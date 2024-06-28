Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class FormAkses
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

    Private Sub FormAkses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using CekAKtif As SqlClient.SqlCommand = New SqlCommand("Select kondisi from vms_datatimer where id='1'", conn)
            conn.Open()
            Dim AktifSta As SqlClient.SqlDataReader = CekAKtif.ExecuteReader()
            AktifSta.Read()

            If AktifSta("kondisi").ToString = "OFF" Then
                chkAktif.Checked = False
                chkUnAktif.Checked = True
            Else
                chkAktif.Checked = True
                chkUnAktif.Checked = False
            End If

            conn.Close()
        End Using

        Using CekUser As SqlClient.SqlCommand = New SqlCommand("Select kondisi from vms_datatimer where id='2'", conn)
            conn.Open()
            Dim AktifSta As SqlClient.SqlDataReader = CekUser.ExecuteReader()
            AktifSta.Read()

            If AktifSta("kondisi").ToString = "OFF" Then
                chkAddUser.Checked = False
            Else
                chkAddUser.Checked = True

            End If
            conn.Close()
        End Using
    End Sub

    Private Sub ChkAktif_Click(sender As Object, e As EventArgs) Handles chkAktif.Click
        If chkAktif.Checked = True Then
            chkUnAktif.Checked = False
        End If
    End Sub

    Private Sub ChkUnAktif_Click(sender As Object, e As EventArgs) Handles chkUnAktif.Click
        If chkUnAktif.Checked = True Then
            chkAktif.Checked = False
        End If
    End Sub

    Private Sub BtnAktifasi_Click(sender As Object, e As EventArgs) Handles btnAktifasi.Click
        Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("UPDATE vms_datatimer Set kondisi=@kondisi Where id=@id", conn)
            With cmdTiket
                .Parameters.AddWithValue("@id", "1")
                If chkAktif.Checked = True Then
                    .Parameters.AddWithValue("@kondisi", "ON")
                Else
                    .Parameters.AddWithValue("@kondisi", "OFF")
                End If
                conn.Open()
                .ExecuteNonQuery()
                conn.Close()
            End With
        End Using

        Using cmdUser As SqlClient.SqlCommand = New SqlCommand("UPDATE vms_datatimer Set kondisi=@kondisi Where id=@id", conn)
                With cmdUser
                    .Parameters.AddWithValue("@id", "2")
                    If chkAddUser.Checked = True Then
                        .Parameters.AddWithValue("@kondisi", "ON")
                    Else
                        .Parameters.AddWithValue("@kondisi", "OFF")
                    End If
                conn.Open()
                .ExecuteNonQuery()
                conn.Close()
            End With

            chkAktif.Enabled = False
            chkUnAktif.Enabled = False
            chkAddUser.Enabled = False
            btnAktifasi.Enabled = False
            End Using
    End Sub

    Private Sub BtnLock_Click(sender As Object, e As EventArgs) Handles btnLock.Click
        Using cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand("SELECT * FROM wms_key WHERE usr1=@idx AND xowner=@Ctg")
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@Idx", "Administrator")
            cmd.Parameters.AddWithValue("@Ctg", "LogBook")
            cmd.Connection = conn
            conn.Open()

            Using sdr As SqlClient.SqlDataReader = cmd.ExecuteReader()
                If sdr.HasRows Then
                    sdr.Read()
                    If txtpass.Text = Decrypt(sdr("str1").ToString) Then
                        chkAktif.Enabled = True
                        chkUnAktif.Enabled = True
                        chkAddUser.Enabled = True
                        btnAktifasi.Enabled = True
                        MsgBox("Form Unlocked", MessageBoxIcon.Information, "Warning")
                        txtpass.Text = ""

                    Else
                        chkAktif.Enabled = False
                        chkUnAktif.Enabled = False
                        chkAddUser.Enabled = False
                        btnAktifasi.Enabled = False
                        MsgBox("Password Tidak Sesuai", MessageBoxIcon.Exclamation, "Error")
                    End If
                End If
            End Using
            conn.Close()
        End Using
    End Sub
End Class