using System;
using System.Collections.Generic;
using System.Text;

namespace Software2
{
    public class City
    {
        public int cityId { get; set; }
        public string city { get; set; }
        public int countryId { get; set; }

        public City(string city)
        {
            this.city = city;
        }
    }
}

