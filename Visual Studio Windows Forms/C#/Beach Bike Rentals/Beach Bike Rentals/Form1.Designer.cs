
namespace Beach_Bike_Rentals
{
    partial class frmBeachBikeRentals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeachBikeRentals));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCostHeading = new System.Windows.Forms.Label();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.txtNumberofDays = new System.Windows.Forms.TextBox();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.btnCost = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBikes = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBikes)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(80, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(222, 29);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Beach Bike Rentals";
            // 
            // lblCostHeading
            // 
            this.lblCostHeading.AutoSize = true;
            this.lblCostHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostHeading.Location = new System.Drawing.Point(134, 56);
            this.lblCostHeading.Name = "lblCostHeading";
            this.lblCostHeading.Size = new System.Drawing.Size(111, 20);
            this.lblCostHeading.TabIndex = 3;
            this.lblCostHeading.Text = "$X.XX per day";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDays.Location = new System.Drawing.Point(28, 89);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(178, 20);
            this.lblNumberOfDays.TabIndex = 4;
            this.lblNumberOfDays.Text = "Number of Rental Days:";
            // 
            // txtNumberofDays
            // 
            this.txtNumberofDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberofDays.Location = new System.Drawing.Point(212, 89);
            this.txtNumberofDays.Name = "txtNumberofDays";
            this.txtNumberofDays.Size = new System.Drawing.Size(100, 26);
            this.txtNumberofDays.TabIndex = 5;
            this.txtNumberofDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLabel.Location = new System.Drawing.Point(28, 132);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(197, 20);
            this.lblTotalLabel.TabIndex = 6;
            this.lblTotalLabel.Text = "Total Cost of Bike Rentals:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(235, 132);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(67, 20);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "$888.88";
            this.lblTotalCost.Visible = false;
            // 
            // btnCost
            // 
            this.btnCost.BackColor = System.Drawing.Color.Gold;
            this.btnCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCost.Location = new System.Drawing.Point(32, 179);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(92, 23);
            this.btnCost.TabIndex = 8;
            this.btnCost.Text = "Find Cost";
            this.btnCost.UseVisualStyleBackColor = false;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gold;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(147, 179);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gold;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(265, 179);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picBikes
            // 
            this.picBikes.Image = ((System.Drawing.Image)(resources.GetObject("picBikes.Image")));
            this.picBikes.Location = new System.Drawing.Point(-3, 257);
            this.picBikes.Name = "picBikes";
            this.picBikes.Size = new System.Drawing.Size(407, 206);
            this.picBikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBikes.TabIndex = 11;
            this.picBikes.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(404, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmBeachBikeRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 462);
            this.Controls.Add(this.picBikes);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblTotalLabel);
            this.Controls.Add(this.txtNumberofDays);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.lblCostHeading);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBeachBikeRentals";
            this.Text = "Beach Bike Rentals";
            this.Load += new System.EventHandler(this.frmBeachBikeRentals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBikes)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblHeading;
        internal System.Windows.Forms.Label lblCostHeading;
        internal System.Windows.Forms.Label lblNumberOfDays;
        internal System.Windows.Forms.TextBox txtNumberofDays;
        internal System.Windows.Forms.Label lblTotalLabel;
        internal System.Windows.Forms.Label lblTotalCost;
        internal System.Windows.Forms.Button btnCost;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.PictureBox picBikes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

