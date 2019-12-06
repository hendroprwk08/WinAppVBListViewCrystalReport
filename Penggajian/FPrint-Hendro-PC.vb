Public Class FPrint
    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        If CBJenis.Text = "Karyawan" Then
            'PrKaryawan.Show()
        Else
            'PrPengajuan.Show()
        End If
    End Sub

    Private Sub FPrint_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        openConn()
    End Sub

    Private Sub CBJenis_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBJenis.SelectedIndexChanged
        If CBJenis.Text = "Karyawan" Then
            StrSQl = "Select idkaryawan from karyawan"
            Read(StrSQl)

            CBDari.Items.Clear()
            CBSampai.Items.Clear()
            While rd.Read
                CBDari.Items.Add(rd(0))
                CBSampai.Items.Add(rd(0))
            End While
        Else
            StrSQl = "Select idgaji from penggajian"
            Read(StrSQl)

            CBDari.Items.Clear()
            CBSampai.Items.Clear()
            While rd.Read
                CBDari.Items.Add(rd(0))
                CBSampai.Items.Add(rd(0))
            End While
        End If
    End Sub
End Class