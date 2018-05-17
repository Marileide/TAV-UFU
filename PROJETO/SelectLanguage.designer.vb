<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLanguage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectLanguage))
        Me.rbSelected = New System.Windows.Forms.RadioButton()
        Me.rbShow = New System.Windows.Forms.RadioButton()
        Me.lblStartup = New System.Windows.Forms.Label()
        Me.rbDefault = New System.Windows.Forms.RadioButton()
        Me.lstCultures = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btOK = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbSelected
        '
        resources.ApplyResources(Me.rbSelected, "rbSelected")
        Me.rbSelected.Name = "rbSelected"
        '
        'rbShow
        '
        Me.rbShow.Checked = True
        resources.ApplyResources(Me.rbShow, "rbShow")
        Me.rbShow.Name = "rbShow"
        Me.rbShow.TabStop = True
        '
        'lblStartup
        '
        resources.ApplyResources(Me.lblStartup, "lblStartup")
        Me.lblStartup.Name = "lblStartup"
        '
        'rbDefault
        '
        resources.ApplyResources(Me.rbDefault, "rbDefault")
        Me.rbDefault.Name = "rbDefault"
        '
        'lstCultures
        '
        Me.lstCultures.DisplayMember = "NativeName"
        Me.lstCultures.FormattingEnabled = True
        resources.ApplyResources(Me.lstCultures, "lstCultures")
        Me.lstCultures.Name = "lstCultures"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.rbDefault)
        Me.Panel1.Controls.Add(Me.rbSelected)
        Me.Panel1.Controls.Add(Me.rbShow)
        Me.Panel1.Controls.Add(Me.lblStartup)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btOK
        '
        resources.ApplyResources(Me.btOK, "btOK")
        Me.btOK.Name = "btOK"
        '
        'SelectLanguage
        '
        Me.AllowDrop = True
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lstCultures)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SelectLanguage"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbSelected As System.Windows.Forms.RadioButton
    Friend WithEvents rbShow As System.Windows.Forms.RadioButton
    Friend WithEvents lblStartup As System.Windows.Forms.Label
    Friend WithEvents rbDefault As System.Windows.Forms.RadioButton
    Friend WithEvents lstCultures As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btOK As System.Windows.Forms.Button
End Class
