using System;
using System.Collections.Generic;
using System.Text;

namespace Software2
{
    class Address
    {
        //public int addressId { get; set; } DELETE MAYBE?
        public string address { get; set; }
        public string address2 { get; set; }
        public int cityId { get; set; }
        public string postalCode { get; set; }
        public string phone { get; set; }
        public DateTime createDate { get; set; }
        public string createdBy { get; set; }
        public DateTime lastUpdate { get; set; }
        public string lastUpdateBy { get; set; }

        public Address( string address, string address2, string postalCode, string phone)
        {
            //this.addressId = addressId;
            this.address = address;
            this.address2 = address2;
            //this.cityId = cityId;
            this.postalCode = postalCode;
            this.phone = phone;
            //this.createDate = createDate;
            //this.createdBy = createdBy;
            //this.lastUpdate = lastUpdate;
            //this.lastUpdateBy = lastUpdateBy;
        }
    }
}
