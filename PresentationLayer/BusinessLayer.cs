using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;
using Microsoft.Data.SqlClient;

namespace PresentationLayer
{

    internal class BusinessLayer
    {
        private string _connection_string;
        private NorthwindContext dbContext;

        public BusinessLayer()
        {
            _connection_string = "Server=DESKTOP-RKCCVPS\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=true;";
            dbContext = new NorthwindContext(_connection_string);
        }


        public int GetNumCustomers()
        {
            var customerCount = 0;

            customerCount = dbContext.Customers.Count();

            return customerCount;
        }

        public List<string> GetCustomerNames()
        {
            List<string> names = [];

            names = [.. dbContext.Customers.Select(customer => customer.ContactName)];

            return names;
        }

        public List<List<string>> GetCustomerData() 
        {
            List<List<string>> customerData = [];

            foreach (Customer customer in dbContext.Customers)
            {
                List<string> customerRecord = [];

                customerRecord.Add(customer.CustomerId);
                customerRecord.Add(customer.CompanyName);
                customerRecord.Add(customer.ContactName ?? "");
                customerRecord.Add(customer.ContactTitle ?? "");
                customerRecord.Add(customer.Address ?? "");
                customerRecord.Add(customer.City ?? "");
                customerRecord.Add(customer.Region ?? "");
                customerRecord.Add(customer.PostalCode ?? "");
                customerRecord.Add(customer.Country ?? "");
                customerRecord.Add(customer.Phone ?? "");
                customerRecord.Add(customer.Fax ?? "");

                customerData.Add(customerRecord);
            }

            return customerData;
        }

        public string GetConnectionString()
        {
            return _connection_string;
        }

        public void SetConnectionString(string connectionString)
        {
            _connection_string = connectionString;
            dbContext = new NorthwindContext(_connection_string);
        }

        public bool ValidateConnectionString(string connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }

                return true; // valid connection
            }
            catch (Exception)
            {
                return false; // invalid connection
            }
        }

        public int GetNumOrders()
        {
            var orderCount = 0;

            orderCount = dbContext.Orders.Count();

            return orderCount;
        }

        public List<List<string>> GetOrderData()
        {
            List<List<string>> orderData = [];

            foreach (Order order in dbContext.Orders) 
            {
                List<string> orderRecord = []; 

                orderRecord.Add(order.OrderId.ToString());
                orderRecord.Add(order.CustomerId ?? "");
                orderRecord.Add(order.EmployeeId.ToString() ?? "");
                orderRecord.Add(order.OrderDate.ToString() ?? "");
                orderRecord.Add(order.RequiredDate.ToString() ?? "");
                orderRecord.Add(order.ShippedDate.ToString() ?? "");
                orderRecord.Add(order.ShipVia.ToString() ?? "");
                orderRecord.Add(order.Freight.ToString() ?? "   ");
                orderRecord.Add(order.ShipName ?? "");
                orderRecord.Add(order.ShipAddress ?? "");
                orderRecord.Add(order.ShipCity ?? "");
                orderRecord.Add(order.ShipRegion ?? "");
                orderRecord.Add(order.ShipPostalCode ?? "");
                orderRecord.Add(order.ShipCountry ?? "");

                orderData.Add(orderRecord);
            }

            return orderData;
        }

        public int GetNumEmployees()
        {
            var employeeCount = 0;

            employeeCount = dbContext.Employees.Count();

            return employeeCount;
        }

        public List<List<string>> GetEmployeeData() 
        {
            List<List<string>> employeeData = [];

            foreach (Employee employee in dbContext.Employees) 
            {
                List<string> employeeRecord = [];

                employeeRecord.Add(employee.EmployeeId.ToString());
                employeeRecord.Add(employee.LastName);
                employeeRecord.Add(employee.FirstName);
                employeeRecord.Add(employee.Title ?? "");
                employeeRecord.Add(employee.TitleOfCourtesy ?? "");
                employeeRecord.Add(employee.BirthDate.ToString() ?? "");
                employeeRecord.Add(employee.HireDate.ToString() ?? "");
                employeeRecord.Add(employee.Address ?? "");
                employeeRecord.Add(employee.City ?? "");
                employeeRecord.Add(employee.Region ?? "");
                employeeRecord.Add(employee.PostalCode ?? "");
                employeeRecord.Add(employee.Country ?? "");
                employeeRecord.Add(employee.HomePhone ?? "");
                employeeRecord.Add(employee.Salary.ToString() ?? "");
                employeeRecord.Add(employee.Extension ?? "");
                employeeRecord.Add(employee.Photo?.ToString() ?? "");
                employeeRecord.Add(employee.Notes ?? "");
                employeeRecord.Add(employee.ReportsTo.ToString() ?? "");
                employeeRecord.Add(employee.PhotoPath ?? "");

                employeeData.Add(employeeRecord);
            }

            return employeeData;
        }
    }
}
