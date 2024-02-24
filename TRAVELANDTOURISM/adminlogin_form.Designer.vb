<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminlogin_form
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
        Me.log = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.adpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.adname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'log
        '
        Me.log.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.log.Location = New System.Drawing.Point(204, 259)
        Me.log.Margin = New System.Windows.Forms.Padding(4)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(100, 36)
        Me.log.TabIndex = 18
        Me.log.Text = "Login"
        Me.log.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(13, 447)
        Me.back.Margin = New System.Windows.Forms.Padding(4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(168, 38)
        Me.back.TabIndex = 17
        Me.back.Text = "Back to Home"
        Me.back.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(335, 259)
        Me.reset.Margin = New System.Windows.Forms.Padding(4)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(100, 36)
        Me.reset.TabIndex = 15
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'adpass
        '
        Me.adpass.Location = New System.Drawing.Point(204, 180)
        Me.adpass.Margin = New System.Windows.Forms.Padding(4)
        Me.adpass.Name = "adpass"
        Me.adpass.Size = New System.Drawing.Size(253, 20)
        Me.adpass.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Admin Name : "
        '
        'adname
        '
        Me.adname.Location = New System.Drawing.Point(204, 138)
        Me.adname.Margin = New System.Windows.Forms.Padding(4)
        Me.adname.Name = "adname"
        Me.adname.Size = New System.Drawing.Size(253, 20)
        Me.adname.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 56)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Admin Login"
        '
        'adminlogin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 498)
        Me.Controls.Add(Me.log)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.adpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.adname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminlogin_form"
        Me.Text = "adminlogin_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents log As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents adpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents adname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
