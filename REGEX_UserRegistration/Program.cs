using System;

namespace REGEX_UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");

            Console.WriteLine("Select Options Please :\n" +
                "1)Enter First Name\n" +
                "2)Enter Last Name\n");

            int option = Convert.ToInt32(Console.ReadLine());          

            switch (option)
            {
                case 1:

                    UserRegistration user = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::::");
                    user.ValidFirstName();
                    break;

                case 2:

                    UserRegistration user1 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::::");
                    user1.ValidLastName();
                    break;

                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
        }
    }
}