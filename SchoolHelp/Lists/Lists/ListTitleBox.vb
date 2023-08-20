''' <summary>
''' Contrôle pour afficher une ligne d'items d'une liste
''' </summary>
Public Class ListTitleBox

    ''' <summary>
    ''' Obtient la liste contenant les titres actuels
    ''' </summary>
    Public titleList As List(Of String)

    ''' <summary>
    ''' Obtient la liste contenant les labels des items actuels
    ''' </summary>
    Private itemsTextBoxList As New List(Of Label)

    ''' <summary>
    ''' Obtient le nombre de colonnes de la liste
    ''' </summary>
    Private columnsNumber As Integer

    ''' <summary>
    ''' Initialise le contrôle
    ''' </summary>
    ''' <param name="itemsList">La liste contenant les items de la ligne</param>
    Public Sub initialise(columnsNumber As Integer, itemsList As List(Of String))

        Me.titleList = itemsList
        Me.columnsNumber = columnsNumber

        lignBox.ColumnCount = Me.columnsNumber

        For i = 1 To Me.columnsNumber
            lignBox.ColumnStyles.Insert(i - 1, New ColumnStyle(SizeType.Percent, 100 / columnsNumber))

            Dim itemTextBox As New TextBox
            If i <= Me.itemsList.Count Then
                itemTextBox.Text = Me.itemsList(i - 1)
            Else
                itemTextBox.Text = "<Pas de texte>"
            End If
            itemTextBox.Font = New Font(FontFamily.GenericSansSerif, 15)
            itemTextBox.TextAlign = HorizontalAlignment.Center
            itemTextBox.Dock = DockStyle.Fill
            AddHandler itemTextBox.TextChanged, AddressOf itemTextChanged

            itemsTextBoxList.Add(itemTextBox)
            lignBox.Controls.Add(itemTextBox)
        Next

    End Sub

    ''' <summary>
    ''' Quand le texte d'un item de la liste change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub itemTextChanged(sender As Object, e As EventArgs)
        For i = 1 To Me.columnsNumber
            itemsList(i - 1) = itemsTextBoxList(i - 1).Text
        Next
    End Sub

End Class
