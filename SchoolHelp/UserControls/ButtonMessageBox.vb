''' <summary>
''' Contrôle affichant un bouton et un message descriptif au-dessus
''' </summary>
Public Class ButtonMessageBox

    ''' <summary>
    ''' Obtient le numéro de l'action définit lors de l'initialisation
    ''' </summary>
    Public actionValue As Integer = 0

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="message">Le message descriptif au-dessus du bouton</param>
    ''' <param name="buttonText">Le texte sur le bouton</param>
    ''' <param name="actionValue">Un entier qui définit l'action du bouton</param>
    ''' <param name="backColor">La couleur d'arrière plan du contrôle</param>
    ''' <param name="foreColor">La couleur de premier plan du contrôle</param>
    '''  <param name="dialogResult">Le résultat du dialogue quand l'utilisateur appuie sur le bouton</param>
    Public Sub initialize(message As String, buttonText As String, backColor As Color, foreColor As Color, actionValue As Integer, dialogResult As DialogResult)
        messageLabel.Text = message
        actionButton.Text = buttonText

        Me.BackColor = backColor
        Me.ForeColor = foreColor
        messageLabel.ForeColor = foreColor

        Me.Margin = New Padding(0)

        Me.actionValue = actionValue

        actionButton.DialogResult = dialogResult
    End Sub

    Private Sub buttonClicked(sender As Button, e As EventArgs) Handles actionButton.Click
        whenButtonClicked(sender, e)
    End Sub

#Region "Evenements"

    ''' <summary>
    ''' Se produit quand le bouton est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event ActionButtonClicked(sender As ButtonMessageBox, e As EventArgs)

    Private Sub whenButtonClicked(sender As Button, e As EventArgs)
        RaiseEvent ActionButtonClicked(Me, e)
    End Sub

#End Region

End Class
