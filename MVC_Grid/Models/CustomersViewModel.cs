using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Grid.Models
{
    public class CustomersViewModel
    {
        public List<Customer> Customers { get; set; }
        public Customer SelectedCustomer { get; set; }
        public string DisplayMode { get; set; }
    }
}