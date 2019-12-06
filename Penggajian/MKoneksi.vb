Module MKoneksi

    Public conn As New OleDb.OleDbConnection
    Public cmd As New OleDb.OleDbCommand
    Public rd As OleDb.OleDbDataReader

    Public StrSQl, Cari As String
    Public lst As ListViewItem

    Public Sub openConn()
        StrSQl = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Penggajian.mdb"
        conn = New OleDb.OleDbConnection(StrSQl)

        Try
            conn.Open()
            If conn.State = ConnectionState.Closed Then
                MsgBox("Data Tidak Tersambung")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Exec(ByVal Query As String) 'untuk insert, update, delete
        Try
            cmd = New OleDb.OleDbCommand(Query, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Read(ByVal Query As String) 'untuk select
        Try
            cmd = New OleDb.OleDbCommand(Query, conn)
            cmd.ExecuteNonQuery()
            rd = cmd.ExecuteReader
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
