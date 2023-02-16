<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComic))
        Me.PicComic = New System.Windows.Forms.PictureBox()
        Me.lblComicTitle = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadge = New System.Windows.Forms.GroupBox()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.radAutograph = New System.Windows.Forms.RadioButton()
        Me.radSuperHero = New System.Windows.Forms.RadioButton()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblClear = New System.Windows.Forms.Button()
        CType(Me.PicComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadge.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicComic
        '
        Me.PicComic.Image = CType(resources.GetObject("PicComic.Image"), System.Drawing.Image)
        Me.PicComic.Location = New System.Drawing.Point(1, 2)
        Me.PicComic.Name = "PicComic"
        Me.PicComic.Size = New System.Drawing.Size(680, 240)
        Me.PicComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicComic.TabIndex = 0
        Me.PicComic.TabStop = False
        '
        'lblComicTitle
        '
        Me.lblComicTitle.AutoSize = True
        Me.lblComicTitle.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComicTitle.ForeColor = System.Drawing.Color.Red
        Me.lblComicTitle.Location = New System.Drawing.Point(164, 267)
        Me.lblComicTitle.Name = "lblComicTitle"
        Me.lblComicTitle.Size = New System.Drawing.Size(342, 67)
        Me.lblComicTitle.TabIndex = 1
        Me.lblComicTitle.Text = "Comic Heroes"
        '
        'lblGroup
        '
        Me.lblGroup.AutoSize = True
        Me.lblGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroup.ForeColor = System.Drawing.Color.Red
        Me.lblGroup.Location = New System.Drawing.Point(159, 358)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(176, 31)
        Me.lblGroup.TabIndex = 2
        Me.lblGroup.Text = "Group Size: "
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.ForeColor = System.Drawing.Color.Red
        Me.txtGroupSize.Location = New System.Drawing.Point(341, 358)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(64, 38)
        Me.txtGroupSize.TabIndex = 3
        '
        'grpBadge
        '
        Me.grpBadge.BackColor = System.Drawing.Color.Turquoise
        Me.grpBadge.Controls.Add(Me.radConvention)
        Me.grpBadge.Controls.Add(Me.radAutograph)
        Me.grpBadge.Controls.Add(Me.radSuperHero)
        Me.grpBadge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadge.ForeColor = System.Drawing.Color.Red
        Me.grpBadge.Location = New System.Drawing.Point(165, 414)
        Me.grpBadge.Name = "grpBadge"
        Me.grpBadge.Size = New System.Drawing.Size(390, 120)
        Me.grpBadge.TabIndex = 4
        Me.grpBadge.TabStop = False
        Me.grpBadge.Text = "Select Badge Type: "
        '
        'radConvention
        '
        Me.radConvention.AutoSize = True
        Me.radConvention.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radConvention.ForeColor = System.Drawing.Color.Red
        Me.radConvention.Location = New System.Drawing.Point(6, 87)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(134, 28)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'radAutograph
        '
        Me.radAutograph.AutoSize = True
        Me.radAutograph.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAutograph.ForeColor = System.Drawing.Color.Red
        Me.radAutograph.Location = New System.Drawing.Point(6, 51)
        Me.radAutograph.Name = "radAutograph"
        Me.radAutograph.Size = New System.Drawing.Size(265, 28)
        Me.radAutograph.TabIndex = 1
        Me.radAutograph.TabStop = True
        Me.radAutograph.Text = "Convention + Autographs"
        Me.radAutograph.UseVisualStyleBackColor = True
        '
        'radSuperHero
        '
        Me.radSuperHero.AutoSize = True
        Me.radSuperHero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSuperHero.ForeColor = System.Drawing.Color.Red
        Me.radSuperHero.Location = New System.Drawing.Point(6, 19)
        Me.radSuperHero.Name = "radSuperHero"
        Me.radSuperHero.Size = New System.Drawing.Size(371, 28)
        Me.radSuperHero.TabIndex = 0
        Me.radSuperHero.TabStop = True
        Me.radSuperHero.Text = "Convention + Superhero Experience"
        Me.radSuperHero.UseVisualStyleBackColor = True
        '
        'lblRegistration
        '
        Me.lblRegistration.AutoSize = True
        Me.lblRegistration.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.Color.Red
        Me.lblRegistration.Location = New System.Drawing.Point(106, 553)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(258, 31)
        Me.lblRegistration.TabIndex = 5
        Me.lblRegistration.Text = "Registration Cost: "
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(407, 553)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(135, 31)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Turquoise
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(195, 602)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(132, 39)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblClear
        '
        Me.lblClear.BackColor = System.Drawing.Color.Turquoise
        Me.lblClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClear.Location = New System.Drawing.Point(446, 601)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(132, 39)
        Me.lblClear.TabIndex = 8
        Me.lblClear.Text = "Clear"
        Me.lblClear.UseVisualStyleBackColor = False
        '
        'frmComic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(684, 652)
        Me.Controls.Add(Me.lblClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.grpBadge)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblComicTitle)
        Me.Controls.Add(Me.PicComic)
        Me.Name = "frmComic"
        Me.Text = "Comic Heroes"
        CType(Me.PicComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadge.ResumeLayout(False)
        Me.grpBadge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicComic As PictureBox
    Friend WithEvents lblComicTitle As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadge As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutograph As RadioButton
    Friend WithEvents radSuperHero As RadioButton
    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblClear As Button
End Class
