Public Class signup_form

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Close()
        HomePage.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles resetbtn.Click
        fname.Clear()
        lname.Clear()
        uname.Clear()
        pword.Clear()
        contno.Clear()
        email.Clear()
    End Sub

    Private Sub signup_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim first, last, user, passw, emai, cont As String
        first = fname.Text
        last = lname.Text
        user = uname.Text
        passw = pword.Text
        cont = contno.Text
        emai = email.Text
    End Sub

    Private Sub regis_Click(sender As Object, e As EventArgs) Handles regis.Click
        Me.Close()
        package_form.Show()
    End Sub
End Class