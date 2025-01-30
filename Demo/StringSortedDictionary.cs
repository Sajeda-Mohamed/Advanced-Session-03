using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringSortedDictionary : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return y?.CompareTo(x) ?? (x is null ? 0 :1);
        }
    }
}
