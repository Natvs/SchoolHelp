Public Class OptionsForm

#Region "Options"

    ''' <summary>
    ''' Instance OptionBox pour les notes
    ''' </summary>
    Private WithEvents marksOptionBox As New SchoolHelp.OptionBox

    ''' <summary>
    ''' Instance OptionBox pour les listes
    ''' </summary>
    Private WithEvents listsOptionBox As New SchoolHelp.OptionBox

    ''' <summary>
    ''' Initialise les options
    ''' </summary>
    Private Sub initializeOptions()
        marksOptionBox.initialize(options.marks.title, options.marks.description, options.marks.launchText)
        optionsPanel.Controls.Add(marksOptionBox)

        listsOptionBox.initialize(options.lists.title, options.lists.descritpion, options.lists.launchText)
        optionsPanel.Controls.Add(listsOptionBox)
    End Sub

    ''' <summary>
    ''' Quand un bouton pour lancer une application est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub launchApp(sender As OptionBox, e As EventArgs) Handles marksOptionBox.LaunchApp, listsOptionBox.LaunchApp
        If sender Is marksOptionBox Then
            Using marksDialog As New MarksForm
                marksDialog.ShowDialog()
            End Using
        ElseIf sender Is listsOptionBox Then
            Using listsDialog As New ListsForm
                listsDialog.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub openOptions(sender As OptionBox, e As EventArgs) Handles marksOptionBox.OpenOptions, listsOptionBox.OpenOptions
        If sender Is marksOptionBox Then
            Using optionsForm As New MarksOptionsDialog
                optionsForm.ShowOptions()
            End Using
        End If
    End Sub

#End Region

    ''' <summary>
    ''' Quand l'application SchoolHelp s'ouvre
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub opening(sender As OptionsForm, e As EventArgs) Handles Me.Load
        initializeOptions()
        options.createDirectorys()
    End Sub

End Class
