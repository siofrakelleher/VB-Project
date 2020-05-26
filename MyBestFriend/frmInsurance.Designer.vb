<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInsurance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cmbPlans = New System.Windows.Forms.ComboBox()
        Me.rtxtDescription = New System.Windows.Forms.RichTextBox()
        Me.grpInsurance = New System.Windows.Forms.GroupBox()
        Me.grpPet = New System.Windows.Forms.GroupBox()
        Me.radDog = New System.Windows.Forms.RadioButton()
        Me.radCat = New System.Windows.Forms.RadioButton()
        Me.grpCat = New System.Windows.Forms.GroupBox()
        Me.radPedigreeCat = New System.Windows.Forms.RadioButton()
        Me.cmbMixed = New System.Windows.Forms.ComboBox()
        Me.cmbCrossbreed = New System.Windows.Forms.ComboBox()
        Me.lblMixedCat = New System.Windows.Forms.Label()
        Me.lblCrossbreedCat = New System.Windows.Forms.Label()
        Me.radMixedCat = New System.Windows.Forms.RadioButton()
        Me.radCrossbreedCat = New System.Windows.Forms.RadioButton()
        Me.lblPedigreeCat = New System.Windows.Forms.Label()
        Me.cmbPedigreeCat = New System.Windows.Forms.ComboBox()
        Me.grpDog = New System.Windows.Forms.GroupBox()
        Me.radPedigreeDog = New System.Windows.Forms.RadioButton()
        Me.radMixedDog = New System.Windows.Forms.RadioButton()
        Me.radCrossbreedDog = New System.Windows.Forms.RadioButton()
        Me.cmbPedigreeDog = New System.Windows.Forms.ComboBox()
        Me.grpCrossbreed = New System.Windows.Forms.GroupBox()
        Me.radSmall1 = New System.Windows.Forms.RadioButton()
        Me.radLarge1 = New System.Windows.Forms.RadioButton()
        Me.radMedium1 = New System.Windows.Forms.RadioButton()
        Me.lblPedigreeDog = New System.Windows.Forms.Label()
        Me.grpMixed = New System.Windows.Forms.GroupBox()
        Me.radLargeMongrel = New System.Windows.Forms.RadioButton()
        Me.radMediumMongrel = New System.Windows.Forms.RadioButton()
        Me.radSmallMongrel = New System.Windows.Forms.RadioButton()
        Me.grpAddOns = New System.Windows.Forms.GroupBox()
        Me.grpSize = New System.Windows.Forms.GroupBox()
        Me.radSmall = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLarge = New System.Windows.Forms.RadioButton()
        Me.grpFurType = New System.Windows.Forms.GroupBox()
        Me.radLong = New System.Windows.Forms.RadioButton()
        Me.radShort = New System.Windows.Forms.RadioButton()
        Me.radTraining = New System.Windows.Forms.RadioButton()
        Me.radGrooming = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.grpExtras = New System.Windows.Forms.GroupBox()
        Me.lblCover = New System.Windows.Forms.Label()
        Me.chkDental = New System.Windows.Forms.CheckBox()
        Me.chkInjury = New System.Windows.Forms.CheckBox()
        Me.chkNonEU = New System.Windows.Forms.CheckBox()
        Me.chkEU = New System.Windows.Forms.CheckBox()
        Me.btnQuote = New System.Windows.Forms.Button()
        Me.txtQuote = New System.Windows.Forms.TextBox()
        Me.grpInsurance.SuspendLayout()
        Me.grpPet.SuspendLayout()
        Me.grpCat.SuspendLayout()
        Me.grpDog.SuspendLayout()
        Me.grpCrossbreed.SuspendLayout()
        Me.grpMixed.SuspendLayout()
        Me.grpAddOns.SuspendLayout()
        Me.grpSize.SuspendLayout()
        Me.grpFurType.SuspendLayout()
        Me.grpExtras.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbPlans
        '
        Me.cmbPlans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPlans.FormattingEnabled = True
        Me.cmbPlans.Items.AddRange(New Object() {"Essential Cover(Accident Only)", "Premier Cover(Accident and Illness)", "Premier Plus Cover(Accident and Illness)"})
        Me.cmbPlans.Location = New System.Drawing.Point(6, 26)
        Me.cmbPlans.Name = "cmbPlans"
        Me.cmbPlans.Size = New System.Drawing.Size(258, 21)
        Me.cmbPlans.TabIndex = 1
        '
        'rtxtDescription
        '
        Me.rtxtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.rtxtDescription.Location = New System.Drawing.Point(6, 53)
        Me.rtxtDescription.Name = "rtxtDescription"
        Me.rtxtDescription.ReadOnly = True
        Me.rtxtDescription.Size = New System.Drawing.Size(258, 173)
        Me.rtxtDescription.TabIndex = 3
        Me.rtxtDescription.Text = ""
        '
        'grpInsurance
        '
        Me.grpInsurance.Controls.Add(Me.rtxtDescription)
        Me.grpInsurance.Controls.Add(Me.cmbPlans)
        Me.grpInsurance.Location = New System.Drawing.Point(536, 12)
        Me.grpInsurance.Name = "grpInsurance"
        Me.grpInsurance.Size = New System.Drawing.Size(272, 236)
        Me.grpInsurance.TabIndex = 4
        Me.grpInsurance.TabStop = False
        Me.grpInsurance.Text = "Insurance Plans"
        '
        'grpPet
        '
        Me.grpPet.Controls.Add(Me.radDog)
        Me.grpPet.Controls.Add(Me.radCat)
        Me.grpPet.Controls.Add(Me.grpCat)
        Me.grpPet.Controls.Add(Me.grpDog)
        Me.grpPet.Location = New System.Drawing.Point(12, 12)
        Me.grpPet.Name = "grpPet"
        Me.grpPet.Size = New System.Drawing.Size(324, 361)
        Me.grpPet.TabIndex = 5
        Me.grpPet.TabStop = False
        Me.grpPet.Text = "Pet Information"
        '
        'radDog
        '
        Me.radDog.AutoSize = True
        Me.radDog.Location = New System.Drawing.Point(59, 28)
        Me.radDog.Name = "radDog"
        Me.radDog.Size = New System.Drawing.Size(45, 17)
        Me.radDog.TabIndex = 2
        Me.radDog.TabStop = True
        Me.radDog.Text = "Dog"
        Me.radDog.UseVisualStyleBackColor = True
        '
        'radCat
        '
        Me.radCat.AutoSize = True
        Me.radCat.Location = New System.Drawing.Point(12, 28)
        Me.radCat.Name = "radCat"
        Me.radCat.Size = New System.Drawing.Size(41, 17)
        Me.radCat.TabIndex = 1
        Me.radCat.TabStop = True
        Me.radCat.Text = "Cat"
        Me.radCat.UseVisualStyleBackColor = True
        '
        'grpCat
        '
        Me.grpCat.Controls.Add(Me.radPedigreeCat)
        Me.grpCat.Controls.Add(Me.cmbMixed)
        Me.grpCat.Controls.Add(Me.cmbCrossbreed)
        Me.grpCat.Controls.Add(Me.lblMixedCat)
        Me.grpCat.Controls.Add(Me.lblCrossbreedCat)
        Me.grpCat.Controls.Add(Me.radMixedCat)
        Me.grpCat.Controls.Add(Me.radCrossbreedCat)
        Me.grpCat.Controls.Add(Me.lblPedigreeCat)
        Me.grpCat.Controls.Add(Me.cmbPedigreeCat)
        Me.grpCat.Location = New System.Drawing.Point(6, 61)
        Me.grpCat.Name = "grpCat"
        Me.grpCat.Size = New System.Drawing.Size(266, 139)
        Me.grpCat.TabIndex = 3
        Me.grpCat.TabStop = False
        Me.grpCat.Text = "Cat"
        '
        'radPedigreeCat
        '
        Me.radPedigreeCat.AutoSize = True
        Me.radPedigreeCat.Location = New System.Drawing.Point(184, 19)
        Me.radPedigreeCat.Name = "radPedigreeCat"
        Me.radPedigreeCat.Size = New System.Drawing.Size(67, 17)
        Me.radPedigreeCat.TabIndex = 7
        Me.radPedigreeCat.TabStop = True
        Me.radPedigreeCat.Text = "Pedigree"
        Me.radPedigreeCat.UseVisualStyleBackColor = True
        '
        'cmbMixed
        '
        Me.cmbMixed.FormattingEnabled = True
        Me.cmbMixed.Items.AddRange(New Object() {"Moggie", "Domestic Longhair", "Domestic Shorthair", "Foreign Shorthairs", "Other"})
        Me.cmbMixed.Location = New System.Drawing.Point(95, 73)
        Me.cmbMixed.Name = "cmbMixed"
        Me.cmbMixed.Size = New System.Drawing.Size(152, 21)
        Me.cmbMixed.TabIndex = 6
        Me.cmbMixed.Visible = False
        '
        'cmbCrossbreed
        '
        Me.cmbCrossbreed.FormattingEnabled = True
        Me.cmbCrossbreed.Items.AddRange(New Object() {"American Curl", "Blue Tabby", "Cornish Rex", "Exotic Shorthair", "Maine Coon", "Scottish Folds", "Snow Leopard Bengal Cat", "Turkish Van Cat", "Other"})
        Me.cmbCrossbreed.Location = New System.Drawing.Point(95, 46)
        Me.cmbCrossbreed.Name = "cmbCrossbreed"
        Me.cmbCrossbreed.Size = New System.Drawing.Size(152, 21)
        Me.cmbCrossbreed.TabIndex = 5
        Me.cmbCrossbreed.Visible = False
        '
        'lblMixedCat
        '
        Me.lblMixedCat.AutoSize = True
        Me.lblMixedCat.Location = New System.Drawing.Point(22, 76)
        Me.lblMixedCat.Name = "lblMixedCat"
        Me.lblMixedCat.Size = New System.Drawing.Size(69, 13)
        Me.lblMixedCat.TabIndex = 4
        Me.lblMixedCat.Text = "Mixed Breed:"
        Me.lblMixedCat.Visible = False
        '
        'lblCrossbreedCat
        '
        Me.lblCrossbreedCat.AutoSize = True
        Me.lblCrossbreedCat.Location = New System.Drawing.Point(26, 49)
        Me.lblCrossbreedCat.Name = "lblCrossbreedCat"
        Me.lblCrossbreedCat.Size = New System.Drawing.Size(63, 13)
        Me.lblCrossbreedCat.TabIndex = 3
        Me.lblCrossbreedCat.Text = "Crossbreed:"
        Me.lblCrossbreedCat.Visible = False
        '
        'radMixedCat
        '
        Me.radMixedCat.AutoSize = True
        Me.radMixedCat.Location = New System.Drawing.Point(94, 20)
        Me.radMixedCat.Name = "radMixedCat"
        Me.radMixedCat.Size = New System.Drawing.Size(84, 17)
        Me.radMixedCat.TabIndex = 2
        Me.radMixedCat.TabStop = True
        Me.radMixedCat.Text = "Mixed Breed"
        Me.radMixedCat.UseVisualStyleBackColor = True
        '
        'radCrossbreedCat
        '
        Me.radCrossbreedCat.AutoSize = True
        Me.radCrossbreedCat.Checked = True
        Me.radCrossbreedCat.Location = New System.Drawing.Point(9, 19)
        Me.radCrossbreedCat.Name = "radCrossbreedCat"
        Me.radCrossbreedCat.Size = New System.Drawing.Size(78, 17)
        Me.radCrossbreedCat.TabIndex = 1
        Me.radCrossbreedCat.TabStop = True
        Me.radCrossbreedCat.Text = "Crossbreed"
        Me.radCrossbreedCat.UseVisualStyleBackColor = True
        '
        'lblPedigreeCat
        '
        Me.lblPedigreeCat.AutoSize = True
        Me.lblPedigreeCat.Location = New System.Drawing.Point(6, 105)
        Me.lblPedigreeCat.Name = "lblPedigreeCat"
        Me.lblPedigreeCat.Size = New System.Drawing.Size(83, 13)
        Me.lblPedigreeCat.TabIndex = 0
        Me.lblPedigreeCat.Text = "Pedigree Breed:"
        Me.lblPedigreeCat.Visible = False
        '
        'cmbPedigreeCat
        '
        Me.cmbPedigreeCat.FormattingEnabled = True
        Me.cmbPedigreeCat.Items.AddRange(New Object() {"Angora", "Burmese", "Cymric", "Devon Rex", "Egyptian Mau", "Forest Cat", "Havana", "Japanese Bobtail", "Korat", "Manx", "Nebelung", "Oriental", "Persian", "Ragdoll", "Siamese", "Tiffany", "Other"})
        Me.cmbPedigreeCat.Location = New System.Drawing.Point(95, 102)
        Me.cmbPedigreeCat.Name = "cmbPedigreeCat"
        Me.cmbPedigreeCat.Size = New System.Drawing.Size(152, 21)
        Me.cmbPedigreeCat.TabIndex = 0
        Me.cmbPedigreeCat.Visible = False
        '
        'grpDog
        '
        Me.grpDog.Controls.Add(Me.radPedigreeDog)
        Me.grpDog.Controls.Add(Me.radMixedDog)
        Me.grpDog.Controls.Add(Me.radCrossbreedDog)
        Me.grpDog.Controls.Add(Me.cmbPedigreeDog)
        Me.grpDog.Controls.Add(Me.grpCrossbreed)
        Me.grpDog.Controls.Add(Me.lblPedigreeDog)
        Me.grpDog.Controls.Add(Me.grpMixed)
        Me.grpDog.Location = New System.Drawing.Point(6, 61)
        Me.grpDog.Name = "grpDog"
        Me.grpDog.Size = New System.Drawing.Size(311, 295)
        Me.grpDog.TabIndex = 9
        Me.grpDog.TabStop = False
        Me.grpDog.Text = "Dog"
        '
        'radPedigreeDog
        '
        Me.radPedigreeDog.AutoSize = True
        Me.radPedigreeDog.Checked = True
        Me.radPedigreeDog.Location = New System.Drawing.Point(6, 26)
        Me.radPedigreeDog.Name = "radPedigreeDog"
        Me.radPedigreeDog.Size = New System.Drawing.Size(67, 17)
        Me.radPedigreeDog.TabIndex = 11
        Me.radPedigreeDog.TabStop = True
        Me.radPedigreeDog.Text = "Pedigree"
        Me.radPedigreeDog.UseVisualStyleBackColor = True
        '
        'radMixedDog
        '
        Me.radMixedDog.AutoSize = True
        Me.radMixedDog.Location = New System.Drawing.Point(79, 26)
        Me.radMixedDog.Name = "radMixedDog"
        Me.radMixedDog.Size = New System.Drawing.Size(84, 17)
        Me.radMixedDog.TabIndex = 10
        Me.radMixedDog.TabStop = True
        Me.radMixedDog.Text = "Mixed Breed"
        Me.radMixedDog.UseVisualStyleBackColor = True
        '
        'radCrossbreedDog
        '
        Me.radCrossbreedDog.AutoSize = True
        Me.radCrossbreedDog.Location = New System.Drawing.Point(169, 26)
        Me.radCrossbreedDog.Name = "radCrossbreedDog"
        Me.radCrossbreedDog.Size = New System.Drawing.Size(78, 17)
        Me.radCrossbreedDog.TabIndex = 7
        Me.radCrossbreedDog.Text = "Crossbreed"
        Me.radCrossbreedDog.UseVisualStyleBackColor = True
        '
        'cmbPedigreeDog
        '
        Me.cmbPedigreeDog.FormattingEnabled = True
        Me.cmbPedigreeDog.Items.AddRange(New Object() {"African Hairless", "Boxer", "Chihuahua", "Dalmation", "Eskimo Dog", "Farm Collie", "Greyhound", "Husky", "Irish Setter", "Jack Russell Terrier", "King Charles Spaniel", "Labrador Retriever", "Maltese", "Pug", "Rottweiler", "St Bernard", "Tibetan Mastiff", "Working Sheep Dog", "Yorkshire Terrier", "Other"})
        Me.cmbPedigreeDog.Location = New System.Drawing.Point(98, 55)
        Me.cmbPedigreeDog.Name = "cmbPedigreeDog"
        Me.cmbPedigreeDog.Size = New System.Drawing.Size(206, 21)
        Me.cmbPedigreeDog.TabIndex = 3
        '
        'grpCrossbreed
        '
        Me.grpCrossbreed.Controls.Add(Me.radSmall1)
        Me.grpCrossbreed.Controls.Add(Me.radLarge1)
        Me.grpCrossbreed.Controls.Add(Me.radMedium1)
        Me.grpCrossbreed.Location = New System.Drawing.Point(9, 188)
        Me.grpCrossbreed.Name = "grpCrossbreed"
        Me.grpCrossbreed.Size = New System.Drawing.Size(200, 100)
        Me.grpCrossbreed.TabIndex = 7
        Me.grpCrossbreed.TabStop = False
        Me.grpCrossbreed.Text = "Crossbreed"
        Me.grpCrossbreed.Visible = False
        '
        'radSmall1
        '
        Me.radSmall1.AutoSize = True
        Me.radSmall1.Location = New System.Drawing.Point(6, 19)
        Me.radSmall1.Name = "radSmall1"
        Me.radSmall1.Size = New System.Drawing.Size(115, 17)
        Me.radSmall1.TabIndex = 4
        Me.radSmall1.TabStop = True
        Me.radSmall1.Text = "Small (up to 10kgs)"
        Me.radSmall1.UseVisualStyleBackColor = True
        '
        'radLarge1
        '
        Me.radLarge1.AutoSize = True
        Me.radLarge1.Location = New System.Drawing.Point(6, 65)
        Me.radLarge1.Name = "radLarge1"
        Me.radLarge1.Size = New System.Drawing.Size(140, 17)
        Me.radLarge1.TabIndex = 6
        Me.radLarge1.TabStop = True
        Me.radLarge1.Text = "Large (more than 20kgs)"
        Me.radLarge1.UseVisualStyleBackColor = True
        '
        'radMedium1
        '
        Me.radMedium1.AutoSize = True
        Me.radMedium1.Location = New System.Drawing.Point(6, 42)
        Me.radMedium1.Name = "radMedium1"
        Me.radMedium1.Size = New System.Drawing.Size(115, 17)
        Me.radMedium1.TabIndex = 5
        Me.radMedium1.TabStop = True
        Me.radMedium1.Text = "Medium (10-20kgs)"
        Me.radMedium1.UseVisualStyleBackColor = True
        '
        'lblPedigreeDog
        '
        Me.lblPedigreeDog.AutoSize = True
        Me.lblPedigreeDog.Location = New System.Drawing.Point(9, 58)
        Me.lblPedigreeDog.Name = "lblPedigreeDog"
        Me.lblPedigreeDog.Size = New System.Drawing.Size(83, 13)
        Me.lblPedigreeDog.TabIndex = 9
        Me.lblPedigreeDog.Text = "Pedigree Breed:"
        '
        'grpMixed
        '
        Me.grpMixed.Controls.Add(Me.radLargeMongrel)
        Me.grpMixed.Controls.Add(Me.radMediumMongrel)
        Me.grpMixed.Controls.Add(Me.radSmallMongrel)
        Me.grpMixed.Location = New System.Drawing.Point(9, 82)
        Me.grpMixed.Name = "grpMixed"
        Me.grpMixed.Size = New System.Drawing.Size(200, 100)
        Me.grpMixed.TabIndex = 8
        Me.grpMixed.TabStop = False
        Me.grpMixed.Text = "Mixed Breed"
        Me.grpMixed.Visible = False
        '
        'radLargeMongrel
        '
        Me.radLargeMongrel.AutoSize = True
        Me.radLargeMongrel.Location = New System.Drawing.Point(6, 65)
        Me.radLargeMongrel.Name = "radLargeMongrel"
        Me.radLargeMongrel.Size = New System.Drawing.Size(181, 17)
        Me.radLargeMongrel.TabIndex = 11
        Me.radLargeMongrel.TabStop = True
        Me.radLargeMongrel.Text = "Large Mongrel (more than 20kgs)"
        Me.radLargeMongrel.UseVisualStyleBackColor = True
        '
        'radMediumMongrel
        '
        Me.radMediumMongrel.AutoSize = True
        Me.radMediumMongrel.Location = New System.Drawing.Point(6, 42)
        Me.radMediumMongrel.Name = "radMediumMongrel"
        Me.radMediumMongrel.Size = New System.Drawing.Size(156, 17)
        Me.radMediumMongrel.TabIndex = 10
        Me.radMediumMongrel.TabStop = True
        Me.radMediumMongrel.Text = "Medium Mongrel (10-20kgs)"
        Me.radMediumMongrel.UseVisualStyleBackColor = True
        '
        'radSmallMongrel
        '
        Me.radSmallMongrel.AutoSize = True
        Me.radSmallMongrel.Location = New System.Drawing.Point(6, 19)
        Me.radSmallMongrel.Name = "radSmallMongrel"
        Me.radSmallMongrel.Size = New System.Drawing.Size(156, 17)
        Me.radSmallMongrel.TabIndex = 9
        Me.radSmallMongrel.TabStop = True
        Me.radSmallMongrel.Text = "Small Mongrel (up to 10kgs)"
        Me.radSmallMongrel.UseVisualStyleBackColor = True
        '
        'grpAddOns
        '
        Me.grpAddOns.Controls.Add(Me.grpSize)
        Me.grpAddOns.Controls.Add(Me.grpFurType)
        Me.grpAddOns.Controls.Add(Me.radTraining)
        Me.grpAddOns.Controls.Add(Me.radGrooming)
        Me.grpAddOns.Location = New System.Drawing.Point(342, 13)
        Me.grpAddOns.Name = "grpAddOns"
        Me.grpAddOns.Size = New System.Drawing.Size(188, 258)
        Me.grpAddOns.TabIndex = 6
        Me.grpAddOns.TabStop = False
        Me.grpAddOns.Text = "Optional Add-ons"
        '
        'grpSize
        '
        Me.grpSize.Controls.Add(Me.radSmall)
        Me.grpSize.Controls.Add(Me.radMedium)
        Me.grpSize.Controls.Add(Me.radLarge)
        Me.grpSize.Location = New System.Drawing.Point(6, 64)
        Me.grpSize.Name = "grpSize"
        Me.grpSize.Size = New System.Drawing.Size(84, 104)
        Me.grpSize.TabIndex = 10
        Me.grpSize.TabStop = False
        Me.grpSize.Text = "Size"
        Me.grpSize.Visible = False
        '
        'radSmall
        '
        Me.radSmall.AutoSize = True
        Me.radSmall.Checked = True
        Me.radSmall.Location = New System.Drawing.Point(6, 23)
        Me.radSmall.Name = "radSmall"
        Me.radSmall.Size = New System.Drawing.Size(50, 17)
        Me.radSmall.TabIndex = 7
        Me.radSmall.TabStop = True
        Me.radSmall.Text = "Small"
        Me.radSmall.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(6, 46)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 8
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLarge
        '
        Me.radLarge.AutoSize = True
        Me.radLarge.Location = New System.Drawing.Point(6, 69)
        Me.radLarge.Name = "radLarge"
        Me.radLarge.Size = New System.Drawing.Size(52, 17)
        Me.radLarge.TabIndex = 9
        Me.radLarge.TabStop = True
        Me.radLarge.Text = "Large"
        Me.radLarge.UseVisualStyleBackColor = True
        '
        'grpFurType
        '
        Me.grpFurType.Controls.Add(Me.radLong)
        Me.grpFurType.Controls.Add(Me.radShort)
        Me.grpFurType.Location = New System.Drawing.Point(6, 174)
        Me.grpFurType.Name = "grpFurType"
        Me.grpFurType.Size = New System.Drawing.Size(126, 73)
        Me.grpFurType.TabIndex = 2
        Me.grpFurType.TabStop = False
        Me.grpFurType.Text = "Fur Type"
        Me.grpFurType.Visible = False
        '
        'radLong
        '
        Me.radLong.AutoSize = True
        Me.radLong.Location = New System.Drawing.Point(10, 45)
        Me.radLong.Name = "radLong"
        Me.radLong.Size = New System.Drawing.Size(113, 17)
        Me.radLong.TabIndex = 2
        Me.radLong.TabStop = True
        Me.radLong.Text = "Long/Heavy/Curly"
        Me.radLong.UseVisualStyleBackColor = True
        '
        'radShort
        '
        Me.radShort.AutoSize = True
        Me.radShort.Checked = True
        Me.radShort.Location = New System.Drawing.Point(10, 22)
        Me.radShort.Name = "radShort"
        Me.radShort.Size = New System.Drawing.Size(91, 17)
        Me.radShort.TabIndex = 1
        Me.radShort.TabStop = True
        Me.radShort.Text = "Short/Smooth"
        Me.radShort.UseVisualStyleBackColor = True
        '
        'radTraining
        '
        Me.radTraining.AutoSize = True
        Me.radTraining.Location = New System.Drawing.Point(6, 41)
        Me.radTraining.Name = "radTraining"
        Me.radTraining.Size = New System.Drawing.Size(138, 17)
        Me.radTraining.TabIndex = 1
        Me.radTraining.TabStop = True
        Me.radTraining.Text = "House Training Seminar"
        Me.radTraining.UseVisualStyleBackColor = True
        '
        'radGrooming
        '
        Me.radGrooming.AutoSize = True
        Me.radGrooming.Checked = True
        Me.radGrooming.Location = New System.Drawing.Point(6, 18)
        Me.radGrooming.Name = "radGrooming"
        Me.radGrooming.Size = New System.Drawing.Size(114, 17)
        Me.radGrooming.TabIndex = 0
        Me.radGrooming.TabStop = True
        Me.radGrooming.Text = "Grooming Services"
        Me.radGrooming.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(976, 350)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "&Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'grpExtras
        '
        Me.grpExtras.Controls.Add(Me.lblCover)
        Me.grpExtras.Controls.Add(Me.chkDental)
        Me.grpExtras.Controls.Add(Me.chkInjury)
        Me.grpExtras.Controls.Add(Me.chkNonEU)
        Me.grpExtras.Controls.Add(Me.chkEU)
        Me.grpExtras.Location = New System.Drawing.Point(536, 254)
        Me.grpExtras.Name = "grpExtras"
        Me.grpExtras.Size = New System.Drawing.Size(272, 119)
        Me.grpExtras.TabIndex = 7
        Me.grpExtras.TabStop = False
        Me.grpExtras.Text = "Optional Extras"
        '
        'lblCover
        '
        Me.lblCover.AutoSize = True
        Me.lblCover.Location = New System.Drawing.Point(6, 23)
        Me.lblCover.Name = "lblCover"
        Me.lblCover.Size = New System.Drawing.Size(75, 13)
        Me.lblCover.TabIndex = 4
        Me.lblCover.Text = "Cover Abroad:"
        '
        'chkDental
        '
        Me.chkDental.AutoSize = True
        Me.chkDental.Location = New System.Drawing.Point(9, 93)
        Me.chkDental.Name = "chkDental"
        Me.chkDental.Size = New System.Drawing.Size(88, 17)
        Me.chkDental.TabIndex = 3
        Me.chkDental.Text = "Dental Cover"
        Me.chkDental.UseVisualStyleBackColor = True
        '
        'chkInjury
        '
        Me.chkInjury.AutoSize = True
        Me.chkInjury.Location = New System.Drawing.Point(9, 70)
        Me.chkInjury.Name = "chkInjury"
        Me.chkInjury.Size = New System.Drawing.Size(160, 17)
        Me.chkInjury.TabIndex = 2
        Me.chkInjury.Text = "Previous Injury/Illness Cover"
        Me.chkInjury.UseVisualStyleBackColor = True
        '
        'chkNonEU
        '
        Me.chkNonEU.AutoSize = True
        Me.chkNonEU.Location = New System.Drawing.Point(87, 47)
        Me.chkNonEU.Name = "chkNonEU"
        Me.chkNonEU.Size = New System.Drawing.Size(64, 17)
        Me.chkNonEU.TabIndex = 1
        Me.chkNonEU.Text = "Non-EU"
        Me.chkNonEU.UseVisualStyleBackColor = True
        '
        'chkEU
        '
        Me.chkEU.AutoSize = True
        Me.chkEU.Location = New System.Drawing.Point(87, 23)
        Me.chkEU.Name = "chkEU"
        Me.chkEU.Size = New System.Drawing.Size(41, 17)
        Me.chkEU.TabIndex = 0
        Me.chkEU.Text = "EU"
        Me.chkEU.UseVisualStyleBackColor = True
        '
        'btnQuote
        '
        Me.btnQuote.Location = New System.Drawing.Point(976, 281)
        Me.btnQuote.Name = "btnQuote"
        Me.btnQuote.Size = New System.Drawing.Size(75, 23)
        Me.btnQuote.TabIndex = 8
        Me.btnQuote.Text = "&Show Quote"
        Me.btnQuote.UseVisualStyleBackColor = True
        '
        'txtQuote
        '
        Me.txtQuote.Location = New System.Drawing.Point(814, 13)
        Me.txtQuote.Multiline = True
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.ReadOnly = True
        Me.txtQuote.Size = New System.Drawing.Size(237, 259)
        Me.txtQuote.TabIndex = 9
        '
        'FrmInsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 378)
        Me.Controls.Add(Me.txtQuote)
        Me.Controls.Add(Me.btnQuote)
        Me.Controls.Add(Me.grpExtras)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.grpAddOns)
        Me.Controls.Add(Me.grpPet)
        Me.Controls.Add(Me.grpInsurance)
        Me.Name = "FrmInsurance"
        Me.Text = "InsurancePlan"
        Me.grpInsurance.ResumeLayout(False)
        Me.grpPet.ResumeLayout(False)
        Me.grpPet.PerformLayout()
        Me.grpCat.ResumeLayout(False)
        Me.grpCat.PerformLayout()
        Me.grpDog.ResumeLayout(False)
        Me.grpDog.PerformLayout()
        Me.grpCrossbreed.ResumeLayout(False)
        Me.grpCrossbreed.PerformLayout()
        Me.grpMixed.ResumeLayout(False)
        Me.grpMixed.PerformLayout()
        Me.grpAddOns.ResumeLayout(False)
        Me.grpAddOns.PerformLayout()
        Me.grpSize.ResumeLayout(False)
        Me.grpSize.PerformLayout()
        Me.grpFurType.ResumeLayout(False)
        Me.grpFurType.PerformLayout()
        Me.grpExtras.ResumeLayout(False)
        Me.grpExtras.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbPlans As ComboBox
    Friend WithEvents rtxtDescription As RichTextBox
    Friend WithEvents rtxtDescription1 As RichTextBox
    Friend WithEvents grpInsurance As GroupBox
    Friend WithEvents grpPet As GroupBox
    Friend WithEvents radSmallMongrel As RadioButton
    Friend WithEvents grpMixed As GroupBox
    Friend WithEvents grpCrossbreed As GroupBox
    Friend WithEvents radSmall1 As RadioButton
    Friend WithEvents radLarge1 As RadioButton
    Friend WithEvents radMedium1 As RadioButton
    Friend WithEvents cmbPedigreeDog As ComboBox
    Friend WithEvents radDog As RadioButton
    Friend WithEvents radCat As RadioButton
    Friend WithEvents cmbPedigreeCat As ComboBox
    Friend WithEvents radLargeMongrel As RadioButton
    Friend WithEvents radMediumMongrel As RadioButton
    Friend WithEvents grpDog As GroupBox
    Friend WithEvents radMixedDog As RadioButton
    Friend WithEvents radCrossbreedDog As RadioButton
    Friend WithEvents lblPedigreeDog As Label
    Friend WithEvents grpCat As GroupBox
    Friend WithEvents lblMixedCat As Label
    Friend WithEvents lblCrossbreedCat As Label
    Friend WithEvents radMixedCat As RadioButton
    Friend WithEvents radCrossbreedCat As RadioButton
    Friend WithEvents lblPedigreeCat As Label
    Friend WithEvents radPedigreeCat As RadioButton
    Friend WithEvents cmbMixed As ComboBox
    Friend WithEvents cmbCrossbreed As ComboBox
    Friend WithEvents radPedigreeDog As RadioButton
    Friend WithEvents grpAddOns As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents grpFurType As GroupBox
    Friend WithEvents radTraining As RadioButton
    Friend WithEvents radGrooming As RadioButton
    Friend WithEvents radLong As RadioButton
    Friend WithEvents radShort As RadioButton
    Friend WithEvents radLarge As RadioButton
    Friend WithEvents radSmall As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents grpSize As GroupBox
    Friend WithEvents grpExtras As GroupBox
    Friend WithEvents lblCover As Label
    Friend WithEvents chkDental As CheckBox
    Friend WithEvents chkInjury As CheckBox
    Friend WithEvents chkNonEU As CheckBox
    Friend WithEvents chkEU As CheckBox
    Friend WithEvents btnQuote As Button
    Friend WithEvents txtQuote As TextBox
End Class
