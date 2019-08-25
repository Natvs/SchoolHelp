''' <summary>
''' Boite de dialogue qui indique à l'utilisateur la progression d'une action
''' </summary>
Public Class ProgressionDialog

    ''' <summary>
    ''' Affiche la boite de dialogue
    ''' </summary>
    ''' <param name="text">Le texte de progression à afficher</param>
    ''' <param name="value">La valeur de la barre de progression</param>
    ''' <param name="maxValue">La valeur maximale de la barre de progression</param>
    Public Overloads Sub Show(text As String, value As Integer, maxValue As Integer)
        progressionLabel.Text = text
        progressionBar.Maximum = maxValue
        progressionBar.Value = value

        'Show()
        Refresh()
    End Sub

    ''' <summary>
    ''' Augmente la valeur de la barre de progression
    ''' </summary>
    ''' <param name="value">La valeur à ajouter à la barre de progression</param>
    Public Sub increment(value As Integer)
        progressionBar.Value = progressionBar.Value + value
        Refresh()
    End Sub

End Class