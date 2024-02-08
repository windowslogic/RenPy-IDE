<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResizeImage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.XText = New System.Windows.Forms.TextBox()
        Me.YText = New System.Windows.Forms.TextBox()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.YLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'XText
        '
        Me.XText.Location = New System.Drawing.Point(39, 12)
        Me.XText.Name = "XText"
        Me.XText.Size = New System.Drawing.Size(100, 20)
        Me.XText.TabIndex = 0
        '
        'YText
        '
        Me.YText.Location = New System.Drawing.Point(168, 12)
        Me.YText.Name = "YText"
        Me.YText.Size = New System.Drawing.Size(100, 20)
        Me.YText.TabIndex = 1
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.Location = New System.Drawing.Point(16, 15)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(17, 13)
        Me.XLabel.TabIndex = 2
        Me.XLabel.Text = "X:"
        '
        'YLabel
        '
        Me.YLabel.AutoSize = True
        Me.YLabel.Location = New System.Drawing.Point(145, 15)
        Me.YLabel.Name = "YLabel"
        Me.YLabel.Size = New System.Drawing.Size(17, 13)
        Me.YLabel.TabIndex = 3
        Me.YLabel.Text = "Y:"
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(116, 38)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(197, 38)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 3
        Me.CloseButton.Text = "Cancel"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ResizeImage
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(284, 71)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.YLabel)
        Me.Controls.Add(Me.XLabel)
        Me.Controls.Add(Me.YText)
        Me.Controls.Add(Me.XText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ResizeImage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resize Image"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents XText As TextBox
    Friend WithEvents YText As TextBox
    Friend WithEvents XLabel As Label
    Friend WithEvents YLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents CloseButton As Button
End Class
