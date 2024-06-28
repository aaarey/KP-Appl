Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography

Public Class FormUser
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)
    Dim thn As String = Format(Now, "yyyy")

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Using CekAKtif As SqlClient.SqlCommand = New SqlCommand("Select kondisi from vms_datatimer where id='2'", conn)
            conn.Open()
            Dim AktifSta As SqlClient.SqlDataReader = CekAKtif.ExecuteReader()
            AktifSta.Read()

            If AktifSta("kondisi").ToString = "OFF" Then
                BtnAdd.Enabled = False
                BtnAdd.BackColor = Color.Gray
                btnUpdate.Enabled = False
                btnUpdate.BackColor = Color.Gray
                btnHapus.Enabled = False
                btnHapus.BackColor = Color.Gray
            Else
                BtnAdd.Enabled = True
                BtnAdd.BackColor = Color.Turquoise
                btnUpdate.Enabled = True
                btnUpdate.BackColor = Color.Turquoise
                btnHapus.Enabled = True
                btnHapus.BackColor = Color.Turquoise

            End If

            conn.Close()
        End Using
    End Sub

    Sub DisplayAdmin()
        Using CekLast As New SqlClient.SqlCommand("select npp as [No NPP], Nama as [Nama Admin], Akses, Email, id From vms_wwuser", conn)
            conn.Open()
            Using sda As New SqlClient.SqlDataAdapter(CekLast)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    With DataGridView1
                        .DataSource = dt
                        .Columns(0).Width = 100
                        .Columns(1).Width = 305
                        .Columns(2).Width = 100
                        .Columns(3).Width = 200
                        .Columns(4).Visible = False
                    End With
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayAdmin()
        ClsFrm()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedindex As DataGridViewRow
        selectedindex = DataGridView1.Rows(e.RowIndex)
        txtNpp.Text = selectedindex.Cells(0).Value
        txtNama.Text = selectedindex.Cells(1).Value
        If Not IsDBNull(selectedindex.Cells(3).Value) Then
            txtmail.Text = selectedindex.Cells(3).Value
        Else
            txtmail.Text = ""
        End If
        If Not IsDBNull(selectedindex.Cells(2).Value) Then
            cmbakses.Text = selectedindex.Cells(2).Value
        Else
            cmbakses.Text = ""
        End If
        lblID.Text = selectedindex.Cells(4).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("update vms_wwuser SET npp=@npp, nama=@nama, email=@mail, pass=@pass, akses=@akses Where id=@id", conn)

            With cmdSave
                .Parameters.AddWithValue("@npp", txtNpp.Text)
                .Parameters.AddWithValue("@nama", txtNama.Text)
                .Parameters.AddWithValue("@mail", txtmail.Text)
                .Parameters.AddWithValue("@pass", Encrypt(txtpass.Text))
                .Parameters.AddWithValue("@akses", cmbakses.Text)
                .Parameters.AddWithValue("@id", lblID.Text)
            End With
            conn.Open()
            cmdSave.ExecuteNonQuery()
            conn.Close()
            DisplayAdmin()
            ClsFrm()
        End Using
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("Insert Into vms_wwuser (npp, nama, email, pass, akses) VALUES (@npp,@nama,@mail,@pass,@akses)", conn)

            With cmdSave
                .Parameters.AddWithValue("@npp", txtNpp.Text)
                .Parameters.AddWithValue("@nama", txtNama.Text)
                .Parameters.AddWithValue("@mail", txtmail.Text)
                .Parameters.AddWithValue("@pass", Encrypt(txtpass.Text))
                .Parameters.AddWithValue("@akses", cmbakses.Text)

            End With
            conn.Open()
            cmdSave.ExecuteNonQuery()
            conn.Close()
            DisplayAdmin()
            ClsFrm()
        End Using
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("DELETE From vms_wwuser WHERE id=@id", conn)

            With cmdSave
                .Parameters.AddWithValue("@id", lblID.Text)
            End With

            Dim Msg, Style, Title, Response
            Msg = "Yakin Akan Hapus Data Ini?"    ' Define message.
            Style = vbYesNo Or vbQuestion Or vbDefaultButton2    ' Define buttons.
            Title = "Confirmation"    ' Define title.
            ' Display message.
            Response = MsgBox(Msg, Style, Title)
            If Response = vbYes Then    ' Use
                conn.Open()
                cmdSave.ExecuteNonQuery()
                conn.Close()
                DisplayAdmin()
                ClsFrm()
            Else
                Exit Sub
            End If

        End Using
    End Sub

    Sub ClsFrm()
        txtNpp.Text = ""
        txtNama.Text = ""
        txtpass.Text = ""
        txtmail.Text = ""
        cmbakses.Text = ""
    End Sub

End Class