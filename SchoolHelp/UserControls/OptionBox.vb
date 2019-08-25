''' <summary>
''' Contrôle affichant une option à l'utilisateur
''' </summary>
Public Class OptionBox

    ''' <summary>
    ''' Déclare une nouvelle instance de OptionBox
    ''' </summary>
    Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

    End Sub

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
    ''' <param name="action">L'action à exécuter lorsque le bouton pour lancer la fonction est cliqué</param>
    Public Sub initialize(title As String, description As String, launchText As String, action As actions.actions)
        titleLabel.Text = title
        descriptionLabel.Text = description
        launchButton.Text = launchText
        Me.action = action
    End Sub

    ''' <summary>
    ''' Quand le bouton pour lancer la fonction est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub launch(sender As Object, e As EventArgs) Handles launchButton.Click
        actions.launchFunction(action)
    End Sub

End Class
