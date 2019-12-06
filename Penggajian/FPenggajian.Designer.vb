<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPenggajian
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
        Me.LbIDGaji = New System.Windows.Forms.Label()
        Me.DTPTanggal = New System.Windows.Forms.DateTimePicker()
        Me.TxTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LV = New System.Windows.Forms.ListView()
        Me.CbIDKaryawan = New System.Windows.Forms.ComboBox()
        Me.TxNama = New System.Windows.Forms.TextBox()
        Me.TxIDJabatan = New System.Windows.Forms.TextBox()
        Me.TxGajiPokok = New System.Windows.Forms.TextBox()
        Me.TxTunjKesehatan = New System.Windows.Forms.TextBox()
        Me.TxTunjAnak = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtTambah = New System.Windows.Forms.Button()
        Me.TxNominal = New System.Windows.Forms.TextBox()
        Me.TxExtra = New System.Windows.Forms.TextBox()
        Me.TxJumlah = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CariToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HapusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbIDGaji
        '
        Me.LbIDGaji.AutoSize = True
        Me.LbIDGaji.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbIDGaji.Location = New System.Drawing.Point(4, 43)
        Me.LbIDGaji.Name = "LbIDGaji"
        Me.LbIDGaji.Size = New System.Drawing.Size(71, 25)
        Me.LbIDGaji.TabIndex = 0
        Me.LbIDGaji.Text = "Label1"
        '
        'DTPTanggal
        '
        Me.DTPTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPTanggal.Location = New System.Drawing.Point(357, 43)
        Me.DTPTanggal.Name = "DTPTanggal"
        Me.DTPTanggal.Size = New System.Drawing.Size(96, 20)
        Me.DTPTanggal.TabIndex = 1
        '
        'TxTotal
        '
        Me.TxTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTotal.Location = New System.Drawing.Point(466, 136)
        Me.TxTotal.Name = "TxTotal"
        Me.TxTotal.Size = New System.Drawing.Size(96, 20)
        Me.TxTotal.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(531, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total"
        '
        'LV
        '
        Me.LV.Location = New System.Drawing.Point(9, 171)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(553, 145)
        Me.LV.TabIndex = 4
        Me.LV.UseCompatibleStateImageBehavior = False
        '
        'CbIDKaryawan
        '
        Me.CbIDKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CbIDKaryawan.FormattingEnabled = True
        Me.CbIDKaryawan.Location = New System.Drawing.Point(9, 88)
        Me.CbIDKaryawan.Name = "CbIDKaryawan"
        Me.CbIDKaryawan.Size = New System.Drawing.Size(60, 21)
        Me.CbIDKaryawan.TabIndex = 5
        '
        'TxNama
        '
        Me.TxNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxNama.Location = New System.Drawing.Point(72, 89)
        Me.TxNama.Name = "TxNama"
        Me.TxNama.Size = New System.Drawing.Size(109, 20)
        Me.TxNama.TabIndex = 6
        '
        'TxIDJabatan
        '
        Me.TxIDJabatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxIDJabatan.Location = New System.Drawing.Point(183, 89)
        Me.TxIDJabatan.Name = "TxIDJabatan"
        Me.TxIDJabatan.Size = New System.Drawing.Size(66, 20)
        Me.TxIDJabatan.TabIndex = 7
        '
        'TxGajiPokok
        '
        Me.TxGajiPokok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxGajiPokok.Location = New System.Drawing.Point(251, 89)
        Me.TxGajiPokok.Name = "TxGajiPokok"
        Me.TxGajiPokok.Size = New System.Drawing.Size(66, 20)
        Me.TxGajiPokok.TabIndex = 8
        '
        'TxTunjKesehatan
        '
        Me.TxTunjKesehatan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTunjKesehatan.Location = New System.Drawing.Point(319, 89)
        Me.TxTunjKesehatan.Name = "TxTunjKesehatan"
        Me.TxTunjKesehatan.Size = New System.Drawing.Size(66, 20)
        Me.TxTunjKesehatan.TabIndex = 9
        '
        'TxTunjAnak
        '
        Me.TxTunjAnak.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxTunjAnak.Location = New System.Drawing.Point(387, 89)
        Me.TxTunjAnak.Name = "TxTunjAnak"
        Me.TxTunjAnak.Size = New System.Drawing.Size(66, 20)
        Me.TxTunjAnak.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtTambah)
        Me.GroupBox1.Controls.Add(Me.TxNominal)
        Me.GroupBox1.Controls.Add(Me.TxExtra)
        Me.GroupBox1.Controls.Add(Me.TxJumlah)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 48)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Extra Pay"
        '
        'BtTambah
        '
        Me.BtTambah.Location = New System.Drawing.Point(343, 16)
        Me.BtTambah.Name = "BtTambah"
        Me.BtTambah.Size = New System.Drawing.Size(21, 22)
        Me.BtTambah.TabIndex = 18
        Me.BtTambah.Text = "+"
        Me.BtTambah.UseVisualStyleBackColor = True
        '
        'TxNominal
        '
        Me.TxNominal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxNominal.Location = New System.Drawing.Point(179, 18)
        Me.TxNominal.Name = "TxNominal"
        Me.TxNominal.Size = New System.Drawing.Size(80, 20)
        Me.TxNominal.TabIndex = 17
        '
        'TxExtra
        '
        Me.TxExtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxExtra.Location = New System.Drawing.Point(8, 18)
        Me.TxExtra.Name = "TxExtra"
        Me.TxExtra.Size = New System.Drawing.Size(164, 20)
        Me.TxExtra.TabIndex = 16
        '
        'TxJumlah
        '
        Me.TxJumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxJumlah.Location = New System.Drawing.Point(261, 18)
        Me.TxJumlah.Name = "TxJumlah"
        Me.TxJumlah.Size = New System.Drawing.Size(80, 20)
        Me.TxJumlah.TabIndex = 15
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HapusToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(109, 26)
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'SimpanToolStripMenuItem
        '
        Me.SimpanToolStripMenuItem.Name = "SimpanToolStripMenuItem"
        Me.SimpanToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.SimpanToolStripMenuItem.Text = "Tambah"
        '
        'CariToolStripMenuItem
        '
        Me.CariToolStripMenuItem.Name = "CariToolStripMenuItem"
        Me.CariToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.CariToolStripMenuItem.Text = "Simpan"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 23)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpanToolStripMenuItem, Me.CariToolStripMenuItem, Me.ToolStripComboBox1, Me.HapusToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(574, 27)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HapusToolStripMenuItem1
        '
        Me.HapusToolStripMenuItem1.Name = "HapusToolStripMenuItem1"
        Me.HapusToolStripMenuItem1.Size = New System.Drawing.Size(53, 23)
        Me.HapusToolStripMenuItem1.Text = "Hapus"
        '
        'FPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(574, 330)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxTunjAnak)
        Me.Controls.Add(Me.TxTunjKesehatan)
        Me.Controls.Add(Me.TxGajiPokok)
        Me.Controls.Add(Me.TxIDJabatan)
        Me.Controls.Add(Me.TxNama)
        Me.Controls.Add(Me.CbIDKaryawan)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxTotal)
        Me.Controls.Add(Me.DTPTanggal)
        Me.Controls.Add(Me.LbIDGaji)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FPenggajian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penggajian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbIDGaji As System.Windows.Forms.Label
    Friend WithEvents DTPTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LV As System.Windows.Forms.ListView
    Friend WithEvents CbIDKaryawan As System.Windows.Forms.ComboBox
    Friend WithEvents TxNama As System.Windows.Forms.TextBox
    Friend WithEvents TxIDJabatan As System.Windows.Forms.TextBox
    Friend WithEvents TxGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents TxTunjKesehatan As System.Windows.Forms.TextBox
    Friend WithEvents TxTunjAnak As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxNominal As System.Windows.Forms.TextBox
    Friend WithEvents TxExtra As System.Windows.Forms.TextBox
    Friend WithEvents TxJumlah As System.Windows.Forms.TextBox
    Friend WithEvents BtTambah As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimpanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CariToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HapusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
