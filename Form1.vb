Imports FontAwesome.Sharp
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Form1
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel1.Text = "Welcome : " & Environment.UserName
        Change_Menu("Login")

        btnEdit.Visible = False
        btnInput.Visible = False
        btnUser.Visible = False
        btnExport.Visible = False

        ' Cek Database
        Dim thn As String = Format(Now, "yyyy")

        Dim CekSql = New SqlCommand("SELECT * FROM INFORMATION_SCHEMA.TABLES T WHERE T.TABLE_NAME = @tblnm", conn)
        CekSql.Parameters.AddWithValue("@tblnm", "vms_kp" & thn)
        conn.Open()
        Dim CekTbl As SqlClient.SqlDataReader = CekSql.ExecuteReader()

        CekTbl.Read()

        If Not CekTbl.HasRows Then
            Dim createSql As String
            Try
                Dim tblname = "vms_kp" & thn
                createSql = "CREATE TABLE " & tblname & " (tr VARCHAR(50) NULL DEFAULT NULL, " &
                      "material VARCHAR(150) NULL DEFAULT NULL," &
                      "batch_mtl VARCHAR(20) NULL Default NULL," &
                      "prodord VARCHAR(20) NULL Default NULL," &
                      "batch_prod VARCHAR(20) NULL DEFAULT NULL," &
                      "type VARCHAR(5) NULL DEFAULT NULL," &
                      "uom VARCHAR(10) NULL DEFAULT NULL," &
                      "take1 INT NULL DEFAULT NULL," &
                      "take2 INT NULL DEFAULT NULL," &
                      "take3 INT NULL DEFAULT NULL," &
                      "take4 INT NULL DEFAULT NULL," &
                      "take5 INT NULL DEFAULT NULL," &
                      "tiket1 VARCHAR(50) NULL DEFAULT NULL," &
                      "tiket2 VARCHAR(50) NULL DEFAULT NULL," &
                      "tiket3 VARCHAR(50) NULL DEFAULT NULL," &
                      "tiket4 VARCHAR(50) NULL DEFAULT NULL," &
                      "tiket5 VARCHAR(50) NULL DEFAULT NULL," &
                      "lok1 VARCHAR(50) NULL DEFAULT NULL," &
                      "lok2 VARCHAR(50) NULL DEFAULT NULL," &
                      "lok3 VARCHAR(50) NULL DEFAULT NULL," &
                      "lok4 VARCHAR(50) NULL DEFAULT NULL," &
                      "lok5 VARCHAR(50) NULL DEFAULT NULL," &
                      "sta1 VARCHAR(50) NULL DEFAULT NULL," &
                      "sta2 VARCHAR(50) NULL DEFAULT NULL," &
                      "sta3 VARCHAR(50) NULL DEFAULT NULL," &
                      "sta4 VARCHAR(50) NULL DEFAULT NULL," &
                      "sta5 VARCHAR(50) NULL DEFAULT NULL," &
                      "idinput1 VARCHAR(20) NULL DEFAULT NULL," &
                      "idinput2 VARCHAR(20) NULL DEFAULT NULL," &
                      "idinput3 VARCHAR(20) NULL DEFAULT NULL," &
                      "idinput4 VARCHAR(20) NULL DEFAULT NULL," &
                      "idinput5 VARCHAR(20) NULL DEFAULT NULL," &
                      "idcount1 VARCHAR(20) NULL DEFAULT NULL," &
                      "idcount2 VARCHAR(20) NULL DEFAULT NULL," &
                      "idcount3 VARCHAR(20) NULL DEFAULT NULL," &
                      "idcount4 VARCHAR(20) NULL DEFAULT NULL," &
                      "remark1 VARCHAR(50) NULL DEFAULT NULL," &
                      "remark2 VARCHAR(50) NULL DEFAULT NULL," &
                      "remark3 VARCHAR(50) NULL DEFAULT NULL," &
                      "remark4 VARCHAR(50) NULL DEFAULT NULL," &
                      "remark5 VARCHAR(50) NULL DEFAULT NULL," &
                      "akurasi VARCHAR(50) NULL DEFAULT NULL," &
                      "idcount5 VARCHAR(20) NULL DEFAULT NULL)"
                Dim cmd As New SqlCommand(createSql, conn)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

            End Try
            conn.Close()
        End If

    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 50)
        PanelSide.Controls.Add(leftBorderBtn)
    End Sub
    Private Sub ActiveButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableBtn()
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.DarkGray
            currentBtn.ForeColor = Color.Transparent
            currentBtn.IconColor = Color.White
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage

        End If
    End Sub
    Private Sub DisableBtn()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.Transparent
            currentBtn.ForeColor = Color.White
            currentBtn.IconColor = Color.White
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText

        End If
    End Sub

    Private Sub AddForm(frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()
    End Sub


    Private Sub Change_Menu(menu As String)
        Select Case menu
            Case "Input"
                AddForm(FormHome)
            Case "Edit"
                AddForm(FormEdit)
            Case "Home"
                AddForm(FormDashboard)
            Case "Log"
                AddForm(FormLog)
            Case "Export"
                AddForm(FormExport)
            Case "User"
                AddForm(FormUser)
            Case "Aktifasi"
                AddForm(FormAkses)
            Case "Login"
                AddForm(FormLogin)
        End Select
    End Sub

    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        ActiveButton(sender, Color.Crimson)
        Change_Menu("Input")
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim Msg, Style, Title, Response
        Msg = "Quit Application?"    ' Define message.
        Style = vbYesNo Or vbQuestion Or vbDefaultButton2    ' Define buttons.
        Title = "Confirmation"    ' Define title.
        ' Display message.
        Response = MsgBox(Msg, Style, Title)
        If Response = vbYes Then    ' Use
            Dim process As System.Diagnostics.Process = Process.GetCurrentProcess
            process.Kill()
            Application.Exit()
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Format(Now, "HH   mm")
        LblTgl.Text = Format(Now, "dd MMM yyyy")
        If LblTitik.Visible = True Then
            LblTitik.Visible = False
        Else
            LblTitik.Visible = True
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ActiveButton(sender, Color.Crimson)
        Change_Menu("Edit")
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        ActiveButton(sender, Color.Crimson)
        Change_Menu("Home")
    End Sub

    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        ActiveButton(sender, Color.Crimson)
        Change_Menu("Log")
    End Sub

    Private Sub BtnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ActiveButton(sender, Color.Crimson)
        Change_Menu("Export")
    End Sub

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ActiveButton(sender, Color.Crimson)
        Change_Menu("User")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'ActiveButton(sender, Color.Crimson)
        Change_Menu("Aktifasi")
    End Sub

    Public Sub awal()
        'ActiveButton(sender, Color.Crimson)
        Change_Menu("Aktifasi")
    End Sub

    Public Sub user()
        'ActiveButton(sender, Color.Crimson)
        Change_Menu("Input")
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If btnLogin.Text = "Login" Then
            ActiveButton(sender, Color.Crimson)
            Change_Menu("Login")
        Else
            btnLogin.Text = "Login"
            btnUser.Visible = False
            btnInput.Visible = False
            btnExport.Visible = False
            btnEdit.Visible = False
            ActiveButton(sender, Color.Crimson)
            Change_Menu("Login")
        End If
    End Sub
End Class
