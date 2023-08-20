''' <summary>
''' Contrôle pour afficher une ligne d'items d'une liste
''' </summary>
Public Class ListItemsBox

    ''' <summary>
    ''' Obtient le type de ligne de cette instance
    ''' </summary>
    Private lignType As Types

    ''' <summary>
    ''' Obtient la liste contenant les items actuels
    ''' </summary>
    Public itemsList As List(Of String)

    ''' <summary>
    ''' Obtient la liste contenant les boites de textes des items actuels
    ''' </summary>
    Private itemsTextBoxList As New List(Of TextBox)

    ''' <summary>
    ''' Obtient le nombre de colonnes de la liste
    ''' </summary>
    Private columnsNumber As Integer

    ''' <summary>
    ''' Obtient la liste contenant les textes interdits
    ''' </summary>
    Private forbiddenStringList As New List(Of String)

    ''' <summary>
    ''' Obtient les différents types de lignes d'items pour les listes
    ''' </summary>
    Public Enum Types
        ''' <summary>
        ''' Spécifie une ligne d'item normale
        ''' </summary>
        item
        ''' <summary>
        ''' Spécifie une ligne d'item dédiée à la recherche
        ''' </summary>
        search
    End Enum

    ''' <summary>
    ''' Initialise une nouvelle ligne d'items
    ''' </summary>
    ''' <param name="type">Le type de cette ligne d'item</param>
    Public Sub New(type As Types)
        InitializeComponent()

        lignType = type
        If type = Types.item Then
            deleteButton.BackgroundImage = My.Resources.cross
        ElseIf type = Types.search Then
            deleteButton.BackgroundImage = My.Resources.wen
        End If
    End Sub

    ''' <summary>
    ''' Initialise une nouvelle ligne d'items
    ''' </summary>
    ''' <param name="type">Le type de cette ligne d'item</param>
    ''' <param name="forbiddenStringList">La liste des caractères ou textes interdits</param>
    Public Sub New(type As Types, forbiddenStringList As List(Of String))
        InitializeComponent()

        lignType = type
        If type = Types.item Then
            deleteButton.BackgroundImage = My.Resources.cross
        ElseIf type = Types.search Then
            deleteButton.BackgroundImage = My.Resources.wen
        End If

        If forbiddenStringList.Count() > 0 Then
            For index = 1 To forbiddenStringList.Count()
                Me.forbiddenStringList.Add(forbiddenStringList(index - 1))
            Next
        End If
    End Sub

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="itemsList">La liste contenant les items de la ligne</param>
    Public Sub initialise(columnsNumber As Integer, itemsList As List(Of String))

        Me.itemsList = itemsList
        Me.columnsNumber = columnsNumber

        lignBox.ColumnCount = Me.columnsNumber

        For i = 1 To Me.columnsNumber
            lignBox.ColumnStyles.Insert(i - 1, New ColumnStyle(SizeType.Percent, 100 / columnsNumber))

            Dim itemTextBox As New TextBox
            If i >= Me.itemsList.Count Then
                Me.itemsList.Add("")
            End If
            itemTextBox.Text = Me.itemsList(i - 1)
            itemTextBox.Font = New Font(FontFamily.GenericSansSerif, 15)
            itemTextBox.TextAlign = HorizontalAlignment.Center
            itemTextBox.Dock = DockStyle.Fill
            AddHandler itemTextBox.TextChanged, AddressOf ItemTextChanged

            itemsTextBoxList.Add(itemTextBox)
            lignBox.Controls.Add(itemTextBox)
        Next
    End Sub

    ''' <summary>
    ''' Actualise le texte des items pour correspondre à la liste
    ''' </summary>
    Private Sub ActualizeItems()
        For index = 1 To Me.columnsNumber
            itemsTextBoxList(index - 1).Text = itemsList(index - 1)
        Next
    End Sub

    ''' <summary>
    ''' Quand le texte d'un item de la liste change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ItemTextChanged(sender As TextBox, e As EventArgs)
        If sender.Text <> "" Then
            If Values.StringValue.Contains(sender.Text, forbiddenStringList) Then
                Using ForbiddenDialog As New SchoolHelpDialog
                    ForbiddenDialog.ShowDialog("Cet item est interdit." + vbNewLine +
                                           "Valeurs interdites : " + Values.ListValue.DisplayList(forbiddenStringList, Values.ListValue.DisplayListMode.quotation) + vbNewLine +
                                           "Aucun item ne peut contenir les valeurs ci-dessus.", Values.Dialogs.DialogsTypes.Ok)
                End Using
                ActualizeItems()
            End If
        End If

        For i = 1 To Me.columnsNumber
            itemsList(i - 1) = itemsTextBoxList(i - 1).Text
        Next
    End Sub

#Region "Evènements"

    ''' <summary>
    ''' Se produit quand le bouton pour supprimer la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event DeletedButtonClicked(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Se produit quand le bouton pour rechercher est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event SearchButtonClicked(sender As Object, e As EventArgs)

    ''' <summary>
    ''' Quand le bouton pour supprimer la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenDeletedButtonCliked(sender As Object, e As EventArgs) Handles deleteButton.Click
        If lignType = Types.item Then
            RaiseEvent DeletedButtonClicked(Me, e)
        ElseIf lignType = Types.search Then
            RaiseEvent SearchButtonClicked(Me, e)
        End If
    End Sub

#End Region

End Class
