/*  CPRG 200 Lab #2
 *  
 *  Author:  Corinne Mullan
 *  Date:    July 2, 2018
 *  
 *  The ValidateInput class contains methods for validating the user input on the form.
 *  The Tag property has been set on all input text boxes to indicate the value that should
 *  be entered into the box.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG200Lab2
{
    public static class ValidateInput
    {
        // Check whether the user has entered anything in the text box referenced by
        // inputBox.
        public static bool IsProvided(TextBox inputBox)
        {
            bool result;        // The return value.  True if input has been entered, false otherwise.

            if (inputBox.Text == "")
            {
                result = false;
                MessageBox.Show("Please enter a value for the " + inputBox.Tag);
                inputBox.Focus();
            }
            else
            {
                result = true;
            }

            return result;
        }

        // Check whether a non-negative integer value has been entered into the specified text box.
        // If the user has entered a decimal value, the decimal portion will be truncated.
        // Note that the value can be zero.
        public static bool IsNonNegativeInt(TextBox inputBox)
        {
            bool result;            // The return value.  True on success, false otherwise
            int val;                // To capture the value from TryParse

            if (!Int32.TryParse(inputBox.Text, out val))
            {
                result = false;
                MessageBox.Show("The " + inputBox.Tag + " must be an integer");
                inputBox.SelectAll();           // Select/highlight the contents of the text box for easy editing
                inputBox.Focus();
            }
            else                    // It is an integer
            {
                if (val < 0)
                {
                    result = false;
                    MessageBox.Show("The " + inputBox.Tag + " must be 0 or greater");
                    inputBox.SelectAll();       // Select/highlight the contents of the text box for easy editing
                    inputBox.Focus();
                }
                else
                {
                    result = true;
                }
            }

            return result;
        }

        // Check whether a positive integer value (> 0) has been entered into the specified text box.
        // If the user has entered a decimal value, the decimal portion will be truncated.
        public static bool IsPositiveInt(TextBox inputBox)
        {
            bool result;            // The return value.  True on success, false otherwise
            int val;                // To capture the value from TryParse

            if (!Int32.TryParse(inputBox.Text, out val))
            {
                result = false;
                MessageBox.Show("The " + inputBox.Tag + " must be an integer");
                inputBox.SelectAll();           // Select/highlight the contents of the text box for easy editing
                inputBox.Focus();
            }
            else                    // It is an integer
            {
                if (val <= 0)
                {
                    result = false;
                    MessageBox.Show("The " + inputBox.Tag + " must be greater than 0");
                    inputBox.SelectAll();       // Select/highlight the contents of the text box for easy editing
                    inputBox.Focus();
                }
                else
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
