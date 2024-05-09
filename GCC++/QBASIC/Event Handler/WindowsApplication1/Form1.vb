Public Class Form1

Private Sub Form1_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
If My.Computer.FileSystem.FileExists("Timer.bak")  then
Dim Files As New System.IO.StreamReader("Timer.bak")
Timer2.Interval = Files.ReadLine()
Files.Close
End If
Timer2.Enabled = True
End Sub

Private Sub Timer2_Tick( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Timer2.Tick
Dim psList() As Process
psList = Process.GetProcesses()
For Each p As Process In psList
If (p.ProcessName = "cc1") Then
p.Kill
End If
Next p
Timer2.Enabled = False
End
End Sub
End Class
