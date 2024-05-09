Imports System.Runtime.InteropServices

Public Class Form1
<DllImport ("user32.dll")> _ 
Private shared function ShowScrollBar(ByVal hwnd As IntPtr, ByVal wBar As Integer, ByVal bShow As Integer ) As Integer
End Function
Dim QBASIC As new Form2 

Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
MDIParent1.Panel1.Enabled = False
If e.CloseReason = CloseReason.UserClosing then
e.Cancel = True
Me.hide
End If
End Sub

Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
Me.MdiParent = MDIParent1
End Sub

Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
QBASIC.LoadForm1
If MDIParent1.Label1.Top <> 0 then
Me.Top = MDIParent1.Label1.Top
End If
If MDIParent1.Label1.left <> 0 then
Me.left = MDIParent1.Label1.Left
End If
TextBox1.Select(0,0)
TextBox1.Focus
End Sub

Private Sub TextBox3_TextChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles TextBox3.TextChanged
TextBox3.Tag = 0
End Sub

Private Sub Panel7_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel7.VisibleChanged
TextBox3.Tag = 0
End Sub

Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OK_Button.Click
TextBox3.Tag = 0
QBASIC.ReplaceAll
End Sub

Private Sub SimpleListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleListView.DoubleClick
If Val(MDIparent1.ListBox2.Tag) = 1 then
Dim k As Integer 
k = TextBox1.SelectionStart
TextBox1.Focus
TextBox1.Select(k,0)
SendKeys.Send(" ")
End If
End Sub

Private Sub SimpleListView_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleListView.LocationChanged
GraphicalListviewPanel2.Top = SimpleListView.Top
GraphicalListviewPanel2.left = SimpleListView.left
End Sub

Private Sub SimpleListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleListView.SelectedIndexChanged 
If SimpleListView.SelectedIndex > -1 then
GraphicalListView.Items(SimpleListView.SelectedIndex).Selected = True
Else If SimpleListView.SelectedIndex = -1 and GraphicalListView.SelectedItems.Count > 0 then
GraphicalListView.SelectedItems(0).Selected = False
End If
End Sub

Private Sub SimpleListView_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleListView.VisibleChanged
GraphicalListviewPanel2.Visible = SimpleListView.Visible
GraphicalListview.Visible = SimpleListView.Visible
End Sub

Private Sub GraphicalListView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GraphicalListView.DoubleClick
SimpleListView.SelectedIndex = GraphicalListview.SelectedItems(0).Index 
If Val(MDIparent1.ListBox2.Tag) = 1 then
Dim k As Integer 
k = TextBox1.SelectionStart
TextBox1.Focus
TextBox1.Select(k,0)
SendKeys.Send(" ")
End If
End Sub

Private Sub GraphicalListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GraphicalListView.SelectedIndexChanged
For Each element As ListViewItem In GraphicalListview.Items 
element.BackColor = GraphicalListview.BackColor
element.ForeColor = GraphicalListview.ForeColor
Next
If GraphicalListview.SelectedItems.Count > 0 then
GraphicalListview.Items(GraphicalListview.SelectedItems(0).Index).BackColor = systemcolors.Highlight
GraphicalListview.Items(GraphicalListview.SelectedItems(0).Index).ForeColor = systemcolors.Highlighttext
End If
If SimpleListView.SelectedIndex > -1 then
GraphicalListview.EnsureVisible(SimpleListView.SelectedIndex)
End If
End Sub

Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
If Val(MDIparent1.ListBox2.Tag) = 1 then
QBASIC.HideAutoCorrectBox
End If
MDIParent1.Panel1.Enabled = True
MDIParent1.Status.Text = "Ready"
Me.Focus
End Sub

Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
MDIParent1.Panel1.Enabled = True
End Sub

Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
If MDIParent1.UseSuggestionFromCodeToolStripMenuItem.Tag = 1 and Val(MDIparent1.ListBox2.Tag) = 1 then
QBASIC.AddCustomWords()
End If
If Val(MDIparent1.ListBox2.Tag) = 1 then
QBASIC.AutoCorrect(e)
End If   
If TextBox1.SelectedText = "" then
TextBox1.SelectionBackColor = SampleUnfocus.BackColor
TextBox1.SelectionColor = SampleUnfocus.ForeColor
End If 
End Sub

Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
If MDIParent1.button1.Tag = 1 then
If e.KeyCode = 221 then
QBASIC.AutoInsertLine
End If
If e.KeyCode = 219 then
QBASIC.AutoInsertLine
End If
Else If MDIParent1.ToolStripMenuItem23.Tag = 1 then
If e.KeyCode = 219 then
Dim k As Integer 
k = TextBox1.SelectionStart
If TextBox1.Text.Substring(k-1, 1) = "{" then
QBASIC.Paste(vbnewline+"}")
TextBox1.SelectionStart = k
End If
End If
End If
If TextBox1.SelectedText = "" then
TextBox1.SelectionBackColor = SampleUnfocus.BackColor
TextBox1.SelectionColor = SampleUnfocus.ForeColor
End If 
QBASIC.ShowAutoCorrectBox()
End Sub

Private Sub TextBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseMove
If Val(MDIparent1.ListBox2.Tag) = 1 then
SimpleListView.Tag = TextBox1.SelectionStart.ToString      
If e.Button then
QBASIC.HideAutoCorrectBox
End If   
End If
End Sub

Private Sub Button7_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button7.Click
TextBox3.Tag = 0
QBASIC.Search
End Sub

