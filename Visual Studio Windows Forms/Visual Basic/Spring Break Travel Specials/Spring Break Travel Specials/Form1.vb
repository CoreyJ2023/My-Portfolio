' Program name: Spring Break Travel Specials
' Developer: Corey Jenkins
' Date: September 13, 2017
' Purpose: This application will be used to select between the locations of Myrtle Beach, Key West,
' Venice Beach. The user can only choose one.
Public Class FrmSpringBreakTravelSpecial
    Private Sub btnMyrtleBeach_Click(sender As Object, e As EventArgs) Handles btnMyrtleBeach.Click
        ' This button will enabled the picture of Myrtle Beach and Key West, and Venice Beach will not show.


        picMyrtleBeach.Visible = True
        picKeyWest.Visible = False
        picVeniceBeach.Visible = False
        btnPurchase.Enabled = True
    End Sub

    Private Sub btnKeyWest_Click(sender As Object, e As EventArgs) Handles btnKeyWest.Click
        ' This button will enabled the picture of Key West while Myrtle Beach and Venice Beach will not appear.
        ' The Purchase button is also enabled.

        picKeyWest.Visible = True
        picMyrtleBeach.Visible = False
        picVeniceBeach.Visible = False
        btnPurchase.Enabled = True
    End Sub

    Private Sub btnVeniceBeach_Click(sender As Object, e As EventArgs) Handles btnVeniceBeach.Click
        ' This button will enable the picture of Venice Beach and Myrtle Beach and Key West pictures will not appear.
        ' The Purchase Button will also be enabled.

        picVeniceBeach.Visible = True
        picMyrtleBeach.Visible = False
        picKeyWest.Visible = False
        btnPurchase.Enabled = True
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        ' This is for the Purchase button. When enabled none of the buttons can be clicked.
        ' The only option from this point will be the Exit Button.
        lblEnjoy.Visible = True
        btnPurchase.Enabled = False
        btnMyrtleBeach.Enabled = False
        btnKeyWest.Enabled = False
        btnVeniceBeach.Enabled = False
        btnCloseWindow.Enabled = True
    End Sub

    Private Sub btnCloseWindow_Click(sender As Object, e As EventArgs) Handles btnCloseWindow.Click
        ' This will close the window once a location has been purchased.
        Close()
    End Sub
End Class