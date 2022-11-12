using System;
using System.Collections.Generic;
using System.Text;

namespace Software2
{
    public class Country
    {
        public int countryId { get; set; }
        public string country { get; set; }

        public Country(string country)
        {
            this.country = country;
        }

    }
}