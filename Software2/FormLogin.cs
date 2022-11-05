using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Software2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            textBoxUser.Text = "test"; //FIXME 
            textBoxPass.Text = "test";
            using (StreamWriter txt = new StreamWriter("login.txt", true))
            {
                string time = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                txt.WriteLine(string.Format("Login Attempt {0}--{1}:{2} {3}:{4}", time, labelUsername.Text, textBoxUser.Text, labelPassword.Text, textBoxPass.Text));

            }
            if (textBoxUser.Text=="test" && textBoxPass.Text=="test")
            {
                new FormControl().Show();
                this.Hide();
            }
            else
            {
              
                MessageBox.Show("The username or password you entered is incorrect");
            }
            
            
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
        }
    }
}
