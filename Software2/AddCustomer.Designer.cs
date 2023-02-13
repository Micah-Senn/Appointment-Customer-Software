
namespace Software2
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelActive = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAdd1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxAdd1 = new System.Windows.Forms.TextBox();
            this.textBoxCusName = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.comboBoxActive = new System.Windows.Forms.ComboBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(262, 406);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 80;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(152, 406);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 79;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActive.Location = new System.Drawing.Point(17, 290);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(51, 19);
            this.labelActive.TabIndex = 75;
            this.labelActive.Text = "Active";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(17, 260);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 19);
            this.labelPhone.TabIndex = 74;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelZip.Location = new System.Drawing.Point(21, 225);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(64, 19);
            this.labelZip.TabIndex = 73;
            this.labelZip.Text = "Zipcode";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(21, 196);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(43, 19);
            this.labelCountry.TabIndex = 72;
            this.labelCountry.Text = "State";
            this.labelCountry.Click += new System.EventHandler(this.labelCountry_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(21, 164);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 19);
            this.labelCity.TabIndex = 71;
            this.labelCity.Text = "City";
            // 
            // labelAdd1
            // 
            this.labelAdd1.AutoSize = true;
            this.labelAdd1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdd1.Location = new System.Drawing.Point(21, 131);
            this.labelAdd1.Name = "labelAdd1";
            this.labelAdd1.Size = new System.Drawing.Size(63, 19);
            this.labelAdd1.TabIndex = 69;
            this.labelAdd1.Text = "Address";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(21, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(117, 19);
            this.labelName.TabIndex = 68;
            this.labelName.Text = "Customer Name";
            // 
            // textBoxAdd1
            // 
            this.textBoxAdd1.Location = new System.Drawing.Point(146, 131);
            this.textBoxAdd1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAdd1.Name = "textBoxAdd1";
            this.textBoxAdd1.Size = new System.Drawing.Size(216, 23);
            this.textBoxAdd1.TabIndex = 2;
            // 
            // textBoxCusName
            // 
            this.textBoxCusName.Location = new System.Drawing.Point(146, 98);
            this.textBoxCusName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCusName.Name = "textBoxCusName";
            this.textBoxCusName.Size = new System.Drawing.Size(216, 23);
            this.textBoxCusName.TabIndex = 1;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(127, 29);
            this.labelMain.Margin = new System.Windows.Forms.Padding(10);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(146, 28);
            this.labelMain.TabIndex = 54;
            this.labelMain.Text = "Add Customer";
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxActive.Location = new System.Drawing.Point(146, 290);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(216, 23);
            this.comboBoxActive.TabIndex = 8;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(146, 164);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(216, 23);
            this.textBoxCity.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(146, 260);
            this.textBoxPhone.Mask = "(999) 000-0000";
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(216, 23);
            this.textBoxPhone.TabIndex = 7;
            this.textBoxPhone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxPhone_MouseDown);
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(146, 225);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(216, 23);
            this.textBoxZip.TabIndex = 6;
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBoxState.Location = new System.Drawing.Point(146, 196);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(216, 23);
            this.comboBoxState.TabIndex = 5;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // AddCustomer
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.comboBoxActive);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAdd1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAdd1);
            this.Controls.Add(this.textBoxCusName);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCustomer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAdd1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxAdd1;
        private System.Windows.Forms.TextBox textBoxCusName;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.ComboBox comboBoxActive;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.ComboBox comboBoxState;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}