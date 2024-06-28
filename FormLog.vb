Imports FontAwesome.Sharp
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Public Class FormLog
    Dim ConStr As String = "Data Source=gidbnd01;Initial Catalog=OPS_PROD;User ID=S-ops_prod;Password=@Bojongso@ng200!;MultipleActiveResultSets=true"
    Dim conn As New SqlClient.SqlConnection(ConStr)
    Dim Total As String
    Private Sub FormLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub


    Sub AllRM()
        Dim thn = cmbtahun.Text
        Using CekLast As New SqlClient.SqlCommand("select [Type],Material,[BatchNbr],[TotalStock],[Total Count],[No. Tiket],[Lokasi],[Input By],[Counted By],[GAP], trx " &
                                                    "from (select vms_tblw2w.kelas as [Type],vms_tblw2w.Material," &
                                                    "vms_tblw2w.batch as [BatchNbr]," &
                                                    "sum(vms_tblw2w.unres) as [TotalStock], A.[Total Count],A.[No. Tiket],A.[Input By],A.[Counted By],A.[Lokasi]," &
                                                    "sum(A.[Total Count]-unres) As [GAP], vms_tblw2w.tahun, A.trx from vms_tblw2w LEFT JOIN " &
                                                    "(select material, batch_mtl, " &
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
                                                    "iif(idinput5='','',(','+idinput5))) as [Input By], " &
                                                    "CONCAT(iif(idcount1='','',(idcount1)), " &
                                                    "iif(idcount2='','',(','+idcount2)), " &
                                                    "iif(idcount3='','',(','+idcount3)), " &
                                                    "iif(idcount4='','',(','+idcount4)), " &
                                                    "iif(idcount5='','',(','+idcount5))) as [Counted By], type, " &
                                                    "CONCAT(IIf(lok1 ='','',(lok1))," &
                                                    "IIf(lok2 ='','',(','+lok2))," &
                                                    "IIf(lok3 ='','',(','+lok3))," &
                                                    "IIf(lok4 ='','',(','+lok4))," &
                                                    "IIf(lok5 ='','',(','+lok5))) as [Lokasi],trx " &
                                                    "from vms_ww" & thn & " group by material, batch_mtl,tiket1,tiket2,tiket3,tiket4,tiket5,idcount1,idcount2,idcount3,idcount4,idcount5, " &
                                                    "idinput1,idinput2,idinput3,idinput4,idinput5,take1,take2,take3,take4,take5,prodord,type,lok1,lok2,lok3,lok4,lok5,trx) A " &
                                                    "on vms_tblw2w.material = A.Material and vms_tblw2w.batch = A.batch_mtl  " &
                                                    "group by vms_tblw2w.material,vms_tblw2w.batch,A.[Total Count],A.[No. Tiket],A.[Input By],A.[Counted By], A.[Lokasi],A.trx,vms_tblw2w.kelas,vms_tblw2w.batch,vms_tblw2w.tahun) X " &
                                                    "where type ='" & Trim(cmbKelas.Text) & "' and tahun=" & thn & " and [No. Tiket] <> '' order by trx desc", conn)
            conn.Open()

            Using sda As New SqlClient.SqlDataAdapter(CekLast)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    With DataGridView1
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .Columns(3).Visible = False
                        .Columns(10).Visible = False
                        .Columns(1).Width = 170
                        .Columns(2).Width = 75
                        .Columns(4).Width = 50
                        .Columns(5).Width = 150
                        .Columns(6).Width = 150
                        .Columns(7).Width = 150
                        .Columns(8).Width = 150
                        .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                End Using
            End Using
            conn.Close()
        End Using
    End Sub

    Sub AllWIP()
        Dim thn = cmbtahun.Text
        Using CekLast As New SqlClient.SqlCommand("select [Type],Material,[OrdProd],[TotalStock],[Total Count],[No. Tiket],[Lokasi],[Input By],[Counted By],[GAP], trx " &
                                                    "from (select vms_tblw2w.kelas as [Type],vms_tblw2w.Material," &
                                                    "vms_tblw2w.prodord1 as [OrdProd]," &
                                                    "sum(vms_tblw2w.unres) as [TotalStock], A.[Total Count],A.[No. Tiket],A.[Input By],A.[Counted By],A.[Lokasi]," &
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
                                                    "iif(idinput5='','',(','+idinput5))) as [Input By], " &
                                                    "CONCAT(iif(idcount1='','',(idcount1)), " &
                                                    "iif(idcount2='','',(','+idcount2)), " &
                                                    "iif(idcount3='','',(','+idcount3)), " &
                                                    "iif(idcount4='','',(','+idcount4)), " &
                                                    "iif(idcount5='','',(','+idcount5))) as [Counted By], type, " &
                                                    "CONCAT(IIf(lok1 ='','',(lok1))," &
                                                    "IIf(lok2 ='','',(','+lok2))," &
                                                    "IIf(lok3 ='','',(','+lok3))," &
                                                    "IIf(lok4 ='','',(','+lok4))," &
                                                    "IIf(lok5 ='','',(','+lok5))) as [Lokasi],trx " &
                                                    "from vms_ww" & thn & " group by material, batch_prod,tiket1,tiket2,tiket3,tiket4,tiket5,idcount1,idcount2,idcount3,idcount4,idcount5, " &
                                                    "idinput1,idinput2,idinput3,idinput4,idinput5,take1,take2,take3,take4,take5,prodord,type,lok1,lok2,lok3,lok4,lok5,trx) A " &
                                                    "on vms_tblw2w.material = A.Material and vms_tblw2w.prodord1 = A.prodord  " &
                                                    "group by vms_tblw2w.material,vms_tblw2w.batch,A.[Total Count],A.[No. Tiket],A.[Input By],A.[Counted By], A.[Lokasi],A.trx,vms_tblw2w.kelas,vms_tblw2w.prodord1,vms_tblw2w.tahun) X " &
                                                    "where type ='" & Trim(cmbKelas.Text) & "' and tahun=" & thn & " and [No. Tiket] <> '' order by trx desc", conn)
            conn.Open()

            Using sda As New SqlClient.SqlDataAdapter(CekLast)
                Using dt As New DataTable()
                    sda.Fill(dt)
                    With DataGridView1
                        .DataSource = dt
                        .Columns(0).Visible = False
                        .Columns(3).Visible = False
                        .Columns(10).Visible = False
                        .Columns(1).Width = 170
                        .Columns(2).Width = 75
                        .Columns(4).Width = 50
                        .Columns(5).Width = 150
                        .Columns(6).Width = 150
                        .Columns(7).Width = 150
                        .Columns(8).Width = 150
                        .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    End With
                End Using
            End Using
            conn.Close()
        End Using
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbKelas.Text = "WIP" Then
            Using cmd As New SqlClient.SqlCommand("Select Count(*) As Total From vms_ww" & cmbtahun.Text & " Where type=@kelas", conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@kelas", cmbKelas.Text)
                conn.Open()
                Dim nts As SqlClient.SqlDataReader = cmd.ExecuteReader()
                If nts.HasRows Then
                    nts.Read()
                    Total = nts("Total").ToString
                    ProgressBar1.Maximum = Val(Total)
                    Label2.Text = "Generate Line [ 0 ] From [ " & Total & " ]"
                End If
                conn.Close()
            End Using
            AllWIP()
        Else
            Using cmd As New SqlClient.SqlCommand("Select Count(*) As Total From vms_ww" & cmbtahun.Text & " Where type=@kelas", conn)
                cmd.CommandType = CommandType.Text
                cmd.Parameters.AddWithValue("@kelas", cmbKelas.Text)
                conn.Open()
                Dim nts As SqlClient.SqlDataReader = cmd.ExecuteReader()
                If nts.HasRows Then
                    nts.Read()
                    Total = nts("Total").ToString
                    ProgressBar1.Maximum = Val(Total)
                    Label2.Text = "Generate Line [ 0 ] From [ " & Total & " ]"
                End If
                conn.Close()
            End Using
            AllRM()

        End If
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim exePath As String = Application.StartupPath()
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        Button2.Enabled = False
        For k = 0 To DataGridView1.ColumnCount - 1
            xlWorkSheet.Cells(1, k + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
            xlWorkSheet.Cells(1, k + 1) = DataGridView1.Columns(k).Name
        Next
        Dim X As Integer = 0
        For i = 0 To DataGridView1.RowCount - 1
            For j = 0 To DataGridView1.ColumnCount - 1
                xlWorkSheet.Cells(i + 2, j + 1).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter
                xlWorkSheet.Cells(i + 2, j + 1) =
                DataGridView1(j, i).Value.ToString()
            Next
            X = X + 1
            Label2.Text = "Generate Line [ " & X.ToString() & " ] From [ " & Total & " ]"
            ProgressBar1.Value = X
        Next

        xlApp.DisplayAlerts = False
        xlApp.Visible = True
        Button2.Enabled = True
        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
    End Sub
End Class