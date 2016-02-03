using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;
using CountryCityManagementApps.Model;

namespace CountryCityManagementApps.DAL
{

    public class CountryGateway
    {
        private string connectionString =
            WebConfigurationManager.ConnectionStrings["CountryManagementSystemString"].ConnectionString;

        public int SaveCountry(Country country)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Country VALUES ('" + country.CountryName + "','" + country.CountryAbout + "')";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int roweffected = command.ExecuteNonQuery();
            connection.Close();

            return roweffected;
        }

        public List<Country> GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Country ORDER BY CountryName ASC";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Country> countries = new List<Country>();

            while (reader.Read())
            {
              
                Country country = new Country();

                country.CountryID = (int) reader["CountryID"];
                
                country.CountryName = reader["CountryName"].ToString();
                country.CountryAbout = reader["CountryAbout"].ToString();

                countries.Add(country);
            }


            reader.Close();
            connection.Close();

            return countries;
        }

        public Country IsExist(Country country)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Country WHERE CountryName='" + country.CountryName + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            Country aCountry = null;
            if (reader.HasRows)
            {
                reader.Read();
                aCountry = new Country();
                aCountry.CountryID = (int) reader["CountryID"];
                aCountry.CountryName = reader["CountryName"].ToString();
                aCountry.CountryAbout = reader["CountryAbout"].ToString();
            }
            reader.Close();
            connection.Close();

            return aCountry;
        }

        public List<CountrySearchView> GetAllCountrySearchViews()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM CountrySearchView";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<CountrySearchView> countrySearchViews = new List<CountrySearchView>();

            while (reader.Read())
            {
                CountrySearchView countrySearchView = new CountrySearchView();
                countrySearchView.CountryName = reader["CountryName"].ToString();
                countrySearchView.CountryAbout = reader["CountryAbout"].ToString();
                countrySearchView.CityName = reader["CityName"].ToString();
                countrySearchView.NoOfDwellers = (int) reader["NoOfDwellers"];


                countrySearchViews.Add(countrySearchView);

            }
            reader.Close();
            connection.Close();

            return countrySearchViews;
        }

        public List<CountrySearchView> SearchCountryByName(string nameSearch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CountrySearchView WHERE CountryName  LIKE '%" + nameSearch + "%'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<CountrySearchView> countrySearchViews = new List<CountrySearchView>();

            while (reader.Read())
            {
                CountrySearchView aCountrySearchView=new CountrySearchView();

                aCountrySearchView.CountryName = reader["CountryName"].ToString();
                aCountrySearchView.CountryAbout = reader["CountryAbout"].ToString();
                aCountrySearchView.CityName = reader["CityName"].ToString();
                aCountrySearchView.NoOfDwellers = (int)reader["NoOfDwellers"];

                countrySearchViews.Add(aCountrySearchView);
            }
            reader.Close();
            connection.Close();
            return countrySearchViews;
        }
       

        public static List<string> GetCompletionList(string prefixText, int count)
        {
             string connectionString =
            WebConfigurationManager.ConnectionStrings["CountryManagementSystemString"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
                
              string query="select CountryName from Country where " + "CountryName like @Search + '%'";
              SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Search", prefixText);
                    command.Connection = connection;
                    connection.Open();
                    List<string> countryNames = new List<string>();
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            countryNames.Add(sdr["CountryName"].ToString());
                        }
                    }
                    connection.Close();
                    return countryNames;


                }

            }


        }

       
      
    






