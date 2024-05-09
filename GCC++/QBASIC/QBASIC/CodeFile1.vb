Imports System.Text.RegularExpressions
Public Class Form2
Dim Undo(1000) As String
Dim UndoIndex(1000) As Integer
Dim Redocount As Integer = 0
Dim countredo As Integer = 0
Dim redoparameter As string
Dim pospar As Integer = 0

Public Declare Function LockWindowUpdate Lib "user32" ( _
    ByVal hWnd As Integer) As Integer 

Dim k101 As Integer
Dim mc101 As MatchCollection
Dim m101 As Match
Dim k1101 As String 

Public Sub Save()
On Error Goto SaveBB
Dim k As Windows.Forms.DialogResult
If MDIParent1.HelpToolStripButton.Enabled = True then
If MDIParent1.TextBox1.Tag = "" then
k = MDIParent1.SaveFileDialog1.ShowDialog
If k <> DialogResult.Cancel then
MDIParent1.TextBox1.Tag = MDIParent1.SaveFileDialog1.FileName
End If
End If
Dim FILE_NAME As String = MDIParent1.TextBox1.Tag
If FILE_NAME <> "" then
Dim objWriter As New System.IO.StreamWriter( FILE_NAME )
For Each l As String In Form1.TextBox1.Lines 
objWriter.WriteLine(l)
Next
objWriter.Close()

Dim objWriter1 As New System.IO.StreamWriter( FILE_NAME + ".design" )
objWriter1.WriteLine(Form6.Panel2.Controls.Count)
For Each k44 As control In Form6.Panel2.Controls 
objWriter1.WriteLine(k44.Name)
objWriter1.WriteLine(k44.Text)
objWriter1.WriteLine(k44.Tag)
objWriter1.WriteLine(k44.left)
objWriter1.WriteLine(k44.top)
objWriter1.WriteLine(k44.Visible)
Next
objWriter1.Close()

countredo = 0
Redocount = 0

MDIParent1.Status.Text = "Saved"
MDIParent1.Text = "GCC++ " + FILE_NAME
end if
End If
Return
Exit Sub
SaveBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End Sub

Public Sub Compile()
On Error Goto OP:
If MDIParent1.HelpToolStripButton.Enabled = True then
Call Save()
If MDIParent1.TextBox1.Tag <> "" then
MDIParent1.Status.Text = "Compiling"
Dim psList() As Process
psList = Process.GetProcesses()
For Each p As Process In psList
If (p.ProcessName = "a") Then
p.Kill
End If
Next p
Call Clean()
Dim k As String
k = MDIParent1.CompilerArguments.Tag + " " + chr(34) + MDIParent1.TextBox1.Tag + chr(34)
Dim psii As new Process
Dim k5 As String
k5 = ""
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
k5 = "\MinGW64\bin\gcc.exe "
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
k5 = "\MinGW64\bin\g++.exe "
End If
psii.StartInfo.FileName = My.Application.Info.DirectoryPath + k5
psii.StartInfo.Arguments = k
psii.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
psii.Start
psii.WaitForExit
If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a.exe") then
MDIParent1.Status.Text = "Compiled No Errors Found" 
Else
MDIParent1.Status.Text = "Errors Encountered" 
call ErrorReport()
end if
Else
MDIParent1.Status.Text = "Compilation Error"
End If
End If
Return
Exit Sub
OP:
MDIParent1.Status.Text = "Compilation Error"
End Sub

Public Sub CompileRun()
On Error goto OPP 
If MDIParent1.HelpToolStripButton.Enabled = True then
If MDIParent1.TextBox1.Tag <> "" then
If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a.exe") then
MDIParent1.Status.Text = "Running"
Dim k As System.Diagnostics.Process  
k = Process.Start(my.Application.Info.DirectoryPath + "\a.exe")
k.WaitForExit
If my.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a1.exe") then
My.Computer.FileSystem.DeleteFile(my.Application.Info.DirectoryPath + "\a1.exe")
End If
My.Computer.FileSystem.RenameFile(my.Application.Info.DirectoryPath + "\a.exe", "a1.exe")
MDIParent1.Status.Text = "Ready"
Else
MDIParent1.Status.Text = "Errors Encountered" 
end if 
End If
End IF
Return
Exit Sub
OPP:
MDIParent1.Status.Text = "Runtime Error"
End Sub

Public Sub CompileRun2()
On Error goto OPP1 
If MDIParent1.HelpToolStripButton.Enabled = True then
If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a1.exe") then
MDIParent1.Status.Text = "Running"
Dim k As System.Diagnostics.Process  
k = Process.Start(my.Application.Info.DirectoryPath + "\a1.exe")
k.WaitForExit
MDIParent1.Status.Text = "Ready"
Else
MDIParent1.Status.Text = "Errors Encountered" 
end if 
End If
Return
Exit Sub
OPP1:
MDIParent1.Status.Text = "Runtime Error"
End Sub

Public Sub CompileRunParameter(para As string)
On Error goto OPP 
If MDIParent1.HelpToolStripButton.Enabled = True then
If MDIParent1.TextBox1.Tag <> "" then
If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a.exe") then
MDIParent1.Status.Text = "Running"
Dim k As System.Diagnostics.Process  
k = Process.Start(my.Application.Info.DirectoryPath + "\a.exe " + para)
k.WaitForExit
If my.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a1.exe") then
My.Computer.FileSystem.DeleteFile(my.Application.Info.DirectoryPath + "\a1.exe")
End If
My.Computer.FileSystem.RenameFile(my.Application.Info.DirectoryPath + "\a.exe", "a1.exe")
MDIParent1.Status.Text = "Ready"
Else
MDIParent1.Status.Text = "Errors Encountered" 
end if 
End If
End IF
Return
Exit Sub
OPP:
MDIParent1.Status.Text = "Runtime Error"
End Sub


