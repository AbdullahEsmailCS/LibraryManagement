Public Class Form2

    Private Sub اضافةكتابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةكتابToolStripMenuItem.Click
        Dim frm As New frm_add_book

        frm.Show()

    End Sub

    Private Sub ادارةالكتبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالكتبToolStripMenuItem.Click
        Dim frm As New frm_show_book
        frm.Show()
    End Sub
End Class