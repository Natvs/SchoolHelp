<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setListsCollectionDialog
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
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.okButton = New System.Windows.Forms.Button()
        Me.nameMessageTextBox = New SchoolHelp.TextMessageBox()
        Me.backColorColorsBox = New SchoolHelp.ColorsBox()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.AutoSize = True
        Me.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.okButton, 0, 2)
        Me.mainTableLayoutPanel.Controls.Add(Me.nameMessageTextBox, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.backColorColorsBox, 0, 1)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 3
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(337, 212)
        Me.mainTableLayoutPanel.TabIndex = 1
        '
        'okButton
        '
        Me.okButton.AutoSize = True
        Me.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(3, 169)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(331, 41)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "Valider"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'nameMessageTextBox
        '
        Me.nameMessageTextBox.AutoSize = True
        Me.nameMessageTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.nameMessageTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nameMessageTextBox.Location = New System.Drawing.Point(3, 3)
        Me.nameMessageTextBox.Name = "nameMessageTextBox"
        Me.nameMessageTextBox.Size = New System.Drawing.Size(331, 67)
        Me.nameMessageTextBox.TabIndex = 2
        '
        'backColorColorsBox
        '
        Me.backColorColorsBox.AutoSize = True
        Me.backColorColorsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.backColorColorsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backColorColorsBox.Location = New System.Drawing.Point(3, 76)
        Me.backColorColorsBox.Name = "backColorColorsBox"
        Me.backColorColorsBox.Size = New System.Drawing.Size(331, 87)
        Me.backColorColorsBox.TabIndex = 3
        '
        'setListsCollectionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 212)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setListsCollectionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier la collection"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents okButton As Button
    Friend WithEvents nameMessageTextBox As TextMessageBox
    Friend WithEvents backColorColorsBox As ColorsBox
End Class
