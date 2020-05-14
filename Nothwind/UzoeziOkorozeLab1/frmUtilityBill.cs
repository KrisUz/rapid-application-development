using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * CPRG 200 Lab 2 : Rapid Application Development
 * Author: Uzoezi Okoroze
 * Date: April 21, 2020
 * 
 */
namespace UzoeziOkorozeLab1
{
    public partial class frmUtilityBill : Form
    {
        // this will locate txt file stored in bin/Debug folder of the project
        const string path= "Customers.txt";
        List<Customer> customers = new List<Customer>(); // This will start the empty list of customer
        double finalcharge;
        Customer T;

        // Define constant
        const int F_RATE = 1000;
        const double F_RATE_R = 6.00;
        const double A_RATE_R = 0.052;
        const double F_RATE_C = 60.00;
        const double A_RATE_C = 0.045;
        const double F_PEAK_I = 76.00;
        const double A_PEAK_I = 0.065;
        const double F_offPEAK_I = 40.00;
        const double A_offPEAK_I = 0.028;

        public frmUtilityBill()
        {
            InitializeComponent();
        }


        // this will execute at the start of the application
        private void frmUtilityBill_Load(object sender, EventArgs e)
        {
            txtCustomerType.SelectedIndex = 0; // first customer type is selected
            txtCustomerName.Focus();

            FileStream fs;
            StreamReader sr = null;
            string line; // to read
            string[] fields;
          
            string customerName;
            int accountNumber;
            char customerType;
            double amountCharge;

            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                //read data
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine(); // next line
                    fields = line.Split(','); //CSV file
                    customerName = fields[0];
                    accountNumber = Convert.ToInt32(fields[1]);
                    customerType = Convert.ToChar(fields[2]);
                    amountCharge = Convert.ToDouble(fields[3]);
                    T = new Customer(customerName, accountNumber, customerType, amountCharge);
                    customers.Add(T);
                }
                DisplayCustomers();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading customers from file: " + 
                    ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }

