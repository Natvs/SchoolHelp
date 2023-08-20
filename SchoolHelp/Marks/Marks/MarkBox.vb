''' <summary>
''' Contrôle pour afficher une note et un coefficient
''' </summary>
Public Class MarkBox

    ''' <summary>
    ''' Obtient le nom la note de ce MarkBox
    ''' </summary>
    Public markName As String

    ''' <summary>
    ''' Obtient la note de ce MarkBox
    ''' </summary>
    Public mark As Decimal

    ''' <summary>
    ''' Obtient le coefficient de ce MarkBox
    ''' </summary>
    Public coef As Decimal

    ''' <summary>
    ''' Obtient la couleur d'arrière-plan de la note
    ''' </summary>
    Public markColor As Color

    ''' <summary>
    ''' Obtient le numéro de la couleur de la note
    ''' </summary>
    Public markColorNumber As Integer

    ''' <summary>
    ''' Obtient la valeur qui définit si la couleur automatique est activée
    ''' </summary>
    Public useAutoColor As Boolean

    ''' <summary>
    ''' Obtient le formulaire de notes parent
    ''' </summary>
    Public marksForm As MarksForm

    ''' <summary>
    ''' Initialise une instance de MarkBox
    ''' </summary>
    ''' <param name="mark">La note de ce MarkBox</param>
    ''' <param name="coef">Le coefficient de ce MarkBox</param>
    ''' <param name="colorNumber">Le numéro de couleur de ce MarkBox</param>
    ''' <param name="useAutoColor">Indique si la couleur automatique est activée</param>
    ''' <param name="parent">Le formulaire de note parent</param>
    Public Sub initialize(markName As String, mark As Decimal, coef As Decimal, colorNumber As Integer, useAutoColor As Boolean, parent As MarksForm)
        Me.marksForm = parent
        initialize(markName, mark, coef, colorNumber, useAutoColor)
    End Sub

    ''' <summary>
    ''' Initialise une instance de MarkBox
    ''' </summary>
    ''' <param name="mark">La note de ce MarkBox</param>
    ''' <param name="coef">Le coefficient de ce MarkBox</param>
    ''' <param name="colorNumber">Le numéro de couleur de ce MarkBox</param>
    ''' <param name="useAutoColor">Indique si la couleur automatique est activée</param>
    Private Sub initialize(markName As String, mark As Decimal, coef As Decimal, colorNumber As Integer, useAutoColor As Boolean)
        Me.markName = markName
        Me.mark = mark
        Me.coef = coef
        Me.markColorNumber = colorNumber
        Me.markColor = marksApp.marks.colors.getColor(Me.markColorNumber)
        Me.useAutoColor = useAutoColor

        Dim inversedColor As Color

        If Me.useAutoColor Then
            Me.BackColor = marksApp.marks.colors.getAutoColor(mark)
            inversedColor = values.ColorValue.inverse(marksApp.marks.colors.getAutoColor(mark))
        Else
            Me.BackColor = markColor
            inversedColor = values.ColorValue.inverse(markColor)
        End If

        nameLabel.Text = markName
        nameLabel.ForeColor = inversedColor
        markLabel.Text = "Note : " + mark.ToString
        markLabel.ForeColor = inversedColor
        coefLabel.Text = "Coefficient : " + coef.ToString
        coefLabel.ForeColor = inversedColor
    End Sub

#Region "edition"

    ''' <summary>
    ''' Supprime le contrôle
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub delete(sender As Object, e As EventArgs) Handles deleteButton.Click
        Using deleteDialog As New SchoolHelpDialog
            If deleteDialog.ShowDialog("Voulez-vous supprimer cette note ?", values.dialogs.DialogsTypes.YesNo) = DialogResult.Yes Then
                marksForm.deleteMark(Me)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Modifie l'instance MarkBox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub edit(sender As Object, e As EventArgs) Handles editButton.Click
        Using markDialog As New setMarkDialog
            Dim result As DialogResult = markDialog.ShowDialog(Me.markName, Me.mark, Me.coef, Me.markColorNumber, Me.useAutoColor)
            initialize(markDialog.markName, markDialog.mark, markDialog.coef, markDialog.selectedColorNumber, markDialog.useAutoColor)
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
            file.WriteLine(Me.markName)
            file.WriteLine(Me.mark.ToString)
            file.WriteLine(Me.coef.ToString)
            file.WriteLine(Me.markColorNumber)
            file.WriteLine(values.BooleanValue.getString(Me.useAutoColor))
        End Using
    End Sub

    ''' <summary>
    ''' Charge cette instance de MarkBox depuis un fichier
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    ''' <param name="parent">Le formulaire de note parent</param>
    Public Shadows Sub load(path As String, parent As MarksForm)
        Using file = FileIO.FileSystem.OpenTextFileReader(path)
            Me.markName = file.ReadLine
            Me.mark = file.ReadLine
            Me.coef = file.ReadLine
            Me.markColorNumber = file.ReadLine
            Me.useAutoColor = values.BooleanValue.fromString(file.ReadLine, True)
        End Using
        initialize(markName, mark, coef, markColorNumber, useAutoColor, parent)
    End Sub

#End Region
End Class
