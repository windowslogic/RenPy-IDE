Public Class CropImage
    Dim crop As Bitmap
    Dim cropx As Integer
    Dim cropy As Integer
    Dim cropwidth As Integer
    Dim cropheight As Integer
    Public croppen As Pen
    Public croppensize As Integer = 2
    Public cropdashstyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Dash
    Public croppencolor As Color = Color.AliceBlue
    Public c As Cursors
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If MsgBox("Are you sure you want to crop this image? This function is irreversible.", MsgBoxStyle.YesNo, "Ren'Py IDE") = MsgBoxResult.Yes Then
            Try
                If cropwidth < 1 Then
                    MsgBox("Please select the area of the image you want to crop.")
                Else
                    Dim rect As Rectangle = New Rectangle(cropx, cropy, cropwidth, cropheight)
                    Dim bit As Bitmap = New Bitmap(PictureBox1.Image, PictureBox1.Width, PictureBox1.Height)
                    crop = New Bitmap(cropwidth, cropheight)
                    Dim g As Graphics = Graphics.FromImage(crop)
                    g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
                    CType(Main.TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image = crop
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CropImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub CropImage_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        Try
            If e.Button = MouseButtons.Left Then
                cropx = e.X
                cropy = e.Y
                croppen = New Pen(croppencolor, croppensize)
                Cursor = Cursors.Cross
            End If
            PictureBox1.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CropImage_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Try
            If PictureBox1.Image Is Nothing Then Exit Sub
            If e.Button = MouseButtons.Left Then
                PictureBox1.Refresh()
                cropwidth = e.X - cropx
                cropheight = e.Y - cropy
                PictureBox1.CreateGraphics.DrawRectangle(croppen, cropx, cropy, cropwidth, cropheight)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CropImage_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        Try
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class