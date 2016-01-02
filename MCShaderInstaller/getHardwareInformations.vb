Imports System.Management
Module getHardwareInformations
    Private ReadOnly regkey As String = "HARDWARE\DESCRIPTION\System\CentralProcessor"
    Public ReadOnly cpu As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("ProcessorNameString")
    Public ReadOnly cpuSpeed As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("~mhz")
    Public ReadOnly cpuCores As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(regkey, False).SubKeyCount
    Public ReadOnly cpuVendorID As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("VendorIdentifier")
    Public ReadOnly cpuIdentifier As String = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("HARDWARE\DESCRIPTION\System\CentralProcessor\0").GetValue("Identifier")
    Public ReadOnly graphicCard As String = getGraphicsCardName()
    Public ReadOnly totalRam = Format((My.Computer.Info.TotalPhysicalMemory / 1024) / 1024 / 1024, "###,###,##0 GB")


    Private Function getGraphicsCardName() As String
        Dim query As New ManagementObjectSearcher("SELECT * FROM Win32_VideoController")
        For Each vc As ManagementObject In query.Get()
            Return (vc("Name"))
        Next
    End Function
End Module
