''' <summary>
''' Formulaire de listes pour afficher des listes et des collections de listes
''' </summary>
Public Class ListsForm

    ''' <summary>
    ''' Obtient le tableau contenant les collections
    ''' </summary>
    Private collectionBoxesList As New List(Of ListsCollectionBox)

    ''' <summary>
    ''' Obtient le tableau contenant les listes
    ''' </summary>
    Public listBoxesList As New List(Of ListBox)

    ''' <summary>
    ''' Obtient le tableau contenant les collections actuellement ouvertes
    ''' ''' </summary>
    Public currentCollectionsList As New List(Of ListsCollectionBox)

    ''' <summary>
    ''' Obtient la collection actuelle
    ''' </summary>
    Public currentCollection As New ListsCollectionBox

    ''' <summary>
    ''' Obtient le chemin de la collection actuelle
    ''' </summary>
    Public currentPath As String

#Region "Form"

    ''' <summary>
    ''' Quand la fenètre s'ouvre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_opening(sender As Object, e As EventArgs) Handles Me.Load
        currentPath = ""
        currentCollection = Nothing
        listsApp.loadAll(listBoxesList, collectionBoxesList, listsApp.collections.getPath(currentCollectionsList), Me)
        updateLists()
    End Sub

    ''' <summary>
    ''' Quand la fenètre de ferme
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        listsApp.saveAll(listBoxesList, collectionBoxesList, listsApp.collections.getPath(currentCollectionsList))
    End Sub

    ''' <summary>
    ''' Actualise les instances MarkBox dans marksPanel
    ''' </summary>
    Public Sub updateLists()
        listsPanel.SuspendLayout()
        listsPanel.Controls.Clear()
        If collectionBoxesList.Count > 0 Then
            For i = 1 To collectionBoxesList.Count
                listsPanel.Controls.Add(collectionBoxesList.Item(i - 1))
            Next
        End If
        If listBoxesList.Count > 0 Then
            For i = 1 To listBoxesList.Count
                listsPanel.Controls.Add(listBoxesList.Item(i - 1))
            Next
        End If
        listsPanel.ResumeLayout()
    End Sub

#End Region

#Region "List edition"

    ''' <summary>
    ''' Quand le bouton pour ajouter une liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub addList(sender As Button, e As EventArgs) Handles addListButton.Click
        addList()
    End Sub

    ''' <summary>
    ''' Ajoute une note
    ''' </summary>
    Public Sub addList()
        Dim newListBox As New ListBox
        Using listDialog As New setListDialog
            Dim result As DialogResult = listDialog.ShowDialog(Nothing, 1, 1)
            If result = DialogResult.OK Then
                newListBox.initialise(listDialog.listName, listDialog.selectedColorNumber, listDialog.columnsNumber, Me)
                listBoxesList.Add(newListBox)
                updateLists()
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime une note
    ''' </summary>
    ''' <param name="list">L'instance ListBox à supprimer</param>
    Public Sub deleteList(list As ListBox)
        If listBoxesList.Contains(list) Then
            listBoxesList.Remove(list)
            updateLists()
        Else
            MessageBox.Show("Cette liste n'existe pas.")
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
        updateLists()
    End Sub

    ''' <summary>
    ''' Ajoute une note
    ''' </summary>
    Public Sub addCollection()
        Dim newCollectionBox As New ListsCollectionBox
        Using collectionDialog As New setListsCollectionDialog
            Dim result As DialogResult = collectionDialog.ShowDialog("", Nothing)
            If result = DialogResult.OK And collectionDialog.selectedName IsNot Nothing Then
                newCollectionBox.initialize(collectionDialog.selectedName, collectionDialog.selectedColorNumber, Me)
                If values.directory.CheckName(newCollectionBox.collectionName, True) Then
                    values.directory.Create(listsApp.collections.getPath(currentCollectionsList), newCollectionBox.collectionName, False, False)
                    collectionBoxesList.Add(newCollectionBox)
                End If
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime une collection
    ''' </summary>
    ''' <param name="list">L'instance MarksCollectionBox à supprimer</param>
    Public Sub deleteCollection(list As ListsCollectionBox)
        If collectionBoxesList.Contains(list) Then
            collectionBoxesList.Remove(list)
            values.directory.delete(listsApp.collections.getPath(currentCollectionsList) + "/" + list.collectionName)
            updateLists()
        Else
            MessageBox.Show("Cette collection n'existe pas.")
        End If
    End Sub

    ''' <summary>
    ''' Ouvre une collection
    ''' </summary>
    ''' <param name="collection">La collection à ouvrir</param>
    Public Sub openCollection(collection As ListsCollectionBox)
        listsApp.saveAll(listBoxesList, collectionBoxesList, listsApp.collections.getPath(currentCollectionsList))

        collectionBoxesList.Clear()
        listBoxesList.Clear()

        currentCollectionsList.Add(collection)
        currentCollection = listsApp.collections.getCurrentCollection(currentCollectionsList)
        currentPath = listsApp.collections.getPath(currentCollectionsList)

        listsApp.loadAll(listBoxesList, collectionBoxesList, listsApp.collections.getPath(currentCollectionsList), Me)
        updateLists()
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
    Public Sub closeCollection(collection As ListsCollectionBox)
        If currentCollection Is Nothing Then
            Close()
            collectionBoxesList.Clear()
            listBoxesList.Clear()
        Else
            listsApp.saveAll(listBoxesList, collectionBoxesList, listsApp.collections.getPath(currentCollectionsList))

            collectionBoxesList.Clear()
            listBoxesList.Clear()

            currentCollectionsList.Remove(collection)
            currentCollection = listsApp.collections.getCurrentCollection(currentCollectionsList)
            currentPath = listsApp.collections.getPath(currentCollectionsList)

            listsApp.loadAll(listBoxesList, collectionBoxesList, listsApp.collections.getPath(currentCollectionsList), Me)
            updateLists()
        End If

    End Sub

#End Region

End Class