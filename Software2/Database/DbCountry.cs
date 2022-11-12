using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2.Database
{
    class DbCountry
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;Port=3306;Username=root;Password=Xmen1029$;Database=software2";
            MySqlConnection conn = new MySqlConnection(sql);
            try
            {
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection not established." + ex.Message);

            }
            return conn;
        }
        public static int getID(string id, string table)
        {
            string sql = "datasource=localhost;Port=3306;Username=root;Password=Xmen1029$;Database=software2";

            MySqlConnection conn = new MySqlConnection(sql);
            conn.Open();
            string query = $"SELECT max({id}) FROM {table}";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                if (rdr[0] == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToInt32(rdr[0]); ;
            }

            return 0;
        }
        public static void AddCountry(Country ctry)
        {
            int countryId = getID("countryId", "country") + 1;
            string sql = "INSERT INTO country VALUES (@countryId, @country, NULL, NULL, NULL, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@countryId", MySqlDbType.VarChar).Value = countryId;
            cmd.Parameters.Add("@country", MySqlDbType.VarChar).Value = ctry.country;

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Country not added.\n" + ex.Message);

            }
            conn.Close();
        }
        public static void UpdateCountry(Country country, string id)
        {
            string sql = "UPDATE country SET country = @country WHERE countryId = @countryId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@country", MySqlDbType.VarChar).Value = country.country;
            cmd.Parameters.Add("@countryId", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Country was not modified. \n" + ex.Message);

            }

            conn.Close();
        }
        public static void DeleteCountry(string id)
        {
            string sql = "DELETE FROM country WHERE countryId = @countryId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@countryId", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Country was not deleted.\n" + ex.Message);

            }
            conn.Close();
        }
    }
}

