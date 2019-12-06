Public Class Form1
    Public edit As Boolean

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        openConn()

        'ambil data jabatan
        StrSQl = "select idjabatan from jabatan"
        Read(StrSQl)

        CbJabatan.Items.Clear() 'bersih-bersih dahulu

        While rd.Read
            CbJabatan.Items.Add(rd(0))
        End While
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        TxFile.Text = OpenFileDialog1.FileName 'tampil nama file

        On Error Resume Next
        PBox.Image.Dispose() 'buang file lama, jika ada

        PBox.Image = Image.FromFile(OpenFileDialog1.FileName) 'tampilkan dalam Pic Box 
        PBox.SizeMode = PictureBoxSizeMode.StretchImage 'strech
    End Sub

    Private Sub btTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        kosong()
        edit = False
    End Sub

    Sub kosong()
        TxIdKry.Text = ""
        TxNama.Text = ""
        DTPTgl.Value = Now()
        TxAlamat.Text = ""
        TxTelp.Text = ""
        TxFile.Text = ""
        TxFileTemp.Text = ""
        PBox.Image = Nothing
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        Dim namaFile As String

        If edit = True Then 'lagi ngedit Vroooh

            'jika upload gambar baru
            If Trim(TxFile.Text) <> Trim(TxFileTemp.Text) Then
                namaFile = System.IO.Path.GetFileName(TxFile.Text) 'nama file baru

                'delete yang lama
                If System.IO.File.Exists(TxFileTemp.Text) Then  'apabila fileny ada 
                    Try
                        FileSystem.Kill(TxFileTemp.Text)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

                'upload gambar baru
                If System.IO.File.Exists(TxFile.Text) Then  'apabila filenya ada 
                    Try
                        System.IO.File.Copy(TxFile.Text, Application.StartupPath & "\Foto\" & namaFile)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else 'jika tidak
                namaFile = System.IO.Path.GetFileName(TxFileTemp.Text)
            End If

            StrSQl = "update karyawan set nama = '" & TxNama.Text & "', " & _
                    "tgllahir = '" & DTPTgl.Value & "', telpon = '" & TxTelp.Text & "', " & _
                    "alamat = '" & TxAlamat.Text & "', foto = '" & namaFile & "', " & _
                    "idjabatan = '" & CbJabatan.Text & "'" & _
                    "where idkaryawan = '" & TxIdKry.Text & "'"
            Exec(StrSQl)
            kosong()

        ElseIf edit = False Then 'tidak sedang edit

            If Trim(TxFile.Text) = "" Then
                StrSQl = "insert into karyawan values('" & TxIdKry.Text & "', " & _
                    "'" & TxNama.Text & "', '" & DTPTgl.Value & "', " & _
                    "'" & TxTelp.Text & "','" & TxAlamat.Text & "', '', " & _
                    "'" & CbJabatan.Text & "')"
            Else
                namaFile = System.IO.Path.GetFileName(OpenFileDialog1.FileName) 'nama file

                'upload
                If System.IO.File.Exists(TxFile.Text) Then  'apabila fileny ada 
                    Try
                        System.IO.File.Copy(TxFile.Text, Application.StartupPath & "\Foto\" & namaFile)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If

                StrSQl = "insert into karyawan values('" & TxIdKry.Text & "', " & _
                    "'" & TxNama.Text & "', '" & DTPTgl.Value & "', " & _
                    "'" & TxTelp.Text & "','" & TxAlamat.Text & "', '" & namaFile & "'" & _
                    "'" & CbJabatan.Text & "')"
            End If

            Exec(StrSQl)
            kosong()
        End If
        edit = False
    End Sub

    Private Sub TabControl1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabControl1.MouseClick
        If TabControl1.SelectedIndex = 1 Then
            'set listview
            LV.View = View.Details
            LV.HoverSelection = True
            LV.FullRowSelect = True

            LV.Columns.Clear()

            'set kolom
            LV.Columns.Add("ID", 50, HorizontalAlignment.Right)
            LV.Columns.Add("Nama", 70, HorizontalAlignment.Left)
            LV.Columns.Add("Telp", 90, HorizontalAlignment.Left)

            'tampilkan data
            StrSQl = "select idkaryawan, nama, telpon " & _
                    "from karyawan order by idkaryawan desc"
            Read(StrSQl)

            'display
            LV.Items.Clear()
            While rd.Read
                lst = LV.Items.Add(rd(0))
                lst.SubItems.Add(rd(1))
                lst.SubItems.Add(rd(2))
            End While
        End If
    End Sub

    Private Sub LV_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LV.MouseDoubleClick
        StrSQl = "select idkaryawan, nama, tgllahir, telpon, alamat, foto, idjabatan " & _
                "from karyawan where IDkaryawan = '" & LV.SelectedItems.Item(0).Text & "'"
        Read(StrSQl)
        rd.Read()

        TxIdKry.Text = rd(0)
        TxNama.Text = rd(1)
        DTPTgl.Value = rd(2)
        TxAlamat.Text = rd(3)
        TxTelp.Text = rd(4)
        CbJabatan.Text = rd(6)

        If Trim(rd(5)) <> "" Then 'jika ada foto            
            TxFile.Text = Application.StartupPath & "\Foto\" & rd(5)
            TxFileTemp.Text = TxFile.Text

            If System.IO.File.Exists(TxFile.Text) Then 'memastikan bahwa foto benar2 ada
                PBox.Image = Image.FromFile(Application.StartupPath & "\Foto\" & rd(5))
                PBox.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                TxFile.Text = ""
                TxFileTemp.Text = TxFile.Text
            End If
        Else
            TxFile.Text = ""
            TxFileTemp.Text = TxFile.Text

            PBox.Image = Nothing
        End If

        TabControl1.SelectedIndex = 0 'buka tabcontrol index 0
        edit = True
    End Sub

    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click
        If Trim(TxFile.Text) <> "" Then
            Try
                PBox.Image.Dispose()
                If System.IO.File.Exists(TxFile.Text) Then
                    FileSystem.Kill(TxFile.Text) 'hapus file
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If
        StrSQl = "delete from karyawan where idkaryawan = '" & TxIdKry.Text & "'"
        Exec(StrSQl)
        kosong()
        edit = False
    End Sub

    Private Sub LV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LV.SelectedIndexChanged

    End Sub

    Private Sub HapusFotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusFotoToolStripMenuItem.Click
        If Trim(TxFile.Text) <> "" Then
            Try
                PBox.Image.Dispose()
                If System.IO.File.Exists(TxFile.Text) Then
                    FileSystem.Kill(TxFile.Text) 'hapus file
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        End If
        StrSQl = "update karyawan set foto='' where idkaryawan = '" & TxIdKry.Text & "'"
        Exec(StrSQl)
        kosong()
        edit = False
    End Sub

    Private Sub PBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PBox.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition)
        Else
            OpenFileDialog1.Title = "Pilih foto"
            OpenFileDialog1.ShowDialog()
            OpenFileDialog1.Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        End If
    End Sub
End Class
