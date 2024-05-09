<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BoxForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
Me.GroupBox1 = New System.Windows.Forms.GroupBox
Me.Button2 = New System.Windows.Forms.Button
Me.Button1 = New System.Windows.Forms.Button
Me.TextBox1 = New System.Windows.Forms.TextBox
Me.Label1 = New System.Windows.Forms.TextBox
Me.GroupBox1.SuspendLayout()
Me.SuspendLayout()
'
'GroupBox1
'
Me.GroupBox1.Controls.Add(Me.Button2)
Me.GroupBox1.Controls.Add(Me.Button1)
Me.GroupBox1.Controls.Add(Me.TextBox1)
Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
Me.GroupBox1.Name = "GroupBox1"
Me.GroupBox1.Size = New System.Drawing.Size(376, 176)
Me.GroupBox1.TabIndex = 6
Me.GroupBox1.TabStop = False
'
'Button2
'
Me.Button2.Location = New System.Drawing.Point(192, 136)
Me.Button2.Name = "Button2"
Me.Button2.Size = New System.Drawing.Size(176, 32)
Me.Button2.TabIndex = 7
Me.Button2.Text = "OK"
Me.Button2.UseVisualStyleBackColor = True
'
'Button1
'
Me.Button1.Location = New System.Drawing.Point(8, 136)
Me.Button1.Name = "Button1"
Me.Button1.Size = New System.Drawing.Size(168, 32)
Me.Button1.TabIndex = 6
Me.Button1.Text = "Cancel"
Me.Button1.UseVisualStyleBackColor = True
'
'TextBox1
'
Me.TextBox1.AcceptsReturn = True
Me.TextBox1.AcceptsTab = True
Me.TextBox1.Location = New System.Drawing.Point(8, 16)
Me.TextBox1.Multiline = True
Me.TextBox1.Name = "TextBox1"
Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
Me.TextBox1.Size = New System.Drawing.Size(360, 112)
Me.TextBox1.TabIndex = 1
Me.TextBox1.WordWrap = False
'
'Label1
'
Me.Label1.BackColor = System.Drawing.SystemColors.Control
Me.Label1.Enabled = False
Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label1.Location = New System.Drawing.Point(8, 8)
Me.Label1.Multiline = True
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(376, 56)
Me.Label1.TabIndex = 7
'
'BoxForm
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.ClientSize = New System.Drawing.Size(393, 249)
Me.ControlBox = False
Me.Controls.Add(Me.GroupBox1)
Me.Controls.Add(Me.Label1)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
Me.Name = "BoxForm"
Me.ShowIcon = False
Me.ShowInTaskbar = False
Me.Text = "BoxForm"
Me.GroupBox1.ResumeLayout(False)
Me.GroupBox1.PerformLayout()
Me.ResumeLayout(False)
Me.PerformLayout()

End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.TextBox
End Class
