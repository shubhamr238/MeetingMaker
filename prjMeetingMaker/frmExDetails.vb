Imports System.Data.OleDb
Public Class frmExDetails
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub frmExDetails_Load() Handles MyBase.Load
        txtExId.Focus()
        clear()
        dbconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Work\Meeting Maker\prjMeetingMaker\Data\Data.mdb"
    End Sub

    Private Sub btnAddNew_Click() Handles btnAddNew.Click
        insertExecutive()
        frmMain.Executive_DetailsTableAdapter.Fill(frmMain.DataDataSet.Executive_Details)
    End Sub
    Private Sub clear()
        txtContactNo.Clear()
        txtAdd.Clear()
        txtEmail.Clear()
        txtExId.Clear()
        txtName.Clear()
        txtRank.Clear()
        txtExId.Focus()
    End Sub
    Private Sub insertExecutive()
        Try
            adt = New OleDbDataAdapter("insert into Executive_Details (ExecutiveID,Name,Rank,Email,ContactNo,Address) values ('" & Val(txtExId.Text) & "', '" & txtName.Text & "','" & txtRank.Text & "','" & txtEmail.Text & "','" & Val(txtContactNo.Text) & "','" & txtAdd.Text & "')", dbconn)
            adt.Fill(ds)
            ds = New DataSet
            MessageBox.Show("Record Saved!!")
        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Error! Not Possible")
        End Try
        dbconn.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub
End Class
