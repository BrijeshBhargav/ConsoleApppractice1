using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApppractice1
{
    internal class atm
    {
          public static void demo2 ()
        {
            int amount = 10000, deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("Enter Your 4 Digit Pin ");
            pin = Convert.ToInt32 (Console.ReadLine());
            while (true)
            {
                Console.WriteLine("WELCOME TO SBI BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("--------------\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                     Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs :",+ amount);
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        withdraw = int.Parse(Console.ReadLine());
                        
                            amount = amount - withdraw;
                            Console.WriteLine("\nPLEASE COLLECT YOUR CASH");
                            Console.WriteLine("\n CURRENT BALANCE IS Rs :", +amount);
                        
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;

                        Console.WriteLine("YOUR TOTAL BALANCE IS Rs : "+ amount);
                        break;
                    case 4:
                        Console.WriteLine(" THANK YOU"); 
                            break;
                }
                Console.WriteLine(" thanks for using atm services");
            }
           
        }
    }
}

