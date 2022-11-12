using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Text;

namespace Software2
{
    public class Customer
    {
        public string customerName { get; set; }
        public int active { get; set; }



        public Customer(string customerName, int active)
        {
            this.customerName = customerName;
            this.active = active;
        }
    }
}
