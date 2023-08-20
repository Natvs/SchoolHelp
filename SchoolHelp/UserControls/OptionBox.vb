''' <summary>
''' Contrôle affichant une option à l'utilisateur
''' </summary>
Public Class OptionBox

    ''' <summary>
    ''' Représente l'action de l'instance OptionBox
    ''' </summary>
    Public action As Integer

    ''' <summary>
    ''' Initialise l'instance OptionBox
    ''' </summary>
    ''' <param name="title">Le titre de l'option</param>
    ''' <param name="description"></param>
    ''' <param name="launchText"></param>
    Public Sub initialize(title As String, description As String, launchText As String)
        titleLabel.Text = title
        descriptionLabel.Text = description
        launchButton.Text = launchText
        Me.action = action
    End Sub

#Region "Evènement LaunchApp"

    ''' <summary>
    ''' Se produit quand le bouton pour lancer l'application est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event LaunchApp(sender As OptionBox, e As EventArgs)

    ''' <summary>
    ''' Quand le bouton pour lancer l'application est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenLaunched(sender As Button, e As EventArgs) Handles launchButton.Click
        RaiseEvent LaunchApp(Me, e)
    End Sub

#End Region

#Region "Evènement OpenOptions"

    ''' <summary>
    ''' Se produit quand le bouton pour ouvrir les options est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event OpenOptions(sender As OptionBox, e As EventArgs)

    ''' <summary>
    ''' Quand le bouton pour ouvrir les options est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenOptionsOpened(sender As Button, e As EventArgs) Handles optionsButton.Click
        RaiseEvent OpenOptions(Me, e)
    End Sub

#End Region

End Class
