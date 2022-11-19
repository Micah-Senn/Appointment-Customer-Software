using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {

        }
        public void DisplayDGV()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type', " +
                "start AS 'Start Time', end AS 'End Time' FROM appointment WHERE customerId = 1";
            MySqlCommand cmda = new MySqlCommand(sqlStringApp, con);
            MySqlDataAdapter adpa = new MySqlDataAdapter(cmda);
            DataTable dt = new DataTable();
            adpa.Fill(dt);
            /* for (int i = 0; i < dt.Rows.Count; i++)
             {
                 DateTime y = (DateTime)dt.Rows[i]["Start Time"];
                 dt.Rows[i]["Start Time"] = y.ToLocalTime();
             }
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 DateTime y = (DateTime)dt.Rows[i]["End Time"];
                 dt.Rows[i]["End Time"] = y.ToLocalTime();
             }*/
            dataGridViewCus.DataSource = dt;
        }

        private void comboBoxCus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
