using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Renamer.Models;

namespace Renamer.Common
{
    public class FilterEvaluator
    {
        private Main mainForm;

        public FilterEvaluator(Main parent)
        {
            mainForm = parent;
        }

        public void Evaluate(FilterType filterType)
        {
            switch (filterType)
            {
                case FilterType.Clear:
                    mainForm.ApplySimpleFilter(FilterType.Clear);
                    break;

                case FilterType.AddNumbering:
                    mainForm.EvalDialog_Num("Add Numbering", "Position:", FilterType.AddNumbering);
                    break;

                case FilterType.NumberByDirectories:
                    mainForm.EvalDialog_Num("Number By Directories", "Position:", FilterType.NumberByDirectories);
                    break;

                case FilterType.AddMultipleNumbering:
                    mainForm.EvalDialog_Num_Num("Add Numbering (Multiple)", "Position:", "Numbers:", FilterType.AddMultipleNumbering);
                    break;

                case FilterType.SwapOrder:
                    mainForm.EvalDialog_Num("Swap Order", "Position:", FilterType.SwapOrder);
                    break;

                case FilterType.AppendBefore:
                    mainForm.EvalDialog_Str("Append Before", "Text:", FilterType.AppendBefore);
                    break;

                case FilterType.AppendAfter:
                    mainForm.EvalDialog_Str("Append After", "Text:", FilterType.AppendAfter);
                    break;

                case FilterType.AppendAtPosition:
                    mainForm.appendAtPositionToolStripMenuItem_Click(null, null);
                    break;

                case FilterType.AppendFromTextFile:
                    mainForm.appendFromTextFileToolStripMenuItem_Click(null, null);
                    break;

                case FilterType.AppendFromDirectory:
                    mainForm.appendFromDirectory();
                    break;

                case FilterType.KeepNumeric:
                    mainForm.ApplySimpleFilter(FilterType.KeepNumeric);
                    break;

                case FilterType.KeepAlphanumeric:
                    mainForm.ApplySimpleFilter(FilterType.KeepAlphanumeric);
                    break;

                case FilterType.RemoveInvalidCharacters:
                    mainForm.ApplySimpleFilter(FilterType.RemoveInvalidCharacters);
                    break;

                case FilterType.PreserveFromLeft:
                    mainForm.EvalDialog_Num("Preserve from Left", "Count:", FilterType.PreserveFromLeft);
                    break;

                case FilterType.PreserveFromRight:
                    mainForm.EvalDialog_Num("Preserve from Right", "Count:", FilterType.PreserveFromRight);
                    break;

                case FilterType.TrimFromLeft:
                    mainForm.EvalDialog_Num("Trim from Left", "Count:", FilterType.TrimFromLeft);
                    break;

                case FilterType.TrimFromRight:
                    mainForm.EvalDialog_Num("Trim from Right", "Count:", FilterType.TrimFromRight);
                    break;

                case FilterType.Substring:
                    mainForm.EvalDialog_Num_Num("Substring", "Start:", "Length:", FilterType.Substring);
                    break;

                case FilterType.RemoveSubstring:
                    mainForm.EvalDialog_Num_Num("Remove Substring", "Start:", "Length:", FilterType.RemoveSubstring);
                    break;

                case FilterType.CapitalizeEachWord:
                    mainForm.ApplySimpleFilter(FilterType.CapitalizeEachWord);
                    break;

                case FilterType.UpperCase:
                    mainForm.ApplySimpleFilter(FilterType.UpperCase);
                    break;

                case FilterType.LowerCase:
                    mainForm.ApplySimpleFilter(FilterType.LowerCase);
                    break;

                case FilterType.SentenceCase:
                    mainForm.ApplySimpleFilter(FilterType.SentenceCase);
                    break;

                case FilterType.Regex:
                    mainForm.EvalDialog_Str("Regular Expression", "Expression:", FilterType.Regex);
                    break;

                case FilterType.RegexReplace:
                    mainForm.EvalDialog_Str_Str("Regex Replace", "Expression:", "Replace String:", FilterType.RegexReplace);
                    break;

                case FilterType.ReplaceString:
                    mainForm.EvalDialog_Str_Str("Replace String", "Search String:", "Replace String:", FilterType.ReplaceString);
                    break;

                case FilterType.ReplaceCaseInsensitive:
                    mainForm.EvalDialog_Str_Str("Replace String (Case Insensitive)", "Search String:", "Replace String:", FilterType.ReplaceCaseInsensitive);
                    break;

                case FilterType.AddExtension:
                    mainForm.ApplySimpleFilter(FilterType.AddExtension);
                    break;

                case FilterType.RemoveExtension:
                    mainForm.ApplySimpleFilter(FilterType.RemoveExtension);
                    break;

                case FilterType.ParentDirectory:
                    mainForm.EvalDialog_Num("Parent Directory", "Position:", FilterType.ParentDirectory);
                    break;

                case FilterType.OriginalFileName:
                    mainForm.EvalDialog_Num("Original Filename", "Position:", FilterType.OriginalFileName);
                    break;
            }
        }
    }
}
