''' <summary>
''' Fournit des données sur l'application des listes
''' </summary>
Structure ListsApp

    ''' <summary>
    ''' Sauvegarde une collection
    ''' </summary>
    ''' <param name="listsList">La liste contenant les listes</param>
    ''' <param name="collectionsList">La liste contenant les collections</param>
    ''' <param name="base">La base du chemin dans lequel sauvegarder les fichiers</param>
    Shared Sub SaveAll(listsList As List(Of ListBox), collectionsList As List(Of ListsCollectionBox), base As String)
        ListsApp.lists.savelists(listsList, base)
        ListsApp.collections.saveCollections(collectionsList, base)
    End Sub

    ''' <summary>
    ''' Charge une collection
    ''' </summary>
    ''' <param name="listsList">La liste contenant les listes</param>
    ''' <param name="collectionsList">La liste contenant les collections</param>
    ''' <param name="base">La base du chemin dans lequel sauvegarder les fichiers</param>
    Shared Sub LoadAll(listsList As List(Of ListBox), collectionsList As List(Of ListsCollectionBox), base As String, parent As ListsForm)
        ListsApp.lists.loadlists(listsList, base, parent)
        ListsApp.collections.loadCollections(collectionsList, base, parent)
    End Sub

#Region "Lists"

    ''' <summary>
    ''' Fournit des données sur les listes
    ''' </summary>
    Structure Lists

        ''' <summary>
        ''' Fournit des données sur les couleurs des listes
        ''' </summary>
        Structure Colors
            Shared ReadOnly defaultColor1 As Color = Color.White
            Shared ReadOnly defaultColor2 As Color = Color.Black
            Shared ReadOnly defaultColor3 As Color = Color.Blue
            Shared ReadOnly defaultColor4 As Color = Color.Red
            Shared ReadOnly defaultColor5 As Color = Color.Yellow
            Shared ReadOnly defaultColor6 As Color = Color.Green

            Shared ReadOnly goodColor As Color = Color.Green
            Shared ReadOnly badColor As Color = Color.Red

            ''' <summary>
            ''' Obtient une couleur à partir du numéro de cette couleur
            ''' </summary>
            ''' <param name="colorNumber">Le numéro de la couleur</param>
            ''' <returns>La couleur correspondant au numéro</returns>
            Shared Function GetColor(colorNumber As Integer) As Color
                Dim colorsList As New List(Of Color)
                colorsList.Add(defaultColor1)
                colorsList.Add(defaultColor2)
                colorsList.Add(defaultColor3)
                colorsList.Add(defaultColor4)
                colorsList.Add(defaultColor5)
                colorsList.Add(defaultColor6)
                If colorNumber = Nothing Or colorNumber = 0 Then
                    colorNumber = 1
                End If
                Return colorsList.Item(colorNumber - 1)
            End Function
        End Structure

        ''' <summary>
        ''' Obtient le nombre d'instance de listes à charger ou à suvegarder pour afficher le formulaire de progression
        ''' </summary>
        Shared ReadOnly showProgressionNumber As Integer = 100

        ''' <summary>
        ''' Sauve les listes dans leur fichier
        ''' </summary>
        ''' <param name="lists">La liste de listes à sauvegarder</param>
        ''' <param name="base">La base du chemin où sauvegarder les listes</param>
        Shared Sub Savelists(lists As List(Of ListBox), base As String)
            Using file = FileIO.FileSystem.OpenTextFileWriter(base + "/listsNumber", False)
                file.WriteLine(lists.Count)
            End Using
            If lists.Count > 0 Then

                Using savingProgression As New ProgressionDialog
                    Dim showProgression As Boolean = False
                    If lists.Count >= showProgressionNumber Then
                        showProgression = True
                        savingProgression.ShowProgress("Sauvegarde des listes", "Sauvegarde des listes en cours...", lists.Count, 0)
                    End If
                    Dim path As String
                    For i = 1 To lists.Count
                        path = base + "/list" + i.ToString
                        lists.Item(i - 1).Save(path)
                        If showProgression = True Then
                            savingProgression.IncreaseProgression()
                        End If
                    Next
                    If showProgression = True Then
                        savingProgression.Close()
                    End If
                End Using
            End If
        End Sub

        ''' <summary>
        ''' Charge les listes depuis leur fichier
        ''' </summary>
        ''' <param name="lists">La liste de listes à charger</param>
        ''' <param name="base">La base du chemin d'où chager les listes</param>
        ''' <param name="parent">Le formulaire de listes parent de ces listes</param>
        Shared Sub Loadlists(lists As List(Of ListBox), base As String, parent As ListsForm)
            If FileIO.FileSystem.FileExists(base + "/listsNumber") Then
                Dim number As Integer
                Using file = FileIO.FileSystem.OpenTextFileReader(base + "/listsNumber")
                    number = file.ReadLine
                End Using
                If number > 0 Then
                    Using savingProgression As New ProgressionDialog
                        Dim showProgression As Boolean = False
                        If number >= showProgressionNumber Then
                            showProgression = True
                            savingProgression.ShowProgress("Sauvergarde des listes", "Sauvegarde des listes en cours...", number, 0)
                        End If
                        Dim path As String
                        For i = 1 To number
                            path = base + "/list" + i.ToString
                            Dim newlistBox As New ListBox
                            newlistBox.Load(path, parent)
                            lists.Add(newlistBox)
                            If showProgression = True Then
                                savingProgression.IncreaseProgression()
                            End If
                        Next
                        If showProgression = True Then
                            savingProgression.Close()
                        End If
                    End Using
                End If
            End If
        End Sub

    End Structure

