using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Windows.Forms;

namespace Software2
{
    public partial class AddAppointment : Form
    {
        private readonly FormControl _parent;
        public string CustomerId { get; set; }

        public AddAppointment(FormControl parent)
        {
            InitializeComponent();
                        _parent = parent;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            CustomerId = textBoxCusId.Text;
            string getCusId = ($"SELECT customerId FROM customer WHERE customerId = ({CustomerId})");

            DateTime startTime = dateTimePickerST.Value;
            DateTime endTime = dateTimePickerET.Value;
            bool overlap = DbAppointment.Overlap(dateTimePickerST.Value.ToUniversalTime(), dateTimePickerET.Value.ToUniversalTime());

            if (
               string.IsNullOrEmpty(textBoxCusId.Text) ||
               string.IsNullOrEmpty(textBoxUserId.Text) ||
               string.IsNullOrEmpty(textBoxDesc.Text) ||
               string.IsNullOrEmpty(textBoxType.Text))
            {
                MessageBox.Show("Please fill out all fields", "Invalid entry");
                return;
            }
            string result = SQL.getSQL(getCusId);
            if (result == null)
            {
                MessageBox.Show("Customer ID not found, please enter a valid customer ID.", "Invalid entry");
                return;
            }
            else if (textBoxUserId.Text != "1" && textBoxUserId.Text != "2")
            {
                MessageBox.Show("Please select an active user ID.", "Invalid entry");
                return;
            }
            else if (outsideOfBusinessHours(startTime, endTime))
            {
                MessageBox.Show("Please select an appointment time during business hours (9am to 5pm).", "Appointment Error");
                return;
            }
            else if (startTime > endTime)
            {
                MessageBox.Show("Appointment start time must procede appointment end time.", "Appointment Error");
                return;
            }
            else if (overlap)
            {
                MessageBox.Show("Appointment already scheduled for this time.", "Appointment Error");
            }
            else
            {
                Appointment app = new Appointment(textBoxCusId.Text, textBoxUserId.Text, textBoxDesc.Text, textBoxType.Text, dateTimePickerST.Value.ToUniversalTime(), dateTimePickerET.Value.ToUniversalTime());
                DbAppointment.AddAppointment(app);
                _parent.DisplayDGVApp();
                this.Close();
            }

        }
        private void textBoxCusId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxCusId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxCusId.Text = textBoxCusId.Text.Remove(textBoxCusId.Text.Length - 1);
            }
        }

        private void textBoxUserId_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxUserId.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numerical values.", "Invalid entry");
                textBoxUserId.Text = textBoxUserId.Text.Remove(textBoxUserId.Text.Length - 1);
            }
        }
        public static bool outsideOfBusinessHours(DateTime startTime, DateTime endTime)
        {
            DateTime businessStart = DateTime.Today.AddHours(9); // 9AM
            DateTime businessEnd = DateTime.Today.AddHours(17); // 5PM
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
