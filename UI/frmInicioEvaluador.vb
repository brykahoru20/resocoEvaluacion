Public Class frmInicioEvaluador


    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Dim frm As New frmLogin()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim frm As New frmEvaluacion()
        frm.Show()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        Dim frm As New frmDetalleEvaluacion()
        frm.Show()
    End Sub

    Private Sub ContactoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContactoToolStripMenuItem.Click
        Dim frm As New frmContacto()
        frm.Show()
    End Sub
End Class