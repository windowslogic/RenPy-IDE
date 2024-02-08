Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Version " & My.Application.Info.Version.ToString()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/windowslogic/RenPy-IDE")
    End Sub
End Class