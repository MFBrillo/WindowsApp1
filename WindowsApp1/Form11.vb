Public Class Form11
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim principal, interesttopay, totalinterest, rate, duration, totalamount As Single

        principal = Convert.ToDouble(txtprincipal.Text)
        rate = txtrate.Text
        duration = Convert.ToDouble(txtduration.Text)
        totalinterest = rate * duration
        txttotalinterest.Text = totalinterest
        interesttopay = (principal / 100) * (totalinterest)
        txtinteresttopay.Text = String.Format("{0:n}", Double.Parse(interesttopay))
        txttotalamount.Text = String.Format("{0:n}", Double.Parse(Val(txtprincipal.Text) + Val(txtinteresttopay.Text)))
        totalamount = Convert.ToDouble(txttotalamount.Text)
        txtamountschedule.Text = String.Format("{0:n}", Double.Parse(totalamount) / duration)




    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        MsgBox("A loan of Php" + txtprincipal.Text + " to be paid in " + txtduration.Text + " month." + vbCrLf + "The interest for the whole term is Php " + txtinteresttopay.Text + " and payment is Php " + txtamountschedule.Text + " Monthly." + vbCrLf + "The total amount to be paid as at the end of term is Php " + txttotalamount.Text + " (loan amount plus interest).", MsgBoxStyle.Information, "Summary of Loan")



    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class