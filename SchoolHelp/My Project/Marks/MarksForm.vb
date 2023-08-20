''' <summary>
''' Formulaire de notes pour afficher des notes et des collections de notes
''' </summary>
Public Class MarksForm

    ''' <summary>
    ''' Obtient le tableau contenant les collections
    ''' </summary>
    Private collectionBoxesList As New List(Of MarksCollectionBox)

    ''' <summary>
    ''' Obtient le tableau contenant les notes
    ''' </summary>
    Private markBoxesList As New List(Of MarkBox)

    ''' <summary>
    ''' Obtient le tableau contenant les collections actuellement ouvertes
    ''' ''' </summary>
    Public currentCollectionsList As New List(Of MarksCollectionBox)

    ''' <summary>
    ''' Obtient la collection actuelle
    ''' </summary>
    Public currentCollection As New MarksCollectionBox

    ''' <summary>
    ''' Obtient le chemin de la collection actuelle
    ''' </summary>
    Public currentPath As String

#Region "Form"

    ''' <summary>
    ''' Quand le formulaire de notes s'ouvre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub opening(sender As Form, e As EventArgs) Handles Me.Load
        currentPath = ""
        currentCollection = Nothing
        marksApp.loadAll(markBoxesList, collectionBoxesList, marksApp.collections.getPath(currentCollectionsList), Me)
        updateMarks()
    End Sub

    ''' <summary>
    ''' Quand le formulaire des notes se ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Shadows Sub closing(sender As Form, e As EventArgs) Handles Me.FormClosing
        marksApp.saveAll(markBoxesList, collectionBoxesList, marksApp.collections.getPath(currentCollectionsList))
    End Sub

    ''' <summary>
    ''' Actualise les instances MarkBox dans marksPanel
    ''' </summary>
    Public Sub updateMarks()
        marksPanel.Controls.Clear()
        If collectionBoxesList.Count > 0 Then
            For i = 1 To collectionBoxesList.Count
                marksPanel.Controls.Add(collectionBoxesList.Item(i - 1))
            Next
        End If
        If markBoxesList.Count > 0 Then
            For i = 1 To markBoxesList.Count
                marksPanel.Controls.Add(markBoxesList.Item(i - 1))
            Next
        End If
    End Sub

#End Region

#Region "Marks Edition"

    ''' <summary>
    ''' Ajoute une note
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub addMark(sender As Button, e As EventArgs) Handles addMarkButton.Click
        addMark()
    End Sub

    ''' <summary>
    ''' Ajoute une note
    ''' </summary>
    Public Sub addMark()
        Dim newMarkBox As New MarkBox
        Using markDialog As New setMarkDialog
            Dim result As DialogResult = markDialog.ShowDialog(20, 1)
            If result = DialogResult.OK Then
                newMarkBox.initialize(markDialog.mark, markDialog.coef, markDialog.selectedBackColor, Me)
                markBoxesList.Add(newMarkBox)
                updateMarks()
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime une note
    ''' </summary>
    ''' <param name="mark">L'instance MarkBox à supprimer</param>
    Public Sub deleteMark(mark As MarkBox)
        If markBoxesList.Contains(mark) Then
            markBoxesList.Remove(mark)
            updateMarks()
        Else
            MessageBox.Show("Cette note n'existe pas.")
        End If
    End Sub

#End Region

#Region "Collections Edition"

    ''' <summary>
    ''' Ajoute une note
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub addCollection(sender As Object, e As EventArgs) Handles addCollectionButton.Click
        addCollection()
        updateMarks()
    End Sub

    ''' <summary>
    ''' Ajoute une note
    ''' </summary>
    Public Sub addCollection()
        Dim newCollectionBox As New MarksCollectionBox
        Using collectionDialog As New setCollectionDialog
            Dim result As DialogResult = collectionDialog.ShowDialog("")
            If result = DialogResult.OK Then
                newCollectionBox.initialize(collectionDialog.collectionName, Me)
                IO.Directory.CreateDirectory(marksApp.collections.getPath(currentCollectionsList) + "/" + newCollectionBox.collectionName)
                newCollectionBox.displayMedium(marksApp.collections.getMedium(marksApp.collections.getPath(currentCollectionsList), newCollectionBox))
                collectionBoxesList.Add(newCollectionBox)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime une collection
    ''' </summary>
    ''' <param name="mark">L'instance MarksCollectionBox à supprimer</param>
    Public Sub deleteCollection(mark As MarksCollectionBox)
        If collectionBoxesList.Contains(mark) Then
            collectionBoxesList.Remove(mark)
            IO.Directory.Delete(marksApp.collections.getPath(currentCollectionsList) + "/" + mark.collectionName, True)
            updateMarks()
        Else
            MessageBox.Show("Cette collection n'existe pas.")
        End If
    End Sub

    ''' <summary>
    ''' Ouvre une collection
    ''' </summary>
    ''' <param name="collection">La collection à ouvrir</param>
    Public Sub openCollection(collection As MarksCollectionBox)
        marksApp.saveAll(markBoxesList, collectionBoxesList, marksApp.collections.getPath(currentCollectionsList))

        collectionBoxesList.Clear()
        markBoxesList.Clear()

        currentCollectionsList.Add(collection)
        currentCollection = marksApp.collections.getCurrentCollection(currentCollectionsList)
        currentPath = marksApp.collections.getPath(currentCollectionsList)

        marksApp.loadAll(markBoxesList, collectionBoxesList, marksApp.collections.getPath(currentCollectionsList), Me)
        updateMarks()
    End Sub

    ''' <summary>
    ''' Ferme la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub closeCollection(sender As Button, e As EventArgs) Handles backButton.Click
        closeCollection(currentCollection)
    End Sub

    ''' <summary>
    ''' Ferme la collection spécifiée et ouvre la précédente
    ''' </summary>
    ''' <param name="collection">La collection à fermer</param>
    Public Sub closeCollection(collection As MarksCollectionBox)
        If currentCollection Is Nothing Then
            Close()
        Else
            marksApp.saveAll(markBoxesList, collectionBoxesList, marksApp.collections.getPath(currentCollectionsList))

            collectionBoxesList.Clear()
            markBoxesList.Clear()

            currentCollectionsList.Remove(collection)
            currentCollection = marksApp.collections.getCurrentCollection(currentCollectionsList)
            currentPath = marksApp.collections.getPath(currentCollectionsList)

            marksApp.loadAll(markBoxesList, collectionBoxesList, marksApp.collections.getPath(currentCollectionsList), Me)
            updateMarks()
        End If
    End Sub

#End Region
End Class