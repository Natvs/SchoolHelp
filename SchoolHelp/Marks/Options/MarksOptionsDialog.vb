''' <summary>
''' Formulaire contenant les options de l'application des notes
''' </summary>
Public Class MarksOptionsDialog

    ''' <summary>
    ''' Affiche le dialogue
    ''' </summary>
    ''' <returns>Le résultat du dialogue</returns>
    Public Overloads Function ShowOptions() As DialogResult
        marksApp.marks.colors.Load()

        Dim MarksColorsRange As New List(Of values.Interval)
        MarksColorsRange.Add(marksApp.marks.colors.color1Interval)
        MarksColorsRange.Add(marksApp.marks.colors.color2Interval)
        MarksColorsRange.Add(marksApp.marks.colors.color3Interval)
        MarksColorsRange.Add(marksApp.marks.colors.color4Interval)
        MarksColorsRange.Add(marksApp.marks.colors.color5Interval)
        MarksColorsRange.Add(marksApp.marks.colors.color6Interval)

        EditMarksColorsByNumberBox.initialize("Modifier les couleurs automatiques des notes", MarksColorsRange, marksApp.marks.colors.getColorList(), marksApp.marks.colors.getColorsNumberList())

        marksApp.collections.colors.Load()
        Dim CollectionsColorsRange As New List(Of values.Interval)
        CollectionsColorsRange.Add(marksApp.collections.colors.color1Interval)
        CollectionsColorsRange.Add(marksApp.collections.colors.color2Interval)
        CollectionsColorsRange.Add(marksApp.collections.colors.color3Interval)
        CollectionsColorsRange.Add(marksApp.collections.colors.color4Interval)
        CollectionsColorsRange.Add(marksApp.collections.colors.color5Interval)
        CollectionsColorsRange.Add(marksApp.collections.colors.color6Interval)

        EditMarksCollectionsColorsByNumberBox.initialize("Modifier les couleurs automatiques des collections", CollectionsColorsRange, marksApp.collections.colors.getColorList(), marksApp.collections.colors.getColorsNumberList())

        Return ShowDialog()
    End Function

    Private Sub WhenClosing(sender As Form, e As EventArgs) Handles Me.FormClosing
        marksApp.marks.colors.Save()
        marksApp.collections.colors.Save()
    End Sub

End Class