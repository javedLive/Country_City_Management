using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using CountryCityManagementApps.Model;

namespace CountryCityManagementApps.DAL
{
    public class CityGateway
    {
        string connectionString =
            WebConfigurationManager.ConnectionStrings["CountryManagementSystemString"].ConnectionString;

        public int SaveCity(City city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"INSERT INTO City VALUES('" + city.CityName + "','" + city.CityAbout + "','" + city.NoOfDwellers + "','" + city.Location + "','" + city.Weather + "'," + city.CountryID + ")";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int roweffected = command.ExecuteNonQuery();
            connection.Close();

            return roweffected;
        }

        public City IsExist(City city)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM City WHERE CityName='" + city.CityName + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            City aCity = null;
            if (reader.HasRows)
            {
                reader.Read();
                aCity = new City();
                //aCity.CountryID = (int)reader["CountryID"];
                //aCity.CountryName = reader["CountryName"].ToString();
                //aCity.CountryAbout = reader["CountryAbout"].ToString();
            }
            reader.Close();
            connection.Close();

            return aCity;
        }

        public List<CityWiseCountry> GetCityWiseCountry()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Select * from CityWiseCountry ORDER BY CityName ASC";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<CityWiseCountry> cityWiseCountries = new List<CityWiseCountry>();

            while (reader.Read())
            {
                CityWiseCountry cityWiseCountry = new CityWiseCountry();
                cityWiseCountry.CityName = reader["CityName"].ToString();
                cityWiseCountry.CityAbout = reader["CityAbout"].ToString();
                cityWiseCountry.NoOfDwellers = (int)reader["NoDwellers"];
                cityWiseCountry.Location = reader["Location"].ToString();
                cityWiseCountry.Weather = reader["Weather"].ToString();
                cityWiseCountry.CountryName = reader["CountryName"].ToString();

                cityWiseCountries.Add(cityWiseCountry);

            }
            reader.Close();
            connection.Close();

            return cityWiseCountries;
        }

        public List<CitySearchView> GetAllCitySearchViews()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM CitySearchView ORDER BY CityName ASC";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<CitySearchView> citySearchViews = new List<CitySearchView>();

            while (reader.Read())
            {
                CitySearchView aCitySearchView=new CitySearchView();
                aCitySearchView.CityName = reader["CityName"].ToString();
                aCitySearchView.CityAbout = reader["CityAbout"].ToString();
                aCitySearchView.NoOfDwellers = (int)reader["NoDwellers"];
                aCitySearchView.Location = reader["Location"].ToString();
                aCitySearchView.Weather = reader["Weather"].ToString();
                aCitySearchView.CountryName = reader["CountryName"].ToString();
                aCitySearchView.CountryAbout = reader["CountryAbout"].ToString();
              
                citySearchViews.Add(aCitySearchView);
            }
            reader.Close();
            connection.Close();

            return citySearchViews;
        }

        public List<CitySearchView> SearchCityByName(string cityNameSearch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CitySearchView WHERE CityName  LIKE '%" + cityNameSearch + "%'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<CitySearchView> citySearchViews = new List<CitySearchView>();

            while (reader.Read())
            {
                CitySearchView aCitySearchView = new CitySearchView();

                aCitySearchView.CityName = reader["CityName"].ToString();
                aCitySearchView.CityAbout = reader["CityAbout"].ToString();
                aCitySearchView.NoOfDwellers = (int)reader["NoDwellers"];
                aCitySearchView.Location = reader["Location"].ToString();
                aCitySearchView.Weather = reader["Weather"].ToString();
                aCitySearchView.CountryName = reader["CountryName"].ToString();
                aCitySearchView.CountryAbout = reader["CountryAbout"].ToString();

                citySearchViews.Add(aCitySearchView);
            }
            reader.Close();
            connection.Close();
            return citySearchViews;
        }

        public List<CitySearchView> SearchCityByCountry(string countrySearch)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM CitySearchView WHERE CountryName  LIKE '%" + countrySearch + "%'";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<CitySearchView> citySearchViews = new List<CitySearchView>();

            while (reader.Read())
            {
                CitySearchView aCitySearchView = new CitySearchView();

                aCitySearchView.CityName = reader["CityName"].ToString();
                aCitySearchView.CityAbout = reader["CityAbout"].ToString();
                aCitySearchView.NoOfDwellers = (int)reader["NoDwellers"];
                aCitySearchView.Location = reader["Location"].ToString();
                aCitySearchView.Weather = reader["Weather"].ToString();
                aCitySearchView.CountryName = reader["CountryName"].ToString();
                aCitySearchView.CountryAbout = reader["CountryAbout"].ToString();

                citySearchViews.Add(aCitySearchView);
            }
            reader.Close();
            connection.Close();
            return citySearchViews;
        }

        public static List<string> GetCompletionListCity(string prefixText, int count)
        {
             string connectionString =
            WebConfigurationManager.ConnectionStrings["CountryManagementSystemString"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
                
              string query="select CityName from City where " + "CityName like @Search + '%'";
              SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Search", prefixText);
                    command.Connection = connection;
                    connection.Open();
                    List<string> countryNames = new List<string>();
                    using (SqlDataReader sdr = command.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            countryNames.Add(sdr["CityName"].ToString());
                        }
                    }
                    connection.Close();
                    return countryNames;


                }

            }

    }
