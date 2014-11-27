Public Class Form1
    Dim BMP As New Drawing.Bitmap(640, 480)
    Dim GFX As Graphics = Graphics.FromImage(BMP)
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Updates"
        Label2.Text = "Welcome soilder to Battlefield 3 - help tool! Here you can find information about all"
        Label3.Text = "guns, vehicles, and mutch mutch more."
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

    Private Sub CloseToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
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

    Private Sub NewsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsToolStripMenuItem.Click
        Process.Start("http://bf3helping.tumblr.com/")

    End Sub

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs) Handles ToolTip1.Popup

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

    Private Sub EmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailToolStripMenuItem.Click
        MainGUI.Show()
    End Sub

    Private Sub MPGHToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MPGHToolStripMenuItem.Click
        Process.Start("http://www.mpgh.net/forum/private.php?do=newpm&u=1509288")
    End Sub

    Private Sub Extra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Extra.Click

    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

    End Sub

    Private Sub Home_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Home.Click

    End Sub

    Private Sub DeumosButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton1.Click
        Maine.ShowDialog()
    End Sub
End Class
