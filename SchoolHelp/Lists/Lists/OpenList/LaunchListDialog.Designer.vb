<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaunchListDialog
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MainBox = New System.Windows.Forms.TableLayoutPanel()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LeftItemsLabel = New System.Windows.Forms.Label()
        Me.ItemsBox = New System.Windows.Forms.TableLayoutPanel()
        Me.CheckButton = New System.Windows.Forms.Button()
        Me.ShowAnswersButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MainBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainBox
        '
        Me.MainBox.AutoSize = True
        Me.MainBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainBox.ColumnCount = 1
        Me.MainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainBox.Controls.Add(Me.SearchButton, 0, 0)
        Me.MainBox.Controls.Add(Me.LeftItemsLabel, 0, 1)
        Me.MainBox.Controls.Add(Me.ItemsBox, 0, 2)
        Me.MainBox.Controls.Add(Me.CheckButton, 0, 3)
        Me.MainBox.Controls.Add(Me.ShowAnswersButton, 0, 4)
        Me.MainBox.Controls.Add(Me.CloseButton, 0, 5)
        Me.MainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBox.Location = New System.Drawing.Point(0, 0)
        Me.MainBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainBox.Name = "MainBox"
        Me.MainBox.RowCount = 6
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainBox.Size = New System.Drawing.Size(1296, 582)
        Me.MainBox.TabIndex = 1
        '
        'SearchButton
        '
        Me.SearchButton.AutoSize = True
        Me.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(4, 5)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(1288, 56)
        Me.SearchButton.TabIndex = 0
        Me.SearchButton.Text = "Terme au hasard"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LeftItemsLabel
        '
        Me.LeftItemsLabel.AutoSize = True
        Me.LeftItemsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LeftItemsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LeftItemsLabel.ForeColor = System.Drawing.Color.Red
        Me.LeftItemsLabel.Location = New System.Drawing.Point(4, 66)
        Me.LeftItemsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LeftItemsLabel.Name = "LeftItemsLabel"
        Me.LeftItemsLabel.Size = New System.Drawing.Size(1288, 46)
        Me.LeftItemsLabel.TabIndex = 5
        Me.LeftItemsLabel.Text = "Items restants :"
        Me.LeftItemsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ItemsBox
        '
        Me.ItemsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ItemsBox.ColumnCount = 1
        Me.ItemsBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ItemsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ItemsBox.Location = New System.Drawing.Point(4, 117)
        Me.ItemsBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ItemsBox.Name = "ItemsBox"
        Me.ItemsBox.RowCount = 2
        Me.ItemsBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ItemsBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ItemsBox.Size = New System.Drawing.Size(1288, 262)
        Me.ItemsBox.TabIndex = 1
        '
        'CheckButton
        '
        Me.CheckButton.AutoSize = True
        Me.CheckButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CheckButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckButton.Location = New System.Drawing.Point(4, 389)
        Me.CheckButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckButton.Name = "CheckButton"
        Me.CheckButton.Size = New System.Drawing.Size(1288, 56)
        Me.CheckButton.TabIndex = 2
        Me.CheckButton.Text = "Vérifier"
        Me.CheckButton.UseVisualStyleBackColor = True
        '
        'ShowAnswersButton
        '
        Me.ShowAnswersButton.AutoSize = True
        Me.ShowAnswersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ShowAnswersButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShowAnswersButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAnswersButton.Location = New System.Drawing.Point(4, 455)
        Me.ShowAnswersButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ShowAnswersButton.Name = "ShowAnswersButton"
        Me.ShowAnswersButton.Size = New System.Drawing.Size(1288, 56)
        Me.ShowAnswersButton.TabIndex = 3
        Me.ShowAnswersButton.Text = "Afficher les réponses"
        Me.ShowAnswersButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.AutoSize = True
        Me.CloseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.Location = New System.Drawing.Point(4, 521)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(1288, 56)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Fermer"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'LaunchListDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1296, 582)
        Me.Controls.Add(Me.MainBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LaunchListDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lancer la liste"
        Me.MainBox.ResumeLayout(False)
        Me.MainBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainBox As TableLayoutPanel
    Friend WithEvents CloseButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents ItemsBox As TableLayoutPanel
    Friend WithEvents CheckButton As Button
    Friend WithEvents ShowAnswersButton As Button
    Friend WithEvents LeftItemsLabel As Label
End Class
