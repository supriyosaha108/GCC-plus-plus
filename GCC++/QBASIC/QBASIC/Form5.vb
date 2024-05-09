Public Class SplashScreen

Private Sub Timer1_Tick( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide
        MDIParent1.Show
        Timer1.Enabled = False
End Sub
End Class