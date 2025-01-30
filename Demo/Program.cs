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
            Dictionary<string, int> Note = new Dictionary<string, int>(new StringEqualityComparerGenaric());
            Note.Add("Sajeda", 123);
            //Note.Add("sajeda", 123);
            Note.Add("Eman", 456);
            Note.Add("Nada", 789);

            Note.Remove("Sajeda");
            Note.Remove("Eman", out int value);

            //Note.Add("Sajeda", 999);//Invalid : key must be unique
            //if(!Note.ContainsKey("Sajeda"))
            //{
            //    Note.Add("Sajeda", 999);
            //}
            //foreach (KeyValuePair<string,int> item in Note)
            //{
            //    Console.WriteLine($"The item is {item.Key} :: {item.Value}");
            //}
            Note.TryAdd("Sajeda", 999);
            //Console.WriteLine(Note["Yassmine"]);//unsafe
            //if (!Note.ContainsKey("Yassmine"))
            //{
            //    Note.Add("Yassmine", 999);
            //}
            Console.WriteLine(Note.TryGetValue("Yassmine",out int value));
            #endregion
        }
    }
}
