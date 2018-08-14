/*  CPRG 200 Lab #2
 *  
 *  Author:  Corinne Mullan
 *  Date:    July 2, 2018
 *  
 *  frmElectricityCharges.cs contains event handlers for the Electricity Charges form.
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200Lab2
{
    public partial class frmElectricityCharges : Form
    {
        // Variable declarations
        List<Customer> custList = new List<Customer>();      // Create an empty list for the customer data

        // Constructor
        public frmElectricityCharges()
        {
            InitializeComponent();
        }

        // When the form loads, initialize the fields on the the form and display the saved customer data.
        private void frmElectricityCharges_Load(object sender, EventArgs e)
        {
            // Set the customer type to residential and put the focus on the usage input text box.  The text 
            // fields will be null when the form first loads so this does not need to be done manually.
            cboType.SelectedItem = "Residential";
            lblUsage.Text = "Electricity Usage in kWh:";
            txtUsage.Tag = "electricity usage";
            lblUsagePeak.Visible = false;
            txtUsagePeak.Visible = false;
            txtUsage.Focus();

            // Also read and display the data from the Customers.txt file, and display
            // the associated calculations
            custList = CustomerFile.ReadCustomers();
            DisplayCustomerInfo();
        }

        // Reset all fields if the user clicks the Reset button.  Reset the customer
        // type to residential, blank out the text boxes, and set the focus to the 
        // usage text box.  The button has been named "Reset" rather than "Clear" so that
        // its first letter can be used as a shortcut key since alt-C is already used for
        // "Calculate".
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAcctNum.Text = "";
            cboType.SelectedItem = "Residential";
            lblUsage.Text = "Electricity Usage in kWh:";
            txtUsage.Tag = "electricity usage";
            lblUsagePeak.Visible = false;
            txtUsagePeak.Visible = false;
            txtUsage.Text = "";
            lblCharges.Text = "";
            txtUsage.Focus();
        }

        // Exit the application when the user clicks the Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // When the combo box indicating the customer type is changed, make the peak usage
        // label and text box visible if the type is "Industrial"; otherwise, hide these
        // controls.  Also change the label of the main usage input field to indicate
        // whether it is off-peak usage (industrial), or overall usage (residential or
        // commercial).
        // Additionally, reset all the fields when the customer type is changed and put
        // the focus on txtUsage in prepration for entering new data.
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.Text.Contains("Industrial"))
            {
                lblUsage.Text = "Off-Peak Usage in kWh:";
                txtUsage.Tag = "off-peak usage";
                lblUsagePeak.Visible = true;
                txtUsagePeak.Visible = true;

                txtUsage.Text = "";
                txtUsagePeak.Text = "";
                lblCharges.Text = "";
                txtUsage.Focus();
            }
            else
            {
                lblUsage.Text = "Electricity Usage in kWh:";
                txtUsage.Tag = "electricity usage";
                lblUsagePeak.Visible = false;
                txtUsagePeak.Visible = false;

                txtUsage.Text = "";
                txtUsagePeak.Text = "";
                lblCharges.Text = "";
                txtUsage.Focus();
            }
        }

        // When the "Calculate and Add" button is clicked, obtain the user input (with validation) and
        // execute the calculations to determine the customers's total charges.  The new data is also
        // added to the Customers.txt file, and displayed in the list box.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            bool success = false;       // Indicates whether the calculation was successful

            // Obtain the customer type from the combo box.  cboType.DropDownStyle has been
            // set to DropDownList, so the user cannot type in anything, and the selection will
            // always be either residential, commercial or industrial, and there is no need for
            // a default case.

            // In all cases, verify that input has been provided for all fields (customer name, account,
            // and usage(s)).  Verify that the account number is a positive integer, and that the usage
            // field(s) are non-negative integers.

            switch(cboType.SelectedItem.ToString())
            {
                case "Residential":
                    // Validate and obtain the user input
                    if (ValidateInput.IsProvided(txtName)
                        && ValidateInput.IsProvided(txtAcctNum)
                        && ValidateInput.IsPositiveInt(txtAcctNum)
                        && ValidateInput.IsProvided(txtUsage)
                        && ValidateInput.IsNonNegativeInt(txtUsage))
                    {
                        ResidentialCustomer rc = new ResidentialCustomer(Convert.ToInt32(txtAcctNum.Text),
                                                 txtName.Text);
                        rc.UsageKWH = Convert.ToInt32(txtUsage.Text);
                        rc.CalculateCharge();
                        lblCharges.Text = rc.ChargeAmount.ToString("c");
                        custList.Add(rc);
                        success = true;
                    }
                    break;

                case "Commercial":
                    // Validate and obtain the user input
                    if (ValidateInput.IsProvided(txtName)
                        && ValidateInput.IsProvided(txtAcctNum)
                        && ValidateInput.IsPositiveInt(txtAcctNum)
                        && ValidateInput.IsProvided(txtUsage)
                        && ValidateInput.IsNonNegativeInt(txtUsage))
                    {
                        CommercialCustomer cc = new CommercialCustomer(Convert.ToInt32(txtAcctNum.Text),
                                                txtName.Text);
                        cc.UsageKWH = Convert.ToInt32(txtUsage.Text);
                        cc.CalculateCharge();
                        lblCharges.Text = cc.ChargeAmount.ToString("c");
                        custList.Add(cc);
                        success = true;
                    }
                    break;

                case "Industrial":
                    // Validate and obtain the user inputs (both off-peak and peak usages)
                    if (ValidateInput.IsProvided(txtName)
                        && ValidateInput.IsProvided(txtAcctNum)
                        && ValidateInput.IsPositiveInt(txtAcctNum)
                        && ValidateInput.IsProvided(txtUsage)
                        && ValidateInput.IsNonNegativeInt(txtUsage)
                        && ValidateInput.IsProvided(txtUsagePeak)
                        && ValidateInput.IsNonNegativeInt(txtUsagePeak))
                    {
                        IndustrialCustomer ic = new IndustrialCustomer(Convert.ToInt32(txtAcctNum.Text),
                                                txtName.Text);
                        ic.UsageKWH = Convert.ToInt32(txtUsage.Text);
                        ic.UsagePeakKWH = Convert.ToInt32(txtUsagePeak.Text);
                        ic.CalculateCharge();
                        lblCharges.Text = ic.ChargeAmount.ToString("c");
                        custList.Add(ic);
                        success = true;
                    }
                    break;
            }

            // Re-display all of the customer data in the list box (the newly added customer
            // information will now appear).
            // No checking is done to determine whether the customer and/or account number already
            // exist in the file; assume that multiple charges can appear in the file for the 
            // same customer/account.
            if (success)
            {
                CustomerFile.WriteCustomers(custList);
                DisplayCustomerInfo();
            }

        }

        // The DisplayCustomerInfo() method displays the information in the custList list to the
        // listbox on the form, and also displays the total number of customers, subtotals for
        // charges for each customer type, and the grand total of the charges.
        private void DisplayCustomerInfo()
        {
            // Variable declarations
            double resCharges = 0;          // The total charges for all residential customers
            double comCharges = 0;          // The total charges for all commercial customers
            double indCharges = 0;          // The total charges for all industrial customers

            List<string> lstNames = new List<string>();    // Create a list to hold the customer names.
                                                           // This will be used to count the number of
                                                           // distinct customers.

            // Clear the customer list box on the form
            lstCustomers.Items.Clear();

            // Loop through the list of customers, displaying the customer data and
            // calculating the required totals
            foreach (Customer c in custList)
            {
                lstCustomers.Items.Add(c);       // The ToString() method will automatically be called

                lstNames.Add(c.CustomerName);    // Add the customer name to the list of names

                switch(c.CustomerType)
                {
                    case 'R':
                        resCharges += c.ChargeAmount;
                        break;

                    case 'C':
                        comCharges += c.ChargeAmount;
                        break;

                    case 'I':
                        indCharges += c.ChargeAmount;
                        break;
                }
            }

            // Display the required customer count and totals
            lblNumCust.Text = lstNames.Distinct().Count().ToString();   // A customer may appear more than
                                                                        // once in Customers.txt, if they have
                                                                        // incurred multiple charges.  Here, 
                                                                        // only count the number of distinct
                                                                        // occurrences of the customer name.
            lblResTotal.Text = resCharges.ToString("c");
            lblComTotal.Text = comCharges.ToString("c");
            lblIndTotal.Text = indCharges.ToString("c");
            lblGrandTotal.Text = (resCharges + comCharges + indCharges).ToString("c");
        }

    }
}
