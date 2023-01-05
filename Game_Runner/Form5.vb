Public Class Form1
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strEmail As String = txtEmail.Text
        Dim strPassword As String = txtPassword.Text
        Dim strFirstName As String = txtFirstName.Text
        Dim strLastName As String = txtLastName.Text
        Dim strAddress As String = txtAddress.Text
        Dim strID As String = txtID.Text
        Dim strPhoneNumber As String = txtPhoneNumber.Text
        '-------------Email--------------------'
        If strEmail.Contains("@") AndAlso strEmail.Contains(".com") Then
            lblEmail.Text = "correct"
            lblEmail.ForeColor = Color.Green
        Else
            lblEmail.Text = "Incorrect Format"
            lblEmail.ForeColor = Color.Red
        End If

        '-----------Password--------------------'
        If strPassword.Length <= 8 Then
            lblPassword.Text = "correct"
            lblPassword.ForeColor = Color.Green
        Else
            lblPassword.Text = "Incorrect Format"
            lblPassword.ForeColor = Color.Red

        End If
        '------------------First Name-----------'
        If strFirstName = strFirstName.ToLower Then
            lblFirstName.Text = "correct"
            lblFirstName.ForeColor = Color.Green
        Else
            lblFirstName.Text = "Incorrect Format"
            lblFirstName.ForeColor = Color.Red
        End If
        '-----------------Last Name-------------'
        If strLastName = strLastName.ToLower Then
            lblLastName.Text = "correct"
            lblLastName.ForeColor = Color.Green
        Else
            lblLastName.Text = "Incorrect Format"
            lblLastName.ForeColor = Color.Red
        End If
        '------------------Mobile Number----------'
        If strPhoneNumber Like "05########" Then
            lblPhoneNumber.Text = "correct"
            lblPhoneNumber.ForeColor = Color.Green
        Else
            lblPhoneNumber.Text = "Incorrect Format"
            lblPhoneNumber.ForeColor = Color.Red

        End If
        '----------------University ID-----------'
        If strID Like "##########" Then
            lblUniversitiyID.Text = "correct"
            lblUniversitiyID.ForeColor = Color.Green
        Else
            lblUniversitiyID.Text = "Incorrect Format"
            lblUniversitiyID.ForeColor = Color.Red

        End If
        '-----------------Address----------------'
        If strAddress = strAddress.Trim Then
            lblAdress.Text = "correct"
            lblAdress.ForeColor = Color.Green
        Else
            lblAdress.Text = "Incorrect Format"
            lblAdress.ForeColor = Color.Red


        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAddress.Text = ""
        txtEmail.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtID.Text = ""
        txtPassword.Text = ""
        txtPhoneNumber.Text = ""
        lblAdress.Text = ""
        lblEmail.Text = ""
        lblFirstName.Text = ""
        lblLastName.Text = ""
        lblUniversitiyID.Text = ""
        lblPassword.Text = ""
        lblPhoneNumber.Text = ""
    End Sub
End Class
