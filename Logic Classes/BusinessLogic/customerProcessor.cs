using SecondHelperLibrary.DataClassess;
using SecondHelperLibrary.ModelClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.LogicClasses.BusinessLogic
{
    public static class customerProcessor
    {
        public static int CreateCustomer(int customer_Id, string first_name, string last_name, string email, string phone)
        {
            if (string.IsNullOrEmpty(first_name))
            {
                throw new ArgumentException($"'{nameof(first_name)}' cannot be null or empty.", nameof(first_name));
            }

            if (string.IsNullOrEmpty(last_name))
            {
                throw new ArgumentException($"'{nameof(last_name)}' cannot be null or empty.", nameof(last_name));
            }

            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException($"'{nameof(email)}' cannot be null or empty.", nameof(email));
            }

            if (string.IsNullOrEmpty(phone))
            {
                throw new ArgumentException($"'{nameof(phone)}' cannot be null or empty.", nameof(phone));
            }

            CustomerModel data = new CustomerModel
            {
                customer_Id = customer_Id,
                first_name = first_name,
                last_name = last_name,
                email = email,
                phone = phone

            };

            string sql = @"INSERT INTO testdb.customers (customer_id, first_name, last_name, email, phone)
                            VALUES (@customer_id, @first_name, @last_name, @email, @phone)";

            return DataAccess.SaveData(sql, data);
        }  

        public static List<CustomerModel> LoadCustomers()
        {
            string sql = @"SELECT customer_id, first_name, last_name, email, phone
                           FROM testdb.customers";

            return DataAccess.LoadData<CustomerModel>(sql);
        }

        ////Create query classses for spusers
        //public static List<CustomerModel> SpLoadCustomers()
        //{
        //    string sql = @"spCustomers_GetAll";

        //    return DataAccess.LoadData<CustomerModel>(sql);
        //}


    }
}
