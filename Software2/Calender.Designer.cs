
namespace Software2
{
    partial class Calender
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
            this.labelCalender = new System.Windows.Forms.Label();
            this.radioWeek = new System.Windows.Forms.RadioButton();
            this.radioMonth = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridViewCal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCal)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCalender
            // 
            this.labelCalender.AutoSize = true;
            this.labelCalender.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelCalender.Location = new System.Drawing.Point(452, 9);
            this.labelCalender.Name = "labelCalender";
            this.labelCalender.Size = new System.Drawing.Size(226, 28);
            this.labelCalender.TabIndex = 0;
            this.labelCalender.Text = "Appointment Calender";
            // 
            // radioWeek
            // 
            this.radioWeek.AutoSize = true;
            this.radioWeek.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioWeek.Location = new System.Drawing.Point(392, 324);
            this.radioWeek.Name = "radioWeek";
            this.radioWeek.Size = new System.Drawing.Size(223, 32);
            this.radioWeek.TabIndex = 2;
            this.radioWeek.TabStop = true;
            this.radioWeek.Text = "Weekly Appointments";
            this.radioWeek.UseVisualStyleBackColor = true;
            this.radioWeek.CheckedChanged += new System.EventHandler(this.radioWeek_CheckedChanged);
            // 
            // radioMonth
            // 
            this.radioMonth.AutoSize = true;
            this.radioMonth.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioMonth.Location = new System.Drawing.Point(668, 324);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.Size = new System.Drawing.Size(234, 32);
            this.radioMonth.TabIndex = 3;
            this.radioMonth.TabStop = true;
            this.radioMonth.Text = "Monthly Appointments";
            this.radioMonth.UseVisualStyleBackColor = true;
            this.radioMonth.CheckedChanged += new System.EventHandler(this.radioMonth_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioAll.Location = new System.Drawing.Point(113, 324);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(183, 32);
            this.radioAll.TabIndex = 1;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Appointments";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.radioAll_CheckedChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(942, 344);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // dataGridViewCal
            // 
            this.dataGridViewCal.AllowUserToAddRows = false;
            this.dataGridViewCal.AllowUserToDeleteRows = false;
            this.dataGridViewCal.AllowUserToResizeColumns = false;
            this.dataGridViewCal.AllowUserToResizeRows = false;
            this.dataGridViewCal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCal.Location = new System.Drawing.Point(12, 50);
            this.dataGridViewCal.Name = "dataGridViewCal";
            this.dataGridViewCal.ReadOnly = true;
            this.dataGridViewCal.RowHeadersVisible = false;
            this.dataGridViewCal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCal.RowTemplate.Height = 25;
            this.dataGridViewCal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCal.Size = new System.Drawing.Size(1030, 268);
            this.dataGridViewCal.TabIndex = 103;
            this.dataGridViewCal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridViewCal.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCal_CellFormatting);
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 403);
            this.Controls.Add(this.dataGridViewCal);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.radioMonth);
            this.Controls.Add(this.radioWeek);
            this.Controls.Add(this.labelCalender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calender";
            this.Text = "Calender";
            this.Load += new System.EventHandler(this.Calender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCalender;
        private System.Windows.Forms.RadioButton radioWeek;
        private System.Windows.Forms.RadioButton radioMonth;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.DataGridView dataGridViewCal;
    }
}