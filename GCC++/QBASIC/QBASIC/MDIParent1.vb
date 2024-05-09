Public Class MDIParent1
Dim QBASIC As new Form2

Private Sub NewToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
NewForm.MdiParent = me
NewForm.Show
End Sub

Private Sub ShowToolStripMenuItem2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem2.Click
If Me.HelpToolStripButton.Enabled = True then
Form1.show
Form1.Focus
End If
End Sub

Private Sub HideToolStripMenuItem2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HideToolStripMenuItem2.Click
Form1.Hide
End Sub

Private Sub OpenToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
QBASIC.Open
End Sub

Private Sub SaveToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
QBASIC.Save
End Sub

Private Sub PrintToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
QBASIC.LoadSettings
Me.Status.Text = "Ready"
End Sub

Private Sub PrintPreviewToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
QBASIC.SaveSettings
End Sub

Private Sub ToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
QBASIC.DeleteSettings
End Sub

Private Sub ExitToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
End
End Sub

Private Sub UndoToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
If Form4.textbox1.Focused = True then
Form4.TextBox1.Undo
Else if Form1.textbox2.Focused = True then
Form1.TextBox2.Undo
Else if Form1.textbox3.Focused = True then
Form1.TextBox3.Undo
Else if BoxForm.textbox1.Focused = True then
BoxForm.TextBox1.Undo
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub RedoToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
If Form4.textbox1.Focused = True then
Form4.TextBox1.Undo
Else if Form1.textbox2.Focused = True then
Form1.TextBox2.Undo
Else if Form1.textbox3.Focused = True then
Form1.TextBox3.Undo
Else if BoxForm.textbox1.Focused = True then
BoxForm.TextBox1.Undo
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub CutToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
If Form1.TextBox1.Focused = True then
Form1.TextBox1.Cut
Else if Form4.textbox1.Focused = True then
Form4.TextBox1.cut
Else if Form1.textbox2.Focused = True then
Form1.TextBox2.cut
Else if Form1.textbox3.Focused = True then
Form1.TextBox3.cut
Else if BoxForm.textbox1.Focused = True then
BoxForm.TextBox1.cut
Else if Form6.textbox1.Focused = True then
Form6.TextBox1.cut
Else if Form6.textbox2.Focused = True then
Form6.textbox2.cut
Else if Form6.textbox3.Focused = True then
Form6.textbox3.cut
Else if Form6.textbox4.Focused = True then
Form6.textbox4.cut
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub CopyToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
If Form1.TextBox1.Focused = True then
Form1.TextBox1.copy
Else if Form4.textbox1.Focused = True then
Form4.TextBox1.copy
Else if Form1.textbox2.Focused = True then
Form1.TextBox2.copy
Else if Form1.textbox3.Focused = True then
Form1.TextBox3.copy
Else if BoxForm.textbox1.Focused = True then
BoxForm.TextBox1.copy
Else if Form6.textbox1.Focused = True then
Form6.TextBox1.Copy
Else if Form6.textbox2.Focused = True then
Form6.textbox2.Copy
Else if Form6.textbox3.Focused = True then
Form6.textbox3.Copy
Else if Form6.textbox4.Focused = True then
Form6.textbox4.Copy
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub PasteToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
If Form1.TextBox1.Focused = True then
Me.Status.Text = "Pasting"
Form1.TextBox1.Paste
Me.Status.Text = "Pasted"
Else if Form4.textbox1.Focused = True then
Form4.TextBox1.Paste
Else if Form1.textbox2.Focused = True then
Form1.TextBox2.paste
Else if Form1.textbox3.Focused = True then
Form1.TextBox3.paste
Else if BoxForm.textbox1.Focused = True then
BoxForm.TextBox1.paste
Else if Form6.textbox1.Focused = True then
Form6.textbox1.paste
Else if Form6.textbox2.Focused = True then
Form6.textbox2.paste
Else if Form6.textbox3.Focused = True then
Form6.textbox3.paste
Else if Form6.textbox4.Focused = True then
Form6.textbox4.paste
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub ToolStripMenuItem9_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
If Me.HelpToolStripButton.Enabled = True then
Form1.Show
Form1.Focus
Form1.Panel7.Visible = True
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub ToolStripMenuItem10_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
If Me.HelpToolStripButton.Enabled = True then
Form1.Show
Form1.Focus
Form1.Panel7.Visible = True
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub SelectAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
If Form1.TextBox1.Focused = True then
Form1.TextBox1.Focus
Form1.TextBox1.SelectAll
Else if Form4.textbox1.Focused = True then
Form4.TextBox1.Focus
Form4.TextBox1.SelectAll
Else if Form1.textbox2.Focused = True then
Form1.TextBox2.Focus
Form1.TextBox2.SelectAll
Else if Form1.textbox3.Focused = True then
Form1.TextBox3.Focus
Form1.TextBox3.SelectAll
Else if BoxForm.textbox1.Focused = True then
BoxForm.TextBox1.Focus
BoxForm.TextBox1.SelectAll
Else if Form6.textbox1.Focused = True then
Form6.textbox1.SelectAll
Else if Form6.textbox2.Focused = True then
Form6.textbox2.SelectAll
Else if Form6.textbox3.Focused = True then
Form6.textbox3.SelectAll
Else if Form6.textbox4.Focused = True then
Form6.textbox4.SelectAll
End If
QBASIC.HideAutoCorrectBox
End Sub

