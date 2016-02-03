using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApps.Model
{
    public class CitySearchView
    {
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string CountryName { get; set; }
        public string CountryAbout { get; set; }

        public CitySearchView(string cityName,string cityAbout,int noOfDwellers,string location,string weather, string countryName,string countryAbout):this()
        {
            CityName = CityName;
            CityAbout = cityAbout;
            NoOfDwellers = noOfDwellers;
            Location = location;
            Weather = weather;
            CountryName = countryName;
            CountryAbout = countryAbout;
        }

        public CitySearchView()
        {

        }

    }
}