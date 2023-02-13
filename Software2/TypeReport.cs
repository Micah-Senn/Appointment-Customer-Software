using MySql.Data.MySqlClient;
using Software2.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Software2
{
    public partial class TypeReport : Form
    {
        public TypeReport()
        {
            InitializeComponent();
            radioButtonJan.Checked = true;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DisplayDGV()
        {
            var checkedButton = this.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked); // LAMBDA EXPRESSION. Using a lambda expression here saved a lot of code and is more efficient than iterating through many if statements to determine the radio button in use.
            var tag = checkedButton.Tag;
            MySqlConnection conn = SQL.GetConnection();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = $"SELECT DISTINCT type AS 'Type', COUNT(*) AS 'Type Count' FROM appointment WHERE MONTH(start) = {tag} GROUP BY type;";
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            dataGridViewType.DataSource = dt;
        }

        private void TypeReport_Load(object sender, EventArgs e)
        {
            DisplayDGV();
        }
    }
}
