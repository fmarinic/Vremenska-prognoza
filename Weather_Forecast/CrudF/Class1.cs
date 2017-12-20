using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace CrudF
{
    public class Crud
    {
        public List<City> GetAllCities()
        {
            List<City> lCities = new List<City>();
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM Forecast_Cities";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lCities.Add(new City()
                        {
                            nID = (int)oReader["Id"],
                            sName = (string)oReader["NAME"],
                            fLat = (float)oReader["LAT"],
                            fLng = (float)oReader["LNG"]
                        });
                    }
                }
            }
            return lCities;
        }
        public void AddCity(City oCity)
        {
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO Forecast_Cities (NAME, LAT, LNG) VALUES('" + oCity.sName + "', '" + oCity.fLat + "', '" + oCity.fLng + "');";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
        public void DeleteCity(City oCity)
        {
            String sSqlConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "DELETE FROM Forecast_Cities WHERE Id = " + oCity.nID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    //nema povratne vrijednosti
                }
            }
        }
        public void UpdateCity()
        {

        }
    }
}
