using System.Globalization;
using System.Collections.Generic;
using System.Collections;

//Representations, Warranties and Disclaimer.
//THIS WORK IS PROVIDED "AS IS", "WHERE IS" AND "AS AVAILABLE", WITHOUT ANY EXPRESS OR IMPLIED
//WARRANTIES OR CONDITIONS OR GUARANTEES. YOU, THE USER, ASSUME ALL RISK IN ITS USE, INCLUDING COPYRIGHT INFRINGEMENT, PATENT
//INFRINGEMENT, SUITABILITY, ETC. AUTHOR EXPRESSLY DISCLAIMS ALL EXPRESS, IMPLIED OR STATUTORY WARRANTIES OR CONDITIONS, INCLUDING
//WITHOUT LIMITATION, WARRANTIES OR CONDITIONS OF MERCHANTABILITY, MERCHANTABLE QUALITY OR FITNESS FOR A PARTICULAR PURPOSE, OR
//ANY WARRANTY OF TITLE OR NON-INFRINGEMENT, OR THAT THE WORK (OR ANY PORTION THEREOF) IS CORRECT, USEFUL, BUG-FREE OR FREE OF
//VIRUSES. YOU MUST PASS THIS DISCLAIMER ON WHENEVER YOU DISTRIBUTE THE WORK OR DERIVATIVE WORKS.

//This is a "derivative work" based on Pascal Ganaye's Article: http://www.codeproject.com/Articles/22978/Implementing-the-NET-IComparer-interface-to-get-a
//The original "work" is subject to CPOL 1.02 License http://www.codeproject.com/info/cpol10.aspx

//Changes:
//Namespace changed to "Renamer.Common.Comparers"
//Class name changed to "Natural"
//"mSortAscending" variable added
//Modified "System.Collections.Generic.IComparer<string>.Compare" to "int Compare"

namespace Renamer.Common.Comparers
{
    public class Natural : IComparer<string>, IComparer 
    {

        private StringParser mParser1;
        private StringParser mParser2;
        private NaturalComparerOptions mNaturalComparerOptions;

        private bool mSortAscending = true;

        private enum TokenType
        {
            Nothing,
            Numerical,
            String
        }

        private class StringParser
        {
            private TokenType mTokenType;
            private string mStringValue;
            private decimal mNumericalValue;
            private int mIdx;
            private string mSource;
            private int mLen;
            private char mCurChar;
            private Natural mNaturalComparer;

            public StringParser(Natural naturalComparer)
            {
                mNaturalComparer = naturalComparer;
            }

            public void Init(string source)
            {
                if (source == null)
                    source = string.Empty;
                mSource = source;
                mLen = source.Length;
                mIdx = -1;
                mNumericalValue = 0;
                NextChar();
                NextToken();
            }

            public TokenType TokenType
            {
                get { return mTokenType; }
            }

            public decimal NumericalValue
            {
                get
                {
                    if (mTokenType == Natural.TokenType.Numerical)
                    {
                        return mNumericalValue;
                    }
                    else
                    {
                        throw new NaturalComparerException("Internal Error: NumericalValue called on a non numerical value.");
                    }
                }
            }

            public string StringValue
            {
                get { return mStringValue; }
            }

            public void NextToken()
            {
                do
                {
                    //CharUnicodeInfo.GetUnicodeCategory 
                    if (mCurChar == '\0')
                    {
                        mTokenType = Natural.TokenType.Nothing;
                        mStringValue = null;
                        return;
                    }
                    else if (char.IsDigit(mCurChar))
                    {
                        ParseNumericalValue();
                        return;
                    }
                    else if (char.IsLetter(mCurChar))
                    {
                        ParseString();
                        return;
                    }
                    else
                    {
                        //ignore this character and loop some more 
                        NextChar();
                    }
                }
                while (true);
            }

            private void NextChar()
            {
                mIdx += 1;
                if (mIdx >= mLen)
                {
                    mCurChar = '\0';
                }
                else
                {
                    mCurChar = mSource[mIdx];
                }
            }

            private void ParseNumericalValue()
            {
                int start = mIdx;
                char NumberDecimalSeparator = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator[0];
                char NumberGroupSeparator = NumberFormatInfo.CurrentInfo.NumberGroupSeparator[0];
                do
                {
                    NextChar();
                    if (mCurChar == NumberDecimalSeparator)
                    {
                        // parse digits after the Decimal Separator 
                        do
                        {
                            NextChar();
                            if (!char.IsDigit(mCurChar) && mCurChar != NumberGroupSeparator)
                                break;

                        }
                        while (true);
                        break;
                    }
                    else
                    {
                        if (!char.IsDigit(mCurChar) && mCurChar != NumberGroupSeparator)
                            break;
                    }
                }
                while (true);
                mStringValue = mSource.Substring(start, mIdx - start);
                if (decimal.TryParse(mStringValue, out mNumericalValue))
                {
                    mTokenType = Natural.TokenType.Numerical;
                }
                else
                {
                    // We probably have a too long value 
                    mTokenType = Natural.TokenType.String;
                }
            }

