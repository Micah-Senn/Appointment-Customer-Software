
namespace Software2
{
    partial class ModCustomer
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
            this.comboBoxActive = new System.Windows.Forms.ComboBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelActive = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelZip = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelAdd2 = new System.Windows.Forms.Label();
            this.labelAdd1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxAdd2 = new System.Windows.Forms.TextBox();
            this.textBoxAdd1 = new System.Windows.Forms.TextBox();
            this.textBoxCusName = new System.Windows.Forms.TextBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelCusId = new System.Windows.Forms.Label();
            this.textBoxCusId = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "False",
            "True"});
            this.comboBoxActive.Location = new System.Drawing.Point(144, 335);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(216, 23);
            this.comboBoxActive.TabIndex = 9;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(260, 404);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 101;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 404);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 100;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelActive
            // 
            this.labelActive.AutoSize = true;
            this.labelActive.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActive.Location = new System.Drawing.Point(21, 335);
            this.labelActive.Name = "labelActive";
            this.labelActive.Size = new System.Drawing.Size(51, 19);
            this.labelActive.TabIndex = 99;
            this.labelActive.Text = "Active";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(21, 302);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(110, 19);
            this.labelPhone.TabIndex = 98;
            this.labelPhone.Text = "Phone Number";
            // 
            // labelZip
            // 
            this.labelZip.AutoSize = true;
            this.labelZip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelZip.Location = new System.Drawing.Point(21, 269);
            this.labelZip.Name = "labelZip";
            this.labelZip.Size = new System.Drawing.Size(64, 19);
            this.labelZip.TabIndex = 97;
            this.labelZip.Text = "Zipcode";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCountry.Location = new System.Drawing.Point(21, 236);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(63, 19);
            this.labelCountry.TabIndex = 96;
            this.labelCountry.Text = "Country";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(21, 202);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(35, 19);
            this.labelCity.TabIndex = 95;
            this.labelCity.Text = "City";
            // 
            // labelAdd2
            // 
            this.labelAdd2.AutoSize = true;
            this.labelAdd2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdd2.Location = new System.Drawing.Point(21, 170);
            this.labelAdd2.Name = "labelAdd2";
            this.labelAdd2.Size = new System.Drawing.Size(106, 19);
            this.labelAdd2.TabIndex = 94;
            this.labelAdd2.Text = "Address Line 2";
            // 
            // labelAdd1
            // 
            this.labelAdd1.AutoSize = true;
            this.labelAdd1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAdd1.Location = new System.Drawing.Point(21, 137);
            this.labelAdd1.Name = "labelAdd1";
            this.labelAdd1.Size = new System.Drawing.Size(106, 19);
            this.labelAdd1.TabIndex = 93;
            this.labelAdd1.Text = "Address Line 1";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(21, 104);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(117, 19);
            this.labelName.TabIndex = 92;
            this.labelName.Text = "Customer Name";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Location = new System.Drawing.Point(144, 269);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(216, 23);
            this.textBoxZip.TabIndex = 7;
            // 
            // textBoxAdd2
            // 
            this.textBoxAdd2.Location = new System.Drawing.Point(144, 170);
            this.textBoxAdd2.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAdd2.Name = "textBoxAdd2";
            this.textBoxAdd2.Size = new System.Drawing.Size(216, 23);
            this.textBoxAdd2.TabIndex = 4;
            // 
            // textBoxAdd1
            // 
            this.textBoxAdd1.Location = new System.Drawing.Point(144, 137);
            this.textBoxAdd1.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAdd1.Name = "textBoxAdd1";
            this.textBoxAdd1.Size = new System.Drawing.Size(216, 23);
            this.textBoxAdd1.TabIndex = 3;
            // 
            // textBoxCusName
            // 
            this.textBoxCusName.Location = new System.Drawing.Point(144, 104);
            this.textBoxCusName.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCusName.Name = "textBoxCusName";
            this.textBoxCusName.Size = new System.Drawing.Size(216, 23);
            this.textBoxCusName.TabIndex = 2;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(118, 11);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(176, 28);
            this.labelMain.TabIndex = 83;
            this.labelMain.Text = "Modify Customer";
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(144, 236);
            this.textBoxCountry.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(216, 23);
            this.textBoxCountry.TabIndex = 6;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(144, 203);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(216, 23);
            this.textBoxCity.TabIndex = 5;
            // 
            // labelCusId
            // 
            this.labelCusId.AutoSize = true;
            this.labelCusId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCusId.Location = new System.Drawing.Point(23, 71);
            this.labelCusId.Name = "labelCusId";
            this.labelCusId.Size = new System.Drawing.Size(91, 19);
            this.labelCusId.TabIndex = 106;
            this.labelCusId.Text = "Customer ID";
            // 
            // textBoxCusId
            // 
            this.textBoxCusId.Location = new System.Drawing.Point(144, 71);
            this.textBoxCusId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCusId.Name = "textBoxCusId";
            this.textBoxCusId.ReadOnly = true;
            this.textBoxCusId.Size = new System.Drawing.Size(216, 23);
            this.textBoxCusId.TabIndex = 1;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(144, 301);
            this.textBoxPhone.Mask = "(999) 000-0000";
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(216, 23);
            this.textBoxPhone.TabIndex = 8;
            // 
            // ModCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCusId);
            this.Controls.Add(this.labelCusId);
            this.Controls.Add(this.textBoxCountry);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.comboBoxActive);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelActive);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelZip);
            this.Controls.Add(this.labelCountry);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelAdd2);
            this.Controls.Add(this.labelAdd1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxZip);
            this.Controls.Add(this.textBoxAdd2);
            this.Controls.Add(this.textBoxAdd1);
            this.Controls.Add(this.textBoxCusName);
            this.Controls.Add(this.labelMain);
            this.Name = "ModCustomer";
            this.Text = "ModCustomer";
            this.Load += new System.EventHandler(this.ModCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxActive;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelActive;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelZip;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelAdd2;
        private System.Windows.Forms.Label labelAdd1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.TextBox textBoxAdd2;
        private System.Windows.Forms.TextBox textBoxAdd1;
        private System.Windows.Forms.TextBox textBoxCusName;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label labelCusId;
        private System.Windows.Forms.TextBox textBoxCusId;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
    }
}