''' <summary>
''' Boite de dialogue qui permet à l'utilisateur de modifier une collection de notes
''' </summary>
Public Class setMarksCollectionDialog

    ''' <summary>
    ''' Obtient le nom de la collection
    ''' </summary>
    Public selectedName As String

    ''' <summary>
    ''' Obtient la couleur de la collection
    ''' </summary>
    Public selectedColorNumber As Integer

    ''' <summary>
    ''' Obtient la valeur indiquand si la couleur automatique est activée
    ''' </summary>
    Public useAutoColor As Boolean

    ''' <summary>
    ''' Affiche la boite de dialogue
    ''' </summary>
    ''' <param name="text">Le nom de la collection</param>
    ''' <param name="collectionColor">La couleur de la collection</param>
    ''' <param name="autoColor">Indique si la couleur automatique est activée</param>
    Public Overloads Function ShowDialog(text As String, collectionColor As Integer, autoColor As Boolean)
        Me.selectedName = text
        Me.selectedColorNumber = collectionColor
        Me.useAutoColor = autoColor

        nameMessageTextBox.initialize("Nom de la collection", Me.selectedName)

        Me.autoColorCheckBox.Checked = autoColor

        Dim backColorsList As New List(Of Color)
        backColorsList.Add(marksApp.collections.colors.color1)
        backColorsList.Add(marksApp.collections.colors.color2)
        backColorsList.Add(marksApp.collections.colors.color3)
        backColorsList.Add(marksApp.collections.colors.color4)
        backColorsList.Add(marksApp.collections.colors.color5)
        backColorsList.Add(marksApp.collections.colors.color6)
        backColorColorsBox.initialize("Couleur de la collection", backColorsList, Me.selectedColorNumber)

        Return ShowDialog()
    End Function

    ''' <summary>
    ''' Quand le nom de la collection change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub updateText(sender As TextMessageBox, e As EventArgs) Handles nameMessageTextBox.SelectedTextChanged
        selectedName = nameMessageTextBox.enteredText
    End Sub

    ''' <summary>
    ''' Quand la couleur sélectionnée change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub colorChanged(sender As ColorsBox, e As EventArgs) Handles backColorColorsBox.SelectedColorChanged
        selectedColorNumber = backColorColorsBox.selectedColorNumber
    End Sub

    ''' <summary>
    ''' Quand la boite pour la couleur automatique est cochée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub collectionAutoColorCheckedChanged(sender As CheckBox, e As EventArgs) Handles autoColorCheckBox.CheckedChanged
        Me.useAutoColor = autoColorCheckBox.Checked
    End Sub
End Class