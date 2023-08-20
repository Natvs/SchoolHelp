Public Class LaunchListDialog

    ''' <summary>
    ''' Obtient le mode de lancement de la liste
    ''' </summary>
    Private launchMode As LaunchModes

    ''' <summary>
    ''' Obtient les différents modes de lancements de la liste
    ''' </summary>
    Public Enum LaunchModes
        ''' <summary>
        ''' Les items affichés sont choisis au hasard dans la liste.
        ''' </summary>
        Mode1
        ''' <summary>
        ''' La liste est organisée au hasard, permettant d'interroger sur tous les items.
        ''' </summary>
        Mode2
    End Enum

    ''' <summary>
    ''' Obtient la liste contenant les titres de la liste
    ''' </summary>
    Private titlesList As List(Of String)

    ''' <summary>
    ''' Obtient le nombre de titres de la liste
    ''' </summary>
    Private titlesNumber As Integer

    ''' <summary>
    ''' Obtient le numéro du titre donné pour lancer la liste
    ''' </summary>
    Private givenTitle As Integer

    ''' <summary>
    ''' Obtient la liste contenant les items de la liste
    ''' </summary>
    Private itemsList As List(Of List(Of String))

    ''' <summary>
    ''' Obtient le numéro de l'item actuel
    ''' </summary>
    Private currentItemNumber As Integer

    ''' <summary>
    ''' Obtient la liste od
    ''' </summary>
    Private itemsRandomList As List(Of List(Of String))

    ''' <summary>
    ''' Obtient la liste contenant les instances TextMessageBox
    ''' </summary>
    Private itemsTextMessagesList As New List(Of TextMessageBox)

    ''' <summary>
    ''' Obtient la liste contenant les instances Label
    ''' </summary>
    Private itemsLabelList As New List(Of Label)

    ''' <summary>
    ''' Obtient la couleur de la liste
    ''' </summary>
    Private listColor As Color

    ''' <summary>
    ''' Afiche le dialogue de lancement de la liste
    ''' </summary>
    ''' <param name="titlesList">La liste contenant les titres de la liste</param>
    ''' <param name="itemsList">La liste contenant les items de la liste</param>
    ''' <param name="givenTitle">L'index du titre donné</param>
    ''' <param name="listColor">La couleur de la liste</param>
    ''' <param name="launchMode">Le mode de lancement de la liste</param>
    Public Overloads Sub ShowDialog(titlesList As List(Of String), itemsList As List(Of List(Of String)), givenTitle As Integer, listColor As Color, launchMode As LaunchModes)
        Me.launchMode = launchMode
        Me.titlesList = titlesList
        Me.itemsList = itemsList
        Me.titlesNumber = titlesList.Count
        Me.givenTitle = givenTitle
        Me.currentItemNumber = 0

        Me.BackColor = listColor
        SearchButton.BackColor = listColor
        CheckButton.BackColor = listColor
        ShowAnswersButton.BackColor = listColor
        CloseButton.BackColor = listColor

        Dim inversedColor As Color = Values.ColorValue.Inverse(listColor)

        Me.ForeColor = inversedColor
        LeftItemsLabel.ForeColor = inversedColor
        SearchButton.ForeColor = inversedColor
        CheckButton.ForeColor = inversedColor
        ShowAnswersButton.ForeColor = inversedColor
        CloseButton.ForeColor = inversedColor

        ItemsBox.ColumnCount = Me.titlesNumber
        For i = 1 To titlesNumber
            ItemsBox.ColumnStyles.Insert(i - 1, New ColumnStyle(SizeType.Percent, 100 / Me.titlesNumber))

            Dim itemTextMessage As New TextMessageBox
            itemTextMessage.Initialize(titlesList(i - 1), Nothing, listColor, inversedColor)
            itemTextMessage.Dock = DockStyle.Fill
            itemsTextMessagesList.Add(itemTextMessage)
            ItemsBox.Controls.Add(itemTextMessage, i - 1, 0)

            Dim itemLabel As New Label
            itemLabel.TextAlign = ContentAlignment.TopCenter
            itemLabel.Font = New Font(FontFamily.GenericSansSerif, 15)
            itemLabel.ForeColor = inversedColor
            itemLabel.Text = ""
            itemLabel.Dock = DockStyle.Fill
            itemsLabelList.Add(itemLabel)
            ItemsBox.Controls.Add(itemLabel, i - 1, 1)
        Next

        If launchMode = LaunchModes.Mode1 Then
            LeftItemsLabel.Text = ""
        ElseIf launchMode = LaunchModes.Mode2 Then
            Me.itemsRandomList = Values.ListValue.GetRandomList(Me.itemsList)
            LeftItemsLabel.Text = "Items restants : " + Me.itemsRandomList.Count.ToString
        End If

        SearchForItem()
        ShowDialog()
    End Sub

#Region "Searching"

    ''' <summary>
    ''' Quand le bouton pour lancer la liste est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub searchForItem(sender As Button, e As EventArgs) Handles SearchButton.Click
        SearchForItem()
    End Sub

    ''' <summary>
    ''' Lance la liste
    ''' </summary>
    Private Sub SearchForItem()
        If Me.launchMode = LaunchModes.Mode1 Then
            For i = 1 To Me.titlesNumber
                itemsTextMessagesList(i - 1).EditText("")
                itemsTextMessagesList(i - 1).EditText(Color.Black)
                itemsLabelList(i - 1).Text = ""
            Next

            Dim random As New Random
            Me.currentItemNumber = random.Next(1, itemsList.Count + 1)

            Dim givenItem As String
            givenItem = itemsList(Me.currentItemNumber - 1)(Me.givenTitle - 1)
            itemsTextMessagesList(Me.givenTitle - 1).EditText(givenItem)
        ElseIf launchMode = LaunchModes.Mode2 Then
            If currentItemNumber = itemsRandomList.Count Then
                Using messageDialog As New SchoolHelpDialog
                    messageDialog.ShowDialog("Vous avez terminé la liste.", Values.Dialogs.DialogsTypes.Ok)
                End Using
            Else
                For i = 1 To Me.titlesNumber
                    itemsTextMessagesList(i - 1).EditText("")
                    itemsTextMessagesList(i - 1).EditText(Color.Black)
                    itemsLabelList(i - 1).Text = ""
                Next

                Me.currentItemNumber = Me.currentItemNumber + 1
                LeftItemsLabel.Text = "Items restants : " + (Me.itemsRandomList.Count - Me.currentItemNumber).ToString

                Dim givenItem As String
                givenItem = itemsRandomList(Me.currentItemNumber - 1)(Me.givenTitle - 1)
                itemsTextMessagesList(Me.givenTitle - 1).EditText(givenItem)
            End If
        End If
    End Sub

