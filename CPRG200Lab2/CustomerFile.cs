/*  CPRG 200 Lab #2
 *  
 *  Author:  Corinne Mullan
 *  Date:    July 2, 2018
 *  
 *  CustomerFile.cs contains code for the CustomerFile class, with methods for reading and 
 *  writing to the Customers.txt file.
 * 
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG200Lab2
{
    public static class CustomerFile
    {
        // Hardcode the name of the file that will be used to store customer data.
        // It will be called Customers.txt and located in the same folder as the .exe file
        // for the program.
        const string path = "Customers.txt";

        // The ReadCustomers() method reads all customer data from Customers.txt and returns
        // it in a list.
        public static List<Customer> ReadCustomers()
        {
            List<Customer> customerList = new List<Customer>();       // Empty list for the customer information
            FileStream fs = null;           // File stream object for Customers.txt
            StreamReader sr = null;         // Strem reader object for Customers.txt

            // Local variables used for reading from the file
            string line;            // The line as a whole
            string[] parts;         // The comma-delimited parts
            Customer cust;          // The customer object

            try
            {
                // Open the file for reading.  If the file does not exist (i.e., the very 
                // first time the program is run), create it.
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);

                // Read data from the file
                while (!sr.EndOfStream)             // Loop until the end of the file is reached
                {
                    line = sr.ReadLine();
                    parts = line.Split(',');        // Split where commas are

                    // Create another customer object, populate its properties, and add to the list
                    cust = new Customer();
                    cust.AccountNo = Convert.ToInt32(parts[0]);
                    cust.CustomerName = parts[1];
                    cust.CustomerType = Convert.ToChar(parts[2]);
                    cust.ChargeAmount = Convert.ToDouble(parts[3]);

                    customerList.Add(cust);
                }
            }
            catch (Exception ex)
            {
                throw ex;       // Pass the exception to the calling code (form)
            }
            finally
            {
                if (sr != null) sr.Close();     // Important to close else won't be able to re-open file for writing
                                                // Will also close the associated filestream
            }

            return customerList;
        }

        public static void WriteCustomers(List<Customer> customerList)
        {
            FileStream fs = null;       // File stream object for Customers.txt
            StreamWriter sw = null;     // Stream writer object for Customers.txt

            try
            {
                // Create will overwrite the existing file if it exists  
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                // Save data
                foreach (Customer c in customerList)
                    sw.WriteLine(c.ToFileString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close();         // Close the stream writer and the associated filestream
            }
        }
    }
}
