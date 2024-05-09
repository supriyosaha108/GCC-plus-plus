Public Class Form4
Private Sub Form4_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    If e.CloseReason = CloseReason.UserClosing then
        e.Cancel = True
        Me.hide
        End If
End Sub

Private Sub Form4_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParent1
End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        MDIParent1.Panel1.Enabled = False
    End Sub

    Private Sub Form4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        MDIParent1.Panel1.Enabled = False        
    End Sub
End Class
