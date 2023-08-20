''' <summary>
''' Boite de dialogue SchoolHelp
''' </summary>
Public Class SchoolHelpDialog

    ''' <summary>
    ''' Obtient le texte entré quand le dialogue comporte une TextBox
    ''' </summary>
    Public enteredText As String

    ''' <summary>
    ''' Obtient la valeur sélectionnée quand le dialogue comporte un NumericUpDown
    ''' </summary>
    Public selectedValue As Integer

    ''' <summary>
    ''' Obtient la couleur sélectionnée quand le dialogue comporte des boutons de couleurs
    ''' </summary>
    Public selectedColor As Color

    ''' <summary>
    ''' Affiche un dialogue
    ''' </summary>
    ''' <param name="message">Le message à afficher</param>
    ''' <param name="dialogType">Le type de dialogue</param>
    Public Overloads Function ShowDialog(message As String, dialogType As Values.Dialogs.DialogsTypes) As DialogResult
        messageLabel.Text = message
        If dialogType = Values.Dialogs.DialogsTypes.Ok Then
            Dim okButton As New Button

            initialiseButton(okButton, DialogResult.OK, "Ok")

            dialogBox.Controls.Add(okButton, 0, 1)
        ElseIf dialogType = Values.Dialogs.DialogsTypes.YesNo Then
            Dim yesButton As New Button
            Dim noButton As New Button

            divideDialogBox(2)

            initialiseButton(yesButton, DialogResult.Yes, "Oui")
            initialiseButton(noButton, DialogResult.No, "Non")

            dialogBox.Controls.Add(yesButton, 0, 1)
            dialogBox.Controls.Add(noButton, 1, 1)

        ElseIf dialogType = Values.Dialogs.DialogsTypes.Text Then
            Dim textTextBox As New TextBox
            Dim okButton As New Button
            Dim cancelButton As New Button

            divideDialogBox(2, {textTextBox}.ToList)

            initialiseTextBox(textTextBox, "")
            initialiseButton(okButton, DialogResult.OK, "Ok")
            initialiseButton(cancelButton, DialogResult.Cancel, "Annuler")

            dialogBox.Controls.Add(textTextBox, 0, 1)
            dialogBox.Controls.Add(okButton, 0, 2)
            dialogBox.Controls.Add(cancelButton, 1, 2)

        ElseIf dialogType = Values.Dialogs.DialogsTypes.Numeric Then
            Dim numberNumericUpDown As New NumericUpDown
            Dim okButton As New Button
            Dim cancelButton As New Button

            divideDialogBox(2, {numberNumericUpDown}.ToList)

            initialiseNumericUpDown(numberNumericUpDown, 0)
            initialiseButton(okButton, DialogResult.OK, "Ok")
            initialiseButton(cancelButton, DialogResult.Cancel, "Annuler")

            dialogBox.Controls.Add(numberNumericUpDown, 0, 1)
            dialogBox.Controls.Add(okButton, 0, 2)
            dialogBox.Controls.Add(cancelButton, 1, 2)
        Else
            Using noSupportedDialogType As New SchoolHelpDialog
                noSupportedDialogType.ShowDialog("Le type de dialogue spécifié n'est pas supporté.", Values.Dialogs.DialogsTypes.Ok)
            End Using
        End If
        Return ShowDialog()
    End Function


    Public Overloads Function ShowDialog(message As String, colorsList As List(Of Color), dialogType As values.dialogs.DialogsTypes) As DialogResult
        messageLabel.Text = message
        If dialogType = values.dialogs.DialogsTypes.Colors Then
            divideDialogBox(colorsList.Count)
            For i = 1 To colorsList.Count
                Dim colorButton As New Button
                initialiseButton(colorButton, DialogResult.OK, colorsList(i - 1))
                dialogBox.Controls.Add(colorButton)
            Next
        Else
            Using noSupportedDialogType As New SchoolHelpDialog
                noSupportedDialogType.ShowDialog("Le type de dialogue spécifié n'est pas supporté.", values.dialogs.DialogsTypes.Ok)
            End Using
        End If
        Return ShowDialog()
    End Function

#Region "Division de la boite de dialogue"

    ''' <summary>
    ''' Divise la boite de dialogue
    ''' </summary>
    ''' <param name="number">Le nombre de division</param>
    Private Sub divideDialogBox(number As Integer)
        dialogBox.ColumnCount = number
        For i = 1 To number
            dialogBox.ColumnStyles.Insert(i - 1, New ColumnStyle(SizeType.Percent, 100 / number))
        Next
        dialogBox.SetColumnSpan(messageLabel, number)
    End Sub

    ''' <summary>
    ''' Divise la boite de dialogue
    ''' </summary>
    ''' <param name="number">Le nombre de division</param>
    ''' <param name="extraControls">La liste contenant les contrôles supplémentaires</param>
    Private Sub divideDialogBox(number As Integer, extraControls As IEnumerable(Of Control))
        dialogBox.RowCount = extraControls.Count + 2
        For i = 1 To extraControls.Count
            dialogBox.RowStyles.Insert(i, New RowStyle(SizeType.AutoSize))
        Next
        divideDialogBox(number)
        For i = 1 To extraControls.Count
            dialogBox.SetColumnSpan(extraControls(i - 1), number)
        Next
    End Sub

