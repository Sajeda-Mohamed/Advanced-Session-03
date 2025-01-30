using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Students
    {
        #region Props
        public int Id { get; set; }
        public string? Name { get; set; }
        #endregion

        #region Constractors
        public Students(int id, string? name)
        {
            Id = id;
            Name = name;
        }
        #endregion
    }
}
