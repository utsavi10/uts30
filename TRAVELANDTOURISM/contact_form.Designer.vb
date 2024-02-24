<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contact_form
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
        Me.cont = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cont
        '
        Me.cont.AutoSize = True
        Me.cont.Font = New System.Drawing.Font("Rockwell", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cont.ForeColor = System.Drawing.Color.Black
        Me.cont.Location = New System.Drawing.Point(203, 9)
        Me.cont.Name = "cont"
        Me.cont.Size = New System.Drawing.Size(185, 39)
        Me.cont.TabIndex = 0
        Me.cont.Text = "CONTACT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 58)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contact Number : 9674588201" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(400, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Instagram ID : @travelandtourism"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(501, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Email Id : travelandtourism000@gmail.com"
        '
        'back
        '
        Me.back.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.Location = New System.Drawing.Point(25, 380)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(126, 31)
        Me.back.TabIndex = 4
        Me.back.Text = "Back to Home"
        Me.back.UseVisualStyleBackColor = True
        '
        'contact_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 432)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cont)
        Me.Name = "contact_form"
        Me.Text = "contact_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cont As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents back As System.Windows.Forms.Button
End Class
