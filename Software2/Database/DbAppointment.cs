using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    class DbAppointment
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

        public static void AddAppointment(Appointment app)
        {
            int appointmentId = getID("appointmentId", "appointment") + 1;
            MySqlConnection conn = SQL.GetConnection();
            string sql = "INSERT INTO appointment VALUES (@appointmentId, @customerId, @userId, 'not needed', @description, 'not needed', 'not needed', @type, 'not needed', @start, @end, @now, 'not needed', @now, 'not needed')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@appointmentId", MySqlDbType.Int16).Value = appointmentId;
            cmd.Parameters.Add("@customerId", MySqlDbType.Int16).Value = app.customerId;
            cmd.Parameters.Add("@userId", MySqlDbType.Int16).Value = app.userId;
            cmd.Parameters.Add("@description", MySqlDbType.VarChar).Value = app.description;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = app.type;
            cmd.Parameters.Add("@start", MySqlDbType.DateTime).Value = app.start;
            cmd.Parameters.Add("@end", MySqlDbType.DateTime).Value = app.end;
            cmd.Parameters.Add("@now", MySqlDbType.DateTime).Value = DateTime.Now.ToUniversalTime();
            Appointment.Appointments.Add(app);

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
            MySqlConnection conn = SQL.GetConnection();
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
            MySqlConnection conn = SQL.GetConnection();
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
        public static bool Overlap(DateTime startTime, DateTime endTime)
        {
            MySqlConnection conn = SQL.GetConnection();
            bool overlap = false;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT EXISTS(SELECT * FROM appointment WHERE start <= @end AND end >= @start)";
                cmd.Parameters.Add("@start", MySqlDbType.DateTime).Value = startTime;
                cmd.Parameters.Add("@end", MySqlDbType.DateTime).Value = endTime;
                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    overlap = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown checking for overlapping appointments: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return overlap;
        }
        public static bool OverlapMod(DateTime startTime, DateTime endTime, string apptId)
        {
            MySqlConnection conn = SQL.GetConnection();
            bool overlap = false;
            try
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT EXISTS(SELECT * FROM appointment WHERE start <= @end AND end >= @start AND appointmentId != @apptId)";
                cmd.Parameters.Add("@start", MySqlDbType.DateTime).Value = startTime;
                cmd.Parameters.Add("@end", MySqlDbType.DateTime).Value = endTime;
                cmd.Parameters.Add("@apptId", MySqlDbType.Int16).Value = apptId;
                if (cmd.ExecuteScalar().ToString() == "1")
                {
                    overlap = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown checking for overlapping appointments: " + ex);
            }
            finally
            {
                conn.Close();
            }

            return overlap;
        }
    }
}
