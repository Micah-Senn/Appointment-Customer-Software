using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    class DbAddress
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

        public static void AddAddress(Address addr)
        {
            string sql = "INSERT INTO address VALUES (NULL, @address, @address2, NULL, @postalCode, @phone, NULL, NULL, NULL, NULL)";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@address", MySqlDbType.VarChar).Value = addr.address;
            cmd.Parameters.Add("@address2", MySqlDbType.VarChar).Value = addr.address2;
            cmd.Parameters.Add("@postalCode", MySqlDbType.VarChar).Value = addr.postalCode;
            cmd.Parameters.Add("@phone", MySqlDbType.VarChar).Value = addr.phone;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Address not added.\n" + ex.Message);

            }
            conn.Close();
        }
    }
}
