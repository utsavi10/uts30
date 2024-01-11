Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.fnametext.Text
        TextBox2.Text = Form1.lnametxt.Text
        TextBox3.Text = Form1.gnametxt.Text
        TextBox4.Text = Form1.addtxt.Text
        TextBox5.Text = Form1.birthdate.Value

        If Form1.femradio.Checked Then
            TextBox6.Text = "Female"
        ElseIf Form1.maleradio.Checked Then
            TextBox6.Text = "Male"
        Else
            TextBox6.Text = "Other"
        End If
        TextBox7.Text = Form1.classbox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class