Public Class ColorsBox

    ''' <summary>
    ''' Initialise cette instance de ColorsBox
    ''' </summary>
    ''' <param name="text">Le texte à afficher au-dessus des couleurs</param>
    ''' <param name="colorsList">La liste de couleurs</param>
    ''' <param name="selectedColorNumber">La couleur sélectionnée</param>
    Public Sub initialize(text As String, colorsList As List(Of Color), selectedColorNumber As Integer)
        colorsLabel.Text = text

        Me.color1 = colorsList.Item(0)
        Me.color2 = colorsList.Item(1)
        Me.color3 = colorsList.Item(2)
        Me.color4 = colorsList.Item(3)
        Me.color5 = colorsList.Item(4)
        Me.color6 = colorsList.Item(5)

        color1Button.BackColor = color1
        color2Button.BackColor = color2
        color3Button.BackColor = color3
        color4Button.BackColor = color4
        color5Button.BackColor = color5
        color6Button.BackColor = color6

        selectColor(selectedColorNumber)

        AddHandler color1Button.Click, AddressOf whenClicked
        AddHandler color2Button.Click, AddressOf whenClicked
        AddHandler color3Button.Click, AddressOf whenClicked
        AddHandler color4Button.Click, AddressOf whenClicked
        AddHandler color5Button.Click, AddressOf whenClicked
        AddHandler color6Button.Click, AddressOf whenClicked
    End Sub

#Region "Couleurs"

    ''' <summary>
    ''' Obtient la couleur sélectionnée
    ''' </summary>
    Public selectedColorNumber As Integer

    ''' <summary>
    ''' Obtient le bouton de couleur sélectionnée
    ''' </summary>
    Private selectedColorButton As Button

    Private color1 As Color
    Private color2 As Color
    Private color3 As Color
    Private color4 As Color
    Private color5 As Color
    Private color6 As Color

    ''' <summary>
    ''' Quand un bouton de couleur est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub colorClicked(sender As Button, e As EventArgs) Handles color1Button.Click, color2Button.Click, color3Button.Click, color4Button.Click, color5Button.Click, color6Button.Click
        Me.selectedColorNumber = getColorNumber(sender)
        selectColor(sender)
    End Sub

    ''' <summary>
    ''' Sélectionne une couleur
    ''' </summary>
    ''' <param name="colorButton">Le bouton de couleur à sélectionner</param>
    Private Sub selectColor(colorButton As Button)
        Me.selectedColorNumber = getColorNumber(colorButton)
        If selectedColorButton IsNot Nothing Then
            selectedColorButton.BackgroundImage = Nothing
        End If
        selectedColorButton = colorButton
        selectedColorButton.BackgroundImage = My.Resources.selectedColor
    End Sub

    ''' <summary>
    ''' Sélectionne une couleur
    ''' </summary>
    ''' <param name="selectedColor"></param>
    Private Sub selectColor(selectedColor As Integer)
        If selectedColor = 1 Then
            Me.selectedColorNumber = 1
            selectColor(color1Button)
        ElseIf selectedColor = 2 Then
            Me.selectedColorNumber = 2
            selectColor(color2Button)
        ElseIf selectedColor = 3 Then
            Me.selectedColorNumber = 3
            selectColor(color3Button)
        ElseIf selectedColor = 4 Then
            Me.selectedColorNumber = 4
            selectColor(color4Button)
        ElseIf selectedColor = 5 Then
            Me.selectedColorNumber = 5
            selectColor(color5Button)
        ElseIf selectedColor = 6 Then
            Me.selectedColorNumber = 6
            selectColor(color6Button)
        Else
            selectColor(1)
        End If
    End Sub

    ''' <summary>
    ''' Obtient le numéro de la couleur
    ''' </summary>
    ''' <param name="colorButton"></param>
    ''' <returns></returns>
    Private Function getColorNumber(colorButton As Button) As Integer
        If colorButton Is color1Button Then
            Return 1
        ElseIf colorButton Is color2Button Then
            Return 2
        ElseIf colorButton Is color3Button Then
            Return 3
        ElseIf colorButton Is color4Button Then
            Return 4
        ElseIf colorButton Is color5Button Then
            Return 5
        ElseIf colorButton Is color6Button Then
            Return 6
        Else
            Return getColorNumber(color1Button)
        End If
    End Function

#End Region

#Region "Initialisation de l'évènement Click"

    ''' <summary>
    ''' Redéclare l'évènement Me.Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event SelectedColorChanged(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand la fenètre ou un des ses boutons de couleurs est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenClicked(sender As Object, e As EventArgs)
        RaiseEvent SelectedColorChanged(Me, e)
    End Sub

#End Region

End Class
