using System.Collections;
using System.Linq;

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
        static void TargetValue(Hashtable Hash, string target)
        {
            foreach (DictionaryEntry item in Hash)
            {
                if (item.Value == target)
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
                if (count > 1)
                {
                    if (list.Add(arr[i]))
                        Console.WriteLine($"The item is {arr[i]} :: Freqyuency is [{count}]");
                }
            }
        }
        static void AddStudent(SortedDictionary<int, string> students, int id, string name)
        {
            if (!students.ContainsKey(id))
            {
                students.Add(id, name);
                Console.WriteLine($"{name} added");
            }
            else
                Console.WriteLine($"{name} already exists");
        }
        static string GetStudent(SortedDictionary<int, string> students, int id)
        {
            return students.TryGetValue(id, out string name) ? name : "Not found";
        }
        static void RemoveStudents(SortedDictionary<int, string> students, int id)
        {
            foreach (var item in students)
            {
                if (item.Key == id)
                {
                    students.Remove(id);
                    break;
                }
                else
                    Console.WriteLine("Student not exists");
            }
        }
        static void AddEmployee(SortedList<int, string> employees, int id, string name)
        {
            if (!employees.ContainsKey(id))
            {
                employees.Add(id, name);
                Console.WriteLine($"{name} added");
            }
            else
                Console.WriteLine($"{name} already exists");
        }
        static HashSet<int> FindMissingNums(int[] arr, int N)
        {
            HashSet<int> Original = new HashSet<int>();
            HashSet<int> missingNumbers = new HashSet<int>();
            for (int i = 1; i <= N; i++)
            {
                if (!Original.Contains(i))
                    missingNumbers.Add(i);
            }
            return missingNumbers;
        }
        static  Hashtable Swapping(Hashtable table)
        {
            Hashtable result = new Hashtable();
            if(table != null)
            {
                foreach (DictionaryEntry item in table)
                {
                    result.Add(item.Value, item.Key);
                }
            }
            return result;
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
            //int[] Numbers = { 2, 3, 2, 4, 4, };
            //CheckDuplicates(Numbers);
            #endregion

            #region Q06-SortedDictionary stores Students
            //SortedDictionary<int, string> Students = new SortedDictionary<int, string>();
            //AddStudent(Students, 101, "Sajeda");
            //AddStudent(Students, 102, "Eman");
            //AddStudent(Students, 103, "Nada");
            //RemoveStudents(Students, 101);
            //foreach (KeyValuePair<int, string> item in Students)
            //{
            //    Console.WriteLine(GetStudent(Students, item.Key));
            //}
            #endregion

            #region Q07-Employee Directory
            //SortedList<int, string> employeeDirectory = new SortedList<int, string>(new EmployeeComparerAsc());
            //employeeDirectory.Add(1, "Sajeda");
            //employeeDirectory.Add(3, "Dina");
            //employeeDirectory.Add(2, "Eman");
            //foreach (KeyValuePair<int, string> item in employeeDirectory)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}
            #endregion

            #region Q08-Missing Numbers
            //int[] Numbers = { 1, 2, 4, 6, 7, 9 };
            //HashSet<int> Nums = FindMissingNums(Numbers,20);
            //foreach (int item in Nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q09-Unique Values
            //List<int> Ints = new List<int>();
            //HashSet<int> Numbers = new HashSet<int>();
            //Ints.Add(1);
            //Ints.Add(1);
            //Ints.Add(2);
            //foreach (int item in Ints)
            //{
            //    Numbers.Add(item);
            //}
            //foreach (var item in Numbers)
            //{
            //    if (Ints is not null)
            //        Console.WriteLine(item);
            //}
            #endregion

            #region Q10-Keys and Values are swapped
            //Hashtable NoteBook = new Hashtable();
            //NoteBook.Add("1", "Sajeda");
            //NoteBook.Add("2", "Eman");
            //NoteBook.Add("3", "Malak");
            //NoteBook.Add("4", "Nada");
            //Hashtable NewNote = Swapping(NoteBook);
            //foreach (DictionaryEntry item in NewNote)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}
            #endregion

            #region Q11-Union of 2 Sets
            HashSet<int> UnionSet= new HashSet<int>();
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };
            foreach (int item in arr1)
            {
                UnionSet.Add(item);
            }
            foreach (int item in arr2)
            {
                UnionSet.Add(item);
            }
            foreach (int item in UnionSet)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
