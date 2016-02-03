using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApps.Model
{
    public class CityWiseCountry
    {
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public string CountryName { get; set; }
        

        public CityWiseCountry(string cityName,string cityAbout,int noOfDwellers,string location, string weather,string countryName):this()
        {
            CityName = cityName;
            CityAbout = cityAbout;
            NoOfDwellers = noOfDwellers;
            Location = location;
            Weather = weather;
            CountryName = countryName;
        }

        public CityWiseCountry()
        {

        }
    }

    
}