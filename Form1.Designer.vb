<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.GB_Data_User = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_Pekerjaan = New System.Windows.Forms.TextBox()
        Me.TXT_Status = New System.Windows.Forms.TextBox()
        Me.TXT_Nama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_Reset = New System.Windows.Forms.Button()
        Me.BTN_Cek_Zodiak = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMB_Tahun = New System.Windows.Forms.ComboBox()
        Me.CMB_Bulan = New System.Windows.Forms.ComboBox()
        Me.CMB_Tanggal = New System.Windows.Forms.ComboBox()
        Me.GB_Zodiak = New System.Windows.Forms.GroupBox()
        Me.LBL_Pekerjaan = New System.Windows.Forms.Label()
        Me.LBL_Status = New System.Windows.Forms.Label()
        Me.LBL_Nama = New System.Windows.Forms.Label()
        Me.TXT_Emosi = New System.Windows.Forms.TextBox()
        Me.TXT_Hubungan = New System.Windows.Forms.TextBox()
        Me.TXT_Sifat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PB_Zodiak = New System.Windows.Forms.PictureBox()
        Me.GB_Data_User.SuspendLayout()
        Me.GB_Zodiak.SuspendLayout()
        CType(Me.PB_Zodiak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GB_Data_User
        '
        Me.GB_Data_User.Controls.Add(Me.Label4)
        Me.GB_Data_User.Controls.Add(Me.TXT_Pekerjaan)
        Me.GB_Data_User.Controls.Add(Me.TXT_Status)
        Me.GB_Data_User.Controls.Add(Me.TXT_Nama)
        Me.GB_Data_User.Controls.Add(Me.Label3)
        Me.GB_Data_User.Controls.Add(Me.Label2)
        Me.GB_Data_User.Controls.Add(Me.BTN_Reset)
        Me.GB_Data_User.Controls.Add(Me.BTN_Cek_Zodiak)
        Me.GB_Data_User.Controls.Add(Me.Label1)
        Me.GB_Data_User.Controls.Add(Me.CMB_Tahun)
        Me.GB_Data_User.Controls.Add(Me.CMB_Bulan)
        Me.GB_Data_User.Controls.Add(Me.CMB_Tanggal)
        Me.GB_Data_User.Location = New System.Drawing.Point(12, 12)
        Me.GB_Data_User.Name = "GB_Data_User"
        Me.GB_Data_User.Size = New System.Drawing.Size(396, 426)
        Me.GB_Data_User.TabIndex = 0
        Me.GB_Data_User.TabStop = False
        Me.GB_Data_User.Text = "Data User"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pekerjaan"
        '
        'TXT_Pekerjaan
        '
        Me.TXT_Pekerjaan.Location = New System.Drawing.Point(71, 83)
        Me.TXT_Pekerjaan.Name = "TXT_Pekerjaan"
        Me.TXT_Pekerjaan.Size = New System.Drawing.Size(310, 23)
        Me.TXT_Pekerjaan.TabIndex = 4
        '
        'TXT_Status
        '
        Me.TXT_Status.Location = New System.Drawing.Point(71, 55)
        Me.TXT_Status.Name = "TXT_Status"
        Me.TXT_Status.Size = New System.Drawing.Size(310, 23)
        Me.TXT_Status.TabIndex = 4
        '
        'TXT_Nama
        '
        Me.TXT_Nama.Location = New System.Drawing.Point(71, 23)
        Me.TXT_Nama.Name = "TXT_Nama"
        Me.TXT_Nama.Size = New System.Drawing.Size(310, 23)
        Me.TXT_Nama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'BTN_Reset
        '
        Me.BTN_Reset.Location = New System.Drawing.Point(204, 156)
        Me.BTN_Reset.Name = "BTN_Reset"
        Me.BTN_Reset.Size = New System.Drawing.Size(186, 23)
        Me.BTN_Reset.TabIndex = 2
        Me.BTN_Reset.Text = "Reset"
        Me.BTN_Reset.UseVisualStyleBackColor = True
        '
        'BTN_Cek_Zodiak
        '
        Me.BTN_Cek_Zodiak.Location = New System.Drawing.Point(6, 156)
        Me.BTN_Cek_Zodiak.Name = "BTN_Cek_Zodiak"
        Me.BTN_Cek_Zodiak.Size = New System.Drawing.Size(185, 23)
        Me.BTN_Cek_Zodiak.TabIndex = 2
        Me.BTN_Cek_Zodiak.Text = "Cek Zodiac"
        Me.BTN_Cek_Zodiak.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Silahkan masukan tanggal kelahiran!"
        '
        'CMB_Tahun
        '
        Me.CMB_Tahun.FormattingEnabled = True
        Me.CMB_Tahun.Location = New System.Drawing.Point(260, 127)
        Me.CMB_Tahun.Name = "CMB_Tahun"
        Me.CMB_Tahun.Size = New System.Drawing.Size(121, 23)
        Me.CMB_Tahun.TabIndex = 0
        Me.CMB_Tahun.Text = "Tahun"
        '
        'CMB_Bulan
        '
        Me.CMB_Bulan.FormattingEnabled = True
        Me.CMB_Bulan.Location = New System.Drawing.Point(134, 127)
        Me.CMB_Bulan.Name = "CMB_Bulan"
        Me.CMB_Bulan.Size = New System.Drawing.Size(121, 23)
        Me.CMB_Bulan.TabIndex = 0
        Me.CMB_Bulan.Text = "Bulan"
        '
        'CMB_Tanggal
        '
        Me.CMB_Tanggal.FormattingEnabled = True
        Me.CMB_Tanggal.Location = New System.Drawing.Point(7, 127)
        Me.CMB_Tanggal.Name = "CMB_Tanggal"
        Me.CMB_Tanggal.Size = New System.Drawing.Size(121, 23)
        Me.CMB_Tanggal.TabIndex = 0
        Me.CMB_Tanggal.Text = "Tanggal"
        '
        'GB_Zodiak
        '
        Me.GB_Zodiak.Controls.Add(Me.LBL_Pekerjaan)
        Me.GB_Zodiak.Controls.Add(Me.LBL_Status)
        Me.GB_Zodiak.Controls.Add(Me.LBL_Nama)
        Me.GB_Zodiak.Controls.Add(Me.TXT_Emosi)
        Me.GB_Zodiak.Controls.Add(Me.TXT_Hubungan)
        Me.GB_Zodiak.Controls.Add(Me.TXT_Sifat)
        Me.GB_Zodiak.Controls.Add(Me.Label7)
        Me.GB_Zodiak.Controls.Add(Me.Label6)
        Me.GB_Zodiak.Controls.Add(Me.Label5)
        Me.GB_Zodiak.Controls.Add(Me.PB_Zodiak)
        Me.GB_Zodiak.Location = New System.Drawing.Point(414, 12)
        Me.GB_Zodiak.Name = "GB_Zodiak"
        Me.GB_Zodiak.Size = New System.Drawing.Size(396, 426)
        Me.GB_Zodiak.TabIndex = 0
        Me.GB_Zodiak.TabStop = False
        Me.GB_Zodiak.Text = "Zodiak"
        '
        'LBL_Pekerjaan
        '
        Me.LBL_Pekerjaan.AutoSize = True
        Me.LBL_Pekerjaan.Location = New System.Drawing.Point(220, 86)
        Me.LBL_Pekerjaan.Name = "LBL_Pekerjaan"
        Me.LBL_Pekerjaan.Size = New System.Drawing.Size(103, 15)
        Me.LBL_Pekerjaan.TabIndex = 5
        Me.LBL_Pekerjaan.Text = "9882405120111014"
        '
        'LBL_Status
        '
        Me.LBL_Status.AutoSize = True
        Me.LBL_Status.Location = New System.Drawing.Point(220, 55)
        Me.LBL_Status.Name = "LBL_Status"
        Me.LBL_Status.Size = New System.Drawing.Size(138, 15)
        Me.LBL_Status.TabIndex = 5
        Me.LBL_Status.Text = "Habib Fauzan Mahardika"
        '
        'LBL_Nama
        '
        Me.LBL_Nama.AutoSize = True
        Me.LBL_Nama.Location = New System.Drawing.Point(220, 23)
        Me.LBL_Nama.Name = "LBL_Nama"
        Me.LBL_Nama.Size = New System.Drawing.Size(26, 15)
        Me.LBL_Nama.TabIndex = 5
        Me.LBL_Nama.Text = "By :"
        '
        'TXT_Emosi
        '
        Me.TXT_Emosi.Location = New System.Drawing.Point(6, 349)
        Me.TXT_Emosi.Multiline = True
        Me.TXT_Emosi.Name = "TXT_Emosi"
        Me.TXT_Emosi.ReadOnly = True
        Me.TXT_Emosi.Size = New System.Drawing.Size(383, 71)
        Me.TXT_Emosi.TabIndex = 4
        '
        'TXT_Hubungan
        '
        Me.TXT_Hubungan.Location = New System.Drawing.Point(6, 250)
        Me.TXT_Hubungan.Multiline = True
        Me.TXT_Hubungan.Name = "TXT_Hubungan"
        Me.TXT_Hubungan.ReadOnly = True
        Me.TXT_Hubungan.Size = New System.Drawing.Size(383, 67)
        Me.TXT_Hubungan.TabIndex = 4
        '
        'TXT_Sifat
        '
        Me.TXT_Sifat.Location = New System.Drawing.Point(7, 194)
        Me.TXT_Sifat.Multiline = True
        Me.TXT_Sifat.Name = "TXT_Sifat"
        Me.TXT_Sifat.ReadOnly = True
        Me.TXT_Sifat.Size = New System.Drawing.Size(383, 23)
        Me.TXT_Sifat.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Saat emosi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Hubungan yang diingkan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Sifat"
        '
        'PB_Zodiak
        '
        Me.PB_Zodiak.Location = New System.Drawing.Point(6, 23)
        Me.PB_Zodiak.Name = "PB_Zodiak"
        Me.PB_Zodiak.Size = New System.Drawing.Size(207, 146)
        Me.PB_Zodiak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB_Zodiak.TabIndex = 0
        Me.PB_Zodiak.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 450)
        Me.Controls.Add(Me.GB_Zodiak)
        Me.Controls.Add(Me.GB_Data_User)
        Me.Name = "Form1"
        Me.Text = "Ramalan Zodiak"
        Me.GB_Data_User.ResumeLayout(False)
        Me.GB_Data_User.PerformLayout()
        Me.GB_Zodiak.ResumeLayout(False)
        Me.GB_Zodiak.PerformLayout()
        CType(Me.PB_Zodiak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GB_Data_User As GroupBox
    Friend WithEvents CMB_Tahun As ComboBox
    Friend WithEvents CMB_Bulan As ComboBox
    Friend WithEvents CMB_Tanggal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_Nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTN_Reset As Button
    Friend WithEvents BTN_Cek_Zodiak As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_Pekerjaan As TextBox
    Friend WithEvents TXT_Status As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GB_Zodiak As GroupBox
    Friend WithEvents PB_Zodiak As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_Emosi As TextBox
    Friend WithEvents TXT_Hubungan As TextBox
    Friend WithEvents TXT_Sifat As TextBox
    Friend WithEvents LBL_Pekerjaan As Label
    Friend WithEvents LBL_Status As Label
    Friend WithEvents LBL_Nama As Label
End Class
