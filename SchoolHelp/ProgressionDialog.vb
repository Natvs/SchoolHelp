''' <summary>
''' Formulaire pour afficher la progression d'une action
''' </summary>
Public Class ProgressionDialog

    ''' <summary>
    ''' Obtient les différents résultats de progression
    ''' </summary>
    Public Enum ProgressionResult
        ''' <summary>
        ''' Spécifie que la progression est complète
        ''' </summary>
        complete
        ''' <summary>
        ''' Spécifie que la progression est incomplète
        ''' </summary>
        incomplete
    End Enum

    ''' <summary>
    ''' Obtient la valeur maximale que peut contenir la barre de progression
    ''' </summary>
    Private maxValue As Integer

    ''' <summary>
    ''' Affiche le formulaire
    ''' </summary>
    ''' <param name="title">Le titre du formulaire</param>
    ''' <param name="message">Le message à afficher</param>
    ''' <param name="totalSteps">Le nombre total d'étapes du chargement</param>
    ''' <param name="currentStep">L'étape actuelle du chargement</param>
    Public Function ShowProgress(title As String, message As String, totalSteps As Integer, currentStep As Integer) As ProgressionResult
        Me.maxValue = totalSteps

        Text = title
        ProgressionLabel.Text = message
        ProgressionBar.Maximum = totalSteps
        ProgressionBar.Value = currentStep

        Me.TopMost = True
        Me.Show()
        Me.Refresh()
        Return GetProgressionResult()
    End Function

    ''' <summary>
    ''' Obtient le résultat de la progression du dialogue
    ''' </summary>
    ''' <returns></returns>
    Public Function GetProgressionResult() As ProgressionResult
        If ProgressionBar.Value = Me.maxValue Then
            Return ProgressionResult.complete
        End If
        Return ProgressionResult.incomplete
    End Function

    ''' <summary>
    ''' Augmente la progression du nombre d'étapes spécifiés
    ''' </summary>
    ''' <param name="stepToIncrement">Le nombre d'étapes à ajouter</param>
    Public Function IncreaseProgression(stepToIncrement As Integer) As ProgressionResult
        ProgressionBar.Value = ProgressionBar.Value + stepToIncrement
        Me.Refresh()
        Return GetProgressionResult()
    End Function

    ''' <summary>
    ''' Augmente la progression d'une étape
    ''' </summary>
    Public Function IncreaseProgression() As ProgressionResult
        Return IncreaseProgression(1)
    End Function

    ''' <summary>
    ''' Affiche un nouveau message de progression
    ''' </summary>
    ''' <param name="newMessage">Le nouveau message de progression</param>
    Public Sub SetNewMessage(newMessage As String)
        ProgressionLabel.Text = newMessage
        Me.Refresh()
    End Sub

End Class