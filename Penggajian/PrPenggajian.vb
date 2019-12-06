Public Class PrPenggajian

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim report As New CrPenggajian

        report.Database.Tables(0).Location = Application.StartupPath & "\Penggajian.mdb"
        report.SetDatabaseLogon("Admin", "")

        report.RecordSelectionFormula = "{QAllPenggajian.IdGaji} >= '" & FPrint.CBDari.Text & "' " & _
                                        "and {QAllPenggajian.IdGaji} <= '" & FPrint.CBSampai.Text & "'"

        CrystalReportViewer1.ReportSource = report
        CrystalReportViewer1.Refresh()
    End Sub
End Class