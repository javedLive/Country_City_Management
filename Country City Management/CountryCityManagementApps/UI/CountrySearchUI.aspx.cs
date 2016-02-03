using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using CountryCityManagementApps.BLL;

namespace CountryCityManagementApps.UI
{
    public partial class CountrySearchUI : System.Web.UI.Page
    {

         CountryManager countryManager = new CountryManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                countrySearchGridView.DataSource = countryManager.GetAllCountrySearchViews();
                countrySearchGridView.DataBind();                
            }

        }

        [System.Web.Script.Services.ScriptMethod()]
        [System.Web.Services.WebMethod]
        public static List<string> GetCompletionList(string prefixText, int count)
        {
            return CountryManager.GetCompletionList(prefixText, count);
        }


        protected void CountrySearchButton_Click(object sender, EventArgs e)
        {
            countrySearchGridView.DataSource = countryManager.SearchCountryByName(countrySearchTextBox.Text);
            countrySearchGridView.DataBind();
        }

        protected void countrySearchGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            countrySearchGridView.PageIndex = e.NewPageIndex;
            countrySearchGridView.DataSource = countryManager.SearchCountryByName(countrySearchTextBox.Text);
            countrySearchGridView.DataBind();
        }

       

        
    }
}