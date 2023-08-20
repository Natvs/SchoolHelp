''' <summary>
''' Contient des données sur les fonctions
''' </summary>
Public Structure options

    ''' <summary>
    ''' Crée les répertoires
    ''' </summary>
    Shared Sub createDirectorys()
        IO.Directory.CreateDirectory("files")
        IO.Directory.CreateDirectory("files/marks")
        IO.Directory.CreateDirectory("files/lists")
    End Sub

    ''' <summary>
    ''' Contient des données sur l'applications "Notes"
    ''' </summary>
    Structure marks

        ''' <summary>
        ''' Obtient le titre de l'application
        ''' </summary>
        Shared ReadOnly title As String = "Notes"

        ''' <summary>
        ''' Obtient la description de l'application
        ''' </summary>
        Shared ReadOnly description As String = "Application pour gérer les notes."

        ''' <summary>
        ''' Obtient le texte d'ouverture de l'application
        ''' </summary>
        Shared ReadOnly launchText As String = "Ouvrir les notes"

    End Structure

    ''' <summary>
    ''' Contient des données sur l'application "Listes"
    ''' </summary>
    Structure lists

        ''' <summary>
        ''' Obtient le titre de l'application
        ''' </summary>
        Shared ReadOnly title As String = "Listes"

        ''' <summary>
        ''' Obtient la descriiption de l'application
        ''' </summary>
        Shared ReadOnly descritpion As String = "Application pour gérer les listes."

        ''' <summary>
        ''' Obtient le texte d'ouverture de l'application
        ''' </summary>
        Shared ReadOnly launchText As String = "Ouvrir les listes"

    End Structure

End Structure