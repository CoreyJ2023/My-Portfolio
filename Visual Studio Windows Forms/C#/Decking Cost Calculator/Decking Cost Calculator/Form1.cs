/*
 * Programmer:      Corey Jenkins
 * Date:            February 16, 2021
 * Program Name:    Decking Cost Calculator
 * Purpose:         To create a GUI in C# which calculates the cost of a deck. Uses If/Else statements.
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

namespace Decking_Cost_Calculator
{
    public partial class frmDeckingCostCalculator : Form
    {
        public frmDeckingCostCalculator()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double decFootage;
            double decCostPerSquareFoot;
            double decCostEstimate;
            double decLumberCost = 2.35D;
            double decRedWoodCost = 7.75D;
            double decCompositeCost = 8.5D;


            if (double.TryParse(txtFootage.Text, out decFootage))
            {
                decFootage = (double)Convert.ToDecimal(txtFootage.Text);

                if (decFootage > 0)
                {
                    if (radLumber.Checked)
                    {
                        decCostPerSquareFoot = decLumberCost;
                    }
                    else if (radRedWood.Checked)
                    {
                        decCostPerSquareFoot = decRedWoodCost;
                    }
                    else if (radComposite.Checked)
                    {
                        decCostPerSquareFoot = decCompositeCost;
                    }

                        decCostEstimate = decFootage * decCompositeCost;
                        lblCostEstimate.Text = decCostEstimate.ToString("C");

                    }

                 else
                 {
                    string message = "You entered " + decFootage.ToString() + " Enter a positive number.";
                    string caption = "System Error";
                        MessageBox.Show(message, caption);
                        txtFootage.Text = "";
                        txtFootage.Focus();
                 }

                            
             }   
             else
             {
                  string message = "Enter the square Footage of Decking.";
                string caption = "System Error";
                  MessageBox.Show(message, caption);
                  txtFootage.Text = "";
                  txtFootage.Focus();
             }                   
                         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFootage.Clear();
            lblCostEstimate.Text = "";
            radLumber.Checked = true;
            radRedWood.Checked = false;
            radComposite.Checked = false;
            txtFootage.Focus();
        }

        private void frmDeckingCostCalculator_Load(object sender, EventArgs e)
        {
            txtFootage.Focus();
            lblCostEstimate.Text = "";
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This program was created by Corey Jenkins.";
            string caption = "About this program";
            MessageBox.Show(message, caption);

        }
    }
}
