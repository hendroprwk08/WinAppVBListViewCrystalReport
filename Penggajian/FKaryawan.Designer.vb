<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CbJabatan = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxFileTemp = New System.Windows.Forms.TextBox()
        Me.PBox = New System.Windows.Forms.PictureBox()
        Me.TxFile = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPTgl = New System.Windows.Forms.DateTimePicker()
        Me.TxNama = New System.Windows.Forms.TextBox()
        Me.TxTelp = New System.Windows.Forms.TextBox()
        Me.TxAlamat = New System.Windows.Forms.TextBox()
        Me.TxIdKry = New System.Windows.Forms.TextBox()
        Me.btSimpan = New System.Windows.Forms.Button()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LV = New System.Windows.Forms.ListView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(263, 291)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CbJabatan)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxFileTemp)
        Me.TabPage1.Controls.Add(Me.PBox)
        Me.TabPage1.Controls.Add(Me.TxFile)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.DTPTgl)
        Me.TabPage1.Controls.Add(Me.TxNama)
        Me.TabPage1.Controls.Add(Me.TxTelp)
        Me.TabPage1.Controls.Add(Me.TxAlamat)
        Me.TabPage1.Controls.Add(Me.TxIdKry)
        Me.TabPage1.Controls.Add(Me.btSimpan)
        Me.TabPage1.Controls.Add(Me.btHapus)
        Me.TabPage1.Controls.Add(Me.btTambah)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(255, 265)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Input Karyawan"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CbJabatan
        '
        Me.CbJabatan.FormattingEnabled = True
        Me.CbJabatan.Location = New System.Drawing.Point(59, 184)
        Me.CbJabatan.Name = "CbJabatan"
        Me.CbJabatan.Size = New System.Drawing.Size(103, 21)
        Me.CbJabatan.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Jabatan"
        '
        'TxFileTemp
        '
        Me.TxFileTemp.Location = New System.Drawing.Point(169, 179)
        Me.TxFileTemp.Multiline = True
        Me.TxFileTemp.Name = "TxFileTemp"
        Me.TxFileTemp.Size = New System.Drawing.Size(73, 37)
        Me.TxFileTemp.TabIndex = 20
        '
        'PBox
        '
        Me.PBox.BackColor = System.Drawing.Color.DimGray
        Me.PBox.Location = New System.Drawing.Point(168, 19)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(74, 101)
        Me.PBox.TabIndex = 7
        Me.PBox.TabStop = False
        '
        'TxFile
        '
        Me.TxFile.Location = New System.Drawing.Point(169, 125)
        Me.TxFile.Multiline = True
        Me.TxFile.Name = "TxFile"
        Me.TxFile.Size = New System.Drawing.Size(72, 47)
        Me.TxFile.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Telp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tgl Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "#Kry"
        '
        'DTPTgl
        '
        Me.DTPTgl.CustomFormat = "dd-MM-yyyy"
        Me.DTPTgl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTgl.Location = New System.Drawing.Point(61, 72)
        Me.DTPTgl.Name = "DTPTgl"
        Me.DTPTgl.Size = New System.Drawing.Size(91, 20)
        Me.DTPTgl.TabIndex = 3
        '
        'TxNama
        '
        Me.TxNama.Location = New System.Drawing.Point(62, 45)
        Me.TxNama.MaxLength = 20
        Me.TxNama.Name = "TxNama"
        Me.TxNama.Size = New System.Drawing.Size(100, 20)
        Me.TxNama.TabIndex = 2
        '
        'TxTelp
        '
        Me.TxTelp.Location = New System.Drawing.Point(62, 152)
        Me.TxTelp.MaxLength = 20
        Me.TxTelp.Name = "TxTelp"
        Me.TxTelp.Size = New System.Drawing.Size(100, 20)
        Me.TxTelp.TabIndex = 5
        '
        'TxAlamat
        '
        Me.TxAlamat.Location = New System.Drawing.Point(62, 98)
        Me.TxAlamat.MaxLength = 20
        Me.TxAlamat.Multiline = True
        Me.TxAlamat.Name = "TxAlamat"
        Me.TxAlamat.Size = New System.Drawing.Size(100, 48)
        Me.TxAlamat.TabIndex = 4
        '
        'TxIdKry
        '
        Me.TxIdKry.Location = New System.Drawing.Point(62, 19)
        Me.TxIdKry.MaxLength = 5
        Me.TxIdKry.Name = "TxIdKry"
        Me.TxIdKry.Size = New System.Drawing.Size(100, 20)
        Me.TxIdKry.TabIndex = 1
        '
        'btSimpan
        '
        Me.btSimpan.Location = New System.Drawing.Point(31, 221)
        Me.btSimpan.Name = "btSimpan"
        Me.btSimpan.Size = New System.Drawing.Size(60, 23)
        Me.btSimpan.TabIndex = 7
        Me.btSimpan.Text = "Simpan"
        Me.btSimpan.UseVisualStyleBackColor = True
        '
        'btHapus
        '
        Me.btHapus.Location = New System.Drawing.Point(92, 221)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(24, 23)
        Me.btHapus.TabIndex = 8
        Me.btHapus.Text = "-"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btTambah
        '
        Me.btTambah.Location = New System.Drawing.Point(6, 221)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(24, 23)
        Me.btTambah.TabIndex = 6
        Me.btTambah.Text = "+"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LV)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(255, 265)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Karyawan"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(6, 6)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(237, 204)
        Me.LV.TabIndex = 0
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OFDialog"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusFotoToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 26)
        '
        'HapusFotoToolStripMenuItem
        '
        Me.HapusFotoToolStripMenuItem.Name = "HapusFotoToolStripMenuItem"
        Me.HapusFotoToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.HapusFotoToolStripMenuItem.Text = "Hapus foto"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 315)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Karyawan"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPTgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxNama As System.Windows.Forms.TextBox
    Friend WithEvents TxTelp As System.Windows.Forms.TextBox
    Friend WithEvents TxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents TxIdKry As System.Windows.Forms.TextBox
    Friend WithEvents PBox As System.Windows.Forms.PictureBox
    Friend WithEvents btSimpan As System.Windows.Forms.Button
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TxFile As System.Windows.Forms.TextBox
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents TxFileTemp As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusFotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CbJabatan As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
