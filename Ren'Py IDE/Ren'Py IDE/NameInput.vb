Public Class NameInput
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If NameTextBox.Text = "" Then
            MsgBox("Please enter a name for the new file.", MsgBoxStyle.Critical, "Error")
        Else
            Dim int As Integer
            Dim rtb As New RichTextBox
            With rtb
                .ForeColor = Color.White
                .Location = New Point(36, 0)
                .Size = New Size(361, 299)
                .Dock = DockStyle.Fill
                .BackColor = Color.Black
                .Font = New Font("Courier New", 12)
            End With
            int += 1
            Main.TabControl1.TabPages.Add(NameTextBox.Text)
            Main.TabControl1.SelectTab(int)
            Main.TabControl1.SelectedTab.Controls.Add(rtb)
            Me.Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
End Class