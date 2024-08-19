using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form2 : Form
    {
        string CustomerName;
        double LastMonthWaterMeter;
        double ThisMonthWaterMeter;
        double Consumption;
        double WaterMoney;
        public Form2(string CustomerName, double LastMonthWaterMeter, double ThisMonthWaterMeter, double Consumption, double WaterMoney )
        {
            InitializeComponent();

            this.CustomerName = CustomerName;
            this.LastMonthWaterMeter = LastMonthWaterMeter;
            this.ThisMonthWaterMeter = ThisMonthWaterMeter;
            this.Consumption = Consumption; 
            this.WaterMoney = WaterMoney;   


            lblCustomerName.Text = CustomerName;
            lblLastMonthWaterMeter.Text = ThisMonthWaterMeter.ToString();
            lblThisMonthWaterMeter.Text = LastMonthWaterMeter.ToString();
            lblConsumption.Text = Consumption.ToString();   
            lblWaterMoney.Text = WaterMoney.ToString(); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment success");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                Close();       
        }
    }
}
