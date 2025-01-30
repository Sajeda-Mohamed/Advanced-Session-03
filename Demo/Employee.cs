using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee : IComparable<Employee>
    {
        #region Constractors
        public Employee(int id, string? name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Id} :: {Name} :: {Salary}";
        }

        public int CompareTo(Employee? other)
        {
            return this?.Salary.CompareTo(other.Salary) ?? (other is null ? 0 : -1);
        }
        #endregion
    }
}
