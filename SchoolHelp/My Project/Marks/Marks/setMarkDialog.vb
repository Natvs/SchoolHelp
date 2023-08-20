''' <summary>
''' Boite de dialogue de saisie d'une note et d'un coefficient
''' </summary>
Public Class setMarkDialog

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
    Public selectedBackColor As Color

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
    Private Sub colorChanged(sender As ColorsBox, e As EventArgs) Handles backColorsBox.Click
        selectedBackColor = backColorsBox.selectedColor
    End Sub

    ''' <summary>
    ''' Affiche le dialogue
    ''' </summary>
    ''' <param name="mark">La note de départ</param>
    ''' <param name="coef">Le coefficient de départ</param>
    Public Overloads Function ShowDialog(mark As Decimal, coef As Integer)
        markNumericUpDown.Value = mark
        coefNumericUpDown.Value = coef
        selectedBackColor = marksApp.marks.colors.color1

        Dim colorsList As New List(Of Color)
        colorsList.Add(marksApp.marks.colors.color1)
        colorsList.Add(marksApp.marks.colors.color2)
        colorsList.Add(marksApp.marks.colors.color3)
        colorsList.Add(marksApp.marks.colors.color4)
        colorsList.Add(marksApp.marks.colors.color5)
        colorsList.Add(marksApp.marks.colors.color6)
        backColorsBox.initialize("Couleurs de fond", colorsList)

        Return ShowDialog()
    End Function

End Class