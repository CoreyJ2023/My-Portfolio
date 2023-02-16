<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCar))
        Me.lblDriverless = New System.Windows.Forms.Label()
        Me.picCar = New System.Windows.Forms.PictureBox()
        Me.lblFlatHeading = New System.Windows.Forms.Label()
        Me.lblNumberOfMiles = New System.Windows.Forms.Label()
        Me.txtNumberOfMiles = New System.Windows.Forms.TextBox()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnDisplayFare = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDriverless
        '
        Me.lblDriverless.AutoSize = True
        Me.lblDriverless.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriverless.Location = New System.Drawing.Point(215, 45)
        Me.lblDriverless.Name = "lblDriverless"
        Me.lblDriverless.Size = New System.Drawing.Size(255, 27)
        Me.lblDriverless.TabIndex = 0
        Me.lblDriverless.Text = "Driverless Uber Car"
        '
        'picCar
        '
        Me.picCar.Image = CType(resources.GetObject("picCar.Image"), System.Drawing.Image)
        Me.picCar.Location = New System.Drawing.Point(1, 359)
        Me.picCar.Name = "picCar"
        Me.picCar.Size = New System.Drawing.Size(683, 200)
        Me.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCar.TabIndex = 1
        Me.picCar.TabStop = False
        '
        'lblFlatHeading
        '
        Me.lblFlatHeading.AutoSize = True
        Me.lblFlatHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlatHeading.Location = New System.Drawing.Point(291, 98)
        Me.lblFlatHeading.Name = "lblFlatHeading"
        Me.lblFlatHeading.Size = New System.Drawing.Size(157, 20)
        Me.lblFlatHeading.TabIndex = 2
        Me.lblFlatHeading.Text = "$X.XX is the Flat Tax"
        '
        'lblNumberOfMiles
        '
        Me.lblNumberOfMiles.AutoSize = True
        Me.lblNumberOfMiles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfMiles.Location = New System.Drawing.Point(220, 140)
        Me.lblNumberOfMiles.Name = "lblNumberOfMiles"
        Me.lblNumberOfMiles.Size = New System.Drawing.Size(133, 21)
        Me.lblNumberOfMiles.TabIndex = 3
        Me.lblNumberOfMiles.Text = "Number of Miles"
        '
        'txtNumberOfMiles
        '
        Me.txtNumberOfMiles.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfMiles.Location = New System.Drawing.Point(359, 137)
        Me.txtNumberOfMiles.Name = "txtNumberOfMiles"
        Me.txtNumberOfMiles.Size = New System.Drawing.Size(100, 27)
        Me.txtNumberOfMiles.TabIndex = 0
        Me.txtNumberOfMiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(216, 201)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(180, 21)
        Me.lblTotalLabel.TabIndex = 5
        Me.lblTotalLabel.Text = "Total cost for the fare:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(391, 201)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(68, 21)
        Me.lblTotalCost.TabIndex = 6
        Me.lblTotalCost.Text = "$888.88"
        '
        'btnDisplayFare
        '
        Me.btnDisplayFare.Location = New System.Drawing.Point(109, 255)
        Me.btnDisplayFare.Name = "btnDisplayFare"
        Me.btnDisplayFare.Size = New System.Drawing.Size(75, 23)
        Me.btnDisplayFare.TabIndex = 7
        Me.btnDisplayFare.Text = "Display Fare"
        Me.btnDisplayFare.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(298, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(487, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmCar
        '
        Me.AcceptButton = Me.btnDisplayFare
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(684, 562)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayFare)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.txtNumberOfMiles)
        Me.Controls.Add(Me.lblNumberOfMiles)
        Me.Controls.Add(Me.lblFlatHeading)
        Me.Controls.Add(Me.picCar)
        Me.Controls.Add(Me.lblDriverless)
        Me.Name = "frmCar"
        Me.Text = "Driverless Car"
        CType(Me.picCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDriverless As Label
    Friend WithEvents picCar As PictureBox
    Friend WithEvents lblFlatHeading As Label
    Friend WithEvents lblNumberOfMiles As Label
    Friend WithEvents txtNumberOfMiles As TextBox
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnDisplayFare As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button

End Class
