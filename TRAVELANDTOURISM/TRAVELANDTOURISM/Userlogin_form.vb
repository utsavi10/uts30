Public Class Userlogin_form

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub signup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signup.LinkClicked
        Me.Close()
        signup_form.Show()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        password.Clear()
        username.Clear()
    End Sub

    
    Private Sub Userlogin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim un, pw As String
        un = username.Text
        pw = password.Text
    End Sub

    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Me.Close()
        package_form.Show()
    End Sub
End Class