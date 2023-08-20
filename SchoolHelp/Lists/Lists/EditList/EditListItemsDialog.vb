''' <summary>
''' Boite de dialogue pour modifier les items d'une liste
''' </summary>
Public Class EditListItemsDialog

    ''' <summary>
    ''' Obtient la liste des items
    ''' </summary>
    Private itemsList As List(Of List(Of String))

    ''' <summary>
    ''' Obtient les titres des colonnes
    ''' </summary>
    Private titlesList As List(Of String)

    ''' <summary>
    ''' Obtient la liste des boites à texte des items
    ''' </summary>
    Private itemsLignList As New List(Of ListItemsBox)

    ''' <summary>
    ''' Obtient le nombre de colonnes de la liste
    ''' </summary>
    Private columnsNumber As Integer

    ''' <summary>
    ''' Obtient la couleur de la liste
    ''' </summary>
    Private listColor As Color

    ''' <summary>
    ''' Affiche le dialogue pour modifier les items de la liste
    ''' </summary>
    ''' <param name="columnsNumber">Le nombre de colonnes de la liste</param>
    ''' <param name="titlesList">La liste contenant les titres de la liste</param>
    ''' <param name="itemsList">La liste contenant les items de la liste</param>
    ''' <returns></returns>
    Public Overloads Function ShowDialog(columnsNumber As Integer, titlesList As List(Of String), itemsList As List(Of List(Of String)), listColor As Color)
        Me.itemsList = itemsList
        Me.titlesList = titlesList
        Me.columnsNumber = columnsNumber
        Me.listColor = listColor

        Me.BackColor = listColor

        'Initialise la liste contenant les lignes d'items
        For lignNumber = 0 To itemsList.Count - 1
            Me.itemsLignList.Add(New SchoolHelp.ListItemsBox(SchoolHelp.ListItemsBox.Types.item))
            AddHandler Me.itemsLignList(lignNumber).DeletedButtonClicked, AddressOf DeleteLign
            Me.itemsLignList(lignNumber).initialise(columnsNumber, itemsList(lignNumber))
            Me.itemsLignList(lignNumber).Dock = DockStyle.Fill
        Next

        ShowItems(itemsList)

        Return ShowDialog()
    End Function

    ''' <summary>
    ''' Montre les items de la liste
    ''' </summary>
    ''' <param name="itemsList">La liste contenant tous les items</param>
    Public Sub ShowItems(itemsList As List(Of List(Of String)))
        Dim numberBeforeItems As Integer = 2

        Using WaitingDialog As New ProgressionDialog

            Me.SuspendLayout()
            mainBox.SuspendLayout()

            WaitingDialog.ShowProgress("Chargement", "Chargement de la liste en cours...", itemsList.Count + numberBeforeItems, 0)
            WaitingDialog.SetNewMessage("Chargement de la liste en cours...")

            listItemsBox.Controls.Clear()

            listItemsBox.RowCount = itemsList.Count + numberBeforeItems

            'Initialise la ligne des titres de la liste
            listItemsBox.RowStyles.Insert(0, New RowStyle(SizeType.AutoSize))
            Dim titleTextBox As New ListTitlesBox
            AddHandler titleTextBox.DeletedButtonClicked, AddressOf DeleteTitlesLign
            titleTextBox.initialise(columnsNumber, Me.titlesList)
            titleTextBox.Dock = DockStyle.Fill
            listItemsBox.Controls.Add(titleTextBox, 0, 0)

            WaitingDialog.IncreaseProgression()

            'Initialise la boite de recherche de la liste
            listItemsBox.RowStyles.Insert(1, New RowStyle(SizeType.AutoSize))
            Dim searchBox As New ListItemsBox(SchoolHelp.ListItemsBox.Types.search, GetForbiddenItems())
            AddHandler searchBox.SearchButtonClicked, AddressOf SearchItem
            searchBox.initialise(columnsNumber, New List(Of String))
            searchBox.Dock = DockStyle.Fill
            listItemsBox.Controls.Add(searchBox, 0, 1)

            WaitingDialog.IncreaseProgression()

            'Initialise les items de la liste
            Dim itemsLignList As New List(Of ListItemsBox)
            For lignNumber = 0 To itemsList.Count - 1
                itemsLignList.Add(New SchoolHelp.ListItemsBox(SchoolHelp.ListItemsBox.Types.item, GetForbiddenItems()))
                AddHandler itemsLignList(lignNumber).DeletedButtonClicked, AddressOf DeleteLign
                itemsLignList(lignNumber).initialise(columnsNumber, itemsList(lignNumber))
                itemsLignList(lignNumber).Dock = DockStyle.Fill
            Next

            For lignNumber = 0 To itemsList.Count - 1
                'MessageBox.Show("RowCount = " + listItemsBox.RowCount.ToString + vbNewLine + "Index = " + (lignNumber + numberBeforeItems).ToString)
                listItemsBox.RowStyles.Insert(lignNumber + numberBeforeItems, New RowStyle(SizeType.AutoSize))
                listItemsBox.Controls.Add(itemsLignList(lignNumber), 0, lignNumber + numberBeforeItems)

                WaitingDialog.IncreaseProgression()
            Next
            listItemsBox.RowStyles.Insert(listItemsBox.RowCount - 1, New RowStyle(SizeType.AutoSize))

            mainBox.ResumeLayout()
            Me.ResumeLayout()

        End Using

    End Sub

    ''' <summary>
    ''' Obtient la liste des items interdits
    ''' </summary>
    Public Function GetForbiddenItems() As List(Of String)
        Dim forbiddenlist As New List(Of String)
        forbiddenlist.Add("/")
        forbiddenlist.Add("\")
        forbiddenlist.Add(Values.ListValue.itemalreadysearched)

        Return forbiddenlist
    End Function

#Region "Add and delete"

    ''' <summary>
    ''' Quand le bouton pour ajouter une liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddLignButtonClicked(sender As Object, e As EventArgs) Handles addLignButton.Click
        AddLign()
    End Sub

    ''' <summary>
    ''' Ajoute une nouvelle ligne à la liste
    ''' </summary>
    Private Sub AddLign()

        listItemsBox.SuspendLayout()

        Dim listToAdd As New List(Of String)

        listItemsBox.RowCount = listItemsBox.RowCount + 1
        listItemsBox.RowStyles.Insert(itemsList.Count + 1, New RowStyle(SizeType.AutoSize))

        Dim lignItemBox As New ListItemsBox(SchoolHelp.ListItemsBox.Types.item, GetForbiddenItems())
        AddHandler lignItemBox.DeletedButtonClicked, AddressOf DeleteLign
        lignItemBox.initialise(columnsNumber, listToAdd)
        lignItemBox.Dock = DockStyle.Fill
        listItemsBox.Controls.Add(lignItemBox, 1, itemsList.Count + 1)

        Me.itemsLignList.Add(lignItemBox)
        Me.itemsList.Add(listToAdd)

        listItemsBox.ResumeLayout()


    End Sub

    ''' <summary>
    ''' Supprime la ligne de titres
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DeleteTitlesLign(sender As ListTitlesBox, e As EventArgs)
        Using deleteDialog As New SchoolHelpDialog
            deleteDialog.ShowDialog("Vous ne pouvez pas supprimer la ligne de titres de la liste.", values.dialogs.DialogsTypes.Ok)
        End Using
    End Sub

    ''' <summary>
    ''' Supprime une ligne d'items
    ''' </summary>
    ''' <param name="sender">La ligne d'items à supprimer</param>
    ''' <param name="e"></param>
    Private Sub DeleteLign(sender As ListItemsBox, e As EventArgs)
        Using deleteDialog As New SchoolHelpDialog
            If deleteDialog.ShowDialog("Voulez-vous supprimer cette ligne ?", values.dialogs.DialogsTypes.YesNo) = DialogResult.Yes Then
                listItemsBox.SuspendLayout()

                listItemsBox.Controls.Remove(sender)
                itemsList.Remove(sender.itemsList)

                listItemsBox.ResumeLayout()
            End If
        End Using
    End Sub

#End Region

#Region "Search"

    Private Sub SearchItem(sender As ListItemsBox, e As EventArgs)
        Dim isListEmpty As Boolean = values.ListValue.IsListEmpty(sender.itemsList)
        If Not isListEmpty Then

            'Index du premier item de la ligne de recherche
            Dim columnNumber As Integer = Values.ListValue.GetFirstItemIndex(sender.itemsList) + 1

            'Texte de cet index
            Dim text As String = sender.itemsList(columnNumber - 1)

            If Values.ListValue.Contains(GetColumnList(columnNumber), text, Values.FindMode.inItem) Then
                ShowItems(SearchItem(columnNumber, text))
            Else
                Using messageDialog As New SchoolHelpDialog
                    messageDialog.ShowDialog("Le texte spécifié est introuvable.", values.dialogs.DialogsTypes.Ok)
                End Using
            End If

        Else
            ShowItems(itemsList)
        End If
    End Sub

    ''' <summary>
    ''' Obtient une liste des ligne d'items qui contiennnet le texte spécifié dans la colonne spécifiée
    ''' </summary>
    ''' <param name="columnNumber">Le numéro de la colonne dans laquelle rechercher le texte</param>
    ''' <param name="mustContain">Le texte à rechercher dans chaque item de la colonne</param>
    ''' <returns>La liste de lignes d'items qui contiennent le texte spécifié dans la colonne spécifiée</returns>
    Private Function SearchItem(columnNumber As Integer, mustContain As String) As List(Of List(Of String))
        'Crée une liste contenant tous les items dans lesquelles rechercher
        Dim searchingList As List(Of String) = GetColumnList(columnNumber)

        Dim indexList As List(Of Integer) = Values.ListValue.FindAllIndex(searchingList, mustContain, Values.FindMode.inItem)

        Dim listItemsBoxList As New List(Of List(Of String))
        For i = 0 To indexList.Count - 1
            listItemsBoxList.Add(Me.itemsLignList(indexList(i)).itemsList)
        Next

        Return listItemsBoxList
    End Function

    ''' <summary>
    ''' Obtient la liste de tous les items dans la colonne spécifiée
    ''' </summary>
    ''' <param name="columnNumber">Le numéro de la colonne</param>
    ''' <returns>La liste de tous les items dans la colonne spécifiée</returns>
    Private Function GetColumnList(columnNumber As Integer) As List(Of String)
        Dim newList As New List(Of String)
        For i = 1 To itemsList.Count
            newList.Add(itemsList(i - 1)(columnNumber - 1))
        Next
        Return newList
    End Function

#End Region

End Class