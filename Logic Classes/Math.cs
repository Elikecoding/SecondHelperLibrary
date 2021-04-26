using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    //This is a class to deal with maths for me
    public class Math
    {
        //Adding
        public int Add(int a, int b)
        {
            return a + b;
        }
        
        //Subtracting
        public int Subtract(int a, int b)
        {
            return a - b;
        }

        //Multiplication
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        //Division
        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b; 
        }

        public IEnumerable<int> GetOddNumbers(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                if (i % 2 !=0)
                {
                    yield return i;
                }
            }
        }
    }
}
