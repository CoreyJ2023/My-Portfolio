<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovie))
        Me.lblMovieTitle = New System.Windows.Forms.Label()
        Me.lblMovieName = New System.Windows.Forms.Label()
        Me.lblMovieTickets = New System.Windows.Forms.Label()
        Me.txtMovie = New System.Windows.Forms.TextBox()
        Me.txtTickets = New System.Windows.Forms.TextBox()
        Me.grpTicketOption = New System.Windows.Forms.GroupBox()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.mnuMovie = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblMovieNameResults = New System.Windows.Forms.Label()
        Me.lblTicketResults = New System.Windows.Forms.Label()
        Me.lblTicketType = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTicketsPurchased = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.picPopcorn = New System.Windows.Forms.PictureBox()
        Me.lblLastPrice = New System.Windows.Forms.Label()
        Me.grpTicketOption.SuspendLayout()
        Me.mnuMovie.SuspendLayout()
        CType(Me.picPopcorn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMovieTitle
        '
        Me.lblMovieTitle.AutoSize = True
        Me.lblMovieTitle.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieTitle.ForeColor = System.Drawing.Color.DarkOrange
        Me.lblMovieTitle.Location = New System.Drawing.Point(97, 24)
        Me.lblMovieTitle.Name = "lblMovieTitle"
        Me.lblMovieTitle.Size = New System.Drawing.Size(366, 40)
        Me.lblMovieTitle.TabIndex = 0
        Me.lblMovieTitle.Text = "The Big Movie Theater"
        '
        'lblMovieName
        '
        Me.lblMovieName.AutoSize = True
        Me.lblMovieName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieName.ForeColor = System.Drawing.Color.Gold
        Me.lblMovieName.Location = New System.Drawing.Point(94, 82)
        Me.lblMovieName.Name = "lblMovieName"
        Me.lblMovieName.Size = New System.Drawing.Size(197, 31)
        Me.lblMovieName.TabIndex = 1
        Me.lblMovieName.Text = "Name of Movie"
        '
        'lblMovieTickets
        '
        Me.lblMovieTickets.AutoSize = True
        Me.lblMovieTickets.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieTickets.ForeColor = System.Drawing.Color.Gold
        Me.lblMovieTickets.Location = New System.Drawing.Point(94, 126)
        Me.lblMovieTickets.Name = "lblMovieTickets"
        Me.lblMovieTickets.Size = New System.Drawing.Size(237, 31)
        Me.lblMovieTickets.TabIndex = 2
        Me.lblMovieTickets.Text = "Number of Tickets"
        '
        'txtMovie
        '
        Me.txtMovie.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovie.Location = New System.Drawing.Point(297, 82)
        Me.txtMovie.Name = "txtMovie"
        Me.txtMovie.Size = New System.Drawing.Size(220, 35)
        Me.txtMovie.TabIndex = 3
        Me.txtMovie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTickets
        '
        Me.txtTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTickets.Location = New System.Drawing.Point(338, 126)
        Me.txtTickets.Name = "txtTickets"
        Me.txtTickets.Size = New System.Drawing.Size(221, 35)
        Me.txtTickets.TabIndex = 4
        Me.txtTickets.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpTicketOption
        '
        Me.grpTicketOption.Controls.Add(Me.radChild)
        Me.grpTicketOption.Controls.Add(Me.radSenior)
        Me.grpTicketOption.Controls.Add(Me.radAdult)
        Me.grpTicketOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTicketOption.ForeColor = System.Drawing.Color.GreenYellow
        Me.grpTicketOption.Location = New System.Drawing.Point(100, 182)
        Me.grpTicketOption.Name = "grpTicketOption"
        Me.grpTicketOption.Size = New System.Drawing.Size(175, 157)
        Me.grpTicketOption.TabIndex = 5
        Me.grpTicketOption.TabStop = False
        Me.grpTicketOption.Text = "Select Ticket Choice"
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(7, 116)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(84, 29)
        Me.radChild.TabIndex = 2
        Me.radChild.Text = "Child"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(7, 80)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(98, 29)
        Me.radSenior.TabIndex = 1
        Me.radSenior.Text = "Senior"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Checked = True
        Me.radAdult.Location = New System.Drawing.Point(7, 50)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(84, 29)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblSelection.Location = New System.Drawing.Point(100, 356)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(304, 20)
        Me.lblSelection.TabIndex = 6
        Me.lblSelection.Text = "Place ticket order here or reset order"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(164, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 36)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplay.Location = New System.Drawing.Point(335, 390)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(96, 36)
        Me.btnDisplay.TabIndex = 8
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(524, 390)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 36)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'mnuMovie
        '
        Me.mnuMovie.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuMovie.Location = New System.Drawing.Point(0, 0)
        Me.mnuMovie.Name = "mnuMovie"
        Me.mnuMovie.Size = New System.Drawing.Size(784, 24)
        Me.mnuMovie.TabIndex = 10
        Me.mnuMovie.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "E&xit"
        '
        'lblMovieNameResults
        '
        Me.lblMovieNameResults.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMovieNameResults.ForeColor = System.Drawing.Color.DarkRed
        Me.lblMovieNameResults.Location = New System.Drawing.Point(102, 454)
        Me.lblMovieNameResults.Name = "lblMovieNameResults"
        Me.lblMovieNameResults.Size = New System.Drawing.Size(189, 27)
        Me.lblMovieNameResults.TabIndex = 0
        Me.lblMovieNameResults.Text = "Name of Movie: "
        Me.lblMovieNameResults.Visible = False
        '
        'lblTicketResults
        '
        Me.lblTicketResults.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketResults.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTicketResults.Location = New System.Drawing.Point(102, 492)
        Me.lblTicketResults.Name = "lblTicketResults"
        Me.lblTicketResults.Size = New System.Drawing.Size(204, 28)
        Me.lblTicketResults.TabIndex = 0
        Me.lblTicketResults.Text = "Number of Tickets"
        Me.lblTicketResults.Visible = False
        '
        'lblTicketType
        '
        Me.lblTicketType.AutoSize = True
        Me.lblTicketType.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketType.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTicketType.Location = New System.Drawing.Point(100, 532)
        Me.lblTicketType.Name = "lblTicketType"
        Me.lblTicketType.Size = New System.Drawing.Size(140, 25)
        Me.lblTicketType.TabIndex = 11
        Me.lblTicketType.Text = "Ticket Type:"
        Me.lblTicketType.Visible = False
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTotalPrice.Location = New System.Drawing.Point(98, 569)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(199, 25)
        Me.lblTotalPrice.TabIndex = 12
        Me.lblTotalPrice.Text = "The Price Total is:"
        Me.lblTotalPrice.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTitle.Location = New System.Drawing.Point(461, 456)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(159, 25)
        Me.lblTitle.TabIndex = 13
        Me.lblTitle.Text = "Title of Movie "
        Me.lblTitle.Visible = False
        '
        'lblTicketsPurchased
        '
        Me.lblTicketsPurchased.AutoSize = True
        Me.lblTicketsPurchased.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTicketsPurchased.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTicketsPurchased.Location = New System.Drawing.Point(457, 495)
        Me.lblTicketsPurchased.Name = "lblTicketsPurchased"
        Me.lblTicketsPurchased.Size = New System.Drawing.Size(40, 25)
        Me.lblTicketsPurchased.TabIndex = 14
        Me.lblTicketsPurchased.Text = "XX"
        Me.lblTicketsPurchased.Visible = False
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblPrice.Location = New System.Drawing.Point(457, 532)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(54, 25)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.Text = "XXX"
        Me.lblPrice.Visible = False
        '
        'picPopcorn
        '
        Me.picPopcorn.BackgroundImage = CType(resources.GetObject("picPopcorn.BackgroundImage"), System.Drawing.Image)
        Me.picPopcorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picPopcorn.Location = New System.Drawing.Point(572, 174)
        Me.picPopcorn.Name = "picPopcorn"
        Me.picPopcorn.Size = New System.Drawing.Size(200, 200)
        Me.picPopcorn.TabIndex = 17
        Me.picPopcorn.TabStop = False
        '
        'lblLastPrice
        '
        Me.lblLastPrice.AutoSize = True
        Me.lblLastPrice.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastPrice.ForeColor = System.Drawing.Color.DarkRed
        Me.lblLastPrice.Location = New System.Drawing.Point(457, 579)
        Me.lblLastPrice.Name = "lblLastPrice"
        Me.lblLastPrice.Size = New System.Drawing.Size(81, 25)
        Me.lblLastPrice.TabIndex = 18
        Me.lblLastPrice.Text = "$XXXX"
        Me.lblLastPrice.Visible = False
        '
        'frmMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(784, 712)
        Me.Controls.Add(Me.lblLastPrice)
        Me.Controls.Add(Me.picPopcorn)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTicketsPurchased)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTicketType)
        Me.Controls.Add(Me.lblTicketResults)
        Me.Controls.Add(Me.lblMovieNameResults)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.grpTicketOption)
        Me.Controls.Add(Me.txtTickets)
        Me.Controls.Add(Me.txtMovie)
        Me.Controls.Add(Me.lblMovieTickets)
        Me.Controls.Add(Me.lblMovieName)
        Me.Controls.Add(Me.lblMovieTitle)
        Me.Controls.Add(Me.mnuMovie)
        Me.MainMenuStrip = Me.mnuMovie
        Me.Name = "frmMovie"
        Me.Text = "The Big Movie Theater"
        Me.grpTicketOption.ResumeLayout(False)
        Me.grpTicketOption.PerformLayout()
        Me.mnuMovie.ResumeLayout(False)
        Me.mnuMovie.PerformLayout()
        CType(Me.picPopcorn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMovieTitle As Label
    Friend WithEvents lblMovieName As Label
    Friend WithEvents lblMovieTickets As Label
    Friend WithEvents txtMovie As TextBox
    Friend WithEvents txtTickets As TextBox
    Friend WithEvents grpTicketOption As GroupBox
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents lblSelection As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents mnuMovie As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblMovieNameResults As Label
    Friend WithEvents lblTicketResults As Label
    Friend WithEvents lblTicketType As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTicketsPurchased As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents picPopcorn As PictureBox
    Friend WithEvents lblLastPrice As Label
End Class
