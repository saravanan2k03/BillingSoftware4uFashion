<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mobiletxt = New System.Windows.Forms.TextBox()
        Me.placetxt = New System.Windows.Forms.TextBox()
        Me.Nametxt = New System.Windows.Forms.TextBox()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mobile No :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Place :"
        '
        'Mobiletxt
        '
        Me.Mobiletxt.Location = New System.Drawing.Point(93, 83)
        Me.Mobiletxt.Name = "Mobiletxt"
        Me.Mobiletxt.Size = New System.Drawing.Size(186, 22)
        Me.Mobiletxt.TabIndex = 3
        '
        'placetxt
        '
        Me.placetxt.Location = New System.Drawing.Point(93, 119)
        Me.placetxt.Name = "placetxt"
        Me.placetxt.Size = New System.Drawing.Size(186, 22)
        Me.placetxt.TabIndex = 4
        '
        'Nametxt
        '
        Me.Nametxt.Location = New System.Drawing.Point(93, 46)
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(186, 22)
        Me.Nametxt.TabIndex = 0
        '
        'addbtn
        '
        Me.addbtn.Location = New System.Drawing.Point(93, 178)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(75, 38)
        Me.addbtn.TabIndex = 6
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = True
        '
        'clearbtn
        '
        Me.clearbtn.Location = New System.Drawing.Point(193, 178)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(75, 38)
        Me.clearbtn.TabIndex = 7
        Me.clearbtn.Text = "CLEAR"
        Me.clearbtn.UseVisualStyleBackColor = True
        '
        'AddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 228)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.Nametxt)
        Me.Controls.Add(Me.placetxt)
        Me.Controls.Add(Me.Mobiletxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Mobiletxt As TextBox
    Friend WithEvents placetxt As TextBox
    Friend WithEvents Nametxt As TextBox
    Friend WithEvents addbtn As Button
    Friend WithEvents clearbtn As Button
End Class
