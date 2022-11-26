using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Software2.Database
{
    class DbUser
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
        public static void AddUser()
        {
            MySqlConnection conn = SQL.GetConnection();
            string sql = "INSERT INTO user VALUES ('2', 'micahsenn', 'password', '1', @now, 'not needed', @now, 'not needed')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@now", MySqlDbType.DateTime).Value = DateTime.Now.ToUniversalTime();

            try
            {
                cmd.ExecuteNonQuery();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show("User not added.\n" + ex.Message);

            }
            conn.Close();
        }
    }
}
