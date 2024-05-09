Public Class Form6
Dim QBASIC As New Form2 
Dim x1 As integer
Dim x2 As Integer

Friend Sub GenButton_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) 
If e.Button = Windows.Forms.MouseButtons.left then
sender.Top = e.y + sender.Top - x1
sender.left = e.x + sender.left - x2
Else
x1 = e.y 
x2 = e.x
End If
End Sub

Friend Sub GenButton__KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
On Error GoTo NNN
If e.KeyCode = 13 then
e.SuppressKeyPress = True
If Form1.WindowState = FormWindowState.Minimized then
Form1.WindowState = FormWindowState.Normal 
End If
Form1.Show
Form1.Focus
If Form1.TextBox1.Text.IndexOf(sender.tag) = -1 then
If sender.name = "main" then
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + sender.tag + vbnewline + "{" + vbnewline + vbNewLine + "getch();" + vbNewLine + "}" + vbNewLine + MDIParent1.Button9.Tag 
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + sender.tag + vbnewline + "{" + vbnewline + vbNewLine + "getch();" + vbNewLine + "return 0;" + vbNewLine + "}" + vbNewLine + MDIParent1.Button9.Tag 
End If
Else
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + sender.tag + vbnewline + "{" + vbnewline + vbNewLine + "}" + vbNewLine +  MDIParent1.Button9.Tag 
End If
Form1.TextBox1.Focus
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag)-1, 0)
Form1.TextBox1.ScrollToCaret
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag) + sender.tag.ToString.Length + 3, 0)
Else
Form1.TextBox1.Focus
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag)-1, 0)
Form1.TextBox1.ScrollToCaret
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag) + sender.tag.ToString.Length + 3 , 0)
End If 
End If
If e.KeyData.ToString = "Delete" or e.KeyData.ToString = "D4" then
Panel2.Controls.Remove(sender)
End If

If e.KeyData.ToString = "Home" then
Dim newname As String
newname = InputBox("Enter New Name:","GCC++", sender.text)
If newname<>"" then
sender.text = newname
End If
End If

If e.KeyData.ToString = "End" then
Dim newdata As String
Dim backup As String
backup = sender.tag
newdata = InputBox("Enter New Data:","GCC++", sender.tag)
If newdata <> "" then
Form1.TextBox1.text = Form1.TextBox1.Text.Replace(backup, newdata)
Dim kk As Integer
kk = Form1.TextBox1.SelectionStart
QBASIC.HighlightIntend
Form1.TextBox1.Select(kk,0)
sender.tag = newdata
ToolTip1.SetToolTip(sender, sender.tag)
End If
End If
Exit Sub 
NNN:
End Sub

