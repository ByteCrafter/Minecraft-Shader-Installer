Imports Ionic.Zip
Imports System.IO
Public Class Form1
    Dim shadersCount As Integer = 0
    Private sfnl As New List(Of String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTextBox1.Text = My.Settings.installedMinecraftPath
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        MessageBox.Show("Craftbyte Minecraft Shader Installer and Configurator")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "Zip files (.zip)|*.zip"
        End With
        If ofd.ShowDialog = DialogResult.OK Then
            ListBox1.Items.Add(ofd.FileName)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CopyShaders()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim fbd As New FolderBrowserDialog
        If fbd.ShowDialog = DialogResult.Yes Then
            MetroTextBox1.Text = fbd.SelectedPath
            My.Settings.installedMinecraftPath = fbd.SelectedPath
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Your PC is ")
        allResults.Show()
    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles MetroTextBox1.Click

    End Sub

    Private Sub MetroTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MetroTextBox1.KeyPress

    End Sub

    Private Sub MetroTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles MetroTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.installedMinecraftPath = MetroTextBox1.Text
            My.Settings.Save()
            My.Settings.Reload()
        End If
    End Sub

    Private Sub CopyShaders()
        Try
            If ListBox1.Items.Count = 0 Then
                MessageBox.Show("Please select an shaderpack!", "No shaderpack selected!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                For Each i As String In ListBox1.Items

                    Using zf As ZipFile = ZipFile.Read(i)
                        Dim newShaderDir As String = My.Settings.installedMinecraftPath & "\shaderpacks\" & IO.Path.GetFileNameWithoutExtension(i)
                        IO.Directory.CreateDirectory(newShaderDir)
                        zf.ExtractAll(newShaderDir, ExtractExistingFileAction.OverwriteSilently)
                    End Using
                Next
                MessageBox.Show("Successfully installed the selected shaders!", "Shader Installer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to unpack the shaders! Message: " & ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

End Class
