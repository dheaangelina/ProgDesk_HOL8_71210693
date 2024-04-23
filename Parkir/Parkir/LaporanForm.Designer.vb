<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanForm
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
        Me.btnTutup = New System.Windows.Forms.Button()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblLaporan = New System.Windows.Forms.Label()
        Me.lblPeriode = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(699, 497)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(93, 35)
        Me.btnTutup.TabIndex = 10
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(468, 19)
        Me.btnTampilkan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(112, 35)
        Me.btnTampilkan.TabIndex = 11
        Me.btnTampilkan.Text = "Tampilkan !"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(28, 111)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView1.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(294, 22)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 26)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.Text = "Masukan Tahun"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Bulan"})
        Me.ComboBox1.Location = New System.Drawing.Point(117, 22)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 28)
        Me.ComboBox1.TabIndex = 7
        '
        'lblLaporan
        '
        Me.lblLaporan.AutoSize = True
        Me.lblLaporan.Location = New System.Drawing.Point(24, 73)
        Me.lblLaporan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLaporan.Name = "lblLaporan"
        Me.lblLaporan.Size = New System.Drawing.Size(76, 20)
        Me.lblLaporan.TabIndex = 5
        Me.lblLaporan.Text = "Laporan :"
        '
        'lblPeriode
        '
        Me.lblPeriode.AutoSize = True
        Me.lblPeriode.Location = New System.Drawing.Point(24, 26)
        Me.lblPeriode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPeriode.Name = "lblPeriode"
        Me.lblPeriode.Size = New System.Drawing.Size(63, 20)
        Me.lblPeriode.TabIndex = 6
        Me.lblPeriode.Text = "Periode"
        '
        'LaporanForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(829, 558)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lblLaporan)
        Me.Controls.Add(Me.lblPeriode)
        Me.Name = "LaporanForm"
        Me.Text = "SIParkir - Laporan Pendapatan Parkir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTutup As Button
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lblLaporan As Label
    Friend WithEvents lblPeriode As Label
End Class
