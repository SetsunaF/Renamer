using System;
using System.Text.RegularExpressions;

namespace Renamer.Common
{
    public static class StringFunctions
    {
        public static string Clear(this string s)
        {
            return string.Empty;
        }

        public static string AppendBefore(this string s, string text)
        {
            return text + s;
        }

        public static string AppendAfter(this string s, string text)
        {
            return s + text;
        }

        public static string AppendAtPosition(this string s, string text, int n)
        {
            if (n > s.Length) return s.Insert(s.Length, text);
            if (n < 0) return s.Insert(0, text);
            return s.Insert(n, text);
        }

        //String.Insert
        //public static string AppendAtPosition(this string s, int position, string text)

        public static string ExtractNumeric(this string s)
        {
            var result = "";
            foreach (var match in Regex.Matches(s, @"\d+")) result += match;
            return result;
        }

        public static string ExtractAlphanumeric(this string s)
        {
            return Regex.Replace(s, "[^a-zA-Z0-9 -]", "");
        }

        //Clean
        //Strip out all nonalphanumeric characters except whitespaces ( ), periods (.), at symbols (@), and hyphens (-)
        //msdn.microsoft.com/en-us/library/844skk0h(v=vs.110).aspx
        public static string Clean(this string s)
        {
            return Regex.Replace(s, @"[^\w\.\s@-]", "");
        }

        //Returns a number of characters from the left-hand side of a string
        public static string KeepLeft(this string s, int n)
        {
            if (n >= s.Length) return s;
            if (n < 0) return string.Empty;

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += s[i];
            }
            return result;
        }

        //Returns a number of characters from the right-hand side of a string
        public static string KeepRight(this string s, int n)
        {
            if (n >= s.Length) return s;
            if (n < 0) return string.Empty;

            string result = "";
            for (int i = 0; i < n; i++)
            {
                result = s[s.Length-1-i] + result;
            }
            return result;
        }

        //Trims a number of characters from the left hand side of a string
        public static string TrimLeft(this string s, int n)
        {
            return KeepRight(s, s.Length - n);
        }

        //Trims a number of characters from the right hand side of a string
        public static string TrimRight(this string s, int n)
        {
            return KeepLeft(s, s.Length - n);
        }

        //stackoverflow.com/questions/1943273/convert-all-first-letter-to-upper-case-rest-lower-for-each-word
        public static string CapitalizeEachWord(this string s)
        {
            if(s.Length == 0) return string.Empty;

            char[] a = s.ToLower().ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i == 0 || a[i - 1] == ' ' ? char.ToUpper(a[i]) : a[i];
            }

            return new string(a);
        }

        //Capitalize only the first character
        public static string SentenceCase(this string s)
        {
            return s[0].ToString().ToUpper() + s.Substring(1).ToLower();
        }

        //Fill with 0's until reach the length of the specified number
        public static string CompleteZeros(this int n, int max)
        {
            string number = n.ToString();

            int maxDigits = max.ToString().Length;
            int requiredZeros = maxDigits - number.Length;

            for (int i = 0; i < requiredZeros; i++)
            {
                number = "0" + number;
            }
            return number;
        }

        //Case insensitive search and replace
        //stackoverflow.com/questions/6275980/string-replace-by-ignoring-case
        public static string ReplaceInsensitive(this string s, string search, string replacement)
        {
            return Regex.Replace(
                s,
                Regex.Escape(search),
                (replacement),
                RegexOptions.IgnoreCase
            );
        }

        //Perform a Regex match on the current string
        public static bool RegexMatch(this string s, string pattern)
        {
            try
            {
                return new Regex(pattern).IsMatch(s);
                //var match = new Regex(pattern).Match(s);
                //return match.Success;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        //Check if given Regex pattern is valid
        public static bool ValidPattern(string pattern)
        {
            try
            {
                new Regex(pattern);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Add spaces to PascalCase string
        //stackoverflow.com/questions/155303/net-how-can-you-split-a-caps-delimited-string-into-an-array
        public static string SplitPascalCase(this string s)
        {
            return Regex.Replace(
                s, 
                "([a-z](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", 
                "$1 "
            );
        }



    }
}
