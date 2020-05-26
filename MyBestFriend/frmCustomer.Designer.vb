<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCustomer = New System.Windows.Forms.GroupBox()
        Me.mskAge = New System.Windows.Forms.MaskedTextBox()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtTown = New System.Windows.Forms.TextBox()
        Me.lblTown = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCounty = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblTelephone = New System.Windows.Forms.Label()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lstName = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpPayment = New System.Windows.Forms.GroupBox()
        Me.mskCreditCard = New System.Windows.Forms.MaskedTextBox()
        Me.mskInsuranceDate = New System.Windows.Forms.MaskedTextBox()
        Me.lblInsurance = New System.Windows.Forms.Label()
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.radAmEx = New System.Windows.Forms.RadioButton()
        Me.radLaser = New System.Windows.Forms.RadioButton()
        Me.radMastercard = New System.Windows.Forms.RadioButton()
        Me.radVisa = New System.Windows.Forms.RadioButton()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpCustomer.SuspendLayout()
        Me.grpPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomer
        '
        Me.grpCustomer.Controls.Add(Me.mskAge)
        Me.grpCustomer.Controls.Add(Me.mskPhone)
        Me.grpCustomer.Controls.Add(Me.txtTown)
        Me.grpCustomer.Controls.Add(Me.lblTown)
        Me.grpCustomer.Controls.Add(Me.txtName)
        Me.grpCustomer.Controls.Add(Me.txtCounty)
        Me.grpCustomer.Controls.Add(Me.txtAddress)
        Me.grpCustomer.Controls.Add(Me.lblTelephone)
        Me.grpCustomer.Controls.Add(Me.lblDesign)
        Me.grpCustomer.Controls.Add(Me.lblAddress)
        Me.grpCustomer.Controls.Add(Me.lblAge)
        Me.grpCustomer.Controls.Add(Me.lstName)
        Me.grpCustomer.Location = New System.Drawing.Point(13, 13)
        Me.grpCustomer.Name = "grpCustomer"
        Me.grpCustomer.Size = New System.Drawing.Size(351, 198)
        Me.grpCustomer.TabIndex = 0
        Me.grpCustomer.TabStop = False
        Me.grpCustomer.Text = "Customer Details"
        '
        'mskAge
        '
        Me.mskAge.Location = New System.Drawing.Point(114, 49)
        Me.mskAge.Mask = "00"
        Me.mskAge.Name = "mskAge"
        Me.mskAge.Size = New System.Drawing.Size(30, 20)
        Me.mskAge.TabIndex = 2
        Me.mskAge.ValidatingType = GetType(Integer)
        '
        'mskPhone
        '
        Me.mskPhone.BeepOnError = True
        Me.mskPhone.Location = New System.Drawing.Point(115, 166)
        Me.mskPhone.Mask = "(+353) 00-0000000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(147, 20)
        Me.mskPhone.TabIndex = 6
        '
        'txtTown
        '
        Me.txtTown.Location = New System.Drawing.Point(114, 109)
        Me.txtTown.Name = "txtTown"
        Me.txtTown.Size = New System.Drawing.Size(100, 20)
        Me.txtTown.TabIndex = 4
        '
        'lblTown
        '
        Me.lblTown.AutoSize = True
        Me.lblTown.Location = New System.Drawing.Point(35, 109)
        Me.lblTown.Name = "lblTown"
        Me.lblTown.Size = New System.Drawing.Size(59, 13)
        Me.lblTown.TabIndex = 13
        Me.lblTown.Text = "Town/City:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(114, 23)
        Me.txtName.MaxLength = 20
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(231, 20)
        Me.txtName.TabIndex = 1
        '
        'txtCounty
        '
        Me.txtCounty.Location = New System.Drawing.Point(114, 139)
        Me.txtCounty.MaxLength = 12
        Me.txtCounty.Name = "txtCounty"
        Me.txtCounty.Size = New System.Drawing.Size(100, 20)
        Me.txtCounty.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(114, 79)
        Me.txtAddress.MaxLength = 50
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(231, 20)
        Me.txtAddress.TabIndex = 3
        '
        'lblTelephone
        '
        Me.lblTelephone.AutoSize = True
        Me.lblTelephone.Location = New System.Drawing.Point(35, 169)
        Me.lblTelephone.Name = "lblTelephone"
        Me.lblTelephone.Size = New System.Drawing.Size(61, 13)
        Me.lblTelephone.TabIndex = 5
        Me.lblTelephone.Text = "Telephone:"
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Location = New System.Drawing.Point(51, 139)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(43, 13)
        Me.lblDesign.TabIndex = 4
        Me.lblDesign.Text = "County:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(46, 79)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 3
        Me.lblAddress.Text = "Address:"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(65, 52)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(29, 13)
        Me.lblAge.TabIndex = 2
        Me.lblAge.Text = "Age:"
        '
        'lstName
        '
        Me.lstName.AutoSize = True
        Me.lstName.Location = New System.Drawing.Point(56, 27)
        Me.lstName.Name = "lstName"
        Me.lstName.Size = New System.Drawing.Size(38, 13)
        Me.lstName.TabIndex = 0
        Me.lstName.Text = "Name:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(539, 217)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpPayment
        '
        Me.grpPayment.Controls.Add(Me.mskCreditCard)
        Me.grpPayment.Controls.Add(Me.mskInsuranceDate)
        Me.grpPayment.Controls.Add(Me.lblInsurance)
        Me.grpPayment.Controls.Add(Me.lblCreditCard)
        Me.grpPayment.Controls.Add(Me.radAmEx)
        Me.grpPayment.Controls.Add(Me.radLaser)
        Me.grpPayment.Controls.Add(Me.radMastercard)
        Me.grpPayment.Controls.Add(Me.radVisa)
        Me.grpPayment.Controls.Add(Me.lblPayment)
        Me.grpPayment.Location = New System.Drawing.Point(370, 13)
        Me.grpPayment.Name = "grpPayment"
        Me.grpPayment.Size = New System.Drawing.Size(242, 198)
        Me.grpPayment.TabIndex = 3
        Me.grpPayment.TabStop = False
        Me.grpPayment.Text = "Payment Details"
        Me.grpPayment.Visible = False
        '
        'mskCreditCard
        '
        Me.mskCreditCard.Location = New System.Drawing.Point(115, 93)
        Me.mskCreditCard.Mask = "0000-000-0000"
        Me.mskCreditCard.Name = "mskCreditCard"
        Me.mskCreditCard.Size = New System.Drawing.Size(100, 20)
        Me.mskCreditCard.TabIndex = 11
        Me.mskCreditCard.ValidatingType = GetType(Integer)
        '
        'mskInsuranceDate
        '
        Me.mskInsuranceDate.Location = New System.Drawing.Point(115, 130)
        Me.mskInsuranceDate.Mask = "00/00/0000"
        Me.mskInsuranceDate.Name = "mskInsuranceDate"
        Me.mskInsuranceDate.Size = New System.Drawing.Size(100, 20)
        Me.mskInsuranceDate.TabIndex = 12
        Me.mskInsuranceDate.ValidatingType = GetType(Date)
        '
        'lblInsurance
        '
        Me.lblInsurance.AutoSize = True
        Me.lblInsurance.Location = New System.Drawing.Point(7, 133)
        Me.lblInsurance.Name = "lblInsurance"
        Me.lblInsurance.Size = New System.Drawing.Size(110, 13)
        Me.lblInsurance.TabIndex = 7
        Me.lblInsurance.Text = "Initial Insurance Date:"
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Location = New System.Drawing.Point(7, 93)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(102, 13)
        Me.lblCreditCard.TabIndex = 6
        Me.lblCreditCard.Text = "Credit Card Number:"
        '
        'radAmEx
        '
        Me.radAmEx.AutoSize = True
        Me.radAmEx.Location = New System.Drawing.Point(178, 26)
        Me.radAmEx.Name = "radAmEx"
        Me.radAmEx.Size = New System.Drawing.Size(52, 17)
        Me.radAmEx.TabIndex = 8
        Me.radAmEx.TabStop = True
        Me.radAmEx.Text = "AmEx"
        Me.radAmEx.UseVisualStyleBackColor = True
        '
        'radLaser
        '
        Me.radLaser.AutoSize = True
        Me.radLaser.Location = New System.Drawing.Point(176, 50)
        Me.radLaser.Name = "radLaser"
        Me.radLaser.Size = New System.Drawing.Size(51, 17)
        Me.radLaser.TabIndex = 10
        Me.radLaser.TabStop = True
        Me.radLaser.Text = "Laser"
        Me.radLaser.UseVisualStyleBackColor = True
        '
        'radMastercard
        '
        Me.radMastercard.AutoSize = True
        Me.radMastercard.Location = New System.Drawing.Point(92, 50)
        Me.radMastercard.Name = "radMastercard"
        Me.radMastercard.Size = New System.Drawing.Size(78, 17)
        Me.radMastercard.TabIndex = 9
        Me.radMastercard.TabStop = True
        Me.radMastercard.Text = "Mastercard"
        Me.radMastercard.UseVisualStyleBackColor = True
        '
        'radVisa
        '
        Me.radVisa.AutoSize = True
        Me.radVisa.Location = New System.Drawing.Point(92, 26)
        Me.radVisa.Name = "radVisa"
        Me.radVisa.Size = New System.Drawing.Size(45, 17)
        Me.radVisa.TabIndex = 7
        Me.radVisa.TabStop = True
        Me.radVisa.Text = "Visa"
        Me.radVisa.UseVisualStyleBackColor = True
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(7, 26)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(78, 13)
        Me.lblPayment.TabIndex = 0
        Me.lblPayment.Text = "Payment Type:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(458, 217)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'FrmCustomer
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 252)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpPayment)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpCustomer)
        Me.Name = "FrmCustomer"
        Me.Text = "Customer Details"
        Me.grpCustomer.ResumeLayout(False)
        Me.grpCustomer.PerformLayout()
        Me.grpPayment.ResumeLayout(False)
        Me.grpPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpCustomer As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lstName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblTelephone As Label
    Friend WithEvents lblDesign As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtTown As TextBox
    Friend WithEvents lblTown As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents grpPayment As GroupBox
    Friend WithEvents radLaser As RadioButton
    Friend WithEvents radMastercard As RadioButton
    Friend WithEvents radVisa As RadioButton
    Friend WithEvents lblPayment As Label
    Friend WithEvents radAmEx As RadioButton
    Friend WithEvents lblInsurance As Label
    Friend WithEvents lblCreditCard As Label
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents mskInsuranceDate As MaskedTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents mskAge As MaskedTextBox
    Friend WithEvents mskCreditCard As MaskedTextBox
End Class
