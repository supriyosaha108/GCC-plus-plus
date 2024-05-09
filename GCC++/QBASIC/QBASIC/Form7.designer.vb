<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
Me.components = New System.ComponentModel.Container
Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
Me.ListView1 = New System.Windows.Forms.ListView
Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
Me.BuildMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.Button1 = New System.Windows.Forms.Button
Me.ContextMenuStrip1.SuspendLayout()
Me.SuspendLayout()
'
'ListView1
'
Me.ListView1.AutoArrange = False
Me.ListView1.BackColor = System.Drawing.Color.Black
Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
Me.ListView1.Font = New System.Drawing.Font("Cascadia Code SemiBold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.ListView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
Me.ListView1.LabelEdit = True
Me.ListView1.Location = New System.Drawing.Point(0, 0)
Me.ListView1.MultiSelect = False
Me.ListView1.Name = "ListView1"
Me.ListView1.Size = New System.Drawing.Size(367, 459)
Me.ListView1.TabIndex = 0
Me.ListView1.UseCompatibleStateImageBehavior = False
Me.ListView1.View = System.Windows.Forms.View.Details
'
'ColumnHeader1
'
Me.ColumnHeader1.Text = ""
Me.ColumnHeader1.Width = 357
'
'ContextMenuStrip1
'
Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.BuildMenuToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem5, Me.ClearAllToolStripMenuItem, Me.ToolStripMenuItem2, Me.CloseToolStripMenuItem})
Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ContextMenuStrip1.Size = New System.Drawing.Size(189, 148)
'
'ToolStripMenuItem3
'
Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Space), System.Windows.Forms.Keys)
Me.ToolStripMenuItem3.Size = New System.Drawing.Size(188, 22)
Me.ToolStripMenuItem3.Text = "Add Item"
'
'ToolStripMenuItem4
'
Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
Me.ToolStripMenuItem4.ShortcutKeys = System.Windows.Forms.Keys.Delete
Me.ToolStripMenuItem4.Size = New System.Drawing.Size(188, 22)
Me.ToolStripMenuItem4.Text = "Remove Selected"
'
'BuildMenuToolStripMenuItem
'
Me.BuildMenuToolStripMenuItem.Name = "BuildMenuToolStripMenuItem"
Me.BuildMenuToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
Me.BuildMenuToolStripMenuItem.Text = "Build Menu"
'
'ToolStripMenuItem1
'
Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
Me.ToolStripMenuItem1.Size = New System.Drawing.Size(185, 6)
'
'ToolStripMenuItem5
'
Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
Me.ToolStripMenuItem5.Size = New System.Drawing.Size(188, 22)
Me.ToolStripMenuItem5.Text = "Refresh"
'
'ClearAllToolStripMenuItem
'
Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
Me.ClearAllToolStripMenuItem.Text = "Clear all"
'
'ToolStripMenuItem2
'
Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
Me.ToolStripMenuItem2.Size = New System.Drawing.Size(185, 6)
'
'CloseToolStripMenuItem
'
Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
Me.CloseToolStripMenuItem.Text = "Close"
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(-200, -200)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(48, 40)
Me.Button1.TabIndex = 2
Me.Button1.Text = "Button1"
Me.Button1.UseVisualStyleBackColor = True
'
'Form7
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.AutoSize = True
Me.BackColor = System.Drawing.Color.Black
Me.ClientSize = New System.Drawing.Size(367, 459)
Me.Controls.Add(Me.Button1)
Me.Controls.Add(Me.ListView1)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
Me.Name = "Form7"
Me.Opacity = 0.5
Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
Me.Text = "Menu Designer"
Me.ContextMenuStrip1.ResumeLayout(False)
Me.ResumeLayout(False)

End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents BuildMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem

End Class
