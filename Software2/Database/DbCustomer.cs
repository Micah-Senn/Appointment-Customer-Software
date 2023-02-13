using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    class DbCustomer
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

        public static void AddCustomer(Customer cus)
        {
            int customerId = getID("customerId", "customer") + 1;
            int addressId = getID("addressId", "address");
            MySqlConnection conn = SQL.GetConnection();
            string sql = "INSERT INTO customer VALUES (@customerId, @customerName, @addressId, @active, NULL, NULL, NULL, NULL)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerId", MySqlDbType.VarChar).Value = customerId;
            cmd.Parameters.Add("@customerName", MySqlDbType.VarChar).Value = cus.customerName;
            cmd.Parameters.Add("@addressId", MySqlDbType.Int16).Value = addressId;
            cmd.Parameters.Add("@active", MySqlDbType.Int16).Value = cus.active;

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Customer not added.\n" + ex.Message);

            }
            conn.Close();
        }

        public static void UpdateCustomer(Customer cus, string id)
        {
            string sql = "UPDATE customer SET customerName = @customerName, active = @active WHERE customerId = @customerId";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerName", MySqlDbType.VarChar).Value = cus.customerName;
            cmd.Parameters.Add("@active", MySqlDbType.Int16).Value = cus.active;
            cmd.Parameters.Add("@customerId", MySqlDbType.Int16).Value = id;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer was not modified. \n" + ex.Message);

            }
            conn.Close();
        }

        public static void DeleteCustomer(string id)
        {
            string sql = "DELETE FROM customer WHERE customerId = @customerId";
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerId", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer was not deleted.\n" + ex.Message);

            }
            conn.Close();
        }


    }
}
