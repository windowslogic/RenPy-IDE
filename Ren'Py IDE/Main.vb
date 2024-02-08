Public Class Main
    Dim originalimage As Bitmap
    Dim Int As Integer = 0

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rtb As New RichTextBox
        rtb.Font = New Font("Courier New", 12)
        rtb.Dock = DockStyle.Fill
        rtb.ForeColor = Color.White()
        rtb.BackColor = Color.Black()
        TabControl1.TabPages.Add("Untitled " & Int + 1)
        TabControl1.SelectTab(Int)
        TabControl1.SelectedTab.Controls.Add(rtb)
        Int = Int + 1

        If My.Settings.TreePath = "" Then

        Else
            PopulateTreeView(My.Settings.TreePath)

        End If

    End Sub
#Region "TreeViewControl"
    Private Sub PopulateTreeView(path As String)
        TreeView1.Nodes.Clear()

        My.Settings.TreePath = path
        Dim rootNode = New TreeNode(path) With {.Tag = path}
        TreeView1.Nodes.Add(rootNode)
        AddDirectories(rootNode)
    End Sub

    Private Sub AddDirectories(parentNode As TreeNode)
        Dim path = DirectCast(parentNode.Tag, String)

        Dim directories = IO.Directory.GetDirectories(path)

        For Each dir As String In directories
            Dim directoryNode = New TreeNode(IO.Path.GetFileName(dir)) With {.Tag = dir}
            parentNode.Nodes.Add(directoryNode)

            Try
                Dim files = IO.Directory.GetFiles(dir)

                For Each file In files
                    Dim fileNode = New TreeNode(IO.Path.GetFileName(file)) With {.Tag = file}
                    directoryNode.Nodes.Add(fileNode)
                Next

                AddDirectories(directoryNode)
            Catch invalidAccessEx As UnauthorizedAccessException
                directoryNode.ForeColor = Color.Red
            End Try
        Next
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim dialog As New FolderBrowserDialog()
        TreeView1.Nodes.Add("Please wait...")
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Open Project Directory"
        If dialog.ShowDialog() = DialogResult.OK Then
            PopulateTreeView(dialog.SelectedPath)
            For Each n As TreeNode In TreeView1.Nodes
                For Each no As TreeNode In n.Nodes
                    If no.Text = "Please wait..." Then
                        no.Remove()
                    End If
                Next
            Next
        Else
            TreeView1.Nodes.Clear()
            TreeView1.Nodes.Add("Open a directory to start.")
        End If
    End Sub
