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

namespace RecipeHelper
{
    public partial class RecipeHelper : Form
    {
        public RecipeHelper()
        {
            InitializeComponent();
        }
        
        /*
         * Convert to Fahrenheit button function, validates Celsius input, does math and presents the converted temperature.
         */
        private void convertFC_Click(object sender, EventArgs e)
        {
            bool celsiusValid = double.TryParse(txtCelsius.Text, out double parseCelsius);

            // Validating if the value of the Celsius feild is actually a number, if not inform the user where the error is.
            if (!celsiusValid) {
                MessageBox.Show("Invalid input for Farhenheit Converter, please input numbers only.", "Error");
            } else {
                
                // Simple conversion and replacement function.
                double convertedFahren = parseCelsius / 5 * 9 + 32;
                txtFahren.Text = convertedFahren.ToString("f2");
            }
        }

        /*
         * Convert to Cups button function, validates Milliliter input, does math and presents the converted volume.
         */
        private void convertMC_Click(object sender, EventArgs e)
        {
            bool milliValid = double.TryParse(txtMilli.Text, out double parseMilli);

            // Validating if the value of the Milliliter feild is actually a number, if not inform the user where the error is.
            if (!milliValid) {
                MessageBox.Show("Invalid input for Milliliter Converter, please input numbers only.", "Error");               
            } else {

                // Once again a simple conversion and replacement function.
                double convertedCups = parseMilli / 263.59;
                txtCups.Text = convertedCups.ToString("f2");

            }
        }
    }
}
