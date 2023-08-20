Namespace values

    ''' <summary>
    ''' Contient les résultats de dialogues MyApp
    ''' </summary>
    Public Enum dialogResults
        none
        ok
        yes
        no
        cancel
    End Enum

    ''' <summary>
    ''' Obtient des fonctions pour les valeurs booléennes
    ''' </summary>
    Structure booleanValue

        ''' <summary>
        ''' Obtient la valeur booléenne par défaut
        ''' </summary>
        Shared defaultValue As Boolean = False

        ''' <summary>
        ''' Donne la valeur booléene opposée à la valeur entrée
        ''' </summary>
        ''' <param name="value">La valeur d'entrée</param>
        ''' <returns>La valeur opposée à la valeur d'entrée</returns>
        Shared Function inverse(value As Object) As Boolean

            Try

                If value = True Then
                    Return False
                ElseIf value = False Then
                    Return True
                Else
                    Return values.booleanValue.defaultValue
                End If

            Catch ex As Exception

                Return values.booleanValue.defaultValue
                parameters.errorLibrary.showException("Une erreur s'est produite lors de l'inversement de la valeur booléenne.", ex)

            End Try

        End Function

        ''' <summary>
        ''' Donne la chaine de caractère correspondant à la valeur booléenne entrée
        ''' </summary>
        ''' <param name="value">La valeur booléene à convertir en chaine de caractères</param>
        ''' <returns>La chaine de caractère correspondant à la valeur entrée</returns>
        Shared Function getString(value As Boolean) As String

            Try

                Return value.ToString

            Catch ex As Exception

                Return values.booleanValue.defaultValue.ToString
                parameters.errorLibrary.showException("Une erreur s'est produite lors de la conversion d'une valeur booléenne en chaine de caractère.", ex)

            End Try

        End Function

        ''' <summary>
        ''' Obtient une valeur booléenne à partir d'une chaine de caractères
        ''' </summary>
        ''' <param name="text">La chaine de caractère à convertir en valeur booléenne</param>
        ''' <returns></returns>
        Shared Function fromString(text As String) As Boolean

            Try

                If text = "True" Then
                    Return True
                ElseIf text = "False" Then
                    Return False
                Else
                    Return False
                    MessageBox.Show("La chaine de caractère '" + text + "' ne peut pas être convertie en une valeur booléene." + vbNewLine + "La valeur à été mise sur 'False'")
                End If

            Catch ex As Exception

                Return False
                parameters.errorLibrary.showException("Une erreur s'est produite lors de la conversion d'une chaine de caractère en valeur booléenne.", ex)

            End Try

        End Function

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les couleurs
    ''' </summary>
    Structure colorValue

        Shared defaultValue As Color = Color.Black

        ''' <summary>
        ''' Invite l'utilisateur à choisir une couleur
        ''' </summary>
        ''' <returns>La couleur choisie par l'utilisateur</returns>
        Shared Function askForColor() As Color

            Try

                Using askColorDialog As New ColorDialog

                    If askColorDialog.ShowDialog = DialogResult.OK Then
                        Return askColorDialog.Color
                    End If

                End Using

            Catch ex As Exception

                Return values.colorValue.defaultValue
                parameters.errorLibrary.showException("Une erreur s'est produite lors du choix d'une couleur.", ex)

            End Try

        End Function

        ''' <summary>
        ''' Donne la chaine de caractère ARGB correspondant à la couleur entrée
        ''' </summary>
        ''' <param name="value">La couelur à convertir en chaine de caractères ARGB</param>
        ''' <returns>La chaine de caractère ARGB correspondant à la couleur entrée</returns>
        Shared Function getString(value As Color) As String

            Try

                Return value.ToArgb

            Catch ex As Exception

                Return values.colorValue.defaultValue.ToArgb
                parameters.errorLibrary.showException("Une erreur s'est produite lors de la conversion de la couleur en entier ARGB.", ex)

            End Try

        End Function

        ''' <summary>
        ''' Obtient une couleur ARGB à partir d'une chaine de caractères
        ''' </summary>
        ''' <param name="text">La chaine de caractèères à convertir en une couleur ARGB</param>
        ''' <returns></returns>
        Shared Function fromString(text As String) As Color

            Try

                Return Color.FromArgb(text)

            Catch ex As Exception

                Return values.colorValue.defaultValue
                parameters.errorLibrary.showException("Une erreur s'est produite lors de la conversion d'une chaine de caractère ARGB en couleur.", ex)

            End Try

        End Function

        ''' <summary>
        ''' Inverse la couleur
        ''' </summary>
        ''' <param name="value">La couleur à inverser</param>
        ''' <returns>La couleur inverse à celle entrée</returns>
        Shared Function inverse(value As Color) As Color

            Try

                Return Color.FromArgb(255 - value.A, 255 - value.R, 255 - value.G, 255 - value.B)

            Catch ex As Exception

                Return values.colorValue.defaultValue
                parameters.errorLibrary.showException("Une erreur s'est produite lors de l'inversion de la couleur.", ex)

            End Try

        End Function

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les images
    ''' </summary>
    Structure imageValue

        ''' <summary>
        ''' Obtient une image d'erreur
        ''' </summary>
        Shared ReadOnly errorImage As Image = My.Resources.bin

        ''' <summary>
        ''' Sauvegarde une image
        ''' </summary>
        ''' <param name="imageToSave">L'image à sauvegarder</param>
        ''' <param name="imageFile">Le fichier dans lequel sauvegarder l'image</param>
        Shared Sub save(imageToSave As Image, imageFile As String)

            Try

                If imageToSave IsNot Nothing Then

                    Using file = IO.File.OpenWrite(imageFile)

                        imageToSave.Save(file, parameters.images.format)

                    End Using

                ElseIf imageToSave Is Nothing Then

                    values.fileValue.delete(imageFile)

                End If

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors de la sauvegarde de l'image", ex)

            End Try

        End Sub

        ''' <summary>
        ''' Charge une image depuis un fichier
        ''' </summary>
        ''' <param name="imageFile">Le fichier de l'image à charger</param>
        ''' <returns>L'image à partir du fichier</returns>
        Shared Function fromFile(imageFile) As Image

            Try

                If FileIO.FileSystem.FileExists(imageFile) = True Then
                    Using file = IO.File.OpenRead(imageFile)
                        Return System.Drawing.Image.FromStream(file)
                    End Using
                Else
                    Return Nothing
                End If

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors du chargement de l'image.", ex)
                Return values.imageValue.errorImage

            End Try

        End Function

        ''' <summary>
        ''' Invite l'utilisateur à choisir une image depuis son ordinateur
        ''' </summary>
        ''' <returns>L'image sélectionnée</returns>
        Shared Function fromComputer() As Image

            Try

                Using imageDialog As New OpenFileDialog
                    imageDialog.Filter = "Fichiers C#|*.png;*.jpg;*.gif;*.bmp;*.raw;*.nef;*.tif;*.eps|Tous les fichiers|*.*Fic"

                    If imageDialog.ShowDialog = DialogResult.OK Then

                        Return values.imageValue.fromFile(imageDialog.FileName)

                    Else

                        Return Nothing

                    End If
                End Using

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors de la saisie d'une image depuis l'ordinateur.", ex)
                Return values.imageValue.errorImage

            End Try

        End Function

        ''' <summary>
        ''' Invite l'utilisateur à choisir une image depuis la librairie
        ''' </summary>
        ''' <param name="imagesID">L'ID des images à montrer obtenue dans Parameter.images</param>
        ''' <returns>L'image sélectionnée</returns>
        Shared Function fromLibrary(imagesID As Integer) As Image

            Try

                Dim imagesDialog As New picturesLibraryDialog

                If imagesID = parameters.images.flowers.ID Then
                    imagesDialog.showAndDialog(picturesLibrary.states.getFlowersImages)
                ElseIf imagesID = parameters.images.landscapes.ID Then
                    imagesDialog.showAndDialog(picturesLibrary.states.getLandscapesImages)
                End If

                If imagesDialog.result = values.dialogResults.ok Then
                    Return imagesDialog.selected
                Else
                    Return Nothing
                End If

            Catch ex As Exception
                parameters.errorLibrary.showException("Une erreur s'est produite lors de l'importation d'une image depuis la librairie", ex)
                Return values.imageValue.errorImage
            End Try

        End Function

        ''' <summary>
        ''' Contient les modes de redimensionnement des images
        ''' </summary>
        Enum resizeMode
            grow
            shrink
        End Enum

        ''' <summary>
        ''' Agrandit ou réduit l'image
        ''' </summary>
        ''' <param name="img">L'image à agrandir ou réduire</param>
        ''' <param name="multiplicator">Le coefficient multiplicateur</param>
        ''' <returns>La nouvelle image redimensionnée</returns>
        Shared Function resize(img As Image, multiplicator As Integer, resizeMode As values.imageValue.resizeMode) As Image

            Try
                If resizeMode = values.imageValue.resizeMode.grow Then
                    Return New Bitmap(img, img.Width * multiplicator, img.Height * multiplicator)
                ElseIf resizeMode = values.imageValue.resizeMode.shrink Then
                    Return New Bitmap(img, img.Width / multiplicator, img.Height / multiplicator)
                Else
                    Return img
                End If

            Catch ex As Exception
                parameters.errorLibrary.showException("Une erreur s'est produite lors du redimensionnement de l'image.", ex)
                Return img
            End Try

        End Function

        ''' <summary>
        ''' Redimensionne une image
        ''' </summary>
        ''' <param name="img">L'image à redimensionner</param>
        ''' <param name="newWidth">La nouvelle largeur de l'image</param>
        ''' <param name="newHeigth">La nouvelle hauteur de l'image</param>
        ''' <returns></returns>
        Shared Function resize(img As Image, newWidth As Integer, newHeigth As Integer) As Image
            Try
                Return New Bitmap(img, newWidth, newHeigth)
            Catch ex As Exception
                parameters.errorLibrary.showException("Erreur lors du redimensionnement de l'image.", ex)
                Return img
            End Try
        End Function

        Enum rotateMode
            left
            right
            inverse
        End Enum

        ''' <summary>
        ''' Fait pivoter une image de 90°
        ''' </summary>
        ''' <param name="rotateImage">L'image à faire pivoter</param>
        ''' <param name="rotateType">Le sens dans lequel faire pivoter l'image</param>
        ''' <returns>L'image pivotée</returns>
        Shared Function rotate(rotateImage As Image, rotateType As values.imageValue.rotateMode) As Image
            Try
                If rotateType = values.imageValue.rotateMode.right Then
                    rotateImage.RotateFlip(RotateFlipType.Rotate90FlipNone)
                ElseIf rotateType = values.imageValue.rotateMode.left Then
                    rotateImage.RotateFlip(RotateFlipType.Rotate270FlipNone)
                ElseIf rotateType = rotateMode.inverse Then
                    rotateImage.RotateFlip(RotateFlipType.Rotate180FlipNone)
                End If
                Return rotateImage
            Catch ex As Exception
                parameters.errorLibrary.showException("Erreur lors de la rotation d'une image", ex)
                Return rotateImage
            End Try
        End Function

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les modes de redimensionnement des PictureBox
    ''' </summary>
    Structure sizeModeValue

        ''' <summary>
        ''' Obtient le mode de redimensionnement par défaut
        ''' </summary>
        Shared ReadOnly defaultSizeMode As PictureBoxSizeMode = PictureBoxSizeMode.Normal

        ''' <summary>
        ''' Donne la chaine de caractères correspondant à un mode de redimensionnement
        ''' </summary>
        ''' <param name="value">Le mode de redimensionnement à convertir en chaine de caractères</param>
        ''' <returns>La chaine de caractères correspondant au mode de redimensionnement entré</returns>
        Shared Function getString(value As PictureBoxSizeMode) As String

            Try

                Return value.ToString

            Catch ex As Exception

                Return values.sizeModeValue.defaultSizeMode.ToString
                parameters.errorLibrary.showException("Une erreur s'est produite lors de la conversion d'une valeur SizeMode en chaine de caractère.", ex)

            End Try

        End Function

        ''' <summary>
        ''' Obtient un mode de redimensionnement à partir d'une chaine de caractères
        ''' </summary>
        ''' <param name="text">La chaine de caractères à convertir en mode de redimenssionement</param>
        ''' <returns></returns>
        Shared Function fromString(text As String) As PictureBoxSizeMode

            Try

                If text = "Normal" Then
                    Return PictureBoxSizeMode.Normal
                ElseIf text = "StretchImage" Then
                    Return PictureBoxSizeMode.StretchImage
                ElseIf text = "AutoSize" Then
                    Return PictureBoxSizeMode.AutoSize
                ElseIf text = "CenterImage" Then
                    Return PictureBoxSizeMode.CenterImage
                ElseIf text = "Zoom" Then
                    Return PictureBoxSizeMode.Zoom
                Else
                    Return values.sizeModeValue.defaultSizeMode
                End If

            Catch ex As Exception

                Return values.sizeModeValue.defaultSizeMode
                parameters.errorLibrary.showException("Une erreur s'est produite lors de la conversion d'une chaine de caractère en SizeMode.", ex)

            End Try

        End Function

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les timers
    ''' </summary>
    Structure timerValue

        ''' <summary>
        ''' Démarre un timer avec un temps spécifié
        ''' </summary>
        ''' <param name="timer">Le timer à démarrer</param>
        ''' <param name="time">Le temps du timer</param>
        Shared Sub startTimer(timer As Timer, time As Integer)
            timer.Interval = time
            timer.Start()
        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les tableaux
    ''' </summary>
    Structure arrayValue

        ''' <summary>
        ''' Compare deux tableaux
        ''' </summary>
        ''' <param name="array">Le premier tableau</param>
        ''' <param name="reference">Le deuxième tableau</param>
        ''' <returns></returns>
        Shared Function compare(array As Array, reference As Array)

            If array.Length <> reference.Length Then
                Return False
            End If

            For i = 0 To array.GetUpperBound(0)
                If reference(i) <> array(i) Then
                    Return False
                End If
            Next

            Return True

        End Function

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les fichiers
    ''' </summary>
    Structure fileValue

        ''' <summary>
        ''' Supprime un fichier
        ''' </summary>
        ''' <param name="file">Le chemin du fichier</param>
        Shared Sub delete(file As String)

            Try

                If FileIO.FileSystem.FileExists(file) = True Then

                    FileIO.FileSystem.DeleteFile(file)

                End If

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors de la suppression du fichier", ex)

            End Try

        End Sub

        ''' <summary>
        ''' Crée un fichier
        ''' </summary>
        ''' <param name="file">Le chemin du fichier</param>
        Shared Sub create(file As String)

            Try

                If IO.File.Exists(file) = False Then
                    IO.File.Create(file)
                End If

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors de la création du fichier", ex)

            End Try
        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les dossiers
    ''' </summary>
    Structure directoryValue

        ''' <summary>
        ''' Supprime un répertoire
        ''' </summary>
        ''' <param name="directory">Le chemin du répertoire</param>
        Shared Sub delete(directory As String)

            Try

                If FileIO.FileSystem.DirectoryExists(directory) Then
                    FileIO.FileSystem.DeleteDirectory(directory, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
                End If

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors de la suppression du répertoire", ex)

            End Try

        End Sub

        ''' <summary>
        ''' Crée un dossier
        ''' </summary>
        ''' <param name="directory">Ke chemin du dossier</param>
        Shared Sub create(directory As String)

            Try

                If IO.Directory.Exists(directory) = False Then
                    IO.Directory.CreateDirectory(directory)
                End If

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est prduite lors de la création du dossier", ex)

            End Try

        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les contrôles
    ''' </summary>
    Structure controlsValue
        ''' <summary>
        ''' Obtient le mode de redimensionnement d'un contrôle
        ''' </summary>
        Enum resizeType
            size
            maximumSize
            minimumSize
        End Enum

        ''' <summary>
        ''' Redimensionne automatiquement le contrôle à son contenu
        ''' </summary>
        ''' <param name="control">Le contrôle à redimensionner automatiquement</param>
        ''' <remarks>Le contrôle doit avoir une propriété nommée AutoSize.</remarks>
        Shared Sub resizeControl(control As Control)
            control.AutoSize = True
        End Sub

        ''' <summary>
        ''' Redimensionne un contrôle
        ''' </summary>
        ''' <param name="control">Le contrôle à redimensionner</param>
        ''' <param name="dockStyle">Le mode de redimesionnement du contrôle</param>
        Shared Sub resizeControl(control As Control, dockStyle As DockStyle)
            control.Dock = dockStyle
        End Sub

        ''' <summary>
        ''' Redimensionne un contrôle
        ''' </summary>
        ''' <param name="control">Le contrôle à redimensionner</param>
        ''' <param name="autoSize">Définit s'il faut redimenssionner le contrôle par rapport à son contenu.</param>
        ''' <param name="dockStyle">Le mode de redimesionnement du contrôle</param>
        ''' <remarks>Le contrôle doit avoir une propriété nommée AutoSize.</remarks>
        Shared Sub resizeControl(control As Control, autoSize As Boolean, dockStyle As DockStyle)
            control.AutoSize = autoSize
            control.Dock = dockStyle
        End Sub

        ''' <summary>
        ''' Redimensionne un contrôle
        ''' </summary>
        ''' <param name="control">Le contrôle à redimenssioner</param>
        ''' <param name="newWidth">La nouvelle largeur</param>
        ''' <param name="newHeight">La nouvelle hauteur</param>
        Shared Sub resizeControl(control As Control, newWidth As Integer, newHeight As Integer)
            control.Size = New Size(newWidth, newHeight)
        End Sub

        ''' <summary>
        ''' Redimensionne un contrôle
        ''' </summary>
        ''' <param name="control">Le contrôle à redimensionner</param>
        ''' <param name="resizeType">Le type de redimensionnement du contrôle</param>
        ''' <param name="newWidth">La nouvelle largeur du contrôle</param>
        ''' <param name="newHeigth">La nouvelle hauteur du contrôle</param>
        Shared Sub resizeControl(control As Control, resizeType As resizeType, newWidth As Integer, newHeigth As Integer)
            If resizeType = resizeType.size Then
                control.Size = New Size(newWidth, newHeigth)
            ElseIf resizeType = resizeType.minimumSize Then
                control.MinimumSize = New Size(newWidth, newHeigth)
            ElseIf resizeType = resizeType.maximumSize Then
                control.MaximumSize = New Size(newWidth, newHeigth)
            End If
        End Sub

        ''' <summary>
        ''' Définit les limites de taille d'un contrôle
        ''' </summary>
        ''' <param name="control">Le contrôle dont les limites de tailles doivent être modifiées</param>
        ''' <param name="minWidth">La largeur minimale du contrôle</param>
        ''' <param name="minHeight">La hauteur minimale du contrôle</param>
        ''' <param name="maxWidth">La largeur maximale du contrôle</param>
        ''' <param name="maxHeigth">La hauteur maximale du contrôle</param>
        Shared Sub resizeControl(control As Control, minWidth As Integer, minHeight As Integer, maxWidth As Integer, maxHeigth As Integer)
            control.MinimumSize = New Size(minWidth, minHeight)
            control.MaximumSize = New Size(maxWidth, maxHeigth)
        End Sub
    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les boutons
    ''' </summary>
    Structure buttonValue

        ''' <summary>
        ''' Initialise un bouton
        ''' </summary>
        ''' <param name="button">Le bouton à initialiser</param>
        ''' <param name="text">Le texte du bouton</param>
        ''' <param name="fontSize">La taille du texte du bouton</param>
        Shared Sub initialize(button As Button, text As String, fontSize As Integer, textColor As Color)
            button.Text = text
            button.Font = New Font(FontFamily.GenericSansSerif, fontSize)
            button.ForeColor = textColor
        End Sub

        ''' <summary>
        ''' Initialise un bouton
        ''' </summary>
        ''' <param name="button">Le bouton à initialiser</param>
        ''' <param name="text">Le texte du bouton</param>
        ''' <param name="fontSize">La taille du texte du bouton</param>
        ''' <param name="dockStyle">La mise en forme du bouton</param>
        Shared Sub initialize(button As Button, text As String, fontSize As Integer, textColor As Color, dockStyle As DockStyle)
            initialize(button, text, fontSize, textColor)
            button.Dock = dockStyle
        End Sub

        ''' <summary>
        ''' Initialise un bouton
        ''' </summary>
        ''' <param name="button">Le bouton à initialiser</param>
        ''' <param name="text">Le texte du bouton</param>
        ''' <param name="fontSize">La taille du texte du bouton</param>
        ''' <param name="useVisualStyle">Définit s'il faut utiliser le style d'arrière-plan de Visual Studio</param>
        ''' <param name="backColor">La couleur d'arrière-plan.</param>
        Shared Sub initialize(button As Button, text As String, fontSize As Integer, textColor As Color, useVisualStyle As Boolean, backColor As Color)
            initialize(button, text, fontSize, textColor)
            button.UseVisualStyleBackColor = useVisualStyle
            button.BackColor = backColor
        End Sub

        ''' <summary>
        ''' Initialise un bouton
        ''' </summary>
        ''' <param name="button">Le bouton à initialiser</param>
        ''' <param name="text">Le texte du bouton</param>
        ''' <param name="fontSize">La taille du texte du bouton</param>
        ''' <param name="dockStyle">La mise en forme du bouton</param>
        ''' <param name="useVisualStyle">Définit s'il faut utiliser le style d'arrière-plan de Visual Studio</param>
        ''' <param name="backColor">La couleur d'arrière-plan.</param>
        Shared Sub initialize(button As Button, text As String, fontSize As Integer, textColor As Color, dockStyle As DockStyle, useVisualStyle As Boolean, backColor As Color)
            initialize(button, text, fontSize, textColor, useVisualStyle, backColor)
            button.Dock = dockStyle
        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les CheckBox
    ''' </summary>
    Structure checkBoxValue

        ''' <summary>
        ''' Initialise une CheckBox
        ''' </summary>
        ''' <param name="checkBox">La CheckBox à initialiser</param>
        ''' <param name="text">Le texte de la CheckBox</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="checked">Définit si la CheckBox est coché</param>
        Shared Sub initialize(checkBox As CheckBox, text As String, fontSize As Integer, textColor As Color, checked As Boolean)
            checkBox.Text = text
            checkBox.Font = New Font(FontFamily.GenericSansSerif, fontSize)
            checkBox.ForeColor = textColor
        End Sub

        ''' <summary>
        ''' Initialise une CheckBox
        ''' </summary>
        ''' <param name="checkBox">La CheckBox à initialiser</param>
        ''' <param name="text">Le texte de la CheckBox</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="checked">Définit si la CheckBox est coché</param>
        ''' <param name="useVisualStyle">Définit s'il faut utiliser le style d'arrière-plan de Visual Studio</param>
        ''' <param name="backColor">La couleur d'arrière-plan</param>
        Shared Sub initialize(checkBox As CheckBox, text As String, fontSize As Integer, textColor As Color, checked As Boolean, useVisualStyle As Boolean, backColor As Color)
            initialize(checkBox, text, fontSize, textColor, checked)
            checkBox.UseVisualStyleBackColor = useVisualStyle
            checkBox.BackColor = backColor
        End Sub

        ''' <summary>
        ''' Initialise une CheckBox
        ''' </summary>
        ''' <param name="checkBox">La CheckBox à initialiser</param>
        ''' <param name="text">Le texte de la CheckBox</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="checked">Définit si la CheckBox est coché</param>
        ''' <param name="dockStyle">La mise en forme de la CheckBox</param>
        Shared Sub initialize(checkBox As CheckBox, text As String, fontSize As Integer, textColor As Color, checked As Boolean, dockStyle As DockStyle)
            initialize(checkBox, text, fontSize, textColor, checked)
            checkBox.Dock = dockStyle
        End Sub

        ''' <summary>
        ''' Initialise une CheckBox
        ''' </summary>
        ''' <param name="checkBox">La CheckBox à initialiser</param>
        ''' <param name="text">Le texte de la CheckBox</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="checked">Définit si la CheckBox est coché</param>
        ''' <param name="useVisualStyle">Définit s'il faut utiliser le style d'arrière-plan de Visual Studio</param>
        ''' <param name="backColor">La couleur d'arrière-plan</param>
        ''' <param name="dockStyle">La mise en forme de la CheckBox</param>
        Shared Sub initialize(checkBox As CheckBox, text As String, fontSize As Integer, textColor As Color, checked As Boolean, useVisualStyle As Boolean, backColor As Color, dockStyle As DockStyle)
            initialize(checkBox, text, fontSize, textColor, checked, useVisualStyle, backColor)
            checkBox.Dock = dockStyle
        End Sub

    End Structure


    ''' <summary>
    ''' Obtient des fonctions pour les PictureBox
    ''' </summary>
    Structure pictureBoxValue

        ''' <summary>
        ''' Initialise une PictureBox
        ''' </summary>
        ''' <param name="pictureBox">La PictureBox à initialiser</param>
        ''' <param name="image">L'image à montrer dans la PictureBox</param>
        ''' <param name="imageSizeMode">Le mode de redimensionnement de l'image</param>
        Shared Sub initialize(pictureBox As PictureBox, image As Image, imageSizeMode As PictureBoxSizeMode)
            pictureBox.Image = image
            pictureBox.SizeMode = imageSizeMode
        End Sub

        ''' <summary>
        ''' Initialise une PictureBox
        ''' </summary>
        ''' <param name="pictureBox">La PictureBox à initialiser</param>
        ''' <param name="image">L'image à montrer dans la PictureBox</param>
        ''' <param name="imageSizeMode">Le mode de redimensionnement de l'image</param>
        ''' <param name="backColor">La couleur d'arrière-plan</param>
        Shared Sub initialize(pictureBox As PictureBox, image As Image, imageSizeMode As PictureBoxSizeMode, backColor As Color)
            initialize(pictureBox, image, imageSizeMode)
            pictureBox.BackColor = backColor
        End Sub

        ''' <summary>
        ''' Initialise une PictureBox
        ''' </summary>
        ''' <param name="pictureBox">La PictureBox à initialiser</param>
        ''' <param name="image">L'image à montrer dans la PictureBox</param>
        ''' <param name="imageSizeMode">Le mode de redimensionnement de l'image</param>
        ''' <param name="dockStyle">La mise en forme de la PictureBox</param>
        Shared Sub initialize(pictureBox As PictureBox, image As Image, imageSizeMode As PictureBoxSizeMode, dockStyle As DockStyle)
            initialize(pictureBox, image, imageSizeMode)
            pictureBox.Dock = dockStyle
        End Sub

        ''' <summary>
        ''' Initialise une PictureBox
        ''' </summary>
        ''' <param name="pictureBox">La PictureBox à initialiser</param>
        ''' <param name="image">L'image à montrer dans la PictureBox</param>
        ''' <param name="imageSizeMode">Le mode de redimensionnement de l'image</param>
        ''' <param name="dockStyle">La mise en forme de la PictureBox</param>
        Shared Sub initialize(pictureBox As PictureBox, image As Image, imageSizeMode As PictureBoxSizeMode, dockStyle As DockStyle, backColor As Color)
            values.pictureBoxValue.initialize(pictureBox, image, imageSizeMode, backColor)
            pictureBox.Dock = dockStyle
        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les Label
    ''' </summary>
    Structure labelValue

        ''' <summary>
        ''' Initialise un Label
        ''' </summary>
        ''' <param name="label">Le Label à initialiser</param>
        ''' <param name="text">Le texte du Label</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        Shared Sub initialise(label As Label, text As String, fontSize As Integer, textColor As Color, textAlign As ContentAlignment)
            label.Text = text
            label.Font = New Font(FontFamily.GenericSansSerif, fontSize)
            label.ForeColor = textColor
            label.TextAlign = textAlign
        End Sub

        ''' <summary>
        ''' Initialise un Label
        ''' </summary>
        ''' <param name="label">Le Label à initialiser</param>
        ''' <param name="text">Le texte du Label</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="dockStyle">La mise en forme du Label</param>
        Shared Sub initialise(label As Label, text As String, fontSize As Integer, textColor As Color, textAlign As ContentAlignment, dockStyle As DockStyle)
            initialise(label, text, fontSize, textColor, textAlign)
            label.Dock = dockStyle
        End Sub

        ''' <summary>
        ''' Initialise un Label
        ''' </summary>
        ''' <param name="label">Le Label à initialiser</param>
        ''' <param name="text">Le texte du Label</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="backColor">La couleur d'arrière-plan du contrôle</param>
        Shared Sub initialise(label As Label, text As String, fontSize As Integer, textColor As Color, textAlign As ContentAlignment, backColor As Color)
            initialise(label, text, fontSize, textColor, textAlign)
            label.BackColor = backColor
        End Sub

        ''' <summary>
        ''' Initialise un Label
        ''' </summary>
        ''' <param name="label">Le Label à initialiser</param>
        ''' <param name="text">Le texte du Label</param>
        ''' <param name="fontSize">La taille du texte</param>
        ''' <param name="textColor">La couleur du texte</param>
        ''' <param name="dockStyle">La mise en forme du Label</param>
        ''' <param name="backColor">La couleur d'arrière-plan du contrôle</param>
        Shared Sub initialise(label As Label, text As String, fontSize As Integer, textColor As Color, textAlign As ContentAlignment, dockStyle As DockStyle, backColor As Color)
            initialise(label, text, fontSize, textColor, textAlign, backColor)
            label.Dock = dockStyle
        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les PictureBox
    ''' </summary>
    Structure progressBarValue

        ''' <summary>
        ''' Initialise une ProgressBar
        ''' </summary>
        ''' <param name="progressBar">La ProgressBar à initialiser</param>
        ''' <param name="currentValue">La valeur de la ProgressBar</param>
        ''' <param name="maxValue">La valeur maximale de la ProgressBar</param>
        ''' <param name="progressColor"></param>
        Shared Sub initialize(progressBar As ProgressBar, currentValue As Integer, maxValue As Integer, progressColor As Color, progressStyle As ProgressBarStyle)
            progressBar.Maximum = maxValue
            progressBar.Value = currentValue
            progressBar.ForeColor = progressColor
            progressBar.Style = progressStyle
        End Sub

        ''' <summary>
        ''' Initialise une ProgressBar
        ''' </summary>
        ''' <param name="progressBar">La ProgressBar à initialiser</param>
        ''' <param name="currentValue">La valeur de la ProgressBar</param>
        ''' <param name="maxValue">La valeur maximale de la ProgressBar</param>
        ''' <param name="progressColor"></param>
        Shared Sub initialize(progressBar As ProgressBar, currentValue As Integer, maxValue As Integer, progressColor As Color, progressStyle As ProgressBarStyle, dockStyle As DockStyle, backColor As Color)
            initialize(progressBar, currentValue, maxValue, progressColor, progressStyle)
            progressBar.Dock = dockStyle
            progressBar.BackColor = backColor
        End Sub

    End Structure

    ''' <summary>
    ''' Obtient des fonctions pour les RichTexBox
    ''' </summary>
    Structure richTextBoxValue

        ''' <summary>
        ''' Invite l'utilisateur à choisir un fichier texte depuis son ordinateur
        ''' </summary>
        ''' <returns>Le chemin du ficher</returns>
        Shared Function fromComputer() As String

            Try

                Using fileDialog As New OpenFileDialog

                    fileDialog.Filter = "Fichiers C#|*.MyAppText"
                    If fileDialog.ShowDialog() = DialogResult.OK Then
                        Return fileDialog.FileName
                    Else
                        Return Nothing
                    End If

                End Using

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors du choix d'un fichier MyAppText.", ex)
                Return Nothing

            End Try

        End Function

        ''' <summary>
        ''' Invite l'utilisateur à sauvegarder le texte
        ''' </summary>
        ''' <param name="textBoxToSave">Le texte à sauvegarder</param>
        Shared Sub save(textBoxToSave As RichTextBox)

            Try

                Using fileDialog As New SaveFileDialog

                    fileDialog.AddExtension = True
                    fileDialog.DefaultExt = ".MyAppText"
                    If fileDialog.ShowDialog = DialogResult.OK Then
                        textBoxToSave.SaveFile(fileDialog.FileName)
                    End If

                End Using

            Catch ex As Exception

                parameters.errorLibrary.showException("Une erreur s'est produite lors de l'enregistrement du fichier MyAppText.", ex)

            End Try

        End Sub

    End Structure

End Namespace
