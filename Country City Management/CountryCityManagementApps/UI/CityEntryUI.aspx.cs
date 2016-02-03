using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementApps.BLL;
using CountryCityManagementApps.Model;

namespace CountryCityManagementApps.UI
{
    public partial class CityEntryUI : System.Web.UI.Page
    {
        CityManager cityManager = new CityManager();
        CountryManager countryManager=new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {               
                counrtyDropDownList.DataTextField = "CountryName";
                counrtyDropDownList.DataValueField = "CountryID";
                counrtyDropDownList.DataSource = countryManager.GetAllCountries();
                counrtyDropDownList.DataBind();
            }
            cityWiseCountryGridView.DataSource = cityManager.GetCityWiseCountry();
            cityWiseCountryGridView.DataBind();
           
        }

        private void TextClear()
        {
            cityNameTextBox.Text = string.Empty;
            cityAboutTextBox.Text = string.Empty;
            noOfDwellersTextBox.Text = null;
            locationTextBox.Text = string.Empty;
            weatherTextBox.Text = string.Empty;
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            
            string cityName = cityNameTextBox.Text;
            string cityAbout = cityAboutTextBox.Text.Replace("'", "''");
            int noOfDwellers = Convert.ToInt32(noOfDwellersTextBox.Text);
            string location = locationTextBox.Text;
            string weather = weatherTextBox.Text;
            int countryID = Convert.ToInt32(counrtyDropDownList.SelectedValue);

            City city=new City(cityName,cityAbout,noOfDwellers,location,weather,countryID);
            messageBoxLabel.Text = cityManager.SaveCity(city);

            cityWiseCountryGridView.DataSource = cityManager.GetCityWiseCountry();
            cityWiseCountryGridView.DataBind();

            TextClear();
        }

        protected void cityWiseCountryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            cityWiseCountryGridView.PageIndex = e.NewPageIndex;
            cityWiseCountryGridView.DataSource = cityManager.GetCityWiseCountry();
            cityWiseCountryGridView.DataBind();
        }
    }
}