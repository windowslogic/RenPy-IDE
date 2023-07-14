Public Class Main

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rtb As New RichTextBox
        With rtb
            .ForeColor = Color.White
            .Location = New Point(65, 0)
            .Size = New Size(332, 292)
            .Dock = DockStyle.Fill
            .BackColor = Color.Black
            .Font = New Font("Courier New", 12)
        End With
        TabControl1.TabPages.Add("Untitled 1")
        TabControl1.SelectedTab.Controls.Add(rtb)

    End Sub
#Region "TreeViewControl"
    Private Sub PopulateTreeView(path As String)
        TreeView1.Nodes.Clear()

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
        dialog.Description = "Select Application Configeration Files Path"
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
            For Each n As TreeNode In TreeView1.Nodes
                For Each no As TreeNode In n.Nodes
                    If no.Text = "Please wait..." Then
                        no.Remove()
                    End If
                Next
            Next
        End If
    End Sub
#End Region
#Region "Menu"
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NameInput.ShowDialog()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim caretindex As Integer = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).SelectionStart
        Dim linenumber As Integer = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).GetLineFromCharIndex(caretindex)
        Dim characterXY As Point = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).GetPositionFromCharIndex(caretindex)
        Dim characterIndex As Integer = CType(TabControl1.SelectedTab.Controls.Item(0), RichTextBox).GetCharIndexFromPosition(characterXY)
        LineNum.Text = "Line:" & linenumber
    End Sub
#End Region

End Class
