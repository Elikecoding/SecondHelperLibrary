using SecondHelperLibrary.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ServiceClasses
{
    class ProductService
    {
        //This is a service that will return different prices based on different types of customers 
        public float ListPrice { get; set; }

        //Get my price based on the type of customer
        public float GetPrice(Person person)
        {
            if (person.IsGoldCustomer)
            {
                return ListPrice * 0.7f; 
            }
            return ListPrice;
        }

    }
}
