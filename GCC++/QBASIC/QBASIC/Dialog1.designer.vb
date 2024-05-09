<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewForm
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
Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("C Project", "Capture99.PNG")
Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("C++ Project", "Capture99.PNG")
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewForm))
Me.ListView1 = New System.Windows.Forms.ListView
Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
Me.OK_Button = New System.Windows.Forms.Button
Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
Me.Cancel_Button = New System.Windows.Forms.Button
Me.TableLayoutPanel1.SuspendLayout()
Me.SuspendLayout()
'
'ListView1
'
Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
Me.ListView1.LargeImageList = Me.ImageList1
Me.ListView1.Location = New System.Drawing.Point(8, 16)
Me.ListView1.MultiSelect = False
Me.ListView1.Name = "ListView1"
Me.ListView1.Size = New System.Drawing.Size(416, 208)
Me.ListView1.TabIndex = 1
Me.ListView1.UseCompatibleStateImageBehavior = False
'
'ImageList1
'
Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
Me.ImageList1.Images.SetKeyName(0, "Capture99.PNG")
'
'OK_Button
'
Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
Me.OK_Button.Location = New System.Drawing.Point(3, 3)
Me.OK_Button.Name = "OK_Button"
Me.OK_Button.Size = New System.Drawing.Size(67, 23)
Me.OK_Button.TabIndex = 0
Me.OK_Button.Text = "OK"
'
'TableLayoutPanel1
'
Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
Me.TableLayoutPanel1.ColumnCount = 2
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
Me.TableLayoutPanel1.Location = New System.Drawing.Point(280, 231)
Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
Me.TableLayoutPanel1.RowCount = 1
Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
Me.TableLayoutPanel1.TabIndex = 0
'
'Cancel_Button
'
Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
Me.Cancel_Button.Name = "Cancel_Button"
Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
Me.Cancel_Button.TabIndex = 1
Me.Cancel_Button.Text = "Cancel"
'
'NewForm
'
Me.AcceptButton = Me.OK_Button
Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
Me.CancelButton = Me.Cancel_Button
Me.ClientSize = New System.Drawing.Size(435, 270)
Me.Controls.Add(Me.ListView1)
Me.Controls.Add(Me.TableLayoutPanel1)
Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
Me.MaximizeBox = False
Me.MinimizeBox = False
Me.Name = "NewForm"
Me.ShowInTaskbar = False
Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
Me.Text = "New"
Me.TableLayoutPanel1.ResumeLayout(False)
Me.ResumeLayout(False)

End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button

End Class
