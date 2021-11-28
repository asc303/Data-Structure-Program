
using System;
using System.Collections.Generic;
using System.Text;
namespace Data_Structure_Programs
{
    class BankingCashCounter
    {
        public const int BANKBAL = 25000;
        public static void MaintainQueue()
        {
            Console.WriteLine("Enter the number of persons in Queue");
            int persons = Convert.ToInt32(Console.ReadLine());
            CustomQueue<int> queue = new CustomQueue<int>();

            for (int i = 1; i <= persons; i++)
            {
                Console.WriteLine("People {0} ", i);
                queue.Enqueu(i);
                WithdrawalAndDeposit();
                queue.Dequeu();
            }
            if (queue.IsEmpty() == 0)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Queue is not Empty");
            }
            Console.WriteLine("Current Balance : " + BANKBAL);
        }
        public static void WithdrawalAndDeposit()
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("Enter Your Opt: Press 1-Withdrawal, 2-Deposit");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter amount to withdrawal");
                        int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
                        int balance = BANKBAL - withdrawalAmount;
                        Console.WriteLine("Bank balance is {0}", +balance);

                        break;
                    case 2:
                        Console.WriteLine("Enter amount to Deposit");
                        int amountDeposit = Convert.ToInt32(Console.ReadLine());
                        int bal = BANKBAL + amountDeposit;
                        Console.WriteLine("Bank balance is {0}", +bal);
                        break;
                }
                Console.WriteLine("Do you want to continue? (Y/N)");
                flag = Console.ReadLine();
            }
        }
    }
}
