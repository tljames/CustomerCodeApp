/* Customer Code App Class
 * This class will seperate the Customer Info into the pieces used to generate the Customer Code.
 * Author: Tim James */

using System;

namespace CustomerCodeApp
{
    class CustomerCodeAppClass
    {
        // Data fields
        private string custFullName;
        private string custBirthdate;
        private int custMonthNumber;
        private string lastName;
        private int birthYear;
        private string purchMonth;

        // Properties
        public string CustFullNames
        {
            get
            {
                return custFullName;
            }
            set
            {
                custFullName = value;
            }
        }
        public string CustBirthdate
        {
            get
            {
                return custBirthdate;
            }
            set
            {
                custBirthdate = value;
            }
        }
        public int CustMonthNumber
        {
            get
            {
                return custMonthNumber;
            }
            set
            {
                custMonthNumber = value;
            }
        }
        // Read only properites
        public string LastName
        {
            get
            {
                ParseName(custFullName);
                return lastName;
            }
        }
        public int BirthYear
        {
            get
            {
                ParseBirthdate(custBirthdate);
                return birthYear;
            }
        }
        public string PurchMonth
        {
            get
            {
                ReturnMonth(custMonthNumber);
                return purchMonth;
            }
        }
        
        // Default Constructor
        public CustomerCodeAppClass()
        {
        }
        
        // Parameterized Constructor
        public CustomerCodeAppClass(string fn, string bd, int mn)
        {
            custFullName = fn;
            CustBirthdate = bd;
            custMonthNumber = mn;
        }
        
        // This method will parse last name from full name
        public void ParseName(string fn)
        {
            string[] nameParts = fn.Split(' ');

            lastName = nameParts[1];
        }
        
        // This method will parse year of birth from birthdate
        public void ParseBirthdate(string bd)
        {
            string[] dateParts = bd.Split('/');
            
            birthYear = Convert.ToInt32(dateParts[2]);
        }
        
        // This method will determine month name from month number
        public void ReturnMonth(int mn)
        {
            string[] monthNames = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            monthNames[0] = monthNames[0].TrimStart('0');

            purchMonth = monthNames[mn - 1];
        }
    }
}
