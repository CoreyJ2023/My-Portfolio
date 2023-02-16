/* Programmer:      Corey Jenkins
 * Date:            February 15, 2021
 * Program Name:    Beach Bike Rentals
 * Purpose:         To create a program in C# that inputs the amount of days and how much it will cost per day. 
 *                  This is done by assigning variables and doing basic math formulas. A constant variable is used.
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

namespace Beach_Bike_Rentals
{
    public partial class frmBeachBikeRentals : Form
    {
        // This is the area where you can place constants and other things.
        const double PRICE_PER_DAY = 9.95;
        public frmBeachBikeRentals()
        {
            InitializeComponent();
        }

        private void btnCost_Click(object sender, EventArgs e)
        {
            string strNumberOfDays;
            int intNumberOfDays;
            double totalCost;

            strNumberOfDays = txtNumberofDays.Text;
            intNumberOfDays = Convert.ToInt32(strNumberOfDays);
            totalCost = intNumberOfDays * PRICE_PER_DAY;
            lblTotalCost.Text = totalCost.ToString("C");

            lblTotalCost.Visible = true;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumberofDays.Clear();
            lblTotalCost.Text = "";
            txtNumberofDays.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBeachBikeRentals_Load(object sender, EventArgs e)
        {
            lblCostHeading.Text = PRICE_PER_DAY.ToString("C") + " per Day";
            lblTotalCost.Text = "";
            txtNumberofDays.Focus();
        }
    }
}
