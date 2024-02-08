Public Class Variables
    Public Shared Sub Save()
        If Main.TabControl1.SelectedTab.Text.Contains(".png") Or Main.TabControl1.SelectedTab.Text.Contains(".jpg") Or Main.TabControl1.SelectedTab.Text.Contains(".jpeg") Then
            Dim Saveas As New SaveFileDialog()
            Saveas.Filter = "PNG|*.png|JPEG|*.jpeg"
            Saveas.CheckPathExists = True
            Saveas.Title = "Save As"
            Saveas.FileName = Main.TabControl1.SelectedTab.Text
            Try
                If Saveas.ShowDialog(Main) = DialogResult.OK Then
                    Select Case Saveas.FilterIndex
                        Case 1
                            CType(Main.TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image.Save(Saveas.FileName, System.Drawing.Imaging.ImageFormat.Png)
                        Case 2
                            CType(Main.TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image.Save(Saveas.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    End Select
                End If
            Catch ex As Exception
                MsgBox("Could not save image.")
            End Try
        Else
            Dim Saveas As New SaveFileDialog()
            Dim myStreamWriter As System.IO.StreamWriter
            Saveas.Filter = "Ren'Py Code (*.rpy)|*.rpy"
            Saveas.CheckPathExists = True
            Saveas.Title = "Save As"
            Saveas.ShowDialog(Main)
            Try
                myStreamWriter = System.IO.File.AppendText(Saveas.FileName)
                myStreamWriter.Write(CType(Main.TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Text)
                myStreamWriter.Flush()
            Catch ex As Exception
                MsgBox("Could not save code.")
            End Try
        End If
    End Sub

    Public Shared Sub CloseTab()
        Main.TabControl1.SelectedTab.Dispose()

        If Main.TabControl1.TabCount < 1 Then
            Dim newtext As New RichTextBox
            Dim newtab As New TabPage
            Main.TabControl1.TabPages.Add(newtab)
            newtab.Controls.Add(newtext)
            newtext.Dock = DockStyle.Fill
            newtab.Text = "Untitled 1"
        End If
    End Sub
End Class
