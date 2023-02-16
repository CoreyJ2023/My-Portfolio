
namespace Decking_Cost_Calculator
{
    partial class frmDeckingCostCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeckingCostCalculator));
            this.radLumber = new System.Windows.Forms.RadioButton();
            this.picDeck = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCostEstimate = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.grpDeckType = new System.Windows.Forms.GroupBox();
            this.radComposite = new System.Windows.Forms.RadioButton();
            this.radRedWood = new System.Windows.Forms.RadioButton();
            this.txtFootage = new System.Windows.Forms.TextBox();
            this.lblSquareFeet = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).BeginInit();
            this.grpDeckType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radLumber
            // 
            this.radLumber.AutoSize = true;
            this.radLumber.Checked = true;
            this.radLumber.ForeColor = System.Drawing.Color.Sienna;
            this.radLumber.Location = new System.Drawing.Point(16, 22);
            this.radLumber.Name = "radLumber";
            this.radLumber.Size = new System.Drawing.Size(244, 28);
            this.radLumber.TabIndex = 0;
            this.radLumber.TabStop = true;
            this.radLumber.Text = "Pressure-Treated Lumber";
            this.radLumber.UseVisualStyleBackColor = true;
            // 
            // picDeck
            // 
            this.picDeck.Image = ((System.Drawing.Image)(resources.GetObject("picDeck.Image")));
            this.picDeck.Location = new System.Drawing.Point(463, 1);
            this.picDeck.Name = "picDeck";
            this.picDeck.Size = new System.Drawing.Size(338, 390);
            this.picDeck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDeck.TabIndex = 17;
            this.picDeck.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Sienna;
            this.btnClear.Location = new System.Drawing.Point(206, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 41);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Sienna;
            this.btnCalculate.Location = new System.Drawing.Point(31, 360);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(146, 41);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCostEstimate
            // 
            this.lblCostEstimate.AutoSize = true;
            this.lblCostEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostEstimate.ForeColor = System.Drawing.Color.Sienna;
            this.lblCostEstimate.Location = new System.Drawing.Point(239, 309);
            this.lblCostEstimate.Name = "lblCostEstimate";
            this.lblCostEstimate.Size = new System.Drawing.Size(110, 25);
            this.lblCostEstimate.TabIndex = 14;
            this.lblCostEstimate.Text = "$0000.00";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Sienna;
            this.lblCost.Location = new System.Drawing.Point(50, 309);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(172, 25);
            this.lblCost.TabIndex = 13;
            this.lblCost.Text = "Cost Estimate: ";
            // 
            // grpDeckType
            // 
            this.grpDeckType.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDeckType.Controls.Add(this.radComposite);
            this.grpDeckType.Controls.Add(this.radRedWood);
            this.grpDeckType.Controls.Add(this.radLumber);
            this.grpDeckType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDeckType.ForeColor = System.Drawing.Color.Sienna;
            this.grpDeckType.Location = new System.Drawing.Point(57, 189);
            this.grpDeckType.Name = "grpDeckType";
            this.grpDeckType.Size = new System.Drawing.Size(265, 106);
            this.grpDeckType.TabIndex = 12;
            this.grpDeckType.TabStop = false;
            this.grpDeckType.Text = "Decking Type";
            // 
            // radComposite
            // 
            this.radComposite.AutoSize = true;
            this.radComposite.ForeColor = System.Drawing.Color.Sienna;
            this.radComposite.Location = new System.Drawing.Point(16, 73);
            this.radComposite.Name = "radComposite";
            this.radComposite.Size = new System.Drawing.Size(118, 28);
            this.radComposite.TabIndex = 2;
            this.radComposite.Text = "Composite";
            this.radComposite.UseVisualStyleBackColor = true;
            // 
            // radRedWood
            // 
            this.radRedWood.AutoSize = true;
            this.radRedWood.ForeColor = System.Drawing.Color.Sienna;
            this.radRedWood.Location = new System.Drawing.Point(16, 46);
            this.radRedWood.Name = "radRedWood";
            this.radRedWood.Size = new System.Drawing.Size(110, 28);
            this.radRedWood.TabIndex = 1;
            this.radRedWood.Text = "Redwood";
            this.radRedWood.UseVisualStyleBackColor = true;
            // 
            // txtFootage
            // 
            this.txtFootage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFootage.ForeColor = System.Drawing.Color.Sienna;
            this.txtFootage.Location = new System.Drawing.Point(244, 136);
            this.txtFootage.Name = "txtFootage";
            this.txtFootage.Size = new System.Drawing.Size(57, 31);
            this.txtFootage.TabIndex = 11;
            this.txtFootage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSquareFeet
            // 
            this.lblSquareFeet.AutoSize = true;
            this.lblSquareFeet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSquareFeet.ForeColor = System.Drawing.Color.Sienna;
            this.lblSquareFeet.Location = new System.Drawing.Point(50, 136);
            this.lblSquareFeet.Name = "lblSquareFeet";
            this.lblSquareFeet.Size = new System.Drawing.Size(187, 25);
            this.lblSquareFeet.TabIndex = 10;
            this.lblSquareFeet.Text = "Square Footage:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Sienna;
            this.lblHeading.Location = new System.Drawing.Point(24, 48);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(394, 37);
            this.lblHeading.TabIndex = 9;
            this.lblHeading.Text = "Decking Cost Calculator ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmDeckingCostCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picDeck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCostEstimate);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.grpDeckType);
            this.Controls.Add(this.txtFootage);
            this.Controls.Add(this.lblSquareFeet);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDeckingCostCalculator";
            this.Text = "Decking Cost Calculator";
            this.Load += new System.EventHandler(this.frmDeckingCostCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDeck)).EndInit();
            this.grpDeckType.ResumeLayout(false);
            this.grpDeckType.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton radLumber;
        internal System.Windows.Forms.PictureBox picDeck;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnCalculate;
        internal System.Windows.Forms.Label lblCostEstimate;
        internal System.Windows.Forms.Label lblCost;
        internal System.Windows.Forms.GroupBox grpDeckType;
        internal System.Windows.Forms.RadioButton radComposite;
        internal System.Windows.Forms.RadioButton radRedWood;
        internal System.Windows.Forms.TextBox txtFootage;
        internal System.Windows.Forms.Label lblSquareFeet;
        internal System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

