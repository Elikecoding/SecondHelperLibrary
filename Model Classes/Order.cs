using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDelivered { get; set; }

        public interface IStorage
        {
            int Store(object obj);
        }
            
    }
}
