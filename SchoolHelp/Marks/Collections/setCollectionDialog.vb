''' <summary>
''' Boite de dialogue qui permet à l'utilisateur d'entrer un nom pour la collection
''' </summary>
Public Class setCollectionDialog

    ''' <summary>
    ''' Obtient le nom de la collection
    ''' </summary>
    Public collectionName As String

    Private Sub updateText(sender As TextBox, e As EventArgs) Handles nameTextBox.TextChanged
        collectionName = nameTextBox.Text
    End Sub

    ''' <summary>
    ''' Affiche la boite de dialogue
    ''' </summary>
    ''' <param name="text">Le nom de la collection à afficher</param>
    Public Overloads Function ShowDialog(text As String)
        Me.collectionName = text

        nameTextBox.Text = Me.collectionName

        Return ShowDialog()
    End Function

End Class