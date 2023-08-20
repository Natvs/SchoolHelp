''' <summary>
''' Fournit des données pour les notes
''' </summary>
Structure marksApp

    ''' <summary>
    ''' Sauvegarde une collection
    ''' </summary>
    ''' <param name="marks"></param>
    ''' <param name="collections"></param>
    ''' <param name="base"></param>
    Shared Sub saveAll(marks As List(Of MarkBox), collections As List(Of MarksCollectionBox), base As String)
        marksApp.marks.saveMarks(marks, base)
        marksApp.collections.saveCollections(collections, base)
    End Sub

    ''' <summary>
    ''' Charge une collection
    ''' </summary>
    ''' <param name="marks"></param>
    ''' <param name="collections"></param>
    ''' <param name="base"></param>
    ''' <param name="parent"></param>
    Shared Sub loadAll(marks As List(Of MarkBox), collections As List(Of MarksCollectionBox), base As String, parent As MarksForm)
        marksApp.marks.loadMarks(marks, base, parent)
        marksApp.collections.loadCollections(collections, base, parent)
    End Sub

#Region "Marks"

    Structure marks

        Structure colors
            Shared ReadOnly color1 As Color = Color.White
            Shared ReadOnly color2 As Color = Color.Black
            Shared ReadOnly color3 As Color = Color.Blue
            Shared ReadOnly color4 As Color = Color.Red
            Shared ReadOnly color5 As Color = Color.Yellow
            Shared ReadOnly color6 As Color = Color.Green
        End Structure

        ''' <summary>
        ''' Sauve les notes dans leur fichier
        ''' </summary>
        ''' <param name="marks">La liste de notes à sauvegarder</param>
        ''' <param name="base">La base du chemin où sauvegarder les notes</param>
        Shared Sub saveMarks(marks As List(Of MarkBox), base As String)
            Using progression As New ProgressionDialog
                Using file = FileIO.FileSystem.OpenTextFileWriter(base + "/marksNumber", False)
                    file.WriteLine(marks.Count)
                End Using
                progression.Show("Sauvegarde des notes", 0, marks.Count)
                If marks.Count > 0 Then
                    Dim path As String
                    For i = 1 To marks.Count
                        path = base + "/mark" + i.ToString
                        marks.Item(i - 1).save(path)
                        progression.increment(1)
                    Next
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Charge les notes depuis leur fichier
        ''' </summary>
        ''' <param name="marks">La liste de notes à charger</param>
        ''' <param name="base">La base du chemin d'où chager les notes</param>
        ''' <param name="parent">Le formulaire de notes parent de ces notes</param>
        Shared Sub loadMarks(marks As List(Of MarkBox), base As String, parent As MarksForm)
            If FileIO.FileSystem.FileExists(base + "/marksNumber") Then
                Using progression As New ProgressionDialog
                    Dim number As Integer
                    Using file = FileIO.FileSystem.OpenTextFileReader(base + "/marksNumber")
                        number = file.ReadLine
                    End Using
                    progression.Show("Chargement des notes", 0, number)
                    If number > 0 Then
                        Dim path As String
                        Dim newMarkBox As New MarkBox
                        For i = 1 To number
                            path = base + "/mark" + i.ToString
                            newMarkBox = New MarkBox
                            newMarkBox.load(path, parent)
                            marks.Add(newMarkBox)
                            progression.increment(1)
                        Next
                    End If
                End Using
            End If
        End Sub

    End Structure
#End Region

#Region "Collections"

    Structure collections

        ''' <summary>
        ''' Sauve les collections dans leur fichier
        ''' </summary>
        ''' <param name="collections">La liste de collections à sauvegarder</param>
        ''' <param name="base">La base du chemin où sauvegarder les collections</param>
        Shared Sub saveCollections(collections As List(Of MarksCollectionBox), base As String)
            Using progression As New ProgressionDialog
                Using file = FileIO.FileSystem.OpenTextFileWriter(base + "/collectionsNumber", False)
                    file.WriteLine(collections.Count)
                End Using
                progression.Show("Sauvegarde des collections", 0, collections.Count)
                If collections.Count > 0 Then
                    Dim path As String
                    For i = 1 To collections.Count
                        path = base + "/collection" + i.ToString
                        collections.Item(i - 1).save(path)
                        progression.increment(1)
                    Next
                End If
            End Using
        End Sub

        ''' <summary>
        ''' Charge les collections depuis leur fichier
        ''' </summary>
        ''' <param name="collections">La liste de collections à charger</param>
        ''' <param name="base">La base du chemin d'où chager les collections</param>
        ''' <param name="parent">Le formulaire de notes parent de ces collections</param>
        Shared Sub loadCollections(collections As List(Of MarksCollectionBox), base As String, parent As MarksForm)
            If FileIO.FileSystem.FileExists(base + "/collectionsNumber") Then
                Using progression As New ProgressionDialog
                    Dim number As Integer
                    Using file = FileIO.FileSystem.OpenTextFileReader(base + "/collectionsNumber")
                        number = file.ReadLine
                    End Using
                    progression.Show("Chargement des collections", 0, number)
                    If number > 0 Then
                        Dim newCollectionBox As New MarksCollectionBox
                        For i = 1 To number
                            collections.Add(New MarksCollectionBox)
                            collections.Item(i - 1).load(base + "/collection" + i.ToString, parent)
                            collections.Item(i - 1).displayMedium(marksApp.collections.getMedium(base, collections.Item(i - 1)))

                            progression.increment(1)
                        Next
                    End If
                End Using
            End If
        End Sub

        ''' <summary>
        ''' Obtient une moyenne pour la collection 
        ''' </summary>
        ''' <param name="base">Le chemin de la collection</param>
        ''' <param name="collectionBox">La collection pour laquelle obtenir la moyenne</param>
        Shared Function getMedium(base As String, collectionBox As MarksCollectionBox) As Decimal
            Dim medium As Decimal = 0
            Dim mediumCoef As Integer = 0

            Dim marksBoxesList As New List(Of MarkBox)

            'Vérifie si le fichier contenant le nombre de notes existe
            If FileIO.FileSystem.FileExists(base + "/" + collectionBox.collectionName + "/marksNumber") Then
                Dim marksNumber As Integer
                Using file = FileIO.FileSystem.OpenTextFileReader(base + "/" + collectionBox.collectionName + "/marksNumber")
                    marksNumber = file.ReadLine
                End Using
                If marksNumber > 0 Then
                    For i = 1 To marksNumber
                        marksBoxesList.Add(New MarkBox)
                        marksBoxesList.Item(i - 1).load(base + "/" + collectionBox.collectionName + "/mark" + i.ToString, Nothing)
                    Next
                End If
            End If

            'Vérifie si le fichier contenant le nombre de collections existe
            If FileIO.FileSystem.FileExists(base + "/" + collectionBox.collectionName + "/collectionsNumber") Then
                Dim collectionsBoxes As New List(Of MarksCollectionBox)
                Dim collectionsNumber As Integer
                Using file = FileIO.FileSystem.OpenTextFileReader(base + "/" + collectionBox.collectionName + "/collectionsNumber")
                    collectionsNumber = file.ReadLine
                End Using
                If collectionsNumber > 0 Then
                    For i = 1 To collectionsNumber
                        collectionsBoxes.Add(New MarksCollectionBox)
                        collectionsBoxes.Item(i - 1).load(base + "/" + collectionBox.collectionName + "/collection" + i.ToString, Nothing)

                        Dim markBoxToAdd As New MarkBox
                        markBoxToAdd.initialize(getMedium(base, collectionBox), 1, Color.White, Nothing)
                        marksBoxesList.Add(markBoxToAdd)
                    Next
                End If
            End If

            'Calcule la moyenne selon les éléments dans la liste MarkBoxes
            Dim totalNumber As Integer = 0
            Dim totalSum As Decimal = 0
            If marksBoxesList.Count > 0 Then
                For i = 1 To marksBoxesList.Count
                    totalSum = totalSum + marksBoxesList.Item(i - 1).mark * marksBoxesList.Item(i - 1).coef
                    totalNumber = totalNumber + marksBoxesList.Item(i - 1).coef
                Next
            End If
            If totalNumber <> 0 Then
                medium = totalSum / totalNumber
                mediumCoef = totalNumber
            Else
                medium = 0
                mediumCoef = 0
            End If

            Return medium
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
        Shared Function getCurrentCollection(collections As List(Of MarksCollectionBox))
            Dim collection As MarksCollectionBox
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