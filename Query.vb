Public Class Query
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblShoeType As Double
        Dim dblCustomization(7) As Double
        Dim dblSubTotal As Double

        If cboType.Text = "Classic" Then
            dblShoeType = (54.95)
        ElseIf cboType.Text = "Retro" Then
            dblShoeType = (49.5)
        ElseIf cboType.Text = "Vintage" Then
            dblShoeType = (44.99)
        End If

        If chkQuarter.Checked Then
            dblCustomization(0) = (8.99)
        Else dblCustomization(0) = (0)
        End If

        If chkVamp.Checked Then
            dblCustomization(1) = (14.99)
        Else dblCustomization(1) = (0)
        End If

        If chkEyestay.Checked Then
            dblCustomization(2) = (5)
        Else dblCustomization(2) = (0)
        End If

        If chkHeelTab.Checked Then
            dblCustomization(3) = (4.99)
        Else dblCustomization(3) = (0)
        End If

        If chkBackCounter.Checked Then
            dblCustomization(4) = (6.49)
        Else dblCustomization(4) = (0)
        End If

        If chkLogo.Checked Then
            dblCustomization(5) = dblCustomization(7) / 0.18
        Else dblCustomization(5) = (0)
        End If

        If chkLaces.Checked Then
            dblCustomization(6) = (4.0)
        Else dblCustomization(6) = (0)
        End If

        dblCustomization(7) = dblCustomization(0) + dblCustomization(1) + dblCustomization(2) + dblCustomization(3) + dblCustomization(4) + dblCustomization(5) + dblCustomization(6) + dblCustomization(7)
        dblSubTotal = FormatCurrency(dblShoeType + dblCustomization(7))
        txtSub.Text = FormatCurrency(dblSubTotal)
        txtVat.Text = FormatCurrency(dblSubTotal * 0.23)
        txtTotal.Text = FormatCurrency(dblSubTotal + txtVat.Text)
    End Sub

    Private Sub cmbShoeType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.Text = "Classic" Then
            grpCustomization.Visible = True
        ElseIf cboType.Text = "Retro" Then
            grpCustomization.Visible = True
        ElseIf cboType.Text = "Vintage" Then
            grpCustomization.Visible = True
        End If
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSub.Text = ""
        txtVat.Text = ""
        txtTotal.Text = ""

        chkLaces.Checked = False
        chkBackCounter.Checked = False
        chkEyestay.Checked = False
        chkHeelTab.Checked = False
        chkLogo.Checked = False
        chkQuarter.Checked = False
        chkVamp.Checked = False
    End Sub
End Class