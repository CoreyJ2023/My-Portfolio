'   Program Name:   The Big Movie Theatre/Individual Project
'   Author:         Corey Jenkins
'   Date:           November 24, 2016
'   Purpose:        To create a program that inputs the name of the movie,
'                   The amount of tickets added and then select "adult" "senior"  or "child"
'                   each with their price. It will then display the name of the movie,
'                   tickets bought the price for the person and then the total price.                 


Option Strict On

Public Class frmMovie

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' For the Display Button, it will show what Movie is typed, the amount of tickets, the calcuation of the tickets with
        ' one of the radio buttons selected, and then the total amount.


        Dim strMovie As String
        Dim intTickets As Integer
        Dim decTicketType As Decimal
        Dim decTicketSenior As Decimal = 9.75D
        Dim decTicketAdult As Decimal = 11.5D
        Dim decTicketChild As Decimal = 8.5D
        Dim decFinalPrice As Decimal

        ' For the number of tickets inputted, We'll code in an error if a text is used and if a negative number is used
        If IsNumeric(txtTickets.Text) Then
            intTickets = Convert.ToInt32(txtTickets.Text)
            'Did you enter a positive number
            If intTickets >= 1 Then
                If radAdult.Checked Then
                    decTicketType = decTicketAdult
                ElseIf radSenior.Checked Then
                    decTicketType = decTicketSenior
                ElseIf radChild.Checked Then
                    decTicketType = decTicketChild
                End If
                '   Calculating each and the answers will be displayed when the button is clicked.
                decFinalPrice = intTickets * decTicketAdult
                lblLastPrice.Text = decFinalPrice.ToString("C")
                lblTicketsPurchased.Text = intTickets.ToString()
                lblPrice.Text = decTicketType.ToString()

                lblMovieNameResults.Visible = True
                lblTicketResults.Visible = True
                lblTicketType.Visible = True
                lblTotalPrice.Visible = True
                lblTitle.Visible = True
                lblTicketsPurchased.Visible = True
                lblPrice.Visible = True
                lblTotalPrice.Visible = True
            Else
                'Error Message if you put in a negative number.
                MsgBox("You have entered a negative number or 0. Please enter a number greater than 0.")
                txtTickets.Text = ""
                txtTickets.Focus()
            End If

        Else
            'Error Message if you put in a letter or characters.
            MsgBox("You have entered text. Please enter a number.")
            txtTickets.Text = ""
            txtTickets.Focus()
        End If

        strMovie = txtMovie.Text
        lblTitle.Text = strMovie.ToString()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This button will clear the items inputted and can start over.
        txtTickets.Clear()
        txtTickets.Text = ""
        txtTickets.Focus()
        txtMovie.Clear()
        txtMovie.Text = ""
        txtMovie.Focus()
        radAdult.Checked = True
        radSenior.Checked = False
        radChild.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This button will terminate the program
        Close()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear will function the same way as the clear button.

        txtTickets.Clear()
        txtTickets.Text = ""
        txtTickets.Focus()
        txtMovie.Clear()
        txtMovie.Text = ""
        txtMovie.Focus()
        radAdult.Checked = True
        radSenior.Checked = False
        radChild.Checked = False
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' This is the menu for Exit. It should terminate the program the same way as the close button.
        Close()
    End Sub
End Class
