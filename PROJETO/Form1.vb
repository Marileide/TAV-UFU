Public Class frmMain
    Public Property Form1 As Object

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim Response As MsgBoxResult
        Response = MsgBox(ml_string(31, "Tem certeza que deseja iniciar um novo documento?"),
                          MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                          ml_string(32, "Text Editor"))
        If Response = MsgBoxResult.Yes Then
            txtEditor.Text = ""
            Me.Text = ml_string(33, "Editor de Comentários")
        End If
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*" 'MLHIDE
        Open.CheckFileExists = True
        Open.ShowDialog(Me)
        Try
            Open.OpenFile()
            myStreamReader = System.IO.File.OpenText(Open.FileName)
            txtEditor.Text = myStreamReader.ReadToEnd()
            Me.Text = ml_string(35, "Text Editor - ") & Open.FileName
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        Dim Save As New SaveFileDialog()
        Dim myStreamWriter As System.IO.StreamWriter
        Save.DefaultExt = "srt"                                       'MLHIDE
        Save.Filter = "Subtitle Files (*.srt)|*.srt|All files (*.*)|*.*" 'MLHIDE
        Save.CheckPathExists = True
        Save.ShowDialog(Me)
        Try
            myStreamWriter = System.IO.File.CreateText(Save.FileName)
            myStreamWriter.Write(txtEditor.Text)
            myStreamWriter.Flush()
            Me.Text = ml_string(37, "Editor de Comentários - ") & Save.FileName
        Catch ex As Exception
            ' Do nothing on Exception
        End Try
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Dim Response As MsgBoxResult
        Response = MsgBox(ml_string(38, "Tem certeza que deseja sair do editor?"),
                          MsgBoxStyle.Question + MsgBoxStyle.YesNo,
                          ml_string(32, "Text Editor"))
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
        txtEditor.SelectedText = Format(Now, "HH:mm ,dd/MM/yyyy")     'MLHIDE
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
        Me.Text = ml_string(40, "Editor de Comentários - Sem Título")
    End Sub


    Private Sub CentroInferiorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroInferiorToolStripMenuItem.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox(ml_string(41, "Insira o texto a ser colocado como comentário na parte central inferior:"))
        Dim insertText = "" + strComentario


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub DireitaInferiorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DireitaInferiorToolStripMenuItem1.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox(ml_string(42, "Insira o texto a ser colocado como comentário na parte direita inferior:"))
        Dim insertText = "" + "{\an3}" + strComentario                'MLHIDE


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub EsquerdaSuperiorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EsquerdaSuperiorToolStripMenuItem2.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox(ml_string(44, "Insira o texto a ser colocado como comentário na parte esquerda superior:"))
        Dim insertText = "" + "{\an7}" + strComentario                'MLHIDE


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length

    End Sub

    Private Sub DireitaSuperiorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DireitaSuperiorToolStripMenuItem1.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox(ml_string(46, "Insira o texto a ser colocado como comentário na parte direita superior:"))
        Dim insertText = "" + "{\an9}" + strComentario                'MLHIDE


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub CentroSuperiorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CentroSuperiorToolStripMenuItem.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox(ml_string(48, "Insira o texto a ser colocado como comentário na parte central superior:"))
        Dim insertText = "" + "{\an8}" + strComentario                'MLHIDE


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub

    Private Sub EsquerdaInferiorToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EsquerdaInferiorToolStripMenuItem2.Click
        Dim strComentario As String
        Dim insertPos As Integer = txtEditor.SelectionStart
        strComentario = InputBox(ml_string(50, "Insira o texto a ser colocado como comentário na parte esquerda inferior:"))
        Dim insertText = "" + "{\an1}" + strComentario                'MLHIDE


        txtEditor.Text = txtEditor.Text.Insert(insertPos, insertText)
        txtEditor.SelectionStart = insertPos + insertText.Length
    End Sub


    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub SobreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreToolStripMenuItem.Click
        janelaSobre.Show()

    End Sub

    Private Sub SelecionarIdiomaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarIdiomaToolStripMenuItem.Click
        Application.Restart()
    End Sub
End Class
