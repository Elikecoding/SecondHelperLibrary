using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.ModelClasses
{
    //Create a model that can be use to map the invoices table in the db
    public class InvoiceModel
    {
        public int invoice_id { get; set; }

        public string number { get; set; }

        public int customer_id { get; set; }

        public decimal invoice_total { get; set; }

        public decimal payment_total { get; set; }

        public DateTime invoice_date { get; set; }

        public DateTime due_date { get; set; }

        public DateTime payment_date { get; set; }

    }
}