#End Region

#Region "Checking"

    ''' <summary>
    ''' Quand le bouton pour vérifier les items est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckItems(sender As Button, e As EventArgs) Handles CheckButton.Click
        CheckItems()
    End Sub

    ''' <summary>
    ''' Vérifie si tous les items sont corrects
    ''' </summary>
    Private Sub CheckItems()
        If launchMode = LaunchModes.Mode1 Then
            For i = 1 To titlesNumber
                If itemsTextMessagesList(i - 1).enteredText <> "" Then
                    If itemsTextMessagesList(i - 1).enteredText = itemsList(Me.currentItemNumber - 1)(i - 1) Then
                        itemsTextMessagesList(i - 1).EditText(listsApp.lists.colors.goodColor)
                    Else
                        itemsTextMessagesList(i - 1).EditText(listsApp.lists.colors.badColor)
                    End If
                End If
            Next
        ElseIf launchMode = LaunchModes.Mode2 Then
            For i = 1 To titlesNumber
                If itemsTextMessagesList(i - 1).enteredText <> "" Then
                    If itemsTextMessagesList(i - 1).enteredText = itemsRandomList(Me.currentItemNumber - 1)(i - 1) Then
                        itemsTextMessagesList(i - 1).EditText(listsApp.lists.colors.goodColor)
                    Else
                        itemsTextMessagesList(i - 1).EditText(listsApp.lists.colors.badColor)
                    End If
                End If
            Next
        End If
    End Sub

#End Region

#Region "Answers"

    ''' <summary>
    ''' Quand le bouton pour montrer les réponses est cliqué
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowAnswers(sender As Button, e As EventArgs) Handles ShowAnswersButton.Click
        ShowAnswers()
    End Sub

    ''' <summary>
    ''' Montre les réponses
    ''' </summary>
    Private Sub ShowAnswers()
        If launchMode = LaunchModes.Mode1 Then
            For i = 1 To titlesNumber
                itemsLabelList(i - 1).Text = itemsList(Me.currentItemNumber - 1)(i - 1)
            Next
        ElseIf launchMode = LaunchModes.Mode2 Then
            For i = 1 To titlesNumber
                itemsLabelList(i - 1).Text = itemsRandomList(Me.currentItemNumber - 1)(i - 1)
            Next
        End If
    End Sub

#End Region

End Class