Private Sub ClearAllToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
QBASIC.HideAutoCorrectBox
Form1.TextBox1.Text = ""
Me.Status.Text = "Cleared"
End Sub

Private Sub LineToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles LineToolStripMenuItem.Click
QBASIC.HideAutoCorrectBox
QBASIC.InsertLine
End Sub

Private Sub GoToLineToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles GoToLineToolStripMenuItem.Click
Dim k As String
k = InputBox("Enter Line Number: ", "Go To Line", "1")
If val(k) > 0 then
QBASIC.HighlightLine (val(k)-1)
End If
End Sub

Private Sub ToolStripMenuItem20_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem20.Click
Button7.Tag = "//_____________________________________________________________________________________________"
End Sub

Private Sub ToolStripMenuItem15_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
Button7.Tag = "//------------------------------------------------"
End Sub

Private Sub ToolStripMenuItem14_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
Button7.Tag = "/*-------------------------------------------------------------------------------------------*/"
End Sub

Private Sub ToolStripMenuItem16_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
Button7.Tag = "'----------------------------------------------------------------------------------------------"
End Sub

Private Sub AboutToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
MessageBox.Show("C and C++ Compiler"+vbNewLine+"IDE Name: GCC++"+vbNewLine+"IDE Version 1.0"+vbNewLine+"Developer: Supriyo Saha"+vbNewLine+"(C) Copyright 2021"+vbNewLine, "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
End Sub

Private Sub MakeExeToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MakeExeToolStripMenuItem.Click
If Form1.SaveFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel
QBASIC.MakeEXE(Form1.SaveFileDialog2.FileName)
End If    
End Sub

Private Sub CleanToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CleanToolStripMenuItem.Click
QBASIC.Clean
Me.Status.Text = "Cleaned"
End Sub

Private Sub CompileToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CompileToolStripMenuItem.Click
QBASIC.Compile
QBASIC.CompileRun
End Sub

Private Sub OnToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OnToolStripMenuItem.Click
Button1.Tag = 1
End Sub

Private Sub OffToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OffToolStripMenuItem.Click
Button1.Tag = 0
End Sub

Private Sub ShowToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem1.Click
Me.Statusbar1.Visible = True
End Sub

Private Sub HideToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HideToolStripMenuItem1.Click
Me.Statusbar1.Visible = false
End Sub

Private Sub CustoToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CustoToolStripMenuItem.Click
Dim k As String
k = QBASIC.Box("Enter Line character: ", "Set Custom Line", Button7.tag)
Button7.Tag = k
End Sub

Private Sub BAToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles BAToolStripMenuItem.Click
If Form1.ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel
Form1.TextBox1.BackColor = Form1.ColorDialog1.Color
QBASIC.LoadForm1
End if
End Sub

Private Sub NoneToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles NoneToolStripMenuItem1.Click
Form1.TextBox1.WordWrap = False
End Sub

Private Sub PresentToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PresentToolStripMenuItem.Click
Form1.TextBox1.WordWrap = True
QBASIC.LoadForm1
End Sub

Private Sub ToolStripMenuItem11_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem11.Click
Form1.TextBox1.ScrollBars = ScrollBars.None
QBASIC.LoadForm1
End Sub

Private Sub HorizontalToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click
Form1.TextBox1.ScrollBars = ScrollBars.Horizontal
QBASIC.LoadForm1
End Sub

Private Sub VerticalToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click
Form1.TextBox1.ScrollBars = ScrollBars.Vertical
QBASIC.LoadForm1
End Sub

Private Sub NoneToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles NoneToolStripMenuItem.Click
Form1.TextBox1.ScrollBars = ScrollBars.Both
QBASIC.LoadForm1
End Sub

Private Sub OpenToolStripButton_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
QBASIC.Open
End Sub

Private Sub SaveToolStripButton_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
QBASIC.Save
End Sub

Private Sub HelpToolStripButton_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HelpToolStripButton.Click
If Me.HelpToolStripButton.Enabled = True then
Form1.show
Form1.Focus
End If
End Sub

Private Sub PrintToolStripButton_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PrintToolStripButton.Click
QBASIC.Compile
QBASIC.CompileRun
End Sub

Private Sub PrintPreviewToolStripButton_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles PrintPreviewToolStripButton.Click
If Form1.SaveFileDialog2.ShowDialog <> Windows.Forms.DialogResult.Cancel
QBASIC.MakeEXE(Form1.SaveFileDialog2.FileName)
End If    
End Sub

Private Sub TextColorToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles TextColorToolStripMenuItem.Click
If Form1.ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel
Form1.TextBox1.ForeColor = Form1.ColorDialog1.Color
QBASIC.LoadForm1
End if
End Sub

Private Sub NewToolStripButton_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles NewToolStripButton.Click
NewForm.MdiParent = me
NewForm.Show
End Sub

Private Sub Timer1_Tick( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Timer1.Tick
NewForm.MdiParent = me
NewForm.Show
Me.UseWaitCursor = False
Me.Timer1.Enabled = False
End Sub

Private Sub MDIParent1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
On Error Resume Next 
End
End Sub

Private Sub MDIParent1_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
Button3.Tag = vbnewline + button7.tag + vbnewline + "/*" + vbnewline + vbnewline + "Enter your comments below" + vbnewline + "." + vbnewline + "." + vbnewline + "." + vbnewline + vbnewline + "*/" + vbnewline + button7.tag + vbnewline + vbnewline
Button5.Tag = vbNewLine  + "void FuntionName()" + vbnewline + "{" + vbnewline + vbnewline + "." + vbnewline + "." + vbnewline + "." + vbnewline + vbnewline + "}" + vbNewLine +  vbNewLine + "//------------------------------------------------" + vbNewLine + vbNewLine
Button6.Tag = vbNewLine + "void main()" + vbnewline + "{" + vbnewline + vbnewline + "." + vbnewline + "." + vbnewline + "." + vbnewline + vbnewline+ "getch();" + vbnewline + "}" + vbNewLine +  vbNewLine+ "//------------------------------------------------" + vbNewLine + vbNewLine
Button8.Tag = "#include<stdio.h>" + vbnewline + "#include<conio.h>" + vbnewline + "#include<stdlib.h>" + vbNewLine +  "//------------------------------------------------" + vbNewLine + vbNewLine + "void main()" + vbnewline + "{" + vbnewline + vbnewline + "." + vbnewline + "." + vbnewline + "." + vbnewline + vbnewline+ "getch();" + vbnewline + "}" + vbNewLine +  vbNewLine + "//------------------------------------------------" + vbNewLine + vbNewLine
Button700.Tag = "#include<stdio.h>" + vbnewline + "#include<conio.h>" + vbnewline + "#include<stdlib.h>" + vbNewLine + "//------------------------------------------------" + vbNewLine + vbNewLine
Button9.Tag = vbNewLine + "/*" + vbNewLine + "_____________________________________________________________________________________________________________________________________________________________*/" + vbNewLine + vbNewLine
Button10.Tag = "switch(VariableName)" + vbnewline + "{" + vbnewline + "case 1:" + vbnewline + "break;" + vbnewline + vbnewline + "case 2:" + vbnewline + "break;" + vbnewline + vbnewline + "default:" + vbnewline + "break;" + vbnewline + "}" + vbnewline
Button11.Tag = "do" + vbNewLine + "{" + vbnewline + vbnewline + "}" + vbnewline + "while( Conditions );" + vbnewline
Button12.Tag = "while( Conditions )" + vbNewLine + "{" + vbnewline + vbnewline + "}" + vbnewline
Button13.Tag = "for( ; ; )" + vbNewLine +"{" + vbnewline + vbnewline + "}" + vbnewline
Button14.Tag = "if( Conditions )" + vbnewline + "{" + vbnewline + vbNewLine + "}" + vbnewline + "else" + vbnewline + "{" + vbnewline + vbNewLine + "}" + vbnewline
Button16.Tag = vbnewline + "struct/union StructUnionName {" + vbnewline + "." + vbnewline + "." + vbnewline + "};" + vbnewline

QBASIC.LoadSettings
Status.Text = "Ready"
End Sub

Private Sub ShowToolStripMenuItem3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem3.Click
If Me.HelpToolStripButton.Enabled = True then
If Panel1.Visible = False then
Panel1.Visible = True
Else
Panel1.Visible = False
End If
End If
End Sub

Private Sub IncreaseWidthToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles IncreaseWidthToolStripMenuItem.Click
If Panel1.Width < 550 then
Panel1.Width = Panel1.Width + 20
End If
End Sub

Private Sub DecreaseWidthToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles DecreaseWidthToolStripMenuItem.Click
If Panel1.Width > 100 then
Panel1.Width = Panel1.Width - 20
End If
End Sub

Private Sub ShowToolStripMenuItem4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem4.Click
If Me.HelpToolStripButton.Enabled = True then
Form4.show()
Form4.Focus
End If
End Sub

Private Sub HideToolStripMenuItem4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HideToolStripMenuItem4.Click
Form4.Hide()
End Sub

Private Sub ShowToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
HelpToolStripButton.tag = 1
QBASIC.LoadForm1
If Form1.Width < = 690 then
Form1.Width = 690
End If
End Sub

Private Sub HideToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
HelpToolStripButton.tag = 0
QBASIC.LoadForm1
End Sub

Private Sub ToolStripMenuItem8_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
Button7.Tag = "/*" + vbNewLine + "_____________________________________________________________________________________________________________________________________________________________*/" + vbNewLine
End Sub

Private Sub ToolStripMenuItem19_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem19.Click
QBASIC.Compile
End Sub

Private Sub OffToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OffToolStripMenuItem1.Click
ListBox2.Tag = 0
QBASIC.HideAutoCorrectBox
Status.Text = "Autocorrect Turned Off"
End Sub

Private Sub OnToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OnToolStripMenuItem1.Click
ListBox2.Tag = 1
Status.Text = "Autocorrect Turned On"
End Sub

Private Sub ToolStripButton1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripButton1.Click
QBASIC.Compile
End Sub

Private Sub OnToolStripMenuItem2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OnToolStripMenuItem2.Click
        Me.ToolStripMenuItem23.Tag = 1
End Sub

Private Sub OffToolStripMenuItem2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OffToolStripMenuItem2.Click
        Me.ToolStripMenuItem23.Tag = 0
End Sub

Private Sub OnToolStripMenuItem3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OnToolStripMenuItem3.Click
        UseSuggestionFromCodeToolStripMenuItem.Tag = 1
End Sub

Private Sub OffToolStripMenuItem3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OffToolStripMenuItem3.Click
        UseSuggestionFromCodeToolStripMenuItem.Tag = 0
End Sub

Private Sub ToolStripMenuItem25_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem25.Click
QBASIC.CompileRun2
End Sub

Private Sub AllCommentsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AllCommentsToolStripMenuItem.Click
        Me.Status.Text = "Removing Comments"
        Form1.TextBox1.Text = QBASIC.RemoveComments(Form1.TextBox1.Text)
        Me.Status.Text = "Comments Removed"
End Sub

Private Sub MultiLineCommentsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MultiLineCommentsToolStripMenuItem.Click
        Me.Status.Text = "Removing Comments"
        Form1.TextBox1.Text = QBASIC.RemoveMultiComments(Form1.TextBox1.Text)
        Me.Status.Text = "Comments Removed"
End Sub

Private Sub SingleLineCommentsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SingleLineCommentsToolStripMenuItem.Click
        Me.Status.Text = "Removing Comments"
        Form1.TextBox1.Text = QBASIC.RemoveSingleComments(Form1.TextBox1.Text)
        Me.Status.Text = "Comments Removed"
End Sub

Private Sub SetMaxCompileTimeToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SetMaxCompileTimeToolStripMenuItem.Click
On Error Goto BB22
Dim k As String
k = inputbox("Enter the value in Mili-Seconds: ", "GCC++", "500")
If Val(k) > 0 then
Dim Files1 As New System.IO.StreamWriter( "Timer.bak" )
Files1.WriteLine(Val(k))
Files1.Close
Status.Text = "Set Successfull"
End If
Exit Sub 
BB22:
Status.Text = "Set Unsuccessfull"
End Sub

Private Sub CToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CToolStripMenuItem.Click
        Status.Text = "Changing Configuration"
        Dim psi As New Process
        psi.StartInfo.FileName = "header.txt"
        psi.Start
        psi.WaitForExit
If Me.SaveFileDialog1.DefaultExt = "c" then
QBASIC.LoadSettings2("header.txt")
Else
QBASIC.LoadSettings2("headercpp.txt")
End If
        Status.Text = "Configuration Changed"
End Sub

Private Sub CPPToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CPPToolStripMenuItem.Click
        Status.Text = "Changing Configuration"
        Dim psi As New Process
        psi.StartInfo.FileName = "headercpp.txt"
        psi.Start
        psi.WaitForExit
        If Me.SaveFileDialog1.DefaultExt = "c" then
QBASIC.LoadSettings2("header.txt")
Else
QBASIC.LoadSettings2("headercpp.txt")
End If
        Status.Text = "Configuration Changed"
End Sub

Private Sub CToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CToolStripMenuItem1.Click
        Status.Text = "Changing Configuration"
        Dim psi As New Process
        psi.StartInfo.FileName = "header.txt"
        psi.Start
        psi.WaitForExit
        If Me.SaveFileDialog1.DefaultExt = "c" then
QBASIC.LoadSettings2("header.txt")
Else
QBASIC.LoadSettings2("headercpp.txt")
End If
        Status.Text = "Configuration Changed"
End Sub

Private Sub CPPToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CPPToolStripMenuItem1.Click
        Status.Text = "Changing Configuration"
        Dim psi As New Process
        psi.StartInfo.FileName = "headercpp.txt"
        psi.Start
        psi.WaitForExit
        If Me.SaveFileDialog1.DefaultExt = "c" then
QBASIC.LoadSettings2("header.txt")
Else
QBASIC.LoadSettings2("headercpp.txt")
End If
        Status.Text = "Configuration Changed"
End Sub

Private Sub EditorToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles EditorToolStripMenuItem.Click
If(Form1.FontDialog1.ShowDialog<>Windows.Forms.DialogResult.Cancel) then
Form1.TextBox1.Font = form1.FontDialog1.Font
End If
End Sub

Private Sub TemporarySpaceToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles TemporarySpaceToolStripMenuItem.Click
If(Form1.FontDialog1.ShowDialog<>Windows.Forms.DialogResult.Cancel) then
Form4.TextBox1.Font = form1.FontDialog1.Font
End If
End Sub

Private Sub AutoSuggestionToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AutoSuggestionToolStripMenuItem.Click
If Form1.ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel
Form1.SimpleListView.ForeColor = Form1.ColorDialog1.Color
Form1.GraphicalListView.ForeColor = Form1.SimpleListView.ForeColor
End if
End Sub

Private Sub SuggestionsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SuggestionsToolStripMenuItem.Click
If(Form1.FontDialog1.ShowDialog<>Windows.Forms.DialogResult.Cancel) then
Form1.SimpleListView.Font = form1.FontDialog1.Font
End If
End Sub

Private Sub Button28_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button28.Click
If Panel1.Width < 550 then
Panel1.Width = Panel1.Width + 20
End If
End Sub

Private Sub Button27_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button27.Click
If Panel1.Width > 100 then
Panel1.Width = Panel1.Width - 20
End If
End Sub

Private Sub AddNewToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        Dim k1 As String
                
        If ContextMenuStrip2.SourceControl.Name = "Button100" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button100.Text = k1
        End If
        
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button2" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button2.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button3" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button3.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button4" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button4.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button5" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button5.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button6" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button6.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button700" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button700.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button8" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button8.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button9" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button9.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button10" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button10.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button11" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button11.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button12" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button12.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button13" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button13.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button14" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button14.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button15" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button15.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button16" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button16.Text = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button17" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button17.Text = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button18" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button18.Text = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button19" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button19.Text = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button20" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button20.Text = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button21" then
        k1 = InputBox("Enter the new name for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Change Name")
        if  k1 <> "" then
        Button21.Text = k1
        End If
        
        
End If        
End Sub

Private Sub RemoveToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles RemoveToolStripMenuItem.Click
         Dim k1 As String
                
        If ContextMenuStrip2.SourceControl.Name = "Button100" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button100.Tag)
        if  k1 <> "" then
        Button100.tag = k1
        End If
        
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button2" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button7.Tag)
        if  k1 <> "" then
        Button7.Tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button3" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button3.Tag)
        if  k1 <> "" then
        Button3.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button4" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button4.Tag)
        if  k1 <> "" then
        Button4.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button5" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button5.Tag)
        if  k1 <> "" then
        Button5.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button6" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button6.Tag)
        if  k1 <> "" then
        Button6.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button700" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button700.Tag)
        if  k1 <> "" then
        Button700.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button8" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button8.Tag)
        if  k1 <> "" then
        Button8.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button9" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button9.Tag)
        if  k1 <> "" then
        Button9.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button10" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button10.Tag)
        if  k1 <> "" then
        Button10.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button11" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button11.Tag)
        if  k1 <> "" then
        Button11.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button12" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button12.Tag)
        if  k1 <> "" then
        Button12.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button13" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button13.Tag)
        if  k1 <> "" then
        Button13.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button14" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button14.Tag)
        if  k1 <> "" then
        Button14.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button15" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button15.Tag)
        if  k1 <> "" then
        Button15.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.name = "Button16" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button16.Tag)
        if  k1 <> "" then
        Button16.tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button17" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button17.Tag)
        if  k1 <> "" then
        Button17.Tag = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button18" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button18.Tag)
        if  k1 <> "" then
        Button18.Tag = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button19" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button19.Tag)
        if  k1 <> "" then
        Button19.Tag = k1
        End If
        
         ElseIf  ContextMenuStrip2.SourceControl.Name = "Button20" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button20.Tag)
        if  k1 <> "" then
        Button20.Tag = k1
        End If
        
        ElseIf  ContextMenuStrip2.SourceControl.Name = "Button21" then
        k1 = QBASIC.Box("Enter the new data for the control" + vbNewLine + "Please Note: Only changes made to CUSTOM TAB can be saved with (Save Settings Option)", "Enter Data", Button21.Tag)
        if  k1 <> "" then
        Button21.Tag = k1
        End If
        
        
