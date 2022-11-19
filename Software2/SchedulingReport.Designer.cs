
namespace Software2
{
    partial class SchedulingReport
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
            this.dataGridViewSch = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSch
            // 
            this.dataGridViewSch.AllowUserToAddRows = false;
            this.dataGridViewSch.AllowUserToDeleteRows = false;
            this.dataGridViewSch.AllowUserToResizeColumns = false;
            this.dataGridViewSch.AllowUserToResizeRows = false;
            this.dataGridViewSch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewSch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSch.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewSch.Name = "dataGridViewSch";
            this.dataGridViewSch.ReadOnly = true;
            this.dataGridViewSch.RowHeadersVisible = false;
            this.dataGridViewSch.RowTemplate.Height = 25;
            this.dataGridViewSch.Size = new System.Drawing.Size(1030, 268);
            this.dataGridViewSch.TabIndex = 109;
            this.dataGridViewSch.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewSch_CellFormatting);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(942, 346);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 108;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(387, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(295, 28);
            this.labelMain.TabIndex = 104;
            this.labelMain.Text = "Consultant Scheduling Report";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Items.AddRange(new object[] {
            "User 1",
            "User 2"});
            this.comboBoxUsers.Location = new System.Drawing.Point(387, 355);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(295, 36);
            this.comboBoxUsers.TabIndex = 110;
            this.comboBoxUsers.SelectedIndexChanged += new System.EventHandler(this.comboBoxUsers_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(452, 326);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(156, 21);
            this.labelUser.TabIndex = 111;
            this.labelUser.Text = "Please select a user";
            // 
            // SchedulingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 403);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.dataGridViewSch);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SchedulingReport";
            this.Text = "SchedulingReport";
            this.Load += new System.EventHandler(this.SchedulingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSch;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Label labelUser;
    }
}