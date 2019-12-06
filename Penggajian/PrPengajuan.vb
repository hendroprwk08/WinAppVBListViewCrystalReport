Public Class PrPengajuan

    Private Sub CrystalReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles CrystalReportViewer1.Load
        'Modifikasi report karyawan 
        Dim MyReport As New CryPengajuan

        MyReport.Database.Tables(0).Location = Application.StartupPath & "\penggajian.mdb"
        MyReport.RecordSelectionFormula = "{QAllpenggajian.idgaji} >= '" & FPrint.CBDari.Text & "' and {QAllpenggajian.idgaji} <= '" & FPrint.CBSampai.Text & "'"

        CrystalReportViewer1.ReportSource = MyReport
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub PrPengajuan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = FMenu 'child form
    End Sub
End Class