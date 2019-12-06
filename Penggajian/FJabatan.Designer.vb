<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FJabatan
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.TxTunj_Anak = New System.Windows.Forms.TextBox()
        Me.TxTunj_Kesehatan = New System.Windows.Forms.TextBox()
        Me.TxGaji_Pokok = New System.Windows.Forms.TextBox()
        Me.TxId_Jabatan = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Lv = New System.Windows.Forms.ListView()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(214, 216)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btSimpan)
        Me.TabPage1.Controls.Add(Me.btHapus)
        Me.TabPage1.Controls.Add(Me.btTambah)
        Me.TabPage1.Controls.Add(Me.TxTunj_Anak)
        Me.TabPage1.Controls.Add(Me.TxTunj_Kesehatan)
        Me.TabPage1.Controls.Add(Me.TxGaji_Pokok)
        Me.TabPage1.Controls.Add(Me.TxId_Jabatan)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(206, 190)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Anak"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Kesehatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Gaji"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Jabatan"
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(33, 150)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(60, 23)
        Me.btSimpan.TabIndex = 19
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Location = New System.Drawing.Point(94, 150)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(24, 23)
        Me.btHapus.TabIndex = 20
        Me.btHapus.Text = "-"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btTambah
        '
        Me.btTambah.Location = New System.Drawing.Point(8, 150)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(24, 23)
        Me.btTambah.TabIndex = 18
        Me.btTambah.Text = "+"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'TxTunj_Anak
        '
        Me.TxTunj_Anak.Location = New System.Drawing.Point(69, 109)
        Me.TxTunj_Anak.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxTunj_Anak.Name = "TxTunj_Anak"
        Me.TxTunj_Anak.Size = New System.Drawing.Size(125, 20)
        Me.TxTunj_Anak.TabIndex = 17
        '
        'TxTunj_Kesehatan
        '
        Me.TxTunj_Kesehatan.Location = New System.Drawing.Point(69, 81)
        Me.TxTunj_Kesehatan.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxTunj_Kesehatan.Name = "TxTunj_Kesehatan"
        Me.TxTunj_Kesehatan.Size = New System.Drawing.Size(125, 20)
        Me.TxTunj_Kesehatan.TabIndex = 16
        '
        'TxGaji_Pokok
        '
        Me.TxGaji_Pokok.Location = New System.Drawing.Point(69, 53)
        Me.TxGaji_Pokok.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxGaji_Pokok.Name = "TxGaji_Pokok"
        Me.TxGaji_Pokok.Size = New System.Drawing.Size(125, 20)
        Me.TxGaji_Pokok.TabIndex = 15
        '
        'TxId_Jabatan
        '
        Me.TxId_Jabatan.Location = New System.Drawing.Point(69, 25)
        Me.TxId_Jabatan.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.TxId_Jabatan.Name = "TxId_Jabatan"
        Me.TxId_Jabatan.Size = New System.Drawing.Size(125, 20)
        Me.TxId_Jabatan.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Lv)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(206, 190)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Lv
        '
        Me.Lv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lv.Location = New System.Drawing.Point(3, 3)
        Me.Lv.Name = "Lv"
        Me.Lv.Size = New System.Drawing.Size(200, 184)
        Me.Lv.TabIndex = 0
        Me.Lv.UseCompatibleStateImageBehavior = False
        '
        'FJabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(231, 236)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FJabatan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jabatan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents TxTunj_Anak As System.Windows.Forms.TextBox
    Friend WithEvents TxTunj_Kesehatan As System.Windows.Forms.TextBox
    Friend WithEvents TxGaji_Pokok As System.Windows.Forms.TextBox
    Friend WithEvents TxId_Jabatan As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Lv As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
