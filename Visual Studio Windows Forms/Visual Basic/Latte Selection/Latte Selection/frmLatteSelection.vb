' Program Name: Latte Selection
' Developer:    Corey Jenkins
' Date:         September 6, 2017
' Purpose:      This application will select between the Pumpkin and Mocha and then it will create
'               the final selection.
Public Class frmLatteSelection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This code is executed when the user clicks the Select button. It disables the
        ' Pumpkin Spice button, the Select button, and the Mocha button. It hides the
        ' Instruction label, displays the confirmaton label, and enables the Exit Window button

        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Visible = True
    End Sub

    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This code is executed when the user clicks the Pumpkin Spice button. It displays
        ' the pumpkin picture, hides the mocha picture, and enables the Selct Latte button

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True 
    End Sub

    Private Sub picMocha_Click(sender As Object, e As EventArgs) Handles picMocha.Click

    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This code is executed when the user clicks the Moche button. It displays the
        ' mocha picture, hides the pumpkin picture, and enables the select button.

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user clicks teh Exit Window button.
        ' It closese the window and terminates the program execution

        Close()
    End Sub
End Class
