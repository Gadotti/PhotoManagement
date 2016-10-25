Public Class frmPrincipal

    Public Property ItensMarcados As Boolean = True
    Public Property ListaImagens As List(Of Imagem)

    Private Sub SairToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub txtCaminhoImagens_Enter(sender As System.Object, e As System.EventArgs) Handles txtCaminhoImagens.Enter
        Try
            FolderBrowserDialogPrincipal.ShowDialog()
            txtCaminhoImagens.Text = FolderBrowserDialogPrincipal.SelectedPath
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message)
        End Try
    End Sub

    Private Sub btnCarregaImagens_Click(sender As System.Object, e As System.EventArgs) Handles btnCarregaImagens.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            'Carrega as imagens do diretório
            ListaImagens = Imagem.ObtemListaImagens(txtCaminhoImagens.Text)

            'Verifica se obteve retorno
            If ListaImagens IsNot Nothing Then
                'Carrega listagem
                clbImagens.Items.Clear()
                For Each wrkImagem In ListaImagens
                    clbImagens.Items.Add(wrkImagem.Nome, True)
                Next
                ItensMarcados = True
            End If
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblDimensoes.Text = String.Empty
        lblDiretorio.Text = String.Empty
        lblModeloCamera.Text = String.Empty
        lblCopyright.Text = String.Empty
        lblTamanhoImagem.Text = String.Empty

    End Sub

    Private Sub btnMarcarTodos_Click(sender As System.Object, e As System.EventArgs) Handles btnMarcarTodos.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If clbImagens.Items.Count > 0 Then
                For wrkInd = 0 To clbImagens.Items.Count - 1
                    clbImagens.SetItemChecked(wrkInd, Not ItensMarcados)
                Next
                ItensMarcados = Not ItensMarcados
            End If
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub clbImagens_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles clbImagens.SelectedIndexChanged
        Try
            With ListaImagens(clbImagens.SelectedIndex)
                lblDimensoes.Text = .Largura.ToString & "px X " & .Altura.ToString & "px"
                lblDiretorio.Text = .DiretorioCompleto
                lblModeloCamera.Text = String.Empty
                lblCopyright.Text = String.Empty
                lblTamanhoImagem.Text = String.Empty

                Dim wrkImage As Image = Image.FromFile(.DiretorioCompleto)

                imgPreviewImagem.Image = wrkImage.GetThumbnailImage(imgPreviewImagem.Width, imgPreviewImagem.Height, Nothing, Nothing)
                imgPreviewImagem.Refresh()
                wrkImage.Dispose()
            End With
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message)
        End Try
    End Sub

    Private Sub cboTamanhoReduzir_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles cboTamanhoReduzir.SelectedIndexChanged
        Try
            If cboTamanhoReduzir.SelectedIndex.Equals(6) Then
                txtTamanhoPersonalizado.Enabled = True
            Else
                txtTamanhoPersonalizado.Enabled = False
            End If
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnReduzirImagens_Click(sender As System.Object, e As System.EventArgs) Handles btnReduzirImagens.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            'Verifica se foi seleciona as opções necessárias
            If cboTamanhoReduzir.SelectedIndex > -1 AndAlso clbImagens.CheckedItems.Count > 0 Then

                'Obtem o tamanho selecionado
                Dim wrkTamanhoImagem As Integer
                Select Case cboTamanhoReduzir.SelectedIndex
                    Case 0
                        wrkTamanhoImagem = 3500
                    Case 1
                        wrkTamanhoImagem = 2500
                    Case 2
                        wrkTamanhoImagem = 1200
                    Case 3
                        wrkTamanhoImagem = 800
                    Case 4
                        wrkTamanhoImagem = 600
                    Case 5
                        wrkTamanhoImagem = 200
                    Case Else
                        wrkTamanhoImagem = CInt(txtTamanhoPersonalizado.Text)
                End Select

                'Passa por cada item da lista carregada
                For wrkInd = 0 To ListaImagens.Count - 1
                    'Verifica se o item na lista está selecionado
                    If clbImagens.GetItemChecked(wrkInd) Then
                        Imagem.GravaFoto(ListaImagens(wrkInd).DiretorioCompleto, wrkTamanhoImagem)
                    End If
                Next

                MsgBox("Imagens alteradas com sucesso!", MsgBoxStyle.OkOnly)
            End If
        Catch wrkErro As Exception
            MsgBox(wrkErro.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        
    End Sub
End Class
