Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class FormLogin
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)
    Private Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "JanganDibukaKarena IniRahasia 123456789 !@#$%^&"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    Private Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "JanganDibukaKarena IniRahasia 123456789 !@#$%^&"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
         &H65, &H64, &H76, &H65, &H64, &H65,
         &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT * FROM vms_wwuser WHERE npp=@idx AND pass=@pass")
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@Idx", txtuser.Text)
            cmd.Parameters.AddWithValue("@pass", Encrypt(txtpass.Text))
            cmd.Connection = conn
            conn.Open()

            Using sdr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                If Not sdr.HasRows Then
                    MsgBox("Password Tidak Sesuai", MessageBoxIcon.Exclamation, "Error")
                End If

                If sdr.HasRows Then
                    sdr.Read()
                    Form1.btnLogin.Text = "Logout"
                    If sdr("akses").ToString = "Administrator" Then
                        Form1.btnUser.Visible = True
                        Form1.btnInput.Visible = True
                        Form1.btnExport.Visible = True
                        Form1.btnEdit.Visible = True
                        Form1.awal()
                        FormHome.txtAdmin.Text = txtuser.Text
                    ElseIf sdr("akses").ToString = "User" Then
                        Form1.btnUser.Visible = False
                        Form1.btnInput.Visible = True
                        Form1.btnExport.Visible = True
                        Form1.btnEdit.Visible = False
                        Form1.user()
                        FormHome.txtAdmin.Text = txtuser.Text
                    ElseIf sdr("akses").ToString = "Korektor" Then
                        Form1.btnUser.Visible = False
                        Form1.btnInput.Visible = True
                        Form1.btnExport.Visible = True
                        Form1.btnEdit.Visible = True
                        Form1.user()
                        FormHome.txtAdmin.Text = txtuser.Text
                    Else
                        Form1.btnUser.Visible = False
                        Form1.btnInput.Visible = False
                        Form1.btnExport.Visible = False
                        Form1.btnEdit.Visible = False
                        MsgBox("Password Tidak Sesuai", MessageBoxIcon.Exclamation, "Error")
                    End If
                End If
                txtpass.Text = ""
                txtuser.Text = ""
            End Using
            conn.Close()
        End Using
    End Sub
End Class