'Name: Mohammed Umer    211120074'
'      Mohammed Alzeer  201120206'
'Date: 10/12/22'
'This form displays a user registration window that is connected to a database'


Imports System.Data.Odbc

Public Class frm_Create_User
    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strEmail As String = Me.txtEmail.Text
        Dim strPassword As String = Me.txtPassword.Text
        Dim strUserName As String = Me.txtUserName.Text
        Dim strAddress As String = Me.txtAddress.Text
        Dim strID As String = txtUniversityID.Text
        Dim strPhoneNumber As String = Me.txtPhoneNumber.Text
        '-------------Email--------------------'
        If strEmail.Contains("@") AndAlso strEmail.Contains(".com") Then
            strEmail = strEmail.ToLower
            lblEmail.Text = "Available"
            lblEmail.ForeColor = Color.Green
        Else
            lblEmail.Text = "The Email should look like this *****@****.com"
            lblEmail.ForeColor = Color.Red
        End If

        '-----------Password--------------------'
        If strPassword.Length >= 8 Then
            lblPassword.Text = "Perfect!"
            lblPassword.ForeColor = Color.Green
        Else
            lblPassword.Text = "Maybe you need to make it more Difficult? Minimum 8 Letters"
            lblPassword.ForeColor = Color.Red

        End If
        '------------------User Name-----------'
        If strUserName = strUserName.ToLower AndAlso strUserName.Length >= 1 AndAlso Not strUserName.Contains(" ") Then
            lblUserName.Text = "Available"
            lblUserName.ForeColor = Color.Green
        Else
            lblUserName.Text = "User name must be lower case, does not contain space, and must be atleast one character!!"
            lblUserName.ForeColor = Color.Red
        End If

        '------------------Mobile Number----------'
        If strPhoneNumber Like "05########" Then
            lblPhoneNumber.Text = "Available"
            lblPhoneNumber.ForeColor = Color.Green
        Else
            lblPhoneNumber.Text = "Must Begin With 05 and 10 characters, we prefer it Mobily Style"
            lblPhoneNumber.ForeColor = Color.Red

        End If
        '----------------University ID-----------'
        If strID Like "#########" Then
            lblUniversityID.Text = "Available"
            lblUniversityID.ForeColor = Color.Green
        Else
            lblUniversityID.Text = "It should amount to 9 numbers, check for any missing number"
            lblUniversityID.ForeColor = Color.Red

        End If
        '-----------------Address----------------'
        If strAddress = strAddress.Trim AndAlso strAddress.Length >= 3 Then
            strAddress = strAddress.ToLower
            lblAddress.Text = "So you live there?"
            lblAddress.ForeColor = Color.Green
        Else
            lblAddress.Text = "Please remove spaces and have atleast 3 characters. How could you mess this one up!"
            lblAddress.ForeColor = Color.Red
        End If






        '---------------------Registeration Message------------'


        If (lblPhoneNumber.ForeColor = Color.Red) Or (lblEmail.ForeColor = Color.Red) Or (lblAddress.ForeColor = Color.Red) Or (lblUserName.ForeColor = Color.Red) Or (lblUserName.ForeColor = Color.Red) Or (lblPassword.ForeColor = Color.Red) Or (lblUniversityID.ForeColor = Color.Red) Then
            MessageBox.Show("Something Isn't Right, double Check you filled the Form properly")
        Else


            Dim con As New OdbcConnection("Dsn=PostgreSQL35W")
            con.Open()
            Dim sql As String
            Dim command As New Odbc.OdbcCommand
            Dim da As New Odbc.OdbcDataAdapter
            Dim datatable As New DataTable


            sql = "INSERT INTO user_info (user_email, username, user_password, mobile_number, university_id, address) VALUES  ('" & strEmail & "','" & strUserName & "','" & strPassword & "','" & strPhoneNumber & "','" & strID & "','" & strAddress & "');"
            command.Connection = con
            command.CommandText = sql
            command.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Registered Successfully")
            Me.Hide()
            Form3.Show()
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtUserName.Text = ""
        txtUniversityID.Text = ""
        txtPassword.Text = ""
        txtPhoneNumber.Text = ""
        lblAddress.Text = ""
        lblEmail.Text = ""
        lblUserName.Text = ""
        lblUniversityID.Text = ""
        lblPassword.Text = ""
        lblPhoneNumber.Text = ""
    End Sub

End Class