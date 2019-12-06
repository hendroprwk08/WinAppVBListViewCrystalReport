<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCari
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
        Me.TxCari = New System.Windows.Forms.TextBox()
        Me.BtCari = New System.Windows.Forms.Button()
        Me.LV = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'TxCari
        '
        Me.TxCari.Location = New System.Drawing.Point(12, 12)
        Me.TxCari.Name = "TxCari"
        Me.TxCari.Size = New System.Drawing.Size(219, 20)
        Me.TxCari.TabIndex = 0
        '
        'BtCari
        '
        Me.BtCari.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.BtCari.Location = New System.Drawing.Point(237, 8)
        Me.BtCari.Name = "BtCari"
        Me.BtCari.Size = New System.Drawing.Size(35, 23)
        Me.BtCari.TabIndex = 1
        Me.BtCari.Text = "Cari"
        Me.BtCari.UseVisualStyleBackColor = True
        '
        'LV
        '
        Me.LV.FullRowSelect = True
        Me.LV.GridLines = True
        Me.LV.Location = New System.Drawing.Point(13, 42)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(258, 206)
        Me.LV.TabIndex = 2
        Me.LV.UseCompatibleStateImageBehavior = False
        Me.LV.View = System.Windows.Forms.View.Details
        '
        'FCari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.BtCari)
        Me.Controls.Add(Me.TxCari)
        Me.Name = "FCari"
        Me.Text = "FCari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxCari As System.Windows.Forms.TextBox
    Friend WithEvents BtCari As System.Windows.Forms.Button
    Friend WithEvents LV As System.Windows.Forms.ListView
End Class
