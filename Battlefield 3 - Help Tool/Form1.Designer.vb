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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.DeumosButton1 = New Battlefield_3___Help_Tool.DeumosButton()
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
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MPGHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.Weapons.SuspendLayout()
        Me.Vehicles.SuspendLayout()
        Me.Extra.SuspendLayout()
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.Weapons)
        Me.TabControl1.Controls.Add(Me.Vehicles)
        Me.TabControl1.Controls.Add(Me.Extra)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Home.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources._256250_10150976825778445_478537776_o
        Me.Home.Controls.Add(Me.DeumosButton1)
        Me.Home.Controls.Add(Me.Label3)
        Me.Home.Controls.Add(Me.Label2)
        Me.Home.Controls.Add(Me.WebBrowser1)
        Me.Home.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Home, "Home")
        Me.Home.Name = "Home"
        Me.Home.UseVisualStyleBackColor = True
        '
        'DeumosButton1
        '
        Me.DeumosButton1.Customization = "Dg4O/w4ODv8pKSn/////Bf///x7///8FPj4+/////w8AAAD/EBAQ//////8="
        resources.ApplyResources(Me.DeumosButton1, "DeumosButton1")
        Me.DeumosButton1.Image = Nothing
        Me.DeumosButton1.Name = "DeumosButton1"
        Me.DeumosButton1.NoRounding = False
        Me.DeumosButton1.Transparent = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Name = "Label2"
        '
        'WebBrowser1
        '
        resources.ApplyResources(Me.WebBrowser1, "WebBrowser1")
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Url = New System.Uri("http://bf3helping.tumblr.com/", System.UriKind.Absolute)
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Name = "Label1"
        '
        'Weapons
        '
        Me.Weapons.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources.BF3_Weapons_Image
        resources.ApplyResources(Me.Weapons, "Weapons")
        Me.Weapons.Controls.Add(Me.Button1)
        Me.Weapons.Controls.Add(Me.Label4)
        Me.Weapons.Controls.Add(Me.Combo1)
        Me.Weapons.Name = "Weapons"
        Me.Weapons.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Name = "Button1"
        Me.ToolTip1.SetToolTip(Me.Button1, resources.GetString("Button1.ToolTip"))
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Name = "Label4"
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Items.AddRange(New Object() {resources.GetString("Combo1.Items"), resources.GetString("Combo1.Items1"), resources.GetString("Combo1.Items2"), resources.GetString("Combo1.Items3"), resources.GetString("Combo1.Items4"), resources.GetString("Combo1.Items5"), resources.GetString("Combo1.Items6"), resources.GetString("Combo1.Items7"), resources.GetString("Combo1.Items8"), resources.GetString("Combo1.Items9"), resources.GetString("Combo1.Items10"), resources.GetString("Combo1.Items11"), resources.GetString("Combo1.Items12"), resources.GetString("Combo1.Items13"), resources.GetString("Combo1.Items14"), resources.GetString("Combo1.Items15"), resources.GetString("Combo1.Items16"), resources.GetString("Combo1.Items17"), resources.GetString("Combo1.Items18"), resources.GetString("Combo1.Items19"), resources.GetString("Combo1.Items20"), resources.GetString("Combo1.Items21"), resources.GetString("Combo1.Items22"), resources.GetString("Combo1.Items23"), resources.GetString("Combo1.Items24"), resources.GetString("Combo1.Items25"), resources.GetString("Combo1.Items26"), resources.GetString("Combo1.Items27"), resources.GetString("Combo1.Items28"), resources.GetString("Combo1.Items29"), resources.GetString("Combo1.Items30"), resources.GetString("Combo1.Items31"), resources.GetString("Combo1.Items32"), resources.GetString("Combo1.Items33"), resources.GetString("Combo1.Items34"), resources.GetString("Combo1.Items35"), resources.GetString("Combo1.Items36"), resources.GetString("Combo1.Items37"), resources.GetString("Combo1.Items38"), resources.GetString("Combo1.Items39"), resources.GetString("Combo1.Items40"), resources.GetString("Combo1.Items41"), resources.GetString("Combo1.Items42"), resources.GetString("Combo1.Items43"), resources.GetString("Combo1.Items44"), resources.GetString("Combo1.Items45"), resources.GetString("Combo1.Items46"), resources.GetString("Combo1.Items47"), resources.GetString("Combo1.Items48"), resources.GetString("Combo1.Items49"), resources.GetString("Combo1.Items50"), resources.GetString("Combo1.Items51"), resources.GetString("Combo1.Items52"), resources.GetString("Combo1.Items53"), resources.GetString("Combo1.Items54"), resources.GetString("Combo1.Items55")})
        resources.ApplyResources(Me.Combo1, "Combo1")
        Me.Combo1.Name = "Combo1"
        Me.ToolTip1.SetToolTip(Me.Combo1, resources.GetString("Combo1.ToolTip"))
        '
        'Vehicles
        '
        Me.Vehicles.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources.battlefield_3_armored_kill___armored_shield_map___screen_2
        resources.ApplyResources(Me.Vehicles, "Vehicles")
        Me.Vehicles.Controls.Add(Me.Label5)
        Me.Vehicles.Controls.Add(Me.Button2)
        Me.Vehicles.Controls.Add(Me.ComboBox1)
        Me.Vehicles.Name = "Vehicles"
        Me.Vehicles.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Name = "Label5"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkOrange
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.ToolTip1.SetToolTip(Me.Button2, resources.GetString("Button2.ToolTip"))
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {resources.GetString("ComboBox1.Items"), resources.GetString("ComboBox1.Items1"), resources.GetString("ComboBox1.Items2"), resources.GetString("ComboBox1.Items3"), resources.GetString("ComboBox1.Items4"), resources.GetString("ComboBox1.Items5"), resources.GetString("ComboBox1.Items6"), resources.GetString("ComboBox1.Items7"), resources.GetString("ComboBox1.Items8"), resources.GetString("ComboBox1.Items9"), resources.GetString("ComboBox1.Items10"), resources.GetString("ComboBox1.Items11"), resources.GetString("ComboBox1.Items12"), resources.GetString("ComboBox1.Items13"), resources.GetString("ComboBox1.Items14"), resources.GetString("ComboBox1.Items15"), resources.GetString("ComboBox1.Items16"), resources.GetString("ComboBox1.Items17"), resources.GetString("ComboBox1.Items18"), resources.GetString("ComboBox1.Items19"), resources.GetString("ComboBox1.Items20"), resources.GetString("ComboBox1.Items21"), resources.GetString("ComboBox1.Items22"), resources.GetString("ComboBox1.Items23"), resources.GetString("ComboBox1.Items24")})
        resources.ApplyResources(Me.ComboBox1, "ComboBox1")
        Me.ComboBox1.Name = "ComboBox1"
        Me.ToolTip1.SetToolTip(Me.ComboBox1, resources.GetString("ComboBox1.ToolTip"))
        '
        'Extra
        '
        Me.Extra.AccessibleRole = System.Windows.Forms.AccessibleRole.Link
        Me.Extra.BackgroundImage = Global.Battlefield_3___Help_Tool.My.Resources.Resources.battlefield_3_wallpaper_high_res1_original
        resources.ApplyResources(Me.Extra, "Extra")
        Me.Extra.Controls.Add(Me.Label7)
        Me.Extra.Controls.Add(Me.Button8)
        Me.Extra.Controls.Add(Me.AxShockwaveFlash1)
        Me.Extra.Controls.Add(Me.CheckBox1)
        Me.Extra.Controls.Add(Me.Button6)
        Me.Extra.Controls.Add(Me.Button5)
        Me.Extra.Controls.Add(Me.Button4)
        Me.Extra.Controls.Add(Me.Button3)
        Me.Extra.Name = "Extra"
        Me.Extra.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Name = "Label7"
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.ToolTip1.SetToolTip(Me.Button8, resources.GetString("Button8.ToolTip"))
        Me.Button8.UseVisualStyleBackColor = True
        '
        'AxShockwaveFlash1
        '
        resources.ApplyResources(Me.AxShockwaveFlash1, "AxShockwaveFlash1")
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        '
        'CheckBox1
        '
        resources.ApplyResources(Me.CheckBox1, "CheckBox1")
        Me.CheckBox1.BackColor = System.Drawing.Color.DarkOrange
        Me.CheckBox1.Name = "CheckBox1"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, resources.GetString("CheckBox1.ToolTip"))
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkOrange
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.ToolTip1.SetToolTip(Me.Button6, resources.GetString("Button6.ToolTip"))
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DarkOrange
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.ToolTip1.SetToolTip(Me.Button5, resources.GetString("Button5.ToolTip"))
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkOrange
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.ToolTip1.SetToolTip(Me.Button4, resources.GetString("Button4.ToolTip"))
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewsToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem, Me.SupportToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'NewsToolStripMenuItem
        '
        Me.NewsToolStripMenuItem.Image = Global.Battlefield_3___Help_Tool.My.Resources.Resources.newspaper
        Me.NewsToolStripMenuItem.Name = "NewsToolStripMenuItem"
        resources.ApplyResources(Me.NewsToolStripMenuItem, "NewsToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.Battlefield_3___Help_Tool.My.Resources.Resources.info1
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmailToolStripMenuItem, Me.MPGHToolStripMenuItem})
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        resources.ApplyResources(Me.SupportToolStripMenuItem, "SupportToolStripMenuItem")
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        resources.ApplyResources(Me.EmailToolStripMenuItem, "EmailToolStripMenuItem")
        '
        'MPGHToolStripMenuItem
        '
        Me.MPGHToolStripMenuItem.Name = "MPGHToolStripMenuItem"
        resources.ApplyResources(Me.MPGHToolStripMenuItem, "MPGHToolStripMenuItem")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.Battlefield_3___Help_Tool.My.Resources.Resources.deletered
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        resources.ApplyResources(Me.CloseToolStripMenuItem, "CloseToolStripMenuItem")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 1
        Me.ToolTip1.AutoPopDelay = 2500
        Me.ToolTip1.InitialDelay = 1
        Me.ToolTip1.ReshowDelay = 0
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.StripAmpersands = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
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
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Home As System.Windows.Forms.TabPage
    Friend WithEvents Weapons As System.Windows.Forms.TabPage
    Friend WithEvents Vehicles As System.Windows.Forms.TabPage
    Friend WithEvents Extra As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents SupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MPGHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeumosButton1 As Battlefield_3___Help_Tool.DeumosButton

End Class
