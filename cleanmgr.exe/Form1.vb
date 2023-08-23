Imports VB = Microsoft.VisualBasic

Public Class Main_form
    Dim Messages() As String = {
        "Windows Update-Bereinigung",
        "Protokolldateien für Windows-Upgrades",
        "Heruntergeladene Programmdateien",
        "Temporäre Internetdateien",
        "DirectX-Shadercache",
        "Dateien für die Übermittlungsoptimierung",
        "Gerätetreiberpakete",
        "Papierkorb",
        "Temporäre Dateien",
        "Miniaturansichten",
        "Dateiversionsverlauf für Benutzer"
    }
    Dim shut = True
    Public Sub Wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

    Private Sub Main_form_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim img = My.Resources.cleanmgr_icon
        PictureBox.Image = img

        Dim rnd As Random = New Random
        Dim msg = "Bereinigen:      "

        msg += Messages.GetValue(rnd.Next(0, Messages.Length - 1))
        Label_dynamic.Text = msg

        While ProgressBar.Value + 10 < ProgressBar.Maximum And shut
            Wait(rnd.Next(1, 1))
            ProgressBar.Value += rnd.Next(1, 10)
        End While

        Close()
    End Sub

    Private Sub Button_KeyDown(sender As Object, e As EventArgs) Handles Button.Click, Button.KeyPress
        'MessageBox.Show("Windows konnte ""System32"" nicht löschen." + vbCrLf + "Bitte wenden sie sich an den Systemadministrator.", "Fataler Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        shut = False
    End Sub

    Private Sub Main_form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        shut = False
    End Sub
End Class
