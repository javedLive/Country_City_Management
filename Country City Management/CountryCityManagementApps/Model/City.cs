using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountryCityManagementApps.Model
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CityAbout { get; set; }
        public int NoOfDwellers { get; set; }
        public string Location { get; set; }
        public string Weather { get; set; }
        public int CountryID { get; set; }

        public City(string cityName,string cityAbout, int noOfDwellers, string location, string weather,int countryID):this()
        {
            CityName = cityName;
            CityAbout = cityAbout;
            NoOfDwellers = noOfDwellers;
            Location = location;
            Weather = weather;
            CountryID = countryID;
        }

        public City()
        {

        }
    }
}