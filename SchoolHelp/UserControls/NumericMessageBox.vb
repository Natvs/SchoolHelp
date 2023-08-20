''' <summary>
''' Contrôle permettant à l'utilisateur d'entrer une valeur numérique
''' </summary>
Public Class NumericMessageBox

    ''' <summary>
    ''' La valeur choisie
    ''' </summary>
    Public numericValue As Decimal

    ''' <summary>
    ''' Initialise cette instance
    ''' </summary>
    ''' <param name="message">Le message à afficher au-dessus de la zone de saisie de la valeur</param>
    ''' <param name="value">La valeur de départ</param>
    ''' <param name="minValue">La valeur minimum qui peut être saisie</param>
    ''' <param name="maxValue">La valeur maximum qui peut être saisie</param>
    ''' <param name="valueStep">La valeur à incrémenter ou décrémenter quand l'utilisateur clique sur une flèche</param>
    ''' <param name="decimals">Le nombre de décimals à afficher</param>
    Public Sub initialise(message As String, value As Decimal, minValue As Decimal, maxValue As Decimal, valueStep As Decimal, decimals As Decimal)
        Me.numericValue = value

        messageLabel.Text = message
        valueNumericUpDown.Value = value
        valueNumericUpDown.Minimum = minValue
        valueNumericUpDown.Maximum = maxValue
        valueNumericUpDown.Increment = valueStep
        valueNumericUpDown.DecimalPlaces = decimals
    End Sub

    ''' <summary>
    ''' Quand la valeur saisie est modifiée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub valueChanged(sender As NumericUpDown, e As EventArgs) Handles valueNumericUpDown.ValueChanged
        Me.numericValue = valueNumericUpDown.Value
        whenValueChange(sender, e)
    End Sub

#Region "Evènements"

    ''' <summary>
    ''' Se produit quand la valeur saisie change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event SelectedValueChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand la valeur saisie est modifiée
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenValueChange(sender As Object, e As EventArgs)
        RaiseEvent SelectedValueChanged(Me, e)
    End Sub

#End Region

End Class
