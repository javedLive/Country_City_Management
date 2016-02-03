using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApps.Model
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public string CountryAbout { get; set; }

        public Country(string countryName, string countryAbout):this()
        {
            CountryName = countryName;
            CountryAbout = countryAbout;
        }

        public Country()
        {

        }
    }
}