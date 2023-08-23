<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_form))
        Me.Label_explain = New System.Windows.Forms.Label()
        Me.Label_static = New System.Windows.Forms.Label()
        Me.Label_dynamic = New System.Windows.Forms.Label()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Button = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_explain
        '
        Me.Label_explain.AutoSize = True
        Me.Label_explain.Location = New System.Drawing.Point(48, 13)
        Me.Label_explain.Name = "Label_explain"
        Me.Label_explain.Size = New System.Drawing.Size(268, 26)
        Me.Label_explain.TabIndex = 1
        Me.Label_explain.Text = "Nicht mehr erforderliche Dateien werden vom Computer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "gelöscht."
        '
        'Label_static
        '
        Me.Label_static.AutoSize = True
        Me.Label_static.Location = New System.Drawing.Point(8, 64)
        Me.Label_static.Name = "Label_static"
        Me.Label_static.Size = New System.Drawing.Size(194, 13)
        Me.Label_static.TabIndex = 2
        Me.Label_static.Text = "Bereinigen von Laufwerk Windows (C:)."
        '
        'Label_dynamic
        '
        Me.Label_dynamic.AutoSize = True
        Me.Label_dynamic.Location = New System.Drawing.Point(8, 97)
        Me.Label_dynamic.Name = "Label_dynamic"
        Me.Label_dynamic.Size = New System.Drawing.Size(81, 13)
        Me.Label_dynamic.TabIndex = 3
        Me.Label_dynamic.Text = "Bereinigen:      ."
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(11, 80)
        Me.ProgressBar.Maximum = 10000
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(227, 14)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar.TabIndex = 4
        '
        'Button
        '
        Me.Button.Location = New System.Drawing.Point(249, 70)
        Me.Button.Name = "Button"
        Me.Button.Size = New System.Drawing.Size(75, 23)
        Me.Button.TabIndex = 5
        Me.Button.Text = "Abbrechen"
        Me.Button.UseVisualStyleBackColor = True
        '
        'PictureBox
        '
        Me.PictureBox.ErrorImage = Global.cleanmgr.My.Resources.Resources.cleanmgr_icon
        Me.PictureBox.InitialImage = Global.cleanmgr.My.Resources.Resources.cleanmgr_icon
        Me.PictureBox.Location = New System.Drawing.Point(11, 13)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(37, 34)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'Main_form
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(335, 114)
        Me.Controls.Add(Me.Button)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.Label_dynamic)
        Me.Controls.Add(Me.Label_static)
        Me.Controls.Add(Me.Label_explain)
        Me.Controls.Add(Me.PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main_form"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datenträgerbereinigung"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Label_explain As Label
    Friend WithEvents Label_static As Label
    Friend WithEvents Label_dynamic As Label
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents Button As Button
End Class
