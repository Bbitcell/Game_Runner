'Name: Mohammed Umer    211120074'
'      Mohammed Alzeer  201120206'
'Date: 10/12/22'
'This form displays a main game window that is connected to a database'


Imports System.Data.Odbc

Public Class Form1

    Dim int_Counter As Integer = 0
    Dim int_Gravity As Integer = 0
    Dim int_Jump As Integer = 0
    Dim int_Velocity As Integer = 0
    Dim int_Deacceralation As Integer = 0

    Dim int_Max_Obstacles As Integer = 10
    Dim int_Obstacles_Interval As Integer = 50
    Dim int_Random_Number_Obstacle_X As Integer
    Dim int_Random_Number_Obstacle_Y As Integer
    Dim int_Random_Direction_Index As Integer
    Dim pic_Obstacle_List As New List(Of PictureBox)
    Dim str_Direction_List As New List(Of String)
    Dim str_Directions() As String = {"Right", "Up", "Left", "Down"}
    Dim int_Obstacle_Speed As Integer = 3
    Dim int_Remove_Obstacle_Index As New List(Of Integer)

    Dim int_Score As Integer = 0
    Dim bln_Invincibility As Boolean = False
    Dim int_Health As Integer = 3
    Dim int_Difficulty As Integer = Form2.int_Difficulty

    Dim img_Player_Left As Image = Global.Game_Runner.My.Resources.left_copy_1
    Dim img_Player_Right As Image = Global.Game_Runner.My.Resources.Right_1
    Dim img_Player_Standing As Image = Global.Game_Runner.My.Resources.standing2_1
    Dim img_obstacle As Image = Global.Game_Runner.My.Resources.Long_Blue_Bone_removebg_preview

    Dim str_user_id As String = Form3.user_id
    Private Sub tmr_Mover_Tick(sender As Object, e As EventArgs) Handles tmr_Mover.Tick

        Move_Vertically()

        Move_Horizontally()

        If (int_Counter Mod int_Obstacles_Interval) = 0 AndAlso pic_Obstacle_List.Count < int_Max_Obstacles Then
            New_Obstacle()
        End If


        Move_Obstacle()


        Clear_Out_Of_Bounds_Obstacles()

        Calculate_Score()

        If int_Difficulty = 4 Then
            Move_Enemy()
        End If

        pic_Player.Location = New Point(pic_Player.Location.X + int_Velocity, (pic_Player.Location.Y + int_Gravity - int_Jump))
        int_Counter += 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmr_Mover.Interval = 50
        tmr_Mover.Start()
        pic_Player.SizeMode = PictureBoxSizeMode.StretchImage
        Randomize()

        If pic_Floor.Location.Y <> Me.Height OrElse pic_Floor.Size.Width <> Me.Width Then
            pic_Floor.Location = New Point(0, Me.Height * (90 / 100))
            pic_Floor.Size = New Size(Me.Width, 8)
        End If

        If int_Difficulty = 4 Then
            If pic_Enemy.Location.Y < (pic_Floor.Location.Y - 50) Then
                pic_Enemy.Location = New Point(pic_Enemy.Location.X, pic_Floor.Location.Y - 40)
            End If
        ElseIf int_Difficulty = 3 Then
            str_Directions = {"Right", "Up", "Left"}
            int_Obstacles_Interval = 100
            pic_Enemy.Dispose()
        ElseIf int_Difficulty = 2 Then
            str_Directions = {"Right", "Up"}
            int_Obstacles_Interval = 150
            pic_Enemy.Dispose()
        ElseIf int_Difficulty = 1 Then
            str_Directions = {"Right"}
            int_Obstacles_Interval = 200
            pic_Enemy.Dispose()

        End If

    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If pic_Player.Location.Y > (pic_Floor.Location.Y - 50) Then
            If e.KeyCode = Keys.Up AndAlso int_Jump < 20 Then
                int_Jump = 20

            End If
        End If


        If e.KeyCode = Keys.Right AndAlso int_Velocity <> 16 Then
            int_Deacceralation = 0

            int_Velocity = 16

            If pic_Player.Image IsNot img_Player_Right Then
                pic_Player.Image = img_Player_Right
            End If


        ElseIf e.KeyCode = Keys.Left AndAlso int_Velocity <> -16 Then
            int_Deacceralation = 0


            int_Velocity = -16

            If pic_Player.Image IsNot img_Player_Left Then
                pic_Player.Image = img_Player_Left
            End If


        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp


        If e.KeyCode = Keys.Right AndAlso int_Velocity > 0 Then

            int_Deacceralation = -2

        ElseIf e.KeyCode = Keys.Left AndAlso int_Velocity < 0 Then

            int_Deacceralation = 2

        ElseIf e.KeyCode = Keys.Escape AndAlso grp_Game_Over.Visible = False Then
            If grp_Game_Pause.Visible Then
                grp_Game_Pause.Visible = False
                tmr_Mover.Start()


            Else
                grp_Game_Pause.Visible = True
                tmr_Mover.Stop()
            End If
        End If

    End Sub

    Private Sub New_Obstacle()
        int_Random_Direction_Index = Int((str_Directions.Length * Rnd()))

        Dim str_Direction As String = str_Directions(int_Random_Direction_Index)
        Dim pic_Obstacle As New PictureBox()

        Me.pic_Obstacle_List.Add(pic_Obstacle)
        pic_Obstacle.BackColor = Color.Transparent
        pic_Obstacle.BackgroundImage = img_obstacle
        pic_Obstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        pic_Obstacle.Height = 100
        pic_Obstacle.Width = 40


        If str_Direction = "Right" Then

            int_Random_Number_Obstacle_X = Int((200 * Rnd()))
            pic_Obstacle.Location = New Point(Me.Width, pic_Floor.Location.Y - 50 - int_Random_Number_Obstacle_X)


        ElseIf str_Direction = "Left" Then
            int_Random_Number_Obstacle_X = Int((200 * Rnd()))
            pic_Obstacle.Location = New Point(0, pic_Floor.Location.Y - 50 - int_Random_Number_Obstacle_X)

        ElseIf str_Direction = "Up" Then
            int_Random_Number_Obstacle_Y = Int((Me.Width * Rnd()))
            pic_Obstacle.Location = New Point(0 + int_Random_Number_Obstacle_Y, 0)

        ElseIf str_Direction = "Down" Then
            int_Random_Number_Obstacle_Y = Int((Me.Width * Rnd()))
            pic_Obstacle.Location = New Point(0 + int_Random_Number_Obstacle_Y, Me.Height)


        End If

        str_Direction_List.Add(str_Direction)

        pic_Obstacle.Visible = True
        pic_Obstacle.Enabled = True

        Me.Controls.Add(pic_Obstacle)
    End Sub

    Private Sub Move_Obstacle()

        For Each i In pic_Obstacle_List

            Move_Obstacle_Direction(i)
            Check_Obstacle_Collision(i)
        Next

    End Sub

    Private Sub Move_Obstacle_Direction(i As PictureBox)
        If str_Direction_List(pic_Obstacle_List.IndexOf(i)) = "Right" Then
            i.Location = New Point(i.Location.X - int_Obstacle_Speed, i.Location.Y)

            If i.Location.X <= -20 Then
                int_Remove_Obstacle_Index.Add(pic_Obstacle_List.IndexOf(i))
                i.Dispose()

            End If

        ElseIf str_Direction_List(pic_Obstacle_List.IndexOf(i)) = "Left" Then
            i.Location = New Point(i.Location.X + int_Obstacle_Speed, i.Location.Y)


            If i.Location.X >= Me.Width + 20 Then
                int_Remove_Obstacle_Index.Add(pic_Obstacle_List.IndexOf(i))
                i.Dispose()

            End If
        ElseIf str_Direction_List(pic_Obstacle_List.IndexOf(i)) = "Up" Then
            i.Location = New Point(i.Location.X, i.Location.Y + int_Obstacle_Speed)

            If i.Location.Y >= Me.Height + 20 Then
                int_Remove_Obstacle_Index.Add(pic_Obstacle_List.IndexOf(i))
                i.Dispose()

            End If

        ElseIf str_Direction_List(pic_Obstacle_List.IndexOf(i)) = "Down" Then
            i.Location = New Point(i.Location.X, i.Location.Y - int_Obstacle_Speed)


            If i.Location.Y <= -20 Then
                int_Remove_Obstacle_Index.Add(pic_Obstacle_List.IndexOf(i))
                i.Dispose()
            End If
        End If
    End Sub
    Private Sub Check_Obstacle_Collision(i As PictureBox)
        If pic_Player.Location.X >= i.Location.X - 10 AndAlso pic_Player.Location.X <= i.Location.X + 10 AndAlso pic_Player.Location.Y >= i.Location.Y - 50 AndAlso pic_Player.Location.Y <= i.Location.Y + 100 AndAlso (bln_Invincibility = False) Then
            int_Health -= 1
            Calculate_Health()
        End If

    End Sub

    Private Sub Move_Vertically()
        If pic_Player.Location.Y < (pic_Floor.Location.Y - 50) AndAlso (int_Jump = 0) Then
            int_Gravity += 1
        Else
            If int_Jump > 0 Then
                int_Jump -= 1

            End If
            int_Gravity = 0
        End If
    End Sub

    Private Sub Move_Horizontally()
        If int_Velocity <> 0 Then

            int_Velocity += int_Deacceralation
            If 20 > pic_Player.Location.X AndAlso int_Velocity < 0 Then

                int_Velocity = 0
            ElseIf pic_Player.Location.X > Me.Width - 60 AndAlso int_Velocity > 0 Then
                int_Velocity = 0

            End If
        Else
            int_Deacceralation = 0

            If pic_Player.Image IsNot img_Player_Standing Then
                pic_Player.Image = img_Player_Standing
            End If


        End If
    End Sub

    Private Sub Clear_Out_Of_Bounds_Obstacles()
        For Each i In int_Remove_Obstacle_Index
            pic_Obstacle_List.RemoveAt(i)
            str_Direction_List.RemoveAt(i)

        Next
        int_Remove_Obstacle_Index.Clear()
    End Sub

    Private Sub Calculate_Score()

        'Calculates Score and displays it'

        'Also, remove invinciblity from the player after some time'

        If int_Counter Mod 80 = 0 Then
            bln_Invincibility = False
            int_Score += 1 + (int_Difficulty - 1)
            lbl_Counter.Text = "Score : " & int_Score.ToString()

        End If
    End Sub
    Private Sub Calculate_Health()

        'Remove hearts from player and when there are no hearts, then end the game'

        Select Case int_Health
            Case 0
                pic_Health1.Dispose()

                lbl_Counter.Text = ""
                tmr_Mover.Stop()
                lbl_Final_Score_Number.Text = int_Score.ToString()
                Database_Score_Add()
                grp_Game_Over.Visible = True
            Case 1
                pic_Health2.Dispose()

            Case 2
                pic_Health3.Dispose()


        End Select
        bln_Invincibility = True
    End Sub

    Private Sub Move_Enemy()

        'Move Enemy to Player'

        If pic_Player.Location.X - pic_Enemy.Location.X < 0 Then
            pic_Enemy.Location = New Point(pic_Enemy.Location.X - 4, pic_Enemy.Location.Y)
        ElseIf pic_Player.Location.X - pic_Enemy.Location.X > 0 Then
            pic_Enemy.Location = New Point(pic_Enemy.Location.X + 4, pic_Enemy.Location.Y)
        End If

        'Check Obstacle's Collision with Player'

        If pic_Enemy.Location.X > pic_Player.Location.X - 20 AndAlso pic_Enemy.Location.X < pic_Player.Location.X + 20 AndAlso pic_Enemy.Location.Y > pic_Player.Location.Y - 20 AndAlso pic_Enemy.Location.Y < pic_Player.Location.Y + 20 AndAlso bln_Invincibility = False Then
            int_Health -= 1
            Calculate_Health()

        End If
    End Sub

    Private Sub Database_Score_Add()
        Dim con As New OdbcConnection("Dsn=PostgreSQL35W")
        Dim write_score_sql As String
        Dim command As New Odbc.OdbcCommand
        write_score_sql = "Insert into user_scores (user_difficulty, user_id,score) values (" & int_Difficulty & "," & str_user_id & "," & int_Score & ");"
        con.Open()
        command.Connection = con
        command.CommandText = write_score_sql
        command.ExecuteNonQuery()

        con.Close()

    End Sub
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Form2.Close()
        Form3.Close()
        frm_Create_User.Close()
        Database_Score_Add()
        Me.Close()
    End Sub

    Private Sub btn_Resume_Click(sender As Object, e As EventArgs) Handles btn_Resume.Click
        grp_Game_Pause.Visible = False
        tmr_Mover.Start()
        Me.Focus()
    End Sub

    Private Sub btn_Game_Over_Exit_Click(sender As Object, e As EventArgs) Handles btn_Game_Over_Exit.Click
        Form2.Close()
        Form3.Close()
        frm_Create_User.Close()
        Me.Close()
    End Sub

    Private Sub btn_Return_Click(sender As Object, e As EventArgs) Handles btn_Return.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
