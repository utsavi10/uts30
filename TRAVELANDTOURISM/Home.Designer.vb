<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contact = New System.Windows.Forms.LinkLabel()
        Me.aboutus = New System.Windows.Forms.LinkLabel()
        Me.userlogin = New System.Windows.Forms.LinkLabel()
        Me.adminlogin = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-4, 211)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 123)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRAVEL AND TOURISM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " MANAGEMENT " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.PIC1
        Me.PictureBox1.Location = New System.Drawing.Point(426, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(445, 293)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'contact
        '
        Me.contact.AutoSize = True
        Me.contact.Font = New System.Drawing.Font("Dubai", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(744, 21)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(117, 49)
        Me.contact.TabIndex = 4
        Me.contact.TabStop = True
        Me.contact.Text = "Contact"
        '
        'aboutus
        '
        Me.aboutus.AutoSize = True
        Me.aboutus.Font = New System.Drawing.Font("Dubai", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutus.Location = New System.Drawing.Point(616, 21)
        Me.aboutus.Name = "aboutus"
        Me.aboutus.Size = New System.Drawing.Size(135, 49)
        Me.aboutus.TabIndex = 5
        Me.aboutus.TabStop = True
        Me.aboutus.Text = "About Us"
        '
        'userlogin
        '
        Me.userlogin.AutoSize = True
        Me.userlogin.Font = New System.Drawing.Font("Dubai", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlogin.Location = New System.Drawing.Point(475, 21)
        Me.userlogin.Name = "userlogin"
        Me.userlogin.Size = New System.Drawing.Size(150, 49)
        Me.userlogin.TabIndex = 6
        Me.userlogin.TabStop = True
        Me.userlogin.Text = "User Login"
        '
        'adminlogin
        '
        Me.adminlogin.AutoSize = True
        Me.adminlogin.Font = New System.Drawing.Font("Dubai", 21.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminlogin.Location = New System.Drawing.Point(309, 21)
        Me.adminlogin.Name = "adminlogin"
        Me.adminlogin.Size = New System.Drawing.Size(172, 49)
        Me.adminlogin.TabIndex = 7
        Me.adminlogin.TabStop = True
        Me.adminlogin.Text = "Admin Login"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(873, 571)
        Me.Controls.Add(Me.adminlogin)
        Me.Controls.Add(Me.userlogin)
        Me.Controls.Add(Me.aboutus)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "HomePage"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents contact As System.Windows.Forms.LinkLabel
    Friend WithEvents aboutus As System.Windows.Forms.LinkLabel
    Friend WithEvents userlogin As System.Windows.Forms.LinkLabel
    Friend WithEvents adminlogin As System.Windows.Forms.LinkLabel

End Class
