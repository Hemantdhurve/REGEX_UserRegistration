using System;

namespace REGEX_UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");
            Start:
            Console.WriteLine("Select Options Please :\n" +
                "1)Enter First Name\n" +
                "2)Enter Last Name\n" + 
                "3)Enter E-Mail Address\n" +
                "4)Enter Phone Number\n" +
                "5)Enter Password Rule No. 1\n" +
                "6)Enter Password Rule No. 2\n" +
                "7)Enter Password Rule No. 3\n" +
                "8)Enter Password Rule No. 4\n" +
                "9)Enter Sample Emails\n");

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

                case 3:
                    UserRegistration user2 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user2.ValidEmail();
                    break;

                case 4:

                    UserRegistration user3 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user3.ValidPhNumber();
                    break;

                case 5:

                    UserRegistration user4 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user4.ValidPasswordRule1();
                    break;

                case 6:

                    UserRegistration user5 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user5.ValidPasswordRule2();
                    break;

                case 7:

                    UserRegistration user6 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user6.ValidPasswordRule3();
                    break;

                case 8:

                    UserRegistration user7 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user7.ValidPasswordRule4();
                    break;

                case 9:

                    UserRegistration user8 = new UserRegistration();
                    Console.WriteLine(":::::::::::::::::::::::::::::;::");
                    user8.ValidSampleEmail();
                    break;



                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
            goto Start;
        }
    }
}