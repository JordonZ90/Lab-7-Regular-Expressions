using System;
using System.Text.RegularExpressions;

namespace Lab7RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            string nameInput;
            Console.WriteLine("what is your first and last name? ");
            nameInput = Console.ReadLine();
            NameCheckRegex(nameInput);

            string emailInput;
            Console.WriteLine("What is your email? ");
            emailInput = Console.ReadLine();
            EmailCheckRegex(emailInput);

            string phoneNumberInput;
            Console.WriteLine("What is your number? ");
            phoneNumberInput = Console.ReadLine();
            PhoneCheckRegex(phoneNumberInput);

            string dateTimeInput;
            Console.WriteLine("What is the date today? : mm-dd-yyyy ");
            dateTimeInput = Console.ReadLine();
            DateTimeCheckRegex(dateTimeInput);

        }
        public static void NameCheckRegex(string nameInput)
        {

            if (Regex.IsMatch(nameInput, @"^[\w'\-,.][^0-9_!¡?÷?¿/\\+=@#$%ˆ&*(){}|~<>;:[\]]{2,}$") == true)
            {
                Console.WriteLine("Your name is real! ");
            }
            else
            {
                Console.WriteLine("Your name is not a real name, sorry! ");
            }

        }
        public static void EmailCheckRegex(string emailInput)
        {
            if (Regex.IsMatch(emailInput, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$") == true)
            {
                Console.WriteLine("Your email is correctly formatted! ");
            }
            else
            {
                Console.WriteLine("Your email is not correctly formatted! ");
            }
        }
        public static void PhoneCheckRegex(string phoneNumberInput)
        {
            if ((Regex.IsMatch(phoneNumberInput, @"^[2-9]\d{2}-\d{3}-\d{4}") == true))
            {
                Console.WriteLine("Your phone number is correct! ");
            }
            else
            {
                Console.WriteLine("You don't know your own number!?! ");
            }
        }
        public static void DateTimeCheckRegex(string dateTimeInput)
        {
            if ((Regex.IsMatch(dateTimeInput, @"^((0|1)\d{1})-((0|1|2)\d{1})-((19|20)\d{2})") == true))
            {
                Console.WriteLine("The date you gave is formatted correctly! ");
            }
            else
            {
                Console.WriteLine("The date you gave is formatted incorrectly!!! ");
            }
        }
    }
}
