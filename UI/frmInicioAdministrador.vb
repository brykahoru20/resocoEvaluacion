Public Class frmInicioAdministrador
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim frm As New frmLogin()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub PaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaisToolStripMenuItem.Click
        Dim frm As New frmPais()
        frm.Show()
    End Sub

    Private Sub UsuarioCategoríaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioCategoríaToolStripMenuItem.Click
        Dim frm As New frmUsuarioCategoria()
        frm.Show()
    End Sub

    Private Sub PreguntaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntaToolStripMenuItem.Click
        Dim frm As New frmPregunta()
        frm.Show()
    End Sub

    Private Sub PreguntasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntasToolStripMenuItem.Click
        Dim frm As New frmCategoria()
        frm.Show()
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoToolStripMenuItem.Click
        Dim frm As New frmUsuario()
        frm.Show()
    End Sub
End Class