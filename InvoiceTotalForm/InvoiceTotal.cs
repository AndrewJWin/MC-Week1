using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************\
*                                  *
* Andrew Terwilliger 1/23/2020     *
* Minneapolis College              *
* ITEC 2505-60 C# Programming      *
*                                  *
\**********************************/

namespace InvoiceTotalForm
{
    public partial class InvoiceTotalCalc : Form
    {
        public InvoiceTotalCalc()
        {
            InitializeComponent();
        }

        // "Calculate" button code, runs the calculation process onto the provided subtotal to provide a discounted price.
        private void button1_Click(object sender, EventArgs e)
        {
            bool subtotalValid = decimal.TryParse(subTotalTxt.Text, out decimal subtotal);

            // Reviewing if the subtotal is valid, if not respond accordingly.
            if (!subtotalValid) {
                MessageBox.Show("Invalid subtotal, numbers only please.", "Error");
            }
            else {
                // Declaring discountPercent ahead of time.
                decimal discountPercent = 0m;

                /*
                 * Calculation of discounts, percentile is calculated as follows:
                 * 
                 * If subtotal is greater than $500, the discount is 20%
                 * If subtotal is greater than $250, but less than $500 - the discount is 15%
                 * If subtotal is greater than $100, bus less than $250 - the discount is 10%
                 */

                if (subtotal >= 500) {
                    discountPercent = .2m;
                    discPercent.Text = "20%";
                }
                else if (subtotal >= 250 && subtotal < 500) {
                    discountPercent = .15m;
                    discPercent.Text = "15%";
                }
                else if (subtotal >= 100 && subtotal < 250) {
                    discountPercent = .1m;
                    discPercent.Text = "10%";
                }
                else {
                    discPercent.Text = "0%";
                }

                // Quickly calculating the discount amount after figuring out the percentage to reduce clutter.
                decimal discountAmt = subtotal * discountPercent;     

                // Display discount and final total after discount to their respective objects.
                discAmount.Text = discountAmt.ToString("c");
                totalTxt.Text = (subtotal - discountAmt).ToString("c");
            }
        }

        // "Exit" button code, simply tells the program to close
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
