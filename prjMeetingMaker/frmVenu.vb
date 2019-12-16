Imports System.Data.OleDb
Public Class frmVenu
    Dim dbconn As New OleDbConnection
    Dim adt As New OleDbDataAdapter
    Dim ds As New DataSet
    Private Sub btnAddNew_Click() Handles btnAddNew.Click
        dbconn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Work\Meeting Maker\prjMeetingMaker\Data\Data.mdb"
        Try
            adt = New OleDbDataAdapter("insert into Venu (Place) values ('" & txtVenu.Text & "')", dbconn)
            adt.Fill(ds)
            ds = New DataSet
            MessageBox.Show("New Venu Added")
        Catch ex As Exception
            ' MessageBox.Show(ex.ToString)
            MessageBox.Show("Error! Not Possible")
        End Try
        dbconn.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class