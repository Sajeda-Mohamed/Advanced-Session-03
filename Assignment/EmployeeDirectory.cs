using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmployeeDirectory 
    {
        #region Props
        public int Id { get; set; }
        public string Name { get; set; }
        #endregion

        #region Constractors
        public EmployeeDirectory(int id, string name)
        {
            Id = id;
            Name = name;
        }
        #endregion
    }
    internal class EmployeeComparerAsc : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if(x != 0 && y != 0)
                return x.CompareTo(y);
            else
                return 0;
        }
    }
}
