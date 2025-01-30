using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Movies : IEquatable<Movies>
    {
        #region Auto Props
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constractors
        public Movies(int id, string? title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Id} :: {Title} :: {Price}";
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id,Title,Price);
        }
        public bool Equals(Movies? other)
        {
            return this.Id.Equals(other.Id) && this.Title.Equals(other.Title) && this.Price.Equals(other.Price);
        }
        #endregion

    }
}
