using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementApps.BLL;
using CountryCityManagementApps.Model;
using System.Text;

namespace CountryCityManagementApps.UI
{
    public partial class CountryEntry : System.Web.UI.Page
    {
        CountryManager countryManager = new CountryManager();
        protected void Page_Load(object sender, EventArgs e)
        {          
                countryGridView.DataSource = countryManager.GetAllCountries();
                countryGridView.DataBind();
                
        }


        protected void submitButton_Click(object sender, EventArgs e)
        {
            

            string countryName = countryNameTextBox.Text;
            string countryAbout = countryAboutTextBox.Text.Replace("'", "''");
                                    
            Country country=new Country(countryName,countryAbout);
            messageBoxLabel.Text = countryManager.SaveCountry(country);

            countryGridView.DataSource = countryManager.GetAllCountries();
            countryGridView.DataBind();

            TextClear();
        }

        protected void countryGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            countryGridView.PageIndex = e.NewPageIndex;
            countryGridView.DataBind();
        }

        private void TextClear()
        {
            countryNameTextBox.Text = string.Empty;
            countryAboutTextBox.Text = string.Empty;
        }
       
    }
}