﻿Imports System.IO.Compression
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTextBox1.Text = My.Settings.installedMinecraftPath
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        MessageBox.Show("Craftbyte Minecraft Shader Installer and Configurator")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK Then
            ListBox1.Items.Add(ofd.SafeFileName)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each i As String In ListBox1.Items

        Next
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
End Class
