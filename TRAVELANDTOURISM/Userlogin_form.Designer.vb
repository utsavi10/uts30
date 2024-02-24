<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Userlogin_form
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
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.reset = New System.Windows.Forms.Button()
        Me.signup = New System.Windows.Forms.LinkLabel()
        Me.back = New System.Windows.Forms.Button()
        Me.login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Myanmar Text", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Login"
        '
        'username
        '
        Me.username.Location = New System.Drawing.Point(272, 150)
        Me.username.Margin = New System.Windows.Forms.Padding(4)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(253, 22)
        Me.username.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 150)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User Name : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 198)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password : "
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(272, 203)
        Me.password.Margin = New System.Windows.Forms.Padding(4)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(253, 22)
        Me.password.TabIndex = 4
        '
        'reset
        '
        Me.reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(364, 299)
        Me.reset.Margin = New System.Windows.Forms.Padding(4)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(100, 36)
        Me.reset.TabIndex = 5
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'signup
        '
        Me.signup.AutoSize = True
        Me.signup.Location = New System.Drawing.Point(427, 360)
        Me.signup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.signup.Name = "signup"
        Me.signup.Size = New System.Drawing.Size(56, 16)
        Me.signup.TabIndex = 7
        Me.signup.TabStop = True
        Me.signup.Text = "Sign Up"
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(16, 452)
        Me.back.Margin = New System.Windows.Forms.Padding(4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(168, 38)
        Me.back.TabIndex = 8
        Me.back.Text = "Back to Home"
        Me.back.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login.Location = New System.Drawing.Point(227, 299)
        Me.login.Margin = New System.Windows.Forms.Padding(4)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(100, 36)
        Me.login.TabIndex = 9
        Me.login.Text = "Login"
        Me.login.UseVisualStyleBackColor = True
        '
        'Userlogin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 505)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.signup)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Userlogin_form"
        Me.Text = "Userlogin_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents signup As System.Windows.Forms.LinkLabel
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents login As System.Windows.Forms.Button
End Class
