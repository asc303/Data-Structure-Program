using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structure_Programs
{
    class UnOrderedList
    {
        public static void UnOrdered()
        {
             string text = File.ReadAllText(@"D:\git project\Data - Structure - Program\Data Structure Programs\Data Structure Programs\Utility\WordFile.txt");
            string[] textArray = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            CustomLinkedList<string> list = new CustomLinkedList<string>();
            for (int i = textArray.Length - 1; i >= 0; i--)
            {
                list.InsertFront(textArray[i]);
            }
            list.Display();
            Console.WriteLine("Enter the String Which You Want to Search");
            string searchStr = Console.ReadLine();
            if (list.Search(searchStr))
            {
                list.DeleteElement(searchStr);
            }
            else
            {
                list.InsertFront(searchStr);
            }
            string textFile = list.ReturnString();
            File.WriteAllText(@"D:\git project\Data - Structure - Program\Data Structure Programs\Data Structure Programs\Utility\WordFile.txt", textFile);
            list.Display();
        }
    }
}
