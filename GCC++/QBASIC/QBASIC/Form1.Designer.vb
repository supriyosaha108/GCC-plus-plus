<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("printf()", 0)
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
Me.MainPanel1 = New System.Windows.Forms.Panel
Me.SimpleListView = New System.Windows.Forms.ListBox
Me.GraphicalListviewPanel2 = New System.Windows.Forms.Panel
Me.GraphicalListviewPanel = New System.Windows.Forms.Panel
Me.GraphicalListView = New System.Windows.Forms.ListView
Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
Me.Panel7 = New System.Windows.Forms.Panel
Me.OK_Button = New System.Windows.Forms.Button
Me.Button7 = New System.Windows.Forms.Button
Me.Button8 = New System.Windows.Forms.Button
Me.Cancel_Button = New System.Windows.Forms.Button
Me.GroupBox3 = New System.Windows.Forms.GroupBox
Me.Label2 = New System.Windows.Forms.Label
Me.Label1 = New System.Windows.Forms.Label
Me.TextBox2 = New System.Windows.Forms.TextBox
Me.TextBox3 = New System.Windows.Forms.TextBox
Me.SampleUnfocus = New System.Windows.Forms.TextBox
Me.RegexMatch = New System.Windows.Forms.TextBox
Me.ColorList = New System.Windows.Forms.ListBox
Me.TextBox1 = New System.Windows.Forms.RichTextBox
Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.RemoveSingleLineCommentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.SingleLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.MultilineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.AllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
Me.CompileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.RunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
Me.GotoLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.WordWarpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.TrueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.FalseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
Me.AutoSuggestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.OnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.OffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog
Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
Me.FontDialog1 = New System.Windows.Forms.FontDialog
Me.Panel0 = New System.Windows.Forms.MenuStrip
Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem
Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
Me.RemoveAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
Me.MainPanel1.SuspendLayout()
Me.GraphicalListviewPanel2.SuspendLayout()
Me.GraphicalListviewPanel.SuspendLayout()
Me.Panel7.SuspendLayout()
Me.GroupBox3.SuspendLayout()
Me.ContextMenuStrip1.SuspendLayout()
Me.Panel0.SuspendLayout()
Me.SuspendLayout()
'
'MainPanel1
'
Me.MainPanel1.BackColor = System.Drawing.SystemColors.Window
Me.MainPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.MainPanel1.Controls.Add(Me.SimpleListView)
Me.MainPanel1.Controls.Add(Me.GraphicalListviewPanel2)
Me.MainPanel1.Controls.Add(Me.Panel7)
Me.MainPanel1.Controls.Add(Me.SampleUnfocus)
Me.MainPanel1.Controls.Add(Me.RegexMatch)
Me.MainPanel1.Controls.Add(Me.ColorList)
Me.MainPanel1.Controls.Add(Me.TextBox1)
Me.MainPanel1.Dock = System.Windows.Forms.DockStyle.Fill
Me.MainPanel1.Location = New System.Drawing.Point(0, 24)
Me.MainPanel1.Name = "MainPanel1"
Me.MainPanel1.Size = New System.Drawing.Size(664, 337)
Me.MainPanel1.TabIndex = 107
'
'SimpleListView
'
Me.SimpleListView.Font = New System.Drawing.Font("Segoe UI", 9.25!)
Me.SimpleListView.ForeColor = System.Drawing.SystemColors.ControlText
Me.SimpleListView.FormattingEnabled = True
Me.SimpleListView.ItemHeight = 15
Me.SimpleListView.Location = New System.Drawing.Point(0, 0)
Me.SimpleListView.Name = "SimpleListView"
Me.SimpleListView.Size = New System.Drawing.Size(0, 4)
Me.SimpleListView.TabIndex = 101
Me.SimpleListView.TabStop = False
Me.SimpleListView.Visible = False
'
'GraphicalListviewPanel2
'
Me.GraphicalListviewPanel2.BackColor = System.Drawing.SystemColors.Window
Me.GraphicalListviewPanel2.Controls.Add(Me.GraphicalListviewPanel)
Me.GraphicalListviewPanel2.Location = New System.Drawing.Point(56, 64)
Me.GraphicalListviewPanel2.Name = "GraphicalListviewPanel2"
Me.GraphicalListviewPanel2.Size = New System.Drawing.Size(156, 126)
Me.GraphicalListviewPanel2.TabIndex = 108
'
'GraphicalListviewPanel
'
Me.GraphicalListviewPanel.BackColor = System.Drawing.SystemColors.Window
Me.GraphicalListviewPanel.Controls.Add(Me.GraphicalListView)
Me.GraphicalListviewPanel.Location = New System.Drawing.Point(4, 3)
Me.GraphicalListviewPanel.Name = "GraphicalListviewPanel"
Me.GraphicalListviewPanel.Size = New System.Drawing.Size(149, 120)
Me.GraphicalListviewPanel.TabIndex = 108
'
'GraphicalListView
'
Me.GraphicalListView.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
Me.GraphicalListView.AllowColumnReorder = True
Me.GraphicalListView.AutoArrange = False
Me.GraphicalListView.BackColor = System.Drawing.SystemColors.Window
Me.GraphicalListView.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.GraphicalListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
Me.GraphicalListView.Font = New System.Drawing.Font("Segoe UI", 9.25!)
Me.GraphicalListView.ForeColor = System.Drawing.SystemColors.ControlText
Me.GraphicalListView.FullRowSelect = True
Me.GraphicalListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
ListViewItem1.UseItemStyleForSubItems = False
Me.GraphicalListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
Me.GraphicalListView.LabelWrap = False
Me.GraphicalListView.Location = New System.Drawing.Point(-6, 0)
Me.GraphicalListView.MultiSelect = False
Me.GraphicalListView.Name = "GraphicalListView"
Me.GraphicalListView.ShowGroups = False
Me.GraphicalListView.ShowItemToolTips = True
Me.GraphicalListView.Size = New System.Drawing.Size(160, 137)
Me.GraphicalListView.SmallImageList = Me.ImageList1
Me.GraphicalListView.TabIndex = 8
Me.GraphicalListView.TileSize = New System.Drawing.Size(30, 15)
Me.GraphicalListView.UseCompatibleStateImageBehavior = False
Me.GraphicalListView.View = System.Windows.Forms.View.Details
Me.GraphicalListView.Visible = False
'
'ColumnHeader1
'
Me.ColumnHeader1.Text = ""
Me.ColumnHeader1.Width = 156
'
'ImageList1
'
Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
Me.ImageList1.Images.SetKeyName(0, "1.png")
Me.ImageList1.Images.SetKeyName(1, "2.png")
Me.ImageList1.Images.SetKeyName(2, "6.png")
Me.ImageList1.Images.SetKeyName(3, "11.png")
'
'Panel7
'
Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.Panel7.BackColor = System.Drawing.SystemColors.Control
Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
Me.Panel7.Controls.Add(Me.OK_Button)
Me.Panel7.Controls.Add(Me.Button7)
Me.Panel7.Controls.Add(Me.Button8)
Me.Panel7.Controls.Add(Me.Cancel_Button)
Me.Panel7.Controls.Add(Me.GroupBox3)
Me.Panel7.Location = New System.Drawing.Point(328, 188)
Me.Panel7.Name = "Panel7"
Me.Panel7.Size = New System.Drawing.Size(332, 145)
Me.Panel7.TabIndex = 106
Me.Panel7.Visible = False
'
'OK_Button
'
Me.OK_Button.Location = New System.Drawing.Point(168, 104)
Me.OK_Button.Name = "OK_Button"
Me.OK_Button.Size = New System.Drawing.Size(75, 32)
Me.OK_Button.TabIndex = 115
Me.OK_Button.TabStop = False
Me.OK_Button.Text = "Replace &all"
'
'Button7
'
Me.Button7.Location = New System.Drawing.Point(8, 104)
Me.Button7.Name = "Button7"
Me.Button7.Size = New System.Drawing.Size(75, 32)
Me.Button7.TabIndex = 113
Me.Button7.TabStop = False
Me.Button7.Text = "&Search"
'
'Button8
'
Me.Button8.DialogResult = System.Windows.Forms.DialogResult.Yes
Me.Button8.Location = New System.Drawing.Point(88, 104)
Me.Button8.Name = "Button8"
Me.Button8.Size = New System.Drawing.Size(75, 32)
Me.Button8.TabIndex = 114
Me.Button8.TabStop = False
Me.Button8.Text = "&Next"
'
'Cancel_Button
'
Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
Me.Cancel_Button.Location = New System.Drawing.Point(248, 104)
Me.Cancel_Button.Name = "Cancel_Button"
Me.Cancel_Button.Size = New System.Drawing.Size(75, 32)
Me.Cancel_Button.TabIndex = 116
Me.Cancel_Button.TabStop = False
Me.Cancel_Button.Text = "&Cancel"
'
'GroupBox3
'
Me.GroupBox3.Controls.Add(Me.Label2)
Me.GroupBox3.Controls.Add(Me.Label1)
Me.GroupBox3.Controls.Add(Me.TextBox2)
Me.GroupBox3.Controls.Add(Me.TextBox3)
Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
Me.GroupBox3.Name = "GroupBox3"
Me.GroupBox3.Size = New System.Drawing.Size(311, 81)
Me.GroupBox3.TabIndex = 7
Me.GroupBox3.TabStop = False
'
'Label2
'
Me.Label2.AutoSize = True
Me.Label2.Location = New System.Drawing.Point(8, 56)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(69, 13)
Me.Label2.TabIndex = 112
Me.Label2.Text = "Replace with"
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.Location = New System.Drawing.Point(8, 24)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(56, 13)
Me.Label1.TabIndex = 111
Me.Label1.Text = "Search for"
'
'TextBox2
'
Me.TextBox2.AcceptsTab = True
Me.TextBox2.Location = New System.Drawing.Point(88, 48)
Me.TextBox2.Name = "TextBox2"
Me.TextBox2.Size = New System.Drawing.Size(208, 20)
Me.TextBox2.TabIndex = 110
Me.TextBox2.TabStop = False
Me.TextBox2.Tag = "0"
'
'TextBox3
'
Me.TextBox3.AcceptsTab = True
Me.TextBox3.Location = New System.Drawing.Point(88, 16)
Me.TextBox3.Name = "TextBox3"
Me.TextBox3.Size = New System.Drawing.Size(208, 20)
Me.TextBox3.TabIndex = 109
Me.TextBox3.TabStop = False
'
'SampleUnfocus
'
Me.SampleUnfocus.Location = New System.Drawing.Point(-200, -200)
Me.SampleUnfocus.Name = "SampleUnfocus"
Me.SampleUnfocus.Size = New System.Drawing.Size(0, 20)
Me.SampleUnfocus.TabIndex = 103
'
'RegexMatch
'
Me.RegexMatch.Enabled = False
Me.RegexMatch.Location = New System.Drawing.Point(-200, -200)
Me.RegexMatch.Name = "RegexMatch"
Me.RegexMatch.Size = New System.Drawing.Size(0, 20)
Me.RegexMatch.TabIndex = 104
Me.RegexMatch.TabStop = False
Me.RegexMatch.Visible = False
'
'ColorList
'
Me.ColorList.FormattingEnabled = True
Me.ColorList.Items.AddRange(New Object() {"#Ff9999", "#Dbd7d2", "#FFFF00", "#F7cac9", "#7fffd4", "#ECFFDC", "#00ffff", "#F0fff0", "#F5DEB3", "#E6e6fa", "#Ffd1dc", "#Aaf0d1", "#Ffe5b4", "#Ffd1dc", "#F0dc82", "#Fbceb1", "#F88379", "#ffc2b3", "#e6e6e6", "#Fffff0", "#cce6ff", "#ffe6cc", "#d1d1e0", "#ffe6ff", "#ffcc99", "#ebc6eb", "#00e6e6", "#c2d6d6", "#e6faff", "#c2c2f0", "#e0e0d2", "#d9ffb3", "#ccffff", "#ffff99", "#d2a679", "#f9ecf9", "#ffbd80", "#00ff55", "#F88379", "#F0dc82", "#Ffe5b4", "#7fffd4", "#Ff9999", "#Dbd7d2", "#F0dc82", "#FDDA0D", "#F4C430", "#FFAA33", "#AFEEEE", "#7FFFD4"})
Me.ColorList.Location = New System.Drawing.Point(-200, -200)
Me.ColorList.Name = "ColorList"
Me.ColorList.Size = New System.Drawing.Size(0, 4)
Me.ColorList.TabIndex = 102
Me.ColorList.TabStop = False
Me.ColorList.Visible = False
'
'TextBox1
'
Me.TextBox1.AcceptsTab = True
Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.TextBox1.AutoWordSelection = True
Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
Me.TextBox1.ContextMenuStrip = Me.ContextMenuStrip1
Me.TextBox1.DetectUrls = False
Me.TextBox1.Font = New System.Drawing.Font("Courier New", 10.5!)
Me.TextBox1.Location = New System.Drawing.Point(8, 0)
Me.TextBox1.Name = "TextBox1"
Me.TextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
Me.TextBox1.Size = New System.Drawing.Size(652, 335)
Me.TextBox1.TabIndex = 0
Me.TextBox1.Text = ""
Me.TextBox1.WordWrap = False
'
'ContextMenuStrip1
'
Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripMenuItem5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem2, Me.SelectAllToolStripMenuItem, Me.RemoveSingleLineCommentsToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripMenuItem3, Me.CompileToolStripMenuItem, Me.RunToolStripMenuItem, Me.ToolStripMenuItem4, Me.GotoLineToolStripMenuItem, Me.WordWarpToolStripMenuItem, Me.ToolStripMenuItem1, Me.AutoSuggestionToolStripMenuItem})
Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
Me.ContextMenuStrip1.Size = New System.Drawing.Size(180, 336)
'
'CutToolStripMenuItem
'
Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
Me.CutToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.CutToolStripMenuItem.Text = "Cut"
'
'CopyToolStripMenuItem
'
Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.CopyToolStripMenuItem.Text = "Copy"
'
'PasteToolStripMenuItem
'
Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.PasteToolStripMenuItem.Text = "Paste"
'
'ToolStripMenuItem5
'
Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
Me.ToolStripMenuItem5.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
Me.ToolStripMenuItem5.Size = New System.Drawing.Size(179, 22)
Me.ToolStripMenuItem5.Text = "Undo"
'
'ToolStripMenuItem6
'
Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
Me.ToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
Me.ToolStripMenuItem6.Size = New System.Drawing.Size(179, 22)
Me.ToolStripMenuItem6.Text = "Redo"
'
'ToolStripMenuItem2
'
Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 6)
'
'SelectAllToolStripMenuItem
'
Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.SelectAllToolStripMenuItem.Text = "Select All"
'
'RemoveSingleLineCommentsToolStripMenuItem
'
Me.RemoveSingleLineCommentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleLineToolStripMenuItem, Me.MultilineToolStripMenuItem, Me.AllToolStripMenuItem})
Me.RemoveSingleLineCommentsToolStripMenuItem.Name = "RemoveSingleLineCommentsToolStripMenuItem"
Me.RemoveSingleLineCommentsToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.RemoveSingleLineCommentsToolStripMenuItem.Text = "Remove Comments"
'
'SingleLineToolStripMenuItem
'
Me.SingleLineToolStripMenuItem.Name = "SingleLineToolStripMenuItem"
Me.SingleLineToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
Me.SingleLineToolStripMenuItem.Text = "Single Line"
'
'MultilineToolStripMenuItem
'
Me.MultilineToolStripMenuItem.Name = "MultilineToolStripMenuItem"
Me.MultilineToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
Me.MultilineToolStripMenuItem.Text = "Multiline"
'
'AllToolStripMenuItem
'
Me.AllToolStripMenuItem.Name = "AllToolStripMenuItem"
Me.AllToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
Me.AllToolStripMenuItem.Text = "All"
'
'ClearAllToolStripMenuItem
'
Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.ClearAllToolStripMenuItem.Text = "Clear All"
'
'SearchToolStripMenuItem
'
Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.SearchToolStripMenuItem.Text = "Search/Replace"
'
'ToolStripMenuItem3
'
Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
Me.ToolStripMenuItem3.Size = New System.Drawing.Size(176, 6)
'
'CompileToolStripMenuItem
'
Me.CompileToolStripMenuItem.Name = "CompileToolStripMenuItem"
Me.CompileToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.CompileToolStripMenuItem.Text = "Compile"
'
'RunToolStripMenuItem
'
Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
Me.RunToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.RunToolStripMenuItem.Text = "Run"
'
'ToolStripMenuItem4
'
Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
Me.ToolStripMenuItem4.Size = New System.Drawing.Size(176, 6)
'
'GotoLineToolStripMenuItem
'
Me.GotoLineToolStripMenuItem.Name = "GotoLineToolStripMenuItem"
Me.GotoLineToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.GotoLineToolStripMenuItem.Text = "Goto Line"
'
'WordWarpToolStripMenuItem
'
Me.WordWarpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrueToolStripMenuItem, Me.FalseToolStripMenuItem})
Me.WordWarpToolStripMenuItem.Name = "WordWarpToolStripMenuItem"
Me.WordWarpToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.WordWarpToolStripMenuItem.Text = "Word Wrap"
'
'TrueToolStripMenuItem
'
Me.TrueToolStripMenuItem.Name = "TrueToolStripMenuItem"
Me.TrueToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
Me.TrueToolStripMenuItem.Text = "None"
'
'FalseToolStripMenuItem
'
Me.FalseToolStripMenuItem.Name = "FalseToolStripMenuItem"
Me.FalseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
Me.FalseToolStripMenuItem.Text = "Present"
'
'ToolStripMenuItem1
'
Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
'
'AutoSuggestionToolStripMenuItem
'
Me.AutoSuggestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnToolStripMenuItem, Me.OffToolStripMenuItem})
Me.AutoSuggestionToolStripMenuItem.Name = "AutoSuggestionToolStripMenuItem"
Me.AutoSuggestionToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
Me.AutoSuggestionToolStripMenuItem.Text = "Auto Suggestion"
'
'OnToolStripMenuItem
'
Me.OnToolStripMenuItem.Name = "OnToolStripMenuItem"
Me.OnToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
Me.OnToolStripMenuItem.Text = "Turn on"
'
'OffToolStripMenuItem
'
Me.OffToolStripMenuItem.Name = "OffToolStripMenuItem"
Me.OffToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
Me.OffToolStripMenuItem.Text = "Turn off"
'
'SaveFileDialog2
'
Me.SaveFileDialog2.DefaultExt = "exe"
Me.SaveFileDialog2.Filter = "Executable Files(*.exe)|*.exe"
'
'Panel0
'
Me.Panel0.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14, Me.BuildToolStripMenuItem})
Me.Panel0.Location = New System.Drawing.Point(0, 0)
Me.Panel0.Name = "Panel0"
Me.Panel0.Size = New System.Drawing.Size(664, 24)
Me.Panel0.TabIndex = 108
Me.Panel0.Text = "MenuStrip2"
'
'ToolStripMenuItem14
'
Me.ToolStripMenuItem14.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem15, Me.ToolStripMenuItem16, Me.ToolStripSeparator2, Me.ToolStripMenuItem12, Me.ToolStripSeparator6, Me.ToolStripMenuItem17, Me.ToolStripMenuItem10, Me.ToolStripMenuItem7, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
Me.ToolStripMenuItem14.Size = New System.Drawing.Size(46, 20)
Me.ToolStripMenuItem14.Text = "Build"
'
'ToolStripMenuItem12
'
Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
Me.ToolStripMenuItem12.Size = New System.Drawing.Size(166, 22)
Me.ToolStripMenuItem12.Text = "Save"
'
'ToolStripSeparator2
'
Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
Me.ToolStripSeparator2.Size = New System.Drawing.Size(163, 6)
'
'ToolStripMenuItem15
'
Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
Me.ToolStripMenuItem15.Size = New System.Drawing.Size(166, 22)
Me.ToolStripMenuItem15.Text = "Compile"
'
'ToolStripMenuItem16
'
Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
Me.ToolStripMenuItem16.Size = New System.Drawing.Size(166, 22)
Me.ToolStripMenuItem16.Text = "Compile and Run"
'
'ToolStripSeparator6
'
Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
Me.ToolStripSeparator6.Size = New System.Drawing.Size(163, 6)
'
'ToolStripMenuItem17
'
Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
Me.ToolStripMenuItem17.Size = New System.Drawing.Size(166, 22)
Me.ToolStripMenuItem17.Text = "Show Designer"
'
'ToolStripMenuItem10
'
Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
Me.ToolStripMenuItem10.Size = New System.Drawing.Size(166, 22)
Me.ToolStripMenuItem10.Text = "Menu Designer"
'
'ToolStripMenuItem7
'
Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
Me.ToolStripMenuItem7.Size = New System.Drawing.Size(166, 22)
Me.ToolStripMenuItem7.Text = "&Temporary Space"
'
'ToolStripSeparator1
'
Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
Me.ToolStripSeparator1.Size = New System.Drawing.Size(163, 6)
'
'CloseToolStripMenuItem
'
Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
Me.CloseToolStripMenuItem.Text = "Close"
'
'BuildToolStripMenuItem
'
Me.BuildToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem11, Me.ToolStripMenuItem18, Me.ToolStripMenuItem20, Me.AddNewToolStripMenuItem, Me.ToolStripSeparator7, Me.RemoveAllToolStripMenuItem1})
Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
Me.BuildToolStripMenuItem.Text = "Edit"
'
'ToolStripMenuItem8
'
Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
Me.ToolStripMenuItem8.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
Me.ToolStripMenuItem8.Size = New System.Drawing.Size(164, 22)
Me.ToolStripMenuItem8.Text = "Cut"
'
'ToolStripMenuItem9
'
Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
Me.ToolStripMenuItem9.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
Me.ToolStripMenuItem9.Size = New System.Drawing.Size(164, 22)
Me.ToolStripMenuItem9.Text = "Copy"
'
'ToolStripMenuItem11
'
Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
Me.ToolStripMenuItem11.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
Me.ToolStripMenuItem11.Size = New System.Drawing.Size(164, 22)
Me.ToolStripMenuItem11.Text = "Paste"
'
'ToolStripMenuItem18
'
Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
Me.ToolStripMenuItem18.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
Me.ToolStripMenuItem18.Size = New System.Drawing.Size(164, 22)
Me.ToolStripMenuItem18.Text = "Select All"
'
'ToolStripMenuItem20
'
Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
Me.ToolStripMenuItem20.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
Me.ToolStripMenuItem20.Size = New System.Drawing.Size(164, 22)
Me.ToolStripMenuItem20.Text = "Search"
'
'AddNewToolStripMenuItem
'
Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
Me.AddNewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
Me.AddNewToolStripMenuItem.Text = "Replace"
'
'ToolStripSeparator7
'
Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
Me.ToolStripSeparator7.Size = New System.Drawing.Size(161, 6)
'
'RemoveAllToolStripMenuItem1
'
Me.RemoveAllToolStripMenuItem1.Name = "RemoveAllToolStripMenuItem1"
Me.RemoveAllToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
Me.RemoveAllToolStripMenuItem1.Text = "Clear All"
'
'Form1
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(664, 361)
Me.Controls.Add(Me.MainPanel1)
Me.Controls.Add(Me.Panel0)
Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
Me.Name = "Form1"
Me.ShowIcon = False
Me.ShowInTaskbar = False
Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
Me.Text = "Editor"
Me.MainPanel1.ResumeLayout(False)
Me.MainPanel1.PerformLayout()
Me.GraphicalListviewPanel2.ResumeLayout(False)
Me.GraphicalListviewPanel.ResumeLayout(False)
Me.Panel7.ResumeLayout(False)
Me.GroupBox3.ResumeLayout(False)
Me.GroupBox3.PerformLayout()
Me.ContextMenuStrip1.ResumeLayout(False)
Me.Panel0.ResumeLayout(False)
Me.Panel0.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents MainPanel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveSingleLineCommentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SingleLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultilineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CompileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GotoLineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordWarpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FalseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AutoSuggestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog2 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents ColorList As System.Windows.Forms.ListBox
    Friend WithEvents SimpleListView As System.Windows.Forms.ListBox
    Friend WithEvents RegexMatch As System.Windows.Forms.TextBox
    Friend WithEvents SampleUnfocus As System.Windows.Forms.TextBox
    Friend WithEvents GraphicalListviewPanel2 As System.Windows.Forms.Panel
    Friend WithEvents GraphicalListviewPanel As System.Windows.Forms.Panel
    Friend WithEvents GraphicalListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel0 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem17 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
