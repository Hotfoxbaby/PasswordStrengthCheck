using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        static void DisplayMenu() 
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Type in the number that corresponds with the options below:\n");
            Console.WriteLine("1. Check Passord Strength\n" +
                "2. Exit");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            MenuInput(Console.ReadLine());
        }

        static void MenuInput(string input) 
        {
            if (input.Equals("1"))
            {
                PasswordCheck();
                DisplayMenu();
            } else if (input.Equals("2"))
            {
                Console.WriteLine("Goodbye!");
            }
        }

        static void PasswordCheck()
        {
            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            foreach (string s in PasswordChecker.CheckPassword(password))
            {
                Console.WriteLine(s);
            }
        }
    }
}
