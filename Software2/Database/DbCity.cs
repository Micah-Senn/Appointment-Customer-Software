using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2.Database
{
    class DbCity
    {
        public static int getID(string id, string table)
        {
            MySqlConnection conn = SQL.GetConnection();
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
        public static void AddCity(City cty)
        {
            int cityId = getID("cityId", "city") + 1;
            int countryId = getID("countryId", "country");
            string sql = "INSERT INTO city VALUES (@cityId, @city, @countryId, @now, 'not needed', @now, 'not needed')";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cityId", MySqlDbType.VarChar).Value = cityId;
            cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = cty.city;
            cmd.Parameters.Add("@countryId", MySqlDbType.VarChar).Value = countryId;
            cmd.Parameters.Add("@now", MySqlDbType.DateTime).Value = DateTime.Now.ToUniversalTime();

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("City not added.\n" + ex.Message);

            }
            conn.Close();
        }
        public static void UpdateCity(City city, string id)
        {
            string sql = "UPDATE city SET city = @city WHERE cityId = @cityId";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = city.city;
            cmd.Parameters.Add("@cityId", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("City was not modified. \n" + ex.Message);

            }
            conn.Close();
        }
        public static void DeleteCity(string id)
        {
            string sql = "DELETE FROM city WHERE cityId = @cityId";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@cityId", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("City was not deleted.\n" + ex.Message);

            }
            conn.Close();
        }
    }
}
