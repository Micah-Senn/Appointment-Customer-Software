
namespace Software2
{
    partial class ModAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelST = new System.Windows.Forms.Label();
            this.labelET = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelURL = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelCusID = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelAppID = new System.Windows.Forms.Label();
            this.dateTimePickerET = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerST = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxCusID = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(262, 508);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 53;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(23, 508);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modify Appointment";
            // 
            // labelST
            // 
            this.labelST.AutoSize = true;
            this.labelST.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelST.Location = new System.Drawing.Point(23, 382);
            this.labelST.Name = "labelST";
            this.labelST.Size = new System.Drawing.Size(78, 19);
            this.labelST.TabIndex = 77;
            this.labelST.Text = "Start Time";
            // 
            // labelET
            // 
            this.labelET.AutoSize = true;
            this.labelET.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelET.Location = new System.Drawing.Point(23, 411);
            this.labelET.Name = "labelET";
            this.labelET.Size = new System.Drawing.Size(70, 19);
            this.labelET.TabIndex = 76;
            this.labelET.Text = "End Time";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(23, 353);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(40, 19);
            this.labelDate.TabIndex = 75;
            this.labelDate.Text = "Date";
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelURL.Location = new System.Drawing.Point(23, 322);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(35, 19);
            this.labelURL.TabIndex = 74;
            this.labelURL.Text = "URL";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(23, 289);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(41, 19);
            this.labelType.TabIndex = 73;
            this.labelType.Text = "Type";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContact.Location = new System.Drawing.Point(23, 256);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(60, 19);
            this.labelContact.TabIndex = 72;
            this.labelContact.Text = "Contact";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocation.Location = new System.Drawing.Point(23, 223);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(66, 19);
            this.labelLocation.TabIndex = 71;
            this.labelLocation.Text = "Location";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDesc.Location = new System.Drawing.Point(23, 186);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(85, 19);
            this.labelDesc.TabIndex = 70;
            this.labelDesc.Text = "Description";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(23, 157);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(38, 19);
            this.labelTitle.TabIndex = 69;
            this.labelTitle.Text = "Title";
            // 
            // labelCusID
            // 
            this.labelCusID.AutoSize = true;
            this.labelCusID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCusID.Location = new System.Drawing.Point(23, 124);
            this.labelCusID.Name = "labelCusID";
            this.labelCusID.Size = new System.Drawing.Size(91, 19);
            this.labelCusID.TabIndex = 68;
            this.labelCusID.Text = "Customer ID";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserID.Location = new System.Drawing.Point(23, 91);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(57, 19);
            this.labelUserID.TabIndex = 67;
            this.labelUserID.Text = "User ID";
            // 
            // labelAppID
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppID.Location = new System.Drawing.Point(23, 62);
            this.labelAppID.Name = "labelAppID";
            this.labelAppID.Size = new System.Drawing.Size(115, 19);
            this.labelAppID.TabIndex = 66;
            this.labelAppID.Text = "Appointment ID";
            // 
            // dateTimePickerET
            // 
            this.dateTimePickerET.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerET.Location = new System.Drawing.Point(146, 411);
            this.dateTimePickerET.Name = "dateTimePickerET";
            this.dateTimePickerET.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerET.TabIndex = 65;
            // 
            // dateTimePickerST
            // 
            this.dateTimePickerST.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerST.Location = new System.Drawing.Point(146, 382);
            this.dateTimePickerST.Name = "dateTimePickerST";
            this.dateTimePickerST.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerST.TabIndex = 64;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(146, 353);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerDate.TabIndex = 63;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(146, 322);
            this.textBoxURL.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(216, 23);
            this.textBoxURL.TabIndex = 62;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(146, 289);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(216, 23);
            this.textBoxType.TabIndex = 61;
            // 
            // textBoxContact
            // 
            this.textBoxContact.Location = new System.Drawing.Point(146, 256);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(216, 23);
            this.textBoxContact.TabIndex = 60;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(146, 223);
            this.textBoxLocation.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(216, 23);
            this.textBoxLocation.TabIndex = 59;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(146, 190);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(216, 23);
            this.textBoxDesc.TabIndex = 58;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(146, 157);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(216, 23);
            this.textBoxTitle.TabIndex = 57;
            // 
            // textBoxCusID
            // 
            this.textBoxCusID.Location = new System.Drawing.Point(146, 124);
            this.textBoxCusID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCusID.Name = "textBoxCusID";
            this.textBoxCusID.Size = new System.Drawing.Size(216, 23);
            this.textBoxCusID.TabIndex = 56;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(146, 91);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(216, 23);
            this.textBoxUserID.TabIndex = 55;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(146, 58);
            this.textBoxAppID.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(216, 23);
            this.textBoxAppID.TabIndex = 54;
            // 
            // ModAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.labelST);
            this.Controls.Add(this.labelET);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelURL);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelCusID);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelAppID);
            this.Controls.Add(this.dateTimePickerET);
            this.Controls.Add(this.dateTimePickerST);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxCusID);
            this.Controls.Add(this.textBoxUserID);
            this.Controls.Add(this.textBoxAppID);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Name = "ModAppointment";
            this.Text = "ModAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelST;
        private System.Windows.Forms.Label labelET;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelCusID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelAppID;
        private System.Windows.Forms.DateTimePicker dateTimePickerET;
        private System.Windows.Forms.DateTimePicker dateTimePickerST;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxContact;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxCusID;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxAppID;
    }
}