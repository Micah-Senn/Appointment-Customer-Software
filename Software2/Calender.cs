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
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
            if (radioAll.Checked)
            {
                DisplayDGVApp();
                this.Refresh();
            }
            else if (radioWeek.Checked)
            {
                this.Refresh();
            }
            else if (radioMonth.Checked)
            {
                this.Refresh();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void DisplayDGVApp()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type', " +
                "start AS 'Start Time', end AS 'End Time' FROM appointment";
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
            dataGridViewCal.DataSource = dt;
        }
        public void DisplayDGVWeek()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type'," +
                " start AS 'Start Time', end AS 'End Time' FROM software2.appointment WHERE  YEARWEEK(`start`) = YEARWEEK(CURDATE())";
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
            dataGridViewCal.DataSource = dt;
        }
        public void DisplayDGVMonth()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            MySqlConnection con = new MySqlConnection(connectionString);

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type', " +
                "start AS 'Start Time', end AS 'End Time' FROM software2.appointment WHERE MONTH(start) = MONTH(CURRENT_DATE()) AND YEAR(start) = YEAR(CURRENT_DATE())";
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
            dataGridViewCal.DataSource = dt;
        }

        private void Calender_Load(object sender, EventArgs e)
        {

        }

        private void radioAll_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDGVApp();
            this.Refresh();
        }

        private void radioWeek_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDGVWeek();
            this.Refresh();
        }

        private void radioMonth_CheckedChanged(object sender, EventArgs e)
        {
            DisplayDGVMonth();
            this.Refresh();
        }

        private void dataGridViewCal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToLocalTime();
            }
        }
    }
}
