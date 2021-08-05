using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordComplexityChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            if (PasswordCheck.CheckPassword(password))
            {
                Console.WriteLine("Password is strong");
            }
            else
            {
                Console.WriteLine("Password is weak");
            }
            Console.ReadLine();
        }
    }
}
