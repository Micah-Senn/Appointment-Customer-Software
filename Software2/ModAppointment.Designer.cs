
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
            this.labelType = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.labelCusID = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelAppID = new System.Windows.Forms.Label();
            this.dateTimePickerET = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerST = new System.Windows.Forms.DateTimePicker();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.textBoxCusId = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxAppId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(263, 402);
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
            this.buttonSave.Location = new System.Drawing.Point(153, 402);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 45);
            this.buttonSave.TabIndex = 52;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Modify Appointment";
            // 
            // labelST
            // 
            this.labelST.AutoSize = true;
            this.labelST.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelST.Location = new System.Drawing.Point(24, 268);
            this.labelST.Name = "labelST";
            this.labelST.Size = new System.Drawing.Size(78, 19);
            this.labelST.TabIndex = 77;
            this.labelST.Text = "Start Time";
            // 
            // labelET
            // 
            this.labelET.AutoSize = true;
            this.labelET.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelET.Location = new System.Drawing.Point(24, 297);
            this.labelET.Name = "labelET";
            this.labelET.Size = new System.Drawing.Size(70, 19);
            this.labelET.TabIndex = 76;
            this.labelET.Text = "End Time";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(24, 237);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(41, 19);
            this.labelType.TabIndex = 73;
            this.labelType.Text = "Type";
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDesc.Location = new System.Drawing.Point(24, 200);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(85, 19);
            this.labelDesc.TabIndex = 70;
            this.labelDesc.Text = "Description";
            // 
            // labelCusID
            // 
            this.labelCusID.AutoSize = true;
            this.labelCusID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCusID.Location = new System.Drawing.Point(24, 171);
            this.labelCusID.Name = "labelCusID";
            this.labelCusID.Size = new System.Drawing.Size(91, 19);
            this.labelCusID.TabIndex = 68;
            this.labelCusID.Text = "Customer ID";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUserID.Location = new System.Drawing.Point(24, 138);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(57, 19);
            this.labelUserID.TabIndex = 67;
            this.labelUserID.Text = "User ID";
            // 
            // labelAppID
            // 
            this.labelAppID.AutoSize = true;
            this.labelAppID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAppID.Location = new System.Drawing.Point(24, 109);
            this.labelAppID.Name = "labelAppID";
            this.labelAppID.Size = new System.Drawing.Size(115, 19);
            this.labelAppID.TabIndex = 66;
            this.labelAppID.Text = "Appointment ID";
            // 
            // dateTimePickerET
            // 
            this.dateTimePickerET.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerET.Location = new System.Drawing.Point(147, 297);
            this.dateTimePickerET.Name = "dateTimePickerET";
            this.dateTimePickerET.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerET.TabIndex = 7;
            // 
            // dateTimePickerST
            // 
            this.dateTimePickerST.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerST.Location = new System.Drawing.Point(147, 268);
            this.dateTimePickerST.Name = "dateTimePickerST";
            this.dateTimePickerST.Size = new System.Drawing.Size(216, 23);
            this.dateTimePickerST.TabIndex = 6;
            this.dateTimePickerST.ValueChanged += new System.EventHandler(this.dateTimePickerST_ValueChanged);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(147, 237);
            this.textBoxType.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(216, 23);
            this.textBoxType.TabIndex = 4;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(147, 204);
            this.textBoxDesc.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(216, 23);
            this.textBoxDesc.TabIndex = 3;
            // 
            // textBoxCusId
            // 
            this.textBoxCusId.Location = new System.Drawing.Point(147, 171);
            this.textBoxCusId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxCusId.Name = "textBoxCusId";
            this.textBoxCusId.Size = new System.Drawing.Size(216, 23);
            this.textBoxCusId.TabIndex = 2;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(147, 138);
            this.textBoxUserId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(216, 23);
            this.textBoxUserId.TabIndex = 1;
            // 
            // textBoxAppId
            // 
            this.textBoxAppId.Location = new System.Drawing.Point(147, 105);
            this.textBoxAppId.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxAppId.Name = "textBoxAppId";
            this.textBoxAppId.ReadOnly = true;
            this.textBoxAppId.Size = new System.Drawing.Size(216, 23);
            this.textBoxAppId.TabIndex = 54;
            // 
            // ModAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.labelST);
            this.Controls.Add(this.labelET);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.labelCusID);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelAppID);
            this.Controls.Add(this.dateTimePickerET);
            this.Controls.Add(this.dateTimePickerST);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxCusId);
            this.Controls.Add(this.textBoxUserId);
            this.Controls.Add(this.textBoxAppId);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModAppointment";
            this.Text = "ModAppointment";
            this.Load += new System.EventHandler(this.ModAppointment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelST;
        private System.Windows.Forms.Label labelET;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Label labelCusID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelAppID;
        private System.Windows.Forms.DateTimePicker dateTimePickerET;
        private System.Windows.Forms.DateTimePicker dateTimePickerST;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.TextBox textBoxCusId;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.TextBox textBoxAppId;
    }
}