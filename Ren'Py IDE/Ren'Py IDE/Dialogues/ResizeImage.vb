Public Class ResizeImage
    Dim int1 As Integer
    Dim int2 As Integer
    Private Function ResizeImg()
        Try

            Return New Bitmap(CType(Main.TabControl1.Controls.Item(0), PictureBox).Image, New Size(int1, int2))
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        int1 = Convert.ToInt32(Me.XText.Text)
        int2 = Convert.ToInt32(Me.YText.Text)

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class