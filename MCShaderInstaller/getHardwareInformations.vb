Imports System.Management
Module getHardwareInformations
    Private regkey As String = "HARDWARE\DESCRIPTION\System\CentralProcessor"
    Public cpu As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString")
    Public cpuSpeed As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("~mhz")
    Public cpuCores As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(regkey, False).SubKeyCount
    Public cpuVendorID As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("VendorIdentifier")
    Public cpuIdentifier As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("Identifier")
    Public graphicCard As String = getGraphicsCardName()
    Public totalRam = Format((My.Computer.Info.TotalPhysicalMemory / 1024) / 1024 / 1024, "###,###,##0 GB")


    Private Function getGraphicsCardName() As String
        Dim query As New ManagementObjectSearcher("SELECT * FROM Win32_VideoController")
        For Each vc As ManagementObject In query.Get()
            Return (vc("Name"))
        Next
    End Function
End Module