Public Sub Open()
On Error Goto OpenBB
Dim k As system.Windows.Forms.DialogResult
Dim s() As String
k = MDIParent1.OpenFileDialog1.ShowDialog   
if k <> Windows.Forms.DialogResult.Cancel then
Dim FileReader As String
FileReader = My.Computer.FileSystem.ReadAllText(MDIParent1.OpenFileDialog1.FileName)
MDIParent1.Status.Text = "Reading"
Form1.TextBox1.Text = FileReader
MDIParent1.TextBox1.Tag = MDIParent1.OpenFileDialog1.FileName
MDIParent1.Text = "GCC++ " + MDIParent1.OpenFileDialog1.FileName
Dim fi As New IO.FileInfo(MDIParent1.OpenFileDialog1.FileName)
Dim extn As String = fi.Extension
s = extn.Split(".")
MDIParent1.SaveFileDialog1.DefaultExt = s(1)
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
MDIParent1.SaveFileDialog1.filter  = "C Program files (*.c)|*.c"
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
MDIParent1.SaveFileDialog1.filter  = "C++ Program files (*.cpp)|*.cpp"
End If
Call Enabler()
HighlightWords(0)
HighlightIntend
countredo = 0
Redocount = 0
MDIParent1.Status.Text = "Opened"


MDIParent1.Status.Text = "Loading Designer"
For Each k33 As control In Form6.Panel2.Controls
k33.Hide
Next
Form6.Show
If My.Computer.FileSystem.FileExists(MDIParent1.OpenFileDialog1.FileName + ".design") then
Dim Files1 As New System.IO.StreamReader( MDIParent1.OpenFileDialog1.FileName + ".design" )
Dim i As Integer
Dim ends as Integer
Dim k44 As New Button
ends = Val(Files1.ReadLine())
For i = 1 to ends
k44.Name = Files1.ReadLine()
k44.Text = Files1.ReadLine()
k44.Tag = Files1.ReadLine()
k44.left = val(Files1.ReadLine())
k44.top = val(Files1.ReadLine())
k44.visible = Files1.ReadLine()
Form6.AddButton(k44.Name, k44.Text, k44.Tag, k44.Left, k44.Top, k44.Visible)
Next
Files1.Close()
Else
Form6.AddButton("main", "main()", "main()", 10, 35, "True")
End If
MDIParent1.Status.Text = "Designer Loaded"

End if
Return
Exit Sub
OpenBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End Sub

Public Sub Enabler()
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
call LoadSettings2("header.txt")
Else
call LoadSettings2("headercpp.txt")
End If
MDIParent1.HelpToolStripButton.Enabled = True
MDIParent1.SaveToolStripMenuItem.Enabled = True
MDIParent1.SaveToolStripButton.Enabled = True
MDIParent1.PrintToolStripButton.Enabled = True
MDIParent1.PrintPreviewToolStripButton.Enabled = True
MDIParent1.EditToolStripMenuItem.Enabled = True
MDIParent1.ToolsToolStripMenuItem.Enabled = True
MDIParent1.ViewToolStripMenuItem.Enabled = True
MDIParent1.BuildToolStripMenuItem.Enabled = True
MDIParent1.PrintToolStripMenuItem.Enabled = True
MDIParent1.PrintPreviewToolStripMenuItem.Enabled = True
MDIParent1.ToolStripMenuItem1.Enabled = True
MDIParent1.ToolStripButton1.Enabled = True
MDIParent1.ToolStripButton2.enabled = True
Form1.MdiParent = MDIParent1
Form6.Show()
Form1.Show()
LoadForm1
countredo = 0
Redocount = 0
Form1.Hide
MDIParent1.Panel1.Visible = True
Return
End Sub

Public Sub LoadSettings2(p As String)
On Error Goto LoadSettingsBB
Dim k As String = ""
If My.Computer.FileSystem.FileExists(p)  then
MDIParent1.ListBox2.Items.Clear
Dim Files As New System.IO.StreamReader(p)
While k <> "-----"
k = Files.ReadLine()
If(k <> "-----") then
MDIParent1.ListBox2.Items.Add(k)
End If
End While
Files.Close
End If


Dim k1 As String = ""
If My.Computer.FileSystem.FileExists("highlight.txt")  then
Form1.RegexMatch.Text = ""
Dim Files As New System.IO.StreamReader("highlight.txt")
While k1 <> "-----"
k1 = Files.ReadLine()
If(k1 <> "-----") then
Form1.RegexMatch.Text = Form1.RegexMatch.Text + k1 + "|"
End If
End While
Files.Close
Form1.RegexMatch.Text = Form1.RegexMatch.Text + "(['" + chr(34) + "])(.(?!\1))*.?\1"
End If

Return
Exit Sub
LoadSettingsBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End Sub

Public Sub LoadToolBox()
On Error Goto LoadSettingsBB
Dim Files7 As New System.IO.StreamReader( ".\Toolbox\7" )
MDIparent1.Button7.Tag = Files7.ReadToEnd()
Files7.Close()
Dim Files17 As New System.IO.StreamReader( ".\Toolbox\17" )
MDIParent1.Button17.Text = Files17.ReadLine()
MDIParent1.Button17.Tag = Files17.ReadToEnd()
Files17.Close()
Dim Files18 As New System.IO.StreamReader( ".\Toolbox\18" )
MDIParent1.Button18.Text = Files18.ReadLine()
MDIParent1.Button18.Tag = Files18.ReadToEnd()
Files18.Close()
Dim Files19 As New System.IO.StreamReader( ".\Toolbox\19" )
MDIParent1.Button19.Text = Files19.ReadLine()
MDIParent1.Button19.Tag = Files19.ReadToEnd()
Files19.Close()
Dim Files20 As New System.IO.StreamReader( ".\Toolbox\20" )
MDIParent1.Button20.Text = Files20.ReadLine()
MDIParent1.Button20.Tag = Files20.ReadToEnd()
Files20.Close()
Dim Files21 As New System.IO.StreamReader( ".\Toolbox\21" )
MDIParent1.Button21.Text = Files21.ReadLine()
MDIParent1.Button21.Tag = Files21.ReadToEnd()
Files21.Close()
Dim Files4 As New System.IO.StreamReader( ".\Toolbox\4" )
MDIParent1.Button4.Text = Files4.ReadLine()
MDIParent1.Button4.Tag = Files4.ReadToEnd()
Files4.Close()
Dim Files1 As New System.IO.StreamReader( ".\Toolbox\1" )
MDIParent1.Button100.Text = Files1.ReadLine()
MDIParent1.Button100.Tag = Files1.ReadToEnd()
Files1.Close()
Dim Files11 As New System.IO.StreamReader( ".\Toolbox\15" )
MDIParent1.Button15.Text = Files11.ReadLine()
MDIParent1.Button15.Tag = Files11.ReadToEnd()
Files11.Close()
Return
Exit Sub
LoadSettingsBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End Sub

