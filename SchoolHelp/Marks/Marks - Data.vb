''' <summary>
''' Fournit des données pour l'applcation des notes
''' </summary>
Structure marksApp

    ''' <summary>
    ''' Sauvegarde une collection
    ''' </summary>
    ''' <param name="marksList"></param>
    ''' <param name="collectionsList"></param>
    ''' <param name="base"></param>
    Shared Sub saveAll(marksList As List(Of MarkBox), collectionsList As List(Of MarksCollectionBox), base As String)
        Using WaitingDialog As New ProgressionDialog
            WaitingDialog.ShowProgress("Sauvegarde", "Sauvegarde des données des notes...", 2, 0)
            marksApp.marks.saveMarks(marksList, base)
            WaitingDialog.IncreaseProgression()
            marksApp.collections.saveCollections(collectionsList, base)
            WaitingDialog.IncreaseProgression()
        End Using
    End Sub

    ''' <summary>
    ''' Charge une collection
    ''' </summary>
    ''' <param name="marks"></param>
    ''' <param name="collections"></param>
    ''' <param name="base"></param>
    ''' <param name="parent"></param>
    Shared Sub loadAll(marks As List(Of MarkBox), collections As List(Of MarksCollectionBox), base As String, parent As MarksForm)
        Using WaitingDialog As New ProgressionDialog
            WaitingDialog.ShowProgress("Chargement", "Chargement des données des notes...", 2, 0)
            marksApp.marks.loadMarks(marks, base, parent)
            WaitingDialog.IncreaseProgression()
            marksApp.collections.loadCollections(collections, base, parent)
            WaitingDialog.IncreaseProgression()
        End Using
    End Sub

