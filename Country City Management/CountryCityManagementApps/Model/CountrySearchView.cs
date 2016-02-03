using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApps.Model
{
    public class CountrySearchView
    {
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }
        public string CityName { get; set; }
        public int NoOfDwellers { get; set; }

        public CountrySearchView(string countryName, string countryAbout, string cityName, int noOfDwellers)
            : this()
        {
            CountryName = countryName;
            CountryAbout = countryAbout;
            CityName = cityName;
            NoOfDwellers = noOfDwellers;
        }

        public CountrySearchView()
        {

        }
        
    }
}