Public Sub LoadSettings()
On Error Goto LoadSettingsBB
Dim K As New FontStyle
Dim k1 As String
Dim k2 As Integer
If My.Computer.FileSystem.DirectoryExists("Toolbox")
LoadToolBox()
End If
If My.Computer.FileSystem.FileExists("Settings.bak")  then
Dim Files As New System.IO.StreamReader("Settings.bak")
Form1.TextBox1.ScrollBars = Files.ReadLine()
Form1.TextBox1.BackColor = System.Drawing.ColorTranslator.FromHtml(Files.ReadLine())
Form1.TextBox1.ForeColor = System.Drawing.ColorTranslator.FromHtml(Files.ReadLine())
Form1.SimpleListView.ForeColor = System.Drawing.ColorTranslator.FromHtml(Files.ReadLine())
Form1.GraphicalListView.ForeColor = Form1.SimpleListView.ForeColor
Call LoadForm1
MDIParent1.Button1.Tag = Files.ReadLine()
MDIParent1.WindowState = Files.ReadLine()
If MDIParent1.WindowState = FormWindowState.Normal then
MDIParent1.top = Files.ReadLine()
MDIParent1.left = Files.ReadLine()
MDIParent1.height = Files.ReadLine()
MDIParent1.width = Files.ReadLine()
End If
MDIparent1.HelpToolStripButton.tag = Files.ReadLine()
MDIparent1.ListBox2.Tag = Files.ReadLine()


Form1.WindowState = Files.ReadLine()
If Form1.WindowState = FormWindowState.Normal then
MDIParent1.Label1.Top = Files.ReadLine()
MDIParent1.Label1.Left = Files.ReadLine()
Form1.height = Files.ReadLine()
Form1.width = Files.ReadLine()
End If

Form6.WindowState = Files.ReadLine()
If Form6.WindowState = FormWindowState.Normal then
MDIParent1.Label2.Top = Files.ReadLine()
MDIParent1.Label2.Left = Files.ReadLine()
Form6.height = Files.ReadLine()
Form6.width = Files.ReadLine()
End If

Form1.Top = MDIParent1.Label1.Top
Form1.left = MDIParent1.Label1.Left
Form6.Top = MDIParent1.Label2.Top
Form6.left = MDIParent1.Label2.left


MDIParent1.Panel1.Width = Files.ReadLine()
MDIParent1.ToolStripMenuItem23.Tag  = Files.ReadLine()
MDIParent1.UseSuggestionFromCodeToolStripMenuItem.Tag = Files.ReadLine()
k1 = Files.ReadLine()
k2 = Val(Files.ReadLine())
K = 0
If Files.ReadLine() = "True" then
K = FontStyle.Bold
End If
Form1.TextBox1.Font = New Font (k1, k2, k)
k1 = Files.ReadLine()
k2 = Val(Files.ReadLine())
K = 0
If Files.ReadLine() = "True" then
K = FontStyle.Bold
End If
Form1.SimpleListView.Font = New Font (k1, k2, k)
k1 = Files.ReadLine()
k2 = Val(Files.ReadLine())
K = 0
If Files.ReadLine() = "True" then
K = FontStyle.Bold
End If
Form4.TextBox1.Font = New Font (k1, k2, k)
MDIParent1.CompilerArguments.Tag = Files.ReadLine()
MDIParent1.ToolStripMenuItem29.Tag = Files.ReadLine()
Files.Close
MDIParent1.Status.Text = "Settings Loaded"
Else
MDIParent1.Status.Text = "Settings backup not found"
End If
Return
Exit Sub
LoadSettingsBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End Sub

Public Sub LoadForm1
Form1.SimpleListView.BackColor = Form1.TextBox1.BackColor
Form1.MainPanel1.BackColor = Form1.TextBox1.BackColor
Form1.SampleUnfocus.BackColor = Form1.TextBox1.BackColor
Form4.TextBox1.BackColor = Form1.TextBox1.BackColor
Form1.SampleUnfocus.ForeColor = Form1.TextBox1.ForeColor
Form4.TextBox1.ForeColor = Form1.TextBox1.ForeColor
If val(MDIparent1.HelpToolStripButton.tag) = 1 then
Call ShowBuildBox()
Else
Call HideBuildBox()
End If
End Sub

Public Sub SaveSettings()
On Error Goto SaveSettingsBB
Form1.Show
Dim Files As New System.IO.StreamWriter( "Settings.bak" )
Files.WriteLine(Form1.TextBox1.ScrollBars)
Files.WriteLine(System.Drawing.ColorTranslator.ToHtml(Form1.TextBox1.BackColor))
Files.WriteLine(System.Drawing.ColorTranslator.ToHtml(Form1.TextBox1.ForeColor))
Files.WriteLine(System.Drawing.ColorTranslator.ToHtml(Form1.SimpleListView.ForeColor))
Files.WriteLine(MDIParent1.Button1.Tag)
Files.WriteLine(MDIParent1.WindowState)
If MDIParent1.WindowState = FormWindowState.Normal then
Files.WriteLine(MDIParent1.top)
Files.WriteLine(MDIParent1.left)
Files.WriteLine(MDIParent1.height)
Files.WriteLine(MDIParent1.width)
End If
Files.WriteLine(MDIparent1.HelpToolStripButton.tag)
Files.WriteLine(MDIparent1.ListBox2.Tag)

Files.WriteLine(Form1.WindowState)
If Form1.WindowState = FormWindowState.Normal then
Files.WriteLine(Form1.top)
Files.WriteLine(Form1.left)
Files.WriteLine(Form1.height)
Files.WriteLine(Form1.width)
MDIParent1.Label1.Top = Form1.Top
MDIParent1.Label1.Left = Form1.Left
End If

Files.WriteLine(Form6.WindowState)
If Form6.WindowState = FormWindowState.Normal then
Files.WriteLine(Form6.top)
Files.WriteLine(Form6.left)
Files.WriteLine(Form6.height)
Files.WriteLine(Form6.width)
MDIParent1.Label2.Top = Form6.Top
MDIParent1.Label2.Left = Form6.left
End If

