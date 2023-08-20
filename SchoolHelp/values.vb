Namespace Values

    ''' <summary>
    ''' Permet de définir un interval
    ''' </summary>
    Public Class Interval

        Private minValue As Decimal
        Private isMinValueHeld As Boolean

        Private maxValue As Decimal
        Private isMaxValueHeld As Boolean

        ''' <summary>
        ''' Obtient les positions dans l'intervalle
        ''' </summary>
        Enum Positions
            ''' <summary>
            ''' Obtient l'emplacement avant l'ouverture de l'intervalle
            ''' </summary>
            startPos
            ''' <summary>
            ''' Obtient l'emplacement avant la fermeture de l'intervalle
            ''' </summary>
            endPos
        End Enum

        ''' <summary>
        ''' Initialise un nouvel interval
        ''' </summary>
        ''' <param name="minValue">La plus petite valeur de l'intervalle</param>
        ''' <param name="isMinValueHeld">Indique si la plus petite valeur est comprise</param>
        ''' <param name="maxValue">La plus grande valeur de l'intervalle</param>
        ''' <param name="isMaxValueHeld">Indique si la plus grande valeur est comprise</param>
        Sub New(minValue As Decimal, isMinValueHeld As Boolean, maxValue As Decimal, isMaxValueHeld As Boolean)
            setInterval(minValue, isMinValueHeld, maxValue, isMaxValueHeld)
        End Sub

        ''' <summary>
        ''' Initialise un nouvel interval à partir des données d'un intervalle déjà existant.
        ''' </summary>
        ''' <param name="value">L'intervalle déjà existant à copier</param>
        Sub New(value As Interval)
            setInterval(value.getMinValue, value.isValueHeld(value.getMinValue), value.getMaxValue, value.isValueHeld(value.getMaxValue))
        End Sub

        'Initialiser ou modifier l'interval

        ''' <summary>
        ''' Initialise l'intervalle
        ''' </summary>
        ''' <param name="minValue">La plus petite valeur de l'intervalle</param>
        ''' <param name="isMinValueHeld">Indique si la plus petite valeur est comprise</param>
        ''' <param name="maxValue">La plus grande valeur de l'intervalle</param>
        ''' <param name="isMaxValueHeld">Indique si la plus grande valeur est comprise</param>
        Public Sub setInterval(minValue As Decimal, isMinValueHeld As Boolean, maxValue As Decimal, isMaxValueHeld As Boolean)
            Me.minValue = minValue
            Me.isMinValueHeld = isMinValueHeld
            Me.maxValue = maxValue
            Me.isMaxValueHeld = isMaxValueHeld
        End Sub

        ''' <summary>
        ''' Initialise l'intervalle depuis une chaine de caractère adapté au format de sauvegarde des intervalles.
        ''' </summary>
        ''' <param name="text">La chaîne de caractère au format de sauvegarde d'intervalle</param>
        Public Sub setInterval(text As String)
            Dim loadingList As New List(Of String)
            loadingList = Values.ListValue.GetList(text, ListValue.DisplayListMode.bar)
            setInterval(loadingList(1), Values.BooleanValue.fromString(loadingList(0)), loadingList(3), Values.BooleanValue.fromString(loadingList(2)))
        End Sub

        ''' <summary>
        ''' Initialise cet interval à partir des données d'un interval déjà existant.
        ''' </summary>
        ''' <param name="value">L'intervalle déjà existant à copier</param>
        Public Sub fromInterval(value As Interval)
            setInterval(value.getMinValue, value.isValueHeld(value.getMinValue), value.getMaxValue, value.isValueHeld(value.getMaxValue))
        End Sub

        ''' <summary>
        ''' Modifie la valeur inférieure de l'intervalle
        ''' </summary>
        ''' <param name="minValue">La plus petite valeur de l'intervalle</param>
        Public Sub setMinValue(minValue As Decimal)
            Me.minValue = minValue
        End Sub

        ''' <summary>
        ''' Modifie la valeur inférieure de l'intervalle
        ''' </summary>
        ''' <param name="minValue">La plus petite valeur de l'intervalle</param>
        ''' <param name="isMinValueHeld">Indique si la plus petite valeur est comprise</param>
        Public Sub setMinValue(minValue As Decimal, isMinValueHeld As Boolean)
            setMinValue(minValue)
            Me.isMinValueHeld = isMinValueHeld
        End Sub

        ''' <summary>
        ''' Modifie la valeur supérieure de l'intervalle
        ''' </summary>
        ''' <param name="maxValue">La plus grande valeur de l'intervalle</param>
        Public Sub setMaxValue(maxValue As Decimal)
            Me.maxValue = maxValue
        End Sub

        ''' <summary>
        ''' Modifie la valeur supérieure de l'intervalle
        ''' </summary>
        ''' <param name="maxValue">La plus grande valeur de l'intervalle</param>
        ''' <param name="isMaxValueHeld">Indique si la plus grande valeur est comprise</param>
        Public Sub setMaxValue(maxValue As Decimal, isMaxValueHeld As Boolean)
            Me.maxValue = maxValue
            setMaxValue(maxValue)
        End Sub

        'Fonctions sur les valeurs

        ''' <summary>
        ''' Obtient un booléen indiquant si la valeur entrée est comprise dans l'intervalle.
        ''' </summary>
        ''' <param name="value">La valeur dont l'appartenance à l'intervalle doit être vérifiée</param>
        ''' <returns>Un booléen indiquant si la valeur est comprise dans l'intervalle</returns>
        Public Function isValueHeld(value As Decimal) As Boolean
            If value > minValue And value < maxValue Then
                Return True
            ElseIf value = minValue And isMinValueHeld Then
                Return True
            ElseIf value = maxValue And isMaxValueHeld Then
                Return True
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Obtient la valeur inférieure de l'intervalle.
        ''' </summary>
        ''' <returns>La valuer inférieure</returns>
        Public Function getMinValue() As Decimal
            Return minValue
        End Function

        ''' <summary>
        ''' Obtient la valeur supérieure de l'intervalle.
        ''' </summary>
        ''' <returns>La valuer supérieure</returns>
        Public Function getMaxValue() As Decimal
            Return maxValue
        End Function

        'Autres fonctions

        ''' <summary>
        ''' Obtient les modes d'affichages d'un intervalle
        ''' </summary>
        Enum DisplayMode
            ''' <summary>
            ''' Indique que l'intervalle est affiché sous forme d'intervalle mathématique
            ''' </summary>
            math
            ''' <summary>
            ''' Indique que l'invtervalle est affiché sous forme d'intervalle à sauvegarder
            ''' </summary>
            saving
        End Enum

        ''' <summary>
        ''' Obtient une chaîne de caractères sous forme d'intervalle mathématique représentant cette instance
        ''' </summary>
        Public Function GetString(mode As DisplayMode) As String
            Dim intervalText As String
            If mode = DisplayMode.math Then
                intervalText = getBorder(isMinValueHeld, Positions.startPos) + minValue.ToString + ";" + maxValue.ToString + getBorder(isMaxValueHeld, Positions.endPos)
            ElseIf mode = DisplayMode.saving Then
                Dim displayingList As New List(Of String)
                displayingList.Add(Values.BooleanValue.getString(isMinValueHeld))
                displayingList.Add(minValue.ToString)
                displayingList.Add(Values.BooleanValue.getString(isMaxValueHeld))
                displayingList.Add(maxValue.ToString)
                intervalText = Values.ListValue.DisplayList(displayingList, ListValue.DisplayListMode.bar)
            Else
                intervalText = Nothing
            End If
            Return intervalText
        End Function

        ''' <summary>
        ''' Obtient le symbole de l'extrémitè de l'intervalle
        ''' </summary>
        ''' <param name="isValueHeld">La valeur qui indique si cette valeur est comprise dans l'intervalle.</param>
        ''' <param name="position">La position de la valeur dans l'intervalle.</param>
        Private Function getBorder(isValueHeld As Boolean, position As Positions) As String
            If isValueHeld Then
                If position = Positions.startPos Then
                    Return "["
                ElseIf position = Positions.endPos Then
                    Return "]"
                Else
                    Return "<Erreur>"
                End If
            ElseIf Not isValueHeld Then
                If position = Positions.startPos Then
                    Return "]"
                ElseIf position = Positions.endPos Then
                    Return "["
                Else
                    Return "<Erreur>"
                End If
            Else
                Return "<Erreur>"
            End If
        End Function

    End Class

    ''' <summary>
    ''' Représente un numéro de couleur
    ''' </summary>
    Public Class NumericColor

        ''' <summary>
        ''' Obtient le numéro de la couleur
        ''' </summary>
        Private colorNumber As Integer

        ''' <summary>
        ''' Initialise une nouvelle instance de NumberedColor
        ''' </summary>
        ''' <param name="value">Le numéro de la couleur</param>
        Sub New(value As Integer)
            setNumber(value)
        End Sub

        ''' <summary>
        ''' Initialise une nouvelle instance de NumberedColor à partir des données d'une instance NumberedColor existante.
        ''' </summary>
        ''' <param name="value"></param>
        Sub New(value As NumericColor)
            setNumber(value.getNumber())
        End Sub

        ''' <summary>
        ''' Initialise le numéro de la couleur.
        ''' </summary>
        ''' <param name="value">Le numéro de la couleur</param>
        Public Sub setNumber(value As Integer)
            Me.colorNumber = value
        End Sub

        ''' <summary>
        ''' Initialise cette instance à partir des données d'une instance NumberedColor déjà existante.
        ''' </summary>
        ''' <param name="value">L'instance ColoredNumber déjà existante à copier</param>
        Public Sub fromColoredNumber(value As NumericColor)
            setNumber(value.getNumber())
        End Sub

        ''' <summary>
        ''' Obtient le numéro de la couleur.
        ''' </summary>
        ''' <returns>Le numéro de la couleur</returns>
        Public Function getNumber() As Integer
            Return colorNumber
        End Function

        ''' <summary>
        ''' Obtient la couleur correspondante au numéro.
        ''' </summary>
        ''' <param name="colorsList"></param>
        ''' <returns>La couleur correspondante au numéro</returns>
        Public Function getColor(colorsList As List(Of Color)) As Color
            If colorNumber <= colorsList.Count Then
                Return colorsList(colorNumber)
            Else
                Using errorMessage As New SchoolHelpDialog
                    errorMessage.ShowDialog("L'entier <colorNumber> spécifié n'est pas compris dans la liste <colorsList>" + vbNewLine + "colorNumber = " + colorNumber.ToString + vbNewLine + "colorsList.Count = " + colorsList.Count.ToString + vbNewLine + "La couleur à été initialisée à la première couleur de <ColorsList>", dialogs.DialogsTypes.Ok)
                End Using
                Return colorsList(0)
            End If
        End Function

    End Class

    ''' <summary>
    ''' Contient les différents modes de recherches
    ''' </summary>
    Enum FindMode
        ''' <summary>
        ''' Spécifie que la recherche est basée sur les items de la liste
        ''' </summary>
        item
        ''' <summary>
        ''' Spécifie que la recherche est basée sur le contenu des items de la liste
        ''' </summary>
        inItem
    End Enum

    Namespace Dialogs

        ''' <summary>
        ''' Contient les différents dialogues possibles
        ''' </summary>
        Public Enum DialogsTypes
            ''' <summary>
            ''' Spécifie que le dialogue contient un message et un bouton OK
            ''' </summary>
            Ok
            ''' <summary>
            ''' Spécifie que le dialogue contient un message, une TextBox, un bouton OK et un bouton ANNULER
            ''' </summary>
            Text
            ''' <summary>
            ''' Spécifie que le dialogue contient un message, un NumericUpDown, un bouton OK et un bouton ANNULER
            ''' </summary>
            Numeric
            ''' <summary>
            ''' Spécifie que le dialogue contient un message, un bouton OUI et un bouton NON
            ''' </summary>
            YesNo
            ''' <summary>
            ''' Spécifie que le dialogue contient un message et des boutons de couleurs
            ''' </summary>
            Colors
        End Enum

        ''' <summary>
        ''' Contient les différents résultats possibles du dialogue d'ouverture d'une liste
        ''' </summary>
        Public Enum OpenListResults
            ''' <summary>
            ''' Aucune résultat
            ''' </summary>
            none
            ''' <summary>
            ''' Modification des listes
            ''' </summary>
            edit
            ''' <summary>
            ''' Lancement de la liste avec le mode 1
            ''' </summary>
            launchMode1
            ''' <summary>
            ''' Lancement de la liste avec le mode 2
            ''' </summary>
            launchMode2
        End Enum

    End Namespace


    ''' <summary>
    ''' Donne accès à des méthodes sur les chaînes de caractères
    ''' </summary>
    Structure StringValue

        ''' <summary>
        ''' Obtient une valeur indiquant si la chaîne de caractère contient un des textes spécifiés
        ''' </summary>
        ''' <param name="text">La chaîne de caractère</param>
        ''' <param name="searchingTextsList">Les textes dont la présence doit être vérifiée dans la chaîne de caractère</param>
        ''' <returns>True si la chaîne de caractère contient un des textes spécifié, sinon False.</returns>
        Shared Function Contains(text As String, searchingTextsList As List(Of String))

            For index = 1 To searchingTextsList.Count()
                If text.Contains(searchingTextsList(index - 1)) Then
                    Return True
                End If
            Next
            Return False

        End Function

    End Structure

    ''' <summary>
    ''' Donne accès à des méthodes sur les valeurs numériques
    ''' </summary>
    Structure NumericValue

        ''' <summary>
        ''' Obtient la plus petite valeur.
        ''' </summary>
        ''' <param name="numericsList">La liste contenant les valeurs à comparer</param>
        ''' <returns>La plus petite valeur</returns>
        Shared Function getMin(numericsList As List(Of Integer)) As Integer
            Dim currentValue As Integer = numericsList(0)
            For i = 1 To numericsList.Count
                If numericsList(i - 1) < currentValue Then
                    currentValue = numericsList(i - 1)
                End If
            Next
            Return currentValue
        End Function

        ''' <summary>
        ''' Obtient la plus petite valeur.
        ''' </summary>
        ''' <param name="numericsList">La liste contenant les valeurs à comparer</param>
        ''' <returns>La plus petite valeur</returns>
        Shared Function getMin(numericsList As List(Of Decimal)) As Decimal
            Dim currentValue As Decimal = numericsList(0)
            For i = 1 To numericsList.Count
                If numericsList(i - 1) < currentValue Then
                    currentValue = numericsList(i - 1)
                End If
            Next
            Return currentValue
        End Function

        ''' <summary>
        ''' Obtient la plus grande valeur.
        ''' </summary>
        ''' <param name="numericsList">La liste contenant les valeurs à comparer</param>
        ''' <returns>La plus grande valeur</returns>
        Shared Function getMax(numericsList As List(Of Integer)) As Integer
            Dim currentValue As Integer = numericsList(0)
            For i = 1 To numericsList.Count
                If numericsList(i - 1) > currentValue Then
                    currentValue = numericsList(i - 1)
                End If
            Next
            Return currentValue
        End Function

        ''' <summary>
        ''' Obtient la plus grande valeur.
        ''' </summary>
        ''' <param name="numericsList">La liste contenant les valeurs à comparer</param>
        ''' <returns>La plus grande valeur</returns>
        Shared Function getMax(numericsList As List(Of Decimal)) As Decimal
            Dim currentValue As Decimal = numericsList(0)
            For i = 1 To numericsList.Count
                If numericsList(i - 1) > currentValue Then
                    currentValue = numericsList(i - 1)
                End If
            Next
            Return currentValue
        End Function

    End Structure

    Structure BooleanValue

        ''' <summary>
        ''' Obtient la chaîne de caractère correspondant à la valeur booléenne.
        ''' </summary>
        ''' <param name="value">La valeur booléenne</param>
        ''' <returns>Une chaîne de caractère correspondante à la valeur entrée</returns>
        Shared Function getString(value As Boolean) As String
            If value = True Then
                Return "True"
            Else
                Return "False"
            End If
        End Function

        ''' <summary>
        ''' Obtient la valeur booléenne correspondante à la chaîne de caractère entrée.
        ''' </summary>
        ''' <param name="value">La chaîne de caractère</param>
        ''' <returns>Une valeur booléenne correspondante à la valeur entrée</returns>
        Shared Function fromString(value As String) As Boolean
            If value = "True" Then
                Return True
            ElseIf value = "False" Then
                Return False
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Obtient la valeur booléenne correspondante à la chaîne de caractère entrée.
        ''' </summary>
        ''' <param name="value">La chaîne de caractère</param>
        ''' <returns>Une valeur booléenne correspondante à la valeur entrée</returns>
        Shared Function fromString(value As String, showErrorDialog As Boolean) As Boolean
            If value = "True" Then
                Return True
            ElseIf value = "False" Then
                Return False
            Else
                If showErrorDialog Then
                    Using errorDialog As New SchoolHelpDialog
                        errorDialog.ShowDialog("Impossible de convertir la chaîne de caractère <" + value + "> en valeur booléenne." + vbNewLine + "La valeur à été initialisée à <False>.", dialogs.DialogsTypes.Ok)
                    End Using
                End If
                Return False
            End If
        End Function

    End Structure

    ''' <summary>
    ''' Donne accès à des méthodes sur les couleurs
    ''' </summary>
    Structure ColorValue

        ''' <summary>
        ''' Obtient la couleur par défaut
        ''' </summary>
        Shared ReadOnly defaultColor As Color = Color.White

        ''' <summary>
        ''' Obtient la couleur inverse
        ''' </summary>
        ''' <param name="color">La couleur à inverser</param>
        ''' <returns>La couleur opposée à la couleur entrée</returns>
        Shared Function Inverse(color As Color) As Color
            Dim newColor As Color = Color.FromArgb(color.A, 255 - color.R, 255 - color.G, 255 - color.B)
            Return newColor
        End Function

        ''' <summary>
        ''' Obtient une couleur à partir d'un entier ARGB
        ''' </summary>
        ''' <param name="colorInteger">L'entier ARGB</param>
        ''' <returns>La couleur correspondante à l'entier spécifié</returns>
        Shared Function FromARGBInteger(colorInteger As Integer) As Color
            If colorInteger = Nothing Then
                Return defaultColor
            Else
                Dim newColor As Color = Color.FromArgb(colorInteger)
                Return newColor
            End If
        End Function

        ''' <summary>
        ''' Obtient un entier ARGB correspondant à une couleur spécifiée
        ''' </summary>
        ''' <param name="color">La couleur spécifiée</param>
        ''' <returns>Un entier ARGB correspondante à la couleur</returns>
        Shared Function GetARGBInteger(color As Color) As Integer
            If color = Nothing Then
                Return defaultColor.ToArgb
            Else
                Dim newInteger As Integer = color.ToArgb()
                Return newInteger
            End If
        End Function

        ''' <summary>
        ''' Obtient une couleur à partir d'un nom de couleur
        ''' </summary>
        ''' <param name="colorName"></param>
        ''' <returns></returns>
        Shared Function FromName(colorName As String) As Color
            If colorName = Nothing Then
                Return defaultColor
            Else
                Dim newColor As Color = Color.FromName(colorName)
                Return newColor
            End If
        End Function

        ''' <summary>
        ''' Obtient le nom de la couleur spécifiée
        ''' </summary>
        ''' <param name="color">La couleur spécifiée</param>
        ''' <returns>Le nom de la couleur spécifiée</returns>
        Shared Function GetName(color As Color) As String
            If color = Nothing Then
                Return defaultColor.Name
            Else
                Dim newName As String = color.Name
                Return newName
            End If
        End Function

    End Structure

    ''' <summary>
    ''' Donne accès à des méthodes sur les répertoires
    ''' </summary>
    Structure Directory

        ''' <summary>
        ''' Obtient la liste des caractères interdits pour un nom de répertoire
        ''' </summary>
        Shared ReadOnly forbiddenCharList As List(Of Char) = New List(Of Char) From {"|", "\", "/", ".", "?", "!", ",", "<", ">", ":", "*"}

        ''' <summary>
        ''' Obtient une valeur qui définit si le dossier existe
        ''' </summary>
        ''' <param name="path">Le chemin du dossier</param>
        ''' <returns>La valeur définissant si le dossier existe</returns>
        Shared Function Exists(path As String) As Boolean
            If FileIO.FileSystem.FileExists(path) Then
                Return True
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Renome un dossier
        ''' </summary>
        ''' <param name="path">Le chemin du dossier à renommer</param>
        ''' <param name="name">Le nom du dossier</param>
        ''' <param name="newName">Le nouveau nom du dossier</param>
        Shared Sub Rename(path As String, name As String, newName As String)
            If name <> newName Then
                FileIO.FileSystem.RenameDirectory(path, newName)
            End If
        End Sub

        ''' <summary>
        ''' Crée un dossier
        ''' </summary>
        ''' <param name="path">Le chemin dans lequel ajouter le dossier</param>
        ''' <param name="name">Le nom du dossier</param>
        ''' <param name="checkName">Indique si le nom doit être vérifié comme un nom valide pour un dossier</param>
        ''' <param name="showMessage">Indique s'il faut afficher un message lorsque le nom n'est pas valide comme nom de dossier</param>
        Shared Sub Create(path As String, name As String, checkName As Boolean, showMessage As Boolean)
            If checkName Then
                If Values.Directory.CheckName(name, showMessage) Then
                    IO.Directory.CreateDirectory(path + "/" + name)
                End If
            Else
                IO.Directory.CreateDirectory(path + "/" + name)
            End If
        End Sub

        ''' <summary>
        ''' Supprime un dossier
        ''' </summary>
        ''' <param name="path">Le chemin du dossier à supprimer</param>
        Shared Sub delete(path As String)
            If IO.Directory.Exists(path) Then
                IO.Directory.Delete(path, True)
            End If
        End Sub

        ''' <summary>
        ''' Vérifie si le nom est valide pour un nom de dossier
        ''' </summary>
        ''' <param name="name">Le nom à valider</param>
        ''' <param name="showMessage">Indique s'il faut montrer un message lorsque le nom n'est pas valide comme nom de dossier</param>
        Shared Function CheckName(name As String, showMessage As Boolean)
            Dim validName As Integer = True
            Dim repeat As Integer = 1
            While repeat <= forbiddenCharList.Count And validName = True
                If name.Contains(forbiddenCharList.Item(repeat - 1)) Then
                    validName = False
                End If
                repeat = repeat + 1
            End While

            If Not validName And showMessage Then
                MessageBox.Show("Les caractères suivants sont interdits pour un nom de dossier : " + vbNewLine + Values.ListValue.DisplayList(forbiddenCharList, ListValue.DisplayListMode.brackets), "Nom de dossier invalide")
            End If

            Return validName
        End Function

        ''' <summary>
        ''' Obtient le dossier contenant le fichier ou le dossier
        ''' </summary>
        ''' <param name="filePath">Le chemin du fichier ou du dossier</param>
        ''' <returns>Le chemin du dossier contenant le fichier ou le dossier</returns>
        Shared Function GetDirectoryPath(filePath As String) As String
            Dim pathList As New List(Of String)
            pathList = filePath.Split("/").ToList

            pathList.RemoveAt(pathList.Count - 1)
            Return Values.ListValue.DisplayList(pathList, ListValue.DisplayListMode.bar)
        End Function

    End Structure

    Structure File

        ''' <summary>
        ''' Obtient la liste des caractères interdits pour un nom de répertoire
        ''' </summary>
        Shared ReadOnly forbiddenCharList As List(Of Char) = New List(Of Char) From {"|", "\", "/", ".", "?", "!", ",", "<", ">", ":", "*"}

        ''' <summary>
        ''' Obtient une valeur qui définit si le fichier existe
        ''' </summary>
        ''' <param name="path">Le chemin du fichier</param>
        ''' <returns>La valeur définissant si le fichier existe</returns>
        Shared Function Exists(path As String) As Boolean
            If FileIO.FileSystem.FileExists(path) Then
                Return True
            Else
                Return False
            End If
        End Function

        ''' <summary>
        ''' Renome un dossier
        ''' </summary>
        ''' <param name="path">Le chemin du dossier à renommer</param>
        ''' <param name="name">Le nom du dossier</param>
        ''' <param name="newName">Le nouveau nom du dossier</param>
        Shared Sub Rename(path As String, name As String, newName As String)
            If name <> newName Then
                FileIO.FileSystem.RenameDirectory(path, newName)
            End If
        End Sub

        ''' <summary>
        ''' Crée un fichier
        ''' </summary>
        ''' <param name="path">Le chemin dans lequel ajouter le fichier</param>
        ''' <param name="name">Le nom du fichier</param>
        ''' <param name="checkName">Indique si le nom doit être vérifié comme un nom valide pour un fichier</param>
        ''' <param name="showMessage">Indique s'il faut afficher un message lorsque le nom n'est pas valide comme nom de fichier</param>
        Shared Sub Create(path As String, name As String, checkName As Boolean, showMessage As Boolean)
            If checkName Then
                If Values.Directory.CheckName(name, showMessage) Then
                    IO.File.Create(path + "/" + name)
                End If
            Else
                IO.File.Create(path + "/" + name)
            End If
        End Sub

        ''' <summary>
        ''' Supprime un fichier
        ''' </summary>
        ''' <param name="path">Le chemin du fichier à supprimer</param>
        Shared Sub Delete(path As String)
            If IO.Directory.Exists(path) Then
                IO.Directory.Delete(path, True)
            End If
        End Sub

        ''' <summary>
        ''' Vérifie si le nom est valide pour un nom de fichier
        ''' </summary>
        ''' <param name="name">Le nom à valider</param>
        ''' <param name="showMessage">Indique s'il faut montrer un message lorsque le nom n'est pas valide comme nom de fichier</param>
        Shared Function CheckName(name As String, showMessage As Boolean)
            Dim validName As Integer = True
            Dim repeat As Integer = 1
            While repeat <= forbiddenCharList.Count And validName = True
                If name.Contains(forbiddenCharList.Item(repeat - 1)) Then
                    validName = False
                End If
                repeat = repeat + 1
            End While

            If Not validName And showMessage Then
                MessageBox.Show("Les caractères suivants sont interdits pour un nom de fichier : " + vbNewLine + Values.ListValue.DisplayList(forbiddenCharList, ListValue.DisplayListMode.brackets), "Nom de dossier invalide")
            End If

            Return validName
        End Function

        ''' <summary>
        ''' Obtient le dossier contenant le fichier
        ''' </summary>
        ''' <param name="filePath">Le chemin du fichier</param>
        ''' <returns>Le chemin du dossier contenant le fichier</returns>
        Shared Function GetDirectoryPath(filePath As String) As String
            Dim pathList As New List(Of String)
            pathList = filePath.Split("/").ToList

            pathList.RemoveAt(pathList.Count - 1)
            Return Values.ListValue.DisplayList(pathList, ListValue.DisplayListMode.bar)
        End Function


    End Structure

    ''' <summary>
    ''' Donne accès à des méthodes pour les listes
    ''' </summary>
    Structure ListValue

        Shared ReadOnly itemalreadysearched As String = "<nothing>"

        ''' <summary>
        ''' Contient les différents modes de disposition d'une liste
        ''' </summary>
        Enum DisplayListMode
            ''' <summary>
            ''' Spécifie que chaque item est séparé par une virgule
            ''' </summary>
            coma
            ''' <summary>
            ''' Spécifie que chaque item est entre guillements séparés par une virgule
            ''' </summary>
            quotation
            ''' <summary>
            ''' Spécifie que chaque item est entre parenthèses séparése par une virgule
            ''' </summary>
            brackets
            ''' <summary>
            ''' Spécifie que chaque item est séparé par une barre oblique (celle au-dessus de la touche 'ctrl')
            ''' </summary>
            bar
        End Enum

        ''' <summary>
        ''' Obtient une valeur qui définit si la liste est vide ou non
        ''' </summary>
        ''' <param name="list">La liste spécifiée</param>
        ''' <returns>Une valeur qui définit si la liste est vide ou non</returns>
        Shared Function IsListEmpty(list As List(Of String)) As Boolean
            For i = 0 To list.Count - 1
                If list(i) <> Nothing Then
                    Return False
                End If
            Next
            Return True
        End Function

        ''' <summary>
        ''' Obtient l'index du premier item non vide d'une liste. Si la liste est vide, retourne -1
        ''' </summary>
        ''' <param name="list">La liste dans laquelle rechecher</param>
        ''' <returns>L'index du premier item non vide s'il existe, sinon - 1</returns>
        Shared Function GetFirstItemIndex(list As List(Of String)) As Integer
            For i = 0 To list.Count
                If list(i) <> "" Then
                    Return i
                End If
            Next
            Return -1
        End Function

        ''' <summary>
        ''' Affiche tout les items d'une liste sous forme de chaîne de caractères
        ''' </summary>
        ''' <param name="list">La liste à afficher</param>
        ''' <param name="mode">Le séparateur entre chaque items de la liste</param>
        ''' <returns>Une chaîne de caractère contenant tout les items de la liste</returns>
        Shared Function DisplayList(list As List(Of Char), mode As DisplayListMode) As String
            Dim displayedList As String = ""

            If list.Count > 0 Then

                If mode = DisplayListMode.coma Then

                    displayedList = list.Item(0)
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", " + list.Item(i - 1)
                        Next
                    End If

                ElseIf mode = DisplayListMode.quotation Then

                    displayedList = Chr(34) + list.Item(0) + Chr(34)
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", " + Chr(34) + list.Item(i - 1) + Chr(34)
                        Next
                    End If

                ElseIf mode = DisplayListMode.brackets Then

                    displayedList = "(" + list.Item(0) + ")"
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", (" + list.Item(i - 1) + ")"
                        Next
                    End If

                ElseIf mode = DisplayListMode.bar Then

                    displayedList = list.Item(0)
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", " + "/" + list.Item(i - 1)
                        Next
                    End If

                End If

            End If

            Return displayedList
        End Function

        ''' <summary>
        ''' Affiche tout les items d'une liste sous forme de chaîne de caractères
        ''' </summary>
        ''' <param name="list">La liste à afficher</param>
        ''' <param name="mode">Le séparateur entre chaque items de la liste</param>
        ''' <returns>Une chaîne de caractère contenant tout les items de la liste</returns>
        Shared Function DisplayList(list As List(Of String), mode As DisplayListMode) As String
            Dim displayedList As String = ""

            If list.Count > 0 Then

                If mode = DisplayListMode.coma Then

                    displayedList = list.Item(0)
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", " + list.Item(i - 1)
                        Next
                    End If

                ElseIf mode = DisplayListMode.quotation Then

                    displayedList = Chr(34) + list.Item(0) + Chr(34)
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", " + Chr(34) + list.Item(i - 1) + Chr(34)
                        Next
                    End If

                ElseIf mode = DisplayListMode.brackets Then

                    displayedList = "(" + list.Item(0) + ")"
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + ", (" + list.Item(i - 1) + ")"
                        Next
                    End If

                ElseIf mode = DisplayListMode.bar Then

                    displayedList = list.Item(0)
                    If list.Count >= 2 Then
                        For i = 2 To list.Count
                            displayedList = displayedList + "/" + list.Item(i - 1)
                        Next
                    End If

                End If

            End If

            Return displayedList
        End Function

        ''' <summary>
        ''' Obtient une liste à partir d'une chaîne du caractère
        ''' </summary>
        ''' <param name="listString">La chaîne de caractère</param>
        ''' <param name="separatorMode">Le séparateur entre chaque items de la liste</param>
        ''' <returns>Une liste contenant les termes de la chaîne de caractère</returns>
        Shared Function GetList(listString As String, separatorMode As DisplayListMode) As List(Of String)

            Dim list As New List(Of String)
            If separatorMode = DisplayListMode.coma Then
                list = listString.Split(",").ToList
            ElseIf separatorMode = DisplayListMode.bar Then
                list = listString.Split("/").ToList
            Else
                MessageBox.Show("Le séparateur spécifié n'est pas pris en compte")
                list = {"<Erreur>"}.ToList
            End If

            Return list
        End Function

        ''' <summary>
        ''' Obtient une liste de listes de chaînes de caractères ordonnées au hasard. Ne modifie pas la liste de départ.
        ''' </summary>
        ''' <param name="ItemsList">La liste de départ à ordonner au hasard. Cette liste ne sera pas modifiée.</param>
        Shared Function GetRandomList(ItemsList As List(Of List(Of String))) As List(Of List(Of String))

            'Crée une liste avec le numéro de chacun des items contenus dans la liste de départ
            Dim LeftNumberList As New List(Of Integer)
            For i = 0 To ItemsList.Count - 1
                LeftNumberList.Add(i)
            Next

            'Crée une liste avec l'organisation au hasard de chacun de ces numéros
            Dim RandomList As New List(Of Integer)
            Dim ListRandom As New Random
            Dim randomNumber As Integer
            While LeftNumberList.Count > 0
                randomNumber = LeftNumberList(ListRandom.Next(0, LeftNumberList.Count))
                RandomList.Add(randomNumber)
                LeftNumberList.Remove(randomNumber)
            End While

            'Ajoute les items au hasard dans la nouvelle liste
            Dim NewList As New List(Of List(Of String))
            For i = 0 To RandomList.Count - 1
                NewList.Add(ItemsList(RandomList(i)))
            Next

            Return NewList
        End Function

        ''' <summary>
        ''' Obtient l'index de la première occurence qui contient le texte spécifié. S'il n'y en a pas, retourne -1.
        ''' </summary>
        ''' <param name="referencedList">La liste dans laquelle chercher le texte. Cette liste ne sera pas modifiée</param>
        ''' <param name="research">Le texte à rechercher</param>
        ''' <param name="findMode">Le mode de recherche dans la liste</param>
        ''' <returns>L'index de la première occurence contenant le texte spécifié s'il existe, sinon -1.</returns>
        Shared Function FindIndex(referencedList As List(Of String), research As String, findMode As FindMode) As Integer
            If referencedList.Count > 0 Then
                If findMode = FindMode.item Then
                    For i = 1 To referencedList.Count
                        If referencedList(i - 1) = research Then
                            Return i
                        End If
                    Next
                ElseIf findMode = FindMode.inItem Then
                    For i = 1 To referencedList.Count
                        If referencedList(i - 1).Contains(research) = True Then
                            Return i - 1
                        End If
                    Next
                Else
                    MessageBox.Show("Le mode de recherche spécifié n'est pas pris en compte.")
                End If
            Else
                MessageBox.Show("La liste est vide. Impossible d'effectuer une recherche.")
            End If
            Return -1
        End Function

        ''' <summary>
        ''' Obtient tous les index des occurences qui contiennent le texte spécifié.
        ''' </summary>
        ''' <param name="referencedList">La liste dans laquelle chercher le texte. Cette liste ne sera pas modifiée</param>
        ''' <param name="research">Le texte à rechercher</param>
        ''' <param name="findMode">Le mode de recherche dans la liste</param>
        ''' <returns>Une liste contenant les index de toutes les occurences contenant le texte spécifié</returns>
        Shared Function FindAllIndex(referencedList As List(Of String), research As String, findMode As FindMode) As List(Of Integer)
            Dim index As Integer
            Dim newList As New List(Of String)
            For i = 1 To referencedList.Count
                newList.Add(referencedList(i - 1))
            Next

            Dim indexList As New List(Of Integer)

            While newList.Count > 0 AndAlso Values.ListValue.Contains(newList, research, findMode)
                index = Values.ListValue.FindIndex(newList, research, findMode)
                If index < newList.Count Then
                    indexList.Add(newList.IndexOf(newList(index)))
                    newList(index) = itemalreadysearched
                End If
            End While
            Return indexList
        End Function

        ''' <summary>
        ''' Obtient une valeur qui définit si la liste contient le texte spécifié
        ''' </summary>
        ''' <param name="referencedList">La liste dans laquelle chercher le texte</param>
        ''' <param name="research">Le texte à rechercher</param>
        ''' <param name="findMode">Le mode de recherche dans la liste</param>
        ''' <returns>True si la liste contient la valeur spécifiée, sinon False.</returns>
        Shared Function Contains(referencedList As List(Of String), research As String, findMode As FindMode) As Boolean
            If referencedList.Count > 0 Then
                If findMode = FindMode.item Then
                    For i = 1 To referencedList.Count
                        If referencedList(i - 1) = research Then
                            Return True
                        End If
                    Next
                ElseIf findMode = FindMode.inItem Then
                    For i = 1 To referencedList.Count
                        If referencedList(i - 1).Contains(research) Then
                            Return True
                        End If
                    Next
                Else
                    MessageBox.Show("Le mode de recherche spécifié n'est pas pris en compte.")
                End If
            Else
                MessageBox.Show("La liste est vide. Impossible de trouver un élément.")
            End If
            Return False
        End Function

    End Structure

End Namespace
