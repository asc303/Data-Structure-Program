﻿using Data_Structure_Programs.Utility;
using System;

namespace Data_Structure_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Data Structure Programs Press 1-Un Ordered List, 2- Ordered List, 3- Balanced Paranthesis, 4-Banking Cash Counter, 5-Palindrome Checker, 6-Exit");
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        UnOrderedList.UnOrdered();
                        break;
                
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
