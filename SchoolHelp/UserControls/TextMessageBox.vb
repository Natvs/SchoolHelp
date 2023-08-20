''' <summary>
''' Contrôle affichant un message avec un titre
''' </summary>
Public Class TextMessageBox

    ''' <summary>
    ''' Obtient le texte entré
    ''' </summary>
    Public enteredText As String

    ''' <summary>
    ''' Initialise cette instance de MessageTextBox
    ''' </summary>
    ''' <param name="message">Le message à afficher au-dessus de la zone de texte</param>
    ''' <param name="enteredText">Le texte à afficher</param>
    Public Sub Initialize(message As String, enteredText As String)
        Me.enteredText = enteredText

        MessageLabel.Text = message
        TextTextBox.Text = enteredText
    End Sub

    ''' <summary>
    ''' Initialise cette instance de MessageTextBox
    ''' </summary>
    ''' <param name="message">Le message à afficher au-dessus de la zone de texte</param>
    ''' <param name="enteredText">Le texte à afficher</param>
    ''' <param name="backColor">La couleur d'arrière-plan du contrôle</param>
    ''' <param name="messageColor">La couleur du message</param>
    Public Sub Initialize(message As String, enteredText As String, backColor As Color, messageColor As Color)
        Initialize(message, enteredText)

        Me.BackColor = backColor
        MessageLabel.ForeColor = messageColor
    End Sub

    ''' <summary>
    ''' Modifie le texte dans la TextBox de ce contrôle
    ''' </summary>
    ''' <param name="newText"></param>
    Public Sub EditText(newText As String)
        TextTextBox.Text = newText
    End Sub

    ''' <summary>
    ''' Modifie la couleur du texte de la TextBox de ce contrôle
    ''' </summary>
    ''' <param name="newColor">La couleur du texte</param>
    Public Sub EditText(newColor As Color)
        TextTextBox.ForeColor = newColor
    End Sub

#Region "Evènement TextChanged"

    ''' <summary>
    ''' Quand le texte change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TextTextBox_TextChanged(sender As Object, e As EventArgs) Handles TextTextBox.TextChanged
        Me.enteredText = TextTextBox.Text
        WhenTextChange(sender, e)
    End Sub


    ''' <summary>
    ''' Se produit quand le texte entré change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event SelectedTextChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand le texte entré change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub WhenTextChange(sender As Object, e As EventArgs)
        RaiseEvent SelectedTextChanged(Me, e)
    End Sub

#End Region
End Class

