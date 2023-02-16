/* 
 * Programmer:      Corey Jenkins
 * Date:            February 18, 2021 (Updated February 4, 2023)
 * Program Name:    The Big Movie Theater
 * Purpose:         To create a program that inputs the name of the movie and the number of tickets. The user will then
 *                  choose from, Senior, Adult or Children. It will then be calculated and everything will be shown below.
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

namespace Big_Movie_Theater
{
    public partial class frmBigMovie : Form
    {
        public frmBigMovie()
        {
            InitializeComponent();
        }

        private void grpTicketOption_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTickets.Clear();
            txtTickets.Text = "";
            txtTickets.Focus();
            txtMovie.Clear();
            txtMovie.Text = "";
            txtMovie.Focus();
            radAdult.Checked = true;
            radSenior.Checked = false;
            radChild.Checked = false;

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string strMovie;
            int tickets;
            double ticketType = 3;
            double ticketSenior = 9.75;
            double ticketAdult = 11.5;
            double ticketChild = 8.5;
            double totalPrice;

            if (int.TryParse(txtTickets.Text, out tickets))
            {
                tickets = Convert.ToInt32(txtTickets.Text);
                if (tickets > 0)
                {
                    if (radAdult.Checked)
                    {
                        ticketType = ticketAdult;
                    }
                    else if (radSenior.Checked)
                    {
                        ticketType = ticketSenior;
                    }
                    else if (radChild.Checked)
                    {
                        ticketType = ticketChild;

                    }
                    totalPrice = tickets * ticketAdult;
                    lblLastPrice.Text = totalPrice.ToString("C");
                    lblTicketsPurchased.Text = tickets.ToString();
                    lblPrice.Text = ticketType.ToString();

                    lblMovieNameResults.Visible = true;
                    lblTicketResults.Visible = true;
                    lblTicketType.Visible = true;
                    lblTotalPrice.Visible = true;
                    lblTitle.Visible = true;
                    lblTicketsPurchased.Visible = true;
                    lblPrice.Visible = true;
                    lblTotalPrice.Visible = true;
                    lblLastPrice.Visible = true;

                }

                else
                {
                    string warningMessage = "You have entered a negative number or 0. Please enter a number greater than 0.";
                    string caption = "Input Error";
                    MessageBox.Show(warningMessage, caption);
                    txtTickets.Text = "";
                    txtTickets.Focus();

                }


            }

            else
            {
                string messageWarning = "You have entered text. Please enter a number.";
                string caption = "Input Error";
                MessageBox.Show(messageWarning, caption);
                txtTickets.Text = "";
                txtTickets.Focus();
            }

            strMovie = txtMovie.Text;
            lblTitle.Text = strMovie.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