End If        
End Sub

Private Sub Button8_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button8.Click
        QBASIC.Paste(button8.Tag)
End Sub

Private Sub Button700_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button700.Click
        QBASIC.Paste(button700.Tag)
End Sub

Private Sub Button6_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button6.Click
        QBASIC.Paste(button6.Tag)
End Sub

Private Sub Button5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button5.Click
        QBASIC.Paste(button5.Tag)
End Sub

Private Sub Button16_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button16.Click
        QBASIC.Paste(button16.Tag)
End Sub

Private Sub Button15_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button15.Click
        QBASIC.Paste(button15.Tag)
End Sub

Private Sub Button14_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button14.Click
        QBASIC.Paste(button14.Tag)
End Sub

Private Sub Button10_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button10.Click
        QBASIC.Paste(button10.Tag)
End Sub

Private Sub Button13_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button13.Click
        QBASIC.Paste(button13.Tag)
End Sub

Private Sub Button12_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button12.Click
        QBASIC.Paste(button12.Tag)
End Sub

Private Sub Button11_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button11.Click
        QBASIC.Paste(button11.Tag)
End Sub

Private Sub Button3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button3.Click
        QBASIC.Paste(button3.Tag)
End Sub

Private Sub Button2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button2.Click
        QBASIC.Paste(button7.Tag)
