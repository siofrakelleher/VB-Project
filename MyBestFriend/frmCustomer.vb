Public Class FrmCustomer
    'create an object of frmInvoice
    Public Shared frmInvoice As New FrmInvoice
    Public Shared strInvoice As String
    'declare customer information variables
    Public strName As String
    Public intAge As Integer
    Public intPhone As Integer
    Public strAddress As String
    Public strTown As String
    Public strCounty As String
    Public intCreditCard As Integer

    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = False
        radVisa.Checked = True
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'assign variables to GUI
        strName = txtName.Text
        Dim intAge As String
        intAge = mskAge.Text
        Dim intPhone As String
        intPhone = mskPhone.Text
        strAddress = txtAddress.Text
        strTown = txtTown.Text
        strCounty = txtCounty.Text
        Dim intCreditCard As String
        intCreditCard = mskCreditCard.Text
        txtAddress.Text = strAddress

        'if the Payment group is visible, then show the insurance form and close the current form
        If grpPayment.Visible Then
            strInvoice = txtName.Text
            frmInvoice.Visible = True
            Me.Visible = False
        End If
        'validate if textboxes are blank
        If txtName.Text = ("") Or mskAge.Text = ("") Or txtAddress.Text = ("") Or txtTown.Text = ("") Or txtCounty.Text = ("") Or mskPhone.Text = ("") Or mskCreditCard.Text = ("") Or mskInsuranceDate.Text = ("") Then
            MessageBox.Show("Field left empty, please fill in all information fields", "Error")
        End If
        'if grpCustomer is visible, then grpPayment is visible
        grpPayment.Visible = IIf(grpCustomer.Visible, True, False)

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskPhone.MaskInputRejected
        'stores telephone variable as integer
        MessageBox.Show("Please use correct telephone format")
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim DialogResult As DialogResult
        DialogResult = MessageBox.Show("Clear the current form?", "Clear Order",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2)

        'clear button clicked, will clear all textboxes
        If vbYes Then
            radVisa.Checked = True
            txtName.Clear()
            mskAge.Clear()
            txtAddress.Clear()
            txtTown.Clear()
            txtCounty.Clear()
            mskPhone.Clear()
            mskCreditCard.Clear()
            mskInsuranceDate.Clear()
            With txtName
                .Clear()
                .Focus()
            End With
        End If

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        strName = ""
    End Sub

End Class