<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainGUI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainGUI))
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.EmailTB = New System.Windows.Forms.TextBox()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.SubjectTB = New System.Windows.Forms.TextBox()
        Me.ToTB = New System.Windows.Forms.TextBox()
        Me.MessageTB = New System.Windows.Forms.TextBox()
        Me.ToLabel = New System.Windows.Forms.Label()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.SendEmailBtn = New System.Windows.Forms.Button()
        Me.ExitProgramBtn = New System.Windows.Forms.Button()
        Me.EmailStatusLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeumosButton1 = New Battlefield_3___Help_Tool.DeumosButton()
        Me.SuspendLayout()
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.Location = New System.Drawing.Point(12, 9)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(52, 16)
        Me.EmailLabel.TabIndex = 0
        Me.EmailLabel.Text = "Email :"
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(221, 9)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(77, 16)
        Me.PasswordLabel.TabIndex = 1
        Me.PasswordLabel.Text = "Password :"
        '
        'EmailTB
        '
        Me.EmailTB.Location = New System.Drawing.Point(70, 8)
        Me.EmailTB.Name = "EmailTB"
        Me.EmailTB.Size = New System.Drawing.Size(145, 20)
        Me.EmailTB.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.EmailTB, "Only gmail is supported at the moment!")
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(304, 8)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(126, 20)
        Me.PasswordTB.TabIndex = 3
        Me.PasswordTB.UseSystemPasswordChar = True
        '
        'SubjectTB
        '
        Me.SubjectTB.Location = New System.Drawing.Point(137, 108)
        Me.SubjectTB.Name = "SubjectTB"
        Me.SubjectTB.Size = New System.Drawing.Size(293, 20)
        Me.SubjectTB.TabIndex = 4
        '
        'ToTB
        '
        Me.ToTB.Location = New System.Drawing.Point(137, 62)
        Me.ToTB.Name = "ToTB"
        Me.ToTB.ReadOnly = True
        Me.ToTB.Size = New System.Drawing.Size(293, 20)
        Me.ToTB.TabIndex = 5
        Me.ToTB.Text = "BF3HelpTool@gmail.com"
        Me.ToolTip1.SetToolTip(Me.ToTB, "You have not enough permission to change this.")
        '
        'MessageTB
        '
        Me.MessageTB.Location = New System.Drawing.Point(137, 160)
        Me.MessageTB.Multiline = True
        Me.MessageTB.Name = "MessageTB"
        Me.MessageTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.MessageTB.Size = New System.Drawing.Size(293, 185)
        Me.MessageTB.TabIndex = 6
        '
        'ToLabel
        '
        Me.ToLabel.AutoSize = True
        Me.ToLabel.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLabel.Location = New System.Drawing.Point(12, 63)
        Me.ToLabel.Name = "ToLabel"
        Me.ToLabel.Size = New System.Drawing.Size(31, 16)
        Me.ToLabel.TabIndex = 7
        Me.ToLabel.Text = "To :"
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectLabel.Location = New System.Drawing.Point(12, 109)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(64, 16)
        Me.SubjectLabel.TabIndex = 8
        Me.SubjectLabel.Text = "Subject :"
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.Location = New System.Drawing.Point(12, 161)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(71, 16)
        Me.MessageLabel.TabIndex = 9
        Me.MessageLabel.Text = "Message :"
        '
        'SendEmailBtn
        '
        Me.SendEmailBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SendEmailBtn.ForeColor = System.Drawing.Color.Black
        Me.SendEmailBtn.Location = New System.Drawing.Point(12, 275)
        Me.SendEmailBtn.Name = "SendEmailBtn"
        Me.SendEmailBtn.Size = New System.Drawing.Size(119, 32)
        Me.SendEmailBtn.TabIndex = 10
        Me.SendEmailBtn.Text = "Send Email"
        Me.SendEmailBtn.UseVisualStyleBackColor = True
        '
        'ExitProgramBtn
        '
        Me.ExitProgramBtn.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitProgramBtn.ForeColor = System.Drawing.Color.Black
        Me.ExitProgramBtn.Location = New System.Drawing.Point(12, 313)
        Me.ExitProgramBtn.Name = "ExitProgramBtn"
        Me.ExitProgramBtn.Size = New System.Drawing.Size(119, 32)
        Me.ExitProgramBtn.TabIndex = 11
        Me.ExitProgramBtn.Text = "Exit Program"
        Me.ExitProgramBtn.UseVisualStyleBackColor = True
        '
        'EmailStatusLabel
        '
        Me.EmailStatusLabel.AutoSize = True
        Me.EmailStatusLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailStatusLabel.Location = New System.Drawing.Point(134, 360)
        Me.EmailStatusLabel.Name = "EmailStatusLabel"
        Me.EmailStatusLabel.Size = New System.Drawing.Size(95, 16)
        Me.EmailStatusLabel.TabIndex = 12
        Me.EmailStatusLabel.Text = "Email Status :"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(235, 360)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(51, 16)
        Me.StatusLabel.TabIndex = 13
        Me.StatusLabel.Text = "Label7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(13, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Only gmail is supported!"
        '
        'DeumosButton1
        '
        Me.DeumosButton1.Customization = "Dg4O/w4ODv8pKSn/////Bf///x7///8FPj4+/////w8AAAD/EBAQ//////8="
        Me.DeumosButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DeumosButton1.Image = Nothing
        Me.DeumosButton1.Location = New System.Drawing.Point(410, 355)
        Me.DeumosButton1.Name = "DeumosButton1"
        Me.DeumosButton1.NoRounding = False
        Me.DeumosButton1.Size = New System.Drawing.Size(27, 23)
        Me.DeumosButton1.TabIndex = 15
        Me.DeumosButton1.Text = "X"
        Me.DeumosButton1.Transparent = False
        '
        'MainGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(442, 382)
        Me.Controls.Add(Me.DeumosButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.EmailStatusLabel)
        Me.Controls.Add(Me.ExitProgramBtn)
        Me.Controls.Add(Me.SendEmailBtn)
        Me.Controls.Add(Me.MessageLabel)
        Me.Controls.Add(Me.SubjectLabel)
        Me.Controls.Add(Me.ToLabel)
        Me.Controls.Add(Me.MessageTB)
        Me.Controls.Add(Me.ToTB)
        Me.Controls.Add(Me.SubjectTB)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.EmailTB)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.EmailLabel)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(120, 80)
        Me.Name = "MainGUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BF3 - Help Tool Support"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents EmailTB As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents SubjectTB As System.Windows.Forms.TextBox
    Friend WithEvents ToTB As System.Windows.Forms.TextBox
    Friend WithEvents MessageTB As System.Windows.Forms.TextBox
    Friend WithEvents ToLabel As System.Windows.Forms.Label
    Friend WithEvents SubjectLabel As System.Windows.Forms.Label
    Friend WithEvents MessageLabel As System.Windows.Forms.Label
    Friend WithEvents SendEmailBtn As System.Windows.Forms.Button
    Friend WithEvents ExitProgramBtn As System.Windows.Forms.Button
    Friend WithEvents EmailStatusLabel As System.Windows.Forms.Label
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeumosButton1 As Battlefield_3___Help_Tool.DeumosButton

End Class
