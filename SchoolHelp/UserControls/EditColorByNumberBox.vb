''' <summary>
''' Contrôle pour choisir la couleur à attribuer en fontion des valeurs choisies
''' </summary>
Public Class EditColorByNumberBox

    ''' <summary>
    ''' Obtient la liste des couleurs
    ''' </summary>
    Private colorList As List(Of Color)

    ''' <summary>
    ''' Obtient le numéro de la couleur sélectionnée
    ''' </summary>
    Public numberedColor As values.NumericColor

    ''' <summary>
    ''' Obtient l'intervalle de la couleur
    ''' </summary>
    Public colorInterval As values.Interval

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="colorList">La liste de couleurs</param>
    ''' <param name="startColorNumber">Le numéro de la couleur de départ</param>
    ''' <param name="colorInterval">L'interval de la couleur</param>
    Public Sub initialize(colorList As List(Of Color), startColorNumber As values.NumericColor, colorInterval As values.Interval)
        Me.colorList = colorList
        Me.numberedColor = startColorNumber
        Me.colorInterval = colorInterval
        Me.toNumericUpDown.Value = Me.colorInterval.getMaxValue()
        Me.fromNumericUpDown.Value = Me.colorInterval.getMinValue()
        colorButton.BackColor = Me.colorList(Me.numberedColor.getNumber() - 1)
    End Sub

#Region "Evènements internes"

    ''' <summary>
    ''' Se produit après la couleur de l'intervalle ait changée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event ColorChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand le bouton pour choisir la couleur est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub colorButtonClicked(sender As Button, e As EventArgs) Handles colorButton.Click
        Using dialog As New SchoolHelpDialog
            If dialog.ShowDialog("Choisissez une couleur", Me.colorList, values.dialogs.DialogsTypes.Colors) = DialogResult.OK Then
                sender.BackColor = dialog.selectedColor
                Me.numberedColor.setNumber(colorList.IndexOf(dialog.selectedColor) + 1)
            End If
            RaiseEvent ColorChanged(Me, e)
        End Using
    End Sub

    ''' <summary>
    ''' Se produit après que la valeur inférieure de l'intervalle ait changé
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event MinValueChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Se produit après que la valeur supérieure de l'intervalle ait changé
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event MaxValueChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand une valeur d'un NumericUpDown change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub valueNumericUpDownValueChanged(sender As NumericUpDown, e As EventArgs) Handles fromNumericUpDown.ValueChanged, toNumericUpDown.ValueChanged
        If sender Is fromNumericUpDown Then
            Me.colorInterval.setMinValue(fromNumericUpDown.Value)
            toNumericUpDown.Minimum = fromNumericUpDown.Value
            RaiseEvent MinValueChanged(Me, e)
        ElseIf sender Is toNumericUpDown Then
            Me.colorInterval.setMaxValue(toNumericUpDown.Value)
            fromNumericUpDown.Maximum = toNumericUpDown.Value
            RaiseEvent MaxValueChanged(Me, e)
        End If
    End Sub

#End Region

End Class