        // user selected customer type from combo box
        private void txtCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(txtCustomerType.SelectedIndex) // Use switch to dispay choice selected
            {
                case 0:
                    lblMessage.Text = "You selected residential; " +
                        "The rate is $6.00 + $0.052 per kWh.";
                    lblPeakHours.Visible = true;
                    txtPeakHours.Visible = true;
                    lblOffPeakHours.Visible = false;
                    txtOffPeakHours.Visible = false;
                    break;
                case 1:
                    lblMessage.Text = "You selected Commercial; " +
                        "The Flat rate is $60.00 for the first 1000kWh " +
                        "+ $0.045 per extra kWh.";
                    lblPeakHours.Visible = true;
                    txtPeakHours.Visible = true;
                    lblOffPeakHours.Visible = false;
                    txtOffPeakHours.Visible = false;
                    break;
                case 2:
                    lblMessage.Text = "You selected Industral; " +
                        "The Rate depends on usage time (Peak rate or Off-Peak rate). " +
                        "Peak rate is $76.00 for the first 1000kWh + $0.065 per extra kWh. " +
                        "Off-Peak rate is $40.00 for the first 1000kWh + $0.028 per extra kWh.";
                    lblPeakHours.Visible = true;
                    txtPeakHours.Visible = true;
                    lblOffPeakHours.Visible = true;
                    txtOffPeakHours.Visible = true;
                    break;
                default:
                    lblMessage.Text = "Customer Type";
                    break;       
            }

        }

        // Calculate the amount for each customer type based on hours of useage and rate
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // define input
            int kWh = 0; double amount = 0;  // KWh per hours 
            int rate; double peak = 0; double offPeak = 0; // rate per hour
            Customer T = new Customer();
            // output
           
            // get the input to convert 


            // perform calculations
            if (txtCustomerType.SelectedIndex == 0) // this is for residential customer
            {
                if (Validator.IsPresent(txtPeakHours, "Hours") &&
                       Validator.IsNonNegativeInteger(txtPeakHours, "Hours"))
                {
                    kWh = Convert.ToInt32(txtPeakHours.Text); //totalAmount of kWh
                    amount = T.CalculateCharge(kWh, F_RATE_R, A_RATE_R);
                    finalcharge = amount;
                }
            }


            else if (txtCustomerType.SelectedIndex == 1) // this is for commercial customer
            {
                if (Validator.IsPresent(txtPeakHours, "Hours") &&
                       Validator.IsNonNegativeInteger(txtPeakHours, "Hours"))
                {
                    kWh = Convert.ToInt32(txtPeakHours.Text); //totalAmount of kWh

                        amount = T.CalculateCharge(kWh, F_RATE_C, A_RATE_C);
                        finalcharge = amount;

                }
            }

            else if (txtCustomerType.SelectedIndex == 2) // this is for industrial customer
            {
                if (Validator.IsPresent(txtPeakHours, "Hours") &&
                      Validator.IsNonNegativeInteger(txtPeakHours, "Hours") &&
                      Validator.IsPresent(txtOffPeakHours, "Rate") &&
                      Validator.IsNonNegativeInteger(txtOffPeakHours, "Rate")
                        )
                {
                    kWh = Convert.ToInt32(txtPeakHours.Text); //totalAmount of kWh
                    rate = Convert.ToInt32(txtOffPeakHours.Text);

                    peak = T.CalculateCharge(kWh, F_PEAK_I, A_PEAK_I);

                    offPeak = T.CalculateCharge(kWh, F_offPEAK_I, A_offPEAK_I);

                    amount = peak + offPeak;
                    finalcharge = amount;
                };

            }

            // display the result
            txtTotalAmount.Text = amount.ToString("c"); //txtTotalAmount.Text = amount.ToString("c");


        }


        // This will terminate/close the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // This will clear all textbox in the form and reset to start.
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerType.SelectedIndex = 0;
            txtPeakHours.Text = "";
            txtOffPeakHours.Text = "";
            txtTotalAmount.Text = "";
            txtPeakHours.Focus();  
            
        }


        
        // ---------Lab2--------
        // user clicks on Add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName;
            int accountNumber;
            char customerType;
            double amountCharge;
         

            // collect new product data and  create an object
            customerName = txtCustomerName.Text;
            accountNumber = Convert.ToInt32(txtAccountNumber.Text);
            customerType = Convert.ToChar(cboSelectCustomerType.Text);
            amountCharge = finalcharge;
            Customer P = new Customer(customerName, accountNumber, customerType, amountCharge);
           

            // add new product to the list
            customers.Add(P);// and refresh display
            
            DisplayCustomers();

            // generate new Customer data and create an object
            //validate customerNmae Ispresent and accountNumber Ispresent & non negetive

            FileStream fs;
            StreamWriter sw = null;
            string line;

            try
            {
                // open file for writing
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                // This will go through the loop
                foreach (Customer c in customers)
                    {
                        line = c.CustomerName + "," +  c.AccountNumber + "," + c.CustomerType + "," + c.AmountCharge;
                        sw.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing customers to file: " +
                        ex.Message, ex.GetType().ToString());
            }
            finally
            {
                 if (sw != null) sw.Close();
            }

            if (string.IsNullOrEmpty(txtCustomerName.Text))
                    return;
        }


        // user clicks on Delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstCustomer.Items.Count > 0)
                lstCustomer.Items.RemoveAt(lstCustomer.SelectedIndex);
        }

        private void DisplayCustomers()
        {
            lstCustomer.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomer.Items.Add(c);
            }
            txtCountCustomer.Text = customers.Count.ToString();

            double customerTotal = CalculateCustomerTotal();  // Total Count for Customer
            //txtCountCustomer.Text = customerTotal.ToString();

            double residentialCharge = CalculateTotalResidential(); // Total count for Residential
            txtTotalResidentialCharge.Text = residentialCharge.ToString();

            double commercialCharge = CalculateTotalCommercial(); // Total count for Commercial
            txtTotalCommercialCharge.Text = commercialCharge.ToString();

            double industrialCharge = CalculateTotalIndustrial(); // Total count for Industrial
            txtTotalIndustrialCharge.Text = industrialCharge.ToString();

            double finalcharge = CalculateTotalAmountCharge();
            txtTotalAmountCharge.Text = finalcharge.ToString();

        }


        // This method will calculate total charge for all customers

        private double CalculateCustomerTotal()
        {
            double totalCustumer= 0;
            foreach (Customer c in customers)
                totalCustumer += c.AmountCharge;
            return totalCustumer;
        }
        //This will Calculate total charge for each customer type

        private double CalculateTotalResidential()
        {
            double totalResidential= 0;
            foreach (Customer c in customers)
                totalResidential +=  c.AmountCharge;
            return totalResidential;
        }

        private double CalculateTotalCommercial()
        {
            double totalCommercial= 0;
            foreach (Customer c in customers)
                totalCommercial += c.AmountCharge;
            return totalCommercial;
        }

        private double CalculateTotalIndustrial()
        {
            double totalIndustrial= 0;
            foreach (Customer c in customers)
                totalIndustrial += c.AmountCharge;
            return totalIndustrial;
        }

        private double CalculateTotalAmountCharge()
        {
            double finalcharge = 0;
            foreach (Customer c in customers)
            {
                finalcharge += c.AmountCharge;
            }
            return finalcharge;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