Files.WriteLine(MDIParent1.Panel1.Width)
Files.WriteLine(MDIParent1.ToolStripMenuItem23.Tag)
Files.WriteLine(MDIParent1.UseSuggestionFromCodeToolStripMenuItem.Tag)
Files.WriteLine(Form1.TextBox1.Font.Name)
Files.WriteLine(Form1.TextBox1.Font.Size)
Files.WriteLine(Form1.TextBox1.Font.Bold)
Files.WriteLine(Form1.SimpleListView.Font.Name)
Files.WriteLine(Form1.SimpleListView.Font.Size)
Files.WriteLine(Form1.SimpleListView.Font.Bold)
Files.WriteLine(Form4.textbox1.Font.Name)
Files.WriteLine(Form4.textbox1.Font.Size)
Files.WriteLine(Form4.textbox1.Font.Bold)
Files.WriteLine(MDIParent1.CompilerArguments.Tag)
Files.WriteLine(MDIParent1.ToolStripMenuItem29.Tag)
Files.Close()
SaveToolBox()
MDIParent1.Status.Text = "Settings Saved"
Return
Exit Sub
SaveSettingsBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End sub

Public Sub SaveToolBox()
On Error Goto SaveSettingsBB
If My.Computer.FileSystem.DirectoryExists("Toolbox") = False then
My.Computer.FileSystem.CreateDirectory("Toolbox")
End If
Dim Files7 As New System.IO.StreamWriter( ".\Toolbox\7" )
Files7.Write(MDIparent1.Button7.Tag)
Files7.Close()
Dim Files17 As New System.IO.StreamWriter( ".\Toolbox\17" )
Files17.WriteLine(MDIParent1.Button17.Text)
Files17.Write(MDIParent1.Button17.Tag)
Files17.Close()
Dim Files18 As New System.IO.StreamWriter( ".\Toolbox\18" )
Files18.WriteLine(MDIParent1.Button18.Text)
Files18.Write(MDIParent1.Button18.Tag)
Files18.Close()
Dim Files19 As New System.IO.StreamWriter( ".\Toolbox\19" )
Files19.WriteLine(MDIParent1.Button19.Text)
Files19.Write(MDIParent1.Button19.Tag)
Files19.Close()
Dim Files20 As New System.IO.StreamWriter( ".\Toolbox\20" )
Files20.WriteLine(MDIParent1.Button20.Text)
Files20.Write(MDIParent1.Button20.Tag)
Files20.Close()
Dim Files21 As New System.IO.StreamWriter( ".\Toolbox\21" )
Files21.WriteLine(MDIParent1.Button21.Text)
Files21.Write(MDIParent1.Button21.Tag)
Files21.Close()
Dim Files4 As New System.IO.StreamWriter( ".\Toolbox\4" )
Files4.WriteLine(MDIParent1.Button4.Text)
Files4.Write(MDIParent1.Button4.Tag)
Files4.Close()
Dim Files1 As New System.IO.StreamWriter( ".\Toolbox\1" )
Files1.WriteLine(MDIParent1.Button100.Text)
Files1.Write(MDIParent1.Button100.Tag)
Files1.Close()
Dim Files11 As New System.IO.StreamWriter( ".\Toolbox\15" )
Files11.WriteLine(MDIParent1.Button15.Text)
Files11.Write(MDIParent1.Button15.Tag)
Files11.Close()
Return
Exit Sub
SaveSettingsBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")
End Sub


Public Sub DeleteSettings()
On Error Goto SaveSettingsBB
If My.Computer.FileSystem.FileExists("Settings.bak")  then
My.Computer.FileSystem.DeleteFile("Settings.bak",FileIO.UIOption.OnlyErrorDialogs,FileIO.RecycleOption.DeletePermanently) 
End if
If My.Computer.FileSystem.DirectoryExists("Toolbox")
My.Computer.FileSystem.DeleteDirectory("Toolbox",FileIO.DeleteDirectoryOption.DeleteAllContents)
End if
MDIParent1.Status.Text = "Settings Removed"
Return
Exit Sub
SaveSettingsBB:
MsgBox("File Error Occured",MsgBoxStyle.Critical,"GCC ++")

End Sub

Public Sub Search()
If MDIParent1.HelpToolStripButton.Enabled = True then
Form1.Show
Dim k As Integer
Dim s As String
s = Form1.TextBox1.Text.Substring(Val(Form1.textbox3.tag), Form1.TextBox1.Text.Length - Val(Form1.textbox3.tag))
k = s.IndexOf(Form1.textbox3.text)
If Form1.textbox3.Text <> "" and k <> -1 then
MDIParent1.Status.Text = "Search Found"
Form1.TextBox1.Focus
Form1.TextBox1.Select(k + Val(Form1.textbox3.tag), Form1.TextBox3.Text.Length)
Form1.TextBox3.Tag = k + Val(Form1.textbox3.tag)+ Form1.TextBox3.Text.length
Else
MDIParent1.Status.Text = "No Occurance Found"
End If
End If
Return
End Sub

Public Sub ReplaceAll()
If MDIParent1.HelpToolStripButton.Enabled = True then
Form1.Show
If Form1.TextBox3.Text <> "" and Form1.TextBox2.Text <> "" then
Form1.TextBox1.text = Form1.TextBox1.Text.Replace(Form1.TextBox3.Text,Form1.TextBox2.Text)
MDIParent1.Status.Text = "Replaced All"
End If
End If
Return
End Sub

Public Sub Clean()
If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a.exe")  then
My.Computer.FileSystem.DeleteFile(my.Application.Info.DirectoryPath + "\a.exe")
End if

If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a1.exe")  then
My.Computer.FileSystem.DeleteFile(my.Application.Info.DirectoryPath + "\a1.exe")
End if

Return
End Sub

Public Sub InsertLine()
If MDIParent1.HelpToolStripButton.Enabled = True then
Paste(MDIParent1.Button7.Tag + vbnewline)
End If
Return
End Sub

Public Sub AutoInsertLine()
If MDIParent1.HelpToolStripButton.Enabled = True then
Dim k As Integer 
k = form1.TextBox1.SelectionStart
If form1.TextBox1.Text.Substring(k-1, 1) = "{" or form1.TextBox1.Text.Substring(k-1, 1) = "}" then
Paste(vbnewline +  MDIParent1.Button7.Tag + vbnewline + vbNewLine)
End if
End If
Return
End Sub

Public Sub HideBuildBox()
If MDIParent1.HelpToolStripButton.Enabled = True then
Form1.Panel0.Visible = False
End If
Return
End Sub

