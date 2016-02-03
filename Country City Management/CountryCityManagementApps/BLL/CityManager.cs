using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using CountryCityManagementApps.DAL;
using CountryCityManagementApps.Model;

namespace CountryCityManagementApps.BLL
{
    public class CityManager
    {
        CityGateway cityGateway=new CityGateway();

        public string SaveCity(City city)
        {
            City acity = cityGateway.IsExist(city);
            if (acity == null)
            {
               
                int roweffected = cityGateway.SaveCity(city);
                if (roweffected > 0)
                {
                    return "Save Successfully";
                }
                else
                {
                    return "Save Failed";
                }
            }
            else
            {
                return "City Name must be unique";
            }
            
        }

        public List<CityWiseCountry> GetCityWiseCountry()
        {
            return cityGateway.GetCityWiseCountry();
        }

        public List<CitySearchView> GetAllCitySearchViews()
        {
            return cityGateway.GetAllCitySearchViews();
        }

        public List<CitySearchView> SearchCityByName(string cityNameSearch)
        {
            return cityGateway.SearchCityByName(cityNameSearch);
        }

        public List<CitySearchView> SearchCityByCountry(string countrySearch)
        {
            return cityGateway.SearchCityByCountry(countrySearch);
        }

        public static List<string> GetCompletionListCity(string prefixText, int count)
        {
            return CityGateway.GetCompletionListCity(prefixText, count);
        }
    }
}