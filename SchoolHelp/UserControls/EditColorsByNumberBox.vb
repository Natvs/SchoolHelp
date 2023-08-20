''' <summary>
''' Contrôle permettant de modifier les 6 couleurs
''' </summary>
Public Class EditColorsByNumberBox

    Public colorsRange As List(Of values.Interval)
    Public colorsList As List(Of Color)

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="title">Le titre du contrôle</param>
    ''' <param name="colorsRange">La liste des intervalles des couleurs. Remarque : colorsRange(0) est l'intervalle de la première couleur.</param>
    ''' <param name="colorsList">La liste des couleurs disponibles.</param>
    ''' <param name="startColorsList">La liste des couleurs de départs. Remarque : startColorsList(0) est la première couleur de départ choisie par l'utilisateur, correspondant à l'intervalle colorsRange(0).</param>
    Public Sub initialize(title As String, colorsRange As List(Of values.Interval), colorsList As List(Of Color), startColorsList As List(Of values.NumericColor))
        Me.mainLabel.Text = title
        Me.colorsRange = colorsRange
        Me.colorsList = colorsList

        Dim minCount As Integer = values.NumericValue.getMin({colorsRange.Count, startColorsList.Count}.ToList)

        mainTableLayoutPanel.RowCount = minCount + 1

        For i = 1 To minCount
            mainTableLayoutPanel.RowStyles.Insert(i, New RowStyle(SizeType.AutoSize))

            Dim newEditColorByNumberBox As New EditColorByNumberBox
            newEditColorByNumberBox.initialize(colorsList, startColorsList(i - 1), colorsRange(i - 1))
            newEditColorByNumberBox.Dock = DockStyle.Fill
            mainTableLayoutPanel.Controls.Add(newEditColorByNumberBox, 0, i)
        Next

    End Sub
End Class