#End Region

#Region "Initialisation des contôles"

    ''' <summary>
    ''' Initialise un bouton
    ''' </summary>
    ''' <param name="button">Le bouton à initialiser</param>
    ''' <param name="dialogResult">Le résultat du dialogue quand l'utilisateur clique sur ce bouton</param>
    ''' <param name="text">Le texte à afficher sur le bouton</param>
    Private Sub initialiseButton(button As Button, dialogResult As DialogResult, text As String)
        button.Dock = DockStyle.Fill
        button.AutoSize = True
        button.Font = New Font(FontFamily.GenericSansSerif, 20)
        button.DialogResult = dialogResult
        button.Text = text
        button.BackColor = Me.BackColor
        button.ForeColor = Me.ForeColor
    End Sub

    ''' <summary>
    ''' Initialise un bouton de couleur
    ''' </summary>
    ''' <param name="button">Le bouton à initialiser</param>
    ''' <param name="dialogResult">Le résultat du dialogue quand l'utilisateur clique sur ce bouton</param>
    ''' <param name="backColor">La couleur du bouton</param>
    Private Sub initialiseButton(button As Button, dialogResult As DialogResult, backColor As Color)
        button.Dock = DockStyle.Fill
        button.AutoSize = True
        button.MinimumSize = New Size(50, 50)
        button.DialogResult = dialogResult
        button.BackColor = backColor
        AddHandler button.Click, AddressOf colorButtonClicked
    End Sub

    ''' <summary>
    ''' Initialise une TextBox
    ''' </summary>
    ''' <param name="startText">Le texte à afficher</param>
    Private Sub initialiseTextBox(textBox As TextBox, startText As String)
        textBox.Dock = DockStyle.Fill
        textBox.Font = New Font(FontFamily.GenericSansSerif, 20)
        textBox.TextAlign = HorizontalAlignment.Center
        textBox.Text = startText
        AddHandler textBox.TextChanged, AddressOf textBoxTextChanged
    End Sub

    ''' <summary>
    ''' Initialise un NumericUpDown
    ''' </summary>
    ''' <param name="numericUpDown"></param>
    ''' <param name="startValue"></param>
    Private Sub initialiseNumericUpDown(numericUpDown As NumericUpDown, startValue As Integer)
        numericUpDown.Dock = DockStyle.Fill
        numericUpDown.Font = New Font(FontFamily.GenericSansSerif, 20)
        numericUpDown.TextAlign = HorizontalAlignment.Center
        numericUpDown.Value = startValue
        AddHandler numericUpDown.ValueChanged, AddressOf numericUpDownValueChanged
    End Sub

#End Region

#Region "Evenements"

    ''' <summary>
    ''' Quand le texte de la TextBox change
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub textBoxTextChanged(sender As TextBox, e As EventArgs)
        Me.enteredText = sender.Text
    End Sub

    ''' <summary>
    ''' Quand le valeur du NumericUpDownChange
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub numericUpDownValueChanged(sender As NumericUpDown, e As EventArgs)
        Me.selectedValue = sender.Value
    End Sub

    ''' <summary>
    ''' Quand un bouton de couleur est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub colorButtonClicked(sender As Button, e As EventArgs)
        Me.selectedColor = sender.BackColor
    End Sub

#End Region
End Class