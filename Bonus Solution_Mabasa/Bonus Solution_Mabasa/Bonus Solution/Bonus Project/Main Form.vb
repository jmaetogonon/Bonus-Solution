' Name:         Bonus Project
' Purpose:      Display a bonus amount
' Programmer:   Jochelle Mae T. Mabasa on September 03, 2020

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtSales_Enter(sender As Object, e As EventArgs) Handles txtSales.Enter
        txtSales.SelectAll()
    End Sub

    Private Sub txtCode_Enter(sender As Object, e As EventArgs) Handles txtCode.Enter
        txtCode.SelectAll()
    End Sub
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress, txtSales.KeyPress
        ' allows the text box to accept only numbers and  the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearBonus(sender As Object, e As EventArgs) Handles txtCode.TextChanged, txtSales.TextChanged
        lblBonus.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculates a bonus amount

        Dim intCode As Integer
        Dim dblSales As Double
        Dim dblBonus As Double
        Dim dblRate As Double

        Integer.TryParse(txtCode.Text, intCode)
        Double.TryParse(txtSales.Text, dblSales)

        Select Case intCode
            Case 1 To 5
                dblRate = 0.03
                dblBonus = dblSales * dblRate
                lblBonus.Text = dblBonus.ToString
            Case 6
                dblRate = 0.07
                dblBonus = dblSales * dblRate
                lblBonus.Text = dblBonus.ToString
            Case 7 To 10
                dblRate = 0.12
                dblBonus = dblSales * dblRate
                lblBonus.Text = dblBonus.ToString
            Case Else
                lblBonus.Text = "Invalid code"
        End Select

        txtCode.Focus()


    End Sub
End Class
