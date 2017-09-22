' Program Name: Pizza Selection
' Developer:    Tu Tong
' Date:         Septemper 21, 2017
' Purpose       This application displays two pizza types
'               (deep dish And thin crust). The user can select a pizza type.


Public Class frmPizzaSelection

    Private Sub btnDeepDish_Click(sender As Object, e As EventArgs) Handles btnDeepDish.Click
        ' This code is executed when user taps or clicks the Deep Dish button. 
        ' It displays the Deep Dish picture, hides the Thin Crust picture, 
        ' and enables the Select Pizza button.

        picDeepDish.Visible = True
        picThinCrust.Visible = False
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnSelectPizza_Click(sender As Object, e As EventArgs) Handles btnSelectPizza.Click
        ' This code is executed when user taps or clicks the Select Pizza button.
        ' It disables Deep Dish, Select Pizza, Thin Crust buttons,
        ' hide the instruction label, and display Confirmation Message label
        ' finally enables the Exit Window button

        btnDeepDish.Enabled = False
        btnSelectPizza.Enabled = False
        btnThinCrush.Enabled = False
        lblInstruction.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnThinCrush_Click(sender As Object, e As EventArgs) Handles btnThinCrush.Click
        ' This code is executed when the user taps or clicks the Thin Crush button.
        ' It displays the Thin Crust picture, hides the Deep Dish picture,
        ' and enables Select Pizza buton.

        picThinCrust.Visible = True
        picDeepDish.Visible = False
        btnSelectPizza.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user taps or clicks the Exit Window
        ' button. It closes the window and terminates the program execution.

        Close()

    End Sub

End Class
