<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup_form
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
        Me.firstname = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.pword = New System.Windows.Forms.TextBox()
        Me.contno = New System.Windows.Forms.TextBox()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.regis = New System.Windows.Forms.Button()
        Me.resetbtn = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(181, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register"
        '
        'firstname
        '
        Me.firstname.AutoSize = True
        Me.firstname.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(43, 79)
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(122, 36)
        Me.firstname.TabIndex = 1
        Me.firstname.Text = "First Name: "
        '
        'username
        '
        Me.username.AutoSize = True
        Me.username.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username.Location = New System.Drawing.Point(43, 161)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(122, 36)
        Me.username.TabIndex = 2
        Me.username.Text = "User Name: "
        '
        'lastname
        '
        Me.lastname.AutoSize = True
        Me.lastname.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(43, 118)
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(119, 36)
        Me.lastname.TabIndex = 3
        Me.lastname.Text = "Last Name: "
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(54, 207)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(108, 36)
        Me.pass.TabIndex = 4
        Me.pass.Text = "Password: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 36)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contact No.:  "
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(171, 89)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(208, 20)
        Me.fname.TabIndex = 7
        '
        'pword
        '
        Me.pword.Location = New System.Drawing.Point(171, 217)
        Me.pword.Name = "pword"
        Me.pword.Size = New System.Drawing.Size(208, 20)
        Me.pword.TabIndex = 8
        '
        'contno
        '
        Me.contno.Location = New System.Drawing.Point(171, 253)
        Me.contno.Name = "contno"
        Me.contno.Size = New System.Drawing.Size(208, 20)
        Me.contno.TabIndex = 9
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(171, 171)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(208, 20)
        Me.uname.TabIndex = 10
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(170, 128)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(208, 20)
        Me.lname.TabIndex = 11
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(170, 289)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(208, 20)
        Me.email.TabIndex = 12
        '
        'regis
        '
        Me.regis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regis.Location = New System.Drawing.Point(344, 345)
        Me.regis.Name = "regis"
        Me.regis.Size = New System.Drawing.Size(102, 32)
        Me.regis.TabIndex = 13
        Me.regis.Text = "Sign Up "
        Me.regis.UseVisualStyleBackColor = True
        '
        'resetbtn
        '
        Me.resetbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetbtn.Location = New System.Drawing.Point(202, 345)
        Me.resetbtn.Name = "resetbtn"
        Me.resetbtn.Size = New System.Drawing.Size(101, 32)
        Me.resetbtn.TabIndex = 14
        Me.resetbtn.Text = "Reset"
        Me.resetbtn.UseVisualStyleBackColor = True
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(13, 399)
        Me.back.Margin = New System.Windows.Forms.Padding(4)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(149, 28)
        Me.back.TabIndex = 15
        Me.back.Text = "Back to Home"
        Me.back.UseVisualStyleBackColor = True
        '
        'signup_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 440)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.resetbtn)
        Me.Controls.Add(Me.regis)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.contno)
        Me.Controls.Add(Me.pword)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "signup_form"
        Me.Text = "Contact Number: "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents firstname As System.Windows.Forms.Label
    Friend WithEvents username As System.Windows.Forms.Label
    Friend WithEvents lastname As System.Windows.Forms.Label
    Friend WithEvents pass As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents pword As System.Windows.Forms.TextBox
    Friend WithEvents contno As System.Windows.Forms.TextBox
    Friend WithEvents uname As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents regis As System.Windows.Forms.Button
    Friend WithEvents resetbtn As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
End Class
