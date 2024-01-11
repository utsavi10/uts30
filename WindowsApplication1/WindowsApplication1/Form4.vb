Public Class Form4

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End 'form1.close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim val As Integer
        Randomize()
        val = Int((600 * Rnd()) + 100)
        Label3.Text = val.ToString
    End Sub
End Class