Public Class HomePage

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub contact_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles contact.LinkClicked
        Me.Hide()
        contact_form.Show()

    End Sub

    Private Sub aboutus_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles aboutus.LinkClicked
        Me.Hide()
        AboutUs_form.Show()

    End Sub

    Private Sub userlogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles userlogin.LinkClicked
        Me.Hide()
        Userlogin_form.Show()
    End Sub

    Private Sub adminlogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles adminlogin.LinkClicked
        Me.Hide()
        adminlogin_form.Show()
    End Sub
End Class



