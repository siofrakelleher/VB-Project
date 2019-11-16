Public Class frmInsurance
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
        'if Cat is selected, show Cat groupbox
        grpCat.Visible = True
        grpDog.Visible = False

        'if Cat and Grooming is selected, show Size groupbox
        If radCat.Checked And radGrooming.Checked Then
            grpSize.Visible = True
            grpFurType.Visible = False
        End If

        'if Cat and Training is selected, show Size groupbox
        If radCat.Checked And radTraining.Checked Then
            grpSize.Visible = True
            grpFurType.Visible = False
        End If
    End Sub

    Private Sub radDog_CheckedChanged(sender As Object, e As EventArgs) Handles radDog.CheckedChanged
        'if Dog is selected, show Dog groupbox
        grpDog.Visible = True
        grpCat.Visible = False

        'if Dog and Grooming is selected, show Size and fur type groupbox
        If radDog.Checked And radGrooming.Checked Then
            grpSize.Visible = True
            grpFurType.Visible = True
        End If

        'if Dog and Training is selected, show Size groupbox
        If radDog.Checked And radTraining.Checked Then
            grpSize.Visible = True
            grpFurType.Visible = False
        End If
    End Sub

    Private Sub radCrossbreedCat_CheckedChanged(sender As Object, e As EventArgs) Handles radCrossbreedCat.CheckedChanged
        'if crossbreed is selected, show crossbreed combobox
        If radCrossbreedCat.Checked Then
            lblCrossbreedCat.Visible = True
        End If
        'if crossbreed label is visible, then the crossbreed combobox is visible
        If lblCrossbreedCat.Visible Then
            cmbCrossbreed.Visible = True
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
        End If
        'if pedigree dog label is visible, then pedigree dog combobox is visible
        'crossbreed groupbox and mixed groupbox are not visible
        If lblPedigreeDog.Visible Then
            cmbPedigreeDog.Visible = True
            grpCrossbreed.Visible = False
            grpMixed.Visible = False
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'declare frm as variable
        Dim Invoice As New frmInvoice

        'if the Optional Add Ons group is visible, then show the next form and close the current form
        If grpAddOns.Visible Then
            frmInvoice.Visible = True
            Me.Close()
        End If

        'if grpInsurance is visible, then grpAddOns is visible
        grpAddOns.Visible = IIf(grpInsurance.Visible, True, False)
        'if grpPet is visible, then grpInsurance is visible
        grpInsurance.Visible = IIf(grpPet.Visible, True, False)

    End Sub

    Private Sub radGrooming_CheckedChanged(sender As Object, e As EventArgs) Handles radGrooming.CheckedChanged
        'if cat and grooming is selected, show size groupbox
        If radCat.Checked Then
            grpSize.Visible = True
        End If
        'if dog and grooming is selected, show size and furtype groupbox
        If radCat.Checked Then
            grpSize.Visible =
            grpFurType.Visible = True
        End If

    End Sub

    Private Sub radTraining_CheckedChanged(sender As Object, e As EventArgs) Handles radTraining.CheckedChanged
        'if cat or dog radio buttons and training radio button is selected, show size groupbox
        If radCat.Checked Or radDog.Checked Then
            grpSize.Visible = True
        End If

    End Sub
End Class