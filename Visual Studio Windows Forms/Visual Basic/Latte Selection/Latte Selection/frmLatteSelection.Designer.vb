﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLatteSelection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLatteSelection))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picPumpkin = New System.Windows.Forms.PictureBox()
        Me.picMocha = New System.Windows.Forms.PictureBox()
        Me.btnPumpkin = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnMocha = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblConfirmation = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.SaddleBrown
        Me.lblHeading.Location = New System.Drawing.Point(273, 65)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(168, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Latte Selection"
        '
        'picPumpkin
        '
        Me.picPumpkin.Image = CType(resources.GetObject("picPumpkin.Image"), System.Drawing.Image)
        Me.picPumpkin.Location = New System.Drawing.Point(26, 106)
        Me.picPumpkin.Name = "picPumpkin"
        Me.picPumpkin.Size = New System.Drawing.Size(300, 250)
        Me.picPumpkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPumpkin.TabIndex = 1
        Me.picPumpkin.TabStop = False
        Me.picPumpkin.Visible = False
        '
        'picMocha
        '
        Me.picMocha.Image = CType(resources.GetObject("picMocha.Image"), System.Drawing.Image)
        Me.picMocha.Location = New System.Drawing.Point(388, 106)
        Me.picMocha.Name = "picMocha"
        Me.picMocha.Size = New System.Drawing.Size(300, 250)
        Me.picMocha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMocha.TabIndex = 2
        Me.picMocha.TabStop = False
        Me.picMocha.Visible = False
        '
        'btnPumpkin
        '
        Me.btnPumpkin.BackColor = System.Drawing.Color.Bisque
        Me.btnPumpkin.Location = New System.Drawing.Point(108, 404)
        Me.btnPumpkin.Name = "btnPumpkin"
        Me.btnPumpkin.Size = New System.Drawing.Size(91, 23)
        Me.btnPumpkin.TabIndex = 3
        Me.btnPumpkin.Text = "Pumpkin Spice"
        Me.btnPumpkin.UseVisualStyleBackColor = False
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Bisque
        Me.btnSelect.Location = New System.Drawing.Point(312, 403)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(91, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Latte"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'btnMocha
        '
        Me.btnMocha.BackColor = System.Drawing.Color.Bisque
        Me.btnMocha.Location = New System.Drawing.Point(497, 404)
        Me.btnMocha.Name = "btnMocha"
        Me.btnMocha.Size = New System.Drawing.Size(91, 23)
        Me.btnMocha.TabIndex = 5
        Me.btnMocha.Text = "Mocha"
        Me.btnMocha.UseVisualStyleBackColor = False
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(223, 450)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(268, 13)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a latte flavor and then click Select Latte Button"
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Location = New System.Drawing.Point(295, 511)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(124, 13)
        Me.lblConfirmation.TabIndex = 7
        Me.lblConfirmation.Text = "Enloy your latte selection"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Bisque
        Me.btnExit.Location = New System.Drawing.Point(320, 553)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit Button"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmLatteSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(714, 662)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnMocha)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnPumpkin)
        Me.Controls.Add(Me.picMocha)
        Me.Controls.Add(Me.picPumpkin)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmLatteSelection"
        Me.Text = "Latte Selection"
        CType(Me.picPumpkin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMocha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPumpkin As PictureBox
    Friend WithEvents picMocha As PictureBox
    Friend WithEvents btnPumpkin As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnMocha As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button
End Class
