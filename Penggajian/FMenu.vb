Public Class FMenu

    Private Sub KaryawanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KaryawanToolStripMenuItem.Click
        Form1.Show()
        Form1.MdiParent = Me
    End Sub

    Private Sub JabatanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JabatanToolStripMenuItem.Click
        FJabatan.Show()
        FJabatan.MdiParent = Me
    End Sub

    Private Sub PenggajianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggajianToolStripMenuItem.Click
        FPenggajian.Show()
        FPenggajian.MdiParent = Me
    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        FPrint.Show()
        FPrint.MdiParent = Me
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem1.Click
        Application.Exit()
    End Sub
End Class