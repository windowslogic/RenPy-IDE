<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open a directory to start.")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CropToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RotateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Flip90DegreesRightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FlipHorizontallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlipVerticallyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.GreyscaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CharacterCounter = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LineNum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ColNum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TextColour = New System.Windows.Forms.Timer(Me.components)
        Me.TextColourResume = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.Black
        Me.TreeView1.ForeColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(12, 27)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Open a directory to start."
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.TreeView1.Size = New System.Drawing.Size(160, 302)
        Me.TreeView1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.PictureToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(595, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.OpenToolStripMenuItem.Text = "Open directory..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(202, 6)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save as..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(202, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(124, 20)
        Me.ToolsToolStripMenuItem.Text = "Programming Tools"
        Me.ToolsToolStripMenuItem.Visible = False
        '
        'PictureToolsToolStripMenuItem
        '
        Me.PictureToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CropToolStripMenuItem, Me.ToolStripSeparator5, Me.RotateToolStripMenuItem, Me.Flip90DegreesRightToolStripMenuItem, Me.ToolStripSeparator6, Me.FlipHorizontallyToolStripMenuItem, Me.FlipVerticallyToolStripMenuItem, Me.ToolStripSeparator4, Me.GreyscaleToolStripMenuItem})
        Me.PictureToolsToolStripMenuItem.Name = "PictureToolsToolStripMenuItem"
        Me.PictureToolsToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.PictureToolsToolStripMenuItem.Text = "Picture Tools"
        Me.PictureToolsToolStripMenuItem.Visible = False
        '
        'CropToolStripMenuItem
        '
        Me.CropToolStripMenuItem.Name = "CropToolStripMenuItem"
        Me.CropToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CropToolStripMenuItem.Text = "Crop..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(177, 6)
        '
        'RotateToolStripMenuItem
        '
        Me.RotateToolStripMenuItem.Name = "RotateToolStripMenuItem"
        Me.RotateToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RotateToolStripMenuItem.Text = "Flip 90 degrees left"
        '
        'Flip90DegreesRightToolStripMenuItem
        '
        Me.Flip90DegreesRightToolStripMenuItem.Name = "Flip90DegreesRightToolStripMenuItem"
        Me.Flip90DegreesRightToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Flip90DegreesRightToolStripMenuItem.Text = "Flip 90 degrees right"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(177, 6)
        '
        'FlipHorizontallyToolStripMenuItem
        '
        Me.FlipHorizontallyToolStripMenuItem.Name = "FlipHorizontallyToolStripMenuItem"
        Me.FlipHorizontallyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FlipHorizontallyToolStripMenuItem.Text = "Flip horizontally"
        '
        'FlipVerticallyToolStripMenuItem
        '
        Me.FlipVerticallyToolStripMenuItem.Name = "FlipVerticallyToolStripMenuItem"
        Me.FlipVerticallyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FlipVerticallyToolStripMenuItem.Text = "Flip vertically"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(177, 6)
        '
        'GreyscaleToolStripMenuItem
        '
        Me.GreyscaleToolStripMenuItem.Name = "GreyscaleToolStripMenuItem"
        Me.GreyscaleToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GreyscaleToolStripMenuItem.Text = "Greyscale"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TabControl1.Location = New System.Drawing.Point(178, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(405, 302)
        Me.TabControl1.TabIndex = 2
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddTabToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.ToolStripSeparator3, Me.RenameToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 76)
        '
        'AddTabToolStripMenuItem
        '
        Me.AddTabToolStripMenuItem.Name = "AddTabToolStripMenuItem"
        Me.AddTabToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AddTabToolStripMenuItem.Text = "Add Tab"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(122, 6)
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'CharacterCounter
        '
        Me.CharacterCounter.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LineNum, Me.ToolStripStatusLabel1, Me.ColNum})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(595, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LineNum
        '
        Me.LineNum.Name = "LineNum"
        Me.LineNum.Size = New System.Drawing.Size(33, 17)
        Me.LineNum.Text = "Row:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'ColNum
        '
        Me.ColNum.Name = "ColNum"
        Me.ColNum.Size = New System.Drawing.Size(66, 17)
        Me.ColNum.Text = "Characters:"
        '
        'TextColour
        '
        Me.TextColour.Enabled = True
        Me.TextColour.Interval = 1000
        '
        'TextColourResume
        '
        Me.TextColourResume.Enabled = True
        Me.TextColourResume.Interval = 1000
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 354)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(617, 399)
        Me.Name = "Main"
        Me.Text = "Ren'Py Development Environment"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents AddTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CharacterCounter As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents LineNum As ToolStripStatusLabel
    Friend WithEvents ColNum As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CropToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RotateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GreyscaleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents Flip90DegreesRightToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents FlipHorizontallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlipVerticallyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextColour As Timer
    Friend WithEvents TextColourResume As Timer
End Class
