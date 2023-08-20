<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListsForm
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
        Me.mainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.backButton = New System.Windows.Forms.Button()
        Me.addCollectionButton = New System.Windows.Forms.Button()
        Me.listsLabel = New System.Windows.Forms.Label()
        Me.listsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.addListButton = New System.Windows.Forms.Button()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.AutoSize = True
        Me.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainPanel.ColumnCount = 1
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainPanel.Controls.Add(Me.backButton, 0, 4)
        Me.mainPanel.Controls.Add(Me.addCollectionButton, 0, 1)
        Me.mainPanel.Controls.Add(Me.listsLabel, 0, 0)
        Me.mainPanel.Controls.Add(Me.listsPanel, 0, 3)
        Me.mainPanel.Controls.Add(Me.addListButton, 0, 2)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.RowCount = 5
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainPanel.Size = New System.Drawing.Size(712, 302)
        Me.mainPanel.TabIndex = 0
        '
        'backButton
        '
        Me.backButton.AutoSize = True
        Me.backButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.backButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(3, 258)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(706, 41)
        Me.backButton.TabIndex = 3
        Me.backButton.Text = "Retour"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'addCollectionButton
        '
        Me.addCollectionButton.AutoSize = True
        Me.addCollectionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.addCollectionButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addCollectionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addCollectionButton.Location = New System.Drawing.Point(3, 34)
        Me.addCollectionButton.Name = "addCollectionButton"
        Me.addCollectionButton.Size = New System.Drawing.Size(706, 41)
        Me.addCollectionButton.TabIndex = 0
        Me.addCollectionButton.Text = "Ajouter une collection"
        Me.addCollectionButton.UseVisualStyleBackColor = True
        '
        'listsLabel
        '
        Me.listsLabel.AutoSize = True
        Me.listsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listsLabel.ForeColor = System.Drawing.Color.Red
        Me.listsLabel.Location = New System.Drawing.Point(3, 0)
        Me.listsLabel.Name = "listsLabel"
        Me.listsLabel.Size = New System.Drawing.Size(706, 31)
        Me.listsLabel.TabIndex = 0
        Me.listsLabel.Text = "Mes listes"
        Me.listsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'listsPanel
        '
        Me.listsPanel.AutoScroll = True
        Me.listsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listsPanel.Location = New System.Drawing.Point(3, 128)
        Me.listsPanel.Name = "listsPanel"
        Me.listsPanel.Size = New System.Drawing.Size(706, 124)
        Me.listsPanel.TabIndex = 2
        '
        'addListButton
        '
        Me.addListButton.AutoSize = True
        Me.addListButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.addListButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addListButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addListButton.Location = New System.Drawing.Point(3, 81)
        Me.addListButton.Name = "addListButton"
        Me.addListButton.Size = New System.Drawing.Size(706, 41)
        Me.addListButton.TabIndex = 1
        Me.addListButton.Text = "Ajouter une liste"
        Me.addListButton.UseVisualStyleBackColor = True
        '
        'ListsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(712, 302)
        Me.Controls.Add(Me.mainPanel)
        Me.Name = "ListsForm"
        Me.Text = "Listes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainPanel As TableLayoutPanel
    Friend WithEvents backButton As Button
    Friend WithEvents addCollectionButton As Button
    Friend WithEvents listsLabel As Label
    Friend WithEvents listsPanel As FlowLayoutPanel
    Friend WithEvents addListButton As Button
End Class
