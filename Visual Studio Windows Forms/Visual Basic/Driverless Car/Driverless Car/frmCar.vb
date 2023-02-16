'   Program:    Driverless Car
'   Author:     Corey Jenkins
'   Date:       October 4, 2017
'   Purpose:    A program to calcuate and display the number of miles to the Destination.
'               The program displays the flat rate pr mile and the toal cost of the Uber fare.

Option Strict On

Public Class frmCar

    ' Here for $X.XX, 2.80 will be use in Decimal form.
    Const _cdecFlatTax = 2.8D
    Const _cdecMiles = 1.8D

    Private Sub btnDisplayFare_Click(sender As Object, e As EventArgs) Handles btnDisplayFare.Click
        '   This event handler is executed when the user click the.
        '   Display Fare button. It will calculate the cost per miles of $1.80 and 
        '   A adds the flat rate of 2.80 charge.

        Dim strNumberOfMiles As String
        Dim intNumberOfMiles As Integer
        Dim decTotalCost As Decimal
        Dim decTotalMiles As Decimal


        strNumberOfMiles = txtNumberOfMiles.Text
        intNumberOfMiles = Convert.ToInt32(strNumberOfMiles)
        decTotalMiles = intNumberOfMiles * _cdecMiles
        decTotalCost = decTotalMiles + _cdecFlatTax
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the 
        ' Clear button. It clears the miles
        ' After that the focus will be on the NumberOfMiles

        txtNumberOfMiles.Clear()
        lblTotalCost.Text = ""
        txtNumberOfMiles.Focus()
    End Sub

    Private Sub frmCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   This event handler is executed when the form is loaded.
        '   It will display the miles heading, clears the Text Property of the Total Cost label.
        '   Will set the focus on the txtNumberOfMiles textbox object

        lblFlatHeading.Text = _cdecFlatTax.ToString("C") & " is the Flat Tax"
        lblTotalCost.Text = ""
        txtNumberOfMiles.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the window and terminate the application.

        Close()
    End Sub

End Class
