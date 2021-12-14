Public Class frmcalculator
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txttotal.Text = Val(txtnum1) + Val(txtnum2)
    End Sub
End Class
