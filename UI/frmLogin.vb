Public Class frmLogin
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Me.Hide()
        If txtUser.Text = "1" Then
            Dim frm As New frmInicioAdministrador()
            frm.Show()

        Else
            Dim frm As New frmInicioEvaluador()
            frm.Show()
        End If

    End Sub
End Class