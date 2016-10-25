Imports System.IO

Public Class Imagem
    Public Property DiretorioCompleto As String
    Public Property SubDiretorio As String
    Public Property Nome As String
    Public Property Largura As Integer
    Public Property Altura As Integer
    Public Property Copyright As String
    Public Property ModeloCamera As String
    Public Property Extensao As String

    Public Overrides Function ToString() As String
        Return Me.Nome.ToString()
    End Function

    Public Sub New(ByVal pImagem As String)
        Dim wrkFile As Image = Image.FromFile(pImagem)

        'Preenche as propriedades
        Me.DiretorioCompleto = pImagem
        Me.Largura = wrkFile.Width
        Me.Altura = wrkFile.Height
        Me.Extensao = Path.GetExtension(pImagem)
        Me.Nome = Path.GetFileName(pImagem)



        wrkFile.Dispose()
    End Sub

    Public Shared Function ObtemListaImagens(ByVal pDiretorio As String, Optional ByVal pIncluiSubPasta As Boolean = False) As List(Of Imagem)
        'Obtem lista de arquivos obtidos do diretório
        Dim wrkArquivos As String() = Directory.GetFiles(pDiretorio)
        Dim wrkListaImagens As New List(Of Imagem)

        'Percorre todos os arquivos obtido na pasta
        For Each wrkArquivo In wrkArquivos
            'Trata somente arquivos JPEG ou JPG
            If Path.GetExtension(wrkArquivo).ToLower.Equals(".jpg") OrElse
                Path.GetExtension(wrkArquivo).ToLower.Equals(".jpeg") Then
                'Adiciona imagem à lista
                wrkListaImagens.Add(New Imagem(wrkArquivo))
            End If
        Next

        Return wrkListaImagens
    End Function

    Public Shared Sub GravaFoto(ByVal pArquivo As String, ByVal pTamanhoMaximo As Integer)
        Dim wrkCaminho As String = Path.GetDirectoryName(pArquivo)
        Dim wrkNomeArquivo As String = Path.GetFileNameWithoutExtension(pArquivo)
        Dim wrkExtensao As String = Path.GetExtension(pArquivo)
        Dim imagemDestrino As String = Path.Combine(wrkCaminho, "Reduzido_" & wrkNomeArquivo & wrkExtensao)

        Dim maxWidth As Integer = pTamanhoMaximo
        Dim maxHeight As Integer = pTamanhoMaximo

        'Monta uma nova imagem.
        Dim imageBitmap As System.Drawing.Bitmap = CType(Bitmap.FromFile(pArquivo), Bitmap)
        
        'Tratapoção e limite de tamanho das imagens
        If imageBitmap.Height < imageBitmap.Width Then
            'Então é formato paisagem
            If imageBitmap.Width > maxWidth Then
                maxHeight = Convert.ToInt32(imageBitmap.Height * maxWidth / imageBitmap.Width)
            Else
                maxWidth = imageBitmap.Width
                maxHeight = imageBitmap.Height
            End If
        Else
            'Senão, é retrato
            If imageBitmap.Height > maxHeight Then
                maxWidth = Convert.ToInt32(imageBitmap.Width * maxWidth / imageBitmap.Height)
            Else
                maxWidth = imageBitmap.Width
                maxHeight = imageBitmap.Height
            End If
        End If
        '=========================================

        ' Atribui o tamanho à nova imagem.
        Dim imageModificada As System.Drawing.Bitmap = New System.Drawing.Bitmap(maxWidth, maxHeight)

        ' Define o desenho da nova imagem.
        Dim graphic As Drawing.Graphics = Drawing.Graphics.FromImage(imageModificada)
        graphic.DrawImage(imageBitmap, New System.Drawing.Rectangle(0, 0, imageModificada.Width, imageModificada.Height), 0, 0, imageBitmap.Width, imageBitmap.Height, System.Drawing.GraphicsUnit.Pixel)
        graphic.Dispose()
        imageBitmap.Dispose()

        'Salva a imagem no local desejado
        imageModificada.Save(imagemDestrino, Drawing.Imaging.ImageFormat.Jpeg)
        imageModificada.Dispose()

    End Sub
End Class
