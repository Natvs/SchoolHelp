<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarksCollectionBox
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
        Me.collectionPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.openButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.collectionLabel = New System.Windows.Forms.Label()
        Me.mediumLabel = New System.Windows.Forms.Label()
        Me.collectionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'collectionPanel
        '
        Me.collectionPanel.AutoSize = True
        Me.collectionPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.collectionPanel.ColumnCount = 4
        Me.collectionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.collectionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.collectionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.collectionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.collectionPanel.Controls.Add(Me.openButton, 0, 2)
        Me.collectionPanel.Controls.Add(Me.editButton, 0, 2)
        Me.collectionPanel.Controls.Add(Me.deleteButton, 3, 2)
        Me.collectionPanel.Controls.Add(Me.collectionLabel, 0, 0)
        Me.collectionPanel.Controls.Add(Me.mediumLabel, 0, 1)
        Me.collectionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.collectionPanel.Location = New System.Drawing.Point(0, 0)
        Me.collectionPanel.Name = "collectionPanel"
        Me.collectionPanel.RowCount = 3
        Me.collectionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.collectionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.collectionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.collectionPanel.Size = New System.Drawing.Size(438, 103)
        Me.collectionPanel.TabIndex = 0
        '
        'openButton
        '
        Me.openButton.AutoSize = True
        Me.openButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.collectionPanel.SetColumnSpan(Me.openButton, 2)
        Me.openButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.openButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openButton.Location = New System.Drawing.Point(3, 65)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(217, 35)
        Me.openButton.TabIndex = 8
        Me.openButton.Text = "Accéder à la collection"
        Me.openButton.UseVisualStyleBackColor = True
        '
        'editButton
        '
        Me.editButton.AutoSize = True
        Me.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.editButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(226, 65)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(91, 35)
        Me.editButton.TabIndex = 7
        Me.editButton.Text = "Modifier"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.AutoSize = True
        Me.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(323, 65)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(112, 35)
        Me.deleteButton.TabIndex = 3
        Me.deleteButton.Text = "Supprimer"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'collectionLabel
        '
        Me.collectionLabel.AutoSize = True
        Me.collectionPanel.SetColumnSpan(Me.collectionLabel, 4)
        Me.collectionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.collectionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collectionLabel.ForeColor = System.Drawing.Color.Red
        Me.collectionLabel.Location = New System.Drawing.Point(3, 0)
        Me.collectionLabel.Name = "collectionLabel"
        Me.collectionLabel.Size = New System.Drawing.Size(432, 31)
        Me.collectionLabel.TabIndex = 1
        Me.collectionLabel.Text = "Collection :"
        Me.collectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mediumLabel
        '
        Me.mediumLabel.AutoSize = True
        Me.collectionPanel.SetColumnSpan(Me.mediumLabel, 4)
        Me.mediumLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mediumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mediumLabel.Location = New System.Drawing.Point(3, 31)
        Me.mediumLabel.Name = "mediumLabel"
        Me.mediumLabel.Size = New System.Drawing.Size(432, 31)
        Me.mediumLabel.TabIndex = 0
        Me.mediumLabel.Text = "Moyenne :"
        Me.mediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MarksCollectionBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.collectionPanel)
        Me.Name = "MarksCollectionBox"
        Me.Size = New System.Drawing.Size(438, 103)
        Me.collectionPanel.ResumeLayout(False)
        Me.collectionPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents collectionPanel As TableLayoutPanel
    Friend WithEvents collectionLabel As Label
    Friend WithEvents mediumLabel As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents openButton As Button
End Class