Public Sub ShowBuildBox()
If MDIParent1.HelpToolStripButton.Enabled = True then
Form1.Panel0.Visible = True
End If
Return
End Sub

Public Sub MakeEXE(Filename As String)
If MDIParent1.HelpToolStripButton.Enabled = True then
Call Compile()
If My.Computer.FileSystem.FileExists(my.Application.Info.DirectoryPath + "\a.exe") then
MDIParent1.Status.Text = "Building EXE File"
My.Computer.FileSystem.CopyFile(my.Application.Info.DirectoryPath + "\a.exe", Filename, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
Threading.Thread.Sleep(2000)
My.Computer.FileSystem.DeleteFile(my.Application.Info.DirectoryPath + "\a.exe")
MDIParent1.Status.Text = "Build Sucessful"
Else
MDIParent1.Status.Text = "Build Unsucessful"
End If
End If
Return
End Sub

Public Sub ErrorReport()
On Error Resume Next
If MDIParent1.HelpToolStripButton.Enabled = True then
MDIParent1.Status.Text = "Generating Error Report"
Dim k As String
k = MDIParent1.CompilerArguments.Tag + " " + chr(34) + MDIParent1.TextBox1.Tag + chr(34)

Dim k5 As String
k5 = ""
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
k5 = "\MinGW64\bin\gcc.exe "
ElseIf MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
k5 = "\MinGW64\bin\g++.exe "
End If

Dim psi As new process
psi.StartInfo.FileName = My.Application.Info.DirectoryPath + k5
psi.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
psi.StartInfo.Arguments = k
psi.StartInfo.CreateNoWindow = True
psi.StartInfo.UseShellExecute = false
psi.StartInfo.RedirectStandardError = True
psi.Start()
If My.Computer.FileSystem.FileExists (my.Application.Info.DirectoryPath +"\EventHandler.exe") then
Process.Start(my.Application.Info.DirectoryPath +"\EventHandler.exe")
End If
psi.WaitForExit()
Dim kk As String
Dim kk1() As string
BB:
kk = psi.StandardError.ReadLine
kk1 = kk.Split(":")
MDIParent1.Status.Text = "Error Report Generated"
MessageBox.Show(kk.Substring(kk.IndexOf(":", 2)+1), "Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation)
If val(kk1(2)) > 0 and val(kk1(3)) > 0 then
HighlightLine2(kk1(2)-1, kk1(3)-1)
Else
GoTo BB:
End if
End If
Return
End Sub

Public Sub HighlightLine(x As integer)
On Error Resume Next
If MDIParent1.HelpToolStripButton.Enabled = True then
Form1.MdiParent = MDIParent1
Form1.Show()
Form1.Focus
Form1.TextBox1.Focus()
Dim k = Form1.TextBox1.GetFirstCharIndexFromLine(x)
Form1.TextBox1.SelectionStart = k
Dim currentLine = form1.TextBox1.Lines(form1.TextBox1.GetLineFromCharIndex(k))
Form1.TextBox1.SelectionLength = currentLine.Length
Form1.TextBox1.ScrollToCaret()
End If
Return
End sub

Public Sub HighlightLine2(x As integer, y As Integer)
On Error Resume Next
If MDIParent1.HelpToolStripButton.Enabled = True then
Form1.MdiParent = MDIParent1
Form1.Show()
Form1.Focus
Form1.TextBox1.Focus()
Dim k = Form1.TextBox1.GetFirstCharIndexFromLine(x)
Form1.TextBox1.SelectionStart = k+y
Form1.TextBox1.SelectionLength = 1
Form1.TextBox1.ScrollToCaret()
End If
Return
End sub

Public Sub Paste(ABC As String)
If(form1.Visible = True) then
Dim k As String
k = Clipboard.GetText()
Clipboard.SetText(ABC)
Form1.TextBox1.Paste
If k <> "" then
Clipboard.SetText(k)
Else
Clipboard.Clear
End If
End If
Return
End Sub

Public Sub AutoCorrect(e As System.Windows.Forms.KeyEventArgs)
On Error Goto OP
Dim startpoint As Integer
Dim endpoint As Integer
Dim startpoint1 As Integer
Dim EndPoint1 As Integer
Dim SearchText As String
Dim c As Integer
Dim k As String
Dim k1 As String

'--------------------------------------------------------------------

If Form1.SimpleListView.Items.Count > 0 and Form1.SimpleListView.Visible = True then

If e.KeyCode = keys.Down and Form1.SimpleListView.Visible = True then
e.SuppressKeyPress = True
If Form1.SimpleListView.SelectedIndex < (Form1.SimpleListView.Items.Count - 1) then
Form1.SimpleListView.SetSelected(Form1.SimpleListView.SelectedIndex + 1, True)
Else
Form1.SimpleListView.ClearSelected
End If
Exit Sub
End If

If e.KeyCode = keys.Up and Form1.SimpleListView.Visible = True and Form1.SimpleListView.Items.Count>0 then
e.SuppressKeyPress = True
If Form1.SimpleListView.SelectedIndex > 0 then
Form1.SimpleListView.SetSelected(Form1.SimpleListView.SelectedIndex - 1, True)
Else
Form1.SimpleListView.ClearSelected
End If
Exit Sub
End If

If e.KeyCode = keys.Right and Form1.SimpleListView.Visible = True or e.KeyCode = keys.Escape and Form1.SimpleListView.Visible = True then
HideAutoCorrectBox
Exit Sub
End If

End If

'--------------------------------------------------------------------


If Form1.TextBox1.SelectionStart > 0 and Form1.SimpleListView.SelectedIndex > -1 and Form1.SimpleListView.Items.Count > 0 then
If e.KeyCode = 32 or e.KeyCode = 13 or  e.KeyCode = 43 or e.KeyCode = keys.ShiftKey  or e.KeyCode.ToString = "Add" or e.KeyCode.ToString = "Subtract" or e.KeyCode.ToString = "Multiply" or e.KeyCode.ToString = "Devide" or e.KeyCode.ToString = "Oemplus" or e.KeyCode.ToString = "OemMinus" or e.KeyCode.ToString = "Shiftkey" or e.KeyCode = keys.Shift or e.KeyCode.ToString = "Oem1" or e.KeyCode.ToString = "OemQuestion" or e.KeyCode.ToString = "Oem6" or e.KeyCode.ToString = "OemOpenBrackets" or e.KeyCode.ToString = "OemPeriod" or e.KeyCode.ToString = "Decimal" or e.KeyData.ToString = "Oemcomma" then
If e.KeyCode = 32 or e.KeyCode = 13 or e.Shift then
e.SuppressKeyPress = True
End If
startpoint = val(Form1.SimpleListView.Tag) - 1
endpoint  = val(Form1.SimpleListView.Tag)
k = Form1.TextBox1.Text.Substring(startpoint,1)
While Asc(k) >= 65 and Asc(k)<=90 and startpoint>0 or Asc(k) >= 97 and Asc(k)<=122 and startpoint>0
startpoint = startpoint - 1
k = Form1.TextBox1.Text.Substring(startpoint,1)
End While
Form1.TextBox1.Focus()
If startpoint=0 then
Form1.TextBox1.Select(startpoint, endpoint - startpoint)
Else
Form1.TextBox1.Select(startpoint+1, endpoint - startpoint - 1)
End If
Paste(Form1.SimpleListView.SelectedItem.ToString)
HideAutoCorrectBox
Exit Sub
End If

End If

'--------------------------------------------------------------------

If e.KeyCode > = 65 and e.KeyCode < = 90 and val(Form1.SimpleListView.Tag) > 0 then
MDIParent1.Status.Text = "Loading Suggestions"
startpoint1 = val(Form1.SimpleListView.Tag) - 1
endpoint1  = val(Form1.SimpleListView.Tag)
k1 = Form1.TextBox1.Text.Substring(startpoint1,1)

'{
    While Asc(k1) >= 65 and Asc(k1)<=90 and startpoint1>0 or Asc(k1) >= 97 and Asc(k1)<=122  and startpoint1>0 
    startpoint1 = startpoint1 - 1
    k1 = Form1.TextBox1.Text.Substring(startpoint1,1)
    End While
'}
Dim SearchText1 As String
If startpoint1 = 0 then
SearchText = Form1.TextBox1.text.substring(startpoint1, endpoint1 - startpoint1) + Chr(e.KeyCode + 32)
SearchText1 = Form1.TextBox1.text.substring(startpoint1, endpoint1 - startpoint1) + Chr(e.KeyCode)
Else
SearchText = Form1.TextBox1.text.substring(startpoint1 + 1 , endpoint1 - startpoint1 - 1) + Chr(e.KeyCode + 32)
SearchText1 = Form1.TextBox1.text.substring(startpoint1 + 1 , endpoint1 - startpoint1 - 1) + Chr(e.KeyCode)
End If

Form1.SimpleListView.Items.Clear
Form1.GraphicalListView.Items.Clear

If SearchText.Length > 0 and SearchText1.Length>0 then

If MDIParent1.UseSuggestionFromCodeToolStripMenuItem.Tag = 1 then
c = 0
While c < MDIParent1.ListBox22.Items.Count
If MDIparent1.ListBox22.Items.Item(c).ToString.IndexOf(SearchText) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox22.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString)   
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString, 1)
End If   
ElseIf MDIparent1.ListBox22.Items.Item(c).ToString.IndexOf(SearchText1) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox22.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString)
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString, 1) 
End If
ElseIf MDIparent1.ListBox22.Items.Item(c).ToString.IndexOf(SearchText.ToLower) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox22.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString)
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString, 1) 
End If
ElseIf MDIparent1.ListBox22.Items.Item(c).ToString.IndexOf(SearchText.ToUpper) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox22.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString)
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox22.Items.Item(c).ToString, 1) 
End If
End If
c = c + 1
End While
End If

