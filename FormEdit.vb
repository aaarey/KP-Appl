Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports FontAwesome.Sharp
Public Class FormEdit
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)

    Private Sub FormEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using cmd As New SqlClient.SqlCommand("Select Distinct tahunkey From vms_datakey", conn)
            cmd.CommandType = CommandType.Text
            conn.Open()
            Dim nts As SqlClient.SqlDataReader = cmd.ExecuteReader()
            cmbtahun.Items.Clear()
            While nts.Read
                cmbtahun.Items.Add(nts("tahunkey").ToString)
            End While
            conn.Close()
        End Using
        cmbtahun.Text = Format(Now, "yyyy")
        ClearLayar()
    End Sub

    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        If (cmbkriteria.Text = "") Or (txtInput.Text = "") Then
            MsgBox("Harap Isi Form Transaksi Terlebih Dahulu", MessageBoxIcon.Hand, "Warning")
        Else

            Dim squery As String = ""
            If cmbkriteria.Text = "Nomor Tiket" Then
                squery = "Select * from vms_datakey WHERE tahunkey=@thn AND ticketkey=@xdata"
            Else
                squery = "Select * from vms_datakey WHERE tahunkey=@thn AND inputkey=@xdata"
            End If
            conn.Open()
            Using CekAKtif As SqlClient.SqlCommand = New SqlCommand(squery, conn)
                CekAKtif.Parameters.AddWithValue("@thn", cmbtahun.Text)
                CekAKtif.Parameters.AddWithValue("@xdata", txtInput.Text)
                Dim AktifSta As SqlClient.SqlDataReader = CekAKtif.ExecuteReader()
                AktifSta.Read()
                If AktifSta.HasRows Then
                    lblcol.Text = AktifSta("kolomkey").ToString
                    lblInputkey.Text = AktifSta("Inputkey").ToString

                    Dim x As String = lblcol.Text
                    Dim thn As String = cmbtahun.Text
                    Using CekEdit As SqlClient.SqlCommand = New SqlCommand("Select prodord, material, batch_prod, take" & x & ", sta" & x & ", tiket" & x & ", lok" & x & ", idinput" & x & "," &
                                                                           "idcount" & x & ", remark" & x & ", akurasi From vms_ww" & thn & " where prodord=@a9", conn)
                        CekEdit.Parameters.AddWithValue("@a9", lblInputkey.Text)

                        Dim EditSta As SqlClient.SqlDataReader = CekEdit.ExecuteReader()
                        EditSta.Read()
                        If EditSta.HasRows Then
                            cmbProd.Text = EditSta("prodord").ToString
                            cmbMaterial.Text = EditSta("material").ToString
                            cmbBatch.Text = EditSta("batch_prod").ToString
                            txtQty.Text = EditSta("take" & x).ToString
                            txtLokasi.Text = EditSta("lok" & x).ToString
                            txtStatus.Text = EditSta("sta" & x).ToString
                            txtRemarks.Text = EditSta("remark" & x).ToString
                            txtChecker.Text = EditSta("idcount" & x).ToString
                            txtTiket.Text = EditSta("tiket" & x).ToString
                        End If
                    End Using
                Else
                    MsgBox(cmbkriteria.Text & " [" & txtInput.Text & "] Tidak Ditemukan", MessageBoxIcon.Hand, "Warning")
                    ClearLayar()
                    txtInput.Select()
                End If
            End Using
        End If
        conn.Close()
    End Sub
    Sub ClearLayar()
        cmbProd.Text = ""
        cmbMaterial.Text = ""
        cmbBatch.Text = ""
        txtQty.Text = ""
        txtStatus.Text = ""
        txtRemarks.Text = ""
        txtTiket.Text = ""
        txtChecker.Text = ""
        cmbkriteria.Text = ""
        txtInput.Text = ""
    End Sub

    Private Sub TxtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTampil.Select()
        End If
    End Sub

    Private Sub BtnTampil_KeyDown(sender As Object, e As KeyEventArgs) Handles btnTampil.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTampil.PerformClick()
        End If
    End Sub
    Sub bersih()
        cmbkriteria.Text = ""
        cmbProd.Text = ""
        cmbkriteria.Text = ""
        cmbBatch.Text = ""
        cmbMaterial.Text = ""
        txtInput.Text = ""
        txtLokasi.Text = ""
        txtQty.Text = ""
        txtRemarks.Text = ""
        txtStatus.Text = ""
        txtTiket.Text = ""
        txtChecker.Text = ""
    End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim lvl As String = lblcol.Text
        Dim thn As String = cmbtahun.Text
        If (cmbProd.Text = "") Or (txtTiket.Text = "") Then
            MsgBox("Silahkan Masukan Data terlebih dahulu", MessageBoxIcon.Error, "Error")
            Exit Sub
        Else
            Using cmdSave As SqlClient.SqlCommand = New SqlCommand("update vms_ww" & thn & " SET prodord=@prod, batch_prod=@batch, material=@mtl, take" & lvl & "=@take, tiket" & lvl & "=@tiket,  
                                                                lok" & lvl & "=@lok, sta" & lvl & "=@sta, idcount" & lvl & "=@idcount, remark" & lvl & "=@remarks Where prodord=@id", conn)

                With cmdSave
                    .Parameters.AddWithValue("@prod", cmbProd.Text)
                    .Parameters.AddWithValue("@batch", cmbBatch.Text)
                    .Parameters.AddWithValue("@mtl", cmbMaterial.Text)
                    .Parameters.AddWithValue("@take", txtQty.Text)
                    .Parameters.AddWithValue("@tiket", txtTiket.Text)
                    .Parameters.AddWithValue("@lok", txtLokasi.Text)
                    .Parameters.AddWithValue("@sta", txtStatus.Text)
                    .Parameters.AddWithValue("@idcount", txtChecker.Text)
                    .Parameters.AddWithValue("@remarks", txtRemarks.Text)
                    .Parameters.AddWithValue("@id", lblInputkey.Text)
                End With
                conn.Open()
                cmdSave.ExecuteNonQuery()
                conn.Close()
                MsgBox("Data Updated", MessageBoxIcon.Information, "Update Sukses")
                bersih()
            End Using
        End If
    End Sub
End Class