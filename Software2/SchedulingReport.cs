using MySql.Data.MySqlClient;
using Software2.Database;
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
    public partial class SchedulingReport : Form
    {
        public SchedulingReport()
        {
            InitializeComponent();
        }

        private void SchedulingReport_Load(object sender, EventArgs e)
        {

        }
        public void DisplayDGV1()
        {
            MySqlConnection con = SQL.GetConnection();

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type', " +
                "start AS 'Start Time', end AS 'End Time' FROM appointment WHERE userId = 1";
            MySqlCommand cmda = new MySqlCommand(sqlStringApp, con);
            MySqlDataAdapter adpa = new MySqlDataAdapter(cmda);
            DataTable dt = new DataTable();
            adpa.Fill(dt);
            dataGridViewSch.DataSource = dt;
        }
        public void DisplayDGV2()
        {
            MySqlConnection con = SQL.GetConnection();

            string sqlStringApp = "SELECT appointmentId AS 'Appointment ID', userId AS 'User ID', customerId AS 'Customer ID', description AS 'Description', type AS 'Type', " +
                "start AS 'Start Time', end AS 'End Time' FROM appointment WHERE userId = 2";
            MySqlCommand cmda = new MySqlCommand(sqlStringApp, con);
            MySqlDataAdapter adpa = new MySqlDataAdapter(cmda);
            DataTable dt = new DataTable();
            adpa.Fill(dt);
            dataGridViewSch.DataSource = dt;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsers.SelectedIndex == 0)
            {
                labelUser.Hide();
                DisplayDGV1();
                this.Refresh();
            }
            else if (comboBoxUsers.SelectedIndex == 1)
            {
                labelUser.Hide();
                DisplayDGV2();
                this.Refresh();
            }
        }

        private void dataGridViewSch_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime dt)
            {
                e.Value = dt.ToLocalTime();
            }
        }
        private void dataGridViewSch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
