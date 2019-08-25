Public Structure actions

    ''' <summary>
    ''' Contient les ID des fonctions
    ''' </summary>
    Public Enum actions
        marks
    End Enum

    ''' <summary>
    ''' Lance une fonction
    ''' </summary>
    ''' <param name="action">L'ID de la fonction à lancer</param>
    Shared Sub launchFunction(action As actions)
        If action = actions.marks Then
            Using marksDialog As New MarksForm
                marksDialog.ShowDialog()
            End Using
        End If
    End Sub

    ''' <summary>
    ''' Crée les répertoires
    ''' </summary>
    Shared Sub createDirectorys()
        IO.Directory.CreateDirectory("files")
        IO.Directory.CreateDirectory("files/marks")
    End Sub

End Structure