Imports System.Data.OleDb
Public Class frmLogin
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Private cn As OleDbConnection
    Private Sub btnOK_Click() Handles btnOK.Click
        Dim sql As String
        sql = "select * from Login where [User_Name]='" & txtUserName.Text & "' and [Password]='" & txtPassword.Text & "';"
        cn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Work\Meeting Maker\prjMeetingMaker\Data\Data.mdb")
        Try
            cn.Open()
            'MsgBox(sql)
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(sql, cn)
            Dim dr As OleDbDataReader
            dr = cmd.ExecuteReader()
            If dr.Read Then
                cn.Close()
                MsgBox("Sucesfully Loged in!")
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                frmMain.ExecutiveDetailsToolStripMenuItem.Enabled = True
                frmMain.NewVenuForMeetingToolStripMenuItem.Enabled = True
                frmMain.MeetingToolStripMenuItem.Enabled = True
                frmMain.LoginToolStripMenuItem.Enabled = False
                frmMain.RegisterToolStripMenuItem.Enabled = False
                frmMain.TabView.Visible = True
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                Me.Hide()
            Else
                MsgBox("Wrong User Name or Password!!")
                cn.Close()
            End If
        Catch ex As Exception
            'MsgBox(ex.ToString)
            MessageBox.Show("Error! Login Can't Be Performed!")
            cn.Close()
        End Try
    End Sub
    Private Sub btn_Register_Click() Handles btn_Register.Click

        frmRegister.Show()
        Me.Hide()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Focus()
    End Sub
End Class
