<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPrint
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CBPilih = New System.Windows.Forms.ComboBox()
        Me.CBDari = New System.Windows.Forms.ComboBox()
        Me.CBSampai = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CBPilih
        '
        Me.CBPilih.FormattingEnabled = True
        Me.CBPilih.Items.AddRange(New Object() {"Karyawan", "Penggajian"})
        Me.CBPilih.Location = New System.Drawing.Point(58, 20)
        Me.CBPilih.Name = "CBPilih"
        Me.CBPilih.Size = New System.Drawing.Size(93, 21)
        Me.CBPilih.TabIndex = 0
        '
        'CBDari
        '
        Me.CBDari.FormattingEnabled = True
        Me.CBDari.Location = New System.Drawing.Point(58, 47)
        Me.CBDari.Name = "CBDari"
        Me.CBDari.Size = New System.Drawing.Size(93, 21)
        Me.CBDari.TabIndex = 1
        '
        'CBSampai
        '
        Me.CBSampai.FormattingEnabled = True
        Me.CBSampai.Location = New System.Drawing.Point(58, 74)
        Me.CBSampai.Name = "CBSampai"
        Me.CBSampai.Size = New System.Drawing.Size(93, 21)
        Me.CBSampai.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Pilih"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sampai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dari"
        '
        'BtPrint
        '
        Me.BtPrint.Location = New System.Drawing.Point(58, 101)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(95, 26)
        Me.BtPrint.TabIndex = 6
        Me.BtPrint.Text = "Print"
        Me.BtPrint.UseVisualStyleBackColor = True
        '
        'FPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(163, 145)
        Me.Controls.Add(Me.BtPrint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBSampai)
        Me.Controls.Add(Me.CBDari)
        Me.Controls.Add(Me.CBPilih)
        Me.Name = "FPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FPrint"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CBPilih As System.Windows.Forms.ComboBox
    Friend WithEvents CBDari As System.Windows.Forms.ComboBox
    Friend WithEvents CBSampai As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtPrint As System.Windows.Forms.Button
End Class