Private Sub Button8_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button8.Click
QBASIC.Search
End Sub

Private Sub Cancel_Button_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Cancel_Button.Click
TextBox3.Tag = 0
TextBox2.Text = ""
TextBox3.Text = ""
Panel7.Hide
End Sub

Private Sub TextBox1_TextChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles TextBox1.TextChanged
If Val(MDIparent1.ListBox2.Tag) = 1 then
SimpleListView.Tag = TextBox1.SelectionStart.ToString
End If
If MDIParent1.Status.Text = "Reading" then
SampleUnfocus.Focus
Else
QBASIC.HighlightWords(0) 
QBASIC.ConditionalHighlightIntend
End If
QBASIC.Form1SAVEUndo()
End Sub

Private Sub ToolStripMenuItem5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
QBASIC.Form1Undo
End Sub

Private Sub ToolStripMenuItem6_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
QBASIC.Form1Redo
End Sub

Private Sub CutToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
TextBox1.Cut
End Sub

Private Sub CopyToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
TextBox1.Copy 
End Sub

Private Sub PasteToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
MDIParent1.Status.Text = "Pasting"
TextBox1.Paste
MDIParent1.Status.Text = "Pasted"
End Sub

Private Sub SelectAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
  TextBox1.SelectAll
End Sub

Private Sub SingleLineToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SingleLineToolStripMenuItem.Click
TextBox1.Text = QBASIC.RemoveSingleComments(TextBox1.Text)
End Sub

Private Sub MultilineToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MultilineToolStripMenuItem.Click
TextBox1.Text = QBASIC.RemoveMultiComments(TextBox1.Text)
End Sub

Private Sub AllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AllToolStripMenuItem.Click
TextBox1.Text = QBASIC.RemoveComments(TextBox1.Text)
End Sub

Private Sub ClearAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
TextBox1.Text = ""
End Sub

Private Sub SearchToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click
Panel7.Visible = True
QBASIC.HideAutoCorrectBox
End Sub

Private Sub CompileToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CompileToolStripMenuItem.Click
QBASIC.Compile
End Sub

Private Sub RunToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles RunToolStripMenuItem.Click
QBASIC.Compile
QBASIC.CompileRun
End Sub

Private Sub GotoLineToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles GotoLineToolStripMenuItem.Click
Dim k As String
k = InputBox("Enter Line Number: ", "Go To Line", "1")
If val(k) > 0 then
QBASIC.HighlightLine (val(k)-1)
End If
End Sub

Private Sub TrueToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles TrueToolStripMenuItem.Click
  TextBox1.WordWrap = False
End Sub

Private Sub FalseToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles FalseToolStripMenuItem.Click
  TextBox1.WordWrap = True
End Sub

Private Sub OnToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OnToolStripMenuItem.Click
MDIParent1.ListBox2.Tag = 1
MDIParent1.Status.Text = "Autocorrect Turned On"
End Sub

Private Sub OffToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
MDIParent1.ListBox2.Tag = 0
QBASIC.HideAutoCorrectBox
MDIParent1.Status.Text = "Autocorrect Turned Off"
End Sub

Private Sub Panel1_Paint( ByVal sender As System.Object,  ByVal e As System.Windows.Forms.PaintEventArgs) Handles GraphicalListviewPanel2.Paint
dim borderrectangle as rectangle
borderrectangle = GraphicalListviewPanel2.ClientRectangle
borderrectangle.Inflate(0,0)
ControlPaint.DrawBorder3D(e.Graphics,borderrectangle,Border3DStyle.Raised)
End Sub

Private Sub GraphicalListviewPanel2_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles GraphicalListviewPanel2.Resize
ShowScrollBar(GraphicalListviewPanel.Handle,1,1)
End Sub

Private Sub GraphicalListviewPanel2_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GraphicalListviewPanel2.VisibleChanged
ShowScrollBar(GraphicalListviewPanel.Handle,1,1)
End Sub

Private Sub ToolStripMenuItem15_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
  QBASIC.Compile
End Sub

Private Sub ToolStripMenuItem16_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
QBASIC.Compile  
QBASIC.CompileRun 
End Sub

Private Sub ToolStripMenuItem17_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem17.Click
  Form6.Show
Form6.Focus
End Sub

Private Sub ToolStripMenuItem10_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
    Form7.Show
Form7.Focus
End Sub

Private Sub ToolStripMenuItem7_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
    Form4.Show
Form4.Focus
End Sub

Private Sub CloseToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
QBASIC.HideAutoCorrectBox  
Me.Hide
End Sub

Private Sub ToolStripMenuItem11_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
  MDIParent1.Status.Text = "Pasting"
TextBox1.Paste
MDIParent1.Status.Text = "Pasted"
End Sub

Private Sub ToolStripMenuItem8_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
  TextBox1.Cut
End Sub

Private Sub ToolStripMenuItem9_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
  TextBox1.Copy
End Sub

Private Sub ToolStripMenuItem18_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
  TextBox1.Focus
TextBox1.SelectAll 
End Sub

Private Sub ToolStripMenuItem20_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
  Panel7.Show
QBASIC.HideAutoCorrectBox
End Sub

Private Sub AddNewToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
  Panel7.Show
QBASIC.HideAutoCorrectBox
End Sub

Private Sub RemoveAllToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles RemoveAllToolStripMenuItem1.Click
  TextBox1.Text = ""
End Sub

Private Sub ToolStripMenuItem12_Click_1( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
  QBASIC.Save
End Sub
End Class

