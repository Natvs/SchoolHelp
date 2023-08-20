''' <summary>
''' Contrôle pour afficher une note et un coefficient
''' </summary>
Public Class MarkBox

    ''' <summary>
    ''' Obtient la note de ce MarkBox
    ''' </summary>
    Public mark As Decimal

    ''' <summary>
    ''' Obtient le coefficient de ce MarkBox
    ''' </summary>
    Public coef As Integer

    ''' <summary>
    ''' Obtient la couleur d'arrière-plan de ce MarkBox
    ''' </summary>
    Public markBackColor As Color

    ''' <summary>
    ''' Obtient le formulaire de notes parent
    ''' </summary>
    Public marksForm As MarksForm

    ''' <summary>
    ''' Initialise une instance de MarkBox
    ''' </summary>
    ''' <param name="mark">La note de ce MarkBox</param>
    ''' <param name="coef">Le coefficient de ce MarkBox</param>
    ''' <param name="parent">Le formulaire de note parent</param>
    Public Sub initialize(mark As Decimal, coef As Integer, backColor As Color, parent As MarksForm)
        Me.mark = mark
        Me.coef = coef
        Me.markBackColor = backColor
        Me.marksForm = parent

        markLabel.Text = "Note : " + mark.ToString
        coefLabel.Text = "Coefficient : " + coef.ToString
        Me.BackColor = backColor
    End Sub

    ''' <summary>
    ''' Initialise une instance de MarkBox
    ''' </summary>
    ''' <param name="mark">La note de ce MarkBox</param>
    ''' <param name="coef">Le coefficient de ce MarkBox</param>
    Private Sub initialize(mark As Decimal, coef As Integer, backColor As Color)
        Me.mark = mark
        Me.coef = coef
        Me.markBackColor = backColor

        markLabel.Text = "Note : " + mark.ToString
        coefLabel.Text = "Coefficient : " + coef.ToString
        Me.BackColor = markBackColor
    End Sub

#Region "edition"

    ''' <summary>
    ''' Supprime le contrôle
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub delete(sender As Object, e As EventArgs) Handles deleteButton.Click
        marksForm.deleteMark(Me)
    End Sub

    ''' <summary>
    ''' Modifie l'instance MarkBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub edit(sender As Object, e As EventArgs) Handles editButton.Click
        Using markDialog As New setMarkDialog
            Dim result As DialogResult = markDialog.ShowDialog(mark, coef)
            initialize(markDialog.mark, markDialog.coef, markDialog.selectedBackColor)
        End Using
    End Sub

#End Region

#Region "save and load"

    ''' <summary>
    ''' Sauvegarde cette instance de MarkBox dans un fichier
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    Public Sub save(path As String)
        Using file = FileIO.FileSystem.OpenTextFileWriter(path, False)
            file.WriteLine(mark.ToString)
            file.WriteLine(coef.ToString)
            file.WriteLine(markBackColor.ToArgb)
        End Using
    End Sub

    ''' <summary>
    ''' Charge cette instance de MarkBox depuis un fichier
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    ''' <param name="parent">Le formulaire de note parent</param>
    Public Shadows Sub load(path As String, parent As MarksForm)
        Using file = FileIO.FileSystem.OpenTextFileReader(path)
            mark = file.ReadLine
            coef = file.ReadLine
            markBackColor = Color.FromArgb(file.ReadLine)
        End Using
        initialize(mark, coef, markBackColor, parent)
    End Sub

#End Region
End Class
