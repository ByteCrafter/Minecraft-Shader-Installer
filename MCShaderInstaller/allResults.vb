Public Class allResults
    Private Sub allResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cpuName.Text = "CPU: " & getHardwareInformations.cpu
        cpuSpeed.Text = "CPU Speed: " & getHardwareInformations.cpuSpeed & " MHz"
        cpuCores.Text = "CPU Cores: " & getHardwareInformations.cpuCores & "x"
        cpuIdentifier.Text = "CPU Identifier: " & getHardwareInformations.cpuIdentifier
        cpuVendor.Text = "CPU Vendor: " & getHardwareInformations.cpuVendorID

        ramInGB.Text = "RAM (in GB): " & getHardwareInformations.totalRam

        graphicsCard.Text = "Graphics Card: " & getHardwareInformations.graphicCard

        CalcCPURating()
        CalcRAMRating()
    End Sub

    Private Sub CalcCPURating()
        If getHardwareInformations.cpuSpeed < 1000 And getHardwareInformations.cpuCores = 1 Then
            cpuRating.ForeColor = Color.DarkRed
            cpuRating.Text = "Your CPU is super bad for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed < 1500 And getHardwareInformations.cpuCores = 1 Then
            cpuRating.ForeColor = Color.Red
            cpuRating.Text = "Your CPU is very bad for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 1500 And getHardwareInformations.cpuCores = 1 Then
            cpuRating.ForeColor = Color.Red
            cpuRating.Text = "Your CPU is bad for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 1500 And getHardwareInformations.cpuCores > 1 Then
            cpuRating.ForeColor = Color.OrangeRed
            cpuRating.Text = "Your CPU is not bad but also not good for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed < 2000 And getHardwareInformations.cpuCores > 1 Then
            cpuRating.ForeColor = Color.Yellow
            cpuRating.Text = "Your CPU is okay but not very good for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 2000 And getHardwareInformations.cpuCores > 1 Then
            cpuRating.ForeColor = Color.LightYellow
            cpuRating.Text = "Your CPU is okay for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 2500 And getHardwareInformations.cpuCores > 1 Then
            cpuRating.ForeColor = Color.LightYellow
            cpuRating.Text = "Your CPU is okay for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 3000 And getHardwareInformations.cpuCores > 2 Then
            cpuRating.ForeColor = Color.LightGoldenrodYellow
            cpuRating.Text = "Your CPU is okay for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 3500 And getHardwareInformations.cpuCores > 2 Then
            cpuRating.ForeColor = Color.OrangeRed
            cpuRating.Text = "Your CPU is good for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 4000 And getHardwareInformations.cpuCores > 4 Then
            cpuRating.ForeColor = Color.OrangeRed
            cpuRating.Text = "Your CPU is very good for running shaders!"
        ElseIf getHardwareInformations.cpuSpeed > 4500 And getHardwareInformations.cpuCores > 8 Then
            cpuRating.ForeColor = Color.OrangeRed
            cpuRating.Text = "Your CPU is super good for running shaders!"
        End If
    End Sub

    Private Sub CalcRAMRating()
        If getHardwareInformations.totalRam = "1 GB" Then
            ramRating.ForeColor = Color.Red
            ramRating.Text = "Your RAM is too low to run shaders!"
        ElseIf getHardwareInformations.totalRam = "2 GB" Then
            ramRating.ForeColor = Color.OrangeRed
            ramRating.Text = "Your RAM is low to run shaders!"
        ElseIf getHardwareInformations.totalRam = "3 GB" Then
            ramRating.ForeColor = Color.Yellow
            ramRating.Text = "Your RAM is low but okay to run shaders!"
        ElseIf getHardwareInformations.totalRam = "4 GB" Then
            ramRating.ForeColor = Color.YellowGreen
            ramRating.Text = "Your RAM is okay to run shaders!"
        ElseIf getHardwareInformations.totalRam = "5 GB" Then
            ramRating.ForeColor = Color.YellowGreen
            ramRating.Text = "Your RAM is okay to run shaders!"
        ElseIf getHardwareInformations.totalRam = "6 GB" Then
            ramRating.ForeColor = Color.Green
            ramRating.Text = "Your RAM is good to run shaders!"
        ElseIf getHardwareInformations.totalRam = "7 GB" Then
            ramRating.ForeColor = Color.Green
            ramRating.Text = "Your RAM is very good to run shaders!"
        ElseIf getHardwareInformations.totalRam = "8 GB" Then
            ramRating.ForeColor = Color.DarkGreen
            ramRating.Text = "Your RAM is super good to run shaders!"
        ElseIf getHardwareInformations.totalRam = "16 GB" Then
            ramRating.ForeColor = Color.DarkGreen
            ramRating.Text = "Your RAM is super good to run shaders!"
        End If
    End Sub

    Private Sub CalcGraphicsCardRating()
        If getHardwareInformations.graphicCard = "Intel(R) HD Graphics" Then
            graphicsCardRating.Text = "Your Graphics Card is okay to run Shaders! Make sure that you have the latest Driver installed!"
            graphicsCardRating.ForeColor = Color.YellowGreen
        End If
    End Sub
End Class