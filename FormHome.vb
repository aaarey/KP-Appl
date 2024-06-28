Imports System.Data
Imports System.Data.SqlClient
Imports FontAwesome.Sharp
Public Class FormHome
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)
    Dim thn As String = Format(Now, "yyyy")


    Private Sub ChkFG_Click(sender As Object, e As EventArgs) Handles chkFG.Click
        If chkFG.Checked = True Then
            chkRM.Checked = False
            chkWIP.Checked = False
            cmbProd.Enabled = False
            cmbBatch.Select()
        End If
    End Sub

    Private Sub ChkRM_Click(sender As Object, e As EventArgs) Handles chkRM.Click
        If chkRM.Checked = True Then
            chkFG.Checked = False
            chkWIP.Checked = False
            cmbProd.Enabled = False
            cmbBatch.Select()
        End If
    End Sub

    Private Sub ChkWIP_Click(sender As Object, e As EventArgs) Handles chkWIP.Click
        If chkWIP.Checked = True Then
            chkRM.Checked = False
            chkFG.Checked = False
            cmbProd.Enabled = True
            cmbProd.Select()
        End If
    End Sub

    Private Sub CmbProd_TextChanged(sender As Object, e As EventArgs) Handles cmbProd.TextChanged
        If chkWIP.Checked = True Then

            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("Select * from vms_tblw2w where kelas='WIP' and tahun=@thn and prodord1=@Prod", conn)
                With CekWIP
                    .Parameters.AddWithValue("@thn", thn)
                    .Parameters.AddWithValue("@Prod", cmbProd.Text)
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    cmbMaterial.Text = hslWIP("material").ToString
                    cmbBatch.Text = hslWIP("batch").ToString
                    LblStock.Text = hslWIP("unres").ToString
                End If
                conn.Close()
            End Using

            Using CekCount As SqlClient.SqlCommand = New SqlCommand("Select Count(*) as count1 from vms_datakey where inputkey=@ikey and tahunkey=@thnkey", conn)
                With CekCount
                    .Parameters.AddWithValue("@thnkey", thn)
                    .Parameters.AddWithValue("@ikey", cmbProd.Text)
                    conn.Open()
                End With
                Dim hslCnt As SqlClient.SqlDataReader = CekCount.ExecuteReader()
                hslCnt.Read()
                If hslCnt.HasRows Then
                    LblCount.Text = hslCnt("count1").ToString
                Else
                    LblCount.Text = "0"
                End If
                conn.Close()
            End Using

            Using CekAkurasi As SqlClient.SqlCommand = New SqlCommand("Select sum(iif(take1>0,take1,0)+iif(take2>0,take2,0)+iif(take3>0,take3,0)+iif(take4>0,take4,0)+iif(take5>0,take5,0)) as take1 from vms_ww" & thn & " where prodord=@Prod", conn)
                With CekAkurasi
                    .Parameters.AddWithValue("@Prod", cmbProd.Text)
                    conn.Open()
                End With
                Dim hslAkurasi As SqlClient.SqlDataReader = CekAkurasi.ExecuteReader()
                hslAkurasi.Read()
                If hslAkurasi.HasRows Then
                    LblTake.Text = hslAkurasi("take1").ToString
                End If
                conn.Close()
            End Using
        End If
    End Sub

    Private Sub TxtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TxtTiket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTiket.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Sub LastInput()

        Using CekLast As New SqlClient.SqlCommand("select TOP 1 tiket1 as Tiket, Material, take1 as Count,  " &
                                                   "iif(prodord='',batch_mtl, prodord) as [No Batch], idinput1 as [ID Admin]  from vms_ww" & thn & " where tiket1=@tik and idinput1=@id order by trx desc", conn)
                conn.Open()
                With CekLast
                    .Parameters.AddWithValue("@tik", txtPrefix.Text & txtTiket.Text)
                    .Parameters.AddWithValue("@id", txtAdmin.Text)
                End With

                Using sda As New SqlClient.SqlDataAdapter(CekLast)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        With DataGridView1
                            .DataSource = dt
                            .Columns(0).Width = 100
                            .Columns(1).Width = 305
                            .Columns(2).Width = 50
                            .Columns(3).Width = 100
                            .Columns(4).Width = 50
                            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        End With
                    End Using
                End Using
                conn.Close()
            End Using


    End Sub

    Sub AllInput()
        Using CekLast As New SqlClient.SqlCommand("select [Type],Material,[OrdProd],[TotalStock],[Total Count],[No. Tiket],[Lokasi],[Input By],[GAP], trx " &
                                                    "from (select vms_tblw2w.kelas as [Type],vms_tblw2w.Material," &
                                                    "vms_tblw2w.prodord1 as [OrdProd]," &
                                                    "sum(vms_tblw2w.unres) as [TotalStock], A.[Total Count],A.[No. Tiket],A.[Input By],A.[Lokasi]," &
                                                    "sum(A.[Total Count]-unres) As [GAP], vms_tblw2w.tahun, A.trx from vms_tblw2w LEFT JOIN " &
                                                    "(select material, prodord,batch_prod, " &
                                                    "sum(isnull(take1, 0) + isnull(take2, 0) + isnull(take3, 0) + isnull(take4, 0) + isnull(take5, 0)) As [Total Count], " &
                                                    "CONCAT(iif(tiket1='','',(tiket1+'['+Right(str(take1),len(take1)))+']'), " &
                                                    "iif(tiket2='','',(','+tiket2+'['+Right(str(take2),len(take2)))+']'), " &
                                                    "iif(tiket3='','',(','+tiket3+'['+Right(str(take3),len(take3)))+']'), " &
                                                    "iif(tiket4='','',(','+tiket4+'['+Right(str(take4),len(take4)))+']'), " &
                                                    "iif(tiket5='','',(','+tiket5+'['+Right(str(take5),len(take5)))+']')) as [No. Tiket], " &
                                                    "CONCAT(iif(idinput1='','',(idinput1)), " &
                                                    "iif(idinput2='','',(','+idinput2)), " &
                                                    "iif(idinput3='','',(','+idinput3)), " &
                                                    "iif(idinput4='','',(','+idinput4)), " &
                                                    "iif(idinput5='','',(','+idinput5))) as [Input By],type, " &
                                                    "CONCAT(IIf(lok1 ='','',(lok1))," &
                                                    "IIf(lok2 ='','',(','+lok2))," &
                                                    "IIf(lok3 ='','',(','+lok3))," &
                                                    "IIf(lok4 ='','',(','+lok4))," &
                                                    "IIf(lok5 ='','',(','+lok5))) as [Lokasi],trx " &
                                                    "from vms_ww" & thn & " group by material, batch_prod,tiket1,tiket2,tiket3,tiket4,tiket5, " &
                                                    "idinput1,idinput2,idinput3,idinput4,idinput5,take1,take2,take3,take4,take5,prodord,type,lok1,lok2,lok3,lok4,lok5,trx) A " &
                                                    "on vms_tblw2w.material = A.Material and vms_tblw2w.prodord1 = A.prodord  " &
                                                    "group by vms_tblw2w.material,vms_tblw2w.batch,A.[Total Count],A.[No. Tiket],A.[Input By],A.[Lokasi],A.trx,vms_tblw2w.kelas,vms_tblw2w.prodord1,vms_tblw2w.tahun) X " &
                                                    "where type in ('WIP') and tahun=" & thn & " and [No. Tiket] <> '' order by trx desc", conn)
            conn.Open()

            Using sda As New SqlClient.SqlDataAdapter(CekLast)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    With DataGridView2
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .Columns(3).Visible = False
                        .Columns(8).Visible = False
                        .Columns(9).Visible = False
                        .Columns(1).Width = 170
                        .Columns(2).Width = 75
                        .Columns(4).Width = 50
                        .Columns(5).Width = 210
                        .Columns(6).Width = 210
                        .Columns(7).Width = 75
                        .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtAdmin.Text = "" Then
            MessageBox.Show("ID Admin harus diisi!", "Appl W2W", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAdmin.Select()
            Exit Sub
        End If

        If Len(txtTiket.Text) < 6 Then
            MessageBox.Show("No Ticket harus 6 Digit!", "Appl W2W", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTiket.Select()
            Exit Sub
        End If

        If Val(LblCount.Text) > 5 Then
            MessageBox.Show("Maksimum Tiket untuk per Batch/Prod. Order Dibatasi 5 Tiket, Silahkan Hub. Admin Untuk penambahan Slot Input Datanya", "Appl W2W", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        Using CekKartu As SqlClient.SqlCommand = New SqlCommand("Select * from vms_datakey where ticketkey=@tik and tahunkey=@th", conn)
            With CekKartu
                .Parameters.AddWithValue("@th", thn)
                .Parameters.AddWithValue("@tik", txtPrefix.Text & txtTiket.Text)
                conn.Open()
            End With
            Dim hslKartu As SqlClient.SqlDataReader = CekKartu.ExecuteReader()
            hslKartu.Read()
            If hslKartu.HasRows Then
                MessageBox.Show("Nomor Tiket [" & txtPrefix.Text & txtTiket.Text & "] duplikasi, silahkan check kembali", "Appl W2W", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                conn.Close()
                Exit Sub
            Else
                Dim x As Integer = Val(LblCount.Text) + 1

                Dim Msg, Style, Title, Response
                Msg = "Yakin data sudah benar?"    ' Define message.
                Style = vbYesNo Or vbQuestion Or vbDefaultButton2    ' Define buttons.
                Title = "Confirmation"    ' Define title.
                ' Display message.
                Response = MsgBox(Msg, Style, Title)

                'Script Simpan untuk WIP

                If chkWIP.Checked = True Then
                    If Val(LblCount.Text) < 1 Then
                        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("Insert into vms_ww" & thn & " (trx,material,prodord,batch_prod,type,uom,take1,sta1,tiket1," &
                                                  "lok1,idinput1,idcount1,remark1,akurasi) values(@a0,@a1,@a2,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)", conn)

                            With cmdSave
                                .Parameters.AddWithValue("@a0", Format(Now, "yyMMddhhmmss"))
                                .Parameters.AddWithValue("@a1", cmbMaterial.Text)
                                .Parameters.AddWithValue("@a2", cmbProd.Text)
                                .Parameters.AddWithValue("@a3", cmbBatch.Text)
                                .Parameters.AddWithValue("@a4", "WIP")
                                .Parameters.AddWithValue("@a5", "EA")
                                .Parameters.AddWithValue("@a6", txtQty.Text)
                                .Parameters.AddWithValue("@a7", txtStatus.Text)
                                .Parameters.AddWithValue("@a8", txtPrefix.Text & txtTiket.Text)
                                .Parameters.AddWithValue("@a9", txtLokasi.Text)
                                .Parameters.AddWithValue("@a10", txtAdmin.Text)
                                .Parameters.AddWithValue("@a11", txtChecker.Text)
                                .Parameters.AddWithValue("@a12", txtRemarks.Text)
                                .Parameters.AddWithValue("@a13", LblAkurasi.Text)
                            End With
                            If Response = vbYes Then
                                cmdSave.ExecuteNonQuery()

                                Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("Insert into vms_datakey(tahunkey,inputkey,ticketkey,kolomkey) values(@a0,@a1,@a2,@a3)", conn)
                                    With cmdTiket
                                        .Parameters.AddWithValue("@a0", thn)
                                        .Parameters.AddWithValue("@a1", cmbProd.Text)
                                        .Parameters.AddWithValue("@a2", txtPrefix.Text & txtTiket.Text)
                                        .Parameters.AddWithValue("@a3", x)
                                        .ExecuteNonQuery()
                                    End With
                                End Using

                            Else
                                conn.Close()
                                Exit Sub
                            End If
                        End Using
                    Else
                        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("update vms_ww" & thn & " set take" & x & "=@a1, sta" & x & "=@a2, tiket" & x & "=@a3, lok" & x & "=@a4, idinput" & x & "=@a5," &
                                                                            "idcount" & x & "=@a6, remark" & x & "=@a7, akurasi=@a8 where prodord=@a9", conn)

                            With cmdSave
                                .Parameters.AddWithValue("@a1", txtQty.Text)
                                .Parameters.AddWithValue("@a2", txtStatus.Text)
                                .Parameters.AddWithValue("@a3", txtPrefix.Text & txtTiket.Text)
                                .Parameters.AddWithValue("@a4", txtLokasi.Text)
                                .Parameters.AddWithValue("@a5", txtAdmin.Text)
                                .Parameters.AddWithValue("@a6", txtChecker.Text)
                                .Parameters.AddWithValue("@a7", txtRemarks.Text)
                                .Parameters.AddWithValue("@a8", LblAkurasi.Text)
                                .Parameters.AddWithValue("@a9", cmbProd.Text)
                            End With
                            If Response = vbYes Then
                                cmdSave.ExecuteNonQuery()

                                Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("Insert into vms_datakey(tahunkey,inputkey,ticketkey,kolomkey) values(@a0,@a1,@a2,@a3)", conn)
                                    With cmdTiket
                                        .Parameters.AddWithValue("@a0", thn)
                                        .Parameters.AddWithValue("@a1", cmbProd.Text)
                                        .Parameters.AddWithValue("@a2", txtPrefix.Text & txtTiket.Text)
                                        .Parameters.AddWithValue("@a3", x)
                                        .ExecuteNonQuery()
                                    End With
                                End Using

                            Else
                                conn.Close()
                                Exit Sub
                            End If
                        End Using
                    End If
                    conn.Close()
                    LastInput()
                    cmbProd.Select()
                End If

                'Script Simpan untuk RM

                If chkRM.Checked = True Then
                    If Val(LblCount.Text) < 1 Then
                        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("Insert into vms_ww" & thn & " (trx,material,batch_mtl,type,uom,take1,sta1,tiket1," &
                                                  "lok1,idinput1,idcount1,remark1,akurasi) values(@a0,@a1,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)", conn)

                            With cmdSave
                                .Parameters.AddWithValue("@a0", Format(Now, "yyMMddhhmmss"))
                                .Parameters.AddWithValue("@a1", cmbMaterial.Text)
                                .Parameters.AddWithValue("@a3", cmbBatch.Text)
                                .Parameters.AddWithValue("@a4", "RM")
                                .Parameters.AddWithValue("@a5", "EA")
                                .Parameters.AddWithValue("@a6", txtQty.Text)
                                .Parameters.AddWithValue("@a7", txtStatus.Text)
                                .Parameters.AddWithValue("@a8", txtPrefix.Text & txtTiket.Text)
                                .Parameters.AddWithValue("@a9", txtLokasi.Text)
                                .Parameters.AddWithValue("@a10", txtAdmin.Text)
                                .Parameters.AddWithValue("@a11", txtChecker.Text)
                                .Parameters.AddWithValue("@a12", txtRemarks.Text)
                                .Parameters.AddWithValue("@a13", LblAkurasi.Text)
                            End With
                            If Response = vbYes Then
                                cmdSave.ExecuteNonQuery()

                                Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("Insert into vms_datakey(tahunkey,inputkey,ticketkey,kolomkey) values(@a0,@a1,@a2,@a3)", conn)
                                    With cmdTiket
                                        .Parameters.AddWithValue("@a0", thn)
                                        .Parameters.AddWithValue("@a1", cmbBatch.Text)
                                        .Parameters.AddWithValue("@a2", txtPrefix.Text & txtTiket.Text)
                                        .Parameters.AddWithValue("@a3", x)
                                        .ExecuteNonQuery()
                                    End With
                                End Using

                            Else
                                conn.Close()
                                Exit Sub
                            End If
                        End Using
                    Else
                        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("update vms_ww" & thn & " set take" & x & "=@a1, sta" & x & "=@a2, tiket" & x & "=@a3, lok" & x & "=@a4, idinput" & x & "=@a5," &
                                                                            "idcount" & x & "=@a6, remark" & x & "=@a7, akurasi=@a8 where batch=@a9", conn)

                            With cmdSave
                                .Parameters.AddWithValue("@a1", txtQty.Text)
                                .Parameters.AddWithValue("@a2", txtStatus.Text)
                                .Parameters.AddWithValue("@a3", txtPrefix.Text & txtTiket.Text)
                                .Parameters.AddWithValue("@a4", txtLokasi.Text)
                                .Parameters.AddWithValue("@a5", txtAdmin.Text)
                                .Parameters.AddWithValue("@a6", txtChecker.Text)
                                .Parameters.AddWithValue("@a7", txtRemarks.Text)
                                .Parameters.AddWithValue("@a8", LblAkurasi.Text)
                                .Parameters.AddWithValue("@a9", cmbBatch.Text)
                            End With
                            If Response = vbYes Then
                                cmdSave.ExecuteNonQuery()

                                Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("Insert into vms_datakey(tahunkey,inputkey,ticketkey,kolomkey) values(@a0,@a1,@a2,@a3)", conn)
                                    With cmdTiket
                                        .Parameters.AddWithValue("@a0", thn)
                                        .Parameters.AddWithValue("@a1", cmbBatch.Text)
                                        .Parameters.AddWithValue("@a2", txtPrefix.Text & txtTiket.Text)
                                        .Parameters.AddWithValue("@a3", x)
                                        .ExecuteNonQuery()
                                    End With
                                End Using

                            Else
                                conn.Close()
                                Exit Sub
                            End If
                        End Using
                    End If
                    conn.Close()
                    LastInput()
                    cmbBatch.Select()
                End If

                If chkFG.Checked = True Then
                    If Val(LblCount.Text) < 1 Then
                        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("Insert into vms_ww" & thn & " (trx,material,batch_mtl,type,uom,take1,sta1,tiket1," &
                                                  "lok1,idinput1,idcount1,remark1,akurasi) values(@a0,@a1,@a3,@a4,@a5,@a6,@a7,@a8,@a9,@a10,@a11,@a12,@a13)", conn)

                            With cmdSave
                                .Parameters.AddWithValue("@a0", Format(Now, "yyMMddhhmmss"))
                                .Parameters.AddWithValue("@a1", cmbMaterial.Text)
                                .Parameters.AddWithValue("@a3", cmbBatch.Text)
                                .Parameters.AddWithValue("@a4", "RM")
                                .Parameters.AddWithValue("@a5", "EA")
                                .Parameters.AddWithValue("@a6", txtQty.Text)
                                .Parameters.AddWithValue("@a7", txtStatus.Text)
                                .Parameters.AddWithValue("@a8", txtPrefix.Text & txtTiket.Text)
                                .Parameters.AddWithValue("@a9", txtLokasi.Text)
                                .Parameters.AddWithValue("@a10", txtAdmin.Text)
                                .Parameters.AddWithValue("@a11", txtChecker.Text)
                                .Parameters.AddWithValue("@a12", txtRemarks.Text)
                                .Parameters.AddWithValue("@a13", LblAkurasi.Text)
                            End With
                            If Response = vbYes Then
                                cmdSave.ExecuteNonQuery()

                                Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("Insert into vms_datakey(tahunkey,inputkey,ticketkey,kolomkey) values(@a0,@a1,@a2,@a3)", conn)
                                    With cmdTiket
                                        .Parameters.AddWithValue("@a0", thn)
                                        .Parameters.AddWithValue("@a1", cmbBatch.Text)
                                        .Parameters.AddWithValue("@a2", txtPrefix.Text & txtTiket.Text)
                                        .Parameters.AddWithValue("@a3", x)
                                        .ExecuteNonQuery()
                                    End With
                                End Using

                            Else
                                conn.Close()
                                Exit Sub
                            End If
                        End Using
                    Else
                        Using cmdSave As SqlClient.SqlCommand = New SqlCommand("update vms_ww" & thn & " set take" & x & "=@a1, sta" & x & "=@a2, tiket" & x & "=@a3, lok" & x & "=@a4, idinput" & x & "=@a5," &
                                                                            "idcount" & x & "=@a6, remark" & x & "=@a7, akurasi=@a8 where batch=@a9", conn)

                            With cmdSave
                                .Parameters.AddWithValue("@a1", txtQty.Text)
                                .Parameters.AddWithValue("@a2", txtStatus.Text)
                                .Parameters.AddWithValue("@a3", txtPrefix.Text & txtTiket.Text)
                                .Parameters.AddWithValue("@a4", txtLokasi.Text)
                                .Parameters.AddWithValue("@a5", txtAdmin.Text)
                                .Parameters.AddWithValue("@a6", txtChecker.Text)
                                .Parameters.AddWithValue("@a7", txtRemarks.Text)
                                .Parameters.AddWithValue("@a8", LblAkurasi.Text)
                                .Parameters.AddWithValue("@a9", cmbBatch.Text)
                            End With
                            If Response = vbYes Then
                                cmdSave.ExecuteNonQuery()

                                Using cmdTiket As SqlClient.SqlCommand = New SqlCommand("Insert into vms_datakey(tahunkey,inputkey,ticketkey,kolomkey) values(@a0,@a1,@a2,@a3)", conn)
                                    With cmdTiket
                                        .Parameters.AddWithValue("@a0", thn)
                                        .Parameters.AddWithValue("@a1", cmbBatch.Text)
                                        .Parameters.AddWithValue("@a2", txtPrefix.Text & txtTiket.Text)
                                        .Parameters.AddWithValue("@a3", x)
                                        .ExecuteNonQuery()
                                    End With
                                End Using

                            Else
                                conn.Close()
                                Exit Sub
                            End If
                        End Using
                    End If
                    conn.Close()
                    LastInput()
                    cmbBatch.Select()
                End If


            End If

        End Using

        If ChkAuto.Checked = True Then
            Dim No As Integer = Val(txtTiket.Text) + 1

            Select Case No
                Case 1 To 9
                    txtTiket.Text = "00000" & No.ToString
                Case 10 To 99
                    txtTiket.Text = "0000" & No.ToString
                Case 100 To 999
                    txtTiket.Text = "000" & No.ToString
                Case 1000 To 9999
                    txtTiket.Text = "00" & No.ToString
                Case 10000 To 99999
                    txtTiket.Text = "0" & No.ToString
                Case 100000 To 999999
                    txtTiket.Text = No.ToString
            End Select


        End If
        ClearDisplay()

    End Sub

    Sub ClearDisplay()
        cmbProd.Text = ""
        cmbMaterial.Text = ""
        cmbBatch.Text = ""
        txtQty.Text = ""
        txtLokasi.Text = ""
        txtStatus.Text = "OK"
        txtRemarks.Text = ""
    End Sub
    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblCount.Text = "0"
        LblStock.Text = "0"
        LblTake.Text = "0"
        LastInput()
        AllInput()
    End Sub

    Private Sub CmbProd_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtQty.Select()
        End If
    End Sub

    Private Sub TxtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtLokasi.Select()

            If Val(LblStock.Text) = (Val(LblCount.Text) + Val(txtQty.Text)) Then
                LblAkurasi.Text = "AKURAT"
            Else
                LblAkurasi.Text = "INVESTIGASI"
            End If
        End If
    End Sub

    Private Sub TxtLokasi_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLokasi.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtStatus.Select()
        End If
    End Sub

    Private Sub TxtStatus_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemarks.Select()
        End If
    End Sub

    Private Sub TxtRemarks_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtChecker.Select()
        End If
    End Sub

    Private Sub TxtChecker_KeyDown(sender As Object, e As KeyEventArgs) Handles txtChecker.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtTiket.Select()
        End If
    End Sub

    Private Sub TxtTiket_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTiket.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Select()
        End If
    End Sub

    Private Sub BtnSave_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSave.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.PerformClick()
        End If
    End Sub

    Private Sub TxtAdmin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAdmin.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbProd.Select()
        End If
    End Sub

    Private Sub TxtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub

    Private Sub TxtQty_Leave(sender As Object, e As EventArgs) Handles txtQty.Leave
        If Val(LblStock.Text) = (Val(LblCount.Text) + Val(txtQty.Text)) Then
            LblAkurasi.Text = "AKURAT"
        Else
            LblAkurasi.Text = "INVESTIGASI"
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Using CekLast As New SqlClient.SqlCommand("select [Type],Material,[OrdProd],[TotalStock],[Total Count],[No. Tiket],[Lokasi],[Input By],[GAP], trx " &
                                                    "from (select vms_tblw2w.kelas as [Type],vms_tblw2w.Material," &
                                                    "vms_tblw2w.prodord1 as [OrdProd]," &
                                                    "sum(vms_tblw2w.unres) as [TotalStock], A.[Total Count],A.[No. Tiket],A.[Input By],A.[Lokasi]," &
                                                    "sum(A.[Total Count]-unres) As [GAP], vms_tblw2w.tahun, A.trx from vms_tblw2w LEFT JOIN " &
                                                    "(select material, prodord,batch_prod, " &
                                                    "sum(isnull(take1, 0) + isnull(take2, 0) + isnull(take3, 0) + isnull(take4, 0) + isnull(take5, 0)) As [Total Count], " &
                                                    "CONCAT(iif(tiket1='','',(tiket1+'['+Right(str(take1),len(take1)))+']'), " &
                                                    "iif(tiket2='','',(','+tiket2+'['+Right(str(take2),len(take2)))+']'), " &
                                                    "iif(tiket3='','',(','+tiket3+'['+Right(str(take3),len(take3)))+']'), " &
                                                    "iif(tiket4='','',(','+tiket4+'['+Right(str(take4),len(take4)))+']'), " &
                                                    "iif(tiket5='','',(','+tiket5+'['+Right(str(take5),len(take5)))+']')) as [No. Tiket], " &
                                                    "CONCAT(iif(idinput1='','',(idinput1)), " &
                                                    "iif(idinput2='','',(','+idinput2)), " &
                                                    "iif(idinput3='','',(','+idinput3)), " &
                                                    "iif(idinput4='','',(','+idinput4)), " &
                                                    "iif(idinput5='','',(','+idinput5))) as [Input By],type, " &
                                                    "CONCAT(IIf(lok1 ='','',(lok1))," &
                                                    "IIf(lok2 ='','',(','+lok2))," &
                                                    "IIf(lok3 ='','',(','+lok3))," &
                                                    "IIf(lok4 ='','',(','+lok4))," &
                                                    "IIf(lok5 ='','',(','+lok5))) as [Lokasi],trx " &
                                                    "from vms_ww" & thn & " group by material, batch_prod,tiket1,tiket2,tiket3,tiket4,tiket5, " &
                                                    "idinput1,idinput2,idinput3,idinput4,idinput5,take1,take2,take3,take4,take5,prodord,type,lok1,lok2,lok3,lok4,lok5,trx) A " &
                                                    "on vms_tblw2w.material = A.Material and vms_tblw2w.prodord1 = A.prodord  " &
                                                    "group by vms_tblw2w.material,vms_tblw2w.batch,A.[Total Count],A.[No. Tiket],A.[Input By],A.[Lokasi],A.trx,vms_tblw2w.kelas,vms_tblw2w.prodord1,vms_tblw2w.tahun) X " &
                                                    "where type in ('WIP') and tahun=" & thn & " and [No. Tiket] <> '' and OrdProd like @prod order by trx desc", conn)

            CekLast.Parameters.AddWithValue("@prod", TextBox1.Text & "%")
            conn.Open()
            Using sda As New SqlClient.SqlDataAdapter(CekLast)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    With DataGridView2
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .Columns(3).Visible = False
                        .Columns(8).Visible = False
                        .Columns(9).Visible = False
                        .Columns(1).Width = 170
                        .Columns(2).Width = 75
                        .Columns(4).Width = 50
                        .Columns(5).Width = 210
                        .Columns(6).Width = 210
                        .Columns(7).Width = 75
                        .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                End Using
            End Using
            conn.Close()
        End Using
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Using CekAKtif As SqlClient.SqlCommand = New SqlCommand("Select kondisi from vms_datatimer where id='1'", conn)
            conn.Open()
            Dim AktifSta As SqlClient.SqlDataReader = CekAKtif.ExecuteReader()
            AktifSta.Read()

            If AktifSta("kondisi").ToString = "OFF" Then
                btnSave.Enabled = False
                btnSave.BackColor = Color.Gray
                FormEdit.btnUpdate.Enabled = False
                FormEdit.btnUpdate.BackColor = Color.Gray
            Else
                btnSave.Enabled = True
                btnSave.BackColor = Color.Turquoise
                FormEdit.btnUpdate.Enabled = True
                FormEdit.btnUpdate.BackColor = Color.Turquoise
            End If

            conn.Close()
        End Using
    End Sub

    Private Sub CmbBatch_TextChanged(sender As Object, e As EventArgs) Handles cmbBatch.TextChanged

        If chkRM.Checked = True Or chkFG.Checked = True Then
            Using CekAkurasi As SqlClient.SqlCommand = New SqlCommand("Select * From vms_tblw2w Where batch=@batch", conn)
                With CekAkurasi
                    .Parameters.AddWithValue("@batch", cmbBatch.Text)
                    conn.Open()
                End With
                Dim hslAkurasi As SqlClient.SqlDataReader = CekAkurasi.ExecuteReader()
                hslAkurasi.Read()
                If hslAkurasi.HasRows Then
                    cmbMaterial.Text = hslAkurasi("material").ToString
                End If
                conn.Close()
            End Using

            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("Select * from vms_tblw2w where and tahun=@thn and batch=@batch", conn)
                With CekWIP
                    .Parameters.AddWithValue("@thn", thn)
                    .Parameters.AddWithValue("@batch", cmbBatch.Text)
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    cmbMaterial.Text = hslWIP("material").ToString
                    LblStock.Text = hslWIP("unres").ToString
                End If
                conn.Close()
            End Using

            Using CekCount As SqlClient.SqlCommand = New SqlCommand("Select Count(*) as count1 from vms_datakey where inputkey=@ikey and tahunkey=@thnkey", conn)
                With CekCount
                    .Parameters.AddWithValue("@thnkey", thn)
                    .Parameters.AddWithValue("@ikey", cmbBatch.Text)
                    conn.Open()
                End With
                Dim hslCnt As SqlClient.SqlDataReader = CekCount.ExecuteReader()
                hslCnt.Read()
                If hslCnt.HasRows Then
                    LblCount.Text = hslCnt("count1").ToString
                Else
                    LblCount.Text = "0"
                End If
                conn.Close()
            End Using

            Using CekAkurasi As SqlClient.SqlCommand = New SqlCommand("Select sum(iif(take1>0,take1,0)+iif(take2>0,take2,0)+iif(take3>0,take3,0)+iif(take4>0,take4,0)+iif(take5>0,take5,0)) as take1 from vms_ww" & thn & " where batch=@batch", conn)
                With CekAkurasi
                    .Parameters.AddWithValue("@batch", cmbBatch.Text)
                    conn.Open()
                End With
                Dim hslAkurasi As SqlClient.SqlDataReader = CekAkurasi.ExecuteReader()
                hslAkurasi.Read()
                If hslAkurasi.HasRows Then
                    LblTake.Text = hslAkurasi("take1").ToString
                End If
                conn.Close()
            End Using
        End If

    End Sub
End Class