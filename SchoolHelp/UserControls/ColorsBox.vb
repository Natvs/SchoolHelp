Public Class ColorsBox

    ''' <summary>
    ''' Obtient la couleur sélectionnée
    ''' </summary>
    Public selectedColor As Color

    Private color1 As Color
    Private color2 As Color
    Private color3 As Color
    Private color4 As Color
    Private color5 As Color
    Private color6 As Color

    ''' <summary>
    ''' Initialise cette instance de ColorsBox
    ''' </summary>
    ''' <param name="text">Le texte à afficher au-dessus des couleurs</param>
    ''' <param name="colorsList">La liste de couleurs</param>
    Public Sub initialize(text As String, colorsList As List(Of Color))
        colorsLabel.Text = text

        color1 = colorsList.Item(0)
        color2 = colorsList.Item(1)
        color3 = colorsList.Item(2)
        color4 = colorsList.Item(3)
        color5 = colorsList.Item(4)
        color6 = colorsList.Item(5)

        color1Button.BackColor = color1
        color2Button.BackColor = color2
        color3Button.BackColor = color3
        color4Button.BackColor = color4
        color5Button.BackColor = color5
        color6Button.BackColor = color6

        selectedColor = color1

        AddHandler color1Button.Click, AddressOf whenClicked
        AddHandler color2Button.Click, AddressOf whenClicked
        AddHandler color3Button.Click, AddressOf whenClicked
        AddHandler color4Button.Click, AddressOf whenClicked
        AddHandler color5Button.Click, AddressOf whenClicked
        AddHandler color6Button.Click, AddressOf whenClicked
    End Sub

    Private Sub colorClicked(sender As Button, e As EventArgs) Handles color1Button.Click, color2Button.Click, color3Button.Click, color4Button.Click, color5Button.Click, color6Button.Click
        selectedColor = sender.BackColor
    End Sub

    ''' <summary>
    ''' Redéclare l'évènement Me.Click
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Shadows Event Click(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand la fenètre ou un des ses boutons de couleurs est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenClicked(sender As Object, e As EventArgs)
        RaiseEvent Click(Me, e)
    End Sub

End Class
