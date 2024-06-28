<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAkses
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.btnLock = New FontAwesome.Sharp.IconButton()
        Me.btnAktifasi = New System.Windows.Forms.Button()
        Me.chkUnAktif = New System.Windows.Forms.CheckBox()
        Me.chkAktif = New System.Windows.Forms.CheckBox()
        Me.chkAddUser = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkAddUser)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.btnLock)
        Me.GroupBox1.Controls.Add(Me.btnAktifasi)
        Me.GroupBox1.Controls.Add(Me.chkUnAktif)
        Me.GroupBox1.Controls.Add(Me.chkAktif)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(329, 393)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Aktifasi Stok Take Period "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Input Password"
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(60, 73)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(217, 26)
        Me.txtpass.TabIndex = 4
        '
        'btnLock
        '
        Me.btnLock.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnLock.IconColor = System.Drawing.Color.Black
        Me.btnLock.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLock.Location = New System.Drawing.Point(60, 105)
        Me.btnLock.Name = "btnLock"
        Me.btnLock.Size = New System.Drawing.Size(217, 44)
        Me.btnLock.TabIndex = 3
        Me.btnLock.Text = "Unlock"
        Me.btnLock.UseVisualStyleBackColor = True
        '
        'btnAktifasi
        '
        Me.btnAktifasi.Enabled = False
        Me.btnAktifasi.Location = New System.Drawing.Point(60, 304)
        Me.btnAktifasi.Name = "btnAktifasi"
        Me.btnAktifasi.Size = New System.Drawing.Size(217, 54)
        Me.btnAktifasi.TabIndex = 2
        Me.btnAktifasi.Text = "Update "
        Me.btnAktifasi.UseVisualStyleBackColor = True
        '
        'chkUnAktif
        '
        Me.chkUnAktif.AutoSize = True
        Me.chkUnAktif.Enabled = False
        Me.chkUnAktif.Location = New System.Drawing.Point(60, 238)
        Me.chkUnAktif.Name = "chkUnAktif"
        Me.chkUnAktif.Size = New System.Drawing.Size(127, 24)
        Me.chkUnAktif.TabIndex = 1
        Me.chkUnAktif.Text = "Freeze Period"
        Me.chkUnAktif.UseVisualStyleBackColor = True
        '
        'chkAktif
        '
        Me.chkAktif.AutoSize = True
        Me.chkAktif.Enabled = False
        Me.chkAktif.Location = New System.Drawing.Point(60, 208)
        Me.chkAktif.Name = "chkAktif"
        Me.chkAktif.Size = New System.Drawing.Size(109, 24)
        Me.chkAktif.TabIndex = 0
        Me.chkAktif.Text = "Aktif Period"
        Me.chkAktif.UseVisualStyleBackColor = True
        '
        'chkAddUser
        '
        Me.chkAddUser.AutoSize = True
        Me.chkAddUser.Enabled = False
        Me.chkAddUser.Location = New System.Drawing.Point(60, 268)
        Me.chkAddUser.Name = "chkAddUser"
        Me.chkAddUser.Size = New System.Drawing.Size(95, 24)
        Me.chkAddUser.TabIndex = 6
        Me.chkAddUser.Text = "Add User"
        Me.chkAddUser.UseVisualStyleBackColor = True
        '
        'FormAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(978, 527)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAkses"
        Me.Text = "FormAkses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAktifasi As Button
    Friend WithEvents chkUnAktif As CheckBox
    Friend WithEvents chkAktif As CheckBox
    Friend WithEvents btnLock As FontAwesome.Sharp.IconButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpass As TextBox
    Friend WithEvents chkAddUser As CheckBox
End Class
