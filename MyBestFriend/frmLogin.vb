
Public Class FrmLogin
    'created new FrmInsurance object
    Public Shared frmInsurance As New FrmInsurance

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'declaring strusername as string with value yoconnor
        Dim strUsername As String = "yoconnor"
        'declaring strpassword as string with value ilovevb
        Dim strPassword As String = "ilovevb"

        'declaring variable to hold values entered by user
        Dim strInputUsername As String = "" 'value to be entered by user
        Dim strInputPassword As String = "" 'value to be entered by password

        'when login button clicked, program checks if username and password is correct.
        'if username and password is correct then program moves onto customer details form
        'login form closes
        If (txtPassword.Text = strPassword) And (txtUsername.Text = strUsername) Then
            frmInsurance.Show()
            Me.Visible = False

        Else
            'if username or password is wrong, message box appears
            'program shuts down
            MessageBox.Show("Incorrect Username/Password", "Error")
            ActiveForm.Visible = False
        End If


    End Sub

End Class