            private void ParseString()
            {
                int start = mIdx;
                bool roman = (mNaturalComparer.mNaturalComparerOptions == NaturalComparerOptions.RomanNumbers);
                int romanValue = 0;
                int lastRoman = int.MaxValue;
                int cptLastRoman = 0;
                do
                {
                    if (roman)
                    {
                        int thisRomanValue = RomanLetterValue(mCurChar);
                        if (thisRomanValue > 0)
                        {
                            bool handled = false;

                            if ((thisRomanValue == 1 || thisRomanValue == 10 || thisRomanValue == 100))
                            {
                                NextChar();
                                int nextRomanValue = RomanLetterValue(mCurChar);
                                if (nextRomanValue == thisRomanValue * 10 | nextRomanValue == thisRomanValue * 5)
                                {
                                    handled = true;
                                    if (nextRomanValue <= lastRoman)
                                    {
                                        romanValue += nextRomanValue - thisRomanValue;
                                        NextChar();
                                        lastRoman = thisRomanValue / 10;
                                        cptLastRoman = 0;
                                    }
                                    else
                                    {
                                        roman = false;
                                    }
                                }
                            }
                            else
                            {
                                NextChar();
                            }
                            if (!handled)
                            {
                                if (thisRomanValue <= lastRoman)
                                {
                                    romanValue += thisRomanValue;
                                    if (lastRoman == thisRomanValue)
                                    {
                                        cptLastRoman += 1;
                                        switch (thisRomanValue)
                                        {
                                            case 1:
                                            case 10:
                                            case 100:
                                                if (cptLastRoman > 4)
                                                    roman = false;

                                                break;
                                            case 5:
                                            case 50:
                                            case 500:
                                                if (cptLastRoman > 1)
                                                    roman = false;

                                                break;
                                        }
                                    }
                                    else
                                    {
                                        lastRoman = thisRomanValue;
                                        cptLastRoman = 1;
                                    }
                                }
                                else
                                {
                                    roman = false;
                                }
                            }
                        }
                        else
                        {
                            roman = false;
                        }
                    }
                    else
                    {
                        NextChar();
                    }
                    if (!char.IsLetter(mCurChar)) break;
                }
                while (true);
                mStringValue = mSource.Substring(start, mIdx - start);
                if (roman)
                {
                    mNumericalValue = romanValue;
                    mTokenType = Natural.TokenType.Numerical;
                }
                else
                {
                    mTokenType = Natural.TokenType.String;
                }
            }

        }

        public Natural(NaturalComparerOptions NaturalComparerOptions, NaturalComparerDirection Direction)
        {
            if (Direction == NaturalComparerDirection.Descending)
                mSortAscending = false;
            mNaturalComparerOptions = NaturalComparerOptions;
            mParser1 = new StringParser(this);
            mParser2 = new StringParser(this);
        }

        public Natural()
            : this(NaturalComparerOptions.Default, NaturalComparerDirection.Ascending)
        {
        }

        public int Compare(string string1, string string2)
        {
            mParser1.Init(string1);
            mParser2.Init(string2);
            int result;
            do
            {
                if ((mParser1.TokenType == TokenType.Numerical) && (mParser2.TokenType == TokenType.Numerical))
                    // both string1 and string2 are numerical 
                    result = decimal.Compare(mParser1.NumericalValue, mParser2.NumericalValue);
                else
                    result = string.Compare(mParser1.StringValue, mParser2.StringValue);

                if (result != 0)
                {
                    // if the sort direction is decending then reverse the result
                    if (!mSortAscending) result = -result;

                    return result;
                }
                else
                {
                    mParser1.NextToken();
                    mParser2.NextToken();
                }

            } while (!(mParser1.TokenType == TokenType.Nothing && mParser2.TokenType == TokenType.Nothing));
            return 0; // identical
        }




        private static int RomanLetterValue(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }

        public int RomanValue(string string1)
        {
            mParser1.Init(string1);

            if (mParser1.TokenType == TokenType.Numerical)
            {
                return (int)mParser1.NumericalValue;
            }
            else
            {
                return 0;
            }
        }

        int IComparer.Compare(object x, object y)
        {
            return ((System.Collections.Generic.IComparer<string>)this).Compare((string)x, (string)y);
        }
    }

    public class NaturalComparerException : System.Exception
    {

        public NaturalComparerException(string msg)
            : base(msg)
        {
        }
    }

    [System.Flags()]
    public enum NaturalComparerOptions
    {
        None,
        RomanNumbers,
        //DecimalValues <- we could put this as an option 
        //IgnoreSpaces <- we could put this as an option 
        //IgnorePunctuation <- we could put this as an option 
        Default = None
    }

    public enum NaturalComparerDirection
    {
        Ascending,
        Descending
    }
}
