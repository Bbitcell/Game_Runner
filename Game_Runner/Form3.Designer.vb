<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_Password = New System.Windows.Forms.TextBox()
        Me.txt_Username = New System.Windows.Forms.TextBox()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.btn_Create_Account = New System.Windows.Forms.Button()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_Password
        '
        Me.txt_Password.Location = New System.Drawing.Point(221, 220)
        Me.txt_Password.Name = "txt_Password"
        Me.txt_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_Password.Size = New System.Drawing.Size(259, 20)
        Me.txt_Password.TabIndex = 0
        '
        'txt_Username
        '
        Me.txt_Username.Location = New System.Drawing.Point(221, 166)
        Me.txt_Username.Name = "txt_Username"
        Me.txt_Username.Size = New System.Drawing.Size(259, 20)
        Me.txt_Username.TabIndex = 1
        '
        'lbl_Login
        '
        Me.lbl_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Login.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Login.Location = New System.Drawing.Point(221, 60)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(258, 61)
        Me.lbl_Login.TabIndex = 2
        Me.lbl_Login.Text = "LOGIN"
        Me.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Login
        '
        Me.btn_Login.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Login.Location = New System.Drawing.Point(232, 272)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(231, 32)
        Me.btn_Login.TabIndex = 3
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = False
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Username.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Username.Location = New System.Drawing.Point(125, 170)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(65, 15)
        Me.lbl_Username.TabIndex = 4
        Me.lbl_Username.Text = "Username"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Password.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Password.Location = New System.Drawing.Point(125, 228)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(61, 15)
        Me.lbl_Password.TabIndex = 5
        Me.lbl_Password.Text = "Password"
        '
        'btn_Create_Account
        '
        Me.btn_Create_Account.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Create_Account.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Create_Account.Location = New System.Drawing.Point(232, 322)
        Me.btn_Create_Account.Name = "btn_Create_Account"
        Me.btn_Create_Account.Size = New System.Drawing.Size(231, 32)
        Me.btn_Create_Account.TabIndex = 6
        Me.btn_Create_Account.Text = "Create Account"
        Me.btn_Create_Account.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Back.ForeColor = System.Drawing.Color.Black
        Me.btn_Back.Location = New System.Drawing.Point(23, 24)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(101, 28)
        Me.btn_Back.TabIndex = 7
        Me.btn_Back.Text = "Exit"
        Me.btn_Back.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.btn_Create_Account)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.txt_Username)
        Me.Controls.Add(Me.txt_Password)
        Me.Name = "Form3"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_Username As TextBox
    Friend WithEvents lbl_Login As Label
    Friend WithEvents btn_Login As Button
    Friend WithEvents lbl_Username As Label
    Friend WithEvents lbl_Password As Label
    Friend WithEvents btn_Create_Account As Button
    Friend WithEvents btn_Back As Button
End Class
