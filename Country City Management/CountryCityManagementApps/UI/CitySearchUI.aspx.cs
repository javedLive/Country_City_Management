using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementApps.BLL;

namespace CountryCityManagementApps.UI
{
    public partial class CitySearchUI : System.Web.UI.Page
    {
        CountryManager countryManager=new CountryManager();
        CityManager cityManager = new CityManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {                
                allCountryNameDropDownList.DataTextField = "CountryName";
                allCountryNameDropDownList.DataValueField = "CountryID";
                allCountryNameDropDownList.DataSource = countryManager.GetAllCountries();
                allCountryNameDropDownList.DataBind();

                citySearchGirdView.DataSource = cityManager.GetAllCitySearchViews();
                citySearchGirdView.DataBind();
            }                    
          
       }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetCompletionListCity(string prefixText, int count)
        {
            return CityManager.GetCompletionListCity(prefixText, count);
        }

        protected void allSearchButton_Click(object sender, EventArgs e)
        {
            if (cityNameRadioButton.Checked && countryNameRadioButton.Checked ==false)
            {
                citySearchGirdView.DataSource = cityManager.SearchCityByName(citySearchTextBox.Text);
                citySearchGirdView.DataBind();
            }
            else if (countryNameRadioButton.Checked && cityNameRadioButton.Checked==false)
            {
                citySearchGirdView.DataSource = cityManager.SearchCityByCountry(allCountryNameDropDownList.SelectedItem.Text);
                citySearchGirdView.DataBind();
            }
        }

        protected void citySearchGirdView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            citySearchGirdView.PageIndex = e.NewPageIndex;
            citySearchGirdView.DataSource = cityManager.SearchCityByName(citySearchTextBox.Text);
            citySearchGirdView.DataBind();
        }
    }
}