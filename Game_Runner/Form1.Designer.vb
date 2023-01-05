<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.



    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmr_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Counter = New System.Windows.Forms.Label()
        Me.grp_Game_Pause = New System.Windows.Forms.GroupBox()
        Me.btn_Resume = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.lbl_Game_Paused = New System.Windows.Forms.Label()
        Me.grp_Game_Over = New System.Windows.Forms.GroupBox()
        Me.btn_Return = New System.Windows.Forms.Button()
        Me.lbl_Final_Score_Number = New System.Windows.Forms.Label()
        Me.lbl_Final_Score = New System.Windows.Forms.Label()
        Me.btn_Game_Over_Exit = New System.Windows.Forms.Button()
        Me.lbl_Game_Over = New System.Windows.Forms.Label()
        Me.pic_Enemy = New System.Windows.Forms.PictureBox()
        Me.pic_Health3 = New System.Windows.Forms.PictureBox()
        Me.pic_Health2 = New System.Windows.Forms.PictureBox()
        Me.pic_Health1 = New System.Windows.Forms.PictureBox()
        Me.pic_Player = New System.Windows.Forms.PictureBox()
        Me.pic_Floor = New System.Windows.Forms.PictureBox()
        Me.grp_Game_Pause.SuspendLayout()
        Me.grp_Game_Over.SuspendLayout()
        CType(Me.pic_Enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Health3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Health2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Health1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_Floor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_Mover
        '
        '
        'lbl_Counter
        '
        Me.lbl_Counter.AutoSize = True
        Me.lbl_Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_Counter.Location = New System.Drawing.Point(885, 35)
        Me.lbl_Counter.Name = "lbl_Counter"
        Me.lbl_Counter.Size = New System.Drawing.Size(58, 15)
        Me.lbl_Counter.TabIndex = 4
        Me.lbl_Counter.Text = "Score : 0 "
        '
        'grp_Game_Pause
        '
        Me.grp_Game_Pause.Controls.Add(Me.btn_Resume)
        Me.grp_Game_Pause.Controls.Add(Me.btn_Exit)
        Me.grp_Game_Pause.Controls.Add(Me.lbl_Game_Paused)
        Me.grp_Game_Pause.Location = New System.Drawing.Point(232, 58)
        Me.grp_Game_Pause.Name = "grp_Game_Pause"
        Me.grp_Game_Pause.Size = New System.Drawing.Size(726, 353)
        Me.grp_Game_Pause.TabIndex = 3
        Me.grp_Game_Pause.TabStop = False
        Me.grp_Game_Pause.Visible = False
        '
        'btn_Resume
        '
        Me.btn_Resume.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Resume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Resume.ForeColor = System.Drawing.Color.Black
        Me.btn_Resume.Location = New System.Drawing.Point(441, 241)
        Me.btn_Resume.Name = "btn_Resume"
        Me.btn_Resume.Size = New System.Drawing.Size(228, 39)
        Me.btn_Resume.TabIndex = 2
        Me.btn_Resume.Text = "RESUME"
        Me.btn_Resume.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Exit.ForeColor = System.Drawing.Color.Black
        Me.btn_Exit.Location = New System.Drawing.Point(35, 241)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(228, 39)
        Me.btn_Exit.TabIndex = 1
        Me.btn_Exit.Text = "EXIT"
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'lbl_Game_Paused
        '
        Me.lbl_Game_Paused.AutoSize = True
        Me.lbl_Game_Paused.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Game_Paused.Location = New System.Drawing.Point(256, 119)
        Me.lbl_Game_Paused.Name = "lbl_Game_Paused"
        Me.lbl_Game_Paused.Size = New System.Drawing.Size(223, 31)
        Me.lbl_Game_Paused.TabIndex = 0
        Me.lbl_Game_Paused.Text = "GAME PAUSED"
        '
        'grp_Game_Over
        '
        Me.grp_Game_Over.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grp_Game_Over.Controls.Add(Me.btn_Return)
        Me.grp_Game_Over.Controls.Add(Me.lbl_Final_Score_Number)
        Me.grp_Game_Over.Controls.Add(Me.lbl_Final_Score)
        Me.grp_Game_Over.Controls.Add(Me.btn_Game_Over_Exit)
        Me.grp_Game_Over.Controls.Add(Me.lbl_Game_Over)
        Me.grp_Game_Over.Location = New System.Drawing.Point(232, 58)
        Me.grp_Game_Over.Name = "grp_Game_Over"
        Me.grp_Game_Over.Size = New System.Drawing.Size(726, 353)
        Me.grp_Game_Over.TabIndex = 10
        Me.grp_Game_Over.TabStop = False
        Me.grp_Game_Over.Visible = False
        '
        'btn_Return
        '
        Me.btn_Return.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Return.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Return.ForeColor = System.Drawing.Color.Black
        Me.btn_Return.Location = New System.Drawing.Point(441, 257)
        Me.btn_Return.Name = "btn_Return"
        Me.btn_Return.Size = New System.Drawing.Size(228, 39)
        Me.btn_Return.TabIndex = 6
        Me.btn_Return.Text = "RETURN"
        Me.btn_Return.UseVisualStyleBackColor = False
        '
        'lbl_Final_Score_Number
        '
        Me.lbl_Final_Score_Number.AutoSize = True
        Me.lbl_Final_Score_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Final_Score_Number.Location = New System.Drawing.Point(487, 154)
        Me.lbl_Final_Score_Number.Name = "lbl_Final_Score_Number"
        Me.lbl_Final_Score_Number.Size = New System.Drawing.Size(30, 31)
        Me.lbl_Final_Score_Number.TabIndex = 5
        Me.lbl_Final_Score_Number.Text = "0"
        '
        'lbl_Final_Score
        '
        Me.lbl_Final_Score.AutoSize = True
        Me.lbl_Final_Score.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Final_Score.Location = New System.Drawing.Point(182, 154)
        Me.lbl_Final_Score.Name = "lbl_Final_Score"
        Me.lbl_Final_Score.Size = New System.Drawing.Size(116, 31)
        Me.lbl_Final_Score.TabIndex = 4
        Me.lbl_Final_Score.Text = "SCORE"
        '
        'btn_Game_Over_Exit
        '
        Me.btn_Game_Over_Exit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Game_Over_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Game_Over_Exit.ForeColor = System.Drawing.Color.Black
        Me.btn_Game_Over_Exit.Location = New System.Drawing.Point(70, 257)
        Me.btn_Game_Over_Exit.Name = "btn_Game_Over_Exit"
        Me.btn_Game_Over_Exit.Size = New System.Drawing.Size(228, 39)
        Me.btn_Game_Over_Exit.TabIndex = 3
        Me.btn_Game_Over_Exit.Text = "EXIT"
        Me.btn_Game_Over_Exit.UseVisualStyleBackColor = False
        '
        'lbl_Game_Over
        '
        Me.lbl_Game_Over.AutoSize = True
        Me.lbl_Game_Over.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Game_Over.Location = New System.Drawing.Point(277, 68)
        Me.lbl_Game_Over.Name = "lbl_Game_Over"
        Me.lbl_Game_Over.Size = New System.Drawing.Size(186, 31)
        Me.lbl_Game_Over.TabIndex = 3
        Me.lbl_Game_Over.Text = "GAME OVER"
        '
        'pic_Enemy
        '
        Me.pic_Enemy.BackColor = System.Drawing.Color.Red
        Me.pic_Enemy.Location = New System.Drawing.Point(1063, 413)
        Me.pic_Enemy.Name = "pic_Enemy"
        Me.pic_Enemy.Size = New System.Drawing.Size(33, 28)
        Me.pic_Enemy.TabIndex = 8
        Me.pic_Enemy.TabStop = False
        '
        'pic_Health3
        '
        Me.pic_Health3.BackColor = System.Drawing.Color.Transparent
        Me.pic_Health3.BackgroundImage = Global.Game_Runner.My.Resources.Resources.heart_1
        Me.pic_Health3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_Health3.Location = New System.Drawing.Point(1080, 30)
        Me.pic_Health3.Name = "pic_Health3"
        Me.pic_Health3.Size = New System.Drawing.Size(34, 25)
        Me.pic_Health3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_Health3.TabIndex = 7
        Me.pic_Health3.TabStop = False
        '
        'pic_Health2
        '
        Me.pic_Health2.BackColor = System.Drawing.Color.Transparent
        Me.pic_Health2.BackgroundImage = Global.Game_Runner.My.Resources.Resources.heart_1
        Me.pic_Health2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_Health2.Location = New System.Drawing.Point(1022, 30)
        Me.pic_Health2.Name = "pic_Health2"
        Me.pic_Health2.Size = New System.Drawing.Size(34, 25)
        Me.pic_Health2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Health2.TabIndex = 6
        Me.pic_Health2.TabStop = False
        '
        'pic_Health1
        '
        Me.pic_Health1.BackColor = System.Drawing.Color.Transparent
        Me.pic_Health1.BackgroundImage = Global.Game_Runner.My.Resources.Resources.heart_1
        Me.pic_Health1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_Health1.Location = New System.Drawing.Point(970, 30)
        Me.pic_Health1.Name = "pic_Health1"
        Me.pic_Health1.Size = New System.Drawing.Size(34, 25)
        Me.pic_Health1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Health1.TabIndex = 5
        Me.pic_Health1.TabStop = False
        '
        'pic_Player
        '
        Me.pic_Player.BackColor = System.Drawing.Color.Transparent
        Me.pic_Player.BackgroundImage = Global.Game_Runner.My.Resources.Resources.standing2_1
        Me.pic_Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pic_Player.Location = New System.Drawing.Point(89, 80)
        Me.pic_Player.Name = "pic_Player"
        Me.pic_Player.Size = New System.Drawing.Size(27, 40)
        Me.pic_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_Player.TabIndex = 3
        Me.pic_Player.TabStop = False
        '
        'pic_Floor
        '
        Me.pic_Floor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pic_Floor.Location = New System.Drawing.Point(0, 446)
        Me.pic_Floor.Name = "pic_Floor"
        Me.pic_Floor.Size = New System.Drawing.Size(1204, 12)
        Me.pic_Floor.TabIndex = 11
        Me.pic_Floor.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Game_Runner.My.Resources.Resources.Castle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 520)
        Me.ControlBox = False
        Me.Controls.Add(Me.pic_Floor)
        Me.Controls.Add(Me.grp_Game_Over)
        Me.Controls.Add(Me.grp_Game_Pause)
        Me.Controls.Add(Me.pic_Enemy)
        Me.Controls.Add(Me.pic_Health3)
        Me.Controls.Add(Me.pic_Health2)
        Me.Controls.Add(Me.pic_Health1)
        Me.Controls.Add(Me.lbl_Counter)
        Me.Controls.Add(Me.pic_Player)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Runner"
        Me.grp_Game_Pause.ResumeLayout(False)
        Me.grp_Game_Pause.PerformLayout()
        Me.grp_Game_Over.ResumeLayout(False)
        Me.grp_Game_Over.PerformLayout()
        CType(Me.pic_Enemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Health3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Health2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Health1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_Floor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmr_Mover As Timer
    Friend WithEvents pic_Player As PictureBox
    Friend WithEvents lbl_Counter As Label
    Friend WithEvents pic_Health1 As PictureBox
    Friend WithEvents pic_Health2 As PictureBox
    Friend WithEvents pic_Health3 As PictureBox
    Friend WithEvents pic_Enemy As PictureBox
    Friend WithEvents grp_Game_Pause As GroupBox
    Friend WithEvents grp_Game_Over As GroupBox
    Friend WithEvents btn_Game_Over_Exit As Button
    Friend WithEvents lbl_Game_Over As Label
    Friend WithEvents btn_Resume As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents lbl_Game_Paused As Label
    Friend WithEvents lbl_Final_Score_Number As Label
    Friend WithEvents lbl_Final_Score As Label
    Friend WithEvents btn_Return As Button
    Friend WithEvents pic_Floor As PictureBox
End Class
