using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Renamer.Common.Comparers
{
    public class Descending:IComparer
    {
        public Descending()
        { }

        public int Compare(object x, object y)
        {
            //return new NumericComparer().Compare(x, y) * -1;
            return -((IComparable)x).CompareTo(y);
        }
    }
}
