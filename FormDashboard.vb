Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class FormDashboard
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)
    Dim thn As String = Format(Now, "yyyy")


    Sub ChkWIP()
        Using CekWIP As SqlClient.SqlCommand = New SqlCommand("Select count(*) as [WIP] from vms_tblw2w where kelas='WIP' and tahun=@thn", conn)
            With CekWIP
                .Parameters.AddWithValue("@thn", thn)
                conn.Open()
            End With
            Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
            hslWIP.Read()
            If hslWIP.HasRows Then
                LblWIP1.Text = hslWIP("WIP").ToString
            End If
            conn.Close()
        End Using

        Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select count(*) as [WIP] from vms_ww" & thn & " where prodord in (select prodord1 from vms_tblw2w where tahun=@thn and kelas='WIP')", conn)
            With CekWIP
                .Parameters.AddWithValue("@thn", thn)
                conn.Open()
            End With
            Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
            hslWIP.Read()
            If hslWIP.HasRows Then
                LblWIP2.Text = hslWIP("WIP").ToString
            End If
            conn.Close()
        End Using

        If Val(LblWIP2.Text) > 10 Then
            Dim Total As Integer = Val(LblWIP2.Text) / Val(LblWIP1.Text) * 100
            CBWIPInput.Value = Total
            CBWIPInput.Text = Total.ToString & "%"


            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select count(*) as [WIP] from vms_ww" & thn & " where prodord in 
                                                                  (select prodord1 from vms_tblw2w where tahun=@thn and kelas='WIP') and akurasi='AKURAT'", conn)
                With CekWIP
                    .Parameters.AddWithValue("@thn", thn)
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    LblWIP3.Text = hslWIP("WIP").ToString
                End If
                conn.Close()
            End Using

            Dim WIPakurasi As Integer = Val(LblWIP1.Text) / Val(LblWIP3.Text) * 100

            CPWIPAkurat.Value = WIPakurasi
            CPWIPAkurat.Text = WIPakurasi.ToString & "%"

            Dim WIPInv As Integer = Total - WIPakurasi

            CPWIPInvt.Value = WIPInv
            CPWIPInvt.Text = WIPInv.ToString & "%"


            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select sum(Total) as [TotalFG] from (
                                                                   select prodord1,sum(unitcos*unres) as [Total] from vms_tblw2w 
                                                                   where tahun=@thn and kelas='WIP' group by prodord1) A", conn)
                With CekWIP
                    .Parameters.AddWithValue("@thn", thn)
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    LblWIP4.Text = hslWIP("TotalFG").ToString
                End If
                conn.Close()
            End Using

            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select type, sum(unitcos* [Total Count]) as Grand from (
                                select type,unitcos,prodord, sum(isnull(take1,0)+isnull(take2,0)+isnull(take3,0)+isnull(take4,0)+isnull(take5,0)) as [Total Count] 
                                from vms_ww" & thn & " inner join vms_tblw2w on prodord = prodord1 
                                group by unitcos,prodord,type 
                                ) A where type ='WIP' group by type", conn)
                With CekWIP
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    Dim GT As Integer = hslWIP("Grand") - Val(LblWIP4.Text)
                    WIPCurr.Text = FormatCurrency(GT, , , TriState.True, TriState.True)
                End If
                conn.Close()
            End Using

        End If
        LblWIP1.Text = FormatNumber(LblWIP1.Text, 0)
    End Sub

    Sub ChkRM()
        Using CekWIP As SqlClient.SqlCommand = New SqlCommand("Select count(*) as [RM] from vms_tblw2w where kelas='RM' and tahun=@thn", conn)
            With CekWIP
                .Parameters.AddWithValue("@thn", thn)
                conn.Open()
            End With
            Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
            hslWIP.Read()
            If hslWIP.HasRows Then
                LblRM1.Text = hslWIP("RM").ToString
            End If
            conn.Close()
        End Using

        Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select count(*) as [RM] from vms_ww" & thn & " where batch_mtl in (select batch from vms_tblw2w where tahun=@thn and kelas='RM')", conn)
            With CekWIP
                .Parameters.AddWithValue("@thn", thn)
                conn.Open()
            End With
            Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
            hslWIP.Read()
            If hslWIP.HasRows Then
                LblRM2.Text = hslWIP("RM").ToString
            End If
            conn.Close()
        End Using

        If Val(LblRM2.Text) > 10 Then
            Dim Total As Integer = Val(LblRM2.Text) / Val(LblRM1.Text) * 100
            CPRMInput.Value = Total
            CPRMInput.Text = Total.ToString & "%"


            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select count(*) as [RM] from vms_ww" & thn & " where batch_mtl in (select batch from vms_tblw2w where tahun=@thn and kelas='RM') and akurasi='AKURAT'", conn)
                With CekWIP
                    .Parameters.AddWithValue("@thn", thn)
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    LblRM3.Text = hslWIP("RM").ToString
                End If
                conn.Close()
            End Using

            Dim WIPakurasi As Integer = Val(LblRM3.Text) / Val(LblRM1.Text) * 100

            CPRMAkurat.Value = WIPakurasi
            CPRMAkurat.Text = WIPakurasi.ToString & "%"

            Dim WIPInv As Integer = Total - WIPakurasi

            CPRMInvt.Value = WIPInv
            CPRMInvt.Text = WIPInv.ToString & "%"


            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select sum(Total) as [TotalFG] from (
                                                                   select batch,sum(unitcos*unres) as [Total] from vms_tblw2w 
                                                                   where tahun=@thn and kelas='RM' group by  batch) A", conn)
                With CekWIP
                    .Parameters.AddWithValue("@thn", thn)
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    LblRM4.Text = hslWIP("TotalFG").ToString
                End If
                conn.Close()
            End Using

            Using CekWIP As SqlClient.SqlCommand = New SqlCommand("select type, sum(unitcos* [Total Count]) as Grand from (
                                select type,unitcos,batch_mtl, sum(isnull(take1,0)+isnull(take2,0)+isnull(take3,0)+isnull(take4,0)+isnull(take5,0)) as [Total Count] 
                                from vms_ww" & thn & " inner join vms_tblw2w on batch_mtl = batch 
                                group by unitcos,batch_mtl,type 
                                ) A where type ='RM' group by type", conn)
                With CekWIP
                    conn.Open()
                End With
                Dim hslWIP As SqlClient.SqlDataReader = CekWIP.ExecuteReader()
                hslWIP.Read()
                If hslWIP.HasRows Then
                    Dim GT As Integer = hslWIP("Grand") - Val(LblRM4.Text)
                    RMCurr.Text = FormatCurrency(GT, , , TriState.True, TriState.True)
                End If
                conn.Close()
            End Using

        End If
        LblRM1.Text = FormatNumber(LblRM1.Text, 0)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ChkWIP()
        ChkRM()
    End Sub


    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPWIPAkurat.Value = 0
        CPWIPAkurat.Text = "0%"
        CPWIPInvt.Value = 0
        CPWIPInvt.Text = "0%"
        CBWIPInput.Value = 0
        CBWIPInput.Text = "0%"
        CPFGInput.Value = 0
        CPFGInput.Text = "0%"
        CPFGAkurat.Value = 0
        CPFGAkurat.Text = "0%"
        CPFGInvt.Value = 0
        CPFGInvt.Text = "0%"
        CPRMInput.Value = 0
        CPRMInput.Text = "0%"
        CPRMAkurat.Value = 0
        CPRMAkurat.Text = "0%"
        CPRMInvt.Value = 0
        CPRMInvt.Text = "0%"

    End Sub
End Class