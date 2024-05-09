Public Class Form7
Dim qbasic As New Form2

Private Sub ListView1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.GotFocus
MDIParent1.Panel1.Enabled = False
End Sub

Private Sub ListView1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Resize
ListView1.Columns(0).Width = ListView1.Width - 10
End Sub

Private Sub ToolStripMenuItem3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
  ListView1.Items.Add("")
End Sub

Private Sub ClearAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
  ListView1.Items.Clear
End Sub

Private Sub CloseToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
  Me.Hide
End Sub

Private Sub BuildMenuToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BuildMenuToolStripMenuItem.Click
Dim k1 As String
k1 = InputBox("Enter MenuName: ", "GCC++", "showMenu1")
If k1 <> "" then
Dim i As Integer
Dim k As String = ""
For i = 1 to ListView1.Items.Count 
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
k = k + "printf(" + Chr(34) + "\n" + ListView1.Items(i-1).Text + chr(34) + ");" + vbNewLine 
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
k = k + "std::cout << " + Chr(34) + "\n" + ListView1.Items(i-1).Text + chr(34) + ";" + vbNewLine 
End If
Next
k = "void " + k1 + "()" + vbNewLine + "{" + vbNewLine + k + vbNewLine + "}" + vbNewLine
Form1.TextBox1.Text = Form1.TextBox1.Text + vbNewLine + k +  MDIParent1.Button9.Tag
qbasic.HighlightIntend 
Form6.AddButton(k1, k1+"()", "void " + k1 + "()", 5, 8, True)
End If
End Sub

Private Sub ToolStripMenuItem4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
If ListView1.SelectedItems.Count>0 then
ListView1.Items(ListView1.SelectedItems(0).Index).Remove
End If
End Sub

Private Sub ToolStripMenuItem5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
  Button1.Focus
End Sub

Private Sub Form7_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If e.CloseReason = CloseReason.UserClosing then
        e.Cancel = True
        Me.hide
        End If
End Sub

Private Sub Form7_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
  Me.MdiParent = MDIParent1
End Sub

Private Sub Form7_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
MDIParent1.Panel1.Enabled = False
End Sub
End Class
