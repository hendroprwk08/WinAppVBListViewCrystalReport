Public Class FPrint

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub FPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openConn()
    End Sub

    Private Sub CBPilih_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBPilih.SelectedIndexChanged
        If CBPilih.Text = "Karyawan" Then
            StrSQl = "select idkaryawan from karyawan order by idkaryawan asc"
            Read(StrSQl)
        Else
            StrSQl = "select idgaji from penggajian order by idgaji asc"
            Read(StrSQl)
        End If

        CBDari.Text = ""
        CBSampai.Text = ""

        'bersihkan item
        CBDari.Items.Clear()
        CBSampai.Items.Clear()

        'isi item
        While rd.Read
            CBDari.Items.Add(rd(0))
            CBSampai.Items.Add(rd(0))
        End While
    End Sub

    Private Sub BtPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtPrint.Click
        If CBPilih.Text = "Karyawan" Then
            PrKaryawan.Show()
        Else
            PrPenggajian.Show()
        End If
    End Sub
End Class