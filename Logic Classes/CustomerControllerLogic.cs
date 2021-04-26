using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses
{
    public class CustomerController
    {
        public ActionResult GetCustomerById (int id)
        {
            //Condition if my custoemr is not found 
            if (id == 0)
            {
                return new NotFound();
            }
            //Condition if my customer is found 
            else
            {
                return new OK();
            }

        }
    }

    //Default Action Result Class
    public class ActionResult
    {
    }

    //Action Result if not found
    public class NotFound : ActionResult
    {
    }

    //Action Result if found
    public class OK : ActionResult
    {
    }
}
