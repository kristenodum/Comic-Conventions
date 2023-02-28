Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtsize.Clear()
        lblTotalCost.Text = ""
        radSuperHero.Checked = True
        radAutograph.Checked = False
        radConvention.Checked = False
        txtsize.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler is executed when the user clicks the Calculate Button. It calculates 
        'the total registration cost.

        'Declaration section
        Dim intGroupSize As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decradSuperHero As Decimal = 380D
        Dim decradAutograph As Decimal = 275D
        Dim decradConvention As Decimal = 209D

        'Did the user enter a numeric value
        If IsNumeric(txtsize.Text) Then
            intGroupSize = Convert.ToInt32(txtsize.Text)
            ' Is number of group greater than zero 
            If intGroupSize > 0 And intGroupSize < 20 Then
                If radSuperHero.Checked Then
                    decRegistration = decradSuperHero
                ElseIf radAutograph.Checked Then
                    decRegistration = decradAutograph
                ElseIf radConvention.Checked Then
                    decRegistration = decradConvention
                End If
                decTotalCost = (intGroupSize * decRegistration)
                lblTotalCost.Text = decTotalCost.ToString("C")
            Else
                'Display error message if user entered a negative number 
                MsgBox("Enter a positive number between 1 and 20", , "Invalid number error")

            End If
        Else
            'Display error message if user entered a nonnumeric value 
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid Entry error")


        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This event handler is executed when the Comic Convention Form is loaded
        lblTotalCost.Text = ""
    End Sub
End Class
