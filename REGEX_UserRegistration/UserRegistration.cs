using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace REGEX_UserRegistration
{
    public class UserRegistration
    {
        //UC1
        public void ValidFirstName()
        {
            Console.WriteLine("Please Enter First Name :");
            string data=Console.ReadLine();

            string pattern = "^[A-Z][a-z]{2,10}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("First Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("First Name is Invalid");
                Console.ResetColor();
            }
        }

        //UC2
        public void ValidLastName()
        {
            Console.WriteLine("Please Enter Last Name :");
            string data = Console.ReadLine();

            string pattern = "^[A-Z][a-z]{2,12}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Last Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Last Name is Invalid");
                Console.ResetColor();
            }
        }

        //UC3

        public void ValidEmail()
        {
            Console.WriteLine("Please Enter Email :");
            string data = Console.ReadLine();

            string pattern = "^[a-zA-z]{3,}([.][a-zA-Z]{3,})[@][a-z]{2}[.][a-z]{2}([.][a-z]{2})$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email is Invalid");
                Console.ResetColor();
            }
        }
    }
}
