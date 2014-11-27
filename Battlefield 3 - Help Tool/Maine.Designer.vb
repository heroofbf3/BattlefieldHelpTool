<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maine))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Weapons = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Combo1 = New System.Windows.Forms.ComboBox()
        Me.Vehicles = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Extra = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.Weapons.SuspendLayout()
        Me.Vehicles.SuspendLayout()
        Me.Extra.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.Weapons)
        Me.TabControl1.Controls.Add(Me.Vehicles)
        Me.TabControl1.Controls.Add(Me.Extra)
        Me.TabControl1.Location = New System.Drawing.Point(8, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(785, 489)
        Me.TabControl1.TabIndex = 1
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Home.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources._256250_10150976825778445_478537776_o
        Me.Home.Controls.Add(Me.Label3)
        Me.Home.Controls.Add(Me.Label2)
        Me.Home.Controls.Add(Me.WebBrowser1)
        Me.Home.Controls.Add(Me.Label1)
        Me.Home.Location = New System.Drawing.Point(4, 22)
        Me.Home.MinimumSize = New System.Drawing.Size(120, 80)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(777, 463)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(36, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(36, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(60, 19)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(651, 394)
        Me.WebBrowser1.TabIndex = 1
        Me.WebBrowser1.Url = New System.Uri("http://heroofbf3.tumblr.com", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(314, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Weapons
        '
        Me.Weapons.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources.BF3_Weapons_Image
        Me.Weapons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Weapons.Controls.Add(Me.Button1)
        Me.Weapons.Controls.Add(Me.Label4)
        Me.Weapons.Controls.Add(Me.Combo1)
        Me.Weapons.Location = New System.Drawing.Point(4, 22)
        Me.Weapons.Name = "Weapons"
        Me.Weapons.Padding = New System.Windows.Forms.Padding(3)
        Me.Weapons.Size = New System.Drawing.Size(777, 463)
        Me.Weapons.TabIndex = 1
        Me.Weapons.Text = "Weapons"
        Me.Weapons.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button1.Location = New System.Drawing.Point(296, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Find"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(242, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Label4"
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Items.AddRange(New Object() {".44 Magnum", "870 MCS", "93R", "A-91", "AEK-971", "AK-74M", "AKS-74U", "AN-94", "AS VAL", "Beretta M9", "DAO 12", "F2000", "FIM-92 Stinger", "G3", "G36C", "Glock 17", "Glock 18", "Javelin", "KH-2002", "M1014", "M16A3", "M16A4", "M9", "M1911", "M240", "M249", "M27", "M39", "M40A5", "M416", "M4A1", "M60", "M98B", "MK 11", "MP-443 Grach", "MP412 REX", "MP7", "P90", "PDW-R", "PKP Pecheneg", "PP-2000", "RPG-7", "RPK", "SA-18 Igla", "Saiga 12", "SCAR-H", "SG553", "SKS", "SMAW", "SV98", "SVD", "Type 88", "UMP-45", "USAS 12", "Premium Weapons", "DLC Weapons"})
        Me.Combo1.Location = New System.Drawing.Point(245, 225)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(220, 21)
        Me.Combo1.TabIndex = 0
        '
        'Vehicles
        '
        Me.Vehicles.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources.battlefield_3_armored_kill___armored_shield_map___screen_2
        Me.Vehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Vehicles.Controls.Add(Me.Label5)
        Me.Vehicles.Controls.Add(Me.Button2)
        Me.Vehicles.Controls.Add(Me.ComboBox1)
        Me.Vehicles.Location = New System.Drawing.Point(4, 22)
        Me.Vehicles.Name = "Vehicles"
        Me.Vehicles.Padding = New System.Windows.Forms.Padding(3)
        Me.Vehicles.Size = New System.Drawing.Size(777, 463)
        Me.Vehicles.TabIndex = 2
        Me.Vehicles.Text = "Vehicles"
        Me.Vehicles.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(242, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Label5"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button2.Location = New System.Drawing.Point(296, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Find"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"M1 Abrams", "T-90", "LAV-25", "BMP-2", "9K22 Tunguska", "LAV-AD", "BTR-90", "AH-1", "Mi-28", "UH-1Y", "KA-60", "AH-6J", "Z-11", "F/A 18 Super Hornet", "A10 Thunderbolt", "Sukhoi Su-35", "Sukhoi Su-39", "F35", "Humvee", "Vodnik", "Growler ITV", "VDV Buggy", "DPV — Desert Patrol Vehicle", "RHIB Boat", "AAV-7A1 / Amphibious Assault Vehicle"})
        Me.ComboBox1.Location = New System.Drawing.Point(245, 225)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Extra
        '
        Me.Extra.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.Extra.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources.battlefield_3_wallpaper_high_res1_original
        Me.Extra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Extra.Controls.Add(Me.Label7)
        Me.Extra.Controls.Add(Me.Button8)
        Me.Extra.Controls.Add(Me.AxShockwaveFlash1)
        Me.Extra.Controls.Add(Me.CheckBox1)
        Me.Extra.Controls.Add(Me.Button6)
        Me.Extra.Controls.Add(Me.Button5)
        Me.Extra.Controls.Add(Me.Button4)
        Me.Extra.Controls.Add(Me.Button3)
        Me.Extra.Location = New System.Drawing.Point(4, 22)
        Me.Extra.Name = "Extra"
        Me.Extra.Size = New System.Drawing.Size(777, 463)
        Me.Extra.TabIndex = 6
        Me.Extra.Text = "Extra"
        Me.Extra.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(524, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Contact"
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button8.Location = New System.Drawing.Point(493, 399)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(110, 57)
        Me.Button8.TabIndex = 13
        Me.Button8.Text = "Contact Me By Email"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(372, 129)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(258, 222)
        Me.AxShockwaveFlash1.TabIndex = 10
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.CheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CheckBox1.Location = New System.Drawing.Point(293, 231)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show/Hide"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button6.Location = New System.Drawing.Point(28, 349)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(109, 28)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Battlelog"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(28, 231)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 28)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "About"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button4.Location = New System.Drawing.Point(28, 111)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(109, 28)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Premium Guide"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button3.Location = New System.Drawing.Point(972, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Maine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 523)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Maine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maine"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.TabControl1.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.Weapons.ResumeLayout(False)
        Me.Weapons.PerformLayout()
        Me.Vehicles.ResumeLayout(False)
        Me.Vehicles.PerformLayout()
        Me.Extra.ResumeLayout(False)
        Me.Extra.PerformLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DeumosTheme1 As Battlefield_3___Help_Tool.DeumosTheme
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Home As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Weapons As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Vehicles As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Extra As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents DeumosButton1 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents DeumosButton2 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents DeumosButton3 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents DeumosButton4 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents DeumosButton7 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents DeumosButton5 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents DeumosButton6 As Battlefield_3___Help_Tool.DeumosButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
