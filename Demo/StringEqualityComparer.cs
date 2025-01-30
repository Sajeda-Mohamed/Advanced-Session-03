using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringEqualityComparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)//Casting
        {
            String?StrX = x as string;
            String?StrY = y as string;
            return StrX?.ToLower().Equals(StrY.ToLower())?? StrY is null? true: false;
        }

        public int GetHashCode(object obj)
        {
            string?str = obj as string;
            return str?.GetHashCode() ?? 0;
        }
    }
}
