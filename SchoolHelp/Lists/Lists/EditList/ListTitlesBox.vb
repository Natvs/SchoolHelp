''' <summary>
''' Contrôle pour afficher les titres d'une liste
''' </summary>
Public Class ListTitlesBox

    ''' <summary>
    ''' Obtient la liste contenant les titres actuels
    ''' </summary>
    Public titlesList As List(Of String)

    ''' <summary>
    ''' Obtient la liste contenant les labels des titres actuels
    ''' </summary>
    Private titlesLabelsList As New List(Of TextBox)

    ''' <summary>
    ''' Obtient le nombre de colonnes de la liste
    ''' </summary>
    Private columnsNumber As Integer

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="itemsList">La liste contenant les items de la ligne</param>
    Public Sub initialise(columnsNumber As Integer, itemsList As List(Of String))

        Me.titlesList = itemsList
        Me.columnsNumber = columnsNumber

        lignBox.ColumnCount = Me.columnsNumber

        For i = 1 To Me.columnsNumber
            lignBox.ColumnStyles.Insert(i - 1, New ColumnStyle(SizeType.Percent, 100 / columnsNumber))

            Dim titlesTextBox As New TextBox
            If i > Me.titlesList.Count Then
                titlesList.Add("")
            End If
            titlesTextBox.Text = Me.titlesList(i - 1)
            titlesTextBox.Font = New Font(FontFamily.GenericSansSerif, 20)
            titlesTextBox.ForeColor = Color.Red
            titlesTextBox.TextAlign = HorizontalAlignment.Center
            titlesTextBox.Dock = DockStyle.Fill
            AddHandler titlesTextBox.TextChanged, AddressOf itemTextChanged

            titlesLabelsList.Add(titlesTextBox)
            lignBox.Controls.Add(titlesTextBox)
        Next

    End Sub

    ''' <summary>
    ''' Quand le texte d'un item de la liste change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub itemTextChanged(sender As Object, e As EventArgs)
        For i = 1 To Me.columnsNumber
            titlesList(i - 1) = titlesLabelsList(i - 1).Text
        Next
    End Sub

#Region "Evenèment Suppresion"

    ''' <summary>
    ''' Se produit quand le bouton pour supprimer la ligne de titre est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Event DeletedButtonClicked(sender As ListTitlesBox, e As EventArgs)

    ''' <summary>
    ''' Quand le bouton pour supprimer la ligne de titres est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub whenDeletedButtonClicked(sender As Button, e As EventArgs) Handles deleteButton.Click
        RaiseEvent DeletedButtonClicked(Me, e)
    End Sub

#End Region

End Class
