using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomerController : ApiController
    {
        private ApplicationDbContext _context;  

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }
        // Get /api/customer
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
