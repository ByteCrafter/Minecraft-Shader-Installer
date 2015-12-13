<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage4 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroStyleExtender1 = New MetroFramework.Components.MetroStyleExtender(Me.components)
        Me.MetroTabPage5 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.HelpTooltip = New MetroFramework.Components.MetroToolTip()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MetroTabPage4.SuspendLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.MetroLabel1.CustomBackground = True
        Me.MetroLabel1.CustomForeColor = True
        Me.MetroLabel1.Location = New System.Drawing.Point(179, 31)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Version 1.0.0"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage4)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage5)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 4
        Me.MetroTabControl1.Size = New System.Drawing.Size(716, 344)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.UseStyleColors = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.Color.Transparent
        Me.MetroTabPage1.Controls.Add(Me.Label3)
        Me.MetroTabPage1.Controls.Add(Me.Label4)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(708, 305)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Start"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 22.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(249, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Craftbyte MSIC"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(246, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(216, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Minecraft Shader Installer && Configurator"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Panel2)
        Me.MetroTabPage2.Controls.Add(Me.Panel1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(708, 305)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Shader Installer"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(347, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(361, 305)
        Me.Panel2.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(73, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(210, 48)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Press Install to install the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selected Shaderpacks!"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(63, 164)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(234, 45)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Install"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.MetroLabel5)
        Me.Panel1.Controls.Add(Me.MetroLabel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 305)
        Me.Panel1.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(15, 254)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(290, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Select Shader Packs"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(15, 75)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(290, 173)
        Me.ListBox1.TabIndex = 8
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.BackColor = System.Drawing.Color.White
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 27)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(326, 38)
        Me.MetroLabel5.TabIndex = 7
        Me.MetroLabel5.Text = "Click on ""Select Shaderpacks"" to select the Shaderpack" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to install. You can use m" &
    "ultiple shaderpacks!"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.BackColor = System.Drawing.Color.White
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(128, 25)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "Shader Installer"
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(708, 305)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Shader Downloader"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        '
        'MetroTabPage4
        '
        Me.MetroTabPage4.BackColor = System.Drawing.Color.Transparent
        Me.MetroTabPage4.Controls.Add(Me.MetroButton1)
        Me.MetroTabPage4.Controls.Add(Me.Label1)
        Me.MetroTabPage4.Controls.Add(Me.MetroLabel3)
        Me.MetroTabPage4.Controls.Add(Me.MetroLabel2)
        Me.MetroTabPage4.ForeColor = System.Drawing.Color.Black
        Me.MetroTabPage4.HorizontalScrollbarBarColor = True
        Me.MetroTabPage4.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage4.Name = "MetroTabPage4"
        Me.MetroTabPage4.Size = New System.Drawing.Size(708, 305)
        Me.MetroTabPage4.TabIndex = 3
        Me.MetroTabPage4.Text = "Is your PC okay for Shaders?"
        Me.MetroTabPage4.VerticalScrollbarBarColor = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Highlight = True
        Me.MetroButton1.Location = New System.Drawing.Point(251, 168)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(207, 42)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.White
        Me.MetroButton1.TabIndex = 5
        Me.MetroButton1.Text = "Click here to check your PC!"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(71, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(567, 74)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Click the button above this text to check if your" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Computer fits the requirements" &
    " to run Shaders!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 27)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(409, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "This will check if your Computer fits the requirements to run Shaders."
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(227, 25)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Is your PC okay for Shaders?"
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Nothing
        '
        'MetroTabPage5
        '
        Me.MetroTabPage5.Controls.Add(Me.MetroButton2)
        Me.MetroTabPage5.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage5.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage5.Controls.Add(Me.MetroLabel6)
        Me.MetroTabPage5.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage5.HorizontalScrollbarBarColor = True
        Me.MetroTabPage5.Location = New System.Drawing.Point(4, 35)
        Me.MetroTabPage5.Name = "MetroTabPage5"
        Me.MetroTabPage5.Size = New System.Drawing.Size(708, 305)
        Me.MetroTabPage5.TabIndex = 4
        Me.MetroTabPage5.Text = "Settings"
        Me.MetroTabPage5.VerticalScrollbarBarColor = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 27)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(220, 19)
        Me.MetroLabel6.TabIndex = 5
        Me.MetroLabel6.Text = "Here you can change some Settings."
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(71, 25)
        Me.MetroLabel7.TabIndex = 4
        Me.MetroLabel7.Text = "Settings"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 60)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Minecraft Path"
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Location = New System.Drawing.Point(7, 82)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(308, 23)
        Me.MetroTextBox1.TabIndex = 7
        Me.MetroTextBox1.Text = "Path needs to be selected!"
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(321, 82)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(184, 23)
        Me.MetroButton2.TabIndex = 8
        Me.MetroButton2.Text = "Select Minecraft Installation Path"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 419)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.White
        Me.Text = "Craftbyte MSIC"
        Me.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MetroTabPage4.ResumeLayout(False)
        Me.MetroTabPage4.PerformLayout()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage5.ResumeLayout(False)
        Me.MetroTabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents MetroStyleExtender1 As MetroFramework.Components.MetroStyleExtender
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage4 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MetroTabPage5 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents HelpTooltip As MetroFramework.Components.MetroToolTip
End Class
