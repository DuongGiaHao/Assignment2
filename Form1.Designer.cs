namespace Assignment2
{
    partial class Form1
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtNumberOfPeople = new System.Windows.Forms.TextBox();
            this.txtLastMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.txtThisMonthWaterMeter = new System.Windows.Forms.TextBox();
            this.cboTypeOfCustomber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCaculator = new System.Windows.Forms.Button();
            this.lvWaterBill = new System.Windows.Forms.ListView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(69, 82);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(273, 22);
            this.txtCustomerName.TabIndex = 0;
            // 
            // txtNumberOfPeople
            // 
            this.txtNumberOfPeople.Enabled = false;
            this.txtNumberOfPeople.Location = new System.Drawing.Point(70, 187);
            this.txtNumberOfPeople.Name = "txtNumberOfPeople";
            this.txtNumberOfPeople.Size = new System.Drawing.Size(272, 22);
            this.txtNumberOfPeople.TabIndex = 1;
            // 
            // txtLastMonthWaterMeter
            // 
            this.txtLastMonthWaterMeter.Location = new System.Drawing.Point(70, 231);
            this.txtLastMonthWaterMeter.Name = "txtLastMonthWaterMeter";
            this.txtLastMonthWaterMeter.Size = new System.Drawing.Size(272, 22);
            this.txtLastMonthWaterMeter.TabIndex = 2;
            // 
            // txtThisMonthWaterMeter
            // 
            this.txtThisMonthWaterMeter.Location = new System.Drawing.Point(69, 286);
            this.txtThisMonthWaterMeter.Name = "txtThisMonthWaterMeter";
            this.txtThisMonthWaterMeter.Size = new System.Drawing.Size(273, 22);
            this.txtThisMonthWaterMeter.TabIndex = 3;
            // 
            // cboTypeOfCustomber
            // 
            this.cboTypeOfCustomber.FormattingEnabled = true;
            this.cboTypeOfCustomber.Location = new System.Drawing.Point(69, 130);
            this.cboTypeOfCustomber.Name = "cboTypeOfCustomber";
            this.cboTypeOfCustomber.Size = new System.Drawing.Size(273, 24);
            this.cboTypeOfCustomber.TabIndex = 4;
            this.cboTypeOfCustomber.SelectedIndexChanged += new System.EventHandler(this.cboTypeOfCustomber_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "CustomerName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type Of Customer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Number Of People:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Month\'s Water Meter:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "This Month\'s Water Meter:";
            // 
            // btnCaculator
            // 
            this.btnCaculator.Location = new System.Drawing.Point(245, 339);
            this.btnCaculator.Name = "btnCaculator";
            this.btnCaculator.Size = new System.Drawing.Size(97, 51);
            this.btnCaculator.TabIndex = 10;
            this.btnCaculator.Text = "Caculator";
            this.btnCaculator.UseVisualStyleBackColor = true;
            this.btnCaculator.Click += new System.EventHandler(this.btnCaculator_Click);
            // 
            // lvWaterBill
            // 
            this.lvWaterBill.FullRowSelect = true;
            this.lvWaterBill.GridLines = true;
            this.lvWaterBill.HideSelection = false;
            this.lvWaterBill.Location = new System.Drawing.Point(392, 97);
            this.lvWaterBill.Name = "lvWaterBill";
            this.lvWaterBill.Size = new System.Drawing.Size(926, 346);
            this.lvWaterBill.TabIndex = 11;
            this.lvWaterBill.UseCompatibleStateImageBehavior = false;
            this.lvWaterBill.SelectedIndexChanged += new System.EventHandler(this.lvWaterBill_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(669, 38);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(494, 33);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(46, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 47);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnCaculator);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboTypeOfCustomber);
            this.groupBox1.Controls.Add(this.txtThisMonthWaterMeter);
            this.groupBox1.Controls.Add(this.txtLastMonthWaterMeter);
            this.groupBox1.Controls.Add(this.txtNumberOfPeople);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 415);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CaculatorForm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment2.Properties.Resources.Screenshot_2024_08_19_135243;
            this.ClientSize = new System.Drawing.Size(1341, 526);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lvWaterBill);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtNumberOfPeople;
        private System.Windows.Forms.TextBox txtLastMonthWaterMeter;
        private System.Windows.Forms.TextBox txtThisMonthWaterMeter;
        private System.Windows.Forms.ComboBox cboTypeOfCustomber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCaculator;
        private System.Windows.Forms.ListView lvWaterBill;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

