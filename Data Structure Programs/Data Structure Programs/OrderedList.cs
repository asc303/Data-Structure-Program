using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structure_Programs
{
    class OrderedList
    {
        public static void Ordered(int searchNum)
        {
            string text = File.ReadAllText(@"D:\git project\Data - Structure - Program\Data Structure Programs\Data Structure Programs\Utility\NumberList.txt");
            string[] textArry = text.Split(" ");
            CustomLinkedList<int> list = new CustomLinkedList<int>();

            int[] arr = new int[textArry.Length];
            for (int i = 0; i < textArry.Length; i++)
            {
                int a = Convert.ToInt32(textArry[i]);
                arr[i] = a;
            }
            Array.Sort(arr);
            list.Display();

            if (list.Search(searchNum))
            {
                list.DeleteElement(searchNum);
            }
            else
            {
                list.Sort(searchNum);
            }
            string textFile = list.ReturnString();
            File.ReadAllText(@"D:\git project\Data - Structure - Program\Data Structure Programs\Data Structure Programs\Utility\NumberList.txt");
            list.Display();
        }
    }
}
