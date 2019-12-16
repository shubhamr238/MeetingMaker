Imports System.Data.OleDb
Public Class frmMeeting
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Private cn As OleDbConnection
    Private Sub frmMeeting_Load() Handles MyBase.Load
        For i As Integer = 1 To 5
            cboDuration.Items.Add(i)
        Next
        cboDuration.SelectedIndex = 1
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpTime.Format = DateTimePickerFormat.Custom
        dbconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Work\Meeting Maker\prjMeetingMaker\Data\Data.mdb"
        dtpDate.CustomFormat = "dd/MM/yy"
        dtpTime.CustomFormat = "HH:mm"
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Work\Meeting Maker\prjMeetingMaker\Data\Data.mdb")
        loaddata()
        loadVenu()
    End Sub
    Private Sub loaddata()
        Dim sql As String
        sql = "select ExecutiveID,Name from Executive_Details"
        Try
            cn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(sql, cn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                lbExecutive.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            MessageBox.Show("Invalid Operation")
            cn.Close()
        End Try
        cn.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cn.Close()
        Me.Hide()
    End Sub

    Private Sub btnSelect_Click() Handles btnSelect.Click
        Try
            lbSelect.Items.Add(lbExecutive.SelectedItem)
            lbExecutive.Items.Remove(lbExecutive.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("Not Possible")
        End Try


    End Sub

    Private Sub btnDeselect_Click() Handles btnDeselect.Click
        Try
            lbExecutive.Items.Add(lbSelect.SelectedItem)
            lbSelect.Items.Remove(lbSelect.SelectedItem)
        Catch ex As Exception
            MessageBox.Show("Not Possible")
        End Try
    End Sub
    Private Sub btnArrange_Click() Handles btnArrange.Click
        If availability() Then
            fillExecutiveDiary()
            fillMeeting()
            fillMeetingMap()
            MsgBox("Sucessful")
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            frmMain.Meeting_MapTableAdapter.Fill(frmMain.DataDataSet4.Meeting_Map)
            frmMain.Executive_DiaryTableAdapter1.Fill(frmMain.DataDataSet3.Executive_Diary)
            frmMain.MeetingTableAdapter.Fill(frmMain.DataDataSet2.Meeting)
            frmMain.Executive_DiaryTableAdapter.Fill(frmMain.DataDataSet1.Executive_Diary)
            frmMain.Executive_DetailsTableAdapter.Fill(frmMain.DataDataSet.Executive_Details)
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Else
            MsgBox("Meeting Cannot Be Arranged!!")
        End If

    End Sub
    Function availability() As Boolean
        cn.Close()
        '''''''''''DATE TIME CALC''''''''''
        Dim s As Integer
        s = cboDuration.SelectedItem
        Dim frm1 As DateTime
        frm1 = dtpTime.Text
        Dim hh As Integer
        Dim mm As Integer
        hh = frm1.Hour + s
        mm = frm1.Minute
        If (hh >= 23) Then
            hh = hh - 23
        End If
        Dim tto As String
        tto = CType(hh, String) & ":" & CType(mm, String)
        'MsgBox(tto)
        'MsgBox(hh)
        ''''''''''''''''''''''''''''''''''''''
        'Variables of time and date
        Dim frm As String
        frm = dtpTime.Text
        Dim day As String
        day = dtpDate.Text
        'MsgBox(frm)
        'MsgBox(day)

        '*******************************************************************
        Try
            Dim avl1 As String
            cn.Open()
            For Each i As String In lbSelect.Items
                avl1 = "select * from Executive_Diary where ExecutiveId= " & i & " and Working_Date=#" & day & "#;"
                'avl = "select * from Executive_Diary"
                'MsgBox(avl1)
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand(avl1, cn)
                Dim dr As OleDbDataReader
                dr = cmd.ExecuteReader()
                If (dr.Read()) Then


                    Try
                        Dim avl As String
                        Dim cmd1 As OleDbCommand
                        Dim dr1 As OleDbDataReader
                        avl = "select * from Executive_Diary where ExecutiveId= " & i & " and Working_Date=#" & day & "# and (From<#" & frm & "# and To<#" & frm & "#) or (From>#" & tto & "# and To>#" & tto & "#);"
                        'avl = "select * from Executive_Diary"
                        'MsgBox(avl)
                        cmd1 = New OleDbCommand(avl, cn)
                        dr1 = cmd.ExecuteReader()
                        If (dr1.Read()) Then
                            Continue For
                        Else
                            cn.Close()
                            Return False
                        End If
                        'MsgBox(dr.GetValue(0))

                        cn.Close()
                        Return True
                    Catch ex As Exception
                        MessageBox.Show("Not Possible")
                        cn.Close()
                        Return False
                    End Try
                    cn.Close()


                Else
                    cn.Close()
                    Return True
                End If
                'MsgBox(dr.GetValue(0))
            Next
            cn.Close()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
            Return False
        End Try
        '*******************************************************************

    End Function

    Private Sub btnInfo_Click() Handles btnInfo.Click
        Dim id As String
        id = lbExecutive.SelectedItem
        Dim sql As String
        sql = "select * from Executive_Details where ExecutiveID=" & id & ";"
        Try
            cn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(sql, cn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            dr.Read()
            MsgBox("Executive ID: " & dr.GetValue(0) & vbCr & "Name: " & dr.GetValue(1) & vbCr & "Rank: " & dr.GetValue(2) & vbCr & "Email: " & dr.GetValue(3) & vbCr & "Contact No.: " & dr.GetValue(4) & vbCr & "Address: " & dr.GetValue(5))
            cn.Close()
        Catch ex As Exception
            MessageBox.Show("Please Choose Correctly!")
            cn.Close()
        End Try
        cn.Close()
    End Sub
    Public Sub fillExecutiveDiary()
        '''''''''''DATE TIME CALC''''''''''
        Dim s As Integer
        s = cboDuration.SelectedItem
        Dim frm1 As DateTime
        frm1 = dtpTime.Text
        Dim hh As Integer
        Dim mm As Integer
        hh = frm1.Hour + s
        mm = frm1.Minute
        If (hh >= 23) Then
            hh = hh - 23
        End If
        Dim tto As String
        tto = CType(hh, String) & ":" & CType(mm, String)
        'MsgBox(tto)
        'MsgBox(hh)
        ''''''''''''''''''''''''''''''''''''''
        For Each i As String In lbSelect.Items
            Try
                Dim sql As String
                sql = "insert into Executive_Diary(ExecutiveID,Working_Date,[From],[To],Details) values ('" & i & "', '" & dtpDate.Text & "','" & dtpTime.Text & "','" & tto & "','" & txtPurpose.Text & "');"
                'MsgBox(sql)
                adt = New OleDbDataAdapter(sql, dbconn)
                adt.Fill(ds)
                ds = New DataSet
                'MessageBox.Show("Record Saved!!")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                'MessageBox.Show("Error! Not Possible")
            End Try
            dbconn.Close()
        Next
    End Sub
    Private Sub loadVenu()
        Dim sql As String
        sql = "select * from Venu"
        Try
            cn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(sql, cn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            While dr.Read
                cboVenu.Items.Add(dr.GetValue(0))
            End While
        Catch ex As Exception
            MessageBox.Show("Invalid Operation")
            cn.Close()
        End Try
        cn.Close()
        cboVenu.SelectedIndex = 0

    End Sub
    Public Sub fillMeeting()
        
        Try
            Dim sql As String
            sql = "insert into Meeting(Meeting_Date,Meeting_Time,Venu,Duration,Purpose) values ('" & dtpDate.Text & "', '" & dtpTime.Text & "','" & cboVenu.SelectedItem & "','" & cboDuration.SelectedItem & "','" & txtPurpose.Text & "');"
            'MsgBox(sql)
            adt = New OleDbDataAdapter(sql, dbconn)
            adt.Fill(ds)
            ds = New DataSet
            'MessageBox.Show("Record Saved!!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            'MessageBox.Show("Error! Not Possible")
        End Try
        dbconn.Close()
    End Sub
    Private Sub fillMeetingMap()
        ''''''''''Date Calc'''''''''''''''
        Dim dt As DateTime
        'dt = FormatDateTime(dtpDate.Value, DateFormat.ShortDate)
        dt = dtpDate.Value
        MsgBox(dt)
        Dim day As Integer
        Dim mon As Integer
        Dim yr As Integer
        day = dt.Day
        mon = dt.Month
        yr = dt.Year
        Dim cdt As String
        cdt = CType(mon, String) & "/" & CType(day, String) & "/" & CType(yr, String)
        'cdt = dt
        MsgBox(cdt)
        ''''''''''''''''''''''''''''''''''''''
        cn.Close()
        Dim s As String
        s = ""
        Dim sel As String
        sel = "select MeetingNo from Meeting where Meeting_Date=#" & cdt & "# and Meeting_Time=#" & dtpTime.Text & "#;"
        Try
            cn.Open()
            'MsgBox(sel)
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(sel, cn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            dr.Read()
            s = dr.GetValue(0)
            'MsgBox(s)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            cn.Close()
        End Try

        For Each i As String In lbSelect.Items
            Try
                Dim sql As String
                sql = "insert into Meeting_Map(ExecutiveID,MeetingNo) values ('" & i & "', '" & s & "');"
                'MsgBox(sql)
                adt = New OleDbDataAdapter(sql, dbconn)
                adt.Fill(ds)
                ds = New DataSet
                'MessageBox.Show("Record Saved!!")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                'MessageBox.Show("Error! Not Possible")
            End Try
            dbconn.Close()
        Next
    End Sub
End Class