#End Region

#Region "Collections"

    ''' <summary>
    ''' Fournit des données pour les collections de notes
    ''' </summary>
    Structure Collections

        ''' <summary>
        ''' Fournit des données sur les couleurs des collections de notes
        ''' </summary>
        Structure Colors

            Shared ReadOnly color1 As Color = Color.White
            Shared ReadOnly color2 As Color = Color.Black
            Shared ReadOnly color3 As Color = Color.Blue
            Shared ReadOnly color4 As Color = Color.Red
            Shared ReadOnly color5 As Color = Color.Yellow
            Shared ReadOnly color6 As Color = Color.Green

            ''' <summary>
            ''' Obtient une couleur à partir du numéro de cette couleur
            ''' </summary>
            ''' <param name="colorNumber">Le numéro de la couleur</param>
            ''' <returns>La couleur correspondant au numéro</returns>
            Shared Function GetColor(colorNumber As Integer) As Color
                Dim colorsList As New List(Of Color)
                colorsList.Add(color1)
                colorsList.Add(color2)
                colorsList.Add(color3)
                colorsList.Add(color4)
                colorsList.Add(color5)
                colorsList.Add(color6)
                If colorNumber = Nothing Or colorNumber = 0 Then
                    colorNumber = 1
                End If
                Return colorsList.Item(colorNumber - 1)
            End Function
        End Structure

        ''' <summary>
        ''' Obtient le nombre d'instances de collections à charger ou à sauvegarder pour afficher le formulaire de progression
        ''' </summary>
        Shared ReadOnly showProgressionNumber As Integer = 100

        ''' <summary>
        ''' Sauve les collections dans leur fichier
        ''' </summary>
        ''' <param name="collections">La liste de collections à sauvegarder</param>
        ''' <param name="base">La base du chemin où sauvegarder les collections</param>
        Shared Sub SaveCollections(collections As List(Of ListsCollectionBox), base As String)
            Using file = FileIO.FileSystem.OpenTextFileWriter(base + "/collectionsNumber", False)
                file.WriteLine(collections.Count)
            End Using
            If collections.Count > 0 Then
                Using savingProgression As New ProgressionDialog
                    Dim showProgression As Boolean = False
                    If collections.Count >= showProgressionNumber Then
                        showProgression = True
                        savingProgression.ShowProgress("Sauvegarde des collections", "Sauvegarde des collections en cours...", collections.Count, 0)
                    End If
                    Dim path As String
                    For i = 1 To collections.Count
                        path = base + "/collection" + i.ToString
                        collections.Item(i - 1).save(path)
                        If showProgression = True Then
                            savingProgression.IncreaseProgression()
                        End If
                    Next
                    If showProgression = True Then
                        savingProgression.Close()
                    End If
                End Using
            End If
        End Sub

        ''' <summary>
        ''' Charge les collections depuis leur fichier
        ''' </summary>
        ''' <param name="collections">La liste de collections à charger</param>
        ''' <param name="base">La base du chemin d'où chager les collections</param>
        ''' <param name="parent">Le formulaire de listes parent de ces collections</param>
        Shared Sub LoadCollections(collections As List(Of ListsCollectionBox), base As String, parent As ListsForm)
            If FileIO.FileSystem.FileExists(base + "/collectionsNumber") Then
                Dim number As Integer
                Using file = FileIO.FileSystem.OpenTextFileReader(base + "/collectionsNumber")
                    number = file.ReadLine
                End Using
                If number > 0 Then
                    Dim newCollectionBox As New ListsCollectionBox
                    Using loadingProgression As New ProgressionDialog
                        Dim showProgression As Boolean = False
                        If number >= showProgressionNumber Then
                            showProgression = True
                            loadingProgression.ShowProgress("Chargement des collections", "Chargement des collections en cours", number, 0)
                        End If
                        For i = 1 To number
                            collections.Add(New ListsCollectionBox)
                            collections.Item(i - 1).load(base + "/collection" + i.ToString, parent)
                            If showProgression = True Then
                                loadingProgression.IncreaseProgression()
                            End If
                        Next
                        If showProgression = True Then
                            loadingProgression.Close()
                        End If
                    End Using
                End If
            End If
        End Sub

        ''' <summary>
        ''' Obtient le chemin de la collection spécifiée
        ''' </summary>
        ''' <param name="collections">La liste de collections</param>
        ''' <returns>Le chemin de la collection</returns>
        Shared Function GetPath(collections As List(Of ListsCollectionBox)) As String
            Dim path As String = "files/lists"
            If collections.Count > 0 Then
                For i = 1 To collections.Count
                    path = path + "/" + collections.Item(i - 1).collectionName
                Next
            End If
            Return path
        End Function

        ''' <summary>
        ''' Obtient la collection actuelle
        ''' </summary>
        ''' <param name="collections">La liste de collections</param>
        ''' <returns>La collection actuelle</returns>
        Shared Function GetCurrentCollection(collections As List(Of ListsCollectionBox))
            Dim collection As ListsCollectionBox
            If collections.Count > 0 Then
                collection = collections.Item(collections.Count - 1)
            Else
                collection = Nothing
            End If
            Return collection
        End Function

    End Structure

#End Region

End Structure