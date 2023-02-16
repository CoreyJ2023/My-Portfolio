<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSpringBreakTravelSpecial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSpringBreakTravelSpecial))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picMyrtleBeach = New System.Windows.Forms.PictureBox()
        Me.picVeniceBeach = New System.Windows.Forms.PictureBox()
        Me.picKeyWest = New System.Windows.Forms.PictureBox()
        Me.btnMyrtleBeach = New System.Windows.Forms.Button()
        Me.btnKeyWest = New System.Windows.Forms.Button()
        Me.btnVeniceBeach = New System.Windows.Forms.Button()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btnCloseWindow = New System.Windows.Forms.Button()
        CType(Me.picMyrtleBeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeniceBeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(333, 100)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(308, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Spring Break Travel Specials"
        '
        'picMyrtleBeach
        '
        Me.picMyrtleBeach.Enabled = False
        Me.picMyrtleBeach.Image = CType(resources.GetObject("picMyrtleBeach.Image"), System.Drawing.Image)
        Me.picMyrtleBeach.Location = New System.Drawing.Point(62, 206)
        Me.picMyrtleBeach.Name = "picMyrtleBeach"
        Me.picMyrtleBeach.Size = New System.Drawing.Size(250, 200)
        Me.picMyrtleBeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMyrtleBeach.TabIndex = 1
        Me.picMyrtleBeach.TabStop = False
        Me.picMyrtleBeach.Visible = False
        '
        'picVeniceBeach
        '
        Me.picVeniceBeach.Enabled = False
        Me.picVeniceBeach.Image = CType(resources.GetObject("picVeniceBeach.Image"), System.Drawing.Image)
        Me.picVeniceBeach.Location = New System.Drawing.Point(663, 206)
        Me.picVeniceBeach.Name = "picVeniceBeach"
        Me.picVeniceBeach.Size = New System.Drawing.Size(250, 200)
        Me.picVeniceBeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVeniceBeach.TabIndex = 2
        Me.picVeniceBeach.TabStop = False
        Me.picVeniceBeach.Visible = False
        '
        'picKeyWest
        '
        Me.picKeyWest.Enabled = False
        Me.picKeyWest.Image = CType(resources.GetObject("picKeyWest.Image"), System.Drawing.Image)
        Me.picKeyWest.Location = New System.Drawing.Point(367, 206)
        Me.picKeyWest.Name = "picKeyWest"
        Me.picKeyWest.Size = New System.Drawing.Size(250, 200)
        Me.picKeyWest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKeyWest.TabIndex = 3
        Me.picKeyWest.TabStop = False
        Me.picKeyWest.Visible = False
        '
        'btnMyrtleBeach
        '
        Me.btnMyrtleBeach.Location = New System.Drawing.Point(124, 445)
        Me.btnMyrtleBeach.Name = "btnMyrtleBeach"
        Me.btnMyrtleBeach.Size = New System.Drawing.Size(96, 23)
        Me.btnMyrtleBeach.TabIndex = 4
        Me.btnMyrtleBeach.Text = "Myrtle Beach"
        Me.btnMyrtleBeach.UseVisualStyleBackColor = True
        '
        'btnKeyWest
        '
        Me.btnKeyWest.Location = New System.Drawing.Point(442, 445)
        Me.btnKeyWest.Name = "btnKeyWest"
        Me.btnKeyWest.Size = New System.Drawing.Size(96, 23)
        Me.btnKeyWest.TabIndex = 5
        Me.btnKeyWest.Text = "Key West"
        Me.btnKeyWest.UseVisualStyleBackColor = True
        '
        'btnVeniceBeach
        '
        Me.btnVeniceBeach.Location = New System.Drawing.Point(749, 445)
        Me.btnVeniceBeach.Name = "btnVeniceBeach"
        Me.btnVeniceBeach.Size = New System.Drawing.Size(96, 23)
        Me.btnVeniceBeach.TabIndex = 6
        Me.btnVeniceBeach.Text = "Venice Beach"
        Me.btnVeniceBeach.UseVisualStyleBackColor = True
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Enabled = False
        Me.lblEnjoy.Location = New System.Drawing.Point(439, 519)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(76, 13)
        Me.lblEnjoy.TabIndex = 7
        Me.lblEnjoy.Text = "Enjoy your trip!"
        Me.lblEnjoy.Visible = False
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(442, 558)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(85, 23)
        Me.btnPurchase.TabIndex = 8
        Me.btnPurchase.Text = "Purchase"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btnCloseWindow
        '
        Me.btnCloseWindow.Location = New System.Drawing.Point(442, 643)
        Me.btnCloseWindow.Name = "btnCloseWindow"
        Me.btnCloseWindow.Size = New System.Drawing.Size(85, 23)
        Me.btnCloseWindow.TabIndex = 10
        Me.btnCloseWindow.Text = "Close Window"
        Me.btnCloseWindow.UseVisualStyleBackColor = True
        '
        'FrmSpringBreakTravelSpecial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 702)
        Me.Controls.Add(Me.btnCloseWindow)
        Me.Controls.Add(Me.btnPurchase)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.btnVeniceBeach)
        Me.Controls.Add(Me.btnKeyWest)
        Me.Controls.Add(Me.btnMyrtleBeach)
        Me.Controls.Add(Me.picKeyWest)
        Me.Controls.Add(Me.picVeniceBeach)
        Me.Controls.Add(Me.picMyrtleBeach)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "FrmSpringBreakTravelSpecial"
        Me.Text = "Spring Break Travel Specials"
        CType(Me.picMyrtleBeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeniceBeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKeyWest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picMyrtleBeach As PictureBox
    Friend WithEvents picVeniceBeach As PictureBox
    Friend WithEvents picKeyWest As PictureBox
    Friend WithEvents btnMyrtleBeach As Button
    Friend WithEvents btnKeyWest As Button
    Friend WithEvents btnVeniceBeach As Button
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnCloseWindow As Button
End Class
