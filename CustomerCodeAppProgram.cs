/* Customer Code App
 * This app will determine a customer code mailing label using: Customer Name, Birthdate,
 * Month Subscription was purchased, and Zip Code.
 * Author: Tim James */

using System;

namespace CustomerCodeApp
{
    class CustomerCodeAppProgram
    {
        static void Main()
        {
            string fullName;
            string birthdate;
            int monthNumber;
            int zipCode;
            string inValue;
            char anotherCode = 'N';

            DisplayInstructions();


            do
            {
                GetCustomerInfo(out fullName, out birthdate, out monthNumber, out zipCode);
                
                CustomerCodeAppClass code = new CustomerCodeAppClass(fullName, birthdate, monthNumber);

                Console.WriteLine("The Customer Code is: {0}{1}{2}{3}", code.LastName, code.BirthYear % 100, code.PurchMonth, zipCode % 100);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Would you like to determine another Customer Code? (y or n)");
                inValue = Console.ReadLine();
                anotherCode = Convert.ToChar(inValue);
                Console.Clear();
            }
            while ((anotherCode == 'Y') || (anotherCode == 'y'));

        }
        // This method will display the instructions
        static void DisplayInstructions()
        {
            Console.WriteLine("Welcome to the Customer Code App!!");
            Console.WriteLine("**********************************");
            Console.WriteLine();
            Console.WriteLine("This app will determine the Customer Code for the mailing label");
            Console.WriteLine("that will appear on the Magazine.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to enter Customer Info...");
            Console.ReadKey();
            Console.Clear();
        }
        // This method will allow the user to enter the Customer Information
        public static void GetCustomerInfo(out string fullName, out string birthdate, out int monthNumber, out int zipCode)
        {
            Console.WriteLine("Please Enter-");
            Console.Write("Customer Name (First Last): ");
            fullName = Console.ReadLine();
            Console.Write("Customer Birthdate (mm/dd/yyyy): ");
            birthdate = Console.ReadLine();
            Console.Write("Date of Month subscription purchased (Number of Month): ");
            monthNumber = int.Parse(Console.ReadLine());
            Console.Write("Customer Zip Code (12345): ");
            zipCode = int.Parse(Console.ReadLine());
            Console.Clear();
        }
    }
}
