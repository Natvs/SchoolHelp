<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarkBox
    Inherits SchoolHelp.hookEvents

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
        Me.markPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.editButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.markLabel = New System.Windows.Forms.Label()
        Me.coefLabel = New System.Windows.Forms.Label()
        Me.markPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'markPanel
        '
        Me.markPanel.AutoSize = True
        Me.markPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.markPanel.ColumnCount = 4
        Me.markPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.markPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.markPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.markPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.markPanel.Controls.Add(Me.coefLabel, 2, 0)
        Me.markPanel.Controls.Add(Me.deleteButton, 4, 1)
        Me.markPanel.Controls.Add(Me.editButton, 0, 1)
        Me.markPanel.Controls.Add(Me.markLabel, 0, 0)
        Me.markPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.markPanel.Location = New System.Drawing.Point(0, 0)
        Me.markPanel.Name = "markPanel"
        Me.markPanel.RowCount = 2
        Me.markPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.markPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.markPanel.Size = New System.Drawing.Size(472, 72)
        Me.markPanel.TabIndex = 0
        '
        'editButton
        '
        Me.editButton.AutoSize = True
        Me.editButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.markPanel.SetColumnSpan(Me.editButton, 3)
        Me.editButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(3, 34)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(348, 35)
        Me.editButton.TabIndex = 0
        Me.editButton.Text = "Modifier"
        Me.editButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.AutoSize = True
        Me.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.Location = New System.Drawing.Point(357, 34)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(112, 35)
        Me.deleteButton.TabIndex = 1
        Me.deleteButton.Text = "Supprimer"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'markLabel
        '
        Me.markLabel.AutoSize = True
        Me.markPanel.SetColumnSpan(Me.markLabel, 2)
        Me.markLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.markLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markLabel.ForeColor = System.Drawing.Color.Red
        Me.markLabel.Location = New System.Drawing.Point(3, 0)
        Me.markLabel.Name = "markLabel"
        Me.markLabel.Size = New System.Drawing.Size(230, 31)
        Me.markLabel.TabIndex = 2
        Me.markLabel.Text = "Note"
        Me.markLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'coefLabel
        '
        Me.coefLabel.AutoSize = True
        Me.markPanel.SetColumnSpan(Me.coefLabel, 2)
        Me.coefLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.coefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coefLabel.Location = New System.Drawing.Point(239, 0)
        Me.coefLabel.Name = "coefLabel"
        Me.coefLabel.Size = New System.Drawing.Size(230, 31)
        Me.coefLabel.TabIndex = 3
        Me.coefLabel.Text = "Coefficient"
        Me.coefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MarkBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.markPanel)
        Me.Name = "MarkBox"
        Me.Size = New System.Drawing.Size(472, 72)
        Me.markPanel.ResumeLayout(False)
        Me.markPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents markPanel As TableLayoutPanel
    Friend WithEvents coefLabel As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents editButton As Button
    Friend WithEvents markLabel As Label
End Class
