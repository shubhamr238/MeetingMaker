<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMeeting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gboMeeting = New System.Windows.Forms.GroupBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboVenu = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.cboDuration = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDeselect = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lbSelect = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnArrange = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbExecutive = New System.Windows.Forms.ListBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboMeeting.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboMeeting
        '
        Me.gboMeeting.Controls.Add(Me.txtPurpose)
        Me.gboMeeting.Controls.Add(Me.Label6)
        Me.gboMeeting.Controls.Add(Me.cboVenu)
        Me.gboMeeting.Controls.Add(Me.Label5)
        Me.gboMeeting.Controls.Add(Me.btnInfo)
        Me.gboMeeting.Controls.Add(Me.cboDuration)
        Me.gboMeeting.Controls.Add(Me.Label4)
        Me.gboMeeting.Controls.Add(Me.dtpTime)
        Me.gboMeeting.Controls.Add(Me.Label3)
        Me.gboMeeting.Controls.Add(Me.btnDeselect)
        Me.gboMeeting.Controls.Add(Me.btnSelect)
        Me.gboMeeting.Controls.Add(Me.lbSelect)
        Me.gboMeeting.Controls.Add(Me.btnCancel)
        Me.gboMeeting.Controls.Add(Me.btnArrange)
        Me.gboMeeting.Controls.Add(Me.Label2)
        Me.gboMeeting.Controls.Add(Me.lbExecutive)
        Me.gboMeeting.Controls.Add(Me.dtpDate)
        Me.gboMeeting.Controls.Add(Me.Label1)
        Me.gboMeeting.Location = New System.Drawing.Point(6, 4)
        Me.gboMeeting.Name = "gboMeeting"
        Me.gboMeeting.Size = New System.Drawing.Size(370, 362)
        Me.gboMeeting.TabIndex = 0
        Me.gboMeeting.TabStop = False
        Me.gboMeeting.Text = "Arrange Meeting"
        '
        'txtPurpose
        '
        Me.txtPurpose.Location = New System.Drawing.Point(23, 142)
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(322, 20)
        Me.txtPurpose.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Meeting &Purpose: "
        '
        'cboVenu
        '
        Me.cboVenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVenu.FormattingEnabled = True
        Me.cboVenu.Location = New System.Drawing.Point(220, 91)
        Me.cboVenu.Name = "cboVenu"
        Me.cboVenu.Size = New System.Drawing.Size(121, 21)
        Me.cboVenu.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Select &Venu :"
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(166, 285)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(37, 23)
        Me.btnInfo.TabIndex = 13
        Me.btnInfo.Text = "&Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'cboDuration
        '
        Me.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDuration.FormattingEnabled = True
        Me.cboDuration.Location = New System.Drawing.Point(220, 40)
        Me.cboDuration.Name = "cboDuration"
        Me.cboDuration.Size = New System.Drawing.Size(121, 21)
        Me.cboDuration.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "&Select Duration (Hr) :"
        '
        'dtpTime
        '
        Me.dtpTime.Location = New System.Drawing.Point(23, 92)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(180, 20)
        Me.dtpTime.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Input &Time:"
        '
        'btnDeselect
        '
        Me.btnDeselect.Location = New System.Drawing.Point(166, 242)
        Me.btnDeselect.Name = "btnDeselect"
        Me.btnDeselect.Size = New System.Drawing.Size(37, 23)
        Me.btnDeselect.TabIndex = 8
        Me.btnDeselect.Text = "<<"
        Me.btnDeselect.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(166, 201)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(37, 23)
        Me.btnSelect.TabIndex = 7
        Me.btnSelect.Text = ">>"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'lbSelect
        '
        Me.lbSelect.FormattingEnabled = True
        Me.lbSelect.Location = New System.Drawing.Point(211, 190)
        Me.lbSelect.Name = "lbSelect"
        Me.lbSelect.Size = New System.Drawing.Size(134, 134)
        Me.lbSelect.TabIndex = 6
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(196, 331)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnArrange
        '
        Me.btnArrange.Location = New System.Drawing.Point(87, 331)
        Me.btnArrange.Name = "btnArrange"
        Me.btnArrange.Size = New System.Drawing.Size(75, 23)
        Me.btnArrange.TabIndex = 4
        Me.btnArrange.Text = "&Arrange"
        Me.btnArrange.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "&Choose Executives:"
        '
        'lbExecutive
        '
        Me.lbExecutive.FormattingEnabled = True
        Me.lbExecutive.Location = New System.Drawing.Point(23, 190)
        Me.lbExecutive.Name = "lbExecutive"
        Me.lbExecutive.Size = New System.Drawing.Size(134, 134)
        Me.lbExecutive.TabIndex = 2
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(23, 41)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(180, 20)
        Me.dtpDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input &Date:"
        '
        'frmMeeting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 373)
        Me.Controls.Add(Me.gboMeeting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMeeting"
        Me.Text = "Arrange Meeting"
        Me.gboMeeting.ResumeLayout(False)
        Me.gboMeeting.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboMeeting As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnArrange As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbExecutive As System.Windows.Forms.ListBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDeselect As System.Windows.Forms.Button
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents lbSelect As System.Windows.Forms.ListBox
    Friend WithEvents dtpTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboDuration As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents cboVenu As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
