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
    public partial class Form1 : Form
    {
        // List to store invoice data
        public List<Invoice> invoices = new List<Invoice>();

        // VAT rate constant
        public const double VAT = 0.1;
        public Form1()
        {
            InitializeComponent();
      
        }

        // Event handler for form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate customer type dropdown
            cboTypeOfCustomber.Items.Add("Household customer");
            cboTypeOfCustomber.Items.Add("Administrative agency, public services");
            cboTypeOfCustomber.Items.Add("Production units");
            cboTypeOfCustomber.Items.Add("Business services");


            // Configure ListView columns
            lvWaterBill.View = View.Details;
            lvWaterBill.Columns.Add("Customer Name", 200);
            lvWaterBill.Columns.Add("Last Month Water Meter", 200);
            lvWaterBill.Columns.Add("Last This Water Meter", 200);
            lvWaterBill.Columns.Add("Amount Of Consumption", 200);
            lvWaterBill.Columns.Add("Total Water Bill", 200);
        }

        // Event handler for customer type selection change
        private void cboTypeOfCustomber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string customerType = cboTypeOfCustomber.Text;

            // Enable or disable the number of people field based on customer type
            if (customerType == "Household customer")
            {
                txtNumberOfPeople.Enabled = true;
            }
            else
            {
                txtNumberOfPeople.Enabled = false;
                txtNumberOfPeople.Text = "";
            }
        }

        // Event handler for calculate button click
        private void btnCaculator_Click(object sender, EventArgs e)
        {
            // Retrieve input values
            string customerName = txtCustomerName.Text.Trim();
            string customerType = cboTypeOfCustomber.Text;
            int numberOfPeople = 0;
            double lastMonthWaterMeter = 0;
            double thisMonthWaterMeter = 0;


            if (customerName == "")
            {
                MessageBox.Show("Please enter customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customerType == "")
            {
                MessageBox.Show("Please enter customer type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (customerType == "Househole customer")
            {
                if (!int.TryParse(txtNumberOfPeople.Text, out numberOfPeople) || numberOfPeople <= 0)
                {
                    MessageBox.Show("Please enter number of people.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!double.TryParse(txtLastMonthWaterMeter.Text, out lastMonthWaterMeter) || lastMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter last month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtThisMonthWaterMeter.Text, out thisMonthWaterMeter) || thisMonthWaterMeter < 0)
            {
                MessageBox.Show("Please enter this month's water meter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (thisMonthWaterMeter < lastMonthWaterMeter)
            {
                MessageBox.Show("This month's water meter reading cannot be less than last month's reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Calculate water bill
            var waterBill = Calculator(customerType, numberOfPeople, lastMonthWaterMeter, thisMonthWaterMeter);

            // Add the calculated data to ListView
            ListViewItem item = new ListViewItem(customerName);
            item.SubItems.Add(lastMonthWaterMeter.ToString());
            item.SubItems.Add(thisMonthWaterMeter.ToString());
            item.SubItems.Add(waterBill.Item1.ToString());
            item.SubItems.Add(waterBill.Item2.ToString());
            lvWaterBill.Items.Add(item);

            Invoice invoice = new Invoice
            {
                // Create and add an invoice object to the list
                CustomerName = customerName,
                LastMonthWaterMeter = lastMonthWaterMeter,
                ThisMonthWaterMeter = thisMonthWaterMeter,
                Consumption = waterBill.Item1,
                WaterMoney = waterBill.Item2,
            };
            invoices.Add(invoice);
        }


        // This method calculates the water bill based on customer type and water consumption
        private (double, double) Calculator(string customerType, int numberOfMember, double lastMonthWaterMeter, double thisMonthwatermeter)
        {
            double consumption = thisMonthwatermeter - lastMonthWaterMeter;
            double waterMoney = 0;

            // Calculate water bill based on customer type
            if (customerType == "Household customer")
            {
                double averagePerson = consumption / numberOfMember;
                if (averagePerson < 10)
                {
                    waterMoney = consumption * 5973;
                }
                else if (averagePerson >= 10 && averagePerson < 20)
                {
                    waterMoney = consumption * 7052;
                }
                else if (averagePerson >= 20 && averagePerson < 30)
                {
                    waterMoney = consumption * 8699;
                }
                else if (averagePerson >= 30)
                {
                    waterMoney = consumption * 15929;
                }
            }
            else if (customerType == "Administrative agency, public services")
            {
                waterMoney = consumption * 9955;
            }
            else if (customerType == "Production units")
            {
                waterMoney = consumption * 11615;
            }
            else if (customerType == "Business services")
            {
                waterMoney = consumption * 22068;
            }

            // Apply VAT to the water bill
            waterMoney += (waterMoney * VAT);

            return (consumption, waterMoney);
        }

        // Event handler for search text change
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            lvWaterBill.Items.Clear();
            bool foundResult = false;

            // Display all invoices if search is empty
            if (search == "")
            {
                foreach (Invoice invoice in invoices)
                {

                    ListViewItem item = new ListViewItem(invoice.CustomerName);
                    item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                    item.SubItems.Add(invoice.Consumption.ToString());
                    item.SubItems.Add(invoice.WaterMoney.ToString());
                    lvWaterBill.Items.Add(item);

                }
                foundResult = true;
            }
            else
            {
                // Display invoices matching the search text
                foreach (Invoice invoice in invoices)
                {
                    if (invoice.CustomerName.ToLower().Contains(search))
                    {
                        ListViewItem item = new ListViewItem(invoice.CustomerName);
                        item.SubItems.Add(invoice.LastMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.ThisMonthWaterMeter.ToString());
                        item.SubItems.Add(invoice.Consumption.ToString());
                        item.SubItems.Add(invoice.WaterMoney.ToString());
                        lvWaterBill.Items.Add(item);
                        foundResult = true;
                    }
                }
            }
            if (!foundResult)
            {
                // Display message if no results found
                ListViewItem item = new ListViewItem("No results found");
                lvWaterBill.Items.Add(item);
            }
        }

        // Confirm exit action
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
            // If the user selects "No", the application will remain open.
        }

        // Event handler for ListView item selection
        private void lvWaterBill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvWaterBill.SelectedItems.Count > 0)
            {
                int index = lvWaterBill.SelectedItems[0].Index;
                if (index >= 0 && index < invoices.Count)
                {
                    // Display detailed invoice information in a new form
                    Form2 bill = new Form2(invoices[index].CustomerName, invoices[index].LastMonthWaterMeter, invoices[index].ThisMonthWaterMeter, invoices[index].Consumption, invoices[index].WaterMoney);
                    bill.Show();
                }
            }
        }

        // Class to represent an invoice
        public class Invoice
        {
            public string CustomerName { get; set; }
            public double LastMonthWaterMeter { get; set; }
            public double ThisMonthWaterMeter { get; set; }
            public double Consumption { get; set; }
            public double WaterMoney { get; set; }
        }    
    }
}

        