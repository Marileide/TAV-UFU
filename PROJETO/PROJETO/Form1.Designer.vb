<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtEditor = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeletarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PosiçãaoDaLegendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentroMeioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentroInferiorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CentroSuperiorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DireitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DireitaInferiorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DireitaSuperiorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsquerdaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsquerdaInferiorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EsquerdaSuperiorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelecionarTudoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FonteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanoDeFundoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEditor
        '
        Me.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEditor.Location = New System.Drawing.Point(0, 24)
        Me.txtEditor.Multiline = True
        Me.txtEditor.Name = "txtEditor"
        Me.txtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEditor.Size = New System.Drawing.Size(884, 709)
        Me.txtEditor.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.FormatarToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.ToolStripSeparator1, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NovoToolStripMenuItem.Text = "Novo..."
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir..."
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SalvarToolStripMenuItem.Text = "Salvar..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecoortarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.ColarToolStripMenuItem, Me.DeletarToolStripMenuItem, Me.ToolStripSeparator3, Me.PosiçãaoDaLegendaToolStripMenuItem, Me.ToolStripSeparator2, Me.SelecionarTudoToolStripMenuItem, Me.HoraDataToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'RecoortarToolStripMenuItem
        '
        Me.RecoortarToolStripMenuItem.Name = "RecoortarToolStripMenuItem"
        Me.RecoortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RecoortarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.RecoortarToolStripMenuItem.Text = "Recortar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ColarToolStripMenuItem.Text = "Colar"
        '
        'DeletarToolStripMenuItem
        '
        Me.DeletarToolStripMenuItem.Name = "DeletarToolStripMenuItem"
        Me.DeletarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeletarToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.DeletarToolStripMenuItem.Text = "Deletar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'PosiçãaoDaLegendaToolStripMenuItem
        '
        Me.PosiçãaoDaLegendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentroMeioToolStripMenuItem, Me.DireitaToolStripMenuItem, Me.EsquerdaToolStripMenuItem})
        Me.PosiçãaoDaLegendaToolStripMenuItem.Name = "PosiçãaoDaLegendaToolStripMenuItem"
        Me.PosiçãaoDaLegendaToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.PosiçãaoDaLegendaToolStripMenuItem.Text = "Inserir comentário..."
        '
        'CentroMeioToolStripMenuItem
        '
        Me.CentroMeioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CentroInferiorToolStripMenuItem, Me.CentroSuperiorToolStripMenuItem})
        Me.CentroMeioToolStripMenuItem.Name = "CentroMeioToolStripMenuItem"
        Me.CentroMeioToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.CentroMeioToolStripMenuItem.Text = "Centro..."
        '
        'CentroInferiorToolStripMenuItem
        '
        Me.CentroInferiorToolStripMenuItem.Name = "CentroInferiorToolStripMenuItem"
        Me.CentroInferiorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.CentroInferiorToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CentroInferiorToolStripMenuItem.Text = "Inferior"
        '
        'CentroSuperiorToolStripMenuItem
        '
        Me.CentroSuperiorToolStripMenuItem.Name = "CentroSuperiorToolStripMenuItem"
        Me.CentroSuperiorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.CentroSuperiorToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.CentroSuperiorToolStripMenuItem.Text = "Superior"
        '
        'DireitaToolStripMenuItem
        '
        Me.DireitaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DireitaInferiorToolStripMenuItem1, Me.DireitaSuperiorToolStripMenuItem1})
        Me.DireitaToolStripMenuItem.Name = "DireitaToolStripMenuItem"
        Me.DireitaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.DireitaToolStripMenuItem.Text = "Direita..."
        '
        'DireitaInferiorToolStripMenuItem1
        '
        Me.DireitaInferiorToolStripMenuItem1.Name = "DireitaInferiorToolStripMenuItem1"
        Me.DireitaInferiorToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.DireitaInferiorToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.DireitaInferiorToolStripMenuItem1.Text = "Inferior"
        '
        'DireitaSuperiorToolStripMenuItem1
        '
        Me.DireitaSuperiorToolStripMenuItem1.Name = "DireitaSuperiorToolStripMenuItem1"
        Me.DireitaSuperiorToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.DireitaSuperiorToolStripMenuItem1.Size = New System.Drawing.Size(186, 22)
        Me.DireitaSuperiorToolStripMenuItem1.Text = "Superior"
        '
        'EsquerdaToolStripMenuItem
        '
        Me.EsquerdaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EsquerdaInferiorToolStripMenuItem2, Me.EsquerdaSuperiorToolStripMenuItem2})
        Me.EsquerdaToolStripMenuItem.Name = "EsquerdaToolStripMenuItem"
        Me.EsquerdaToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.EsquerdaToolStripMenuItem.Text = "Esquerda..."
        '
        'EsquerdaInferiorToolStripMenuItem2
        '
        Me.EsquerdaInferiorToolStripMenuItem2.Name = "EsquerdaInferiorToolStripMenuItem2"
        Me.EsquerdaInferiorToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.EsquerdaInferiorToolStripMenuItem2.Size = New System.Drawing.Size(186, 22)
        Me.EsquerdaInferiorToolStripMenuItem2.Text = "Inferior"
        '
        'EsquerdaSuperiorToolStripMenuItem2
        '
        Me.EsquerdaSuperiorToolStripMenuItem2.Name = "EsquerdaSuperiorToolStripMenuItem2"
        Me.EsquerdaSuperiorToolStripMenuItem2.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.D6), System.Windows.Forms.Keys)
        Me.EsquerdaSuperiorToolStripMenuItem2.Size = New System.Drawing.Size(186, 22)
        Me.EsquerdaSuperiorToolStripMenuItem2.Text = "Superior"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(198, 6)
        '
        'SelecionarTudoToolStripMenuItem
        '
        Me.SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        Me.SelecionarTudoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelecionarTudoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SelecionarTudoToolStripMenuItem.Text = "Selecionar Tudo"
        '
        'HoraDataToolStripMenuItem
        '
        Me.HoraDataToolStripMenuItem.Name = "HoraDataToolStripMenuItem"
        Me.HoraDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.HoraDataToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.HoraDataToolStripMenuItem.Text = "Hora/Data"
        '
        'FormatarToolStripMenuItem
        '
        Me.FormatarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FonteToolStripMenuItem, Me.CorToolStripMenuItem, Me.PlanoDeFundoToolStripMenuItem})
        Me.FormatarToolStripMenuItem.Name = "FormatarToolStripMenuItem"
        Me.FormatarToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.FormatarToolStripMenuItem.Text = "Formatar"
        '
        'FonteToolStripMenuItem
        '
        Me.FonteToolStripMenuItem.Name = "FonteToolStripMenuItem"
        Me.FonteToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.FonteToolStripMenuItem.Text = "Fonte..."
        '
        'CorToolStripMenuItem
        '
        Me.CorToolStripMenuItem.Name = "CorToolStripMenuItem"
        Me.CorToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CorToolStripMenuItem.Text = "Cor..."
        '
        'PlanoDeFundoToolStripMenuItem
        '
        Me.PlanoDeFundoToolStripMenuItem.Name = "PlanoDeFundoToolStripMenuItem"
        Me.PlanoDeFundoToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.PlanoDeFundoToolStripMenuItem.Text = "Plano de Fundo..."
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'frmMain
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(884, 733)
        Me.Controls.Add(Me.txtEditor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TAV UFU v1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub AbrirToolStripMenuItem_Disposed(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Disposed

    End Sub

    Friend WithEvents txtEditor As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecoortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeletarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SelecionarTudoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HoraDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FonteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlanoDeFundoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PosiçãaoDaLegendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentroMeioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentroInferiorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CentroSuperiorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DireitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DireitaInferiorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DireitaSuperiorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsquerdaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsquerdaInferiorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EsquerdaSuperiorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
End Class
