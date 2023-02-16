using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latte_Selection
{
    public partial class frmLatteSelection : Form
    {
        public frmLatteSelection()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            btnMocha.Enabled = false;
            btnPumpkin.Enabled = false;
            btnSelect.Enabled = false;
            btnExit.Enabled = true;
            lblConfirmation.Visible = true;
            lblInstructions.Visible = false;
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); 
           
        }

        private void btnPumpkin_Click(object sender, EventArgs e)
        {
            picMocha.Visible = false;
            picPumpkin.Visible = true;
        }

        private void btnMocha_Click(object sender, EventArgs e)
        {
            picPumpkin.Visible = false;
            picMocha.Visible = true;
        }

        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caption = "About this program";
            string message = "This program has been created by Corey Jenkins.";
            MessageBox.Show(message, caption);

        }
    }
}
