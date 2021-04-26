using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class FizzBuzz
    {
        //Return a different string based on a number condition
        public static string GetOutput(int number)
        {
            if (number % 3 == 0 && number % 5 == 0 )
            {
                return "FIZZ BUZZZ";
            }
            else if (number % 3 == 0)
            {
                return "FIZZZ";
            }
            else if (number % 5 == 0)
            {
                return "BUZZZZ";
            }

            return number.ToString();
        }
    }
}
