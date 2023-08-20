''' <summary>
''' Formulaire pour initialiser une liste
''' </summary>
Public Class SetListDialog

    ''' <summary>
    ''' Obtient le nom de la liste
    ''' </summary>
    Public listName As String

    ''' <summary>
    ''' Obtient le numéro de la couleur
    ''' </summary>
    Public selectedColorNumber As Integer

    ''' <summary>
    ''' Obtient le nombre de colonnes de la liste
    ''' </summary>
    Public columnsNumber As Integer

    ''' <summary>
    ''' Affiche le formulaire
    ''' </summary>
    ''' <param name="listName">Le nom de la liste</param>
    ''' <param name="colorNumber">Le numéro de la couleur de la liste</param>
    ''' <param name="columnsNumber">Le nombre de colonnes de la liste</param>
    Public Overloads Function ShowDialog(listName As String, colorNumber As Integer, columnsNumber As Integer)
        Me.listName = listName
        Me.selectedColorNumber = colorNumber
        Me.columnsNumber = columnsNumber

        listNameBox.Initialize("Nom de la liste", listName)

        Dim colorsList As New List(Of Color)
        colorsList.Add(listsApp.lists.colors.defaultColor1)
        colorsList.Add(listsApp.lists.colors.defaultColor2)
        colorsList.Add(listsApp.lists.colors.defaultColor3)
        colorsList.Add(listsApp.lists.colors.defaultColor4)
        colorsList.Add(listsApp.lists.colors.defaultColor5)
        colorsList.Add(listsApp.lists.colors.defaultColor6)

        listColorsBox.initialize("Couleur de la liste", colorsList, colorNumber)

        columnsNumberBox.initialise("Nombre de colonnes", columnsNumber, 1, 10, 1, 0)

        Return Me.ShowDialog()
    End Function

    ''' <summary>
    ''' Se produit quand le nom de la liste change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListNameChanged(sender As TextMessageBox, e As EventArgs) Handles listNameBox.SelectedTextChanged
        listName = listNameBox.enteredText
    End Sub

    ''' <summary>
    ''' Se produit quand la couleur sélectionnée change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ColorChanged(sender As ColorsBox, e As EventArgs) Handles listColorsBox.SelectedColorChanged
        selectedColorNumber = listColorsBox.selectedColorNumber
    End Sub

    ''' <summary>
    ''' Se produit quand le nombre de colonnes change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ColumnsNumberChanged(sender As NumericMessageBox, e As EventArgs) Handles columnsNumberBox.SelectedValueChanged
        Me.columnsNumber = columnsNumberBox.numericValue
    End Sub

End Class