Public Class frmMain

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim Response As MsgBoxResult
        Response = MsgBox("Tem certeza que deseja iniciar um novo documento?", _
                          MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                          "Text Editor")
        If Response = MsgBoxResult.Yes Then
            txtEditor.Text = ""
            Me.Text = "Editor de Comentários - Sem Título"
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
        Open.CheckFileExists = True
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            txtEditor.Text = myStreamReader.ReadToEnd()
            Me.Text = "Text Editor - " & Open.FileName
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.DefaultExt = "srt"
        Save.Filter = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*"
        Save.CheckPathExists = True
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.CreateText(Save.FileName)
            myStreamWriter.Write(txtEditor.Text)
            myStreamWriter.Flush()
            Me.Text = "Editor de Comentários - " & Save.FileName
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Dim Response As MsgBoxResult
        Response = MsgBox("Tem certeza que deseja sair do editor?", _
                          MsgBoxStyle.Question + MsgBoxStyle.YesNo, _
                          "Text Editor")
        If Response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub RecoortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoortarToolStripMenuItem.Click
        txtEditor.Cut()
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        txtEditor.Copy()
    End Sub

    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        txtEditor.Paste()
    End Sub

    Private Sub DeletarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletarToolStripMenuItem.Click
        txtEditor.SelectedText = ""
    End Sub

    Private Sub SelecionarTudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarTudoToolStripMenuItem.Click
        txtEditor.SelectAll()
    End Sub

    Private Sub HoraDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoraDataToolStripMenuItem.Click
        txtEditor.SelectedText = Format(Now, "HH:mm ,dd/MM/yyyy")
    End Sub

    Private Sub FonteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FonteToolStripMenuItem.Click
        Dim Font As New FontDialog()
        Font.Font = txtEditor.Font
        Font.ShowDialog(Me)
        Try
            txtEditor.Font = Font.Font
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub CorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorToolStripMenuItem.Click
        Dim Colour As New ColorDialog()
        Colour.Color = txtEditor.ForeColor
        Colour.ShowDialog(Me)
        Try
            txtEditor.ForeColor = Colour.Color
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub PlanoDeFundoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanoDeFundoToolStripMenuItem.Click
        Dim Colour As New ColorDialog()
        Colour.Color = txtEditor.BackColor
        Colour.ShowDialog(Me)
        Try
            txtEditor.BackColor = Colour.Color
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEditor.Text = ""
        Me.Text = "Editor de Comentários - Sem Título"
    End Sub


    Private Sub CentroInferiorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroInferiorToolStripMenuItem.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox("Insira o texto a ser colocado como comentário na parte central inferior:")
        Dim insertText = "" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub DireitaInferiorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DireitaInferiorToolStripMenuItem1.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox("Insira o texto a ser colocado como comentário na parte direita inferior:")
        Dim insertText = "" + "{\an3}" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub EsquerdaSuperiorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EsquerdaSuperiorToolStripMenuItem2.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox("Insira o texto a ser colocado como comentário na parte esquerda superior:")
        Dim insertText = "" + "{\an7}" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length

    End Sub

    Private Sub DireitaSuperiorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DireitaSuperiorToolStripMenuItem1.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox("Insira o texto a ser colocado como comentário na parte direita superior:")
        Dim insertText = "" + "{\an9}" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub CentroSuperiorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroSuperiorToolStripMenuItem.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox("Insira o texto a ser colocado como comentário na parte central superior:")
        Dim insertText = "" + "{\an8}" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub EsquerdaInferiorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EsquerdaInferiorToolStripMenuItem2.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox("Insira o texto a ser colocado como comentário na parte esquerda inferior:")
        Dim insertText = "" + "{\an1}" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        janelaSobre.Show()



    End Sub
End Class