End Sub

Private Sub Button9_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button9.Click
        QBASIC.Paste(button9.Tag)
End Sub

Private Sub Button21_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button21.Click
        QBASIC.Paste(button21.Tag)
End Sub

Private Sub Button20_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button20.Click
        QBASIC.Paste(button20.Tag)
End Sub

Private Sub Button19_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button19.Click
        QBASIC.Paste(button19.Tag)
End Sub

Private Sub Button18_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button18.Click
        QBASIC.Paste(button18.Tag)
End Sub

Private Sub Button17_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button17.Click
        QBASIC.Paste(button17.Tag)
End Sub

Private Sub Button100_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button100.Click
        QBASIC.Paste(button100.Tag)
End Sub

Private Sub Button4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button4.Click
        QBASIC.Paste(button4.Tag)
End Sub

Private Sub CompilerArguments_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles CompilerArguments.Click
        Dim k As String
        k = InputBox("Enter the Compiler options[-w to suppress warnings]: ","GCC++", CompilerArguments.Tag)
        CompilerArguments.Tag = k       
End Sub

Private Sub SimpleUIToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SimpleUIToolStripMenuItem.Click
QBASIC.HideAutoCorrectBox
Form1.GraphicalListViewPanel2.Height = 0
Form1.GraphicalListViewPanel2.Width  = 0
Form1.SimpleListView.Width = 120
Form1.SimpleListView.Height = 94
End Sub

