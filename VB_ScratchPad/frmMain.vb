Public Class frmMain
    Private Sub btnSayHello_Click(sender As Object, e As EventArgs) Handles btnSayHello.Click
        lblSayHello.Text = "Hello World!"
        lblSayName.Text = "My name is James!!!"
    End Sub

    Private Sub btnGoodbye_Click(sender As Object, e As EventArgs) Handles btnGoodbye.Click
        Application.Exit()
    End Sub
End Class