c = 0
While c < MDIParent1.ListBox2.Items.Count
If MDIparent1.ListBox2.Items.Item(c).ToString.IndexOf(SearchText) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox2.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString)
If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ".h" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 2)    
Else If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = "()" or MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ");" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 0) 
Else
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 3) 
End If
End If   
ElseIf MDIparent1.ListBox2.Items.Item(c).ToString.IndexOf(SearchText1) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox2.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString)
If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ".h" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 2)   
Else If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = "()" or MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ");" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 0)   
Else
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 3)   
End If
End If
ElseIf MDIparent1.ListBox2.Items.Item(c).ToString.IndexOf(SearchText.ToLower) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox2.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString)
If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ".h" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 2)   
Else If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = "()" or MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ");" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 0)   
Else
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 3)   
End If
End If
ElseIf MDIparent1.ListBox2.Items.Item(c).ToString.IndexOf(SearchText.ToUpper) = 0 then
If Form1.SimpleListView.Items.Contains(MDIParent1.ListBox2.Items.Item(c).ToString) = False then
Form1.SimpleListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString)
If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ".h" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 2)   
Else If MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = "()" or MDIparent1.ListBox2.Items.Item(c).ToString.Substring(MDIparent1.ListBox2.Items.Item(c).ToString.Length - 2) = ");" then
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 0) 
Else
Form1.GraphicalListView.Items.Add(MDIparent1.ListBox2.Items.Item(c).ToString, 3)   
End If
End If
End If
c = c + 1
End While
End If
If Form1.SimpleListView.Items.Count > 0 then
pospar = 1
Else
pospar = 0
End If
MDIParent1.Status.Text = "Ready"
End If

'--------------------------------------------------------------------

If e.KeyCode = keys.Down or e.KeyCode = keys.Up or e.KeyCode>= 65 and e.KeyCode<=90 then
Else
HideAutoCorrectBox
End If
Return
Exit Sub

OP:
HideAutoCorrectBox
Return
End Sub

Public Sub ShowAutoCorrectBox()
Form1.SimpleListView.Tag = Form1.TextBox1.SelectionStart.ToString

If Form1.SimpleListView.Visible = True then
If Form1.TextBox1.GetPositionFromCharIndex(Form1.TextBox1.SelectionStart).X > (Form1.SimpleListView.Left + Form1.GraphicalListviewPanel2.Width + Form1.simplelistview.Width - 30) or Form1.TextBox1.GetPositionFromCharIndex(Form1.TextBox1.SelectionStart).X < (Form1.SimpleListView.Left) then
Form1.SimpleListView.Left = (Form1.TextBox1.GetPositionFromCharIndex(Form1.TextBox1.SelectionStart-1).X + Form1.TextBox1.Left )
End If
Else
Form1.SimpleListView.Left = (Form1.TextBox1.GetPositionFromCharIndex(Form1.TextBox1.SelectionStart-1).X + Form1.TextBox1.Left )
End If

