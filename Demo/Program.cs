using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Genaric Collection [Hashtable]
            Hashtable Note = new Hashtable(new StringEqualityComparer());
            Note.Add("Sajeda", 123);
            Note.Add("Eman", 456);
            Note.Add("Nada", 789);
            foreach (DictionaryEntry i in Note)
            {
                Console.WriteLine($"The Key is {i.Key}, The Value is {i.Value}");
            }
            if (Note.ContainsKey("Yasmine"))
            {
                Console.WriteLine(Note["Yasmine"]);
            }
            #endregion

           
        }
    }
}
