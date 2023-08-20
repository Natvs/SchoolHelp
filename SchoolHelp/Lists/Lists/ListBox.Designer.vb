<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBox
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.listPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.openButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.listPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'listPanel
        '
        Me.listPanel.AutoSize = True
        Me.listPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listPanel.ColumnCount = 4
        Me.listPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.listPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.listPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.listPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.listPanel.Controls.Add(Me.openButton, 0, 2)
        Me.listPanel.Controls.Add(Me.deleteButton, 4, 2)
        Me.listPanel.Controls.Add(Me.editButton, 2, 2)
        Me.listPanel.Controls.Add(Me.nameLabel, 0, 0)
        Me.listPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listPanel.Location = New System.Drawing.Point(0, 0)
        Me.listPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.listPanel.Name = "listPanel"
        Me.listPanel.RowCount = 3
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.Size = New System.Drawing.Size(680, 102)
        Me.listPanel.TabIndex = 0
        '
        'openButton
        '
        Me.openButton.AutoSize = True
        Me.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listPanel.SetColumnSpan(Me.openButton, 2)
        Me.openButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.openButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openButton.Location = New System.Drawing.Point(4, 51)
        Me.openButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(332, 46)
        Me.openButton.TabIndex = 0
        Me.openButton.Text = "Ouvrir la liste"
        Me.openButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.AutoSize = True
        Me.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(514, 51)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(162, 46)
        Me.deleteButton.TabIndex = 2
        Me.deleteButton.Text = "Supprimer"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.AutoSize = True
        Me.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.editButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(344, 51)
        Me.editButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(162, 46)
        Me.editButton.TabIndex = 1
        Me.editButton.Text = "Modifier"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.listPanel.SetColumnSpan(Me.nameLabel, 4)
        Me.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.ForeColor = System.Drawing.Color.Red
        Me.nameLabel.Location = New System.Drawing.Point(4, 0)
        Me.nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(672, 46)
        Me.nameLabel.TabIndex = 4
        Me.nameLabel.Text = "Nom de la liste"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.listPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ListBox"
        Me.Size = New System.Drawing.Size(680, 102)
        Me.listPanel.ResumeLayout(False)
        Me.listPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listPanel As TableLayoutPanel
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents nameLabel As Label
    Friend WithEvents openButton As Button
End Class
