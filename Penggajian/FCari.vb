Public Class FCari

    Private Sub FCari_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openConn()

        If Cari = "Karyawan" Then
            SetLVKLaryawan()
            CariKaryawan()
        End If
    End Sub

    Sub CariKaryawan()
        StrSQl = "select * from Qinfokaryawan order by idkaryawan asc"
        Read(StrSQl)

        'display
        LV.Items.Clear()
        While rd.Read
            lst = LV.Items.Add(rd(0))
            lst.SubItems.Add(rd(1))
        End While
    End Sub

    Sub SetLVKLaryawan()
        LV.Columns.Clear()
        LV.Columns.Add("ID", 50, HorizontalAlignment.Right)
        LV.Columns.Add("Nama", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub LV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LV.DoubleClick
        If Cari = "Karyawan" Then
            StrSQl = "select * from QInfoKaryawan " & _
                "where IdKaryawan = '" & LV.SelectedItems.Item(0).Text & "'"
            Read(StrSQl)

            rd.Read()

            'akses objek yang ada di form penggajian
            FPenggajian.CbIDKaryawan.Text = rd(0)
            FPenggajian.TxNama.Text = rd(1)
            FPenggajian.TxIDJabatan.Text = rd(2)
            FPenggajian.TxGajiPokok.Text = rd(3)
            FPenggajian.TxTunjKesehatan.Text = rd(4)
            FPenggajian.TxTunjAnak.Text = rd(5)
            FPenggajian.HitungGaji() 'fungsi hitung gaji
        End If
        Close()
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub
End Class