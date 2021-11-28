using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Programs
{
    class PalindromeChecker
    {
        public static void IsPalindrome()
        {
            CustomLinkedList<char> linkedList = new CustomLinkedList<char>();
            Console.WriteLine("Enter a String to Check Palindrome");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                linkedList.Enqueue(input[i]);
            }
            linkedList.Display();
            string reverseWord = linkedList.DequeuePalindromeChecker();
            if (input == reverseWord)
            {
                Console.WriteLine("{0} is a Palindrome!", input);
            }
            else
            {
                Console.WriteLine("{0} is not a Palindrome!", input);
            }
        }
    }
}