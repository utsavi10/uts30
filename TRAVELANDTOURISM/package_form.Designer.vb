<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class package_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mybookings = New System.Windows.Forms.Button()
        Me.checkpack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.myprofile = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DashBoard"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 66)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel2.Controls.Add(Me.myprofile)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.mybookings)
        Me.Panel2.Controls.Add(Me.checkpack)
        Me.Panel2.Location = New System.Drawing.Point(2, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(177, 460)
        Me.Panel2.TabIndex = 0
        '
        'mybookings
        '
        Me.mybookings.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.mybookings.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mybookings.Location = New System.Drawing.Point(0, 178)
        Me.mybookings.Name = "mybookings"
        Me.mybookings.Size = New System.Drawing.Size(177, 103)
        Me.mybookings.TabIndex = 2
        Me.mybookings.Text = "My Bookings"
        Me.mybookings.UseVisualStyleBackColor = False
        '
        'checkpack
        '
        Me.checkpack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.checkpack.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkpack.Location = New System.Drawing.Point(0, 78)
        Me.checkpack.Name = "checkpack"
        Me.checkpack.Size = New System.Drawing.Size(177, 116)
        Me.checkpack.TabIndex = 0
        Me.checkpack.Text = "Check Package"
        Me.checkpack.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Marker", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 38)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Page"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, 367)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 119)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "My Bookings"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'myprofile
        '
        Me.myprofile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.myprofile.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myprofile.Location = New System.Drawing.Point(0, 270)
        Me.myprofile.Name = "myprofile"
        Me.myprofile.Size = New System.Drawing.Size(177, 100)
        Me.myprofile.TabIndex = 3
        Me.myprofile.Text = "My Profile"
        Me.myprofile.UseVisualStyleBackColor = False
        '
        'package_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 456)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "package_form"
        Me.Text = "package_form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents mybookings As System.Windows.Forms.Button
    Friend WithEvents checkpack As System.Windows.Forms.Button
    Friend WithEvents myprofile As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
