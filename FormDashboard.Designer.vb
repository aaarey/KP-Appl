<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CPFGInvt = New CircularProgressBar.CircularProgressBar()
        Me.CPFGAkurat = New CircularProgressBar.CircularProgressBar()
        Me.CPFGInput = New CircularProgressBar.CircularProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CPRMInvt = New CircularProgressBar.CircularProgressBar()
        Me.CPRMAkurat = New CircularProgressBar.CircularProgressBar()
        Me.CPRMInput = New CircularProgressBar.CircularProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.WIPCurr = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblWIP1 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CPWIPInvt = New CircularProgressBar.CircularProgressBar()
        Me.CPWIPAkurat = New CircularProgressBar.CircularProgressBar()
        Me.CBWIPInput = New CircularProgressBar.CircularProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblWIP2 = New System.Windows.Forms.Label()
        Me.LblWIP3 = New System.Windows.Forms.Label()
        Me.LblWIP4 = New System.Windows.Forms.Label()
        Me.RMCurr = New System.Windows.Forms.Label()
        Me.LblRM1 = New System.Windows.Forms.Label()
        Me.LblRM2 = New System.Windows.Forms.Label()
        Me.LblRM4 = New System.Windows.Forms.Label()
        Me.LblRM3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CPFGInvt)
        Me.Panel1.Controls.Add(Me.CPFGAkurat)
        Me.Panel1.Controls.Add(Me.CPFGInput)
        Me.Panel1.Location = New System.Drawing.Point(11, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 236)
        Me.Panel1.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(106, 20)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Jumlah Batch"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(288, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Investigasi"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 20)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "Nilai Selisih"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(170, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Akurat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Input Tiket"
        '
        'CPFGInvt
        '
        Me.CPFGInvt.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPFGInvt.AnimationSpeed = 500
        Me.CPFGInvt.BackColor = System.Drawing.Color.Transparent
        Me.CPFGInvt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CPFGInvt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPFGInvt.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPFGInvt.InnerMargin = 2
        Me.CPFGInvt.InnerWidth = -1
        Me.CPFGInvt.Location = New System.Drawing.Point(259, 84)
        Me.CPFGInvt.MarqueeAnimationSpeed = 2000
        Me.CPFGInvt.Name = "CPFGInvt"
        Me.CPFGInvt.OuterColor = System.Drawing.Color.Gray
        Me.CPFGInvt.OuterMargin = -25
        Me.CPFGInvt.OuterWidth = 26
        Me.CPFGInvt.ProgressColor = System.Drawing.Color.Red
        Me.CPFGInvt.ProgressWidth = 20
        Me.CPFGInvt.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPFGInvt.Size = New System.Drawing.Size(120, 120)
        Me.CPFGInvt.StartAngle = 270
        Me.CPFGInvt.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPFGInvt.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPFGInvt.SubscriptText = ""
        Me.CPFGInvt.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPFGInvt.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPFGInvt.SuperscriptText = ""
        Me.CPFGInvt.TabIndex = 4
        Me.CPFGInvt.Text = "100%"
        Me.CPFGInvt.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPFGInvt.Value = 68
        '
        'CPFGAkurat
        '
        Me.CPFGAkurat.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPFGAkurat.AnimationSpeed = 500
        Me.CPFGAkurat.BackColor = System.Drawing.Color.Transparent
        Me.CPFGAkurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CPFGAkurat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPFGAkurat.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPFGAkurat.InnerMargin = 2
        Me.CPFGAkurat.InnerWidth = -1
        Me.CPFGAkurat.Location = New System.Drawing.Point(133, 84)
        Me.CPFGAkurat.MarqueeAnimationSpeed = 2000
        Me.CPFGAkurat.Name = "CPFGAkurat"
        Me.CPFGAkurat.OuterColor = System.Drawing.Color.Gray
        Me.CPFGAkurat.OuterMargin = -25
        Me.CPFGAkurat.OuterWidth = 26
        Me.CPFGAkurat.ProgressColor = System.Drawing.Color.Lime
        Me.CPFGAkurat.ProgressWidth = 20
        Me.CPFGAkurat.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPFGAkurat.Size = New System.Drawing.Size(120, 120)
        Me.CPFGAkurat.StartAngle = 270
        Me.CPFGAkurat.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPFGAkurat.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPFGAkurat.SubscriptText = ""
        Me.CPFGAkurat.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPFGAkurat.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPFGAkurat.SuperscriptText = ""
        Me.CPFGAkurat.TabIndex = 3
        Me.CPFGAkurat.Text = "100%"
        Me.CPFGAkurat.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPFGAkurat.Value = 68
        '
        'CPFGInput
        '
        Me.CPFGInput.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPFGInput.AnimationSpeed = 500
        Me.CPFGInput.BackColor = System.Drawing.Color.Transparent
        Me.CPFGInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CPFGInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPFGInput.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPFGInput.InnerMargin = 2
        Me.CPFGInput.InnerWidth = -1
        Me.CPFGInput.Location = New System.Drawing.Point(7, 84)
        Me.CPFGInput.MarqueeAnimationSpeed = 2000
        Me.CPFGInput.Name = "CPFGInput"
        Me.CPFGInput.OuterColor = System.Drawing.Color.Gray
        Me.CPFGInput.OuterMargin = -25
        Me.CPFGInput.OuterWidth = 26
        Me.CPFGInput.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CPFGInput.ProgressWidth = 20
        Me.CPFGInput.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPFGInput.Size = New System.Drawing.Size(120, 120)
        Me.CPFGInput.StartAngle = 270
        Me.CPFGInput.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPFGInput.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPFGInput.SubscriptText = ""
        Me.CPFGInput.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPFGInput.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPFGInput.SuperscriptText = ""
        Me.CPFGInput.TabIndex = 2
        Me.CPFGInput.Text = "100%"
        Me.CPFGInput.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPFGInput.Value = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Finish Goods Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(402, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "RM && PP Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(795, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "WIP Status"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.RMCurr)
        Me.Panel2.Controls.Add(Me.LblRM1)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.CPRMInvt)
        Me.Panel2.Controls.Add(Me.CPRMAkurat)
        Me.Panel2.Controls.Add(Me.CPRMInput)
        Me.Panel2.Location = New System.Drawing.Point(404, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 236)
        Me.Panel2.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 20)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Jumlah Batch"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 20)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Nilai Selisih"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(284, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Investigasi"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 206)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Akurat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Input Tiket"
        '
        'CPRMInvt
        '
        Me.CPRMInvt.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPRMInvt.AnimationSpeed = 500
        Me.CPRMInvt.BackColor = System.Drawing.Color.Transparent
        Me.CPRMInvt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CPRMInvt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPRMInvt.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPRMInvt.InnerMargin = 2
        Me.CPRMInvt.InnerWidth = -1
        Me.CPRMInvt.Location = New System.Drawing.Point(258, 84)
        Me.CPRMInvt.MarqueeAnimationSpeed = 2000
        Me.CPRMInvt.Name = "CPRMInvt"
        Me.CPRMInvt.OuterColor = System.Drawing.Color.Gray
        Me.CPRMInvt.OuterMargin = -25
        Me.CPRMInvt.OuterWidth = 26
        Me.CPRMInvt.ProgressColor = System.Drawing.Color.Red
        Me.CPRMInvt.ProgressWidth = 20
        Me.CPRMInvt.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPRMInvt.Size = New System.Drawing.Size(120, 120)
        Me.CPRMInvt.StartAngle = 270
        Me.CPRMInvt.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPRMInvt.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPRMInvt.SubscriptText = ""
        Me.CPRMInvt.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPRMInvt.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPRMInvt.SuperscriptText = ""
        Me.CPRMInvt.TabIndex = 4
        Me.CPRMInvt.Text = "100%"
        Me.CPRMInvt.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPRMInvt.Value = 68
        '
        'CPRMAkurat
        '
        Me.CPRMAkurat.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPRMAkurat.AnimationSpeed = 500
        Me.CPRMAkurat.BackColor = System.Drawing.Color.Transparent
        Me.CPRMAkurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CPRMAkurat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPRMAkurat.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPRMAkurat.InnerMargin = 2
        Me.CPRMAkurat.InnerWidth = -1
        Me.CPRMAkurat.Location = New System.Drawing.Point(132, 84)
        Me.CPRMAkurat.MarqueeAnimationSpeed = 2000
        Me.CPRMAkurat.Name = "CPRMAkurat"
        Me.CPRMAkurat.OuterColor = System.Drawing.Color.Gray
        Me.CPRMAkurat.OuterMargin = -25
        Me.CPRMAkurat.OuterWidth = 26
        Me.CPRMAkurat.ProgressColor = System.Drawing.Color.Lime
        Me.CPRMAkurat.ProgressWidth = 20
        Me.CPRMAkurat.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPRMAkurat.Size = New System.Drawing.Size(120, 120)
        Me.CPRMAkurat.StartAngle = 270
        Me.CPRMAkurat.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPRMAkurat.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPRMAkurat.SubscriptText = ""
        Me.CPRMAkurat.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPRMAkurat.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPRMAkurat.SuperscriptText = ""
        Me.CPRMAkurat.TabIndex = 3
        Me.CPRMAkurat.Text = "100%"
        Me.CPRMAkurat.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPRMAkurat.Value = 68
        '
        'CPRMInput
        '
        Me.CPRMInput.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPRMInput.AnimationSpeed = 500
        Me.CPRMInput.BackColor = System.Drawing.Color.Transparent
        Me.CPRMInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CPRMInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPRMInput.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPRMInput.InnerMargin = 2
        Me.CPRMInput.InnerWidth = -1
        Me.CPRMInput.Location = New System.Drawing.Point(6, 84)
        Me.CPRMInput.MarqueeAnimationSpeed = 2000
        Me.CPRMInput.Name = "CPRMInput"
        Me.CPRMInput.OuterColor = System.Drawing.Color.Gray
        Me.CPRMInput.OuterMargin = -25
        Me.CPRMInput.OuterWidth = 26
        Me.CPRMInput.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CPRMInput.ProgressWidth = 20
        Me.CPRMInput.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPRMInput.Size = New System.Drawing.Size(120, 120)
        Me.CPRMInput.StartAngle = 270
        Me.CPRMInput.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPRMInput.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPRMInput.SubscriptText = ""
        Me.CPRMInput.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPRMInput.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPRMInput.SuperscriptText = ""
        Me.CPRMInput.TabIndex = 2
        Me.CPRMInput.Text = "100%"
        Me.CPRMInput.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPRMInput.Value = 68
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.WIPCurr)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.LblWIP1)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.CPWIPInvt)
        Me.Panel3.Controls.Add(Me.CPWIPAkurat)
        Me.Panel3.Controls.Add(Me.CBWIPInput)
        Me.Panel3.Location = New System.Drawing.Point(797, 45)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(387, 236)
        Me.Panel3.TabIndex = 9
        '
        'WIPCurr
        '
        Me.WIPCurr.AutoSize = True
        Me.WIPCurr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WIPCurr.Location = New System.Drawing.Point(171, 9)
        Me.WIPCurr.Name = "WIPCurr"
        Me.WIPCurr.Size = New System.Drawing.Size(19, 20)
        Me.WIPCurr.TabIndex = 11
        Me.WIPCurr.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 20)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Jumlah Batch"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(14, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 20)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "Nilai Selisih"
        '
        'LblWIP1
        '
        Me.LblWIP1.AutoSize = True
        Me.LblWIP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWIP1.Location = New System.Drawing.Point(171, 42)
        Me.LblWIP1.Name = "LblWIP1"
        Me.LblWIP1.Size = New System.Drawing.Size(19, 20)
        Me.LblWIP1.TabIndex = 10
        Me.LblWIP1.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(290, 206)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Investigasi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(172, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Akurat"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(30, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 17)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Input Tiket"
        '
        'CPWIPInvt
        '
        Me.CPWIPInvt.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPWIPInvt.AnimationSpeed = 500
        Me.CPWIPInvt.BackColor = System.Drawing.Color.Transparent
        Me.CPWIPInvt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CPWIPInvt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPWIPInvt.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPWIPInvt.InnerMargin = 2
        Me.CPWIPInvt.InnerWidth = -1
        Me.CPWIPInvt.Location = New System.Drawing.Point(259, 84)
        Me.CPWIPInvt.MarqueeAnimationSpeed = 2000
        Me.CPWIPInvt.Name = "CPWIPInvt"
        Me.CPWIPInvt.OuterColor = System.Drawing.Color.Gray
        Me.CPWIPInvt.OuterMargin = -25
        Me.CPWIPInvt.OuterWidth = 26
        Me.CPWIPInvt.ProgressColor = System.Drawing.Color.Red
        Me.CPWIPInvt.ProgressWidth = 20
        Me.CPWIPInvt.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPWIPInvt.Size = New System.Drawing.Size(120, 120)
        Me.CPWIPInvt.StartAngle = 270
        Me.CPWIPInvt.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPWIPInvt.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPWIPInvt.SubscriptText = ""
        Me.CPWIPInvt.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPWIPInvt.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPWIPInvt.SuperscriptText = ""
        Me.CPWIPInvt.TabIndex = 4
        Me.CPWIPInvt.Text = "0%"
        Me.CPWIPInvt.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPWIPInvt.Value = 68
        '
        'CPWIPAkurat
        '
        Me.CPWIPAkurat.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CPWIPAkurat.AnimationSpeed = 500
        Me.CPWIPAkurat.BackColor = System.Drawing.Color.Transparent
        Me.CPWIPAkurat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CPWIPAkurat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CPWIPAkurat.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CPWIPAkurat.InnerMargin = 2
        Me.CPWIPAkurat.InnerWidth = -1
        Me.CPWIPAkurat.Location = New System.Drawing.Point(133, 84)
        Me.CPWIPAkurat.MarqueeAnimationSpeed = 2000
        Me.CPWIPAkurat.Name = "CPWIPAkurat"
        Me.CPWIPAkurat.OuterColor = System.Drawing.Color.Gray
        Me.CPWIPAkurat.OuterMargin = -25
        Me.CPWIPAkurat.OuterWidth = 26
        Me.CPWIPAkurat.ProgressColor = System.Drawing.Color.Lime
        Me.CPWIPAkurat.ProgressWidth = 20
        Me.CPWIPAkurat.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CPWIPAkurat.Size = New System.Drawing.Size(120, 120)
        Me.CPWIPAkurat.StartAngle = 270
        Me.CPWIPAkurat.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPWIPAkurat.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CPWIPAkurat.SubscriptText = ""
        Me.CPWIPAkurat.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CPWIPAkurat.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CPWIPAkurat.SuperscriptText = ""
        Me.CPWIPAkurat.TabIndex = 3
        Me.CPWIPAkurat.Text = "0%"
        Me.CPWIPAkurat.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CPWIPAkurat.Value = 68
        '
        'CBWIPInput
        '
        Me.CBWIPInput.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.CBWIPInput.AnimationSpeed = 500
        Me.CBWIPInput.BackColor = System.Drawing.Color.Transparent
        Me.CBWIPInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBWIPInput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CBWIPInput.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CBWIPInput.InnerMargin = 2
        Me.CBWIPInput.InnerWidth = -1
        Me.CBWIPInput.Location = New System.Drawing.Point(7, 84)
        Me.CBWIPInput.MarqueeAnimationSpeed = 2000
        Me.CBWIPInput.Name = "CBWIPInput"
        Me.CBWIPInput.OuterColor = System.Drawing.Color.Gray
        Me.CBWIPInput.OuterMargin = -25
        Me.CBWIPInput.OuterWidth = 26
        Me.CBWIPInput.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBWIPInput.ProgressWidth = 20
        Me.CBWIPInput.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.CBWIPInput.Size = New System.Drawing.Size(120, 120)
        Me.CBWIPInput.StartAngle = 270
        Me.CBWIPInput.Step = 1
        Me.CBWIPInput.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.CBWIPInput.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CBWIPInput.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.CBWIPInput.SubscriptText = ""
        Me.CBWIPInput.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.CBWIPInput.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.CBWIPInput.SuperscriptText = ""
        Me.CBWIPInput.TabIndex = 2
        Me.CBWIPInput.Text = "0%"
        Me.CBWIPInput.TextMargin = New System.Windows.Forms.Padding(5, 5, 0, 0)
        Me.CBWIPInput.Value = 68
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'LblWIP2
        '
        Me.LblWIP2.AutoSize = True
        Me.LblWIP2.Location = New System.Drawing.Point(970, 295)
        Me.LblWIP2.Name = "LblWIP2"
        Me.LblWIP2.Size = New System.Drawing.Size(45, 13)
        Me.LblWIP2.TabIndex = 11
        Me.LblWIP2.Text = "Label13"
        Me.LblWIP2.Visible = False
        '
        'LblWIP3
        '
        Me.LblWIP3.AutoSize = True
        Me.LblWIP3.Location = New System.Drawing.Point(1099, 295)
        Me.LblWIP3.Name = "LblWIP3"
        Me.LblWIP3.Size = New System.Drawing.Size(45, 13)
        Me.LblWIP3.TabIndex = 12
        Me.LblWIP3.Text = "Label14"
        Me.LblWIP3.Visible = False
        '
        'LblWIP4
        '
        Me.LblWIP4.AutoSize = True
        Me.LblWIP4.Location = New System.Drawing.Point(828, 295)
        Me.LblWIP4.Name = "LblWIP4"
        Me.LblWIP4.Size = New System.Drawing.Size(45, 13)
        Me.LblWIP4.TabIndex = 13
        Me.LblWIP4.Text = "Label13"
        Me.LblWIP4.Visible = False
        '
        'RMCurr
        '
        Me.RMCurr.AutoSize = True
        Me.RMCurr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMCurr.Location = New System.Drawing.Point(146, 9)
        Me.RMCurr.Name = "RMCurr"
        Me.RMCurr.Size = New System.Drawing.Size(19, 20)
        Me.RMCurr.TabIndex = 14
        Me.RMCurr.Text = "0"
        '
        'LblRM1
        '
        Me.LblRM1.AutoSize = True
        Me.LblRM1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRM1.Location = New System.Drawing.Point(146, 42)
        Me.LblRM1.Name = "LblRM1"
        Me.LblRM1.Size = New System.Drawing.Size(19, 20)
        Me.LblRM1.TabIndex = 13
        Me.LblRM1.Text = "0"
        '
        'LblRM2
        '
        Me.LblRM2.AutoSize = True
        Me.LblRM2.Location = New System.Drawing.Point(446, 295)
        Me.LblRM2.Name = "LblRM2"
        Me.LblRM2.Size = New System.Drawing.Size(45, 13)
        Me.LblRM2.TabIndex = 16
        Me.LblRM2.Text = "Label13"
        Me.LblRM2.Visible = False
        '
        'LblRM4
        '
        Me.LblRM4.AutoSize = True
        Me.LblRM4.Location = New System.Drawing.Point(717, 295)
        Me.LblRM4.Name = "LblRM4"
        Me.LblRM4.Size = New System.Drawing.Size(45, 13)
        Me.LblRM4.TabIndex = 15
        Me.LblRM4.Text = "Label14"
        Me.LblRM4.Visible = False
        '
        'LblRM3
        '
        Me.LblRM3.AutoSize = True
        Me.LblRM3.Location = New System.Drawing.Point(585, 296)
        Me.LblRM3.Name = "LblRM3"
        Me.LblRM3.Size = New System.Drawing.Size(45, 13)
        Me.LblRM3.TabIndex = 17
        Me.LblRM3.Text = "Label19"
        Me.LblRM3.Visible = False
        '
        'FormDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1211, 494)
        Me.Controls.Add(Me.LblRM3)
        Me.Controls.Add(Me.LblRM2)
        Me.Controls.Add(Me.LblRM4)
        Me.Controls.Add(Me.LblWIP4)
        Me.Controls.Add(Me.LblWIP3)
        Me.Controls.Add(Me.LblWIP2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormDashboard"
        Me.Text = "FormDashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents CPFGInvt As CircularProgressBar.CircularProgressBar
    Friend WithEvents CPFGAkurat As CircularProgressBar.CircularProgressBar
    Friend WithEvents CPFGInput As CircularProgressBar.CircularProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CPRMInvt As CircularProgressBar.CircularProgressBar
    Friend WithEvents CPRMAkurat As CircularProgressBar.CircularProgressBar
    Friend WithEvents CPRMInput As CircularProgressBar.CircularProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CPWIPInvt As CircularProgressBar.CircularProgressBar
    Friend WithEvents CPWIPAkurat As CircularProgressBar.CircularProgressBar
    Friend WithEvents CBWIPInput As CircularProgressBar.CircularProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblWIP1 As Label
    Friend WithEvents LblWIP2 As Label
    Friend WithEvents LblWIP3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents WIPCurr As Label
    Friend WithEvents LblWIP4 As Label
    Friend WithEvents RMCurr As Label
    Friend WithEvents LblRM1 As Label
    Friend WithEvents LblRM2 As Label
    Friend WithEvents LblRM4 As Label
    Friend WithEvents LblRM3 As Label
End Class
