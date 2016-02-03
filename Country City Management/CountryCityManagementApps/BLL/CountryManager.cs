using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CountryCityManagementApps.DAL;
using CountryCityManagementApps.Model;

namespace CountryCityManagementApps.BLL
{
    public class CountryManager
    {
        CountryGateway countryGateway=new CountryGateway();


        public string SaveCountry(Country country)
        {
            Country acountry = countryGateway.IsExist(country);
            if (acountry == null)
            {
                
                int roweffected = countryGateway.SaveCountry(country);
                    if (roweffected > 0)
                    {
                        return "Save successfully";
                    }
                    else
                    {
                        return "Save failed";
                    }
            }
            else
            {
                return "Country Name must be unique";
            }
            
        }

        public List<Country> GetAllCountries()
        {
            return countryGateway.GetAllCountries();
        }

        public List<CountrySearchView> GetAllCountrySearchViews()
        {
            return countryGateway.GetAllCountrySearchViews();
        }

        public List<CountrySearchView> SearchCountryByName(string nameSearch)
        {
            return countryGateway.SearchCountryByName(nameSearch);
        }
        
        public static List<string> GetCompletionList(string prefixText, int count)
        {
            return CountryGateway.GetCompletionList(prefixText,count);
        }


    }
}