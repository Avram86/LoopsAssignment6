using System;

namespace LoopsAssignment6
{
    class Program
    {
        public static void Main(string[] args)
        {
             string userName = "ADMIN";
             string password = "123";


            //ForLoop(userName, password);
            WhileLoop(userName, password);
            //DoWhileLoop(userName, password);
        }

        public  static void ForLoop(string userName, string password)
        {
            for (int i = 0; i < 3; i++)
            {

                Console.Write("Please enter the user: ");
                string user = Console.ReadLine();

                Console.Write("Please enetr the password: ");
                string pass = Console.ReadLine();

                if (string.Equals(user, userName, StringComparison.InvariantCultureIgnoreCase) && string.Equals(pass, password, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Welcome, {user}!");
                    break;
                }
                else
                {
                    if (i == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Must work on your memory!!!!!");
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }

            }
        }

        public static void WhileLoop(string userName, string password)
        {
            string user = "";
            string pass = "";
            int i = 5;

            while (i >= 0)
            {
                Console.WriteLine("Please authenticate:");

                Console.Write("Please enter the user: ");
                user = Console.ReadLine();

                Console.Write("Please enetr the password: ");
                pass = Console.ReadLine();

                if (string.Equals(user, userName, StringComparison.InvariantCultureIgnoreCase) && string.Equals(pass, password, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Welcome, {user}!");
                    break;
                }
                else
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Must work on your memory!!!!!");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Try again!");
                    }
                }

                i--;
            }
        }

        public static void DoWhileLoop(string userName, string password)
        {
            string user = "";
            string pass = "";
            int i = 5;

            do
            {
                Console.WriteLine("Please authenticate:");

                Console.Write("Please enter the user: ");
                 user = Console.ReadLine();

                Console.Write("Please enetr the password: ");
                 pass = Console.ReadLine();

                if (string.Equals(user, userName, StringComparison.InvariantCultureIgnoreCase) && string.Equals(pass, password, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Welcome, {user}!");
                    break;
                }
                if (i == 0)
                {
                    Console.WriteLine("Must work on your memory!!!!!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Try again!");
                }

                i--;

            } while (i>=0);
            
            
        }
    }
}
