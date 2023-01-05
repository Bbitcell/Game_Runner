'Name: Mohammed Umer    211120074'
'      Mohammed Alzeer  201120206'
'Date: 10/12/22'
'This form displays a user login window that is connected to a database'


Imports System.Data.Odbc

Public Class Form3
    Public user_id As String

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click

        Dim con As New OdbcConnection("Dsn=PostgreSQL35W")
        Dim sql As String
        Dim command As New Odbc.OdbcCommand
        Dim da As New Odbc.OdbcDataAdapter
        Dim datatable As New DataTable

        Dim str_Username As String = txt_Username.Text
        Dim str_User_Password As String = txt_Password.Text

        con.Open()

        sql = "Select * from user_info Where username = '" & str_Username & "'" & " and user_password = '" & str_User_Password & "'"
        command.Connection = con
        command.CommandText = sql
        da.SelectCommand = command
        da.Fill(datatable)



        If datatable.Rows.Count > 0 Then

            sql = "Select user_id from user_info Where username = '" & str_Username & "'" & " and user_password = '" & str_User_Password & "'"
            command.Connection = con
            command.CommandText = sql
            user_id = command.ExecuteScalar()
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Try again, Take a coffee it seems like you need it")

        End If
        con.Close()

    End Sub

    Private Sub btn_Create_Account_Click(sender As Object, e As EventArgs) Handles btn_Create_Account.Click
        frm_Create_User.Show()
        Me.Hide()
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        frm_Create_User.Close()
        Form1.Close()
        Form2.Close()
        Me.Close()
    End Sub
End Class