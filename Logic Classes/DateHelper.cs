using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class DateHelper
    {
        //Ternary to return a new date time depending on the current date time
        public static DateTime FirstOfNextMonth(DateTime date)
        {
            return date.Month == 12 ? new DateTime(date.Year + 1, 1, 1) : new DateTime(date.Year, date.Month + 1, 1);
        }
    }
}
