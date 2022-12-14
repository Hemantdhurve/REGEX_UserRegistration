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

        //UC4

        public void ValidPhNumber()
        {
            Console.WriteLine("Please Enter Phone Number :");
            string data = Console.ReadLine();

            string pattern = "^[0-9]{2}[ ][6-9]{1}[0-9]{9}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Phone Number is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Phone Number is Invalid");
                Console.ResetColor();
            }
        }

        //UC5

        public void ValidPasswordRule1()
        {
            Console.WriteLine("Please Enter Password Rule 1 :");
            string data = Console.ReadLine();

            string pattern = "^[a-zA-Z]{8,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 1 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 1 Invalid");
                Console.ResetColor();
            }
        }

        //UC6

        public void ValidPasswordRule2()
        {
            Console.WriteLine("Please Enter Password Rule 2 :");
            string data = Console.ReadLine();

            string pattern = "^(?=.*[A-Z])[a-zA-Z]{8,}$";                      //(?=.*)  Look Ahead used for at least one time            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 2 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 2 Invalid");
                Console.ResetColor();
            }
        }

        //UC7

        public void ValidPasswordRule3()
        {
            Console.WriteLine("Please Enter Password Rule 3 :");
            string data = Console.ReadLine();

            string pattern = "^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 3 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 3 Invalid");
                Console.ResetColor();
            }
        }

        //UC8

        public void ValidPasswordRule4()
        {
            Console.WriteLine("Please Enter Password Rule 4 :");
            string data = Console.ReadLine();

            string pattern= "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 4 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 4 Invalid");
                Console.ResetColor();
            }
        }

        //UC9

        public void ValidSampleEmail()
        {
            Console.WriteLine("Please Enter Sample Email :");
            string data = Console.ReadLine();

            string pattern = "^[a-zA-Z0-9]+([#$%+_-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

            //creating object of the Regex superclass

            Regex regobj = new Regex(pattern);

            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Sample Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sample Email is Invalid");
                Console.ResetColor();
            }
        }
    }
}
