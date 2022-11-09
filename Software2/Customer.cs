using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace Software2
{
    class Customer
    {

        //public int customerId{ get; set; } FIXME DELETE MAYBE??
        public string customerName { get; set; } 
        public int addressId { get; set; }
        public int active { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public Customer(string customerName, int active)
        {
            this.customerName = customerName;
            //this.addressId = addressId;
            this.active = active;
            //this.createDate = createDate;
            //this.createdBy = createdBy;
            //this.lastUpdateBy = lastUpdateBy;
        }
    }
}
