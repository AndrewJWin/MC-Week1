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

namespace ScoreAccumulator
{
    public partial class ScoreAccumulator : Form
    {
        public ScoreAccumulator()
        {
            InitializeComponent();
        }

        // Global variable for the Total count, so it can easily be cleared and added to easily.
        int totalCount = 0;

        // The following function verifies, adds and calculates the average of scores provided to it.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Boolean value for verifying the score text.
            bool scoreValid = decimal.TryParse(txtScore.Text, out decimal newScore);
            
            /* If the value is not in a form that can be interpreted in decimal form, an exception is thrown.
            *  It is handled by presenting the user with a MessageBox detailing what they should review.
            */
            if (!scoreValid) {
                MessageBox.Show("Invalid Score, please input numbers only.", "Error");
            } else {

                // Parsing the total that is currently there as decimal and adding the newScore, then Stringifying and replacing.
                txtTotal.Text = (decimal.Parse(txtTotal.Text) + newScore).ToString();
                
                // Quickly adding to the total count using short notation.
                totalCount++;

                // The following simply readds the values into their proper labels, Count and Average respectively.
                txtCount.Text = totalCount.ToString();
                txtAverage.Text = (decimal.Parse(txtTotal.Text) / totalCount).ToString();
            }

        }

        // Clear button function, simply sets all variables and Text objects to a set value. Either 0, "" or "0".
        private void btnClear_Click(object sender, EventArgs e)
        {
            totalCount = 0;
            txtScore.Text = "";
            txtTotal.Text = "0";
            txtCount.Text = "0";
            txtAverage.Text = "";
        }

        // Exit button function, simply exits the program.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
