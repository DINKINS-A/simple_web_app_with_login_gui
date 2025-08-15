using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Models;

namespace PresentationLayer
{

    internal class BusinessLayer
    {
        private NorthwindContext dbContext;

        public BusinessLayer() 
        {
            dbContext = new NorthwindContext("Server=DESKTOP-RKCCVPS\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=true;");
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
    }
}
