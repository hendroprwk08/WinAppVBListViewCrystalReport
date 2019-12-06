Public Class PrKaryawan

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim report As New CrKaryawan 'nama crystal report

        'database dipanggil ulang sesuai lokasinya (dinamis)
        report.Database.Tables(0).Location = Application.StartupPath & "\Penggajian.mdb"
        report.SetDatabaseLogon("Admin", "")

        report.RecordSelectionFormula = "{Karyawan.idkaryawan} >= '" & FPrint.CBDari.Text & "' " & _
                                        "and {Karyawan.idkaryawan} <= '" & FPrint.CBSampai.Text & "'"

        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub PrKaryawan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class