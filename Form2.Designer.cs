namespace Assignment2
{
    partial class Form2
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
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblLastMonthWaterMeter = new System.Windows.Forms.Label();
            this.lblThisMonthWaterMeter = new System.Windows.Forms.Label();
            this.lblConsumption = new System.Windows.Forms.Label();
            this.lblWaterMoney = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(175, 510);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(132, 43);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CustomerName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Month\'s Water Meter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "This Month\'s Water Meter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "WaterMoney";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(227, 113);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(44, 16);
            this.lblCustomerName.TabIndex = 17;
            this.lblCustomerName.Text = "label6";
            // 
            // lblLastMonthWaterMeter
            // 
            this.lblLastMonthWaterMeter.AutoSize = true;
            this.lblLastMonthWaterMeter.Location = new System.Drawing.Point(227, 192);
            this.lblLastMonthWaterMeter.Name = "lblLastMonthWaterMeter";
            this.lblLastMonthWaterMeter.Size = new System.Drawing.Size(44, 16);
            this.lblLastMonthWaterMeter.TabIndex = 18;
            this.lblLastMonthWaterMeter.Text = "label7";
            // 
            // lblThisMonthWaterMeter
            // 
            this.lblThisMonthWaterMeter.AutoSize = true;
            this.lblThisMonthWaterMeter.Location = new System.Drawing.Point(227, 296);
            this.lblThisMonthWaterMeter.Name = "lblThisMonthWaterMeter";
            this.lblThisMonthWaterMeter.Size = new System.Drawing.Size(44, 16);
            this.lblThisMonthWaterMeter.TabIndex = 19;
            this.lblThisMonthWaterMeter.Text = "label8";
            // 
            // lblConsumption
            // 
            this.lblConsumption.AutoSize = true;
            this.lblConsumption.Location = new System.Drawing.Point(227, 381);
            this.lblConsumption.Name = "lblConsumption";
            this.lblConsumption.Size = new System.Drawing.Size(44, 16);
            this.lblConsumption.TabIndex = 20;
            this.lblConsumption.Text = "label9";
            // 
            // lblWaterMoney
            // 
            this.lblWaterMoney.AutoSize = true;
            this.lblWaterMoney.Location = new System.Drawing.Point(220, 470);
            this.lblWaterMoney.Name = "lblWaterMoney";
            this.lblWaterMoney.Size = new System.Drawing.Size(51, 16);
            this.lblWaterMoney.TabIndex = 21;
            this.lblWaterMoney.Text = "label10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(227, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Water Bill";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Assignment2.Properties.Resources.Screenshot_2024_08_19_135549;
            this.ClientSize = new System.Drawing.Size(476, 565);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblWaterMoney);
            this.Controls.Add(this.lblConsumption);
            this.Controls.Add(this.lblThisMonthWaterMeter);
            this.Controls.Add(this.lblLastMonthWaterMeter);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblLastMonthWaterMeter;
        private System.Windows.Forms.Label lblThisMonthWaterMeter;
        private System.Windows.Forms.Label lblConsumption;
        private System.Windows.Forms.Label lblWaterMoney;
        private System.Windows.Forms.Label label6;
    }
}