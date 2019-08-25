Public Class StartingForm

#Region "Options"

    ''' <summary>
    ''' Instance OptionBox pour les notes
    ''' </summary>
    Private WithEvents marksOptionBox As New SchoolHelp.OptionBox

    Private WithEvents colorsBox As New SchoolHelp.ColorsBox

    ''' <summary>
    ''' Initialise les options
    ''' </summary>
    Private Sub initializeOptions()
        marksOptionBox.initialize("Notes", "Permet d'ajouter des notes ou de modifier des notes déjà existantes.", "Ouvrir les notes", actions.actions.marks)
        Dim colorList As New List(Of Color)
        colorList.Add(Color.Black)
        colorList.Add(Color.White)
        colorList.Add(Color.Blue)
        colorList.Add(Color.Red)
        colorList.Add(Color.Yellow)
        colorList.Add(Color.Green)
        colorsBox.initialize("Couleur d'arrière-plan", colorList)
        optionsPanel.Controls.Add(marksOptionBox)
        optionsPanel.Controls.Add(colorsBox)
    End Sub

#End Region

    Private Sub opening(sender As Form, e As EventArgs) Handles MyBase.Load
        initializeOptions()
        actions.createDirectorys()
    End Sub

End Class
