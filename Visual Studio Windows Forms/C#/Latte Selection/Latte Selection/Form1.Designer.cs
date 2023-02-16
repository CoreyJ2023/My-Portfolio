
namespace Latte_Selection
{
    partial class frmLatteSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLatteSelection));
            this.lblHeading = new System.Windows.Forms.Label();
            this.picPumpkin = new System.Windows.Forms.PictureBox();
            this.picMocha = new System.Windows.Forms.PictureBox();
            this.btnPumpkin = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnMocha = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picPumpkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMocha)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeading.Location = new System.Drawing.Point(291, 50);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(168, 25);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Latte Selection";
            // 
            // picPumpkin
            // 
            this.picPumpkin.Image = ((System.Drawing.Image)(resources.GetObject("picPumpkin.Image")));
            this.picPumpkin.Location = new System.Drawing.Point(53, 95);
            this.picPumpkin.Name = "picPumpkin";
            this.picPumpkin.Size = new System.Drawing.Size(300, 250);
            this.picPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPumpkin.TabIndex = 2;
            this.picPumpkin.TabStop = false;
            this.picPumpkin.Visible = false;
            // 
            // picMocha
            // 
            this.picMocha.Image = ((System.Drawing.Image)(resources.GetObject("picMocha.Image")));
            this.picMocha.Location = new System.Drawing.Point(455, 95);
            this.picMocha.Name = "picMocha";
            this.picMocha.Size = new System.Drawing.Size(300, 250);
            this.picMocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMocha.TabIndex = 3;
            this.picMocha.TabStop = false;
            this.picMocha.Visible = false;
            // 
            // btnPumpkin
            // 
            this.btnPumpkin.BackColor = System.Drawing.Color.Bisque;
            this.btnPumpkin.Location = new System.Drawing.Point(141, 387);
            this.btnPumpkin.Name = "btnPumpkin";
            this.btnPumpkin.Size = new System.Drawing.Size(91, 23);
            this.btnPumpkin.TabIndex = 4;
            this.btnPumpkin.Text = "Pumpkin Spice";
            this.btnPumpkin.UseVisualStyleBackColor = false;
            this.btnPumpkin.Click += new System.EventHandler(this.btnPumpkin_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Bisque;
            this.btnSelect.Location = new System.Drawing.Point(358, 387);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(91, 23);
            this.btnSelect.TabIndex = 5;
            this.btnSelect.Text = "Select Latte";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnMocha
            // 
            this.btnMocha.BackColor = System.Drawing.Color.Bisque;
            this.btnMocha.Location = new System.Drawing.Point(555, 387);
            this.btnMocha.Name = "btnMocha";
            this.btnMocha.Size = new System.Drawing.Size(91, 23);
            this.btnMocha.TabIndex = 6;
            this.btnMocha.Text = "Mocha";
            this.btnMocha.UseVisualStyleBackColor = false;
            this.btnMocha.Click += new System.EventHandler(this.btnMocha_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(260, 437);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(268, 13);
            this.lblInstructions.TabIndex = 7;
            this.lblInstructions.Text = "Choose a latte flavor and then click Select Latte Button";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(335, 488);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(124, 13);
            this.lblConfirmation.TabIndex = 8;
            this.lblConfirmation.Text = "Enloy your latte selection";
            this.lblConfirmation.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Bisque;
            this.btnExit.Enabled = false;
            this.btnExit.Location = new System.Drawing.Point(358, 521);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit Button";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmLatteSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnMocha);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnPumpkin);
            this.Controls.Add(this.picMocha);
            this.Controls.Add(this.picPumpkin);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLatteSelection";
            this.Text = "Latte Selection";
            ((System.ComponentModel.ISupportInitialize)(this.picPumpkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMocha)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblHeading;
        internal System.Windows.Forms.PictureBox picPumpkin;
        internal System.Windows.Forms.PictureBox picMocha;
        internal System.Windows.Forms.Button btnPumpkin;
        internal System.Windows.Forms.Button btnSelect;
        internal System.Windows.Forms.Button btnMocha;
        internal System.Windows.Forms.Label lblInstructions;
        internal System.Windows.Forms.Label lblConfirmation;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

