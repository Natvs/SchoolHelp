''' <summary>
''' Contrôle utilisateur utilisé pour une collection de notes
''' </summary>
Public Class MarksCollectionBox

    ''' <summary>
    ''' Obtient le nom de la collection
    ''' </summary>
    Public collectionName As String

    ''' <summary>
    ''' Obtient le formulaire de note parent de cette instance
    ''' </summary>
    Public marksForm As MarksForm

    ''' <summary>
    ''' Obtient la moyenne de cette instance
    ''' </summary>
    Public medium As Integer

    ''' <summary>
    ''' Initialise cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="collectionName">Le nom de la collection</param>
    ''' <param name="parent">Le formulaire de notes parent de cette instance</param>
    Public Sub initialize(collectionName As String, parent As MarksForm)
        Me.collectionName = collectionName
        Me.marksForm = parent

        collectionLabel.Text = Me.collectionName
    End Sub

    ''' <summary>
    ''' Affiche la moyenne spécifiée
    ''' </summary>
    ''' <param name="medium">La moyenne à afficher</param>
    Public Sub displayMedium(medium As Decimal)
        mediumLabel.Text = "Moyenne : " + FormatNumber(medium, 2)
    End Sub

#Region "Edition"

    ''' <summary>
    ''' Ouvre la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub open(sender As Button, e As EventArgs) Handles openButton.Click
        marksForm.openCollection(Me)
    End Sub

    ''' <summary>
    ''' Modifie la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub edit(sender As Button, e As EventArgs) Handles editButton.Click
        Using collectionDialog As New setCollectionDialog
            Dim result As DialogResult = collectionDialog.ShowDialog(Me.collectionName)
            If result = DialogResult.OK Then
                FileIO.FileSystem.RenameDirectory(marksApp.collections.getPath(Me.marksForm.currentCollectionsList) + "/" + Me.collectionName, collectionDialog.collectionName)
                initialize(collectionDialog.collectionName, Me.marksForm)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime cette collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub delete(sender As Button, e As EventArgs) Handles deleteButton.Click
        marksForm.deleteCollection(Me)
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
        End Using
    End Sub

    ''' <summary>
    ''' Charge cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    ''' <param name="parent">Le formulaire de note parent de cette instance</param>
    Public Shadows Sub load(path As String, parent As MarksForm)
        If FileIO.FileSystem.FileExists(path) Then
            Using file = FileIO.FileSystem.OpenTextFileReader(path)
                initialize(file.ReadLine, parent)
            End Using
        End If
    End Sub

#End Region

End Class
