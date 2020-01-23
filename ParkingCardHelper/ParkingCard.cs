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

namespace ParkingCardHelper
{
    public partial class ParkingHelper : Form
    {
        public ParkingHelper()
        {
            InitializeComponent();
        }

        // Calculate Button function.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool creditValid = Double.TryParse(txtCreditAdded.Text, out double creditAdded),
                 costOneParkWithCardValid = Double.TryParse(txtOneParkWithCard.Text, out double costOneParkWithCard),
                 costOneParkNoCardValid = Double.TryParse(txtOneParkNoCard.Text, out double costOneParkNoCard);
            /*
             * Validating the Credit added, Cost of parking with card and without card as Boolean.
             */

            if (creditValid && costOneParkWithCardValid && costOneParkNoCardValid)
            {
                // Calculate the number of days parked with the card with the availible credit.
                int daysParking = (int)(creditAdded / costOneParkWithCard);

                /*
                 * Calculate the Credit remaining after we use the card as many times as possible evenly.
                 * Then figure out the price difference between using the card and not.
                 * Finally getting the total savings for using the card using the price difference.
                 */

                double creditRemaining = creditAdded % costOneParkWithCard,
                       oneDaySavings = costOneParkNoCard - costOneParkWithCard,
                       totalSavings = daysParking * oneDaySavings;


                // Set all the following text boxes to their respective values, using the currency marker to set values in monetary sense. 
                txtDaysParking.Text = daysParking.ToString();
                txtCreditRemaining.Text = creditRemaining.ToString("c");
                txtSaved.Text = totalSavings.ToString("c");
            }
            else
            {
                // If the value of credit or the price of parking with the Card is invalid - Respond accordingly.
                MessageBox.Show("Please enter values in numerical form.", "Error");
            }
        }

        // Closing Button function
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Simply close the program.
            this.Close();
        }
    }
}
