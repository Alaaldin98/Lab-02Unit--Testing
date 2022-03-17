using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02Unit__Testing
{
    public class Class1
    {
        public static string atmBank()
        {
            int amount = 0, deposit, withdraw;
            int choice, pin;
            Console.WriteLine("Enter Your 4 Digit Pin ");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("WELCOME TO BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"\n YOUR CURRENT BALANCE IS Rs : { amount} ");
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw < 10)
                        {
                            Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 10");
                        }
                        else if (withdraw > (amount - 10))
                        {
                            Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                            Console.WriteLine($"\n CURRENT BALANCE IS : {amount}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                        Console.WriteLine($"YOUR TOTAL BALANCE IS Rs : {amount}");
                        break;
                    case 4:
                        Console.WriteLine("\n THANK YOU…");  
                            break;
                }
            }
            Console.WriteLine("\n\n THANKS FOR USING ATM SERVICE");
        }
    }
}
    