Form1.SimpleListView.top = (Form1.TextBox1.GetPositionFromCharIndex(Form1.TextBox1.SelectionStart-1).Y + Form1.TextBox1.top + 20)
If (Form1.SimpleListView.Left + Form1.SimpleListView.width + Form1.GraphicalListviewPanel2.width)>(Form1.TextBox1.left + Form1.TextBox1.Width) then
Form1.SimpleListView.Left = Form1.TextBox1.left + Form1.TextBox1.Width - Form1.SimpleListView.Width - Form1.GraphicalListviewPanel2.Width
End If
If (Form1.SimpleListView.Top + Form1.SimpleListView.Height + Form1.GraphicalListviewPanel.Height) > (Form1.TextBox1.top + Form1.TextBox1.Height) then
Form1.SimpleListView.Top = Form1.TextBox1.GetPositionFromCharIndex(Form1.TextBox1.SelectionStart - 1).Y - Form1.SimpleListView.Height - Form1.GraphicalListviewPanel2.Height + (form1.TextBox1.top)
End If
'----------------------------
If pospar = 1 then
Form1.SimpleListView.Visible = True
Else
Form1.SimpleListView.Visible = False
End If
End Sub

Public Sub HideAutoCorrectBox()
pospar = 0
Form1.SimpleListView.Visible = False
Form1.SimpleListView.ClearSelected
Form1.SimpleListView.Items.Clear
Form1.GraphicalListView.Items.Clear
Return
End Sub

Public Function Box(N11 As String, N22 As String, N33 As String)
Dim k As String
BoxForm.TopMost = True
BoxForm.Label1.Text = N11
BoxForm.Text = N22
BoxForm.TextBox1.Text = N33
BoxForm.ShowDialog
k = BoxForm.TextBox1.Text 
BoxForm.TextBox1.Text  = ""
BoxForm.Label1.Text = ""
Return k

End Function


Public Sub AddCustomWords()
        MDIParent1.ListBox22.Items.Clear
        Dim k As String
        Dim k1 As String
        Dim k2 As String
        Dim k3 As String
        k2 = ""

        MDIParent1.ListBox11.Items.Clear     
        k = RemoveComments(Form1.TextBox1.Text)
        For i = 0 to k.Length - 1    
        k1 = k.Chars(i)
        If asc(k1) >=65 and Asc(k1) <=90 or  asc(k1) >=97 and Asc(k1) <=122 or asc(k1) = 95 or  asc(k1) >=48 and Asc(k1) <=57 then
        k2 = k2 + k1
        Else
        If k2 <> "" then
        MDIParent1.ListBox11.Items.Add(k2)
        End If
        k2 = ""
        End If
        If k1=";" or k1="{" or k1="}" or k1="<" or k1=">" or Asc(k1) = 10 then
        If MDIParent1.ListBox11.Items.Count > 0 then
        k3 = MDIParent1.ListBox11.Items(0).ToString
        If k3 = "char" or k3 = "signed" or k3 = "unsigned" or k3 = "short" or k3 = "int" or k3 = "long" or k3 = "float" or k3 = "double" or k3 = "struct" or k3 = "union" or k3 = "enum" or k3 = "void" or k3 = "main" then
        For j = 1 to MDIParent1.ListBox11.Items.Count - 1
        If MDIParent1.ListBox22.Items.Contains(MDIParent1.ListBox11.Items(j)) = False then
        If MDIParent1.ListBox11.Items(j).ToString.Length > 0 and MDIParent1.ListBox11.Items(j).ToString <> "main" and Val(MDIParent1.ListBox11.Items(j).ToString) = 0 then
        If  MDIParent1.ListBox2.Items.Contains(MDIParent1.ListBox11.Items(j)) = false and MDIParent1.ListBox2.Items.Contains(MDIParent1.ListBox11.Items(j).ToString + "()") = false  and MDIParent1.ListBox2.Items.Contains(MDIParent1.ListBox11.Items(j).ToString + "();") = false then
        MDIParent1.ListBox22.Items.Add(MDIParent1.ListBox11.Items(j).ToString)
       End if
        End If
        End If
        Next
        End If
        MDIParent1.ListBox11.Items.Clear
        k2 = ""     
        End If
        End If
        Next
    End Sub
    
Public Function RemoveComments(S25 as String)
        
        Dim k As Integer
        Dim k1 As Integer
        Dim k2 As String
        k = 0
        k1 = 0
        k2 = S25 + chr(10)
        While(k<>-1 and k1<>-1 and k1<=k2.Length)
        k = k2.IndexOf("//")
        k1 = k2.IndexOf(chr(10), k+1)
        If k<>-1 and k1<>-1 then
        k2 = k2.Remove(k, k1-k)
        End If        
        End While 
        
        k = 0
        k1 = 0
        While(k<>-1 and k1<>-1 and k1<=k2.Length)
        k = k2.IndexOf("/*")
        k1 = k2.IndexOf("*/", k+1)
        If k<>-1 and k1<>-1 then
        k2 = k2.Remove(k, k1-k+2)
        End If        
        End While 
        
        Return k2
        
End Function

Public Function RemoveSingleComments(S25 as String)
        
        Dim k As Integer
        Dim k1 As Integer
        Dim k2 As String
        k = 0
        k1 = 0
        k2 = S25 + chr(10)
        While(k<>-1 and k1<>-1 and k1<=k2.Length)
        k = k2.IndexOf("//")
        k1 = k2.IndexOf(chr(10), k+1)
        If k<>-1 and k1<>-1 then
        k2 = k2.Remove(k, k1-k)
        End If        
        End While         
        Return k2
        
End Function

Public Function RemoveMultiComments(S25 as String)
        
        Dim k As Integer
        Dim k1 As Integer
        Dim k2 As String
        k = 0
        k1 = 0
        k2 = S25 + vbNewLine
        While(k<>-1 and k1<>-1 and k1<=k2.Length)
        k = k2.IndexOf("/*")
        k1 = k2.IndexOf("*/", k+1)
        If k<>-1 and k1<>-1 then
        k2 = k2.Remove(k, k1-k+2)
        End If        
        End While 
        Return k2
        
End Function

