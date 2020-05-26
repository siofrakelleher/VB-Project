Public Class FrmInvoice
    Private Sub FrmInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'quote from insurance form appears in invoice textbox
        txtInvoice.Text = "****** PLAN/PET DETAILS ********" & vbCrLf
        txtInvoice.Text += FrmInsurance.strInvoice & vbCrLf
        'customer details from customer form appears in invoice textbox
        txtInvoice.Text += vbCrLf & "****** CUSTOMER DETAILS ********" & vbCrLf
        txtInvoice.Text += FrmInsurance.frmCustomer.txtName.Text & vbCrLf
        txtInvoice.Text += FrmInsurance.frmCustomer.txtAddress.Text & vbCrLf
        txtInvoice.Text += FrmInsurance.frmCustomer.txtTown.Text & vbCrLf
        txtInvoice.Text += FrmInsurance.frmCustomer.txtCounty.Text & vbCrLf
        txtInvoice.Text += vbCrLf & "****** PAYMENT TYPE *********" & vbCrLf & "By: "
        txtInvoice.Text += IIf(FrmInsurance.frmCustomer.radVisa.Checked, FrmInsurance.frmCustomer.radVisa.Text, "")
        txtInvoice.Text += IIf(FrmInsurance.frmCustomer.radLaser.Checked, FrmInsurance.frmCustomer.radLaser.Text, "")
        txtInvoice.Text += IIf(FrmInsurance.frmCustomer.radMastercard.Checked, FrmInsurance.frmCustomer.radMastercard.Text, "")
        txtInvoice.Text += IIf(FrmInsurance.frmCustomer.radAmEx.Checked, FrmInsurance.frmCustomer.radAmEx.Text, "")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit programme
        Me.Close()
    End Sub

    Private Sub BtnStartOver_Click(sender As Object, e As EventArgs) Handles btnStartOver.Click
        ' Start over with plan selection
        Me.Visible = False
        FrmLogin.frmInsurance.Visible = True
    End Sub
End Class