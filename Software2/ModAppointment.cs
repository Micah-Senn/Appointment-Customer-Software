using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class ModAppointment : Form
    {
        private readonly FormControl _parent;
        public string AppointmentId { get; set; }
        public ModAppointment(FormControl parent)
        {
            InitializeComponent();
            _parent = parent;
        }
        public static string getSQL(string query)
        {
            string sql = "datasource=localhost;Port=3306;Username=root;Password=Xmen1029$;Database=software2";
            MySqlConnection conn = new MySqlConnection(sql);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                if (rdr[0] == DBNull.Value)
                {
                    return null;
                }
                return Convert.ToString(rdr[0]);
            }

            return null;
        }
        public static DateTime getDTSQL(string query)
        {
            string sql = "datasource=localhost;Port=3306;Username=root;Password=Xmen1029$;Database=software2";
            MySqlConnection conn = new MySqlConnection(sql);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.HasRows)
            {
                rdr.Read();
                if (rdr[0] == DBNull.Value)
                {
                    return default;
                }
                DateTime dt = Convert.ToDateTime(rdr[0]);
                return dt.ToLocalTime();
            }

            return default;
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModAppointment_Load(object sender, EventArgs e)
        {
            textBoxAppId.Text = this.AppointmentId;
            string getUserId = ($"SELECT userId FROM appointment WHERE appointmentId = ({this.AppointmentId})");
            string getCusId = ($"SELECT customerId FROM appointment WHERE appointmentId = ({this.AppointmentId})");
            string getDesc = ($"SELECT description FROM appointment WHERE appointmentId = ({this.AppointmentId})");
            string getType = ($"SELECT type FROM appointment WHERE appointmentId = ({this.AppointmentId})");
            string getSt = ($"SELECT start FROM appointment WHERE appointmentId = ({this.AppointmentId})");
            string getEt = ($"SELECT end FROM appointment WHERE appointmentId = ({this.AppointmentId})");
            textBoxUserId.Text = getSQL(getUserId);
            textBoxCusId.Text = getSQL(getCusId);
            textBoxDesc.Text = getSQL(getDesc);
            textBoxType.Text = getSQL(getType);
            dateTimePickerST.Value = getDTSQL(getSt);
            dateTimePickerET.Value = getDTSQL(getEt);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DateTime startTime = dateTimePickerST.Value;
            DateTime endTime = dateTimePickerET.Value;
            bool overlap = DbAppointment.OverlapMod(dateTimePickerST.Value.ToUniversalTime(), dateTimePickerET.Value.ToUniversalTime(), this.AppointmentId);
            if (
               string.IsNullOrEmpty(textBoxUserId.Text) ||
               string.IsNullOrEmpty(textBoxCusId.Text) ||
               string.IsNullOrEmpty(textBoxDesc.Text) ||
               string.IsNullOrEmpty(textBoxType.Text))
            {
                MessageBox.Show("Please fill out all fields", "Invalid entry");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCusId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a valid Customer ID", "Invalid entry");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBoxUserId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter a valid User ID", "Invalid entry");
                return;
            }
            else if (outsideOfBusinessHours(startTime, endTime))
            {
                MessageBox.Show("Please select an appointment time during business hours (9am to 5pm)", "Appointment Error");
                return;
            }
            else if (textBoxUserId.Text != "1" && textBoxUserId.Text != "2")
            {
                MessageBox.Show("Please select an active user ID.", "Invalid entry");
                return;
            }
            else if (startTime > endTime)
            {
                MessageBox.Show("Appointment start time must procede appointment end time", "Appointment Error");
                return;
            }
            else if (overlap)
            {
                MessageBox.Show("Appointment already scheduled for this time.", "Appointment Error");
            }
            else
            {
                Appointment app = new Appointment(textBoxCusId.Text, textBoxUserId.Text, textBoxDesc.Text, textBoxType.Text, dateTimePickerST.Value.ToUniversalTime(), dateTimePickerET.Value.ToUniversalTime());
                string appId = this.AppointmentId;
                DbAppointment.UpdateAppointment(app, appId);
                _parent.DisplayDGVApp();
                this.Close();
            }
            
        }
        public static bool outsideOfBusinessHours(DateTime startTime, DateTime endTime)
        {
            DateTime businessStart = DateTime.Today.AddHours(9);
            DateTime businessEnd = DateTime.Today.AddHours(17); // 5pm
            if (startTime.TimeOfDay > businessStart.TimeOfDay && startTime.TimeOfDay < businessEnd.TimeOfDay &&
                endTime.TimeOfDay > businessStart.TimeOfDay && endTime.TimeOfDay < businessEnd.TimeOfDay)
                return false;

            return true;
        }

        private void dateTimePickerST_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
