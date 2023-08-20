<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarksForm
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
        Me.marksLabel = New System.Windows.Forms.Label()
        Me.marksPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.addMarkButton = New System.Windows.Forms.Button()
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
        Me.mainPanel.Controls.Add(Me.marksLabel, 0, 0)
        Me.mainPanel.Controls.Add(Me.marksPanel, 0, 3)
        Me.mainPanel.Controls.Add(Me.addMarkButton, 0, 2)
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
        'marksLabel
        '
        Me.marksLabel.AutoSize = True
        Me.marksLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.marksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marksLabel.ForeColor = System.Drawing.Color.Red
        Me.marksLabel.Location = New System.Drawing.Point(3, 0)
        Me.marksLabel.Name = "marksLabel"
        Me.marksLabel.Size = New System.Drawing.Size(706, 31)
        Me.marksLabel.TabIndex = 0
        Me.marksLabel.Text = "Mes notes"
        Me.marksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marksPanel
        '
        Me.marksPanel.AutoScroll = True
        Me.marksPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.marksPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.marksPanel.Location = New System.Drawing.Point(3, 128)
        Me.marksPanel.Name = "marksPanel"
        Me.marksPanel.Size = New System.Drawing.Size(706, 124)
        Me.marksPanel.TabIndex = 2
        '
        'addMarkButton
        '
        Me.addMarkButton.AutoSize = True
        Me.addMarkButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.addMarkButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addMarkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addMarkButton.Location = New System.Drawing.Point(3, 81)
        Me.addMarkButton.Name = "addMarkButton"
        Me.addMarkButton.Size = New System.Drawing.Size(706, 41)
        Me.addMarkButton.TabIndex = 1
        Me.addMarkButton.Text = "Ajouter une note"
        Me.addMarkButton.UseVisualStyleBackColor = True
        '
        'MarksForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(712, 302)
        Me.Controls.Add(Me.mainPanel)
        Me.Name = "MarksForm"
        Me.Text = "Notes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainPanel As TableLayoutPanel
    Friend WithEvents marksLabel As Label
    Friend WithEvents marksPanel As FlowLayoutPanel
    Friend WithEvents addMarkButton As Button
    Friend WithEvents addCollectionButton As Button
    Friend WithEvents backButton As Button
End Class
