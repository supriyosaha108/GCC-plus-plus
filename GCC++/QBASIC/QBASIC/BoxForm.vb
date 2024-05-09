Public Class BoxForm

Private Sub Button2_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" then
        Me.Hide
        End If
End Sub

Private Sub Button1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Button1.Click
TextBox1.Text = ""
        Me.Hide
End Sub
End Class