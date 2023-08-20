''' <summary>
''' Contrôle utilisateur utilisé pour une collection de notes
''' </summary>
Public Class MarksCollectionBox

    ''' <summary>
    ''' Obtient le chemin du dossier de la collection
    ''' </summary>
    Public collectionFolderPath As String

    ''' <summary>
    ''' Obtient le nom de la collection
    ''' </summary>
    Public collectionName As String

    ''' <summary>
    ''' Obtient la couleur de la collection
    ''' </summary>
    Public collectionColor As Color

    ''' <summary>
    ''' Obtient le numéro de la couleur de la collection
    ''' </summary>
    Public collectionColorNumber As Integer

    ''' <summary>
    ''' Obtient la valeur qui définit si la couleur automatique est activée
    ''' </summary>
    Public useAutoColor As Boolean

    ''' <summary>
    ''' Obtient le formulaire de note parent de cette instance
    ''' </summary>
    Public marksForm As MarksForm

    ''' <summary>
    ''' Obtient la moyenne de cette instance
    ''' </summary>
    Public medium As Decimal

    ''' <summary>
    ''' Initialise cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="collectionName">Le nom de la collection</param>
    ''' <param name="collectionFolderPath">Le chemin de la collection contenant cette collection</param>
    ''' <param name="collectionColorNumber">Le numéro de la couleur de la collection</param>
    ''' <param name="useAutoColor">Indique si la couleur automatique est activée</param>
    ''' <param name="parent">Le formulaire de notes parent de cette instance</param>
    Public Sub Initialize(collectionName As String, collectionFolderPath As String, collectionColorNumber As Integer, useAutoColor As Boolean, parent As MarksForm)
        Me.collectionFolderPath = marksApp.collections.getCollectionDirectoryPath(collectionFolderPath, Me.collectionName)
        Initialize(collectionName, collectionColorNumber, useAutoColor, parent)
    End Sub

    ''' <summary>
    ''' Initialise cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="collectionName">Le nom de la collection</param>
    ''' <param name="collectionColorNumber">Le numéro de la couleur de la collection</param>
    ''' <param name="useAutoColor">Indique si la couleur automatique est activée</param>
    ''' <param name="parent">Le formulaire de notes parent de cette instance</param>
    Private Sub Initialize(collectionName As String, collectionColorNumber As Integer, useAutoColor As Boolean, parent As MarksForm)
        Me.collectionName = collectionName
        Me.collectionColorNumber = collectionColorNumber
        Me.collectionColor = marksApp.collections.colors.getColor(Me.collectionColorNumber)
        Me.useAutoColor = useAutoColor

        Me.medium = getMedium(collectionFolderPath, Me)

        Dim inversedColor As Color
        If Me.useAutoColor Then
            Me.BackColor = marksApp.collections.colors.getAutoColor(medium)
            inversedColor = values.ColorValue.inverse(marksApp.collections.colors.getAutoColor(medium))
        Else
            Me.BackColor = collectionColor
            inversedColor = values.ColorValue.inverse(collectionColor)
        End If

        Me.marksForm = parent

        collectionLabel.ForeColor = inversedColor
        collectionLabel.Text = Me.collectionName
        mediumLabel.ForeColor = inversedColor
        mediumLabel.Text = "Moyenne : " + FormatNumber(Me.medium, 2)
    End Sub

    ''' <summary>
    ''' Obtient une moyenne pour la collection 
    ''' </summary>
    ''' <param name="base">Le chemin du dossier contenant la collection</param>
    ''' <param name="collectionBox">La collection pour laquelle obtenir la moyenne</param>
    Private Function GetMedium(base As String, collectionBox As MarksCollectionBox) As Decimal
        Dim medium As Decimal = 0
        Dim mediumCoef As Decimal = 0

        Dim totalNumber As Decimal = 0
        Dim totalSum As Decimal = 0

        Dim marksBoxesList As New List(Of MarkBox)

        'Vérifie si le fichier contenant le nombre de notes existe
        If FileIO.FileSystem.FileExists(base + "/marksNumber") Then
            Dim marksNumber As Integer
            Using file = FileIO.FileSystem.OpenTextFileReader(base + "/marksNumber")
                marksNumber = file.ReadLine
            End Using
            If marksNumber > 0 Then
                For i = 1 To marksNumber
                    Using newMarkBox As New MarkBox
                        newMarkBox.load(base + "/mark" + i.ToString, Nothing)
                        totalSum = totalSum + newMarkBox.mark * newMarkBox.coef
                        totalNumber = totalNumber + newMarkBox.coef
                    End Using
                Next
            End If
        End If

        'Vérifie si le fichier contenant le nombre de collections existe
        If FileIO.FileSystem.FileExists(base + "/collectionsNumber") Then
            Dim collectionsNumber As Integer
            Using file = FileIO.FileSystem.OpenTextFileReader(base + "/collectionsNumber")
                collectionsNumber = file.ReadLine
            End Using
            If collectionsNumber > 0 Then
                For i = 1 To collectionsNumber
                    Using newCollectionBox As New MarksCollectionBox
                        newCollectionBox.load(base + "/collection" + i.ToString, Nothing)
                        totalSum = totalSum + newCollectionBox.medium
                        totalNumber = totalNumber + 1
                    End Using
                Next
            End If
        End If

        'Calcule la moyenne
        If totalNumber > 0 Then
            Return totalSum / totalNumber
        Else
            Return Nothing
        End If
    End Function

