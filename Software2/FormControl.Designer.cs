
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
            this.textBoxSearchApp = new System.Windows.Forms.TextBox();
            this.textBoxSearchCus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAppointments
            // 
            this.labelAppointments.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.buttonAddApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddApp.Location = new System.Drawing.Point(650, 264);
            this.buttonAddApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddApp.Name = "buttonAddApp";
            this.buttonAddApp.Size = new System.Drawing.Size(100, 27);
            this.buttonAddApp.TabIndex = 1;
            this.buttonAddApp.Text = "Add";
            this.buttonAddApp.UseVisualStyleBackColor = true;
            this.buttonAddApp.Click += new System.EventHandler(this.buttonAddApp_Click);
            // 
            // buttonModifyApp
            // 
            this.buttonModifyApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifyApp.Location = new System.Drawing.Point(760, 264);
            this.buttonModifyApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonModifyApp.Name = "buttonModifyApp";
            this.buttonModifyApp.Size = new System.Drawing.Size(100, 27);
            this.buttonModifyApp.TabIndex = 2;
            this.buttonModifyApp.Text = "Modify";
            this.buttonModifyApp.UseVisualStyleBackColor = true;
            this.buttonModifyApp.Click += new System.EventHandler(this.buttonModifyApp_Click);
            // 
            // buttonDeleteApp
            // 
            this.buttonDeleteApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteApp.Location = new System.Drawing.Point(870, 264);
            this.buttonDeleteApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteApp.Name = "buttonDeleteApp";
            this.buttonDeleteApp.Size = new System.Drawing.Size(100, 27);
            this.buttonDeleteApp.TabIndex = 3;
            this.buttonDeleteApp.Text = "Delete";
            this.buttonDeleteApp.UseVisualStyleBackColor = true;
            this.buttonDeleteApp.Click += new System.EventHandler(this.buttonDeleteApp_Click);
            // 
            // buttonAddCus
            // 
            this.buttonAddCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddCus.Location = new System.Drawing.Point(430, 549);
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
            this.buttonModCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModCus.Location = new System.Drawing.Point(540, 549);
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
            this.buttonDeleteCus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDeleteCus.Location = new System.Drawing.Point(650, 549);
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
            this.buttonCal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCal.Location = new System.Drawing.Point(794, 341);
            this.buttonCal.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(176, 29);
            this.buttonCal.TabIndex = 7;
            this.buttonCal.Text = "View Calendar";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonType
            // 
            this.buttonType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonType.Location = new System.Drawing.Point(794, 380);
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
            this.buttonSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSchedule.Location = new System.Drawing.Point(794, 419);
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
            this.buttonCusReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCusReport.Location = new System.Drawing.Point(794, 458);
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
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.Location = new System.Drawing.Point(794, 549);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 45);
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
            this.AppointmentGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppointmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AppointmentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.AppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentGridView.Location = new System.Drawing.Point(14, 52);
            this.AppointmentGridView.Margin = new System.Windows.Forms.Padding(5);
            this.AppointmentGridView.Name = "AppointmentGridView";
            this.AppointmentGridView.ReadOnly = true;
            this.AppointmentGridView.RowHeadersVisible = false;
            this.AppointmentGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.AppointmentGridView.RowTemplate.Height = 25;
            this.AppointmentGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AppointmentGridView.Size = new System.Drawing.Size(956, 202);
            this.AppointmentGridView.TabIndex = 12;
            this.AppointmentGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AppointmentGridView_CellContentClick);
            this.AppointmentGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.AppointmentGridView_CellFormatting);
            // 
            // CustomersGridView
            // 
            this.CustomersGridView.AllowUserToAddRows = false;
            this.CustomersGridView.AllowUserToDeleteRows = false;
            this.CustomersGridView.AllowUserToResizeColumns = false;
            this.CustomersGridView.AllowUserToResizeRows = false;
            this.CustomersGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CustomersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.CustomersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGridView.Location = new System.Drawing.Point(14, 341);
            this.CustomersGridView.Margin = new System.Windows.Forms.Padding(5);
            this.CustomersGridView.Name = "CustomersGridView";
            this.CustomersGridView.ReadOnly = true;
            this.CustomersGridView.RowHeadersVisible = false;
            this.CustomersGridView.RowTemplate.Height = 25;
            this.CustomersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGridView.Size = new System.Drawing.Size(736, 202);
            this.CustomersGridView.TabIndex = 13;
            this.CustomersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Customers";
            // 
            // textBoxSearchApp
            // 
            this.textBoxSearchApp.Location = new System.Drawing.Point(760, 22);
            this.textBoxSearchApp.Name = "textBoxSearchApp";
            this.textBoxSearchApp.PlaceholderText = "Search Appointments";
            this.textBoxSearchApp.Size = new System.Drawing.Size(210, 23);
            this.textBoxSearchApp.TabIndex = 16;
            this.textBoxSearchApp.TextChanged += new System.EventHandler(this.textBoxSearchApp_TextChanged);
            // 
            // textBoxSearchCus
            // 
            this.textBoxSearchCus.Location = new System.Drawing.Point(540, 311);
            this.textBoxSearchCus.Name = "textBoxSearchCus";
            this.textBoxSearchCus.PlaceholderText = "Search Customers";
            this.textBoxSearchCus.Size = new System.Drawing.Size(210, 23);
            this.textBoxSearchCus.TabIndex = 17;
            this.textBoxSearchCus.TextChanged += new System.EventHandler(this.textBoxSearchCus_TextChanged);
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(984, 608);
            this.Controls.Add(this.textBoxSearchCus);
            this.Controls.Add(this.textBoxSearchApp);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox textBoxSearchApp;
        private System.Windows.Forms.TextBox textBoxSearchCus;
    }
}