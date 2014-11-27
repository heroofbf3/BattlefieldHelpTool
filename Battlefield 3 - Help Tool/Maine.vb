Imports System.Net

Public Class Maine

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DeumosTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosTheme1.Click

    End Sub


    Private Sub DeumosTheme1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Battlefield 3 - Help Tool"
        Label2.Text = "Current Version:  1.0"
        Label3.Text = "MPGH - Multiplayer Game Hacks"
        Label4.Text = "Select Weapon"
        Label5.Text = "Select Vehicle"
        AxShockwaveFlash1.Hide()
        AxShockwaveFlash1.Play()
        Me.Hide()
        Dim time As Integer = 10
        NotifyIcon1.Visible = True
        NotifyIcon1.BalloonTipTitle = "Battlefield 3 - Help Tool"
        NotifyIcon1.BalloonTipText = "Welcome!"
        NotifyIcon1.ShowBalloonTip(time)


    End Sub
    Public Sub CheckForUpdates()
        Dim file As String = Application.StartupPath & "/version.txt"
        Dim MyVer As String = My.Application.Info.Version.ToString
        If My.Computer.FileSystem.FileExists(file) Then
            My.Computer.FileSystem.DeleteFile(file)
        End If
        My.Computer.Network.DownloadFile("http://download2192.mediafire.com/0ep9zrk0spzg/9a1a13d72pi1bwo/version.txt", file)
        Dim LastVer As String = My.Computer.FileSystem.ReadAllText(file)
        If Not MyVer = LastVer Then
            MsgBox("Update Available")
            'Do Shit
            My.Computer.Network.DownloadFile("http://bf3helptool.comeze.com/BfHtPbl.rar", "")
        Else : MsgBox("No Update Found!")
        End If
    End Sub
    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Show()
        NotifyIcon1.Visible = False
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Show()
    End Sub

    Private Sub WebsiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub InfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Info.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Info.Show()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Combo1.Click
















    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Combo1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Combo1.SelectedItem = "M16A4" Then
            M16A4.Show()
        ElseIf Combo1.SelectedItem = "M16A3" Then
            M16A3.Show()
        ElseIf Combo1.SelectedItem = "AK-74M" Then
            AK74.Show()
        ElseIf Combo1.SelectedItem = "M416" Then
            M416.Show()
        ElseIf Combo1.SelectedItem = "F2000" Then
            F2000.Show()
        ElseIf Combo1.SelectedItem = "AEK-971" Then
            AEK971.Show()
        ElseIf Combo1.SelectedItem = "AN-94" Then
            AN94.Show()
        ElseIf Combo1.SelectedItem = "AS VAL" Then
            ASVAL.Show()
        ElseIf Combo1.SelectedItem = "G3" Then
            G3.Show()
        ElseIf Combo1.SelectedItem = "M1911" Then
            M1911.Show()
        ElseIf Combo1.SelectedItem = "KH-2002" Then
            KH2002.Show()
        ElseIf Combo1.SelectedItem = "MK 11" Then
            MK11.Show()
        ElseIf Combo1.SelectedItem = "SVD" Then
            SVD.Show()
        ElseIf Combo1.SelectedItem = "M40A5" Then
            M40A5.Show()
        ElseIf Combo1.SelectedItem = "SKS" Then
            SKS.Show()
        ElseIf Combo1.SelectedItem = "SV98" Then
            SV98.Show()
        ElseIf Combo1.SelectedItem = "M98B" Then
            M98B.Show()
        ElseIf Combo1.SelectedItem = "M39" Then
            M39.Show()
        ElseIf Combo1.SelectedItem = "M27" Then
            M27.Show()
        ElseIf Combo1.SelectedItem = "RPK" Then
            RPK.Show()
        ElseIf Combo1.SelectedItem = "M249" Then
            M249.Show()
        ElseIf Combo1.SelectedItem = "M60" Then
            M60.Show()
        ElseIf Combo1.SelectedItem = "M240" Then
            M240.Show()
        ElseIf Combo1.SelectedItem = "PKP Pecheneg" Then
            PKPPecheneg.Show()
        ElseIf Combo1.SelectedItem = "Type 88" Then
            Type88.Show()
        ElseIf Combo1.SelectedItem = "M4A1" Then
            M4A1.Show()
        ElseIf Combo1.SelectedItem = "AKS-74U" Then
            AKS74U.Show()
        ElseIf Combo1.SelectedItem = "SCAR-H" Then
            SCARH.Show()
        ElseIf Combo1.SelectedItem = "G36C" Then
            G36C.Show()
        ElseIf Combo1.SelectedItem = "SG553" Then
            SG553.Show()
        ElseIf Combo1.SelectedItem = "A-91" Then
            A91.Show()
        ElseIf Combo1.SelectedItem = "UMP-45" Then
            UMP45.Show()
        ElseIf Combo1.SelectedItem = "P90" Then
            P90.Show()
        ElseIf Combo1.SelectedItem = "MP7" Then
            MP7.Show()
        ElseIf Combo1.SelectedItem = "PP-2000" Then
            PP2000.Show()
        ElseIf Combo1.SelectedItem = "PDW-R" Then
            PDWR.Show()
        ElseIf Combo1.SelectedItem = "870 MCS" Then
            Ters.Show()
        ElseIf Combo1.SelectedItem = "Saiga 12" Then
            Saiga12.Show()
        ElseIf Combo1.SelectedItem = "USAS 12" Then
            USAS12.Show()
        ElseIf Combo1.SelectedItem = "DAO 12" Then
            DAO12.Show()
        ElseIf Combo1.SelectedItem = "M1014" Then
            M1014.Show()
        ElseIf Combo1.SelectedItem = "Beretta M9" Then
            BerettaM9.Show()
        ElseIf Combo1.SelectedItem = "MP-443 Grach" Then
            MP443Grach.Show()
        ElseIf Combo1.SelectedItem = "93R" Then
            opsa.Show()
        ElseIf Combo1.SelectedItem = "Glock 17" Then
            Glock17.Show()
        ElseIf Combo1.SelectedItem = "Glock 18" Then
            Glock18.Show()
        ElseIf Combo1.SelectedItem = "MP412 REX" Then
            MP412REX.Show()
        ElseIf Combo1.SelectedItem = ".44 Magnum" Then
            magnum.Show()
        ElseIf Combo1.SelectedItem = "RPG-7" Then
            RPG7.Show()
        ElseIf Combo1.SelectedItem = "SMAW" Then
            SMAW.Show()
        ElseIf Combo1.SelectedItem = "Javelin" Then
            Javelin.Show()
        ElseIf Combo1.SelectedItem = "FIM-92 Stinger" Then
            FIM92Stinger.Show()
        ElseIf Combo1.SelectedItem = "SA-18 Igla" Then
            SA18Igla.Show()
        ElseIf Combo1.SelectedItem = "Premium Weapons" Then
            MsgBox("Comming in next version", MsgBoxStyle.OkOnly, vbMsgBoxSetForeground = MsgBoxStyle.OkCancel)


        ElseIf Combo1.SelectedItem = "DLC Weapons" Then
            MsgBox("Comming in next version", MsgBoxStyle.OkOnly, vbMsgBoxSetForeground = MsgBoxStyle.OkCancel)
        ElseIf Combo1.SelectedItem = "M9" Then
            M9.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem = "M1 Abrams" Then
            M1Abrams.Show()
        ElseIf ComboBox1.SelectedItem = "T-90" Then
            T90.Show()
        ElseIf ComboBox1.SelectedItem = "LAV-25" Then
            LAV25.Show()
        ElseIf ComboBox1.SelectedItem = "BMP-2" Then
            BMP2.Show()
        ElseIf ComboBox1.SelectedItem = "9K22 Tunguska" Then
            K22Tunguska.Show()
        ElseIf ComboBox1.SelectedItem = "LAV-AD" Then
            LAVAD.Show()
        ElseIf ComboBox1.SelectedItem = "BTR-90" Then
            BTR90.Show()
        ElseIf ComboBox1.SelectedItem = "AH-1" Then
            AH1.Show()
        ElseIf ComboBox1.SelectedItem = "Mi-28" Then
            Mi28.Show()
        ElseIf ComboBox1.SelectedItem = "UH-1Y" Then
            UH1Y.Show()
        ElseIf ComboBox1.SelectedItem = "KA-60" Then
            KA60.Show()
        ElseIf ComboBox1.SelectedItem = "AH-6J" Then
            AH6J.Show()
        ElseIf ComboBox1.SelectedItem = "F/A 18 Super Hornet" Then
            FA18SH.Show()
        ElseIf ComboBox1.SelectedItem = "Z-11" Then
            Z11.Show()
        ElseIf ComboBox1.SelectedItem = "A10 Thunderbolt" Then
            A10Thunderbolt.Show()
        ElseIf ComboBox1.SelectedItem = "Sukhoi Su-35" Then
            Su35.Show()
        ElseIf ComboBox1.SelectedItem = "Sukhoi Su-39" Then
            Su39.Show()
        ElseIf ComboBox1.SelectedItem = "F35" Then
            F35.Show()
        ElseIf ComboBox1.SelectedItem = "Humvee" Then
            Humvee.Show()
        ElseIf ComboBox1.SelectedItem = "Vodnik" Then
            Vodnik.Show()
        ElseIf ComboBox1.SelectedItem = "Growler ITV" Then
            GrowlerITV.Show()
        ElseIf ComboBox1.SelectedItem = "VDV Buggy" Then
            VDVBuggy.Show()
        ElseIf ComboBox1.SelectedItem = "DPV — Desert Patrol Vehicle" Then
            DPV.Show()
        ElseIf ComboBox1.SelectedItem = "RHIB Boat" Then
            RHIBBoat.Show()
        ElseIf ComboBox1.SelectedItem = "AAV-7A1 / Amphibious Assault Vehicle" Then
            AAV7A1.Show()


        End If
    End Sub

    Private Sub NewsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://bf3helping.tumblr.com/")

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub AxAcroPDF1_OnError(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PremiumGuide.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Process.Start("Chrome", "http://battlelog.battlefield.com/bf3")

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        MessageBox.Show("Author: Joakim Lindström" & vbCrLf & "Name: Battlefield 3 - Help Tool" & vbCrLf & "Version: 1.0" & vbCrLf & "Note: This product is only available on MPGH and if uploaded on another site without my permission it WILL get removed.", "Info")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            AxShockwaveFlash1.Show()
            AxShockwaveFlash1.Play()


        Else
            AxShockwaveFlash1.Stop()
            AxShockwaveFlash1.Hide()

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dogtag.Show()

        MsgBox("I will add more advanced search for dogtags in next version", MsgBoxStyle.Information, )

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.mpgh.net/forum/private.php?do=newpm&u=1509288")

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MainGUI.Show()
    End Sub

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MainGUI.Show()
    End Sub

    Private Sub MPGHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Process.Start("http://www.mpgh.net/forum/private.php?do=newpm&u=1509288")
    End Sub

    Private Sub Extra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Extra.Click

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click

    End Sub

    Private Sub DeumosButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton2.Click
        MessageBox.Show("Author: Joakim Lindström" & vbCrLf & "Name: Battlefield 3 - Help Tool" & vbCrLf & "Version: 1.0" & vbCrLf & "Note: This product is only available on MPGH and if uploaded on another site without my permission it WILL get removed.", "Info")
    End Sub

    Private Sub DeumosButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton3.Click
        Process.Start("http://battlelog.battlefield.com/bf3")
    End Sub

    Private Sub DeumosButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton4.Click
        MainGUI.Show()
    End Sub

    Private Sub DeumosButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton7.Click
        Application.Exit()
    End Sub

    Private Sub DeumosButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub DeumosButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton5.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub DeumosButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton1.Click
        PremiumGuide.Show()
    End Sub

    Private Sub DeumosButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton4.Click
        MainGUI.Show()
    End Sub

    Private Sub DeumosButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton6.Click
        MessageBox.Show("Author: Joakim Lindström" & vbCrLf & "Name: Battlefield 3 - Help Tool" & vbCrLf & "Version: 1.0" & vbCrLf & "Note: This product is only available on MPGH and if uploaded on another site without my permission it WILL get removed.", "Info")
    End Sub

    Private Sub DeumosTheme1_Click_1(sender As Object, e As EventArgs) Handles DeumosTheme1.Click

    End Sub
    Dim applocation, cursorlocation As New Point(0, 0)
    Private Sub dowork()
        applocation = Me.Location
        cursorlocation = Cursor.Position

    End Sub

    Private Sub DeumosTheme1_MouseDown(sender As Object, e As MouseEventArgs) Handles DeumosTheme1.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        dowork()
    End Sub

    Private Sub DeumosTheme1_MouseUp(sender As Object, e As MouseEventArgs) Handles DeumosTheme1.MouseUp
        Timer1.Stop()
        dowork()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Location = applocation - cursorlocation + Cursor.Position
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        dowork()
    End Sub

    Private Sub TabControl1_MouseUp(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseUp
        Timer1.Stop()
        dowork()
    End Sub

    Private Sub Home_MouseDown(sender As Object, e As MouseEventArgs) Handles Home.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        dowork()
    End Sub

    Private Sub Home_MouseUp(sender As Object, e As MouseEventArgs) Handles Home.MouseUp
        Timer1.Stop()
        dowork()
    End Sub

    Private Sub Weapons_MouseDown(sender As Object, e As MouseEventArgs) Handles Weapons.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        dowork()
    End Sub

    Private Sub Weapons_MouseUp(sender As Object, e As MouseEventArgs) Handles Weapons.MouseUp
        Timer1.Stop()
        dowork()
    End Sub

    Private Sub Vehicles_Leave(sender As Object, e As EventArgs) Handles Vehicles.Leave

    End Sub

    Private Sub Vehicles_MouseDown(sender As Object, e As MouseEventArgs) Handles Vehicles.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        dowork()
    End Sub

    Private Sub Vehicles_MouseUp(sender As Object, e As MouseEventArgs) Handles Vehicles.MouseUp
        Timer1.Stop()
        dowork()
    End Sub

    Private Sub Extra_MouseDown(sender As Object, e As MouseEventArgs) Handles Extra.MouseDown
        Timer1.Enabled = True
        Timer1.Start()
        dowork()
    End Sub

    Private Sub Extra_MouseUp(sender As Object, e As MouseEventArgs) Handles Extra.MouseUp
        Timer1.Stop()
        dowork()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Process.Start("http://www.mpgh.net")
    End Sub
End Class