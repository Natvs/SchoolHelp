Public Class OpenListDialog

    ''' <summary>
    ''' Obtient le résultat du dialogue d'ouverture de la liste
    ''' </summary>
    Public openResult As values.dialogs.OpenListResults

    ''' <summary>
    ''' Obtient la liste contenant les titres de la liste
    ''' </summary>
    Private columnsTitlesList As List(Of String)

    ''' <summary>
    ''' Obtient la colonne à partir de laquelle lancer la liste
    ''' </summary>
    Public launchColumnNumber As Integer

    ''' <summary>
    ''' Affiche le dialogue d'ouverture de la liste
    ''' </summary>
    ''' <param name="list"></param>
    ''' <param name="columnsTitlesList"></param>
    ''' <returns>Le type d'ouverture de la liste sélectionnée</returns>
    Public Overloads Function ShowDialog(list As ListBox, columnsTitlesList As List(Of String)) As DialogResult
        Me.openResult = values.dialogs.OpenListResults.none
        Me.columnsTitlesList = columnsTitlesList

        Dim color = list.listColor
        Dim inversedColor = Values.ColorValue.inverse(color)

        Me.BackColor = list.listColor
        Me.ForeColor = inversedColor

        LaunchListMode1Box.RowCount = Me.columnsTitlesList.Count

        EditListBox.initialize("Modifier le contenu de la liste", "Modifier la liste", color, inversedColor, 0, DialogResult.OK)

        If Me.columnsTitlesList.Count > 0 Then
            For i = 1 To columnsTitlesList.Count
                If columnsTitlesList(i - 1) <> "" Then

                    Dim titleName As String = Me.columnsTitlesList(i - 1)

                    'Crée un contrôle pour lancer la liste avec le mode 1

                    Dim TitleButtonMode1 As New ButtonMessageBox
                    TitleButtonMode1.initialize("Démarrer la liste à partir de la colonne " + titleName, titleName, color, inversedColor, i, DialogResult.OK)
                    TitleButtonMode1.Dock = DockStyle.Fill
                    TitleButtonMode1.BackColor = color
                    TitleButtonMode1.ForeColor = inversedColor
                    AddHandler TitleButtonMode1.ActionButtonClicked, AddressOf LaunchMode1ButtonClicked

                    LaunchListMode1Box.RowStyles.Insert(i - 1, New RowStyle(SizeType.AutoSize))
                    LaunchListMode1Box.Controls.Add(TitleButtonMode1, 1, i - 1)

                    'Crée un contrôle pour lancer la liste avec le mode 2

                    Dim TitleButtonMode2 As New ButtonMessageBox
                    TitleButtonMode2.initialize("Démarrer la liste à partir de la colonne " + titleName, titleName, color, inversedColor, i, DialogResult.OK)
                    TitleButtonMode2.Dock = DockStyle.Fill
                    TitleButtonMode2.BackColor = color
                    TitleButtonMode2.ForeColor = inversedColor
                    AddHandler TitleButtonMode2.ActionButtonClicked, AddressOf LaunchMode2ButtonClicked

                    LaunchListMode2Box.RowStyles.Insert(i - 1, New RowStyle(SizeType.AutoSize))
                    LaunchListMode2Box.Controls.Add(TitleButtonMode2, 1, i - 1)

                End If
            Next
        End If

        Return ShowDialog()
    End Function

    ''' <summary>
    ''' Quand le bouton pour éditer la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditButtonClicked(sender As ButtonMessageBox, e As EventArgs) Handles EditListBox.ActionButtonClicked
        openResult = values.dialogs.OpenListResults.edit
    End Sub

    ''' <summary>
    ''' Quand un bouton pour lancer la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LaunchMode1ButtonClicked(sender As ButtonMessageBox, e As EventArgs)
        Me.launchColumnNumber = sender.actionValue
        openResult = values.dialogs.OpenListResults.launchMode1
    End Sub

    Private Sub LaunchMode2ButtonClicked(sender As ButtonMessageBox, e As EventArgs)
        Me.launchColumnNumber = sender.actionValue
        openResult = values.dialogs.OpenListResults.launchMode2
    End Sub

End Class