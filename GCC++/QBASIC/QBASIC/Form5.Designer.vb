﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
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
Me.components = New System.ComponentModel.Container
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
Me.Panel1 = New System.Windows.Forms.Panel
Me.Label3 = New System.Windows.Forms.Label
Me.Label2 = New System.Windows.Forms.Label
Me.PictureBox1 = New System.Windows.Forms.PictureBox
Me.Label1 = New System.Windows.Forms.Label
Me.Panel1.SuspendLayout()
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
Me.SuspendLayout()
'
'Timer1
'
Me.Timer1.Enabled = True
Me.Timer1.Interval = 1000
'
'Panel1
'
Me.Panel1.BackColor = System.Drawing.Color.Transparent
Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
Me.Panel1.Controls.Add(Me.Label3)
Me.Panel1.Controls.Add(Me.Label2)
Me.Panel1.Controls.Add(Me.PictureBox1)
Me.Panel1.Controls.Add(Me.Label1)
Me.Panel1.Location = New System.Drawing.Point(1, 1)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(360, 179)
Me.Panel1.TabIndex = 15
Me.Panel1.UseWaitCursor = True
'
'Label3
'
Me.Label3.AutoSize = True
Me.Label3.Location = New System.Drawing.Point(160, 87)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(147, 13)
Me.Label3.TabIndex = 14
Me.Label3.Text = "Developed by Supriyo Saha®"
Me.Label3.UseWaitCursor = True
'
'Label2
'
Me.Label2.AutoSize = True
Me.Label2.Location = New System.Drawing.Point(160, 103)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(75, 13)
Me.Label2.TabIndex = 13
Me.Label2.Text = "Version 1.0.00"
Me.Label2.UseWaitCursor = True
'
'PictureBox1
'
Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
Me.PictureBox1.ErrorImage = Nothing
Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
Me.PictureBox1.InitialImage = Nothing
Me.PictureBox1.Location = New System.Drawing.Point(29, 31)
Me.PictureBox1.Name = "PictureBox1"
Me.PictureBox1.Size = New System.Drawing.Size(116, 112)
Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
Me.PictureBox1.TabIndex = 10
Me.PictureBox1.TabStop = False
Me.PictureBox1.UseWaitCursor = True
'
'Label1
'
Me.Label1.AutoSize = True
Me.Label1.BackColor = System.Drawing.Color.Transparent
Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
Me.Label1.ForeColor = System.Drawing.Color.Black
Me.Label1.Location = New System.Drawing.Point(145, 31)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(192, 55)
Me.Label1.TabIndex = 9
Me.Label1.Text = "GCC++"
Me.Label1.UseWaitCursor = True
'
'SplashScreen
'
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.BackColor = System.Drawing.Color.Black
Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
Me.ClientSize = New System.Drawing.Size(362, 181)
Me.ControlBox = False
Me.Controls.Add(Me.Panel1)
Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
Me.DoubleBuffered = True
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
Me.Name = "SplashScreen"
Me.ShowIcon = False
Me.ShowInTaskbar = False
Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.TopMost = True
Me.UseWaitCursor = True
Me.Panel1.ResumeLayout(False)
Me.Panel1.PerformLayout()
CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
Me.ResumeLayout(False)

End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