#End Region
#Region "Menu"
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        New_Tab()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Variables.Save()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles CharacterCounter.Tick
        Try
            Dim caretindex As Integer = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectionStart
            Dim linenumber As Integer = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).GetLineFromCharIndex(caretindex)
            Dim characterXY As Point = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).GetPositionFromCharIndex(caretindex)
            Dim characterIndex As Integer = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).GetCharIndexFromPosition(characterXY)
            LineNum.Text = "Line: " & linenumber
            ColNum.Text = "Characters: " & characterIndex
        Catch
        End Try
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick

        If Not TreeView1.SelectedNode.Text.Contains(".rpy") Then
            If TreeView1.SelectedNode.Text.Contains(".png") Or TreeView1.SelectedNode.Text.Contains(".jpg") Or TreeView1.SelectedNode.Text.Contains(".jpeg") Or TreeView1.SelectedNode.Text.Contains(".gif") Then
                Dim picbox As New PictureBox
                picbox.Font = New Font("Courier New", 12)
                picbox.Dock = DockStyle.Fill
                picbox.ForeColor = Color.White()
                picbox.BackColor = Color.Black()
                TabControl1.TabPages.Add(TreeView1.SelectedNode.Text)
                TabControl1.SelectTab(Int)
                TabControl1.SelectedTab.Controls.Add(picbox)
                Int = Int + 1

                Dim MySelectedNode As TreeNode = e.Node
                Try
                    picbox.Load(MySelectedNode.FullPath)
                    picbox.SizeMode = PictureBoxSizeMode.Zoom
                    originalimage = New Bitmap(picbox.Image)

                    Dim width As Integer = originalimage.Width
                    Dim height As Integer = originalimage.Height

                Catch ex As Exception
                    MsgBox("Unable to open specified picture.")
                End Try
            Else
                MsgBox("The selected file is incompatible with this application.")
            End If
        ElseIf TreeView1.SelectedNode.Text.Contains(".rpy") Or TreeView1.SelectedNode.Text.Contains(".rpy.bak") Then
            Dim rtb As New RichTextBox
            rtb.Font = New Font("Courier New", 12)
            rtb.Dock = DockStyle.Fill
            rtb.ForeColor = Color.White()
            rtb.BackColor = Color.Black()
            TabControl1.TabPages.Add(TreeView1.SelectedNode.Text)
            TabControl1.SelectTab(Int)
            TabControl1.SelectedTab.Controls.Add(rtb)
            Int = Int + 1

            Dim MyStreamReader As System.IO.StreamReader
            Dim MySelectedNode As TreeNode = e.Node
            Try
                MyStreamReader = System.IO.File.OpenText(MySelectedNode.FullPath)
                rtb.Text = MyStreamReader.ReadToEnd()
            Catch ex As Exception
                MsgBox("Unable to open specified code.")
            End Try
        Else
            MsgBox("The selected file is incompatible with this application.")
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text.Contains(".png") Or TabControl1.SelectedTab.Text.Contains(".jpg") Or TabControl1.SelectedTab.Text.Contains(".jpeg") Then
            PictureToolsToolStripMenuItem.Visible = True
            EditToolStripMenuItem.Visible = False
        Else
            PictureToolsToolStripMenuItem.Visible = False
            EditToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub GreyscaleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreyscaleToolStripMenuItem.Click
        Dim clrpixel As Color

        For y As Integer = 0 To originalimage.Height - 1
            For x As Integer = 0 To originalimage.Width - 1
                clrpixel = originalimage.GetPixel(x, y)

                Dim a As Integer = clrpixel.A
                Dim r As Integer = clrpixel.R
                Dim g As Integer = clrpixel.G
                Dim b As Integer = clrpixel.B

                Dim avg As Integer = (r + g + b) / 3
                originalimage.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg))
            Next
        Next
        CType(TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image = originalimage
    End Sub

    Private Sub CropToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CropToolStripMenuItem.Click
        My.Settings.ImagePath = CType(TabControl1.SelectedTab.Controls.Item(0), PictureBox).ImageLocation.ToString()
        CropImage.PictureBox1.Load(My.Settings.ImagePath)
        CropImage.ShowDialog()
    End Sub

    Private Sub RotateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RotateToolStripMenuItem.Click, Flip90DegreesRightToolStripMenuItem.Click, FlipHorizontallyToolStripMenuItem.Click, FlipVerticallyToolStripMenuItem.Click
        Dim bmrotate As New Bitmap(CType(TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image)

        If sender Is FlipHorizontallyToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.RotateNoneFlipX)
        If sender Is FlipVerticallyToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.RotateNoneFlipY)
        If sender Is Flip90DegreesRightToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.Rotate90FlipNone)
        If sender Is RotateToolStripMenuItem Then bmrotate.RotateFlip(RotateFlipType.Rotate270FlipNone)
        CType(TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image = bmrotate
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub

    Public Overloads Shared Function ResizeImage(SourceImage As Drawing.Image, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmSource = New Drawing.Bitmap(SourceImage)

        Return ResizeImage(bmSource, TargetWidth, TargetHeight)
    End Function

    Public Overloads Shared Function ResizeImage(bmSource As Drawing.Bitmap, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function

    Private Sub CloseTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        If Int > 1 Then
            Int = Int - 1
        End If
        If TabControl1.SelectedTab.Text.Contains(".png") Or TabControl1.SelectedTab.Text.Contains(".jpg") Or TabControl1.SelectedTab.Text.Contains(".jpeg") Then
            If Not CType(TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image Is Nothing Then
                If MsgBox("You may have unsaved changes to the image you're currently trying to close. Do you want to save those changes?", MsgBoxStyle.YesNoCancel, "Unsaved Changes") = MsgBoxResult.Yes Then
                    Variables.Save()
                ElseIf MsgBoxResult.No Then
                    Variables.CloseTab()
                Else
                    Int = Int + 1
                End If

            ElseIf CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Text = "" Then
                Variables.CloseTab()
            Else
                If MsgBox("You may have unsaved changes to the code you're currently trying to close. Do you want to save those changes?", MsgBoxStyle.YesNoCancel, "Unsaved Changes") = MsgBoxResult.Yes Then
                    Variables.Save()
                Else
                    Variables.CloseTab()
                End If
            End If
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If TabControl1.SelectedTab.Text.Contains(".png") Or TabControl1.SelectedTab.Text.Contains(".jpg") Or TabControl1.SelectedTab.Text.Contains(".jpeg") Then
            If Not CType(TabControl1.SelectedTab.Controls.Item(0), PictureBox).Image Is Nothing Then
                If MsgBox("You may have unsaved changes to the image you're currently trying to close. Do you want to save those changes?", MsgBoxStyle.YesNoCancel, "Unsaved Changes") = MsgBoxResult.Yes Then
                    Variables.Save()
                    e.Cancel = True
                ElseIf MsgBoxResult.No Then
                    End
                Else
                    End
                End If

            ElseIf CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).Text = "" Then
                End
            Else
                If MsgBox("You may have unsaved changes to the code you're currently trying to close. Do you want to save those changes?", MsgBoxStyle.YesNoCancel, "Unsaved Changes") = MsgBoxResult.Yes Then
                    Variables.Save()
                    e.Cancel = True
                Else
                    End
                End If
            End If
        End If

    End Sub
#End Region
#Region "Functions"
    Private Sub New_Tab()
        Dim rtb As New RichTextBox
        rtb.Font = New Font("Courier New", 12)
        rtb.Dock = DockStyle.Fill
        rtb.ForeColor = Color.White()
        rtb.BackColor = Color.Black()
        TabControl1.TabPages.Add("Untitled " & Int + 1)
        TabControl1.SelectTab(Int)
        TabControl1.SelectedTab.Controls.Add(rtb)
        Int = Int + 1
    End Sub

    Private Sub TextColour_Tick(sender As Object, e As EventArgs) Handles TextColour.Tick
        Try
            If CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectedText.Length = 0 Then
                Dim cls As New OperandColours
                cls.ColorVisibleLines(CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox))
            Else
                TextColour.Stop()
            End If
        Catch ex As exception
        End Try

    End Sub

    Private Sub TextColourResume_Tick(sender As Object, e As EventArgs) Handles TextColourResume.Tick
        TextColour.Start()
    End Sub
#End Region
End Class