#Region "Edition"

    ''' <summary>
    ''' Ouvre la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub open(sender As Button, e As EventArgs) Handles openButton.Click
        marksForm.openCollection(Me)
    End Sub

    ''' <summary>
    ''' Modifie la collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub edit(sender As Button, e As EventArgs) Handles editButton.Click
        Using collectionDialog As New setMarksCollectionDialog
            Dim result As DialogResult = collectionDialog.ShowDialog(Me.collectionName, Me.collectionColorNumber, Me.useAutoColor)
            If result = DialogResult.OK Then
                values.directory.Rename(marksApp.collections.getPath(Me.marksForm.currentCollectionsList) + "/" + Me.collectionName, Me.collectionName, collectionDialog.selectedName)
                Initialize(collectionDialog.selectedName, values.directory.GetDirectoryPath(collectionFolderPath), collectionDialog.selectedColorNumber, collectionDialog.useAutoColor, Me.marksForm)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Supprime cette collection
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub delete(sender As Button, e As EventArgs) Handles deleteButton.Click
        Using deleteDialog As New SchoolHelpDialog
            If deleteDialog.ShowDialog("Voulez-vous supprimer cette collection ?", values.dialogs.DialogsTypes.YesNo) = DialogResult.Yes Then
                marksForm.deleteCollection(Me)
            End If
        End Using
    End Sub

#End Region

#Region "Save and load"

    ''' <summary>
    ''' Sauvegarde cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    Public Sub save(path As String)
        Using file = FileIO.FileSystem.OpenTextFileWriter(path, False)
            file.WriteLine(collectionName)
            file.WriteLine(collectionColorNumber)
            file.WriteLine(values.BooleanValue.getString(useAutoColor))
        End Using
    End Sub

    ''' <summary>
    ''' Charge cette instance de MarksCollectionBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier</param>
    ''' <param name="parent">Le formulaire de note parent de cette instance</param>
    Public Shadows Sub load(path As String, parent As MarksForm)
        If FileIO.FileSystem.FileExists(path) Then
            Using file = FileIO.FileSystem.OpenTextFileReader(path)
                Me.collectionName = file.ReadLine
                Me.collectionColorNumber = file.ReadLine
                Me.useAutoColor = values.BooleanValue.fromString(file.ReadLine, True)
            End Using
            Initialize(Me.collectionName, values.directory.GetDirectoryPath(path), Me.collectionColorNumber, useAutoColor, parent)
        End If
    End Sub

#End Region

End Class
