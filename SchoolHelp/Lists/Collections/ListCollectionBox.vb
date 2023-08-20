Public Class ListsCollectionBox

    ''' <summary>
    ''' Obtient le nom de la collection
    ''' </summary>
    Public collectionName As String

    ''' <summary>
    ''' Obtient la couleur de la collection
    ''' </summary>
    Public collectionColor As Color

    ''' <summary>
    ''' Obtient le numéro de la couleur de la collection
    ''' </summary>
    Public collectionColorNumber As Integer

    ''' <summary>
    ''' Obtient la couleur inverse de la collection
    ''' </summary>
    Private collectionInversedColor As Color

    ''' <summary>
    ''' Obtient le formulaire de note parent de cette instance
    ''' </summary>
    Public listForm As ListsForm

    ''' <summary>
    ''' Initialise cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="collectionName">Le nom de la collection</param>
    ''' <param name="collectionColorNumber">La couleur de la collection</param>
    ''' <param name="parent">Le formulaire de notes parent de cette instance</param>
    Public Sub initialize(collectionName As String, collectionColorNumber As Integer, parent As ListsForm)
        Me.collectionName = collectionName
        Me.collectionColorNumber = collectionColorNumber
        Me.collectionColor = marksApp.collections.colors.getColor(collectionColorNumber)
        Me.listForm = parent
        Me.collectionInversedColor = values.ColorValue.inverse(Me.collectionColor)

        collectionLabel.Text = Me.collectionName
        collectionLabel.ForeColor = collectionInversedColor
        BackColor = Me.collectionColor
    End Sub

#Region "Edition"

    ''' <summary>
    ''' Ouvre la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub open(sender As Button, e As EventArgs) Handles openButton.Click
        listForm.openCollection(Me)
    End Sub

    ''' <summary>
    ''' Modifie la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub edit(sender As Button, e As EventArgs) Handles editButton.Click
        Using collectionDialog As New setListsCollectionDialog
            Dim result As DialogResult = collectionDialog.ShowDialog(Me.collectionName, Me.collectionColorNumber)
            If result = DialogResult.OK Then
                values.directory.Rename(listsApp.collections.getPath(Me.listForm.currentCollectionsList) + "/" + Me.collectionName, Me.collectionName, collectionDialog.selectedName)
                initialize(collectionDialog.selectedName, collectionDialog.selectedColorNumber, Me.listForm)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime cette collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub delete(sender As Button, e As EventArgs) Handles deleteButton.Click
        Using deleteDialog As New SchoolHelpDialog
            If deleteDialog.ShowDialog("Voulez-vous supprimer cette collection ?", values.dialogs.DialogsTypes.YesNo) = DialogResult.Yes Then
                listForm.deleteCollection(Me)
            End If
        End Using
    End Sub

#End Region

#Region "Save and load"

    ''' <summary>
    ''' Sauvegarde cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    Public Sub save(path As String)
        Using file = FileIO.FileSystem.OpenTextFileWriter(path, False)
            file.WriteLine(collectionName)
            file.WriteLine(collectionColorNumber)
        End Using
    End Sub

    ''' <summary>
    ''' Charge cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    ''' <param name="parent">Le formulaire de note parent de cette instance</param>
    Public Shadows Sub load(path As String, parent As ListsForm)
        If FileIO.FileSystem.FileExists(path) Then
            Using file = FileIO.FileSystem.OpenTextFileReader(path)
                Me.collectionName = file.ReadLine
                Me.collectionColorNumber = file.ReadLine
            End Using
            initialize(Me.collectionName, Me.collectionColorNumber, parent)
        End If
    End Sub

#End Region

End Class
