Public Class Form1


    Private Sub btndevide_Click(sender As Object, e As EventArgs) Handles btndevide.Click
        Try
            Dim a, b As Integer
            a = Txt1.Text
            b = txt2.Text
            lblresult.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
