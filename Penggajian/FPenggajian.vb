Public Class FPenggajian
    Public edit As Boolean

    Private Sub ComboBox1_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbIDKaryawan.DropDown
        Cari = "Karyawan"
        FCari.Show()
    End Sub

    Sub HitungGaji()
        TxJumlah.Text = Val(TxGajiPokok.Text) + Val(TxTunjKesehatan.Text) + Val(TxTunjAnak.Text) + Val(TxNominal.Text)
    End Sub

    Private Sub TxNominal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxNominal.TextChanged
        HitungGaji()
    End Sub

    Private Sub Penggajian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openConn()
        setLV()
        IsiCombo()
        edit = False
    End Sub

    Sub setLV()
        LV.View = View.Details
        LV.FullRowSelect = True
        LV.HoverSelection = True
        LV.GridLines = True

        LV.Columns.Clear()
        LV.Columns.Add("ID", 40, HorizontalAlignment.Right)
        LV.Columns.Add("Nama", 60, HorizontalAlignment.Left)
        LV.Columns.Add("Jbt", 40, HorizontalAlignment.Right)
        LV.Columns.Add("Gaji", 65, HorizontalAlignment.Right)
        LV.Columns.Add("Kesehatan", 65, HorizontalAlignment.Right)
        LV.Columns.Add("Anak", 65, HorizontalAlignment.Right)
        LV.Columns.Add("Eks", 65, HorizontalAlignment.Left)
        LV.Columns.Add("Nominal", 65, HorizontalAlignment.Right)
        LV.Columns.Add("Jumlah", 65, HorizontalAlignment.Right)
    End Sub

    Private Sub BtTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtTambah.Click
        If LV.Items.Count = 0 Then
            Nomer()
        End If

        lst = LV.Items.Add(CbIDKaryawan.Text)
        lst.SubItems.Add(TxNama.Text)
        lst.SubItems.Add(TxIDJabatan.Text)
        lst.SubItems.Add(TxGajiPokok.Text)
        lst.SubItems.Add(TxTunjKesehatan.Text)
        lst.SubItems.Add(TxTunjAnak.Text)
        lst.SubItems.Add(TxExtra.Text)
        lst.SubItems.Add(TxNominal.Text)
        lst.SubItems.Add(TxJumlah.Text)

        TambahTotal()
        KosongInput()
    End Sub

    Sub Nomer()
        StrSQl = "select count(*) from penggajian"
        Read(StrSQl)
        rd.Read()

        If rd(0) = 0 Then
            LbIDGaji.Text = Format(Now(), "yy") & "/" & Format(Now(), "MM") & "/" & "001"
        Else
            LbIDGaji.Text = Format(Now(), "yy") & "/" & Format(Now(), "MM") & "/" & Format(rd(0) + 1, "000")
        End If
    End Sub

    Sub KosongInput()
        CbIDKaryawan.Text = ""
        TxNama.Text = ""
        TxIDJabatan.Text = ""
        TxGajiPokok.Text = ""
        TxTunjKesehatan.Text = ""
        TxTunjAnak.Text = ""
        TxExtra.Text = ""
        TxNominal.Text = ""
        TxJumlah.Text = ""
    End Sub

    Sub TambahTotal()
        TxTotal.Text = Val(TxTotal.Text) + Val(TxJumlah.Text)
    End Sub

    Sub KurangTotal()
        TxTotal.Text = Val(TxTotal.Text) - Val(LV.SelectedItems(0).SubItems(8).Text)
    End Sub

    Private Sub LV_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        If MsgBox("Hapus data " & LV.SelectedItems(0).Text & "?", vbYesNo) = vbYes Then
            KurangTotal()
            LV.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub LV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LV.KeyDown
        If e.KeyCode = Keys.Delete Then
            HapusToolStripMenuItem_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub SimpanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanToolStripMenuItem.Click
        Nomer()
        KosongInput()
        LV.Items.Clear() 'bersihkan listview
        edit = False
    End Sub

    Private Sub CariToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariToolStripMenuItem.Click
        Dim i As Integer

        If edit = False Then
            'insert penggajian
            StrSQl = "insert into penggajian values ('" & LbIDGaji.Text & "', '" & DTPTanggal.Value & "')"
            Exec(StrSQl)

            'insert detail dengan menyimpan semua data yang ada di listview
            For i = 0 To LV.Items.Count - 1
                StrSQl = "insert into dpenggajian values ('" & LbIDGaji.Text & "', " & _
                            "'" & LV.Items(i).SubItems(0).Text & "', '" & LV.Items(i).SubItems(6).Text & "', " & _
                            "" & IIf(LV.Items(i).SubItems(7).Text = "", "0", LV.Items(i).SubItems(7).Text) & ")"
                Exec(StrSQl)
            Next

            MsgBox("Data tersimpan!")
        ElseIf edit = True Then
            'update penggajian
            StrSQl = "update penggajian set tgl = '" & DTPTanggal.Value & "' " & _
                        "where idgaji ='" & LbIDGaji.Text & "'"
            Exec(StrSQl)

            'hapus data lama pada detail
            StrSQl = "delete from dpenggajian where idgaji = '" & LbIDGaji.Text & "'"
            Exec(StrSQl)

            'insert detail yang baru
            For i = 0 To LV.Items.Count - 1
                StrSQl = "insert into dpenggajian values ('" & LbIDGaji.Text & "', " & _
                            "'" & LV.Items(i).SubItems(0).Text & "', '" & LV.Items(i).SubItems(6).Text & "', " & _
                            "" & IIf(LV.Items(i).SubItems(7).Text = "", "0", LV.Items(i).SubItems(7).Text) & ")"
                Exec(StrSQl)
            Next

            MsgBox("Data terupdate!")
        End If

        IsiCombo()
        LV.Items.Clear()
        TxTotal.Text = "0"
        edit = False
    End Sub

    Sub IsiCombo()
        StrSQl = ("select IdGaji from penggajian order by IdGaji desc")
        Read(StrSQl)

        'display
        ToolStripComboBox1.Items.Clear()
        While rd.Read
            ToolStripComboBox1.Items.Add(rd(0))
        End While
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        'bersih-bersih
        KosongInput()
        LV.Items.Clear()
        TxTotal.Text = "0"

        'taruh value dari tabel ke textbox
        StrSQl = "select * from Qallpenggajian where idgaji = '" & ToolStripComboBox1.Text & "'"
        Read(StrSQl)

        While rd.Read()
            LbIDGaji.Text = rd(0)
            DTPTanggal.Value = rd(1)

            lst = LV.Items.Add(rd(2))
            lst.SubItems.Add(rd(3))
            lst.SubItems.Add(rd(4))
            lst.SubItems.Add(rd(5))
            lst.SubItems.Add(rd(6))
            lst.SubItems.Add(rd(7))
            lst.SubItems.Add(rd(8))
            lst.SubItems.Add(rd(9))
            lst.SubItems.Add(rd(10))

            TxTotal.Text = Val(TxTotal.Text) + Val(rd(10))
        End While

        edit = True
    End Sub

    Private Sub HapusToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusToolStripMenuItem1.Click
        StrSQl = "delete from dpenggajian where idgaji = '" & LbIDGaji.Text & "'"
        Exec(StrSQl)

        StrSQl = "delete from penggajian where idgaji = '" & LbIDGaji.Text & "'"
        Exec(StrSQl)

        LV.Items.Clear()
        KosongInput()
        LbIDGaji.Text = "none"
        ToolStripComboBox1.Text = ""
        IsiCombo()
        MsgBox("Data dihapus!")
    End Sub
End Class