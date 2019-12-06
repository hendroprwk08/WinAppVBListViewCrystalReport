Public Class FJabatan

    Private Sub Jabatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openConn()
    End Sub

    Private Sub TabControl1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseClick
        If TabControl1.SelectedIndex = 1 Then
            'set listview
            Lv.View = View.Details
            Lv.HoverSelection = True
            Lv.FullRowSelect = True

            Lv.Columns.Clear()

            'set kolom
            Lv.Columns.Add("ID", 50, HorizontalAlignment.Right)
            Lv.Columns.Add("Gaji", 70, HorizontalAlignment.Left)
            Lv.Columns.Add("Kesehatan", 70, HorizontalAlignment.Left)
            Lv.Columns.Add("Anak", 70, HorizontalAlignment.Left)

            'tampilkan data
            StrSQl = "select * from jabatan order by IdJabatan desc"
            Read(StrSQl)

            'display
            Lv.Items.Clear()
            While rd.Read
                lst = Lv.Items.Add(rd(0))
                lst.SubItems.Add(rd(1))
                lst.SubItems.Add(rd(2))
                lst.SubItems.Add(rd(3))
            End While
        End If
    End Sub

    Private Sub Btsimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        StrSQl = "insert into jabatan values ('" & TxId_Jabatan.Text & "'," & TxGaji_Pokok.Text & "," & TxTunj_Kesehatan.Text & "," & TxTunj_Anak.Text & ")"
        Exec(StrSQl)
    End Sub

    Private Sub Bttambah_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        kosong()
    End Sub
    Sub kosong()
        TxId_Jabatan.Text = ""
        TxGaji_Pokok.Text = ""
        TxTunj_Kesehatan.Text = ""
        TxTunj_Anak.Text = ""
    End Sub

    Private Sub TxId_Jabatan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxId_Jabatan.TextChanged

    End Sub

    Private Sub Lv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lv.DoubleClick
        StrSQl = "select * from Jabatan where IdJabatan = '" & Lv.SelectedItems.Item(0).Text & "'"
        Read(StrSQl)

        rd.Read()
        TxId_Jabatan.Text = rd(0)
        TxGaji_Pokok.Text = rd(1)
        TxTunj_Kesehatan.Text = rd(2)
        TxTunj_Anak.Text = rd(3)

        TabControl1.SelectedIndex = 0 'buka tabcontrol index 0
    End Sub

End Class