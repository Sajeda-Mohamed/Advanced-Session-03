using System.Collections;

namespace Assignment
{
    internal class Program
    {
        static Hashtable CountFrequency(int[] arr)
        {
            Hashtable frequency = new Hashtable();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }
                if (!frequency.ContainsKey(arr[i]))
                    frequency.Add(arr[i], count);
            }
            return frequency;
        }
        static string FindHighestValue(Hashtable Note)
        {
            string keyOfmax = null;
            int maxValue = int.MinValue;
            if (Note != null)
            {
                foreach (DictionaryEntry item in Note)
                {
                    if ((int)item.Value > maxValue)
                    {
                        maxValue = (int)item.Value;
                        keyOfmax = (string)item.Key;
                    }
                }
            }
            return keyOfmax;
        }
        static void TargetValue(Hashtable Hash,string target)
        {
            foreach (DictionaryEntry item in Hash)
            {
                if(item.Value == target)
                    Console.WriteLine(item.Key);
            }
        }
        static void CheckDuplicates(int[] arr)
        {
            HashSet<int> list = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                        count++;
                }
                if(count > 1)
                {
                    if (list.Add(arr[i]))
                        Console.WriteLine($"The item is {arr[i]} :: Freqyuency is [{count}]");
                }                   
            }
        }
        static void Main(string[] args)
        {
            #region Part1
            // in the Demo
            #endregion

            #region Part2
            #region Q01-Count Frequency of each Element
            //int[] arr = { 3, 1, 8, 3, 6, 6 };
            //Hashtable hashtable = CountFrequency(arr);
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //    Console.WriteLine($"Element: {entry.Key}, Frequency: {entry.Value}");
            //}
            #endregion

            #region Q02-Highest Value
            //Hashtable NoteBook = new Hashtable();
            //NoteBook.Add("Sajeda", 88);
            //NoteBook.Add("Eman", 98);
            //NoteBook.Add("Ahlam", 99);
            //Console.WriteLine(FindHighestValue(NoteBook));
            #endregion

            #region Q03-Specific targetValue
            //Hashtable Fruits = new Hashtable();
            //Fruits.Add("Key1", "Apple");
            //Fruits.Add("Key2", "Banana");
            //Fruits.Add("Key3", "Apple");
            //TargetValue(Fruits,"Apple");
            #endregion

            #region Q05-DuplicatesInArray
            int[] Numbers = { 2, 3, 2, 4, 4, };
            CheckDuplicates(Numbers);
            #endregion
            #endregion
        }
    }
}
