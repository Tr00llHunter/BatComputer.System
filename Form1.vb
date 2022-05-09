Public Class Form1

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Informacion.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Batman" And TextBox2.Text = "Selina Kyle" Then
            Baticomputadora.Show()
            Me.Hide()
        Else
            MsgBox("Usuario/Contraseña Incorrecta", MsgBoxStyle.Exclamation, "Error")

        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "Batman" And TextBox2.Text = "Selina Kyle" Then
            Baticomputadora.Show()
            Me.Hide()
        Else
            MsgBox("Usuario/Contraseña Incorrecta", MsgBoxStyle.Exclamation, "Error")

        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
