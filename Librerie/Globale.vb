Imports System
Imports System.Management
Imports System.Net.NetworkInformation

Namespace Network
    Module Globale
        Function cercaMACWIFI() As String
            Dim Scheda() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
            Dim MAC_Address As String
            cercaMACWIFI = ""

            MAC_Address = Scheda(0).GetPhysicalAddress.ToString()
            For I = 0 To Scheda.Length - 1
                'If Scheda(I).Description.ToLower.Contains("wireless") = True And Scheda(I).NetworkInterfaceType = 71 Then
                If Scheda(I).NetworkInterfaceType = 71 Then
                    MAC_Address = Scheda(I).GetPhysicalAddress.ToString()
                End If
            Next

            If MAC_Address <> "" Then
                cercaMACWIFI = MAC_Address
            End If

        End Function
    End Module
End Namespace