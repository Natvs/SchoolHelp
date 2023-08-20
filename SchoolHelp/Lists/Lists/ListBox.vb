''' <summary>
''' Contrôle pour afficher une liste
''' </summary>
Public Class ListBox

    ''' <summary>
    ''' Obtient le nom de la liste
    ''' </summary>
    Public listName As String

    ''' <summary>
    ''' Obtient la couleur de la liste
    ''' </summary>
    Public listColor As Color

    ''' <summary>
    ''' Obtient le numéro de la couleur de la liste
    ''' </summary>
    Public listColorNumber As Integer

    ''' <summary>
    ''' Obtient le formulaire de note parent de cette liste
    ''' </summary>
    Public listForm As ListsForm

    ''' <summary>
    ''' Obtient le nombre de colonnes dans la liste
    ''' </summary>
    Public listColumnsNumber As Integer

    ''' <summary>
    ''' Obtient les titres des colonnes de la liste
    ''' </summary>
    Public listColumnNames As New List(Of String)

    ''' <summary>
    ''' Obtient les items de la liste
    ''' </summary>
    Public listItems As New List(Of List(Of String))

    ''' <summary>
    ''' Initialise ce contrôle
    ''' </summary>
    ''' <param name="name">Le nom de la liste</param>
    ''' <param name="colorNumber">La numéro de la couleur</param>
    ''' <param name="columnsNumber">Le nombre de colonnes de la liste</param>"/>
    ''' <param name="parent">Le formulaire de listes parent de cette liste</param>
    Public Sub Initialise(name As String, colorNumber As Integer, columnsNumber As Integer, parent As ListsForm)
        Me.listForm = parent
        initialise(name, colorNumber, columnsNumber)
    End Sub

    ''' <summary>
    ''' Initialise ce contrôle
    ''' </summary>
    ''' <param name="name">Le nom de la liste</param>
    ''' <param name="colorNumber">La numéro de la couleur</param>
    ''' <param name="columnsNumber">Le nombre de colonnes de la liste</param>
    Private Sub Initialise(name As String, colorNumber As Integer, columnsNumber As Integer)
        Me.listName = name
        Me.listColorNumber = colorNumber
        Me.listColor = listsApp.lists.colors.getColor(colorNumber)
        Me.listColumnsNumber = columnsNumber

        nameLabel.Text = name
        Me.BackColor = Me.listColor
        nameLabel.ForeColor = Values.ColorValue.Inverse(Me.listColor)
    End Sub

#Region "edition"

    ''' <summary>
    ''' Se produit quand le bouton pour supprimer la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Delete(sender As Button, e As EventArgs) Handles deleteButton.Click
        Using deleteDialog As New SchoolHelpDialog
            If deleteDialog.ShowDialog("Voulez-vous supprimer cette liste ?", Values.Dialogs.DialogsTypes.YesNo) = DialogResult.Yes Then
                listForm.deleteList(Me)
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Se produit quand le bouton pour modifier est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditButton_Click(sender As Button, e As EventArgs) Handles editButton.Click
        Using setDialog As New SetListDialog
            Dim result As DialogResult = setDialog.ShowDialog(listName, listColorNumber, listColumnsNumber)
            Initialise(setDialog.listName, setDialog.selectedColorNumber, setDialog.columnsNumber)
        End Using
    End Sub

#End Region

    ''' <summary>
    ''' Se produit quand le bouton pour ouvrir la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub OpenList(sender As Button, e As EventArgs) Handles openButton.Click
        Using openingDialog As New OpenListDialog
            openingDialog.ShowDialog(Me, Me.listColumnNames)
            If openingDialog.openResult = Values.Dialogs.OpenListResults.edit Then
                Using editList As New EditListItemsDialog
                    editList.ShowDialog(Me.listColumnsNumber, Me.listColumnNames, Me.listItems, Me.listColor)
                End Using
            ElseIf openingDialog.openResult = Values.Dialogs.OpenListResults.launchMode1 Then
                Using launchDialog As New LaunchListDialog
                    launchDialog.ShowDialog(Me.listColumnNames, Me.listItems, openingDialog.launchColumnNumber, Me.listColor, LaunchListDialog.LaunchModes.Mode1)
                End Using
            ElseIf openingDialog.openResult = Values.Dialogs.OpenListResults.launchMode2 Then
                Using launchDialog As New LaunchListDialog
                    launchDialog.ShowDialog(Me.listColumnNames, Me.listItems, openingDialog.launchColumnNumber, Me.listColor, LaunchListDialog.LaunchModes.Mode2)
                End Using
            End If
        End Using
    End Sub

#Region "save and load"

    ''' <summary>
    ''' Sauvegarde cette instance de ListBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier dans lequel sauvarder cette instance</param>
    Public Sub Save(path As String)
        Using savingFile = FileIO.FileSystem.OpenTextFileWriter(path, False)
            savingFile.WriteLine(Me.listName)
            savingFile.WriteLine(Me.listColorNumber.ToString)
            savingFile.WriteLine(Me.listColumnsNumber)

            savingFile.WriteLine(Values.ListValue.DisplayList(listColumnNames, Values.ListValue.DisplayListMode.bar))
            savingFile.WriteLine(Me.listItems.Count.ToString)
            For lignNumber = 1 To listItems.Count
                savingFile.WriteLine(Values.ListValue.DisplayList(listItems(lignNumber - 1), Values.ListValue.DisplayListMode.bar))
            Next
        End Using
    End Sub

    ''' <summary>
    ''' Charge cette instance de listBox
    ''' </summary>
    ''' <param name="path">Le chemin du fichier depuis lequel charger cette instance</param>
    ''' <param name="parent">Le formulaire de listes parent de cette instance</param>
    Public Shadows Sub Load(path As String, parent As ListsForm)
        Using loadingFile = FileIO.FileSystem.OpenTextFileReader(path)
            Me.listName = loadingFile.ReadLine
            Me.listColorNumber = loadingFile.ReadLine
            Me.listColumnsNumber = loadingFile.ReadLine

            Me.listColumnNames = Values.ListValue.GetList(loadingFile.ReadLine(), Values.ListValue.DisplayListMode.bar)
            Dim lignsNumber As Integer = loadingFile.ReadLine
            For lignNumber = 1 To lignsNumber
                listItems.Add(New List(Of String))
            Next
            For lignNumber = 1 To listItems.Count
                listItems(lignNumber - 1) = Values.ListValue.GetList(loadingFile.ReadLine, Values.ListValue.DisplayListMode.bar)
            Next
        End Using
        Initialise(Me.listName, Me.listColorNumber, Me.listColumnsNumber, parent)
    End Sub

#End Region
End Class
