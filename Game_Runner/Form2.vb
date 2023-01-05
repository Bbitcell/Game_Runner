'Name: Mohammed Umer    211120074'
'      Mohammed Alzeer  201120206'
'Date: 10/12/22'
'This form displays a game title screen window that user can select the difficlty of the game'


Public Class Form2
    Public int_Difficulty As Integer = 4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Play.Click
        If rdo_Easy.Checked Then
            int_Difficulty = 1
            Me.Hide()
            Dim frm As New Form1
            frm.Show()

        ElseIf rdo_Normal.Checked Then
            int_Difficulty = 2
            Me.Hide()
            Dim frm As New Form1
            frm.Show()
        ElseIf rdo_Hard.Checked Then
            int_Difficulty = 3
            Me.Hide()
            Dim frm As New Form1
            frm.Show()
        ElseIf rdo_Very_Hard.Checked Then
            int_Difficulty = 4
            Me.Hide()
            Dim frm As New Form1
            frm.Show()
        Else
            MessageBox.Show("Please Select Difficulty")
        End If

    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Form3.Show()
        Form3.txt_Password.Clear()
        Form3.txt_Username.Clear()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        frm_Create_User.Close()
        Form1.Close()
        Form3.Close()
        Me.Close()
    End Sub
End Class