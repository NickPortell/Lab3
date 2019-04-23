using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            String number;
            String response = "y", user;


            Console.WriteLine("Hello! What can I call you?");
            user = Console.ReadLine();

            Console.WriteLine("Oh, hello " + user + "!");

            while (response == "y")
            {

                Console.WriteLine("Please enter an integer value between 1 and 100. ");
                number = Console.ReadLine();


                if (int.TryParse(number, out num) == false)
                {
                    Console.WriteLine("That is not a valid number.");
                }
                else if (int.TryParse(number, out num) == true && (num > 100 || num <= 0))
                {
                    Console.WriteLine("That is not a valid number.");
                }
                else if (int.TryParse(number, out num) == true && (num <= 100 && num > 0))
                {
                    if (num % 2 == 1)
                    {
                        Console.WriteLine(user + " " + num + " is Odd.");
                    }
                    else if (num % 2 == 0 && num >= 2 && num <= 25)
                    {
                        Console.WriteLine("Sorry " + user + ", " + num + " is Even and less than 25.");
                    }
                    else if (num % 2 == 0 && num >= 26 && num <= 60)
                    {
                        Console.WriteLine("Even. isn't that great, " + user + "?");
                    }
                    else if (num % 2 == 0 && num > 60)
                    {
                        Console.WriteLine("Wow, " + user + " " + num + " is Even! Can you believe it?!");
                    }
                    else if (num % 2 == 1 && num > 60)
                    {
                        Console.WriteLine(user + ", " + num + " is Odd... How sad..");
                    }
                    else
                    {
                        Console.WriteLine("Mr. " + user + ", I don't feel soo good...");
                    }
                }
                else
                    return;

                    Console.WriteLine("Would you like to continue? y or n: ");
                    response = Console.ReadLine();
            }
        }
    }
}
