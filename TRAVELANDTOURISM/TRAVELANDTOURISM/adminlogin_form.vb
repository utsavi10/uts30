Public Class adminlogin_form
    Dim an, apw As String
    Private Sub adminlogin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        an = adname.Text
        apw = adpass.Text
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        adname.Clear()
        adpass.Clear()
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles log.Click
        If (an.Equals("admin") And apw.Equals("secret")) Then
            Me.Close()
            adminpackage_form.Show()
        Else
            MessageBox.Show("Invalid Password or Username", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            adname.Clear()
            adpass.Clear()
        End If
    End Sub

    
End Class