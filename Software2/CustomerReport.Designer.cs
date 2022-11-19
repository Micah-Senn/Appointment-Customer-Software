
namespace Software2
{
    partial class CustomerReport
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
            this.comboBoxCus = new System.Windows.Forms.ComboBox();
            this.dataGridViewCus = new System.Windows.Forms.DataGridView();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.labelSel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCus
            // 
            this.comboBoxCus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCus.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCus.FormattingEnabled = true;
            this.comboBoxCus.Location = new System.Drawing.Point(381, 356);
            this.comboBoxCus.Name = "comboBoxCus";
            this.comboBoxCus.Size = new System.Drawing.Size(295, 36);
            this.comboBoxCus.TabIndex = 114;
            this.comboBoxCus.SelectedIndexChanged += new System.EventHandler(this.comboBoxCus_SelectedIndexChanged);
            // 
            // dataGridViewCus
            // 
            this.dataGridViewCus.AllowUserToAddRows = false;
            this.dataGridViewCus.AllowUserToDeleteRows = false;
            this.dataGridViewCus.AllowUserToResizeColumns = false;
            this.dataGridViewCus.AllowUserToResizeRows = false;
            this.dataGridViewCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridViewCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCus.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewCus.Name = "dataGridViewCus";
            this.dataGridViewCus.ReadOnly = true;
            this.dataGridViewCus.RowTemplate.Height = 25;
            this.dataGridViewCus.Size = new System.Drawing.Size(1030, 268);
            this.dataGridViewCus.TabIndex = 113;
            this.dataGridViewCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCus_CellContentClick);
            this.dataGridViewCus.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewCus_CellFormatting);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(942, 347);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 45);
            this.buttonExit.TabIndex = 112;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(443, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(173, 28);
            this.labelMain.TabIndex = 111;
            this.labelMain.Text = "Customer Report";
            // 
            // labelSel
            // 
            this.labelSel.AutoSize = true;
            this.labelSel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSel.Location = new System.Drawing.Point(445, 324);
            this.labelSel.Name = "labelSel";
            this.labelSel.Size = new System.Drawing.Size(165, 21);
            this.labelSel.TabIndex = 115;
            this.labelSel.Text = "Select a customer ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 116;
            this.label1.Text = "Customer ID:";
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSel);
            this.Controls.Add(this.comboBoxCus);
            this.Controls.Add(this.dataGridViewCus);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerReport";
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCus;
        private System.Windows.Forms.DataGridView dataGridViewCus;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Label labelSel;
        private System.Windows.Forms.Label label1;
    }
}