''' <summary>
''' Boite de dialogue de saisie d'une note et d'un coefficient
''' </summary>
Public Class setMarkDialog

    ''' <summary>
    ''' Obtient le nom choisi
    ''' </summary>
    Public markName As String

    ''' <summary>
    ''' Obtient la note choisie
    ''' </summary>
    Public mark As Decimal

    ''' <summary>
    ''' Obtient le coefficient choisi
    ''' </summary>
    Public coef As Decimal

    ''' <summary>
    ''' Obtient la couleur d'arrière-plan sélectionnée
    ''' </summary>
    Public selectedColorNumber As Integer

    ''' <summary>
    ''' Obtient la valeur qui définit si la couleur automatique est activée
    ''' </summary>
    Public useAutoColor As Boolean
    '"'Ici
    ''' <summary>
    ''' Affiche le dialogue
    ''' </summary>
    ''' <param name="markName">Le nom de départ de la note</param>
    ''' <param name="mark">La note de départ</param>
    ''' <param name="coef">Le coefficient de départ</param>
    Public Overloads Function ShowDialog(markName As String, mark As Decimal, coef As Decimal, colorNumber As Integer, autoColor As Boolean)
        Me.markName = markName
        Me.mark = mark
        Me.coef = coef
        Me.useAutoColor = autoColor

        nameMessageTextBox.initialize("Nom de la note", Me.markName)

        markNumericUpDown.Value = mark
        coefNumericUpDown.Value = coef

        autoColorCheckBox.Checked = useAutoColor

        If colorNumber = Nothing Then
            selectedColorNumber = 1
        Else
            selectedColorNumber = colorNumber
        End If

        Dim colorsList As New List(Of Color)
        colorsList.Add(marksApp.marks.colors.defaultColor1)
        colorsList.Add(marksApp.marks.colors.defaultColor2)
        colorsList.Add(marksApp.marks.colors.defaultColor3)
        colorsList.Add(marksApp.marks.colors.defaultColor4)
        colorsList.Add(marksApp.marks.colors.defaultColor5)
        colorsList.Add(marksApp.marks.colors.defaultColor6)

        backColorsBox.initialize("Couleur de la note", colorsList, colorNumber)

        Return ShowDialog()
    End Function

#Region "Evènements internes"

    ''' <summary>
    ''' Quand un NumericUpDown change de valeur
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub valuesChanged(sender As NumericUpDown, e As EventArgs) Handles markNumericUpDown.ValueChanged, coefNumericUpDown.ValueChanged

        If sender Is markNumericUpDown Then
            mark = markNumericUpDown.Value
        ElseIf sender Is coefNumericUpDown Then
            coef = coefNumericUpDown.Value
        End If

    End Sub

    ''' <summary>
    ''' Quand une couleur d'arrière-plan est cliquée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub colorChanged(sender As ColorsBox, e As EventArgs) Handles backColorsBox.SelectedColorChanged
        selectedColorNumber = backColorsBox.selectedColorNumber
    End Sub

    ''' <summary>
    ''' Quand le nom de la note change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub markNameChanged(sender As TextMessageBox, e As EventArgs) Handles nameMessageTextBox.SelectedTextChanged
        markName = nameMessageTextBox.enteredText
    End Sub

    ''' <summary>
    ''' Quand la boite pour la couleur automatique est cochée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub markAutoColorCheckedChanged(sender As Object, e As EventArgs) Handles autoColorCheckBox.CheckedChanged
        Me.useAutoColor = autoColorCheckBox.Checked
    End Sub

    Private Sub colorChanged(sender As Object, e As EventArgs) Handles backColorsBox.SelectedColorChanged

    End Sub

    Private Sub markNameChanged(sender As Object, e As EventArgs) Handles nameMessageTextBox.SelectedTextChanged

    End Sub

#End Region

End Class