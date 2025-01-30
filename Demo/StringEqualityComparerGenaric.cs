using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringEqualityComparerGenaric : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return x?.ToLower().Equals(y.ToLower()) ?? y is null ? true : false;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj?.GetHashCode() ?? 0;
        }
    }
}
