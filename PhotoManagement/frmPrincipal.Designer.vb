<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhotoManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialogPrincipal = New System.Windows.Forms.FolderBrowserDialog()
        Me.clbImagens = New System.Windows.Forms.CheckedListBox()
        Me.txtCaminhoImagens = New System.Windows.Forms.TextBox()
        Me.btnCarregaImagens = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblDiretorio = New System.Windows.Forms.Label()
        Me.LabelText = New System.Windows.Forms.Label()
        Me.lblModeloCamera = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.imgPreviewImagem = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTamanhoImagem = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDimensoes = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMarcarTodos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnReduzirImagens = New System.Windows.Forms.Button()
        Me.chkManterOriginal = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTamanhoPersonalizado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboTamanhoReduzir = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkIncluiSubpasta = New System.Windows.Forms.CheckBox()
        Me.pbBarraProgresso = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgPreviewImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbBarraProgresso})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 408)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(840, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip.TabIndex = 1
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PhotoManagementToolStripMenuItem})
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'PhotoManagementToolStripMenuItem
        '
        Me.PhotoManagementToolStripMenuItem.Name = "PhotoManagementToolStripMenuItem"
        Me.PhotoManagementToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PhotoManagementToolStripMenuItem.Text = "Photo Management"
        '
        'clbImagens
        '
        Me.clbImagens.FormattingEnabled = True
        Me.clbImagens.Location = New System.Drawing.Point(12, 67)
        Me.clbImagens.Name = "clbImagens"
        Me.clbImagens.Size = New System.Drawing.Size(231, 304)
        Me.clbImagens.TabIndex = 2
        '
        'txtCaminhoImagens
        '
        Me.txtCaminhoImagens.Location = New System.Drawing.Point(12, 41)
        Me.txtCaminhoImagens.Name = "txtCaminhoImagens"
        Me.txtCaminhoImagens.Size = New System.Drawing.Size(549, 20)
        Me.txtCaminhoImagens.TabIndex = 3
        '
        'btnCarregaImagens
        '
        Me.btnCarregaImagens.Location = New System.Drawing.Point(567, 39)
        Me.btnCarregaImagens.Name = "btnCarregaImagens"
        Me.btnCarregaImagens.Size = New System.Drawing.Size(121, 23)
        Me.btnCarregaImagens.TabIndex = 4
        Me.btnCarregaImagens.Text = "Carregar Imagens"
        Me.btnCarregaImagens.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDiretorio)
        Me.GroupBox1.Controls.Add(Me.LabelText)
        Me.GroupBox1.Controls.Add(Me.lblModeloCamera)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.imgPreviewImagem)
        Me.GroupBox1.Controls.Add(Me.lblCopyright)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblTamanhoImagem)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblDimensoes)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(249, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações da Imagem"
        '
        'lblDiretorio
        '
        Me.lblDiretorio.AutoSize = True
        Me.lblDiretorio.Location = New System.Drawing.Point(119, 116)
        Me.lblDiretorio.Name = "lblDiretorio"
        Me.lblDiretorio.Size = New System.Drawing.Size(56, 13)
        Me.lblDiretorio.TabIndex = 10
        Me.lblDiretorio.Text = "lblDiretorio"
        '
        'LabelText
        '
        Me.LabelText.AutoSize = True
        Me.LabelText.Location = New System.Drawing.Point(64, 116)
        Me.LabelText.Name = "LabelText"
        Me.LabelText.Size = New System.Drawing.Size(49, 13)
        Me.LabelText.TabIndex = 9
        Me.LabelText.Text = "Diretório:"
        Me.LabelText.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModeloCamera
        '
        Me.lblModeloCamera.AutoSize = True
        Me.lblModeloCamera.Location = New System.Drawing.Point(119, 93)
        Me.lblModeloCamera.Name = "lblModeloCamera"
        Me.lblModeloCamera.Size = New System.Drawing.Size(88, 13)
        Me.lblModeloCamera.TabIndex = 8
        Me.lblModeloCamera.Text = "lblModeloCamera"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Modelo da Câmera:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'imgPreviewImagem
        '
        Me.imgPreviewImagem.Location = New System.Drawing.Point(394, 25)
        Me.imgPreviewImagem.Name = "imgPreviewImagem"
        Me.imgPreviewImagem.Size = New System.Drawing.Size(179, 111)
        Me.imgPreviewImagem.TabIndex = 6
        Me.imgPreviewImagem.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.Location = New System.Drawing.Point(119, 69)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(61, 13)
        Me.lblCopyright.TabIndex = 5
        Me.lblCopyright.Text = "lblCopyright"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Copyright:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTamanhoImagem
        '
        Me.lblTamanhoImagem.AutoSize = True
        Me.lblTamanhoImagem.Location = New System.Drawing.Point(119, 47)
        Me.lblTamanhoImagem.Name = "lblTamanhoImagem"
        Me.lblTamanhoImagem.Size = New System.Drawing.Size(99, 13)
        Me.lblTamanhoImagem.TabIndex = 3
        Me.lblTamanhoImagem.Text = "lblTamanhoImagem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tamanho:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDimensoes
        '
        Me.lblDimensoes.AutoSize = True
        Me.lblDimensoes.Location = New System.Drawing.Point(119, 25)
        Me.lblDimensoes.Name = "lblDimensoes"
        Me.lblDimensoes.Size = New System.Drawing.Size(106, 13)
        Me.lblDimensoes.TabIndex = 1
        Me.lblDimensoes.Text = "lblDimensoesImagem"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dimensões:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMarcarTodos
        '
        Me.btnMarcarTodos.Location = New System.Drawing.Point(12, 382)
        Me.btnMarcarTodos.Name = "btnMarcarTodos"
        Me.btnMarcarTodos.Size = New System.Drawing.Size(231, 23)
        Me.btnMarcarTodos.TabIndex = 6
        Me.btnMarcarTodos.Text = "Marcar/Desmarcar Todos"
        Me.btnMarcarTodos.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnReduzirImagens)
        Me.GroupBox2.Controls.Add(Me.chkManterOriginal)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtTamanhoPersonalizado)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboTamanhoReduzir)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 225)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(579, 146)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Edição em Lote"
        '
        'btnReduzirImagens
        '
        Me.btnReduzirImagens.Location = New System.Drawing.Point(150, 117)
        Me.btnReduzirImagens.Name = "btnReduzirImagens"
        Me.btnReduzirImagens.Size = New System.Drawing.Size(130, 23)
        Me.btnReduzirImagens.TabIndex = 6
        Me.btnReduzirImagens.Text = "Reduzir Imagens"
        Me.btnReduzirImagens.UseVisualStyleBackColor = True
        '
        'chkManterOriginal
        '
        Me.chkManterOriginal.AutoSize = True
        Me.chkManterOriginal.Checked = True
        Me.chkManterOriginal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkManterOriginal.Location = New System.Drawing.Point(150, 82)
        Me.chkManterOriginal.Name = "chkManterOriginal"
        Me.chkManterOriginal.Size = New System.Drawing.Size(145, 17)
        Me.chkManterOriginal.TabIndex = 5
        Me.chkManterOriginal.Text = "Manter Imagens Originais"
        Me.chkManterOriginal.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(213, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "px"
        '
        'txtTamanhoPersonalizado
        '
        Me.txtTamanhoPersonalizado.Enabled = False
        Me.txtTamanhoPersonalizado.Location = New System.Drawing.Point(150, 56)
        Me.txtTamanhoPersonalizado.MaxLength = 5
        Me.txtTamanhoPersonalizado.Name = "txtTamanhoPersonalizado"
        Me.txtTamanhoPersonalizado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTamanhoPersonalizado.Size = New System.Drawing.Size(63, 20)
        Me.txtTamanhoPersonalizado.TabIndex = 3
        Me.txtTamanhoPersonalizado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Largura ou Altura Máxima:"
        '
        'cboTamanhoReduzir
        '
        Me.cboTamanhoReduzir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTamanhoReduzir.FormattingEnabled = True
        Me.cboTamanhoReduzir.Items.AddRange(New Object() {"Altura/Largura Máxima: 3500 px", "Altura/Largura Máxima: 2500 px", "Altura/Largura Máxima: 1200 px", "Altura/Largura Máxima: 800 px", "Altura/Largura Máxima: 600 px", "Altura/Largura Máxima: 200 px", "Altura/Largura Máxima: Personalizado"})
        Me.cboTamanhoReduzir.Location = New System.Drawing.Point(150, 25)
        Me.cboTamanhoReduzir.Name = "cboTamanhoReduzir"
        Me.cboTamanhoReduzir.Size = New System.Drawing.Size(235, 21)
        Me.cboTamanhoReduzir.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tamanho a Reduzir:"
        '
        'chkIncluiSubpasta
        '
        Me.chkIncluiSubpasta.AutoSize = True
        Me.chkIncluiSubpasta.Location = New System.Drawing.Point(694, 43)
        Me.chkIncluiSubpasta.Name = "chkIncluiSubpasta"
        Me.chkIncluiSubpasta.Size = New System.Drawing.Size(107, 17)
        Me.chkIncluiSubpasta.TabIndex = 8
        Me.chkIncluiSubpasta.Text = "Incluir Subpastas"
        Me.chkIncluiSubpasta.UseVisualStyleBackColor = True
        '
        'pbBarraProgresso
        '
        Me.pbBarraProgresso.Name = "pbBarraProgresso"
        Me.pbBarraProgresso.Size = New System.Drawing.Size(100, 16)
        Me.pbBarraProgresso.Visible = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 430)
        Me.Controls.Add(Me.chkIncluiSubpasta)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnMarcarTodos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCarregaImagens)
        Me.Controls.Add(Me.txtCaminhoImagens)
        Me.Controls.Add(Me.clbImagens)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmPrincipal"
        Me.Text = "Photo Management"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgPreviewImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FolderBrowserDialogPrincipal As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ArquivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents clbImagens As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtCaminhoImagens As System.Windows.Forms.TextBox
    Friend WithEvents btnCarregaImagens As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnMarcarTodos As System.Windows.Forms.Button
    Friend WithEvents lblDimensoes As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTamanhoImagem As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents imgPreviewImagem As System.Windows.Forms.PictureBox
    Friend WithEvents lblModeloCamera As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkIncluiSubpasta As System.Windows.Forms.CheckBox
    Friend WithEvents LabelText As System.Windows.Forms.Label
    Friend WithEvents lblDiretorio As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTamanhoPersonalizado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboTamanhoReduzir As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkManterOriginal As System.Windows.Forms.CheckBox
    Friend WithEvents btnReduzirImagens As System.Windows.Forms.Button
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PhotoManagementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbBarraProgresso As System.Windows.Forms.ToolStripProgressBar

End Class
