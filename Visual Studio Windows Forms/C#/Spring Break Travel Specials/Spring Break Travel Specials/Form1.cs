/*
 * Programmer:      Corey Jenkins
 * Date:            February 17, 2021 (Updated February 8, 2023)
 * Program Name:    Spring break Travel Specials
 * Purpose:         To create a program in which you can select which destination you want to go.
 *                  Once selected, it cannot be changed again. A message will appear once it has been selected.
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

namespace Spring_Break_Travel_Specials
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMyrtleBeach_Click(object sender, EventArgs e)
        {
            picMyrtleBeach.Visible = true;
            picVeniceBeach.Visible = false;
            picKeyWest.Visible = false;

        }

        private void btnKeyWest_Click(object sender, EventArgs e)
        {
            picKeyWest.Visible = true;
            picVeniceBeach.Visible = false;
            picMyrtleBeach.Visible = false;

        }

        private void btnVeniceBeach_Click(object sender, EventArgs e)
        {
            picVeniceBeach.Visible = true;
            picKeyWest.Visible = false;
            picMyrtleBeach.Visible = false;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            btnKeyWest.Enabled = false;
            btnVeniceBeach.Enabled = false;
            btnMyrtleBeach.Enabled = false;
            btnPurchase.Enabled = false;
            lblEnjoy.Visible = true;

        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
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
