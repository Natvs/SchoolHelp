<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionBox
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.optionPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.launchButton = New System.Windows.Forms.Button()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.optionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'optionPanel
        '
        Me.optionPanel.AutoSize = True
        Me.optionPanel.ColumnCount = 1
        Me.optionPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.optionPanel.Controls.Add(Me.descriptionLabel, 0, 1)
        Me.optionPanel.Controls.Add(Me.launchButton, 0, 2)
        Me.optionPanel.Controls.Add(Me.titleLabel, 0, 0)
        Me.optionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optionPanel.Location = New System.Drawing.Point(0, 0)
        Me.optionPanel.MaximumSize = New System.Drawing.Size(400, 0)
        Me.optionPanel.MinimumSize = New System.Drawing.Size(400, 0)
        Me.optionPanel.Name = "optionPanel"
        Me.optionPanel.RowCount = 3
        Me.optionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionPanel.Size = New System.Drawing.Size(400, 100)
        Me.optionPanel.TabIndex = 0
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.descriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descriptionLabel.Location = New System.Drawing.Point(3, 39)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(394, 20)
        Me.descriptionLabel.TabIndex = 2
        Me.descriptionLabel.Text = "Description"
        Me.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'launchButton
        '
        Me.launchButton.AutoSize = True
        Me.launchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.launchButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.launchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.launchButton.Location = New System.Drawing.Point(3, 62)
        Me.launchButton.Name = "launchButton"
        Me.launchButton.Size = New System.Drawing.Size(394, 35)
        Me.launchButton.TabIndex = 0
        Me.launchButton.Text = "Lancer la fonction"
        Me.launchButton.UseVisualStyleBackColor = True
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.Red
        Me.titleLabel.Location = New System.Drawing.Point(3, 0)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(394, 39)
        Me.titleLabel.TabIndex = 1
        Me.titleLabel.Text = "Titre"
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OptionBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.optionPanel)
        Me.Name = "OptionBox"
        Me.Size = New System.Drawing.Size(400, 100)
        Me.optionPanel.ResumeLayout(False)
        Me.optionPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optionPanel As TableLayoutPanel
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents launchButton As Button
    Friend WithEvents titleLabel As Label
End Class
