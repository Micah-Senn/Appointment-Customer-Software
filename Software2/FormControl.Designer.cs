
namespace Software2
{
    partial class FormControl
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
            this.labelAppointments = new System.Windows.Forms.Label();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.buttonModifyApp = new System.Windows.Forms.Button();
            this.buttonDeleteApp = new System.Windows.Forms.Button();
            this.buttonAddCus = new System.Windows.Forms.Button();
            this.buttonModCus = new System.Windows.Forms.Button();
            this.buttonDeleteCus = new System.Windows.Forms.Button();
            this.buttonCal = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonCusReport = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.AppointmentGridView = new System.Windows.Forms.DataGridView();
            this.CustomersGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointments
            // 
            this.labelAppointments.AutoSize = true;
            this.labelAppointments.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelAppointments.Location = new System.Drawing.Point(14, 14);
            this.labelAppointments.Margin = new System.Windows.Forms.Padding(5);
            this.labelAppointments.Name = "labelAppointments";
            this.labelAppointments.Size = new System.Drawing.Size(146, 28);
            this.labelAppointments.TabIndex = 0;
            this.labelAppointments.Text = "Appointments";
            // 
            // buttonAddApp
            // 
            this.buttonAddApp.Location = new System.Drawing.Point(537, 264);
            this.buttonAddApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddApp.Name = "buttonAddApp";
            this.buttonAddApp.Size = new System.Drawing.Size(100, 45);
            this.buttonAddApp.TabIndex = 1;
            this.buttonAddApp.Text = "Add";
            this.buttonAddApp.UseVisualStyleBackColor = true;
            this.buttonAddApp.Click += new System.EventHandler(this.buttonAddApp_Click);
            // 
            // buttonModifyApp
            // 
            this.buttonModifyApp.Location = new System.Drawing.Point(647, 264);
            this.buttonModifyApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonModifyApp.Name = "buttonModifyApp";
            this.buttonModifyApp.Size = new System.Drawing.Size(100, 45);
            this.buttonModifyApp.TabIndex = 2;
            this.buttonModifyApp.Text = "Modify";
            this.buttonModifyApp.UseVisualStyleBackColor = true;
            this.buttonModifyApp.Click += new System.EventHandler(this.buttonModifyApp_Click);
            // 
            // buttonDeleteApp
            // 
            this.buttonDeleteApp.Location = new System.Drawing.Point(757, 264);
            this.buttonDeleteApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteApp.Name = "buttonDeleteApp";
            this.buttonDeleteApp.Size = new System.Drawing.Size(100, 45);
            this.buttonDeleteApp.TabIndex = 3;
            this.buttonDeleteApp.Text = "Delete";
            this.buttonDeleteApp.UseVisualStyleBackColor = true;
            // 
            // buttonAddCus
            // 
            this.buttonAddCus.Location = new System.Drawing.Point(317, 553);
            this.buttonAddCus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCus.Name = "buttonAddCus";
            this.buttonAddCus.Size = new System.Drawing.Size(100, 45);
            this.buttonAddCus.TabIndex = 4;
            this.buttonAddCus.Text = "Add";
            this.buttonAddCus.UseVisualStyleBackColor = true;
            this.buttonAddCus.Click += new System.EventHandler(this.buttonAddCus_Click);
            // 
            // buttonModCus
            // 
            this.buttonModCus.Location = new System.Drawing.Point(427, 553);
            this.buttonModCus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonModCus.Name = "buttonModCus";
            this.buttonModCus.Size = new System.Drawing.Size(100, 45);
            this.buttonModCus.TabIndex = 5;
            this.buttonModCus.Text = "Modify";
            this.buttonModCus.UseVisualStyleBackColor = true;
            this.buttonModCus.Click += new System.EventHandler(this.buttonModCus_Click);
            // 
            // buttonDeleteCus
            // 
            this.buttonDeleteCus.Location = new System.Drawing.Point(537, 553);
            this.buttonDeleteCus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteCus.Name = "buttonDeleteCus";
            this.buttonDeleteCus.Size = new System.Drawing.Size(100, 45);
            this.buttonDeleteCus.TabIndex = 6;
            this.buttonDeleteCus.Text = "Delete";
            this.buttonDeleteCus.UseVisualStyleBackColor = true;
            this.buttonDeleteCus.Click += new System.EventHandler(this.buttonDeleteCus_Click);
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(681, 341);
            this.buttonCal.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(176, 29);
            this.buttonCal.TabIndex = 7;
            this.buttonCal.Text = "View Calender";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonType
            // 
            this.buttonType.Location = new System.Drawing.Point(681, 380);
            this.buttonType.Margin = new System.Windows.Forms.Padding(5);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(176, 29);
            this.buttonType.TabIndex = 8;
            this.buttonType.Text = "Appointment Type Report";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Location = new System.Drawing.Point(681, 419);
            this.buttonSchedule.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(176, 29);
            this.buttonSchedule.TabIndex = 9;
            this.buttonSchedule.Text = "Scheduling Report";
            this.buttonSchedule.UseVisualStyleBackColor = true;
            this.buttonSchedule.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCusReport
            // 
            this.buttonCusReport.Location = new System.Drawing.Point(681, 458);
            this.buttonCusReport.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCusReport.Name = "buttonCusReport";
            this.buttonCusReport.Size = new System.Drawing.Size(176, 29);
            this.buttonCusReport.TabIndex = 10;
            this.buttonCusReport.Text = "Customer Report";
            this.buttonCusReport.UseVisualStyleBackColor = true;
            this.buttonCusReport.Click += new System.EventHandler(this.buttonCusReport_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(681, 565);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 29);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.button5_Click);
            // 
            // AppointmentGridView
            // 
            this.AppointmentGridView.AllowUserToAddRows = false;
            this.AppointmentGridView.AllowUserToDeleteRows = false;
            this.AppointmentGridView.AllowUserToResizeColumns = false;
            this.AppointmentGridView.AllowUserToResizeRows = false;
            this.AppointmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGridView.Location = new System.Drawing.Point(14, 52);
            this.AppointmentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.AppointmentGridView.Name = "AppointmentGridView";
            this.AppointmentGridView.ReadOnly = true;
            this.AppointmentGridView.RowHeadersVisible = false;
            this.AppointmentGridView.RowTemplate.Height = 25;
            this.AppointmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentGridView.Size = new System.Drawing.Size(843, 202);
            this.AppointmentGridView.TabIndex = 12;
            this.AppointmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGridView_CellContentClick);
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.AllowUserToAddRows = false;
            this.CustomersGridView.AllowUserToDeleteRows = false;
            this.CustomersGridView.AllowUserToResizeColumns = false;
            this.CustomersGridView.AllowUserToResizeRows = false;
            this.CustomersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Location = new System.Drawing.Point(14, 341);
            this.CustomersGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.ReadOnly = true;
            this.CustomersGridView.RowHeadersVisible = false;
            this.CustomersGridView.RowTemplate.Height = 25;
            this.CustomersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGridView.Size = new System.Drawing.Size(623, 202);
            this.CustomersGridView.TabIndex = 13;
            this.CustomersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customers";
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 608);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomersGridView);
            this.Controls.Add(this.AppointmentGridView);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCusReport);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonType);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.buttonDeleteCus);
            this.Controls.Add(this.buttonModCus);
            this.Controls.Add(this.buttonAddCus);
            this.Controls.Add(this.buttonDeleteApp);
            this.Controls.Add(this.buttonModifyApp);
            this.Controls.Add(this.buttonAddApp);
            this.Controls.Add(this.labelAppointments);
            this.Name = "FormControl";
            this.Text = "Scheduling Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormControl_FormClosed);
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.Shown += new System.EventHandler(this.FormControl_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAppointments;
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.Button buttonModifyApp;
        private System.Windows.Forms.Button buttonDeleteApp;
        private System.Windows.Forms.Button buttonAddCus;
        private System.Windows.Forms.Button buttonModCus;
        private System.Windows.Forms.Button buttonDeleteCus;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonCusReport;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView AppointmentGridView;
        private System.Windows.Forms.DataGridView CustomersGridView;
        private System.Windows.Forms.Label label1;
    }
}