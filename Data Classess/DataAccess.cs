using Dapper;
using MySql.Data.MySqlClient;
using SecondHelperLibrary.ModelClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondHelperLibrary.DataClassess
{
    public class DataAccess
    {
        //Connection string
        public static string GetConnectionString(string connectionName = "testdb")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        //Create an Async method that handles calls to the Db
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        

        //Save to db
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {
                return cnn.Execute(sql, data);
            }
        }

        //Map two objects together and display them
        public static void MapMultipleObjects()
        {
            using (IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {
                string sql = @"SELECT cid.*,ci.* FROM testdb.customers cid
                               LEFT JOIN testdb.invoices ci
                               ON cid.customer_id = ci.customer_id";

                var customers = cnn.Query<CustomerModel, InvoiceModel, CustomerModel>(
                    sql, (customer, invoice) => { customer.customer_Id = invoice.invoice_id; return customer; });

                foreach (var c in customers)
                {
                     Console.WriteLine($"{c.first_name} {c.last_name} email: {c.email}"); 
                }

            }
        }

        //Map two objects together, pass in a paramete then display the two objects
        public static void MapMultipleObjectsWithParameters(string email)
        {
            using(IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {
                //Create an anon object to map my parameter to my prop
                var anonObj = new
                {
                    email
                };

                string sql = @"SELECT cid.*,ci.* FROM testdb.customers cid
                               LEFT JOIN testdb.invoices ci
                               ON cid.customer_id = ci.customer_id
                               WHERE cid.email = @email";

                //Map two models together with their corresponding tables in the db
                var customers = cnn.Query<CustomerModel, InvoiceModel, CustomerModel>(
                    sql, (customer, invoice) => { customer.customer_Id = invoice.invoice_id; return customer; }, anonObj);

                foreach (var c in customers)
                {
                    Console.WriteLine($"{c.first_name} {c.last_name} email: {c.email}");
                }
            }
        }

        //Query the db and retur multiple data sets
        public static void MultipleDataSets()
        {
            using(IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {

                string sql = @"SELECT * FROM testdb.customers;
                               SELECT * FROM testdb.invoices; ";

                List<CustomerModel> customers = null;
                List<InvoiceModel> invoices = null;

                //Must be in same order as your sql statements
                using(var lists = cnn.QueryMultiple(sql))
                {
                    customers = lists.Read<CustomerModel>().ToList();
                    invoices = lists.Read<InvoiceModel>().ToList();
                }

                foreach (var customer in customers)
                {
                   //add displayed info here
                }

                foreach (var invoice in invoices)
                {
                    //add displayed info here
                }

            }
        }

        public static void MultipleDataSetsWithParameters(string email, string invoice_id)
        {
            using (IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {

                string sql = @"SELECT * FROM testdb.customers WHERE email = @email;
                               SELECT * FROM testdb.invoices WHER invoice_id LIKE '%' + @invoice_id + '%'; ";

                List<CustomerModel> customers = null;
                List<InvoiceModel> invoices = null;

                //Create an anon object to map my parameter to my prop
                var anonObj = new
                {
                    email,
                    invoice_id
                };

                //Must be in same order as your sql statements
                using (var lists = cnn.QueryMultiple(sql, anonObj))
                {
                    customers = lists.Read<CustomerModel>().ToList();
                    invoices = lists.Read<InvoiceModel>().ToList();
                }

                foreach (var customer in customers)
                {
                    //add displayed info here
                }

                foreach (var invoice in invoices)
                {
                    //add displayed info here
                }

            }
        }

        //Create a bad transaction then roll back the changes
        public static void RunWithTransaction(string first_name, string last_name)
        {
            using(IDbConnection cnn = new MySqlConnection(GetConnectionString()))
            {
                var c = new DynamicParameters();
                c.Add("@first_name", first_name);
                c.Add("@last_name", last_name);

                string sql = $@"INSERT INTO testdb.customer (first_name, last_name)
                                VALUES (@first_name, @last_name)";

                cnn.Open();
                using(var trans = cnn.BeginTransaction())
                {
                    int recordsUpdated = cnn.Execute(sql, c, trans);

                    Console.WriteLine($"Records updated: {recordsUpdated}");

                    try
                    {
                        cnn.Execute("UPDATE testdb.customer set Id = 1 ", transaction: trans);
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        trans.Rollback();
                    }
                }

            }
        }

    }
}
