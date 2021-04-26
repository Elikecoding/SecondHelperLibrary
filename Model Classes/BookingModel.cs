using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    public class BookingModel
    {
        //This is where I set the properties for my booking class
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime LeavingTime { get; set; }
        public string Reference { get; set; }

    }
}
