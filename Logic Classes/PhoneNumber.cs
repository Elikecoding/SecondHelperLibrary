using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class PhoneNumber
    {
        //Get my digits
        public string Area { get; }
        public string Major { get; }
        public string Minor { get; }

        //Arrange them into a phone number
        private PhoneNumber(string area, string major, string minor)
        {
            Area = area;
            Major = major;
            Minor = minor;
        }

        //Parse my digits together 
        public static PhoneNumber Parse(string number)
        {
            if (String.IsNullOrEmpty(number))
            {
                throw new ArgumentException("Phone Number cannot be blank");
            }
            else if (number.Length != 10)
            {
                throw new ArgumentException("Please check the amount of digits in your phone number");
            }
            else if (number.Contains("A") || number.Contains("B") || number.Contains("C") || number.Contains("D") || number.Contains("E") ||
                                     number.Contains("F") || number.Contains("G") || number.Contains("H") || number.Contains("I") || number.Contains("J") ||
                                     number.Contains("K") || number.Contains("L") || number.Contains("M") || number.Contains("N") || number.Contains("O") ||
                                     number.Contains("P") || number.Contains("Q") || number.Contains("R") || number.Contains("S") || number.Contains("T") ||
                                     number.Contains("U") || number.Contains("V") || number.Contains("W") || number.Contains("Y") || number.Contains("X") ||
                                     number.Contains("Z") || number.Contains("/") || number.Contains("*") || number.Contains("-") || number.Contains("+") ||
                                     number.Contains("=") || number.Contains("-") || number.Contains("_") || number.Contains(")") || number.Contains("&") ||
                                     number.Contains("^") || number.Contains("%") || number.Contains("$") || number.Contains("£") || number.Contains("!") ||
                                     number.Contains(";") || number.Contains(":") || number.Contains("'") || number.Contains("@") || number.Contains("[") ||
                                     number.Contains("]") || number.Contains("{") || number.Contains("}") || number.Contains(" "))
            {
                throw new ArgumentException("Phone number cannot have any whites spaces and should only contain numbers");
            }

            var area = number.Substring(0, 3);
            var major = number.Substring(3, 3);
            var minor = number.Substring(6);

            return new PhoneNumber(area, major, minor);

        }

        //Return my new number
        public override string ToString()
        {
            return String.Format($"({Area})-{Major}-{Minor}");
        }

    }
}
