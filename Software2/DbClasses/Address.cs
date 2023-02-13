using System;
using System.Collections.Generic;
using System.Text;

namespace Software2
{
    class Address
    {
        public int addressId { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }

        public Address( string address, string city, string state, string postalCode, string phone)
        {
            this.address = address;
            this.city = city;
            this.state = state;
            this.postalCode = postalCode;
            this.phone = phone;
        }
    }
}
