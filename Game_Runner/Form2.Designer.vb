<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_Select_Difficulty = New System.Windows.Forms.Label()
        Me.btn_Play = New System.Windows.Forms.Button()
        Me.rdo_Easy = New System.Windows.Forms.RadioButton()
        Me.rdo_Normal = New System.Windows.Forms.RadioButton()
        Me.rdo_Hard = New System.Windows.Forms.RadioButton()
        Me.rdo_Very_Hard = New System.Windows.Forms.RadioButton()
        Me.btn_Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Select_Difficulty
        '
        Me.lbl_Select_Difficulty.AutoSize = True
        Me.lbl_Select_Difficulty.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Select_Difficulty.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_Select_Difficulty.Location = New System.Drawing.Point(242, 56)
        Me.lbl_Select_Difficulty.Name = "lbl_Select_Difficulty"
        Me.lbl_Select_Difficulty.Size = New System.Drawing.Size(202, 31)
        Me.lbl_Select_Difficulty.TabIndex = 1
        Me.lbl_Select_Difficulty.Text = "Select Difficulty"
        '
        'btn_Play
        '
        Me.btn_Play.Location = New System.Drawing.Point(253, 302)
        Me.btn_Play.Name = "btn_Play"
        Me.btn_Play.Size = New System.Drawing.Size(182, 37)
        Me.btn_Play.TabIndex = 2
        Me.btn_Play.Text = "Play"
        Me.btn_Play.UseVisualStyleBackColor = True
        '
        'rdo_Easy
        '
        Me.rdo_Easy.AutoSize = True
        Me.rdo_Easy.BackColor = System.Drawing.Color.Black
        Me.rdo_Easy.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rdo_Easy.Location = New System.Drawing.Point(137, 164)
        Me.rdo_Easy.Name = "rdo_Easy"
        Me.rdo_Easy.Size = New System.Drawing.Size(48, 17)
        Me.rdo_Easy.TabIndex = 3
        Me.rdo_Easy.TabStop = True
        Me.rdo_Easy.Text = "Easy"
        Me.rdo_Easy.UseVisualStyleBackColor = False
        '
        'rdo_Normal
        '
        Me.rdo_Normal.AutoSize = True
        Me.rdo_Normal.BackColor = System.Drawing.Color.Black
        Me.rdo_Normal.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rdo_Normal.Location = New System.Drawing.Point(248, 164)
        Me.rdo_Normal.Name = "rdo_Normal"
        Me.rdo_Normal.Size = New System.Drawing.Size(58, 17)
        Me.rdo_Normal.TabIndex = 4
        Me.rdo_Normal.TabStop = True
        Me.rdo_Normal.Text = "Normal"
        Me.rdo_Normal.UseVisualStyleBackColor = False
        '
        'rdo_Hard
        '
        Me.rdo_Hard.AutoSize = True
        Me.rdo_Hard.BackColor = System.Drawing.Color.Black
        Me.rdo_Hard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rdo_Hard.Location = New System.Drawing.Point(358, 164)
        Me.rdo_Hard.Name = "rdo_Hard"
        Me.rdo_Hard.Size = New System.Drawing.Size(48, 17)
        Me.rdo_Hard.TabIndex = 5
        Me.rdo_Hard.TabStop = True
        Me.rdo_Hard.Text = "Hard"
        Me.rdo_Hard.UseVisualStyleBackColor = False
        '
        'rdo_Very_Hard
        '
        Me.rdo_Very_Hard.AutoSize = True
        Me.rdo_Very_Hard.BackColor = System.Drawing.Color.Black
        Me.rdo_Very_Hard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.rdo_Very_Hard.Location = New System.Drawing.Point(450, 164)
        Me.rdo_Very_Hard.Name = "rdo_Very_Hard"
        Me.rdo_Very_Hard.Size = New System.Drawing.Size(72, 17)
        Me.rdo_Very_Hard.TabIndex = 6
        Me.rdo_Very_Hard.TabStop = True
        Me.rdo_Very_Hard.Text = "Very Hard"
        Me.rdo_Very_Hard.UseVisualStyleBackColor = False
        '
        'btn_Back
        '
        Me.btn_Back.Location = New System.Drawing.Point(12, 23)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(133, 37)
        Me.btn_Back.TabIndex = 7
        Me.btn_Back.Text = "Back"
        Me.btn_Back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(686, 390)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Back)
        Me.Controls.Add(Me.rdo_Very_Hard)
        Me.Controls.Add(Me.rdo_Hard)
        Me.Controls.Add(Me.rdo_Normal)
        Me.Controls.Add(Me.rdo_Easy)
        Me.Controls.Add(Me.btn_Play)
        Me.Controls.Add(Me.lbl_Select_Difficulty)
        Me.Name = "Form2"
        Me.Text = "Title Screen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Select_Difficulty As Label
    Friend WithEvents btn_Play As Button
    Friend WithEvents rdo_Easy As RadioButton
    Friend WithEvents rdo_Normal As RadioButton
    Friend WithEvents rdo_Hard As RadioButton
    Friend WithEvents rdo_Very_Hard As RadioButton
    Friend WithEvents btn_Back As Button
    Friend WithEvents Button1 As Button
End Class
