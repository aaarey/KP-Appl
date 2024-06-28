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
        Me.PenelTOP = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSide = New System.Windows.Forms.Panel()
        Me.btnLogin = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTgl = New System.Windows.Forms.Label()
        Me.LblTitik = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.btnUser = New FontAwesome.Sharp.IconButton()
        Me.btnExport = New FontAwesome.Sharp.IconButton()
        Me.btnLog = New FontAwesome.Sharp.IconButton()
        Me.btnEdit = New FontAwesome.Sharp.IconButton()
        Me.btnInput = New FontAwesome.Sharp.IconButton()
        Me.BtnDashboard = New FontAwesome.Sharp.IconButton()
        Me.PanelLine = New System.Windows.Forms.Panel()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PenelTOP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSide.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PenelTOP
        '
        Me.PenelTOP.BackColor = System.Drawing.Color.Black
        Me.PenelTOP.Controls.Add(Me.PictureBox1)
        Me.PenelTOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.PenelTOP.Location = New System.Drawing.Point(0, 0)
        Me.PenelTOP.Name = "PenelTOP"
        Me.PenelTOP.Size = New System.Drawing.Size(1464, 73)
        Me.PenelTOP.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.KP2023.My.Resources.Resources.MicrosoftTeams_image__1_
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(275, 43)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelSide
        '
        Me.PanelSide.BackColor = System.Drawing.Color.Black
        Me.PanelSide.Controls.Add(Me.btnLogin)
        Me.PanelSide.Controls.Add(Me.Panel1)
        Me.PanelSide.Controls.Add(Me.IconButton1)
        Me.PanelSide.Controls.Add(Me.btnUser)
        Me.PanelSide.Controls.Add(Me.btnExport)
        Me.PanelSide.Controls.Add(Me.btnLog)
        Me.PanelSide.Controls.Add(Me.btnEdit)
        Me.PanelSide.Controls.Add(Me.btnInput)
        Me.PanelSide.Controls.Add(Me.BtnDashboard)
        Me.PanelSide.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSide.Location = New System.Drawing.Point(0, 73)
        Me.PanelSide.Name = "PanelSide"
        Me.PanelSide.Size = New System.Drawing.Size(204, 602)
        Me.PanelSide.TabIndex = 1
        '
        'btnLogin
        '
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.IconChar = FontAwesome.Sharp.IconChar.LockOpen
        Me.btnLogin.IconColor = System.Drawing.Color.White
        Me.btnLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLogin.IconSize = 40
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(0, 300)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(204, 50)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblTgl)
        Me.Panel1.Controls.Add(Me.LblTitik)
        Me.Panel1.Controls.Add(Me.lblTime)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 415)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(204, 123)
        Me.Panel1.TabIndex = 7
        '
        'LblTgl
        '
        Me.LblTgl.AutoSize = True
        Me.LblTgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTgl.ForeColor = System.Drawing.Color.White
        Me.LblTgl.Location = New System.Drawing.Point(15, 73)
        Me.LblTgl.Name = "LblTgl"
        Me.LblTgl.Size = New System.Drawing.Size(186, 32)
        Me.LblTgl.TabIndex = 3
        Me.LblTgl.Text = "dd MMM yyyy"
        '
        'LblTitik
        '
        Me.LblTitik.AutoSize = True
        Me.LblTitik.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitik.ForeColor = System.Drawing.Color.Lime
        Me.LblTitik.Location = New System.Drawing.Point(79, 10)
        Me.LblTitik.Name = "LblTitik"
        Me.LblTitik.Size = New System.Drawing.Size(43, 63)
        Me.LblTitik.TabIndex = 2
        Me.LblTitik.Text = ":"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.Lime
        Me.lblTime.Location = New System.Drawing.Point(4, 10)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(196, 63)
        Me.lblTime.TabIndex = 0
        Me.lblTime.Text = "00   00"
        '
        'IconButton1
        '
        Me.IconButton1.BackColor = System.Drawing.Color.DarkRed
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconButton1.ForeColor = System.Drawing.Color.White
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.PowerOff
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.IconSize = 40
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 538)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Size = New System.Drawing.Size(204, 64)
        Me.IconButton1.TabIndex = 6
        Me.IconButton1.Text = "Log Off"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserEdit
        Me.btnUser.IconColor = System.Drawing.Color.White
        Me.btnUser.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnUser.IconSize = 40
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.Location = New System.Drawing.Point(0, 250)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(204, 50)
        Me.btnUser.TabIndex = 5
        Me.btnUser.Text = "Tambah Anggota"
        Me.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.IconChar = FontAwesome.Sharp.IconChar.Download
        Me.btnExport.IconColor = System.Drawing.Color.White
        Me.btnExport.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExport.IconSize = 40
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.Location = New System.Drawing.Point(0, 200)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(204, 50)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Unduh Data"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLog.FlatAppearance.BorderSize = 0
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btnLog.IconColor = System.Drawing.Color.White
        Me.btnLog.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnLog.IconSize = 40
        Me.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLog.Location = New System.Drawing.Point(0, 150)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(204, 50)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "Pencarian Data"
        Me.btnLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilRuler
        Me.btnEdit.IconColor = System.Drawing.Color.White
        Me.btnEdit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnEdit.IconSize = 40
        Me.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Location = New System.Drawing.Point(0, 100)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(204, 50)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit Data"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInput.FlatAppearance.BorderSize = 0
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.Color.White
        Me.btnInput.IconChar = FontAwesome.Sharp.IconChar.PenToSquare
        Me.btnInput.IconColor = System.Drawing.Color.White
        Me.btnInput.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInput.IconSize = 40
        Me.btnInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInput.Location = New System.Drawing.Point(0, 50)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(204, 50)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "Tambah Data"
        Me.btnInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'BtnDashboard
        '
        Me.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDashboard.FlatAppearance.BorderSize = 0
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.IconChar = FontAwesome.Sharp.IconChar.House
        Me.BtnDashboard.IconColor = System.Drawing.Color.White
        Me.BtnDashboard.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnDashboard.IconSize = 40
        Me.BtnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(204, 50)
        Me.BtnDashboard.TabIndex = 0
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDashboard.UseVisualStyleBackColor = True
        '
        'PanelLine
        '
        Me.PanelLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelLine.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLine.Location = New System.Drawing.Point(204, 73)
        Me.PanelLine.Name = "PanelLine"
        Me.PanelLine.Size = New System.Drawing.Size(1260, 10)
        Me.PanelLine.TabIndex = 2
        '
        'PanelContainer
        '
        Me.PanelContainer.Location = New System.Drawing.Point(210, 89)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1238, 558)
        Me.PanelContainer.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(204, 653)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1260, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(57, 17)
        Me.ToolStripStatusLabel1.Text = "Welcome"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1464, 675)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.PanelLine)
        Me.Controls.Add(Me.PanelSide)
        Me.Controls.Add(Me.PenelTOP)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "W2W Systems Information"
        Me.PenelTOP.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSide.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PenelTOP As Panel
    Friend WithEvents PanelSide As Panel
    Friend WithEvents PanelLine As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents BtnDashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents btnInput As FontAwesome.Sharp.IconButton
    Friend WithEvents btnUser As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExport As FontAwesome.Sharp.IconButton
    Friend WithEvents btnLog As FontAwesome.Sharp.IconButton
    Friend WithEvents btnEdit As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblTitik As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents LblTgl As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLogin As FontAwesome.Sharp.IconButton
End Class
