Imports System.Data.OleDb
Public Class frmRegister
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub btnOk_Click() Handles btnOk.Click
        If StrComp(txtNewPass1.Text, txtNewPass2.Text) = 0 Then
            dbconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Work\Meeting Maker\prjMeetingMaker\Data\Data.mdb"
            Try
                adt = New OleDbDataAdapter("insert into Login ([User_Name],[Password]) values ('" & txtUserID.Text & "', '" & txtNewPass1.Text & "');", dbconn)
                adt.Fill(ds)
                ds = New DataSet
                MessageBox.Show("User Added Sucessfully!")
                dbconn.Close()
            Catch ex As Exception
                'MessageBox.Show(ex.ToString)
                MessageBox.Show("User Already Present!" & vbCr & "Choose Different User Name")
                dbconn.Close()
            End Try
            dbconn.Close()
        Else
            MsgBox("Password Dosen't Match!")
        End If
    End Sub

    Private Sub btnCancel_Click() Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click() Handles btnLogin.Click
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class