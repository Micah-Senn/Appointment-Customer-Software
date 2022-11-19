using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    class DbAppointment
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

        public static void AddAppointment(Appointment app)
        {
            int appointmentId = getID("appointmentId", "appointment") + 1;
            MySqlConnection conn = GetConnection();
            string sql = "INSERT INTO appointment VALUES (@appointmentId, @customerId, @userId, NULL, @description, NULL, NULL, @type, NULL, @start, @end, NULL, NULL, NULL, NULL)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@appointmentId", MySqlDbType.Int16).Value = appointmentId;
            cmd.Parameters.Add("@customerId", MySqlDbType.Int16).Value = app.customerId;
            cmd.Parameters.Add("@userId", MySqlDbType.Int16).Value = app.userId;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = app.description;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = app.type;
            cmd.Parameters.Add("@start", MySqlDbType.DateTime).Value = app.start;
            cmd.Parameters.Add("@end", MySqlDbType.DateTime).Value = app.end;

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("Appointment not added.\n" + ex.Message);

            }
            conn.Close();
        }
        public static void DeleteAppointment(string id)
        {
            string sql = "DELETE FROM appointment WHERE appointmentId = @appointmentId";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@appointmentId", MySqlDbType.Int32).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Appointment was not deleted.\n" + ex.Message);

            }
            conn.Close();
        }
        public static void UpdateAppointment(Appointment app, string id)
        {
            string sql = $"UPDATE appointment SET customerId = @customerId, userId = @userId, description = @description, type = @type, start = @start, end = @end WHERE appointmentId = {id}";
            MySqlConnection conn = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@customerId", MySqlDbType.VarChar).Value = app.customerId;
            cmd.Parameters.Add("@userId", MySqlDbType.VarChar).Value = app.userId;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = app.description;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = app.type;
            cmd.Parameters.Add("@start", MySqlDbType.DateTime).Value = app.start;
            cmd.Parameters.Add("@end", MySqlDbType.DateTime).Value = app.end;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Appointment was not modified. \n" + ex.Message);

            }
            conn.Close();
        }
    }
}
