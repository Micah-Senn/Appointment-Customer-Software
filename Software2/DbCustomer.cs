using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    class DbCustomer
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

        public static void AddCustomer(Customer cus)
        {

            
            string sql = "INSERT INTO customer VALUES (NULL, @customerName, NULL, @active, NULL, NULL, NULL, NULL)";// @addressId, @active, @createDate, @createdBy, NULL, @lastUpdateBy";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerName", MySqlDbType.VarChar).Value = cus.customerName;
         //   cmd.Parameters.Add("@addressId", MySqlDbType.VarChar).Value = cus.addressId; // do I need to cast as INT?? FIXME
            cmd.Parameters.Add("@active", MySqlDbType.Int16).Value = cus.active;
         //   cmd.Parameters.Add("@createDate", MySqlDbType.VarChar).Value = cus.createDate;
         //   cmd.Parameters.Add("@createdBy", MySqlDbType.VarChar).Value = cus.createdBy;
         //   cmd.Parameters.Add("@lastUpdateBy", MySqlDbType.VarChar).Value = cus.lastUpdateBy;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added successfully.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer not added.\n" + ex.Message);

            }
            conn.Close();
        }

        public static void UpdateCustomer(Customer cus, string id)
        {
            string sql = "UPDATE customer VALUES SET customerName = @customerName"; //addressId = @addressId, active = @active, createDate = @createDate, createdBy = @createdBy lastUpdateBy = @lastUpdateBy WHERE ID = @customerId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerName", MySqlDbType.VarChar).Value = cus.customerName;
        //    cmd.Parameters.Add("@addressId", MySqlDbType.VarChar).Value = cus.addressId; // do I need to cast as INT?? FIXME
          //  cmd.Parameters.Add("@active", MySqlDbType.VarChar).Value = cus.active;
          //  cmd.Parameters.Add("@createDate", MySqlDbType.VarChar).Value = cus.createDate;
          //  cmd.Parameters.Add("@createdBy", MySqlDbType.VarChar).Value = cus.createdBy;
          //  cmd.Parameters.Add("@lastUpdateBy", MySqlDbType.VarChar).Value = cus.lastUpdateBy;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer was sucessfully modified.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer record was not modified. \n" + ex.Message);

            }
            conn.Close();
        }

        public static void DeleteCustomer(string id)
        {
            string sql = "DELETE FROM customer WHERE customerId = @customerId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerId", MySqlDbType.VarChar).Value = id; // do I need to cast as INT?? FIXME
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer was deleted successfully.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Customer was not deleted.\n" + ex.Message);

            }
            conn.Close();
        }
        public static void DisplayCustomer(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            conn.Close();

        }
    }
}
