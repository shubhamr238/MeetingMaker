Public Class frmMain

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ExecutiveDetailsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ExecutiveDetailsToolStripMenuItem.Click
        frmExDetails.Show()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        frmLogin.Show()

    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Visible = False
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.Meeting_MapTableAdapter.Fill(Me.DataDataSet4.Meeting_Map)
        Me.Executive_DiaryTableAdapter1.Fill(Me.DataDataSet3.Executive_Diary)
        Me.MeetingTableAdapter.Fill(Me.DataDataSet2.Meeting)
        Me.Executive_DiaryTableAdapter.Fill(Me.DataDataSet1.Executive_Diary)
        Me.Executive_DetailsTableAdapter.Fill(Me.DataDataSet.Executive_Details)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        ExecutiveDetailsToolStripMenuItem.Enabled = False
        NewVenuForMeetingToolStripMenuItem.Enabled = False
        MeetingToolStripMenuItem.Enabled = False
        Threading.Thread.Sleep(3000)
        Me.Visible = True
        Me.TabPage2.Text = "Executive Details"
        Me.TabPage3.Text = "Executive Diary"
        Me.TabPage4.Text = "Meeting"
        Me.TabPage5.Text = "Meeting Map"
        Me.TabView.Visible = False
        frmLogin.ShowDialog()
    End Sub

    Private Sub MeetingToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MeetingToolStripMenuItem.Click
        frmMeeting.Show()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegisterToolStripMenuItem.Click
        frmRegister.Show()
    End Sub

    Private Sub NewVenuForMeetingToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NewVenuForMeetingToolStripMenuItem.Click
        frmVenu.Show()
    End Sub
End Class