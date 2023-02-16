'   Program Name:   Comic Heroes
'   Author:         Corey Jenkins
'   Date:           October 25, 2017
'   Purpose:        This window application will select one of the three options for
'                   the Heroes convention. This program also will take in no more than 
'                   20 group entries. The Convention + Superhero Experince will cost $380,
'                   the Convention + Autograph will cost $275 and the cost for just only
'                   the convention is $209.

Option Strict On
Public Class frmComic
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' For this button, we'll code delcare variables as integers and then use the If/else condition when a number
        ' is inputted and other factors such as if a button is selected with a variable for that button assigned and
        ' what happens if it were to go over 20 or when a negative value is entered or even a non-numbered text.

        ' Declaration section
        Dim intGroup As Integer
        Dim intGroupSize As Integer
        Dim intRegulation As Integer
        Dim intSuperHero As Integer = 380
        Dim intAutograph As Integer = 275
        Dim intConvention As Integer = 209

        ' Has a numeral value been inputed
        If IsNumeric(txtGroupSize.Text) Then
            intGroup = Convert.ToInt32(txtGroupSize.Text)
            'did you enter over 20
            If intGroup <= 20 Then
                'Did you entered a negative number
                If intGroup > 0 Then
                    If radSuperHero.Checked Then
                        intGroupSize = intSuperHero
                    ElseIf radAutograph.Checked Then
                        intGroupSize = intAutograph
                    ElseIf radConvention.Checked Then
                        intGroupSize = intConvention
                    End If
                    ' Calculate the Regulation price.
                    intRegulation = intGroup * intGroupSize
                    lblTotal.Text = intRegulation.ToString("C")
                Else
                    'Displays message if you have entered a negative number.
                    MsgBox("You've entered " & intGroup.ToString() & ". Enter a postive number.", , "Input error.")
                    txtGroupSize.Text = ""
                    txtGroupSize.Focus()
                End If
            Else
                'Display message if you have entered a number greather than 20.
                MsgBox("You've entered a number greater than 20. Please enter a number less than or equal to 20.", , "Input error.")
                txtGroupSize.Text = ""
                txtGroupSize.Focus()
            End If
        Else
            ' Display message if you have entered a non numerical value
            MsgBox("Please enter a number for Groups.", , "Input error.")
            txtGroupSize.Text = ""
            txtGroupSize.Focus()
        End If
    End Sub

    Private Sub lblClear_Click(sender As Object, e As EventArgs) Handles lblClear.Click
        ' The clear button will be used to delete the number inputted and set it back to default.
        ' It will also have radSuperHeroes button to be set to True

        txtGroupSize.Clear()
        lblTotal.Text = ""
        radSuperHero.Checked = True
        radAutograph.Checked = False
        radConvention.Checked = False
        txtGroupSize.Focus()
    End Sub

    Private Sub frmComic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the form is loaded at the start of
        ' the program. 
        txtGroupSize.Focus()
        lblTotal.Text = ""
    End Sub
End Class