Private Sub GraphicalUIToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles GraphicalUIToolStripMenuItem.Click
QBASIC.HideAutoCorrectBox
Form1.SimpleListView.Width = 0
Form1.SimpleListView.Height = 0    
Form1.GraphicalListViewPanel2.Height = 126
Form1.GraphicalListViewPanel2.Width  = 156
End Sub

Private Sub ShowToolStripMenuItem5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem5.Click
If Me.HelpToolStripButton.Enabled = True then
Form6.show
Form6.Focus
End If
End Sub

Private Sub HideToolStripMenuItem3_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HideToolStripMenuItem3.Click
  Form6.Hide
End Sub

Private Sub ToolStripButton2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripButton2.Click
If Me.HelpToolStripButton.Enabled = True then
Form6.show
Form6.Focus
End If
End Sub

Private Sub OnToolStripMenuItem4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OnToolStripMenuItem4.Click
ToolStripMenuItem29.Tag = 1
End Sub

Private Sub OffToolStripMenuItem4_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OffToolStripMenuItem4.Click
ToolStripMenuItem29.Tag = 0
Dim k1 As Integer
k1 = Form1.TextBox1.SelectionStart
Form1.TextBox1.SelectAll
Form1.TextBox1.SelectionColor =  Form1.TextBox1.ForeColor
Form1.TextBox1.SelectionBackColor =  Form1.TextBox1.BackColor
Form1.TextBox1.Select(k1,0)
Form1.TextBox1.SelectionColor =  Form1.TextBox1.ForeColor
Form1.TextBox1.SelectionBackColor =  Form1.TextBox1.BackColor
Form1.TextBox1.Focus
End Sub

Private Sub AddRemoveKeywordsToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AddRemoveKeywordsToolStripMenuItem.Click
Status.Text = "Changing Configuration"
Dim psi As New Process
psi.StartInfo.FileName = "highlight.txt"
psi.Start
psi.WaitForExit
If Me.SaveFileDialog1.DefaultExt = "c" then
QBASIC.LoadSettings2("header.txt")
Else
QBASIC.LoadSettings2("headercpp.txt")
End If
Status.Text = "Configuration Changed"
End Sub

Private Sub ShowToolStripMenuItem6_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ShowToolStripMenuItem6.Click
  If Me.HelpToolStripButton.Enabled = True then
Form7.show()
Form7.Focus
End If
End Sub

Private Sub HideToolStripMenuItem5_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles HideToolStripMenuItem5.Click
  Form7.Hide
End Sub

Private Sub ToolStripMenuItem32_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ToolStripMenuItem32.Click
Dim k111 As String
k111 = InputBox ("Enter Parameters: ", "GCC++")
If k111 <> "" then
QBASIC.Compile
QBASIC.CompileRunParameter(k111)
End If
End Sub
End Class