<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AturProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanggananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPendapatanParkirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BantuanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlPlat = New System.Windows.Forms.Panel()
        Me.lblPlat = New System.Windows.Forms.Label()
        Me.lblInputPlat = New System.Windows.Forms.Label()
        Me.lblJenis = New System.Windows.Forms.Label()
        Me.txtPlat = New System.Windows.Forms.TextBox()
        Me.lblTekan = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.pnlHarga = New System.Windows.Forms.Panel()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblInfoJenis = New System.Windows.Forms.Label()
        Me.lblJmlKendaraan = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTgl = New System.Windows.Forms.Label()
        Me.lblInfoUser = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CoNoPlat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMasuk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColKeluar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColHarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColJenis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlGird = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlPlat.SuspendLayout()
        Me.pnlHarga.SuspendLayout()
        Me.pnlInput.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlGird.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BantuanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(708, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemToolStripMenuItem
        '
        Me.SistemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AturProfilToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.SistemToolStripMenuItem.Name = "SistemToolStripMenuItem"
        Me.SistemToolStripMenuItem.Size = New System.Drawing.Size(54, 22)
        Me.SistemToolStripMenuItem.Text = "Sistem"
        '
        'AturProfilToolStripMenuItem
        '
        Me.AturProfilToolStripMenuItem.Name = "AturProfilToolStripMenuItem"
        Me.AturProfilToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.AturProfilToolStripMenuItem.Text = "Atur Profil"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LanggananToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.LaporanPendapatanParkirToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'LanggananToolStripMenuItem
        '
        Me.LanggananToolStripMenuItem.Name = "LanggananToolStripMenuItem"
        Me.LanggananToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.LanggananToolStripMenuItem.Text = "Langganan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanPendapatanParkirToolStripMenuItem
        '
        Me.LaporanPendapatanParkirToolStripMenuItem.Name = "LaporanPendapatanParkirToolStripMenuItem"
        Me.LaporanPendapatanParkirToolStripMenuItem.Size = New System.Drawing.Size(216, 22)
        Me.LaporanPendapatanParkirToolStripMenuItem.Text = "Laporan Pendapatan Parkir"
        '
        'BantuanToolStripMenuItem
        '
        Me.BantuanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BantuanToolStripMenuItem1, Me.TentangToolStripMenuItem})
        Me.BantuanToolStripMenuItem.Name = "BantuanToolStripMenuItem"
        Me.BantuanToolStripMenuItem.Size = New System.Drawing.Size(63, 22)
        Me.BantuanToolStripMenuItem.Text = "Bantuan"
        '
        'BantuanToolStripMenuItem1
        '
        Me.BantuanToolStripMenuItem1.Name = "BantuanToolStripMenuItem1"
        Me.BantuanToolStripMenuItem1.Size = New System.Drawing.Size(118, 22)
        Me.BantuanToolStripMenuItem1.Text = "Bantuan"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'pnlPlat
        '
        Me.pnlPlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlPlat.Controls.Add(Me.lblPlat)
        Me.pnlPlat.Location = New System.Drawing.Point(8, 23)
        Me.pnlPlat.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlPlat.Name = "pnlPlat"
        Me.pnlPlat.Size = New System.Drawing.Size(689, 66)
        Me.pnlPlat.TabIndex = 1
        '
        'lblPlat
        '
        Me.lblPlat.AutoSize = True
        Me.lblPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlat.Location = New System.Drawing.Point(241, 13)
        Me.lblPlat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlat.Name = "lblPlat"
        Me.lblPlat.Size = New System.Drawing.Size(213, 39)
        Me.lblPlat.TabIndex = 0
        Me.lblPlat.Text = "AB 1506 XY"
        '
        'lblInputPlat
        '
        Me.lblInputPlat.AutoSize = True
        Me.lblInputPlat.Location = New System.Drawing.Point(4, 14)
        Me.lblInputPlat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInputPlat.Name = "lblInputPlat"
        Me.lblInputPlat.Size = New System.Drawing.Size(62, 13)
        Me.lblInputPlat.TabIndex = 2
        Me.lblInputPlat.Text = "Nomor Plat:"
        '
        'lblJenis
        '
        Me.lblJenis.AutoSize = True
        Me.lblJenis.Location = New System.Drawing.Point(5, 34)
        Me.lblJenis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJenis.Name = "lblJenis"
        Me.lblJenis.Size = New System.Drawing.Size(326, 13)
        Me.lblJenis.TabIndex = 3
        Me.lblJenis.Text = "Tekan F1 - Motor, F2 - Mobil, F3 - Taksi, F4 - Sepeda, F5 - Bis/Truk"
        Me.lblJenis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPlat
        '
        Me.txtPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlat.Location = New System.Drawing.Point(83, 10)
        Me.txtPlat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPlat.Name = "txtPlat"
        Me.txtPlat.Size = New System.Drawing.Size(139, 20)
        Me.txtPlat.TabIndex = 4
        '
        'lblTekan
        '
        Me.lblTekan.AutoSize = True
        Me.lblTekan.Location = New System.Drawing.Point(5, 53)
        Me.lblTekan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTekan.Name = "lblTekan"
        Me.lblTekan.Size = New System.Drawing.Size(172, 13)
        Me.lblTekan.TabIndex = 5
        Me.lblTekan.Text = "Tekan Enter untuk Masuk / Keluar"
        Me.lblTekan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarga.Location = New System.Drawing.Point(5, 8)
        Me.lblHarga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(65, 36)
        Me.lblHarga.TabIndex = 6
        Me.lblHarga.Text = "Rp."
        Me.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlHarga
        '
        Me.pnlHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHarga.Controls.Add(Me.lblHarga)
        Me.pnlHarga.Location = New System.Drawing.Point(8, 92)
        Me.pnlHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlHarga.Name = "pnlHarga"
        Me.pnlHarga.Size = New System.Drawing.Size(350, 56)
        Me.pnlHarga.TabIndex = 2
        '
        'pnlInput
        '
        Me.pnlInput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlInput.Controls.Add(Me.lblInfoJenis)
        Me.pnlInput.Controls.Add(Me.lblJenis)
        Me.pnlInput.Controls.Add(Me.lblInputPlat)
        Me.pnlInput.Controls.Add(Me.lblTekan)
        Me.pnlInput.Controls.Add(Me.txtPlat)
        Me.pnlInput.Location = New System.Drawing.Point(8, 151)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(350, 81)
        Me.pnlInput.TabIndex = 8
        '
        'lblInfoJenis
        '
        Me.lblInfoJenis.AutoSize = True
        Me.lblInfoJenis.Location = New System.Drawing.Point(225, 14)
        Me.lblInfoJenis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoJenis.Name = "lblInfoJenis"
        Me.lblInfoJenis.Size = New System.Drawing.Size(0, 13)
        Me.lblInfoJenis.TabIndex = 12
        Me.lblInfoJenis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblJmlKendaraan
        '
        Me.lblJmlKendaraan.AutoSize = True
        Me.lblJmlKendaraan.Location = New System.Drawing.Point(8, 283)
        Me.lblJmlKendaraan.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblJmlKendaraan.Name = "lblJmlKendaraan"
        Me.lblJmlKendaraan.Size = New System.Drawing.Size(210, 13)
        Me.lblJmlKendaraan.TabIndex = 10
        Me.lblJmlKendaraan.Text = "0 Motor, 0 Mobil, 0 Taksi, 0 Spd, 0 Bis/truk"
        Me.lblJmlKendaraan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(303, 311)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTgl
        '
        Me.lblTgl.AutoSize = True
        Me.lblTgl.Location = New System.Drawing.Point(8, 267)
        Me.lblTgl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTgl.Name = "lblTgl"
        Me.lblTgl.Size = New System.Drawing.Size(52, 13)
        Me.lblTgl.TabIndex = 8
        Me.lblTgl.Text = "Tanggal: "
        Me.lblTgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblInfoUser
        '
        Me.lblInfoUser.AutoSize = True
        Me.lblInfoUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoUser.Location = New System.Drawing.Point(8, 242)
        Me.lblInfoUser.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInfoUser.Name = "lblInfoUser"
        Me.lblInfoUser.Size = New System.Drawing.Size(66, 13)
        Me.lblInfoUser.TabIndex = 8
        Me.lblInfoUser.Text = "Informasi -"
        Me.lblInfoUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CoNoPlat, Me.ColMasuk, Me.ColKeluar, Me.ColHarga, Me.ColJenis, Me.id})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(335, 220)
        Me.DataGridView1.TabIndex = 9
        '
        'CoNoPlat
        '
        Me.CoNoPlat.HeaderText = "No Plat"
        Me.CoNoPlat.MinimumWidth = 8
        Me.CoNoPlat.Name = "CoNoPlat"
        Me.CoNoPlat.Width = 150
        '
        'ColMasuk
        '
        Me.ColMasuk.HeaderText = "Masuk"
        Me.ColMasuk.MinimumWidth = 8
        Me.ColMasuk.Name = "ColMasuk"
        Me.ColMasuk.Width = 150
        '
        'ColKeluar
        '
        Me.ColKeluar.HeaderText = "Keluar"
        Me.ColKeluar.MinimumWidth = 8
        Me.ColKeluar.Name = "ColKeluar"
        Me.ColKeluar.Width = 150
        '
        'ColHarga
        '
        Me.ColHarga.HeaderText = "Harga"
        Me.ColHarga.MinimumWidth = 8
        Me.ColHarga.Name = "ColHarga"
        Me.ColHarga.Width = 150
        '
        'ColJenis
        '
        Me.ColJenis.HeaderText = "Jenis"
        Me.ColJenis.MinimumWidth = 8
        Me.ColJenis.Name = "ColJenis"
        Me.ColJenis.Width = 150
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.MinimumWidth = 8
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 150
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 26)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'pnlGird
        '
        Me.pnlGird.AutoScroll = True
        Me.pnlGird.Controls.Add(Me.DataGridView1)
        Me.pnlGird.Location = New System.Drawing.Point(361, 92)
        Me.pnlGird.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlGird.Name = "pnlGird"
        Me.pnlGird.Size = New System.Drawing.Size(335, 220)
        Me.pnlGird.TabIndex = 11
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(708, 322)
        Me.Controls.Add(Me.pnlGird)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblJmlKendaraan)
        Me.Controls.Add(Me.lblTgl)
        Me.Controls.Add(Me.lblInfoUser)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.pnlHarga)
        Me.Controls.Add(Me.pnlPlat)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormUtama"
        Me.Text = "SIParkir - Form Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlPlat.ResumeLayout(False)
        Me.pnlPlat.PerformLayout()
        Me.pnlHarga.ResumeLayout(False)
        Me.pnlHarga.PerformLayout()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlInput.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlGird.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AturProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LanggananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BantuanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlPlat As Panel
    Friend WithEvents lblPlat As Label
    Friend WithEvents lblInputPlat As Label
    Friend WithEvents lblJenis As Label
    Friend WithEvents txtPlat As TextBox
    Friend WithEvents lblTekan As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents pnlHarga As Panel
    Friend WithEvents lblInfoUser As Label
    Friend WithEvents pnlInput As Panel
    Friend WithEvents lblJmlKendaraan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlGird As Panel
    Friend WithEvents lblInfoJenis As Label
    Friend WithEvents CoNoPlat As DataGridViewTextBoxColumn
    Friend WithEvents ColMasuk As DataGridViewTextBoxColumn
    Friend WithEvents ColKeluar As DataGridViewTextBoxColumn
    Friend WithEvents ColHarga As DataGridViewTextBoxColumn
    Friend WithEvents ColJenis As DataGridViewTextBoxColumn
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents LaporanPendapatanParkirToolStripMenuItem As ToolStripMenuItem
End Class
