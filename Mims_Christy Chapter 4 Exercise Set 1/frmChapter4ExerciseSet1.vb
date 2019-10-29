'Program: Chapter 4 Exercise Set 1
'Programmer Name: Christy Mims
'Date: 3/3/17
'Description:  This program allows the user to enter, compute, and change information in the exercises 22, 24, 26, 30, 34, 36, 38 starting on page 137
'and 24 and 28 on page 155. The user Is able to do this through the use of text boxes and buttons.  The code then computes and changes data for the user.
Public Class frmChapter4ExerciseSet1
    Dim high_score1 As Integer = 0
    Dim high_score2 As Integer = 0
    Dim color_is_red As Boolean = True

    Private Sub btnComputeCost22_Click(sender As Object, e As EventArgs) Handles btnComputeCost22.Click
        'This button calculates the cost of bagels.
        Dim Cost, bagels As Decimal
        bagels = CDec(txtNumberOfBagels.Text)
        If bagels < 6 Then
            Cost = bagels * 0.75D
        ElseIf bagels >= 6 Then
            Cost = bagels * 0.6D
        End If
        txtCost.Text = Cost.ToString("C")
    End Sub

    Private Sub btnComputeCost24_Click(sender As Object, e As EventArgs) Handles btnComputeCost24.Click
        'This button calculates the cost for copies.
        Dim Cost24, copies As Decimal
        copies = CDec(txtNumberOfCopies.Text)
        If copies < 100 Then
            Cost24 = 0.05D * copies
        ElseIf copies >= 100 Then
            Cost24 = 5 + (copies - 100) * 0.03D
        End If
        txtCost24.Text = Cost24.ToString("C")
    End Sub

    Private Sub btnGrossPay_Click(sender As Object, e As EventArgs) Handles btnGrossPay.Click
        'This button calculates gross pay based on hourly wage and hours worked.
        Dim hourly_wage, hours_worked, gross_pay As Decimal
        hourly_wage = CDec(txtHourlyWage.Text)
        hours_worked = CDec(txtHoursWorked.Text)
        If hours_worked <= 40 Then
            gross_pay = hourly_wage * hours_worked
        ElseIf hours_worked > 40 Then
            gross_pay = (40 * hourly_wage) + (1.5 * hourly_wage * (hours_worked - 40))
        End If
        txtGrossPay.Text = gross_pay.ToString("C")
    End Sub

    Private Sub btnComputeNewBalance_Click(sender As Object, e As EventArgs) Handles btnComputeNewBalance.Click
        'This button calculates the new balance after money is withdrawn from bank.
        Dim current_balance, withrawal, new_balance As Decimal
        current_balance = CDec(txtCurrentBalance.Text)
        withrawal = CDec(txtWithdrawal.Text)

        new_balance = current_balance - withrawal

        If current_balance < withrawal Then
            txtNewBalance.Text = "Withdrawal Denied"
        ElseIf new_balance < 150 Then
            txtNewBalance.Text = "New balance is " & new_balance.ToString("C") & ".      " & "Balance below $150"
        Else
            txtNewBalance.Text = "The new balance is " & new_balance.ToString("C")
        End If
    End Sub

    Private Sub btnChangeTextColor_Click(sender As Object, e As EventArgs) Handles btnChangeTextColor.Click
        'This button changes the color of text entered in the text box.
        If color_is_red Then
            txtNewColor.ForeColor = Color.Red
            color_is_red = False
        Else
            txtNewColor.ForeColor = Color.Black
            color_is_red = True
        End If
    End Sub

    Private Sub btnReadCurrentScore_Click(sender As Object, e As EventArgs) Handles btnReadCurrentScore.Click
        'This button displays the current score.
        Dim score As Integer
        score = txtScore.Text
        high_score1 = score
    End Sub

    Private Sub btnDisplayTwoHighestScores_Click(sender As Object, e As EventArgs) Handles btnDisplayTwoHighestScores.Click
        'This button displays the two highest scores entered in.
        Dim score As Integer
        score = txtScore.Text
        If score > high_score1 Then
            high_score1 = score
        ElseIf score < high_score1 Then
            high_score2 = score
        End If
        txtTwoHighestScores.Text = high_score1 & (" ") & (" ") & high_score2

    End Sub

    Private Sub btnCalculateTax_Click(sender As Object, e As EventArgs) Handles btnCalculateTax.Click
        'This button calculates the amount tax.
        Dim income_tax, Tax As Decimal
        income_tax = txtTaxableIncome.Text
        If income_tax <= 50000 And income_tax <= 20000 Then
            Tax = 0.02D * income_tax
            txtTax.Text = Tax.ToString("C")
            txtTax.Text = Tax
        ElseIf income_tax <= 50000 Then
            Tax = 400 + 0.025 * (income_tax - 20000)
            txtTax.Text = Tax.ToString("C")
        ElseIf income_tax > 50000 Then
            Tax = 1150 + 0.035D * (income_tax - 50000)
            txtTax.Text = Tax.ToString("C")
        End If
    End Sub

    Private Sub btnFindBook_Click(sender As Object, e As EventArgs) Handles btnFindBook.Click
        'This button helps a user to locate a book in a library based on the books call number.
        Dim call_number As Decimal
        call_number = CDec(txtCallNumber.Text)
        Select Case call_number
            Case 100 To 199
                txtLocation.Text = "basement"
            Case 200 To 500, Is > 900
                txtLocation.Text = "main floor"
            Case 501 To 699, 751 To 900
                txtLocation.Text = "upper floor"
            Case 700 To 750
                txtLocation.Text = "archives"
            Case Else
                txtLocation.Text = "Call number must be 100 or more."
        End Select
    End Sub

    Private Sub btnComputeTotalOfTour_Click(sender As Object, e As EventArgs) Handles btnComputeTotalOfTour.Click
        'This button allows the user determine the cost for a tour based on the amount of people they have.
        Dim number_of_registrants, total As Double
        number_of_registrants = CDbl(txtNumberRegistrants.Text)
        Select Case number_of_registrants
            Case 10 To 19
                total = 500 * number_of_registrants
            Case 20 To 29
                total = 450 * number_of_registrants
            Case Is >= 30
                total = 400 * number_of_registrants
            Case < 10
                MessageBox.Show("Sorry, there must be at least 10 registrants.")
        End Select
        txtTotalCost.Text = total.ToString("C")
    End Sub
End Class
