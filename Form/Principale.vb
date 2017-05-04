Imports MAC_Finder.Network

Public Class Principale
    Dim versione As String = "1.2.0"
    Private Sub Principale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "MAC-Finder - versione " & versione
        Me.txtMac.Text = ""
        Me.txtMac.Visible = False
        Me.txtMac.ReadOnly = True

        Me.cmdRicerca.Text = ""
        Me.cmdCopia.Text = ""
        Me.cmdInfo.Text = ""

        Me.lblMessaggio.Text = "Benvenuto, seleziona il comando di ricerca"

        ToolTip.SetToolTip(cmdRicerca, "Ricerca il MAC Address della scheda")
        ToolTip.SetToolTip(cmdCopia, "Copia l'indirizzo trovato negli appunti")
        ToolTip.SetToolTip(cmdInfo, "Informazioni")
    End Sub

    Private Sub cmdRicerca_Click(sender As System.Object, e As System.EventArgs) Handles cmdRicerca.Click
        txtMac.Text = cercaMACWIFI()
        If txtMac.Text <> "" Then
            txtMac.Visible = True
            Me.lblMessaggio.Text = "L'indirizzo fisico trovato è:"
        Else
            txtMac.Visible = False
            Me.lblMessaggio.Text = "Non è stato possibile recuperare l'indirizzo fisico!"
        End If
    End Sub

    Private Sub cmdCopia_Click(sender As System.Object, e As System.EventArgs) Handles cmdCopia.Click
        If txtMac.Text <> "" Then
            My.Computer.Clipboard.SetText(txtMac.Text)
            Me.lblMessaggio.Text = "Indirizzo copiato negli appunti"
        Else
            Me.lblMessaggio.Text = "Devi prima trovare l'indirizzo per copiarlo!"
        End If
    End Sub

    Private Sub cmdInfo_Click(sender As System.Object, e As System.EventArgs) Handles cmdInfo.Click
        MsgBox("MAC-Finder - versione " & versione & vbCr & "Programma ideato e sviluppato da Alessandro Ivaldi" & vbCr & "Per segnalazioni contattare lo sviluppatore: alessandro.ivaldi@email.it", MsgBoxStyle.Information, "Informazioni")
    End Sub

End Class
