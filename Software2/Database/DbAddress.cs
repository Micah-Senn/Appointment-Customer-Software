using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    class DbAddress
    {
      
        public static int getID(string id, string table)
        {
            string sql = "datasource=localhost;Port=3306;Username=root;Password=Xmen1029$;Database=software2";

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

        public static void AddAddress(Address addr)
        {
            int addressId = getID("addressId", "address") + 1;
            string sql = "INSERT INTO address VALUES (@addressId, @address, @city, @state, @postalCode, @phone, NULL, NULL, NULL, NULL)";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@addressId", MySqlDbType.VarChar).Value = addressId;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = addr.address;
            cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = addr.city;
            cmd.Parameters.Add("@state", MySqlDbType.VarChar).Value = addr.state;
            cmd.Parameters.Add("@postalCode", MySqlDbType.VarChar).Value = addr.postalCode;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = addr.phone;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Address not added.\n" + ex.Message);

            }
            conn.Close();
        }

        public static void UpdateAddress(Address addr, string id)
        {
            string sql = "UPDATE address SET address = @address, city = @city, state = @state, postalCode = @postalCode, phone = @phone WHERE addressId = @addressId";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = addr.address;
            cmd.Parameters.Add("@city", MySqlDbType.VarChar).Value = addr.city;
            cmd.Parameters.Add("@state", MySqlDbType.VarChar).Value = addr.state;
            cmd.Parameters.Add("@postalCode", MySqlDbType.VarChar).Value = addr.postalCode;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = addr.phone;
            cmd.Parameters.Add("@addressId", MySqlDbType.VarChar).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Address was not modified. \n" + ex.Message);

            }
            conn.Close();
        }

        public static void DeleteAddress(string id)
        {
            string sql = "DELETE FROM address WHERE addressId = @addressId";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@addressId", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Address was not deleted.\n" + ex.Message);

            }
            conn.Close();
        }
    }
}
