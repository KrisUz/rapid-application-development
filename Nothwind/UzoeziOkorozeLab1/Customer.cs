using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/*
 * CPRG 200 Lab 2 : Rapid Application Development
 * Author: Uzoezi Okoroze
 * Date: April 21, 2020
 * 
 */
namespace UzoeziOkorozeLab1
{
    public class Customer
    {
        // private data
        private string customerName;
        private int accountNumber;
        private char customerType;
        private double amountCharge;

        // public properties
        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value != "")
                    customerName = value;
            }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value < 0) value = -value;
                accountNumber = value;
            }

        }
        public char CustomerType
        {
            get { return customerType; }
            set
            {
                if (value == 'R')

                {
                    customerType = value;
                }
                else if (value == 'C')
                {
                    customerType = value;
                }
                else if (value == 'I')
                {
                    customerType = value;
                }
            }
        }

        public double AmountCharge
        {
            get { return amountCharge; }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    amountCharge = value;
                }
            }
        }

        // constructor
        public Customer() { }
        public Customer(string custname, int acctnum,  char custType, double amtCharge)
        {
            AccountNumber = acctnum;
            CustomerName = custname;
            CustomerType = custType;
            AmountCharge = amtCharge;
        }
        // public operations (methods)
        public double CalculateCharge(int kWhUsage, double flatRate, double addRate, int minKwh)
        {

            if (kWhUsage < minKwh)
                amountCharge = flatRate;
            else
                amountCharge = flatRate + ((kWhUsage - minKwh) * addRate);

            return amountCharge;
        }

        //This will calculate charge for residential and commercial
        public double CalculateCharge(int kWhUsage, double flatRate, double addRate)
        {
            amountCharge = flatRate + (kWhUsage * addRate);

            return amountCharge;

        }
        
        public override string ToString()
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = culture.TextInfo;
            customerName = textInfo.ToTitleCase(customerName);
            return customerName + ":\t" + accountNumber.ToString() + ",\t " + customerType + ",\t" + amountCharge.ToString("c");
        }


    } //class

} // namespace
