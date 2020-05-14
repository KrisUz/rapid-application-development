using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        // private data
        private string customerName;
        private int accountNo;
        private double chargeAmount;
        private char customerType;

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                if (value != "")
                    customerName = value;
            }
        }

        public int AccountNo
        {
            get { return accountNo; }
            set
            {
                if (value < 0) value = -value;
                accountNo = value;
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

        public double ChargeAmount
        {
            get { return chargeAmount; }
            set
            {
                if (value.GetType() != typeof(string))
                {
                    chargeAmount = value;
                }
            }
        }

        public Customer() { }
        public Customer(int acctnum, string custname, char custType, double charge)
        {
            AccountNo = acctnum;
            CustomerName = custname;
            CustomerType = custType;
            ChargeAmount = charge;
        }

        public double CalculateCharge(int kWhUsage, double flatRate, double addRate, int minKwh)
        {

            if (kWhUsage < minKwh)
                chargeAmount = flatRate;
            else
                chargeAmount = flatRate + ((kWhUsage - minKwh) * addRate);

            return chargeAmount;
        }

        //This will calculate charge for residential
        public double CalculateCharge(int kWhUsage, double flatRate, double addRate)
        {
            chargeAmount = flatRate + (kWhUsage * addRate);

            return chargeAmount;
        }
        public override string ToString()
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = culture.TextInfo;
            customerName = textInfo.ToTitleCase(customerName);
            return customerName + ":\t" + accountNo.ToString() + ",\t " + customerType + ",\t" + chargeAmount.ToString("c");
        }

        //public operation (methods)

    } //class

} // namespace
