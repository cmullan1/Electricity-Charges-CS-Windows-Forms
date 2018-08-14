/*  CPRG 200 Lab #2
 *  
 *  Author:  Corinne Mullan
 *  Date:    July 2, 2018
 *  
 *  The Customer.cs file contains code for the Customer, ResidentialCustomer, CommercialCustomer, 
 *  and IndustrialCustomer classes.  This includes the CalculateCharge() and ToString() methods.
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200Lab2
{
    // -------------------------  Customer Class ------------------------------------------ //
    public class Customer
    {
        // Protected data and public accessor properties

        protected int accountNo;                    // The account number
        public int AccountNo
        {
            get { return accountNo; }
            set { accountNo = (value < 1) ? 1 : value; }    // Require the account number to be a positive integer
        }

        public string CustomerName { get; set; }    // The customer name


        protected char customerType;                // The customer type ('R', 'C' or 'I')
        public char CustomerType
        {
            get { return customerType; }
            // The customer type is either 'R', 'C' or 'I'.  Default to 'R' if the value
            // is anything other than 'C'/'c' or 'I'/'i'
            set
            {
                if (value == 'C' || value == 'c')
                    customerType = 'C';
                else if (value == 'I' || value == 'i')
                    customerType = 'I';
                else
                    customerType = 'R';
            }
        }

        protected int usageKWH;                     // The customers usage (total usage for residential
                                                    // or commercial; off-peak for industrial
        public int UsageKWH
        {
            get { return usageKWH; }
            set { usageKWH = (value < 0) ? 0 : value; }     // Require the usage to be non-negative
        }

        public double ChargeAmount { get; set; }    // The customer's total charge amount

        // Public constructor
        // Use default values if no parameters are supplied.
        public Customer(int custAcct = 0, char custType = 'R', string custName = "", double custCharges = 0)
        {
            AccountNo = custAcct;
            CustomerType = custType;
            CustomerName = custName;
            ChargeAmount = custCharges;
        }

        // Public methods

        // The CalculateCharge() method is just a placeholder than will be overridden in the 
        // derived classes.  Do not use an abstract method/class here, as it will be useful to
        // instantiate objects using the Customer base class in parts of the the program (i.e.,
        // when reading and writing from the Customers.txt file).
        public virtual void CalculateCharge()
        {
            return;
        }

        // Return a string suitable for displaying the customer information to the screen.
        public override string ToString()
        {
            // The charge amount can be displayed to the screen using the currency format.
            return AccountNo.ToString() + "\t" + CustomerName + "\t" + CustomerType + "\t"
                   + ChargeAmount.ToString("c");
        }

        // Return a string suitable for writing the customer information to the customers.txt
        // file.  
        public string ToFileString()
        {
            // Round the charge amount to two decimal places, but do not include a "$" in
            // the text file.
            return AccountNo.ToString() + "," + CustomerName + "," + CustomerType + ","
                   + ChargeAmount.ToString("0.##");
        }

    }

    // -------------------------  Residential Customer class ------------------------------ //
    // Inherits from the Customer class
    public class ResidentialCustomer : Customer
    {
        // Public constructor 
        public ResidentialCustomer(int a = 0, string n = "", double c = 0) : base(a, 'R', n, c) { }

        // Implement the CalculateCharge() method
        public override void CalculateCharge()
        {
            // Declare constants
            const double RES_FLAT_RATE = 6;
            const double RES_MULTIPLIER = 0.052;

            // Calculate and return the total charges
            ChargeAmount = (RES_FLAT_RATE + RES_MULTIPLIER * UsageKWH);
        }
    }

    // -------------------------  Commercial Customer class ------------------------------- //
    // Inherits from the Customer class
    public class CommercialCustomer : Customer
    {
        // Public constructor 
        public CommercialCustomer(int a = 0, string n = "", double c = 0) : base(a, 'C', n, c) { }

        // Implement the CalculateCharge() method
        public override void CalculateCharge()
        {
            // Declare constants
            const double COM_FLAT_RATE = 60;
            const double COM_MULTIPLIER = 0.045;
            const double COM_BASELINE = 1000;

            // Calculate and return the total charges
            ChargeAmount = COM_FLAT_RATE;
            if (usageKWH > COM_BASELINE)
            {
                ChargeAmount += COM_MULTIPLIER * (usageKWH - COM_BASELINE);
            }
        }
    }

    // -------------------------  Industrial Customer class ------------------------------- //
    // Inherits from the Customer class
    public class IndustrialCustomer : Customer
    {
        // Private data and public accessors
        // Add a peak usage variable for the industrial customer.  The usageKWH variable will
        // store the off-peak usage in this case.
        private int usagePeakKWH;
        public int UsagePeakKWH
        {
            get { return usagePeakKWH; }
            set { usagePeakKWH = (value < 0) ? 0 : value; }
        }

        // Public constructor 
        public IndustrialCustomer(int a = 0, string n = "", double c = 0) : base(a, 'I', n, c) { }

        // Implement the CalculateCharge() method
        public override void CalculateCharge()
        {
            // Declare constants
            const double IND_BASELINE = 1000;
            const double IND_OFFPEAK_FLAT_RATE = 40;
            const double IND_OFFPEAK_MULTIPLIER = 0.028;
            const double IND_PEAK_FLAT_RATE = 76;
            const double IND_PEAK_MULTIPLIER = 0.065;

            // Calculate and return the total charges.
            // Both the off-peak and peak flat rates are always charged, even when the
            // consumption is zero.
            ChargeAmount = IND_OFFPEAK_FLAT_RATE + IND_PEAK_FLAT_RATE;

            if (UsageKWH > IND_BASELINE)
            {
                ChargeAmount += IND_OFFPEAK_MULTIPLIER * (UsageKWH - IND_BASELINE);
            }

            if (UsagePeakKWH > IND_BASELINE)
            {
                ChargeAmount += IND_PEAK_MULTIPLIER * (UsagePeakKWH - IND_BASELINE);
            }

        }
    }
}