#Region "Marks"

    ''' <summary>
    ''' Fournit des données pour les notes
    ''' </summary>
    Structure marks

        ''' <summary>
        ''' Fournit des données sur les couleurs des notes
        ''' </summary>
        Structure colors
            Shared ReadOnly file As String = "files/marks/marksColorsFile"

            Shared ReadOnly defaultColor1 As Color = Color.White
            Shared ReadOnly defaultColor2 As Color = Color.Black
            Shared ReadOnly defaultColor3 As Color = Color.Red
            Shared ReadOnly defaultColor4 As Color = Color.Yellow
            Shared ReadOnly defaultColor5 As Color = Color.Blue
            Shared ReadOnly defaultColor6 As Color = Color.Green

            ''' <summary>
            ''' Obtient la liste contenant les couleurs par défaut
            ''' </summary>
            ''' <returns>La liste contenant les couleurs</returns>
            Shared Function getColorList() As List(Of Color)
                Dim colorList As New List(Of Color)
                colorList.Add(defaultColor1)
                colorList.Add(defaultColor2)
                colorList.Add(defaultColor3)
                colorList.Add(defaultColor4)
                colorList.Add(defaultColor5)
                colorList.Add(defaultColor6)
                Return colorList
            End Function

            'Numéros des couleurs

            Shared ReadOnly defaultColor1Number As New values.NumericColor(1)
            Shared ReadOnly defaultColor2Number As New values.NumericColor(2)
            Shared ReadOnly defaultColor3Number As New values.NumericColor(3)
            Shared ReadOnly defaultColor4Number As New values.NumericColor(4)
            Shared ReadOnly defaultColor5Number As New values.NumericColor(5)
            Shared ReadOnly defaultColor6Number As New values.NumericColor(6)

            Shared currentColor1Number As New values.NumericColor(defaultColor1Number)
            Shared currentColor2Number As New values.NumericColor(defaultColor2Number)
            Shared currentColor3Number As New values.NumericColor(defaultColor3Number)
            Shared currentColor4Number As New values.NumericColor(defaultColor4Number)
            Shared currentColor5Number As New values.NumericColor(defaultColor5Number)
            Shared currentColor6Number As New values.NumericColor(defaultColor6Number)

            ''' <summary>
            ''' Obtient la liste contenant les numéros actuels des couleurs
            ''' </summary>
            ''' <returns>La liste contenant les numéros des couleurs</returns>
            Shared Function getColorsNumberList() As List(Of values.NumericColor)
                Dim colorsNumberlist As New List(Of values.NumericColor)
                colorsNumberlist.Add(currentColor1Number)
                colorsNumberlist.Add(currentColor2Number)
                colorsNumberlist.Add(currentColor3Number)
                colorsNumberlist.Add(currentColor4Number)
                colorsNumberlist.Add(currentColor5Number)
                colorsNumberlist.Add(currentColor6Number)
                Return colorsNumberlist
            End Function

            'Intervalles des couleurs

            Shared ReadOnly defaultColor1Interval As New values.Interval(0, True, 5, False)
            Shared ReadOnly defaultColor2Interval As New values.Interval(5, True, 10, False)
            Shared ReadOnly defaultColor3Interval As New values.Interval(10, True, 12.5, False)
            Shared ReadOnly defaultColor4Interval As New values.Interval(12.5, True, 15, False)
            Shared ReadOnly defaultColor5Interval As New values.Interval(15, True, 17.5, False)
            Shared ReadOnly defaultColor6Interval As New values.Interval(17.5, True, 20, True)

            Shared color1Interval As New values.Interval(defaultColor1Interval)
            Shared color2Interval As New values.Interval(defaultColor2Interval)
            Shared color3Interval As New values.Interval(defaultColor3Interval)
            Shared color4Interval As New values.Interval(defaultColor4Interval)
            Shared color5Interval As New values.Interval(defaultColor5Interval)
            Shared color6Interval As New values.Interval(defaultColor6Interval)

            ''' <summary>
            ''' Obtient la couleur à attribuer en fonction de la note
            ''' </summary>
            ''' <param name="mark">La note qui définit la couleur à attribuer</param>
            ''' <returns>La couleur en fonction de la note</returns>
            Shared Function getAutoColor(mark As Decimal) As Color
                If color1Interval.isValueHeld(mark) Then
                    Return getColor(currentColor1Number.getNumber())
                ElseIf color2Interval.isValueHeld(mark) Then
                    Return getColor(currentColor2Number.getNumber())
                ElseIf color3Interval.isValueHeld(mark) Then
                    Return getColor(currentColor3Number.getNumber())
                ElseIf color4Interval.isValueHeld(mark) Then
                    Return getColor(currentColor4Number.getNumber())
                ElseIf color5Interval.isValueHeld(mark) Then
                    Return getColor(currentColor5Number.getNumber())
                ElseIf color6Interval.isValueHeld(mark) Then
                    Return getColor(currentColor6Number.getNumber())
                Else
                    Return defaultColor1
                End If
            End Function

            'Fonctions des couleurs

            ''' <summary>
            ''' Obtient une couleur à partir du numéro de cette couleur
            ''' </summary>
            ''' <param name="colorNumber">Le numéro de la couleur</param>
            ''' <returns>La couleur correspondant au numéro</returns>
            Shared Function getColor(colorNumber As Integer) As Color
                Dim colorsList As List(Of Color) = marksApp.marks.colors.getColorList()
                If colorNumber = Nothing Or colorNumber = 0 Then
                    colorNumber = 1
                End If
                Return colorsList.Item(colorNumber - 1)
            End Function

            ''' <summary>
            ''' Obtient le numéro de la couleur spécifiée
            ''' </summary>
            ''' <param name="color">La couleur</param>
            ''' <returns>Le numéro de la couleur spécifié</returns>
            Shared Function getColorNumber(color As Color) As Integer
                Dim colorsList As List(Of Color) = marksApp.marks.colors.getColorList()
                If colorsList.Contains(color) Then
                    Return colorsList.IndexOf(color)
                Else
                    Return 1
                End If
            End Function

            ''' <summary>
            ''' Sauvegarde les intervalles et les couleurs des notes
            ''' </summary>
            Shared Sub Save()
                Using savingFile = FileIO.FileSystem.OpenTextFileWriter(file, False)
                    savingFile.WriteLine(color1Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor1Number.getNumber.ToString)
                    savingFile.WriteLine(color2Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor2Number.getNumber.ToString)
                    savingFile.WriteLine(color3Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor3Number.getNumber.ToString)
                    savingFile.WriteLine(color4Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor4Number.getNumber.ToString)
                    savingFile.WriteLine(color5Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor5Number.getNumber.ToString)
                    savingFile.WriteLine(color6Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor6Number.getNumber.ToString)
                End Using
            End Sub

            ''' <summary>
            ''' Charge les intervalles et les couleurs des notes
            ''' </summary>
            Shared Sub Load()
                If values.file.Exists(file) Then
                    Using loadingFile = FileIO.FileSystem.OpenTextFileReader(file)
                        color1Interval.setInterval(loadingFile.ReadLine)
                        currentColor1Number.setNumber(loadingFile.ReadLine)
                        color2Interval.setInterval(loadingFile.ReadLine)
                        currentColor2Number.setNumber(loadingFile.ReadLine)
                        color3Interval.setInterval(loadingFile.ReadLine)
                        currentColor3Number.setNumber(loadingFile.ReadLine)
                        color4Interval.setInterval(loadingFile.ReadLine)
                        currentColor4Number.setNumber(loadingFile.ReadLine)
                        color5Interval.setInterval(loadingFile.ReadLine)
                        currentColor5Number.setNumber(loadingFile.ReadLine)
                        color6Interval.setInterval(loadingFile.ReadLine)
                        currentColor6Number.setNumber(loadingFile.ReadLine)
                    End Using
                End If
            End Sub

        End Structure

        ''' <summary>
        ''' Obtient le nombre d'instances de notes à charger ou à sauvegarder pour afficher le formulaire de progression
        ''' </summary>
        Shared ReadOnly showProgressionNumber As Integer = 100

        ''' <summary>
        ''' Sauve les notes dans leur fichier
        ''' </summary>
        ''' <param name="marks">La liste de notes à sauvegarder</param>
        ''' <param name="base">La base du chemin où sauvegarder les notes</param>
        Shared Sub saveMarks(marks As List(Of MarkBox), base As String)
            Using file = FileIO.FileSystem.OpenTextFileWriter(base + "/marksNumber", False)
                file.WriteLine(marks.Count)
            End Using
            If marks.Count > 0 Then

                Using savingProgression As New ProgressionDialog
                    Dim showProgression As Boolean = False
                    If marks.Count >= showProgressionNumber Then
                        showProgression = True
                        savingProgression.ShowProgress("Sauvegarde des notes", "Sauvegarde des notes en cours...", marks.Count, 0)
                    End If
                    Dim path As String
                    For i = 1 To marks.Count
                        path = base + "/mark" + i.ToString
                        marks.Item(i - 1).save(path)
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
        ''' Charge les notes depuis leur fichier
        ''' </summary>
        ''' <param name="marks">La liste de notes à charger</param>
        ''' <param name="base">La base du chemin d'où chager les notes</param>
        ''' <param name="parent">Le formulaire de notes parent de ces notes</param>
        Shared Sub loadMarks(marks As List(Of MarkBox), base As String, parent As MarksForm)
            If FileIO.FileSystem.FileExists(base + "/marksNumber") Then
                Dim number As Integer
                Using file = FileIO.FileSystem.OpenTextFileReader(base + "/marksNumber")
                    number = file.ReadLine
                End Using
                If number > 0 Then
                    Using savingProgression As New ProgressionDialog
                        Dim showProgression As Boolean = False
                        If number >= showProgressionNumber Then
                            showProgression = True
                            savingProgression.ShowProgress("Sauvergarde des notes", "Sauvegarde des notes en cours...", number, 0)
                        End If
                        Dim path As String
                        For i = 1 To number
                            path = base + "/mark" + i.ToString
                            Dim newMarkBox As New MarkBox
                            newMarkBox.load(path, parent)
                            marks.Add(newMarkBox)
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
    Structure collections

        ''' <summary>
        ''' Fournit des données sur les couleurs des collections de notes
        ''' </summary>
        Structure colors
            Shared file As String = "files/marks/collectionsColorsFile"

            Shared ReadOnly color1 As Color = Color.White
            Shared ReadOnly color2 As Color = Color.Black
            Shared ReadOnly color3 As Color = Color.Red
            Shared ReadOnly color4 As Color = Color.Yellow
            Shared ReadOnly color5 As Color = Color.Blue
            Shared ReadOnly color6 As Color = Color.Green

            ''' <summary>
            ''' Obtient la liste contenant les couleurs
            ''' </summary>
            ''' <returns>La liste contenant les couleurs</returns>
            Shared Function getColorList() As List(Of Color)
                Dim colorList As New List(Of Color)
                colorList.Add(color1)
                colorList.Add(color2)
                colorList.Add(color3)
                colorList.Add(color4)
                colorList.Add(color5)
                colorList.Add(color6)
                Return colorList
            End Function

            'Numéros des couleurs

            Shared ReadOnly defaultColor1Number As New values.NumericColor(1)
            Shared ReadOnly defaultColor2Number As New values.NumericColor(2)
            Shared ReadOnly defaultColor3Number As New values.NumericColor(3)
            Shared ReadOnly defaultColor4Number As New values.NumericColor(4)
            Shared ReadOnly defaultColor5Number As New values.NumericColor(5)
            Shared ReadOnly defaultColor6Number As New values.NumericColor(6)

            Shared currentColor1Number As New values.NumericColor(defaultColor1Number)
            Shared currentColor2Number As New values.NumericColor(defaultColor2Number)
            Shared currentColor3Number As New values.NumericColor(defaultColor3Number)
            Shared currentColor4Number As New values.NumericColor(defaultColor4Number)
            Shared currentColor5Number As New values.NumericColor(defaultColor5Number)
            Shared currentColor6Number As New values.NumericColor(defaultColor6Number)

            ''' <summary>
            ''' Obtient la liste contenant les numéros actuels des couleurs
            ''' </summary>
            ''' <returns>La liste contenant les numéros des couleurs</returns>
            Shared Function getColorsNumberList() As List(Of values.NumericColor)
                Dim colorsNumberlist As New List(Of values.NumericColor)
                colorsNumberlist.Add(currentColor1Number)
                colorsNumberlist.Add(currentColor2Number)
                colorsNumberlist.Add(currentColor3Number)
                colorsNumberlist.Add(currentColor4Number)
                colorsNumberlist.Add(currentColor5Number)
                colorsNumberlist.Add(currentColor6Number)
                Return colorsNumberlist
            End Function

            'Intervalles des couleurs

            Shared ReadOnly defaultColor1Interval As New values.Interval(0, True, 5, False)
            Shared ReadOnly defaultColor2Interval As New values.Interval(5, True, 10, False)
            Shared ReadOnly defaultColor3Interval As New values.Interval(10, True, 12.5, False)
            Shared ReadOnly defaultColor4Interval As New values.Interval(12.5, True, 15, False)
            Shared ReadOnly defaultColor5Interval As New values.Interval(15, True, 17.5, False)
            Shared ReadOnly defaultColor6Interval As New values.Interval(17.5, True, 20, True)

            Shared color1Interval As New values.Interval(defaultColor1Interval)
            Shared color2Interval As New values.Interval(defaultColor2Interval)
            Shared color3Interval As New values.Interval(defaultColor3Interval)
            Shared color4Interval As New values.Interval(defaultColor4Interval)
            Shared color5Interval As New values.Interval(defaultColor5Interval)
            Shared color6Interval As New values.Interval(defaultColor6Interval)

            ''' <summary>
            ''' Obtient la couleur à attribuer en fonction de la note
            ''' </summary>
            ''' <param name="mark">La note qui définit la couleur à attribuer</param>
            ''' <returns>La couleur en fonction de la note</returns>
            Shared Function getAutoColor(mark As Decimal) As Color
                If color1Interval.isValueHeld(mark) Then
                    Return getColor(currentColor1Number.getNumber())
                ElseIf color2Interval.isValueHeld(mark) Then
                    Return getColor(currentColor2Number.getNumber())
                ElseIf color3Interval.isValueHeld(mark) Then
                    Return getColor(currentColor3Number.getNumber())
                ElseIf color4Interval.isValueHeld(mark) Then
                    Return getColor(currentColor4Number.getNumber())
                ElseIf color5Interval.isValueHeld(mark) Then
                    Return getColor(currentColor5Number.getNumber())
                ElseIf color6Interval.isValueHeld(mark) Then
                    Return getColor(currentColor6Number.getNumber())
                Else
                    Return color1
                End If
            End Function

            'Fonctions des couleurs

            ''' <summary>
            ''' Obtient une couleur à partir du numéro de cette couleur
            ''' </summary>
            ''' <param name="colorNumber">Le numéro de la couleur</param>
            ''' <returns>La couleur correspondant au numéro</returns>
            Shared Function getColor(colorNumber As Integer) As Color
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

            ''' <summary>
            ''' Obtient le numéro de la couleur spécifiée
            ''' </summary>
            ''' <param name="color">La couleur</param>
            ''' <returns>Le numéro de la couleur spécifié</returns>
            Shared Function getColorNumber(color As Color) As Integer
                Dim colorsList As List(Of Color) = marksApp.collections.colors.getColorList()
                If colorsList.Contains(color) Then
                    Return colorsList.IndexOf(color)
                Else
                    Return 1
                End If
            End Function

            ''' <summary>
            ''' Sauvegarde les intervalles et les couleurs des notes
            ''' </summary>
            Shared Sub Save()
                Using savingFile = FileIO.FileSystem.OpenTextFileWriter(file, False)
                    savingFile.WriteLine(color1Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor1Number.getNumber.ToString)
                    savingFile.WriteLine(color2Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor2Number.getNumber.ToString)
                    savingFile.WriteLine(color3Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor3Number.getNumber.ToString)
                    savingFile.WriteLine(color4Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor4Number.getNumber.ToString)
                    savingFile.WriteLine(color5Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor5Number.getNumber.ToString)
                    savingFile.WriteLine(color6Interval.GetString(values.Interval.DisplayMode.saving))
                    savingFile.WriteLine(currentColor6Number.getNumber.ToString)
                End Using
            End Sub

            ''' <summary>
            ''' Charge les intervalles et les couleurs des notes
            ''' </summary>
            Shared Sub Load()
                If values.file.Exists(file) Then
                    Using loadingFile = FileIO.FileSystem.OpenTextFileReader(file)
                        color1Interval.setInterval(loadingFile.ReadLine)
                        currentColor1Number.setNumber(loadingFile.ReadLine)
                        color2Interval.setInterval(loadingFile.ReadLine)
                        currentColor2Number.setNumber(loadingFile.ReadLine)
                        color3Interval.setInterval(loadingFile.ReadLine)
                        currentColor3Number.setNumber(loadingFile.ReadLine)
                        color4Interval.setInterval(loadingFile.ReadLine)
                        currentColor4Number.setNumber(loadingFile.ReadLine)
                        color5Interval.setInterval(loadingFile.ReadLine)
                        currentColor5Number.setNumber(loadingFile.ReadLine)
                        color6Interval.setInterval(loadingFile.ReadLine)
                        currentColor6Number.setNumber(loadingFile.ReadLine)
                    End Using
                End If
            End Sub

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
        Shared Sub saveCollections(collections As List(Of MarksCollectionBox), base As String)
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
        ''' <param name="parent">Le formulaire de notes parent de ces collections</param>
        Shared Sub loadCollections(collections As List(Of MarksCollectionBox), base As String, parent As MarksForm)
            If FileIO.FileSystem.FileExists(base + "/collectionsNumber") Then
                Dim number As Integer
                Using file = FileIO.FileSystem.OpenTextFileReader(base + "/collectionsNumber")
                    number = file.ReadLine
                End Using
                If number > 0 Then
                    Dim newCollectionBox As New MarksCollectionBox
                    Using loadingProgression As New ProgressionDialog
                        Dim showProgression As Boolean = False
                        If number >= showProgressionNumber Then
                            showProgression = True
                            loadingProgression.ShowProgress("Chargement des collections", "Chargement des collections en cours", number, 0)
                        End If
                        For i = 1 To number
                            collections.Add(New MarksCollectionBox)
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
        ''' Obtient le dossier de la collection spécifiée
        ''' </summary>
        ''' <param name="base">Le chemin du dossier qui contient la collection</param>
        ''' <param name="collectionName">Le nom de la collection</param>
        ''' <returns>Le dossier de la collection</returns>
        Shared Function getCollectionDirectoryPath(base As String, collectionName As String)
            Return base + "/" + collectionName
        End Function

        ''' <summary>
        ''' Obtient le chemin de la collection spécifiée
        ''' </summary>
        ''' <param name="collections">La liste de collections</param>
        ''' <returns>Le chemin de la collection</returns>
        Shared Function getPath(collections As List(Of MarksCollectionBox)) As String
            Dim path As String = "files/marks"
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
        Shared Function getCurrentCollection(collections As List(Of MarksCollectionBox)) As MarksCollectionBox
            Dim collection As MarksCollectionBox
            If collections.Count > 0 Then
                collection = collections.Item(collections.Count - 1)
            Else
                collection = Nothing
            End If
            Return collection
        End Function

    End Structure

End Structure

#End Region