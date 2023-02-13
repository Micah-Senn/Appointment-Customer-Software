using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Software2.DbClasses
{
    class CustomerInfo
    {
        public static BindingList<CustomerInfo> Info = new BindingList<CustomerInfo>();
        public int customerId { get; set; }
        public string customerName { get; set; }
        public string add1 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public int active { get; set; }
        public CustomerInfo(int customerId, string customerName, string add1, string city, string state, string zip, string phone, int active)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.active = active;
            this.add1 = add1;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
        }
        public static void AddCustomerInfo(CustomerInfo info)
        {
            Info.Add(info);
        }
    }
}
