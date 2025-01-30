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
        static void Main(string[] args)
        {
            #region Part1
            // in the Demo
            #endregion

            #region Part2
            #region Q01-Count Frequency of each Element
            int[] arr = { 3, 1, 8, 3, 6, 6 };
            Hashtable hashtable = CountFrequency(arr);
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Element: {entry.Key}, Frequency: {entry.Value}");
            }
            #endregion
            #endregion
        }
    }
}
