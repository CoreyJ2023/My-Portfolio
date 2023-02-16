
namespace Big_Movie_Theater
{
    partial class frmBigMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBigMovie));
            this.lblLastPrice = new System.Windows.Forms.Label();
            this.picPopcorn = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTicketsPurchased = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTicketType = new System.Windows.Forms.Label();
            this.lblTicketResults = new System.Windows.Forms.Label();
            this.lblMovieNameResults = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSelection = new System.Windows.Forms.Label();
            this.radSenior = new System.Windows.Forms.RadioButton();
            this.radAdult = new System.Windows.Forms.RadioButton();
            this.grpTicketOption = new System.Windows.Forms.GroupBox();
            this.radChild = new System.Windows.Forms.RadioButton();
            this.txtTickets = new System.Windows.Forms.TextBox();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.lblMovieTickets = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picPopcorn)).BeginInit();
            this.grpTicketOption.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLastPrice
            // 
            this.lblLastPrice.AutoSize = true;
            this.lblLastPrice.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLastPrice.Location = new System.Drawing.Point(403, 599);
            this.lblLastPrice.Name = "lblLastPrice";
            this.lblLastPrice.Size = new System.Drawing.Size(81, 25);
            this.lblLastPrice.TabIndex = 37;
            this.lblLastPrice.Text = "$XXXX";
            this.lblLastPrice.Visible = false;
            // 
            // picPopcorn
            // 
            this.picPopcorn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPopcorn.BackgroundImage")));
            this.picPopcorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPopcorn.Location = new System.Drawing.Point(548, 143);
            this.picPopcorn.Name = "picPopcorn";
            this.picPopcorn.Size = new System.Drawing.Size(200, 200);
            this.picPopcorn.TabIndex = 36;
            this.picPopcorn.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPrice.Location = new System.Drawing.Point(403, 549);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(54, 25);
            this.lblPrice.TabIndex = 35;
            this.lblPrice.Text = "XXX";
            this.lblPrice.Visible = false;
            // 
            // lblTicketsPurchased
            // 
            this.lblTicketsPurchased.AutoSize = true;
            this.lblTicketsPurchased.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketsPurchased.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTicketsPurchased.Location = new System.Drawing.Point(403, 504);
            this.lblTicketsPurchased.Name = "lblTicketsPurchased";
            this.lblTicketsPurchased.Size = new System.Drawing.Size(40, 25);
            this.lblTicketsPurchased.TabIndex = 34;
            this.lblTicketsPurchased.Text = "XX";
            this.lblTicketsPurchased.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitle.Location = new System.Drawing.Point(403, 458);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(159, 25);
            this.lblTitle.TabIndex = 33;
            this.lblTitle.Text = "Title of Movie ";
            this.lblTitle.Visible = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalPrice.Location = new System.Drawing.Point(53, 599);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(199, 25);
            this.lblTotalPrice.TabIndex = 32;
            this.lblTotalPrice.Text = "The Price Total is:";
            this.lblTotalPrice.Visible = false;
            // 
            // lblTicketType
            // 
            this.lblTicketType.AutoSize = true;
            this.lblTicketType.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketType.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTicketType.Location = new System.Drawing.Point(53, 549);
            this.lblTicketType.Name = "lblTicketType";
            this.lblTicketType.Size = new System.Drawing.Size(140, 25);
            this.lblTicketType.TabIndex = 31;
            this.lblTicketType.Text = "Ticket Type:";
            this.lblTicketType.Visible = false;
            // 
            // lblTicketResults
            // 
            this.lblTicketResults.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketResults.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTicketResults.Location = new System.Drawing.Point(54, 501);
            this.lblTicketResults.Name = "lblTicketResults";
            this.lblTicketResults.Size = new System.Drawing.Size(204, 28);
            this.lblTicketResults.TabIndex = 20;
            this.lblTicketResults.Text = "Number of Tickets";
            this.lblTicketResults.Visible = false;
            // 
            // lblMovieNameResults
            // 
            this.lblMovieNameResults.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieNameResults.ForeColor = System.Drawing.Color.DarkRed;
            this.lblMovieNameResults.Location = new System.Drawing.Point(53, 456);
            this.lblMovieNameResults.Name = "lblMovieNameResults";
            this.lblMovieNameResults.Size = new System.Drawing.Size(189, 27);
            this.lblMovieNameResults.TabIndex = 21;
            this.lblMovieNameResults.Text = "Name of Movie: ";
            this.lblMovieNameResults.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(485, 365);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 36);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(293, 365);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(96, 36);
            this.btnDisplay.TabIndex = 29;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(114, 365);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 36);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblSelection.Location = new System.Drawing.Point(63, 323);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(304, 20);
            this.lblSelection.TabIndex = 27;
            this.lblSelection.Text = "Place ticket order here or reset order";
            // 
            // radSenior
            // 
            this.radSenior.AutoSize = true;
            this.radSenior.Location = new System.Drawing.Point(7, 80);
            this.radSenior.Name = "radSenior";
            this.radSenior.Size = new System.Drawing.Size(98, 29);
            this.radSenior.TabIndex = 1;
            this.radSenior.Text = "Senior";
            this.radSenior.UseVisualStyleBackColor = true;
            // 
            // radAdult
            // 
            this.radAdult.AutoSize = true;
            this.radAdult.Checked = true;
            this.radAdult.Location = new System.Drawing.Point(7, 50);
            this.radAdult.Name = "radAdult";
            this.radAdult.Size = new System.Drawing.Size(84, 29);
            this.radAdult.TabIndex = 0;
            this.radAdult.TabStop = true;
            this.radAdult.Text = "Adult";
            this.radAdult.UseVisualStyleBackColor = true;
            // 
            // grpTicketOption
            // 
            this.grpTicketOption.Controls.Add(this.radChild);
            this.grpTicketOption.Controls.Add(this.radSenior);
            this.grpTicketOption.Controls.Add(this.radAdult);
            this.grpTicketOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTicketOption.ForeColor = System.Drawing.Color.GreenYellow;
            this.grpTicketOption.Location = new System.Drawing.Point(77, 163);
            this.grpTicketOption.Name = "grpTicketOption";
            this.grpTicketOption.Size = new System.Drawing.Size(175, 157);
            this.grpTicketOption.TabIndex = 26;
            this.grpTicketOption.TabStop = false;
            this.grpTicketOption.Text = "Select Ticket Choice";
            this.grpTicketOption.Enter += new System.EventHandler(this.grpTicketOption_Enter);
            // 
            // radChild
            // 
            this.radChild.AutoSize = true;
            this.radChild.Location = new System.Drawing.Point(7, 116);
            this.radChild.Name = "radChild";
            this.radChild.Size = new System.Drawing.Size(84, 29);
            this.radChild.TabIndex = 2;
            this.radChild.Text = "Child";
            this.radChild.UseVisualStyleBackColor = true;
            // 
            // txtTickets
            // 
            this.txtTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTickets.Location = new System.Drawing.Point(305, 106);
            this.txtTickets.Name = "txtTickets";
            this.txtTickets.Size = new System.Drawing.Size(221, 35);
            this.txtTickets.TabIndex = 25;
            this.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMovie
            // 
            this.txtMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovie.Location = new System.Drawing.Point(305, 60);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(220, 35);
            this.txtMovie.TabIndex = 24;
            this.txtMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMovieTickets
            // 
            this.lblMovieTickets.AutoSize = true;
            this.lblMovieTickets.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTickets.ForeColor = System.Drawing.Color.Gold;
            this.lblMovieTickets.Location = new System.Drawing.Point(53, 110);
            this.lblMovieTickets.Name = "lblMovieTickets";
            this.lblMovieTickets.Size = new System.Drawing.Size(237, 31);
            this.lblMovieTickets.TabIndex = 23;
            this.lblMovieTickets.Text = "Number of Tickets";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.Gold;
            this.lblMovieName.Location = new System.Drawing.Point(61, 64);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(197, 31);
            this.lblMovieName.TabIndex = 22;
            this.lblMovieName.Text = "Name of Movie";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblMovieTitle.Location = new System.Drawing.Point(61, -65);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(366, 40);
            this.lblMovieTitle.TabIndex = 19;
            this.lblMovieTitle.Text = "The Big Movie Theater";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(60, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 40);
            this.label1.TabIndex = 38;
            this.label1.Text = "The Big Movie Theater";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 39;
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
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmBigMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLastPrice);
            this.Controls.Add(this.picPopcorn);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblTicketsPurchased);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTicketType);
            this.Controls.Add(this.lblTicketResults);
            this.Controls.Add(this.lblMovieNameResults);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.grpTicketOption);
            this.Controls.Add(this.txtTickets);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.lblMovieTickets);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.lblMovieTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBigMovie";
            this.Text = "The Big Movie Theater";
            ((System.ComponentModel.ISupportInitialize)(this.picPopcorn)).EndInit();
            this.grpTicketOption.ResumeLayout(false);
            this.grpTicketOption.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblLastPrice;
        internal System.Windows.Forms.PictureBox picPopcorn;
        internal System.Windows.Forms.Label lblPrice;
        internal System.Windows.Forms.Label lblTicketsPurchased;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.Label lblTotalPrice;
        internal System.Windows.Forms.Label lblTicketType;
        internal System.Windows.Forms.Label lblTicketResults;
        internal System.Windows.Forms.Label lblMovieNameResults;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnDisplay;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label lblSelection;
        internal System.Windows.Forms.RadioButton radSenior;
        internal System.Windows.Forms.RadioButton radAdult;
        internal System.Windows.Forms.GroupBox grpTicketOption;
        internal System.Windows.Forms.RadioButton radChild;
        internal System.Windows.Forms.TextBox txtTickets;
        internal System.Windows.Forms.TextBox txtMovie;
        internal System.Windows.Forms.Label lblMovieTickets;
        internal System.Windows.Forms.Label lblMovieName;
        internal System.Windows.Forms.Label lblMovieTitle;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

