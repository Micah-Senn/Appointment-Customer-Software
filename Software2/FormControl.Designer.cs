
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
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.buttonModifyApp = new System.Windows.Forms.Button();
            this.buttonDeleteApp = new System.Windows.Forms.Button();
            this.buttonAddCus = new System.Windows.Forms.Button();
            this.buttonModCus = new System.Windows.Forms.Button();
            this.buttonDeleteCus = new System.Windows.Forms.Button();
            this.buttonCal = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.labelMain.Location = new System.Drawing.Point(335, 9);
            this.labelMain.Margin = new System.Windows.Forms.Padding(5);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(207, 28);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Scheduling Software";
            // 
            // buttonAddApp
            // 
            this.buttonAddApp.Location = new System.Drawing.Point(286, 253);
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
            this.buttonModifyApp.Location = new System.Drawing.Point(396, 253);
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
            this.buttonDeleteApp.Location = new System.Drawing.Point(506, 253);
            this.buttonDeleteApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteApp.Name = "buttonDeleteApp";
            this.buttonDeleteApp.Size = new System.Drawing.Size(100, 45);
            this.buttonDeleteApp.TabIndex = 3;
            this.buttonDeleteApp.Text = "Delete";
            this.buttonDeleteApp.UseVisualStyleBackColor = true;
            // 
            // buttonAddCus
            // 
            this.buttonAddCus.Location = new System.Drawing.Point(72, 549);
            this.buttonAddCus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddCus.Name = "buttonAddCus";
            this.buttonAddCus.Size = new System.Drawing.Size(100, 45);
            this.buttonAddCus.TabIndex = 4;
            this.buttonAddCus.Text = "Add";
            this.buttonAddCus.UseVisualStyleBackColor = true;
            // 
            // buttonModCus
            // 
            this.buttonModCus.Location = new System.Drawing.Point(297, 549);
            this.buttonModCus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonModCus.Name = "buttonModCus";
            this.buttonModCus.Size = new System.Drawing.Size(100, 45);
            this.buttonModCus.TabIndex = 5;
            this.buttonModCus.Text = "Modify";
            this.buttonModCus.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteCus
            // 
            this.buttonDeleteCus.Location = new System.Drawing.Point(506, 549);
            this.buttonDeleteCus.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDeleteCus.Name = "buttonDeleteCus";
            this.buttonDeleteCus.Size = new System.Drawing.Size(100, 45);
            this.buttonDeleteCus.TabIndex = 6;
            this.buttonDeleteCus.Text = "Delete";
            this.buttonDeleteCus.UseVisualStyleBackColor = true;
            // 
            // buttonCal
            // 
            this.buttonCal.Location = new System.Drawing.Point(681, 360);
            this.buttonCal.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCal.Name = "buttonCal";
            this.buttonCal.Size = new System.Drawing.Size(176, 29);
            this.buttonCal.TabIndex = 7;
            this.buttonCal.Text = "View Calender";
            this.buttonCal.UseVisualStyleBackColor = true;
            this.buttonCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(681, 399);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "Appointment Type Report";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 438);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Scheduling Report";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 477);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 29);
            this.button4.TabIndex = 10;
            this.button4.Text = "Customer Report";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(681, 565);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(72, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(736, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(72, 341);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(534, 202);
            this.dataGridView2.TabIndex = 13;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 608);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonCal);
            this.Controls.Add(this.buttonDeleteCus);
            this.Controls.Add(this.buttonModCus);
            this.Controls.Add(this.buttonAddCus);
            this.Controls.Add(this.buttonDeleteApp);
            this.Controls.Add(this.buttonModifyApp);
            this.Controls.Add(this.buttonAddApp);
            this.Controls.Add(this.labelMain);
            this.Name = "FormControl";
            this.Text = "Scheduling Software";
            this.Load += new System.EventHandler(this.FormControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.Button buttonModifyApp;
        private System.Windows.Forms.Button buttonDeleteApp;
        private System.Windows.Forms.Button buttonAddCus;
        private System.Windows.Forms.Button buttonModCus;
        private System.Windows.Forms.Button buttonDeleteCus;
        private System.Windows.Forms.Button buttonCal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}