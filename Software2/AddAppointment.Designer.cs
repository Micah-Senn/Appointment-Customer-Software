
namespace Software2
{
    partial class AddAppointment
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxCusId = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.dateTimePickerST = new System.Windows.Forms.DateTimePicker();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelCusID = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelST = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelET = new System.Windows.Forms.Label();
            this.dateTimePickerET = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Appointment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(144, 148);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(216, 23);
            this.textBoxUserId.TabIndex = 2;
            this.textBoxUserId.TextChanged += new System.EventHandler(this.textBoxUserId_TextChanged);
            // 
            // textBoxCusId
            // 
            this.textBoxCusId.Location = new System.Drawing.Point(144, 115);
            this.textBoxCusId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCusId.Name = "textBoxCusId";
            this.textBoxCusId.Size = new System.Drawing.Size(216, 23);
            this.textBoxCusId.TabIndex = 1;
            this.textBoxCusId.TextChanged += new System.EventHandler(this.textBoxCusId_TextChanged);
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(144, 181);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(216, 23);
            this.textBoxDesc.TabIndex = 4;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(144, 214);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(216, 23);
            this.textBoxType.TabIndex = 5;
            // 
            // dateTimePickerST
            // 
            this.dateTimePickerST.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
            this.dateTimePickerST.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerST.Location = new System.Drawing.Point(144, 245);
            this.dateTimePickerST.Name = "dateTimePickerST";
            this.dateTimePickerST.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerST.TabIndex = 6;
            this.dateTimePickerST.ValueChanged += new System.EventHandler(this.dateTimePickerST_ValueChanged);
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserID.Location = new System.Drawing.Point(41, 148);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(57, 19);
            this.labelUserID.TabIndex = 14;
            this.labelUserID.Text = "User ID";
            // 
            // labelCusID
            // 
            this.labelCusID.AutoSize = true;
            this.labelCusID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCusID.Location = new System.Drawing.Point(41, 116);
            this.labelCusID.Name = "labelCusID";
            this.labelCusID.Size = new System.Drawing.Size(91, 19);
            this.labelCusID.TabIndex = 15;
            this.labelCusID.Text = "Customer ID";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDesc.Location = new System.Drawing.Point(41, 181);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(56, 19);
            this.labelDesc.TabIndex = 17;
            this.labelDesc.Text = "Vehicle";
            this.labelDesc.Click += new System.EventHandler(this.labelDesc_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(41, 214);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(69, 19);
            this.labelType.TabIndex = 20;
            this.labelType.Text = "Job Type";
            this.labelType.Click += new System.EventHandler(this.labelType_Click);
            // 
            // labelST
            // 
            this.labelST.AutoSize = true;
            this.labelST.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelST.Location = new System.Drawing.Point(41, 245);
            this.labelST.Name = "labelST";
            this.labelST.Size = new System.Drawing.Size(97, 19);
            this.labelST.TabIndex = 24;
            this.labelST.Text = "Appointment";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(150, 406);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(260, 406);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelET
            // 
            this.labelET.AutoSize = true;
            this.labelET.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelET.Location = new System.Drawing.Point(41, 274);
            this.labelET.Name = "labelET";
            this.labelET.Size = new System.Drawing.Size(56, 19);
            this.labelET.TabIndex = 28;
            this.labelET.Text = "Due by";
            // 
            // dateTimePickerET
            // 
            this.dateTimePickerET.CustomFormat = "MM\'/\'dd\'/\'yyyy hh\':\'mm tt";
            this.dateTimePickerET.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerET.Location = new System.Drawing.Point(144, 274);
            this.dateTimePickerET.Name = "dateTimePickerET";
            this.dateTimePickerET.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerET.TabIndex = 7;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.labelET);
            this.Controls.Add(this.dateTimePickerET);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelST);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelCusID);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.dateTimePickerST);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCusId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAppointment";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxCusId;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePickerST;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelCusID;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelST;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelET;
        private System.Windows.Forms.DateTimePicker dateTimePickerET;
    }
}