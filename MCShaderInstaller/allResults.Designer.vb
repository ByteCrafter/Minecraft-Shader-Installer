<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class allResults
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cpuName = New System.Windows.Forms.Label()
        Me.cpuVendor = New System.Windows.Forms.Label()
        Me.cpuSpeed = New System.Windows.Forms.Label()
        Me.cpuCores = New System.Windows.Forms.Label()
        Me.cpuIdentifier = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cpuRating = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ramInGB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.graphicsCard = New System.Windows.Forms.Label()
        Me.ramRating = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.graphicsCardRating = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.overallRating = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CPU:"
        '
        'cpuName
        '
        Me.cpuName.AutoSize = True
        Me.cpuName.Location = New System.Drawing.Point(12, 22)
        Me.cpuName.Name = "cpuName"
        Me.cpuName.Size = New System.Drawing.Size(35, 13)
        Me.cpuName.TabIndex = 1
        Me.cpuName.Text = "CPU: "
        '
        'cpuVendor
        '
        Me.cpuVendor.AutoSize = True
        Me.cpuVendor.Location = New System.Drawing.Point(12, 35)
        Me.cpuVendor.Name = "cpuVendor"
        Me.cpuVendor.Size = New System.Drawing.Size(72, 13)
        Me.cpuVendor.TabIndex = 2
        Me.cpuVendor.Text = "CPU Vendor: "
        '
        'cpuSpeed
        '
        Me.cpuSpeed.AutoSize = True
        Me.cpuSpeed.Location = New System.Drawing.Point(12, 48)
        Me.cpuSpeed.Name = "cpuSpeed"
        Me.cpuSpeed.Size = New System.Drawing.Size(69, 13)
        Me.cpuSpeed.TabIndex = 3
        Me.cpuSpeed.Text = "CPU Speed: "
        '
        'cpuCores
        '
        Me.cpuCores.AutoSize = True
        Me.cpuCores.Location = New System.Drawing.Point(12, 61)
        Me.cpuCores.Name = "cpuCores"
        Me.cpuCores.Size = New System.Drawing.Size(65, 13)
        Me.cpuCores.TabIndex = 4
        Me.cpuCores.Text = "CPU Cores: "
        '
        'cpuIdentifier
        '
        Me.cpuIdentifier.AutoSize = True
        Me.cpuIdentifier.Location = New System.Drawing.Point(12, 74)
        Me.cpuIdentifier.Name = "cpuIdentifier"
        Me.cpuIdentifier.Size = New System.Drawing.Size(78, 13)
        Me.cpuIdentifier.TabIndex = 5
        Me.cpuIdentifier.Text = "CPU Identifier: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(12, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Overall rating:"
        '
        'cpuRating
        '
        Me.cpuRating.AutoSize = True
        Me.cpuRating.Location = New System.Drawing.Point(12, 111)
        Me.cpuRating.Name = "cpuRating"
        Me.cpuRating.Size = New System.Drawing.Size(87, 13)
        Me.cpuRating.TabIndex = 7
        Me.cpuRating.Text = "%CPUratinglbl1%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(12, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "RAM:"
        '
        'ramInGB
        '
        Me.ramInGB.AutoSize = True
        Me.ramInGB.Location = New System.Drawing.Point(12, 164)
        Me.ramInGB.Name = "ramInGB"
        Me.ramInGB.Size = New System.Drawing.Size(72, 13)
        Me.ramInGB.TabIndex = 9
        Me.ramInGB.Text = "RAM (in GB): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 241)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Graphics Card:"
        '
        'graphicsCard
        '
        Me.graphicsCard.AutoSize = True
        Me.graphicsCard.Location = New System.Drawing.Point(12, 254)
        Me.graphicsCard.Name = "graphicsCard"
        Me.graphicsCard.Size = New System.Drawing.Size(80, 13)
        Me.graphicsCard.TabIndex = 11
        Me.graphicsCard.Text = "Graphics Card: "
        '
        'ramRating
        '
        Me.ramRating.AutoSize = True
        Me.ramRating.Location = New System.Drawing.Point(12, 199)
        Me.ramRating.Name = "ramRating"
        Me.ramRating.Size = New System.Drawing.Size(89, 13)
        Me.ramRating.TabIndex = 13
        Me.ramRating.Text = "%RAMratinglbl1%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(12, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Overall rating:"
        '
        'graphicsCardRating
        '
        Me.graphicsCardRating.AutoSize = True
        Me.graphicsCardRating.Location = New System.Drawing.Point(12, 303)
        Me.graphicsCardRating.Name = "graphicsCardRating"
        Me.graphicsCardRating.Size = New System.Drawing.Size(80, 13)
        Me.graphicsCardRating.TabIndex = 15
        Me.graphicsCardRating.Text = "%GCratinglbl1%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 290)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Overall rating:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.25!)
        Me.Label4.Location = New System.Drawing.Point(229, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 26)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Overall Rating:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'overallRating
        '
        Me.overallRating.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.overallRating.AutoSize = True
        Me.overallRating.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.overallRating.Location = New System.Drawing.Point(238, 167)
        Me.overallRating.Name = "overallRating"
        Me.overallRating.Size = New System.Drawing.Size(138, 25)
        Me.overallRating.TabIndex = 17
        Me.overallRating.Text = "overallRating"
        Me.overallRating.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'allResults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 332)
        Me.Controls.Add(Me.overallRating)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.graphicsCardRating)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ramRating)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.graphicsCard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ramInGB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cpuRating)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cpuIdentifier)
        Me.Controls.Add(Me.cpuCores)
        Me.Controls.Add(Me.cpuSpeed)
        Me.Controls.Add(Me.cpuVendor)
        Me.Controls.Add(Me.cpuName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "allResults"
        Me.ShowIcon = False
        Me.Text = "All results"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cpuName As Label
    Friend WithEvents cpuVendor As Label
    Friend WithEvents cpuSpeed As Label
    Friend WithEvents cpuCores As Label
    Friend WithEvents cpuIdentifier As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cpuRating As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ramInGB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents graphicsCard As Label
    Friend WithEvents ramRating As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents graphicsCardRating As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents overallRating As Label
End Class
