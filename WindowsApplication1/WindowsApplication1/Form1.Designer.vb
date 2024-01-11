<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.fnametext = New System.Windows.Forms.TextBox()
        Me.lnametxt = New System.Windows.Forms.TextBox()
        Me.gnametxt = New System.Windows.Forms.TextBox()
        Me.addtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.birthdate = New System.Windows.Forms.DateTimePicker()
        Me.resetbt = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.femradio = New System.Windows.Forms.RadioButton()
        Me.maleradio = New System.Windows.Forms.RadioButton()
        Me.otheradio = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.termslink = New System.Windows.Forms.LinkLabel()
        Me.classbox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'fnametext
        '
        Me.fnametext.Location = New System.Drawing.Point(217, 126)
        Me.fnametext.Name = "fnametext"
        Me.fnametext.Size = New System.Drawing.Size(300, 20)
        Me.fnametext.TabIndex = 0
        '
        'lnametxt
        '
        Me.lnametxt.Location = New System.Drawing.Point(217, 165)
        Me.lnametxt.Name = "lnametxt"
        Me.lnametxt.Size = New System.Drawing.Size(300, 20)
        Me.lnametxt.TabIndex = 1
        '
        'gnametxt
        '
        Me.gnametxt.Location = New System.Drawing.Point(217, 211)
        Me.gnametxt.Name = "gnametxt"
        Me.gnametxt.Size = New System.Drawing.Size(300, 20)
        Me.gnametxt.TabIndex = 2
        '
        'addtxt
        '
        Me.addtxt.Location = New System.Drawing.Point(217, 252)
        Me.addtxt.Multiline = True
        Me.addtxt.Name = "addtxt"
        Me.addtxt.Size = New System.Drawing.Size(300, 62)
        Me.addtxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(48, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "STUDENT REGISTRATION FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(93, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "FIRST NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "LAST NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "GUARDIAN NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(106, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ADDRESS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "BIRTHDATE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(109, 359)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "GENDER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(106, 423)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "CLASS"
        '
        'birthdate
        '
        Me.birthdate.Location = New System.Drawing.Point(211, 323)
        Me.birthdate.Name = "birthdate"
        Me.birthdate.Size = New System.Drawing.Size(306, 20)
        Me.birthdate.TabIndex = 13
        '
        'resetbt
        '
        Me.resetbt.Location = New System.Drawing.Point(126, 517)
        Me.resetbt.Name = "resetbt"
        Me.resetbt.Size = New System.Drawing.Size(75, 23)
        Me.resetbt.TabIndex = 14
        Me.resetbt.Text = "RESET"
        Me.resetbt.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 517)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "REGISTER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'femradio
        '
        Me.femradio.AutoSize = True
        Me.femradio.Location = New System.Drawing.Point(217, 359)
        Me.femradio.Name = "femradio"
        Me.femradio.Size = New System.Drawing.Size(67, 17)
        Me.femradio.TabIndex = 16
        Me.femradio.TabStop = True
        Me.femradio.Text = "FEMALE"
        Me.femradio.UseVisualStyleBackColor = True
        '
        'maleradio
        '
        Me.maleradio.AutoSize = True
        Me.maleradio.Location = New System.Drawing.Point(311, 359)
        Me.maleradio.Name = "maleradio"
        Me.maleradio.Size = New System.Drawing.Size(54, 17)
        Me.maleradio.TabIndex = 17
        Me.maleradio.TabStop = True
        Me.maleradio.Text = "MALE"
        Me.maleradio.UseVisualStyleBackColor = True
        '
        'otheradio
        '
        Me.otheradio.AutoSize = True
        Me.otheradio.Location = New System.Drawing.Point(403, 359)
        Me.otheradio.Name = "otheradio"
        Me.otheradio.Size = New System.Drawing.Size(70, 17)
        Me.otheradio.TabIndex = 18
        Me.otheradio.TabStop = True
        Me.otheradio.Text = "OTHERS"
        Me.otheradio.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(194, 467)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "I ACCEPT"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'termslink
        '
        Me.termslink.AutoSize = True
        Me.termslink.Location = New System.Drawing.Point(329, 468)
        Me.termslink.Name = "termslink"
        Me.termslink.Size = New System.Drawing.Size(134, 13)
        Me.termslink.TabIndex = 20
        Me.termslink.TabStop = True
        Me.termslink.Text = "TERMS AND CONDITION"
        '
        'classbox
        '
        Me.classbox.FormattingEnabled = True
        Me.classbox.Items.AddRange(New Object() {"FYBCA", "SYBCA", "TYBCA"})
        Me.classbox.Location = New System.Drawing.Point(211, 423)
        Me.classbox.Name = "classbox"
        Me.classbox.Size = New System.Drawing.Size(262, 21)
        Me.classbox.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 634)
        Me.Controls.Add(Me.classbox)
        Me.Controls.Add(Me.termslink)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.otheradio)
        Me.Controls.Add(Me.maleradio)
        Me.Controls.Add(Me.femradio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.resetbt)
        Me.Controls.Add(Me.birthdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addtxt)
        Me.Controls.Add(Me.gnametxt)
        Me.Controls.Add(Me.lnametxt)
        Me.Controls.Add(Me.fnametext)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fnametext As System.Windows.Forms.TextBox
    Friend WithEvents lnametxt As System.Windows.Forms.TextBox
    Friend WithEvents gnametxt As System.Windows.Forms.TextBox
    Friend WithEvents addtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents birthdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents resetbt As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents femradio As System.Windows.Forms.RadioButton
    Friend WithEvents maleradio As System.Windows.Forms.RadioButton
    Friend WithEvents otheradio As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents termslink As System.Windows.Forms.LinkLabel
    Friend WithEvents classbox As System.Windows.Forms.ComboBox

End Class
