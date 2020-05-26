Public Class FrmInsurance
    'declare totals variable
    Dim decPrice As Decimal
    Dim decAddons As Decimal
    Dim decExtras As Decimal

    Public Shared strInvoice As String
    'create new object of FrmCustomer
    Public Shared frmCustomer As New FrmCustomer

    'declare constants for insurance plans
    Const decEssentialPlan As Decimal = 252750D
    Const decPremierPlan As Decimal = 255000D
    Const decPlusPlan As Decimal = 257000D

    'declare constants for pedigree dogs insurance plans
    Const decAfricanHairlessEssential As Decimal = 1.14D
    Const decAfricanHairlessPremier As Decimal = 1.24D
    Const decAfricanHairlessPlus As Decimal = 1.35D
    Const decBoxerEssential As Decimal = 0.86D
    Const decBoxerPremier As Decimal = 0.94D
    Const decBoxerPlus As Decimal = 1.26D
    Const decChihuahuaEssential As Decimal = 1.83D
    Const decChihuahuaPremier As Decimal = 1.99D
    Const decChihuahuaPlus As Decimal = 2.04D
    Const decDalmationEssential As Decimal = 0.65D
    Const decDalmationPremier As Decimal = 0.79D
    Const decDalmationPlus As Decimal = 1D
    Const decEskimoEssential As Decimal = 1.14D
    Const decEskimoPremier As Decimal = 1.25D
    Const decEskimoPlus As Decimal = 1.56D
    Const decCollieEssential As Decimal = 0.95D
    Const decColliePremier As Decimal = 1.02D
    Const decColliePlus As Decimal = 1.3D
    Const decGreyHoundEssential As Decimal = 1.99D
    Const decGreyHoundPremier As Decimal = 2.14D
    Const decGreyHoundPlus As Decimal = 2.38D
    Const decHuskyEssential As Decimal = 1.85D
    Const decHuskyPremier As Decimal = 2.08D
    Const decHuskyPlus As Decimal = 2.25D
    Const decIrishSetterEssential As Decimal = 0.65D
    Const decIrishSetterPremier As Decimal = 0.8D
    Const decIrishSetterPlus As Decimal = 1.15D
    Const decTerrierEssential As Decimal = 1.77D
    Const decTerrierPremier As Decimal = 1.98D
    Const decTerrierPlus As Decimal = 2.12D
    Const decSpanielEssential As Decimal = 1.02D
    Const decSpanielPremier As Decimal = 1.22D
    Const decSpanielPlus As Decimal = 1.56D
    Const decRetrieverEssential As Decimal = 1.74D
    Const decRetrieverPremier As Decimal = 1.98D
    Const decRetrieverPlus As Decimal = 2.11D
    Const decMalteseEssential As Decimal = 1.47D
    Const decMaltesePremier As Decimal = 1.66D
    Const decMaltesePlus As Decimal = 1.99D
    Const decPugEssential As Decimal = 1.31D
    Const decPugPremier As Decimal = 1.61D
    Const decPugPlus As Decimal = 1.89D
    Const decRottweilerEssential As Decimal = 2.17D
    Const decRottweilerPremier As Decimal = 2.55D
    Const decRottweilerPlus As Decimal = 2.99D
    Const decStBernardEssential As Decimal = 1.63D
    Const decStBernardPremier As Decimal = 1.82D
    Const decStBernardPlus As Decimal = 2.02D
    Const decMastiffEssential As Decimal = 1.15D
    Const decMastiffPremier As Decimal = 1.3D
    Const decMastiffPlus As Decimal = 1.61D
    Const decSheepDogEssential As Decimal = 0.75D
    Const decSheepDogPremier As Decimal = 0.88D
    Const decSheepDogPlus As Decimal = 1.11D
    Const decYorkshireTerrierEssential As Decimal = 0.88D
    Const decYorkshireTerrierPremier As Decimal = 1.11D
    Const decYorkshireTerrierPlus As Decimal = 1.48D
    Const decOtherEssential As Decimal = 1.22D
    Const decOtherPremier As Decimal = 1.55D
    Const decOtherPlus As Decimal = 1.79D

    'declare constants for crossbreed dog size prices
    Const decSmallCrossbreedEssential As Decimal = 1.17D
    Const decSmallCrossbreedPremier As Decimal = 1.38D
    Const decSmallCrossbreedPlus As Decimal = 1.45D
    'both medium and small crossbreed and mixed dog prices are percentages multiplied by the small crossbreed and mixed dog prices
    Const decMediumDog As Decimal = 1.1D
    Const decLargeDog As Decimal = 1.2D

    'declare constants for mixed dog size prices
    Const decSmallMongrelEssential As Decimal = 0.99D
    Const decSmallMongrelPremier As Decimal = 1.09D
    Const decSmallMongrelPlus As Decimal = 1.29D

    'declare constants for pedigree cats price insurance plans
    Const decAngoraPedigreeEssential As Decimal = 0.72D
    Const decAngoraPedigreePremier As Decimal = 1.14D
    Const decAngoraPedigreePlus As Decimal = 1.48D
    Const decBurmesePedigreeEssential As Decimal = 0.77D
    Const decBurmesePedigreePremier As Decimal = 0.94D
    Const decBurmesePedigreePlus As Decimal = 1.19D
    Const decCymricPedigreeEssential As Decimal = 1.01D
    Const decCymricPedigreePremier As Decimal = 1.17D
    Const decCymricPedigreePlus As Decimal = 1.52D
    Const decDevonPedigreeEssential As Decimal = 0.74D
    Const decDevonPedigreePremier As Decimal = 1.08D
    Const decDevonPedigreePlus As Decimal = 1D
    Const decMauPedigreeEssential As Decimal = 1.1D
    Const decMauPedigreePremier As Decimal = 1.25D
    Const decMauPedigreePlus As Decimal = 1.56D
    Const decForestPedigreeEssential As Decimal = 0.95D
    Const decForestPedigreePremier As Decimal = 1.02D
    Const decForestPedigreePlus As Decimal = 1.3D
    Const decHavanaPedigreeEssential As Decimal = 0.87D
    Const decHavanaPedigreePremier As Decimal = 1.04D
    Const decHavanaPedigreePlus As Decimal = 1.39D
    Const decBobtailPedigreeEssential As Decimal = 1.05D
    Const decBobtailPedigreePremier As Decimal = 1.2D
    Const decBobtailPedigreePlus As Decimal = 1.44D
    Const decKoratPedigreeEssential As Decimal = 0.65D
    Const decKoratPedigreePremier As Decimal = 0.8D
    Const decKoratPedigreePlus As Decimal = 1.15D
    Const decManxPedigreeEssential As Decimal = 0.68D
    Const decManxPedigreePremier As Decimal = 0.83D
    Const decManxPedigreePlus As Decimal = 1.18D
    Const decNebelungPedigreeEssential As Decimal = 1.21D
    Const decNebelungPedigreePremier As Decimal = 1.45D
    Const decNebelungPedigreePlus As Decimal = 1.87D
    Const decOrientalPedigreeEssential As Decimal = 0.88D
    Const decOrientalPedigreePremier As Decimal = 1.08D
    Const decOrientalPedigreePlus As Decimal = 1.33D
    Const decPersianPedigreeEssential As Decimal = 1.47D
    Const decPersianPedigreePremier As Decimal = 1.66D
    Const decPersianPedigreePlus As Decimal = 1.99D
    Const decRagdollPedigreeEssential As Decimal = 0.98D
    Const decRagdollPedigreePremier As Decimal = 1.02D
    Const decRagdollPedigreePlus As Decimal = 1.21D
    Const decSiamesePedigreeEssential As Decimal = 1.33D
    Const decSiamesePedigreePremier As Decimal = 1.77D
    Const decSiamesePedigreePlus As Decimal = 2.01D
    Const decTiffanyPedigreeEssential As Decimal = 1.38D
    Const decTiffanyPedigreePremier As Decimal = 1.82D
    Const decTiffanyPedigreePlus As Decimal = 2.05D
    Const decOtherPedigreeEssential As Decimal = 2.25D
    Const decOtherPedigreePremier As Decimal = 2.4D
    Const decOtherPedigreePlus As Decimal = 2.89D

    'declare constants for crossbreed cat prices
    Const decAmericanCurlEssential As Decimal = 1.17D
    Const decBlueTabbyEssential As Decimal = 0.81D
    Const decCornishRexEssential As Decimal = 0.38D
    Const decExoticShorthairEssential As Decimal = 1.11D
    Const decMaineCoonEssential As Decimal = 0.69D
    Const decScottishFoldEssential As Decimal = 1.37D
    Const decBengalEssential As Decimal = 0.67D
    Const decTurkishEssential As Decimal = 1.15D
    Const decOtherCrossbreedEssential As Decimal = 1.84D

    'declare mixed breed cat prices
    Const decMoggieEssential As Decimal = 0.84D
    Const decLonghairEssential As Decimal = 1.06D
    Const decShorthairEssential As Decimal = 1.04
    Const decForeignShorthairEssential As Decimal = 1.09D
    Const decOtherMixedEssential As Decimal = 1.18D

    'all Crossbreed and Mixed Premier and Premier Plus plans are 10% and 20% each respectively
    Const decPremier As Decimal = 1.1D
    Const decPlus As Decimal = 1.2D

    'declare Grooming Services prices
    'for dogs
    Const decShortSmall = 25D
    Const decShortMedium = 30D
    Const decShortLarge = 35D
    Const decLongSmall = 45D
    Const decLongMedium = 50D
    Const decLongLarge = 55D
    'for cats
    Const decGroomingCatSmall = 20D
    Const decGroomingCatMedium = 25D

    'declare House training seminar prices
    Const decDogSmall = 18D
    Const decDogMedium = 22D
    Const decDogLarge = 28D
    Const decTrainingCat = 14D

    'declare insurance Plan extras prices
    Const decEUCover = 1D
    Const decNonEU = 1.25D
    Const decInjuryIllness = 0.25D
    Const decDental = 35D

    'declare variables for customer quote
    Dim decTotal As Decimal
    Dim intDays As Integer

    Private Sub cmbPlans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPlans.SelectedIndexChanged
        'declare insurance plan variables
        Dim strEssential As String
        Dim strPremier As String
        Dim strPlus As String

        'when plan selected from drop down, description will be shown in listbox
        If cmbPlans.SelectedIndex = 0 Then
            rtxtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered accidental injuries per policy year. Cover for each injury will continue for a maximum of 12 months from the date which the injury occurred, as long as you have paid the premium to keep the insurance in force. Once the time limit is reached for an injury, there will be no more cover for it. There is no cover for illness under this type of cover."

        ElseIf cmbPlans.SelectedIndex = 1 Then
            rtxtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered illnesses and injuries per policy year. Cover for each condition will continue for a maximum of 12 months from the date which the condition first occurred or started showing clinical signs, as long as you have paid the premium to keep the insurance in force. Once the time limit is reached for a condition, there will be no more cover for it."

        ElseIf cmbPlans.SelectedIndex = 2 Then
            rtxtDescription.Text = "Your pet will be covered up to the vet fee limit for all covered illnesses and injuries per policy year. As long as you have paid the premium to keep the insurance in force, cover will reinstate at renewal and all eligible conditions will continue to be covered up to the vet fee limit."
        End If
    End Sub

    Private Sub radCat_CheckedChanged(sender As Object, e As EventArgs) Handles radCat.CheckedChanged
        'if Cat is selected, reveal 'cat' UI elements otherwise reveal 'dog' UI elements
        If radCat.Checked Then
            grpCat.Visible = True
            grpDog.Visible = False
        Else
            grpCat.Visible = False
            grpDog.Visible = True
        End If
        updateOptionals()
    End Sub

    Private Sub radCrossbreedCat_CheckedChanged(sender As Object, e As EventArgs) Handles radCrossbreedCat.CheckedChanged
        'if crossbreed is selected, show crossbreed combobox
        If radCrossbreedCat.Checked Then
            lblCrossbreedCat.Visible = True
            cmbCrossbreed.Visible = True
        End If
        'if crossbreed UI is visible, then the rest of cat UI is invisible
        If lblCrossbreedCat.Visible And cmbCrossbreed.Visible Then
            lblMixedCat.Visible = False
            cmbMixed.Visible = False
            lblPedigreeCat.Visible = False
            cmbPedigreeCat.Visible = False
        End If

    End Sub

    Private Sub radMixedCat_CheckedChanged(sender As Object, e As EventArgs) Handles radMixedCat.CheckedChanged
        'if mixed is selected, show mixed combobox
        If radMixedCat.Checked Then
            lblMixedCat.Visible = True
        End If
        'if the mixed label is visible, then the mixed combobox is visible
        If lblMixedCat.Visible Then
            cmbMixed.Visible = True
            lblPedigreeCat.Visible = False
            cmbPedigreeCat.Visible = False
            lblCrossbreedCat.Visible = False
            cmbCrossbreed.Visible = False
        End If
    End Sub

    Private Sub radPedigreeCat_CheckedChanged(sender As Object, e As EventArgs) Handles radPedigreeCat.CheckedChanged
        'if pedigree is selected, show pedigree label
        If radPedigreeCat.Checked Then
            lblPedigreeCat.Visible = True
        End If
        'if pedigree label is visble, show the pedigree combobox
        If lblPedigreeCat.Visible Then
            cmbPedigreeCat.Visible = True
            lblMixedCat.Visible = False
            cmbMixed.Visible = False
            lblCrossbreedCat.Visible = False
            cmbCrossbreed.Visible = False
        End If
    End Sub

    Private Sub radCrossbreedDog_CheckedChanged(sender As Object, e As EventArgs) Handles radCrossbreedDog.CheckedChanged
        'if crossbreed is selected, show crossbreed groupbox
        If radCrossbreedDog.Checked Then
            grpCrossbreed.Visible = True
        End If
        'mixed groupbox, pedigree dog label and combobox are not visible
        If grpCrossbreed.Visible Then
            grpMixed.Visible = False
            lblPedigreeDog.Visible = False
            cmbPedigreeDog.Visible = False
        End If
    End Sub

    Private Sub radMixedDog_CheckedChanged(sender As Object, e As EventArgs) Handles radMixedDog.CheckedChanged
        'if mixed breed is selected, show mixed breed groupbox
        If radMixedDog.Checked Then
            grpMixed.Visible = True
        End If
        'crossbreed groupbox, pedigree dog label and combobox are not visible
        If grpMixed.Visible Then
            grpCrossbreed.Visible = False
            lblPedigreeDog.Visible = False
            cmbPedigreeDog.Visible = False
        End If
    End Sub

    Private Sub radPedigreeDog_CheckedChanged(sender As Object, e As EventArgs) Handles radPedigreeDog.CheckedChanged
        'if pedigree is selected, show pedigree groupbox
        If radPedigreeDog.Checked Then
            lblPedigreeDog.Visible = True
            cmbPedigreeDog.Visible = True
        End If
        'if pedigree dog UI is visible, all other dog UI is invisible
        If lblPedigreeDog.Visible And cmbPedigreeDog.Visible Then
            grpCrossbreed.Visible = False
            grpMixed.Visible = False
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'If the Optional Extras group Is visible, Then show the Next form and close the current form
        If grpExtras.Visible Then
            strInvoice = txtQuote.Text
            frmCustomer.Visible = True
            Me.Visible = False
        End If
        'I tried to code better user design here but ran out of time to fix the issues I had with it executing correctly

        'if grppet is visible, then grpaddons is visible
        'grpAddOns.Visible = IIf(grpPet.Visible, True, False)

        'if grpaddons is visible, then grpinsurance is visible
        'If grpPet.Visible And grpAddOns.Visible Then
        'grpInsurance.Visible = True
        'End If
        'grpinsurance.visible = iif(grpaddons.visible, true, false)

        'if grpinsurance is visible, then grpextras is visible
        'grpextras.visible = iif(grpinsurance.visible, true, false
    End Sub

    Private Sub updateOptionals()
        ' check for applicable options for cat/dog
        grpSize.Visible = True
        If radCat.Checked And radGrooming.Checked Then
            radLarge.Visible = False
        Else radLarge.Visible = True
        End If
        If radGrooming.Checked Then
            If radDog.Checked Then
                grpFurType.Visible = True
            Else
                grpFurType.Visible = False
            End If
        Else
            grpFurType.Visible = False
        End If
    End Sub

    Private Sub radGrooming_CheckedChanged(sender As Object, e As EventArgs) Handles radGrooming.CheckedChanged
        ' check for applicable options for cat/dog
        updateOptionals()
    End Sub

    Private Sub radTraining_CheckedChanged(sender As Object, e As EventArgs) Handles radTraining.CheckedChanged
        'if cat or dog radio buttons and training radio button is selected, show size groupbox
        grpSize.Visible = True
        If radCat.Checked Then
            radLarge.Visible = False
        End If
        If radDog.Checked Then
            radLarge.Visible = True
        End If
    End Sub

    Private Sub frmInsurance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'preselect UI elements for suitable default values
        radCat.Checked = True
        radCrossbreedCat.Checked = True
        radPedigreeDog.Checked = True
        radSmallMongrel.Checked = True
        radSmall1.Checked = True
        cmbPlans.SelectedIndex = 0
        cmbPedigreeCat.SelectedIndex = 0
        cmbPedigreeDog.SelectedIndex = 0
        cmbCrossbreed.SelectedIndex = 0
        cmbMixed.SelectedIndex = 0
        radSmall.Checked = True
        radShort.Checked = True
    End Sub

    Private Sub btnQuote_Click(sender As Object, e As EventArgs) Handles btnQuote.Click
        Dim decPrice As Decimal
        'cat selection reported in quote textbox
        If radCat.Checked Then
            txtQuote.Text = radCat.Text & vbCrLf
            Select Case cmbPlans.SelectedIndex 'show crossbreed price per day in quote textbox
                Case 0 'essential cover
                    If radCrossbreedCat.Checked Then
                        txtQuote.Text += radCrossbreedCat.Text & vbCrLf & cmbCrossbreed.SelectedItem & ": "
                        Select Case cmbCrossbreed.SelectedIndex
                            Case 0
                                decPrice += decAmericanCurlEssential * 365
                            Case 1
                                decPrice += decBlueTabbyEssential * 365
                            Case 2
                                decPrice += decCornishRexEssential * 365
                            Case 3
                                decPrice += decExoticShorthairEssential * 365
                            Case 4
                                decPrice += decMaineCoonEssential * 365
                            Case 5
                                decPrice += decScottishFoldEssential * 365
                            Case 6
                                decPrice += decBengalEssential * 365
                            Case 8
                                decPrice += decTurkishEssential * 365
                            Case 7
                                decPrice += decOtherCrossbreedEssential * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
                Case 1 'premier cover
                    If radCrossbreedCat.Checked Then
                        txtQuote.Text += radCrossbreedCat.Text & vbCrLf & cmbPlans.SelectedItem & ": "
                        Select Case cmbCrossbreed.SelectedIndex
                            Case 0
                                decPrice += decAmericanCurlEssential * decPremier * 365
                            Case 1
                                decPrice += decBlueTabbyEssential * decPremier * 365
                            Case 2
                                decPrice += decCornishRexEssential * decPremier * 365
                            Case 3
                                decPrice += decExoticShorthairEssential * decPremier * 365
                            Case 4
                                decPrice += decMaineCoonEssential * decPremier * 365
                            Case 5
                                decPrice += decScottishFoldEssential * decPremier * 365
                            Case 6
                                decPrice += decBengalEssential * decPremier * 365
                            Case 8
                                decPrice += decTurkishEssential * decPremier * 365
                            Case 7
                                decPrice += decOtherCrossbreedEssential * decPremier * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
                Case 2 'premier plus
                    If radCrossbreedCat.Checked Then
                        txtQuote.Text += radCrossbreedCat.Text & vbCrLf & cmbPlans.SelectedItem & ": "
                        Select Case cmbCrossbreed.SelectedIndex
                            Case 0
                                decPrice += decAmericanCurlEssential * decPlus * 365
                            Case 1
                                decPrice += decBlueTabbyEssential * decPlus * 365
                            Case 2
                                decPrice += decCornishRexEssential * decPlus * 365
                            Case 3
                                decPrice += decExoticShorthairEssential * decPlus * 365
                            Case 4
                                decPrice += decMaineCoonEssential * decPlus * 365
                            Case 5
                                decPrice += decScottishFoldEssential * decPlus * 365
                            Case 6
                                decPrice += decBengalEssential * decPlus * 365
                            Case 8
                                decPrice += decTurkishEssential * decPlus * 365
                            Case 7
                                decPrice += decOtherCrossbreedEssential * decPlus * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
            End Select
            Select Case cmbPlans.SelectedIndex 'show pedigree price per day in quote textbox
                Case 0 'essential cover
                    If radPedigreeCat.Checked Then
                        txtQuote.Text += radPedigreeCat.Text & vbCrLf & cmbPedigreeCat.SelectedItem & ": "
                        Select Case cmbPedigreeCat.SelectedIndex
                            Case 0
                                decPrice += decAngoraPedigreeEssential * 365
                            Case 1
                                decPrice += decBurmesePedigreeEssential * 365
                            Case 2
                                decPrice += decCymricPedigreeEssential * 365
                            Case 3
                                decPrice += decDevonPedigreeEssential * 365
                            Case 4
                                decPrice += decMauPedigreeEssential * 365
                            Case 5
                                decPrice += decForestPedigreeEssential * 365
                            Case 6
                                decPrice += decHavanaPedigreeEssential * 365
                            Case 8
                                decPrice += decBobtailPedigreeEssential * 365
                            Case 9
                                decPrice += decManxPedigreeEssential * 365
                            Case 10
                                decPrice += decNebelungPedigreeEssential * 365
                            Case 11
                                decPrice += decOrientalPedigreeEssential * 365
                            Case 12
                                decPrice += decPersianPedigreeEssential * 365
                            Case 13
                                decPrice += decRagdollPedigreeEssential * 365
                            Case 14
                                decPrice += decSiamesePedigreeEssential * 365
                            Case 15
                                decPrice += decTiffanyPedigreeEssential * 365
                            Case 16
                                decPrice += decOtherPedigreeEssential * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
                Case 1 'premier cover
                    If radPedigreeCat.Checked Then
                        txtQuote.Text += radPedigreeCat.Text & vbCrLf & cmbPedigreeCat.SelectedItem & ": "
                        Select Case cmbPedigreeCat.SelectedIndex
                            Case 0
                                decPrice += decAngoraPedigreeEssential * decPremier * 365
                            Case 1
                                decPrice += decBurmesePedigreeEssential * decPremier * 365
                            Case 2
                                decPrice += decCymricPedigreeEssential * decPremier * 365
                            Case 3
                                decPrice += decDevonPedigreeEssential * decPremier * 365
                            Case 4
                                decPrice += decMauPedigreeEssential * decPremier * 365
                            Case 5
                                decPrice += decForestPedigreeEssential * decPremier * 365
                            Case 6
                                decPrice += decHavanaPedigreeEssential * decPremier * 365
                            Case 8
                                decPrice += decBobtailPedigreeEssential * decPremier * 365
                            Case 9
                                decPrice += decManxPedigreeEssential * decPremier * 365
                            Case 10
                                decPrice += decNebelungPedigreeEssential * decPremier * 365
                            Case 11
                                decPrice += decOrientalPedigreeEssential * decPremier * 365
                            Case 12
                                decPrice += decPersianPedigreeEssential * decPremier * 365
                            Case 13
                                decPrice += decRagdollPedigreeEssential * decPremier * 365
                            Case 14
                                decPrice += decSiamesePedigreeEssential * decPremier * 365
                            Case 15
                                decPrice += decTiffanyPedigreeEssential * decPremier * 365
                            Case 16
                                decPrice += decOtherPedigreeEssential * decPremier * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
                Case 2 'premier plus cover
                    If radPedigreeCat.Checked Then
                        txtQuote.Text += radPedigreeCat.Text & vbCrLf & cmbPedigreeCat.SelectedItem & ": "
                        Select Case cmbPedigreeCat.SelectedIndex
                            Case 0
                                decPrice += decAngoraPedigreeEssential * decPlus * 365
                            Case 1
                                decPrice += decBurmesePedigreeEssential * decPlus * 365
                            Case 2
                                decPrice += decCymricPedigreeEssential * decPlus * 365
                            Case 3
                                decPrice += decDevonPedigreeEssential * decPlus * 365
                            Case 4
                                decPrice += decMauPedigreeEssential * decPlus * 365
                            Case 5
                                decPrice += decForestPedigreeEssential * decPlus * 365
                            Case 6
                                decPrice += decHavanaPedigreeEssential * decPlus * 365
                            Case 8
                                decPrice += decBobtailPedigreeEssential * decPlus * 365
                            Case 9
                                decPrice += decManxPedigreeEssential * decPlus * 365
                            Case 10
                                decPrice += decNebelungPedigreeEssential * decPlus * 365
                            Case 11
                                decPrice += decOrientalPedigreeEssential * decPlus * 365
                            Case 12
                                decPrice += decPersianPedigreeEssential * decPlus * 365
                            Case 13
                                decPrice += decRagdollPedigreeEssential * decPlus * 365
                            Case 14
                                decPrice += decSiamesePedigreeEssential * decPlus * 365
                            Case 15
                                decPrice += decTiffanyPedigreeEssential * decPlus * 365
                            Case 16
                                decPrice += decOtherPedigreeEssential * decPlus * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
            End Select
            Select Case cmbPlans.SelectedIndex 'show mixed price per day in quote textbox
                Case 0 'essential cover
                    If radMixedCat.Checked Then
                        txtQuote.Text += radMixedCat.Text & vbCrLf & cmbMixed.SelectedItem & ": "
                        Select Case cmbMixed.SelectedIndex
                            Case 0
                                decPrice += decMoggieEssential * 365
                            Case 1
                                decPrice += decLonghairEssential * 365
                            Case 2
                                decPrice += decShorthairEssential * 365
                            Case 3
                                decPrice += decForeignShorthairEssential * 365
                            Case 4
                                decPrice += decOtherMixedEssential * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
                Case 1 'premier cover
                    If radMixedCat.Checked Then
                        txtQuote.Text += radMixedCat.Text & vbCrLf & cmbMixed.SelectedItem & ": "
                        Select Case cmbMixed.SelectedIndex
                            Case 0
                                decPrice += decMoggieEssential * decPremier * 365
                            Case 1
                                decPrice += decLonghairEssential * decPremier * 365
                            Case 2
                                decPrice += decShorthairEssential * decPremier * 365
                            Case 3
                                decPrice += decForeignShorthairEssential * decPremier * 365
                            Case 4
                                decPrice += decOtherMixedEssential * decPremier * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
                Case 2 'premier plus cover
                    If radMixedCat.Checked Then
                        txtQuote.Text += radMixedCat.Text & vbCrLf & cmbMixed.SelectedItem & ": "
                        Select Case cmbMixed.SelectedIndex
                            Case 0
                                decPrice += decMoggieEssential * decPlus * 365
                            Case 1
                                decPrice += decLonghairEssential * decPlus * 365
                            Case 2
                                decPrice += decShorthairEssential * decPlus * 365
                            Case 3
                                decPrice += decForeignShorthairEssential * decPlus * 365
                            Case 4
                                decPrice += decOtherMixedEssential * decPlus * 365
                        End Select
                        txtQuote.Text += Format(decPrice, "Currency") & vbCrLf
                    End If
            End Select
        End If 'ending cat radio btn check

        'dog selection reported in quote textbox
        If radDog.Checked Then
            txtQuote.Text = radDog.Text & vbCrLf
            If radPedigreeDog.Checked Then
                txtQuote.Text += radPedigreeDog.Text & vbCrLf & cmbPedigreeDog.SelectedItem & ": "
                'show pedigree price per day in quote textbox
                Select Case cmbPlans.SelectedIndex
                    Case 0
                        Select Case cmbPedigreeDog.SelectedIndex
                            Case 0
                                decPrice += decAfricanHairlessEssential * 365
                            Case 1
                                decPrice += decBoxerEssential * 365
                            Case 2
                                decPrice += decChihuahuaEssential * 365
                            Case 3
                                decPrice += decDalmationEssential * 365
                            Case 4
                                decPrice += decEskimoEssential * 365
                            Case 5
                                decPrice += decCollieEssential * 365
                            Case 6
                                decPrice += decGreyHoundEssential * 365
                            Case 7
                                decPrice += decHuskyEssential * 365
                            Case 8
                                decPrice += decIrishSetterEssential * 365
                            Case 9
                                decPrice += decTerrierEssential * 365
                            Case 10
                                decPrice += decSpanielEssential * 365
                            Case 11
                                decPrice += decRetrieverEssential * 365
                            Case 12
                                decPrice += decMalteseEssential * 365
                            Case 13
                                decPrice += decPugEssential * 365
                            Case 14
                                decPrice += decRottweilerEssential * 365
                            Case 15
                                decPrice += decStBernardEssential * 365
                            Case 16
                                decPrice += decMastiffEssential * 365
                            Case 17
                                decPrice += decSheepDogEssential * 365
                            Case 18
                                decPrice += decYorkshireTerrierEssential * 365
                            Case 19
                                decPrice += decOtherPedigreeEssential * 365
                        End Select
                    Case 1
                        Select Case cmbPedigreeDog.SelectedIndex
                            Case 0
                                decPrice += decAfricanHairlessPremier * 365
                            Case 1
                                decPrice += decBoxerPremier * 365
                            Case 2
                                decPrice += decChihuahuaPremier * 365
                            Case 3
                                decPrice += decDalmationPremier * 365
                            Case 4
                                decPrice += decEskimoPremier * 365
                            Case 5
                                decPrice += decColliePremier * 365
                            Case 6
                                decPrice += decGreyHoundPremier * 365
                            Case 7
                                decPrice += decHuskyPremier * 365
                            Case 8
                                decPrice += decIrishSetterPremier * 365
                            Case 9
                                decPrice += decTerrierPremier * 365
                            Case 10
                                decPrice += decSpanielPremier * 365
                            Case 11
                                decPrice += decRetrieverPremier * 365
                            Case 12
                                decPrice += decMaltesePremier * 365
                            Case 13
                                decPrice += decPugPremier * 365
                            Case 14
                                decPrice += decRottweilerPremier * 365
                            Case 15
                                decPrice += decStBernardPremier * 365
                            Case 16
                                decPrice += decMastiffPremier * 365
                            Case 17
                                decPrice += decSheepDogPremier * 365
                            Case 18
                                decPrice += decYorkshireTerrierPremier * 365
                            Case 19
                                decPrice += decOtherPedigreePremier * 365
                        End Select
                    Case 2
                        Select Case cmbPedigreeDog.SelectedIndex
                            Case 0
                                decPrice += decAfricanHairlessPlus * 365
                            Case 1
                                decPrice += decBoxerPlus * 365
                            Case 2
                                decPrice += decChihuahuaPlus * 365
                            Case 3
                                decPrice += decDalmationPlus * 365
                            Case 4
                                decPrice += decEskimoPlus * 365
                            Case 5
                                decPrice += decColliePlus * 365
                            Case 6
                                decPrice += decGreyHoundPlus * 365
                            Case 7
                                decPrice += decHuskyPlus * 365
                            Case 8
                                decPrice += decIrishSetterPlus * 365
                            Case 9
                                decPrice += decTerrierPlus * 365
                            Case 10
                                decPrice += decSpanielPlus * 365
                            Case 11
                                decPrice += decRetrieverPlus * 365
                            Case 12
                                decPrice += decMaltesePlus * 365
                            Case 13
                                decPrice += decPugPlus * 365
                            Case 14
                                decPrice += decRottweilerPlus * 365
                            Case 15
                                decPrice += decStBernardPlus * 365
                            Case 16
                                decPrice += decMastiffPlus * 365
                            Case 17
                                decPrice += decSheepDogPlus * 365
                            Case 18
                                decPrice += decYorkshireTerrierPlus * 365
                            Case 19
                                decPrice += decOtherPedigreePlus * 365
                        End Select
                End Select
                'show mixed price in quote textbox
            ElseIf radMixedDog.Checked Then
                txtQuote.Text += radMixedDog.Text & vbCrLf
                Select Case cmbPlans.SelectedIndex
                    Case 0 'Essential plan
                        If radSmallMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * 365
                            txtQuote.Text += radSmallMongrel.Text & ": "
                        ElseIf radMediumMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decMediumDog * 365
                            txtQuote.Text += radMediumMongrel.Text & ": "
                        ElseIf radLargeMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decLargeDog * 365
                            txtQuote.Text += radLargeMongrel.Text & ": "
                        End If
                    Case 1 'Premier plan
                        If radSmallMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decPremier * 365
                            txtQuote.Text += radSmallMongrel.Text & ": "
                        ElseIf radMediumMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decPremier * decMediumDog * 365
                            txtQuote.Text += radMediumMongrel.Text & ": "
                        ElseIf radLargeMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decPremier * decLargeDog * 365
                            txtQuote.Text += radLargeMongrel.Text & ": "
                        End If
                    Case 2 'Premier Plus plan
                        If radSmallMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decPlus * 365
                            txtQuote.Text += radSmallMongrel.Text & ": "
                        ElseIf radMediumMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decPlus * decMediumDog * 365
                            txtQuote.Text += radMediumMongrel.Text & ": "
                        ElseIf radLargeMongrel.Checked Then
                            decPrice += decSmallMongrelEssential * decPlus * decLargeDog * 365
                            txtQuote.Text += radLargeMongrel.Text & ": "
                        End If
                End Select
                'show crossbreed price per day in quote textbox
            ElseIf radCrossbreedDog.Checked Then
                txtQuote.Text += radCrossbreedDog.Text & vbCrLf
                Select Case cmbPlans.SelectedIndex
                    Case 0 'Essential Plan
                        If radSmall1.Checked Then
                            decPrice += decSmallCrossbreedEssential * 365
                            txtQuote.Text += radSmall1.Text & ": "
                        ElseIf radMedium1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decMediumDog * 365
                            txtQuote.Text += radMedium1.Text & ": "
                        ElseIf radLarge1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decLargeDog * 365
                            txtQuote.Text += radLarge1.Text & ": "
                        End If
                    Case 1 'Premier Plan
                        If radSmall1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decPremier * 365
                            txtQuote.Text += radSmall1.Text & ": "
                        ElseIf radMedium1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decMediumDog * decPremier * 365
                            txtQuote.Text += radMedium1.Text & ": "
                        ElseIf radLarge1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decLargeDog * decPremier * 365
                            txtQuote.Text += radLarge1.Text & ": "
                        End If
                    Case 2 'Premier Plus plan
                        If radSmall1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decPlus * 365
                            txtQuote.Text += radSmall1.Text & ": "
                        ElseIf radMedium1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decMediumDog * decPlus * 365
                            txtQuote.Text += radMedium1.Text & ": "
                        ElseIf radLarge1.Checked Then
                            decPrice += decSmallCrossbreedEssential * decLargeDog * decPlus * 365
                            txtQuote.Text += radLarge1.Text & ": "
                        End If
                End Select
            End If
            'format Price variable 
            txtQuote.Text += Format(decPrice, "Currency")
        End If 'ending dog radio btn check

        'declare Add on variable
        Dim decAddons As Decimal
        'optional addons selection reported in quote textbox
        If radGrooming.Checked Then
            'small/medium cat
            If radSmall.Checked And radCat.Checked Then
                txtQuote.Text += radGrooming.Text & vbCrLf
                txtQuote.Text += radSmall.Text & ": "
                decAddons = decGroomingCatSmall
            ElseIf radMedium.Checked And radCat.Checked Then
                txtQuote.Text += radGrooming.Text & vbCrLf
                txtQuote.Text += radMedium.Text & ": "
                decAddons = decGroomingCatMedium
            End If
            'small/medium/large dog with short/long fur type
            If radDog.Checked And radShort.Checked Then
                txtQuote.Text += vbCrLf & radGrooming.Text & vbCrLf
                txtQuote.Text += radShort.Text
                If radSmall.Checked Then 'small
                    decAddons += decShortSmall
                    txtQuote.Text += " " & radSmall.Text & ": "
                End If
                If radMedium.Checked Then 'medium
                    decAddons += decShortMedium
                    txtQuote.Text += " " & radMedium.Text & ": "
                End If
                If radLarge.Checked Then 'large
                    decAddons += decShortLarge
                    txtQuote.Text += " " & radLarge.Text & ": "
                End If
            ElseIf radDog.Checked And radLong.Checked Then
                txtQuote.Text += vbCrLf & radGrooming.Text & vbCrLf
                txtQuote.Text += radLong.Text
                If radSmall.Checked Then 'small
                    decAddons += decLongSmall
                    txtQuote.Text += " " & radSmall.Text & ": "
                End If
                If radMedium.Checked Then 'medium
                    decAddons += decLongMedium
                    txtQuote.Text += " " & radMedium.Text & ": "
                End If
                If radLarge.Checked Then 'large
                    decAddons += decLongLarge
                    txtQuote.Text += " " & radLarge.Text & ": "
                End If
            End If
        End If
        If radTraining.Checked Then
            'small/medium/large cat
            If radCat.Checked Then
                decAddons += decTrainingCat
                txtQuote.Text += "House Training Seminar" & vbCrLf
                If radSmall.Checked Then
                    txtQuote.Text += radSmall.Text & ": "
                End If
                If radMedium.Checked Then
                    txtQuote.Text += radMedium.Text & ": "
                End If
                If radLarge.Checked Then
                    txtQuote.Text += radLarge.Text & ": "
                End If
            End If
            'small/medium/large dog
            If radDog.Checked Then
                txtQuote.Text += vbCrLf & "House Training Seminar" & vbCrLf
                If radSmall.Checked Then
                    decAddons += decDogSmall
                    txtQuote.Text += radSmall.Text & ": "
                End If
                If radMedium.Checked Then
                    decAddons += decDogMedium
                    txtQuote.Text += radMedium.Text & ": "
                End If
                If radLarge.Checked Then
                    decAddons += decDogLarge
                    txtQuote.Text += radLarge.Text & ": "
                End If
            End If
        End If
        txtQuote.Text += Format(decAddons, "Currency")
        'declare Extras variable
        Dim decExtras As Decimal
        'insurance extras selection reported in quote textbox
        txtQuote.Text += vbCrLf & "Optional Extras"
        If chkEU.Checked Then
            decExtras += decEUCover
            txtQuote.Text += vbCrLf & chkEU.Text & ": €" & decEUCover
        End If
        If chkNonEU.Checked Then
            decExtras += decNonEU
            txtQuote.Text += vbCrLf & chkNonEU.Text & ": €" & decNonEU
        End If
        If chkInjury.Checked Then
            decExtras += decInjuryIllness
            txtQuote.Text += vbCrLf & chkInjury.Text & ": €" & decInjuryIllness
        End If
        If chkDental.Checked Then
            decExtras += decDental
            txtQuote.Text += vbCrLf & chkDental.Text & ": €" & decDental
        End If
        'format Extras variable
        txtQuote.Text += vbCrLf & "Total Extras:" & Format(decExtras, "Currency")
    End Sub
End Class