Private Sub ToolStripMenuItem2_Click_1( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
ContextMenuStrip1.SourceControl.Focus
SendKeys.Send(vbNewLine)
End Sub

Private Sub RemoveToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
ContextMenuStrip1.SourceControl.Focus    
SendKeys.Send(Keys.Delete)
End Sub

Private Sub Form6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub Form6_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
If e.CloseReason = CloseReason.UserClosing  then
e.Cancel = True
Me.hide
End If
End Sub

Private Sub Form6_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub Form6_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
Me.MdiParent = MDIParent1
End Sub

Private Sub Form6_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If MDIParent1.Label2.Top <> 0 then
        Me.Top = MDIParent1.Label2.Top
        End If
        If MDIParent1.Label2.left <> 0 then
        Me.left = MDIParent1.Label2.left
        End If
MDIParent1.Panel1.Enabled = False
End Sub

Public Sub AddButton(name As string, text As string, tag As string, left As integer, top As Integer, visible As string)
If visible = "True" then
Dim btn As New Button
btn.Name = name
btn.Text = text
btn.Tag = tag
btn.Size = new Size(144,90) 
btn.Location = new Point (left,top)
btn.BackColor = color.White
btn.BackgroundImage = PictureBox1.Image
btn.BackgroundImageLayout = ImageLayout.Stretch
ToolTip1.SetToolTip(btn, btn.tag) 
btn.ContextMenuStrip = ContextMenuStrip1
btn.Cursor = Cursors.SizeAll
btn.Font = New Font ("Microsoft Sans Serif", 9.75, FontStyle.Bold)
AddHandler btn.MouseMove , AddressOf GenButton_MouseMove
AddHandler btn.KeyDown, AddressOf GenButton__KeyDown 
AddHandler btn.MouseDown, AddressOf GenButton_MouseDown
Panel2.Controls.Add(btn)
btn.BringToFront
Return
End If
End Sub

Private Sub ToolStripMenuItem5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
QBASIC.Compile
End Sub

Private Sub ToolStripMenuItem6_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
QBASIC.Compile  
QBASIC.CompileRun
End Sub

Private Sub Button1_Click_1( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button1.Click
Panel1.Hide
End Sub

Private Sub Button2_Click_1( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button2.Click
If TextBox1.Text <> "" then
Dim btn As New Button
btn.Name = TextBox1.Text
btn.Text = TextBox1.Text + "()"
If TextBox1.Text = "main" then
btn.Text = "Main"
End If
btn.Tag = combobox1.Text + " " + TextBox1.Text + "(" + textbox2.Text + ")"
btn.Size = new Size(144,90) 
btn.Location = new Point (val(TextBox3.Text),val(TextBox4.Text))
TextBox3.Text = val(TextBox3.Text) + 10
btn.BackColor = color.White
btn.BackgroundImage = PictureBox1.Image
btn.BackgroundImageLayout = ImageLayout.Stretch
ToolTip1.SetToolTip(btn, btn.tag) 
btn.Cursor = Cursors.SizeAll
btn.Font = New Font ("Microsoft Sans Serif", 9.75, FontStyle.Bold)
btn.ContextMenuStrip = ContextMenuStrip1
AddHandler btn.MouseMove , AddressOf GenButton_MouseMove
AddHandler btn.KeyDown, AddressOf GenButton__KeyDown
AddHandler btn.MouseDown, AddressOf GenButton_MouseDown
Panel2.Controls.Add(btn)
btn.BringToFront
Panel1.Hide
End If
End Sub

Private Sub ComboBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.GotFocus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub Panel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel2.Click
Me.Focus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub Panel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.Click
  Me.Focus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub TextBox1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub TextBox2_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub ToolStripMenuItem8_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
ContextMenuStrip1.SourceControl.Focus
SendKeys.Send("{Home}")
End Sub

Private Sub ToolStripMenuItem9_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
ContextMenuStrip1.SourceControl.Focus
SendKeys.Send("{End}")
End Sub

Private Sub EditorToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles EditorToolStripMenuItem.Click
  Form1.Show
Form1.Focus
Form1.TextBox1.Focus
End Sub

Private Sub RemoveAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles RemoveAllToolStripMenuItem.Click
  QBASIC.Compile
QBASIC.CompileRun
End Sub

Private Sub CompileToolStripMenuItem2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CompileToolStripMenuItem2.Click
  QBASIC.Compile
End Sub

Private Sub ToolStripMenuItem12_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
AddButton("main", "Main", "void main()", val(TextBox3.Text), val(TextBox4.Text), "True")
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
AddButton("main", "Main", "int main()", val(TextBox3.Text), val(TextBox4.Text), "True")
End If
TextBox4.Text = val(TextBox4.Text) + 10
End Sub

Private Sub FunctionToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles FunctionToolStripMenuItem1.Click
   Panel1.Show
End Sub

Private Sub DeleteAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles DeleteAllToolStripMenuItem.Click
  For Each k As control In Panel2.Controls
k.Hide
Next
End Sub

Private Sub ArrangeIconsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
Dim k1 As Integer
Dim k2 As Integer
k1 = 5
k2 = 8
For Each k As control In Panel2.Controls
k.Location = new Point(k1, k2)
k2 = k2 + 95
If k2 >= Panel2.Height - 95 then
k2 = 8
k1 = k1 + 150
End If
Next
End Sub

Private Sub ChangeIconsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ChangeIconsToolStripMenuItem.Click
Form4.Show
Form4.Focus
Form4.TextBox1.Focus
End Sub

Friend Sub GenButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

If e.Clicks = 2 then
If Form1.WindowState = FormWindowState.Minimized then
Form1.WindowState = FormWindowState.Normal 
End If
Form1.Show
Form1.Focus
If Form1.TextBox1.Text.IndexOf(sender.tag) = -1 then
If sender.name = "main" then
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + sender.tag + vbnewline + "{" + vbnewline + vbNewLine + "getch();" + vbNewLine + "}" + vbNewLine + MDIParent1.Button9.Tag 
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + sender.tag + vbnewline + "{" + vbnewline + vbNewLine + "getch();" + vbNewLine + "return 0;" + vbNewLine + "}" + vbNewLine + MDIParent1.Button9.Tag 
End If
Else
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + sender.tag + vbnewline + "{" + vbnewline + vbNewLine + "}" + vbNewLine +  MDIParent1.Button9.Tag 
End If
Form1.TextBox1.Focus
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag)-1, 0)
Form1.TextBox1.ScrollToCaret
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag) + sender.tag.ToString.Length + 3, 0)
Else
Form1.TextBox1.Focus
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag)-1, 0)
Form1.TextBox1.ScrollToCaret
Form1.TextBox1.Select(Form1.TextBox1.Text.IndexOf(sender.tag) + sender.tag.ToString.Length + 3 , 0)
End If 
End If
End Sub

Private Sub ToolStripMenuItem18_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem18.Click
  Panel2.Focus
End Sub

Private Sub CloseToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) 
  Me.Hide
End Sub

Private Sub Button5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button5.Click
  Panel1.Show
End Sub

Private Sub Button8_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button8.Click
  QBASIC.Compile
End Sub

Private Sub Button7_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button7.Click
  QBASIC.Save
End Sub

Private Sub Button3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button3.Click
For Each k As control In Panel2.Controls
k.Hide
Next
End Sub

Private Sub Button6_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button6.Click
  Me.Hide
End Sub

Private Sub Button4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button4.Click
QBASIC.HideAutoCorrectBox
Form1.Show
Form1.Focus
Form1.Panel7.Show
Form1.TextBox3.Focus
End Sub

Private Sub ToolStripMenuItem3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
Form7.Show
Form7.Focus
End Sub
End Class