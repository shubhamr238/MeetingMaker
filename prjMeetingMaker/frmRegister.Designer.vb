<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Me.gboReg = New System.Windows.Forms.GroupBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtNewPass2 = New System.Windows.Forms.TextBox()
        Me.txtNewPass1 = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboReg.SuspendLayout()
        Me.SuspendLayout()
        '
        'gboReg
        '
        Me.gboReg.Controls.Add(Me.btnCancel)
        Me.gboReg.Controls.Add(Me.btnLogin)
        Me.gboReg.Controls.Add(Me.btnOk)
        Me.gboReg.Controls.Add(Me.txtNewPass2)
        Me.gboReg.Controls.Add(Me.txtNewPass1)
        Me.gboReg.Controls.Add(Me.txtUserID)
        Me.gboReg.Controls.Add(Me.Label3)
        Me.gboReg.Controls.Add(Me.Label2)
        Me.gboReg.Controls.Add(Me.Label1)
        Me.gboReg.Location = New System.Drawing.Point(12, 12)
        Me.gboReg.Name = "gboReg"
        Me.gboReg.Size = New System.Drawing.Size(332, 178)
        Me.gboReg.TabIndex = 0
        Me.gboReg.TabStop = False
        Me.gboReg.Text = "Register"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(129, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(238, 137)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(20, 137)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 6
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtNewPass2
        '
        Me.txtNewPass2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass2.Location = New System.Drawing.Point(140, 94)
        Me.txtNewPass2.Name = "txtNewPass2"
        Me.txtNewPass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass2.Size = New System.Drawing.Size(174, 26)
        Me.txtNewPass2.TabIndex = 5
        '
        'txtNewPass1
        '
        Me.txtNewPass1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPass1.Location = New System.Drawing.Point(140, 58)
        Me.txtNewPass1.Name = "txtNewPass1"
        Me.txtNewPass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtNewPass1.Size = New System.Drawing.Size(174, 26)
        Me.txtNewPass1.TabIndex = 4
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(140, 24)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(174, 26)
        Me.txtUserID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Re-enter Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New User ID"
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 197)
        Me.Controls.Add(Me.gboReg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegister"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Register User"
        Me.gboReg.ResumeLayout(False)
        Me.gboReg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboReg As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents txtNewPass2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPass1 As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
End Class