Public Sub HighlightIntend()
If MDIParent1.ToolStripMenuItem29.Tag = 1 then
Dim i As Integer
Dim c1 As Integer
Dim c2 As Integer
Form1.SampleUnfocus.Focus 
LockWindowUpdate(Form1.TextBox1.Handle.ToInt32)
Form1.TextBox1.SelectAll
Form1.TextBox1.SelectionBackColor = Form1.SampleUnfocus.BackColor
Dim stack As Integer
stack = -1
For i = 0 to Form1.TextBox1.Text.Length - 1
c1 = Form1.TextBox1.Text.IndexOf("{", i)
c2 = Form1.TextBox1.Text.IndexOf("}", i)
If c1 < c2 and c1 <> -1 and c2 <> -1 then
i = c1
Else If c2 < c1 and c2 <> -1 and c1 <> -1 then
i = c2
Else If c2 = -1 and c1 <> -1 then
i = c1
Else If c1 = -1 and c2<> -1 then
i = c2
Else If c1=-1 and c2 = -1 then
Exit For
end If
If  Form1.TextBox1.Text.Substring(i, 1) = "{" then
stack = stack + 1
Form1.TextBox1.Select(i, 1)
Form1.TextBox1.SelectionBackColor = colortranslator.FromHtml(Form1.ColorList.Items(stack mod Form1.ColorList.Items.Count).ToString)
ElseIf Form1.TextBox1.Text.Substring(i, 1) = "}" and stack>=0 then
Form1.TextBox1.Select(i, 1)
Form1.TextBox1.SelectionBackColor = colortranslator.FromHtml(Form1.ColorList.Items(stack mod Form1.ColorList.Items.Count).ToString)
stack = stack - 1
End If
Next
If redoparameter <> "Undo" then
Form1.TextBox1.Select(k101,0)
Form1.TextBox1.SelectionBackColor = Form1.SampleUnfocus.BackColor
Form1.TextBox1.SelectionColor = Form1.SampleUnfocus.ForeColor
Form1.TextBox1.Focus
End If
LockWindowUpdate(0)
End If
End Sub

Public Sub HighlightWords(DoChecks As Integer)
On Error Goto BB:
If MDIParent1.ToolStripMenuItem29.Tag = 1 then
If redoparameter <> "Undo" then
k101 = Form1.TextBox1.SelectionStart
k1101 = Form1.TextBox1.Text 
If DoChecks = 0 then GoTo DD 
If k101>0 then
If char.IsLetterOrDigit(k1101, k101-1) = False then 
DD:
Form1.SampleUnfocus.Focus
Form1.TextBox1.SelectAll 
Form1.TextBox1.SelectionColor = Form1.SampleUnfocus.ForeColor
mc101 = Regex.Matches(k1101, Form1.RegexMatch.Text)
For  Each me.m101 in mc101
If isQuotes(m101.Index) = False then
If IsNotChar(m101.Index, m101.Index + m101.Length) then
Form1.TextBox1.Select(m101.Index, m101.Length)
Form1.TextBox1.SelectionColor = color.DarkBlue
End If
Else
Form1.TextBox1.Select(m101.Index, m101.Length)
Form1.TextBox1.SelectionColor = Form1.TextBox1.ForeColor
End If
Next
end If
End If
Exit Sub
End If
End If
BB:
End Sub

Public Function IsNotChar(start As Integer, ends As Integer)
If start>0 and ends < (k1101.Length) then
If Char.IsLetterOrDigit(k1101.Substring(start-1,1)) or Char.IsLetterOrDigit(k1101.Substring(ends,1)) then
Return False
End If
ElseIf start=0 and ends < (k1101.Length) then
If char.IsLetterOrDigit(k1101.Substring(ends,1)) then
Return False
End If
End If
Return True
End Function

Public Function isQuotes(start As Integer)
On Error Goto BB:
If k1101.Substring(start,1) = Chr(34) or k1101.Substring(start,1) = Chr(39) then
Return True
End If
Return False
BB:
End Function

Public Sub Form1Undo()
redoparameter = "Undo"
Form1.SampleUnfocus.Focus
countredo = countredo - 1
If  countredo < 0 then 
countredo = 999
End If
Redocount = Redocount + 1
Form1.TextBox1.Text  = Undo(countredo)
HighlightIntend()
Form1.TextBox1.Select(UndoIndex(countredo),0)
Form1.TextBox1.SelectionBackColor = Form1.SampleUnfocus.BackColor
Form1.TextBox1.SelectionColor = Form1.SampleUnfocus.ForeColor
Form1.TextBox1.Focus
redoparameter = ""
End Sub

Public Sub Form1Redo()
If Redocount > 0 then
redoparameter = "Undo"
Form1.SampleUnfocus.Focus
countredo = (countredo + 1) mod 1000
Redocount = Redocount - 1
form1.TextBox1.Text  = Undo(countredo)
HighlightIntend()
Form1.TextBox1.Select(UndoIndex(countredo),0)
Form1.TextBox1.SelectionBackColor = Form1.SampleUnfocus.BackColor
Form1.TextBox1.SelectionColor = Form1.SampleUnfocus.ForeColor
Form1.TextBox1.Focus
redoparameter = ""
end If
End Sub

Public Sub Form1SAVEUndo()
If redoparameter<> "Undo" and Form1.TextBox1.Text <> Undo(countredo) then
countredo = (countredo + 1) mod 1000
Redocount = 0
UndoIndex(countredo) = Form1.TextBox1.SelectionStart 
Undo(countredo) = Form1.TextBox1.Text
End If
End Sub

Public Sub ConditionalHighlightIntend()
If MDIParent1.ToolStripMenuItem29.Tag = 1 then
If redoparameter <> "Undo" then
Dim k1 as integer
Dim k2 as Integer
k1 = Form1.TextBox1.TextLength - Len(Form1.TextBox1.Text.Replace("{", ""))
k2 = Form1.TextBox1.TextLength - Len(Form1.TextBox1.Text.Replace("}", ""))
If  Val(Form1.SampleUnfocus.Tag) <> k1 then
HighlightIntend()
Form1.SampleUnfocus.Tag = k1
ElseIf  Val(Form1.Label1.Tag) <> k2 then
HighlightIntend()
Form1.Label1.Tag = k2
Else
Form1.TextBox1.Select(k101,0)
Form1.TextBox1.SelectionBackColor = Form1.SampleUnfocus.BackColor
Form1.TextBox1.SelectionColor = Form1.SampleUnfocus.ForeColor
Form1.TextBox1.Focus
End If
End If
End If
End Sub
End Class

