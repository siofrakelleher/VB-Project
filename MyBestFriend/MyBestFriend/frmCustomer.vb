Public Class FrmCustomer

    Const strName As String = ""
    Const strAge As String = ""
    Const strTelephone As String = ""
    Const strAddress As String = ""
    Const strTown As String = ""
    Const strCounty As String = "a; z"
    Const strCreditcard As String = ""


    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Visible = False
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'declare frmInsurancePlan as variable
        Dim InsurancePlan As New frmInsurance

        'if the Payment group is visible, then show the insurance form and close the current form
        If grpPayment.Visible Then
            frmInsurance.Visible = True
            Me.Close()
        End If

        'if grpCustomer is visible, then grpPayment is visible
        grpPayment.Visible = IIf(grpCustomer.Visible, True, False)

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskPhone.MaskInputRejected
        'stores telephone variable as integer
        Dim strTelephone As String = ""
        Dim Telephone As Integer = CInt(strTelephone)
        Dim intTelephone As Integer = "1, 9"
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskInsuranceDate.MaskInputRejected
        'stores date variable as integer
        'Dim intDate As Integer = ""
    End Sub

    Private Sub btnNext2_Click(sender As Object, e As EventArgs)
        'declare frmInsurancePlan as variable
        Dim InsurancePlan As New frmInsurance
        'if btnNext2 clicked, program moves onto next form
        frmInsurance.Show()
        Me.Visible = False
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear button clicked, will clear all textboxes
        txtName.Clear()
        mskAge.Clear()
        txtAddress.Clear()
        txtTown.Clear()
        txtCounty.Clear()
        mskPhone.Clear()
        mskCreditCard.Clear()
        mskInsuranceDate.Clear()

    End Sub
End Class