Public Class MainMenu
    Public Shared instance As MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optional: Display current time
        Label3.Text = DateTime.Now.ToString("h:mmtt dddd").ToLower()
        instance = Me
    End Sub

    Private Sub btndatainput_Click(sender As Object, e As EventArgs) Handles btndatainput.Click
        Dim form As New datainputform()
        form.Show()
    End Sub

    Private Sub btnsortandanalysedata_Click(sender As Object, e As EventArgs) Handles btnsortandalysedata.Click
        Dim form As New analysedata()
        form.Show()
    End Sub

    Private Sub btnformcreation_Click(sender As Object, e As EventArgs) Handles btnformcreation.Click
        Dim form As New formcreation()
        form.Show()
    End Sub
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Hide()
        Login.Show()
    End Sub

End Class
