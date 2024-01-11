Public Class Form1

    Private Sub termslink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles termslink.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles resetbt.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you want to reset the values?", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            fnametext.Clear()
            lnametxt.Clear()
            gnametxt.Clear()
            addtxt.Clear()
            birthdate.ResetText()
            femradio.Checked = False
            maleradio.Checked = False
            otheradio.Checked = False
            classbox.ResetText()
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Pleace give acceptance and proceed", "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
