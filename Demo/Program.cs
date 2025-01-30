using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Genaric Collection [Hashtable]
            //Hashtable Note = new Hashtable(new StringEqualityComparer());
            //Note.Add("Sajeda", 123);
            //Note.Add("Eman", 456);
            //Note.Add("Nada", 789);
            //foreach (DictionaryEntry i in Note)
            //{
            //    Console.WriteLine($"The Key is {i.Key}, The Value is {i.Value}");
            //}
            //if (Note.ContainsKey("Yasmine"))
            //{
            //    Console.WriteLine(Note["Yasmine"]);
            //}
            #endregion

            #region Genaric Collection [Dictionary]
            //Dictionary<string, int> Note = new Dictionary<string, int>(new StringEqualityComparerGenaric());
            //Note.Add("Sajeda", 123);
            ////Note.Add("sajeda", 123);
            //Note.Add("Eman", 456);
            //Note.Add("Nada", 789);

            //Note.Remove("Sajeda");
            //Note.Remove("Eman", out int value);

            //Note.Add("Sajeda", 999);//Invalid : key must be unique
            //if(!Note.ContainsKey("Sajeda"))
            //{
            //    Note.Add("Sajeda", 999);
            //}
            //foreach (KeyValuePair<string,int> item in Note)
            //{
            //    Console.WriteLine($"The item is {item.Key} :: {item.Value}");
            //}
            //Note.TryAdd("Sajeda", 999);
            //Console.WriteLine(Note["Yassmine"]);//unsafe
            //if (!Note.ContainsKey("Yassmine"))
            //{
            //    Note.Add("Yassmine", 999);
            //}
            //Console.WriteLine(Note.TryGetValue("Yassmine",out int value));
            #endregion

            #region Genaric Collection [Sorted Dictionary]
            //SortedDictionary<string, int> Note = new SortedDictionary<string, int>(new StringSortedDictionary());

            //Note.Add("Sajeda", 111);
            //Note.Add("Nada", 222);
            //Note.Add("Eman", 333);
            //foreach (KeyValuePair<string,int> i in Note)
            //{
            //    Console.WriteLine($"{i.Key} ::: {i.Value}");
            //}
            //SortedDictionary<Employee, string> Employees = new SortedDictionary<Employee, string>(new EmployeeCompareAsc());
            //Employees.Add(new Employee(10, "Sajeda", 8000),"10,Sajeda,8000");
            //Employees.Add(new Employee(20, "Nada", 5000), "20, Nada, 5000");
            //Employees.Add(new Employee(30, "Eman", 6000), "30, Eman, 6000");

            //foreach (KeyValuePair<Employee,string> emp in Employees)
            //{
            //    Console.WriteLine($"{emp.Key}");
            //}
            #endregion

            #region Genaric Collection [HashSet]
            //HashSet<int> Numbers = new HashSet<int>();
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //foreach (int item in Numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //HashSet<Movies> movies = new HashSet<Movies>();
            //movies.Add(new Movies(101, "Avatar", 250));
            //movies.Add(new Movies(202, "Mission Impossible", 350));
            //movies.Add(new Movies(202, "Mission Impossible", 350));
            //movies.Add(new Movies(303, "Harry Potter", 150));

            //foreach (Movies movie in movies)
            //{
            //    Console.WriteLine(movie);
            //}
            #endregion
        }
    }
}
