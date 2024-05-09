Public Class NewForm
Dim QBASIC As new Form2

Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
On Error GoTo BB:
If ListView1.FocusedItem.index = 0 then
MDIParent1.SaveFileDialog1.DefaultExt = "c"
MDIParent1.SaveFileDialog1.filter  = "C Program files (*.c)|*.c"
Else If ListView1.FocusedItem.index = 1 then
MDIParent1.SaveFileDialog1.DefaultExt = "cpp"
MDIParent1.SaveFileDialog1.filter  = "C++ Program files (*.cpp)|*.cpp"
End If
MDIParent1.TextBox1.Text = ""
If MDIParent1.SaveFileDialog1.DefaultExt = "c" then
Form1.TextBox1.Text = "#include<stdio.h>" + vbnewline + "#include<conio.h>" + vbnewline + "#include<stdlib.h>" + MDIParent1.Button9.Tag 
Else If MDIParent1.SaveFileDialog1.DefaultExt = "cpp" then
Form1.TextBox1.Text = "#include<iostream>" + vbnewline +"#include<cstdio>" + vbnewline + "#include<conio.h>" + vbnewline + "#include<cstdlib>" + vbnewline + "using namespace std;" + MDIParent1.Button9.Tag 
End If
MDIParent1.TextBox1.Tag = ""
MDIParent1.Status.Text = "Ready"
MDIParent1.Text = "GCC++"
QBASIC.Enabler()
For Each k33 As control In Form6.Panel2.Controls
k33.Hide
Next
Form6.Show
Me.Close()
Return
BB:
End Sub

Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
Me.Close()
End Sub

Private Sub NewForm_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

End Sub
End Class
