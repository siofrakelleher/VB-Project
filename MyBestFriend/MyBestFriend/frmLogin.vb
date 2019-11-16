
Public Class FrmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'declaring strusername as string with value yoconnor
        Dim strUsername As String = "yoconnor"
        'declaring strpassword as string with value ilovevb
        Dim strPassword As String = "ilovevb"

        'declaring variable to hold values entered by user
        Dim strInputUsername As String = "" 'value to be entered by user
        Dim strInputPassword As String = "" 'value to be entered by password

        'declare frmCustomer as variable
        Dim CustomerDetails As New FrmCustomer
        'declare frmLogin as variable
        Dim Login As New FrmLogin
        'when login button clicked, program checks if username and password is correct.
        'if username and password is correct then program moves onto customer details form
        'login form closes
        If (txtPassword.Text = strPassword) And (txtUsername.Text = strUsername) Then
            FrmCustomer.Show()
            Me.Visible = False

        Else
            'if username or password is wrong, message box appears
            'program shuts down
            MessageBox.Show("Incorrect Username/Password")
            ActiveForm.Visible = False
        End If


    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
