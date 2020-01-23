using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginningTemplate
{
    public partial class BusCost : Form
    {
        public BusCost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double busFare = 2.0;
            int trips = 0;
            if (Int32.TryParse(txtTrips.Text, out trips))
            {
                double total = busFare * trips;
                txtTotal.Text = "$" + total;
            }
            else
            {
                MessageBox.Show("Enter only Numbers please.", "Error");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
