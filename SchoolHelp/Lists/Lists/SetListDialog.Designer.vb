<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetListDialog
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
        Me.listPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.listColorsBox = New SchoolHelp.ColorsBox()
        Me.listNameBox = New SchoolHelp.TextMessageBox()
        Me.okButton = New System.Windows.Forms.Button()
        Me.columnsNumberBox = New SchoolHelp.NumericMessageBox()
        Me.listPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'listPanel
        '
        Me.listPanel.AutoSize = True
        Me.listPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listPanel.ColumnCount = 1
        Me.listPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.listPanel.Controls.Add(Me.listColorsBox, 0, 1)
        Me.listPanel.Controls.Add(Me.listNameBox, 0, 0)
        Me.listPanel.Controls.Add(Me.okButton, 0, 3)
        Me.listPanel.Controls.Add(Me.columnsNumberBox, 0, 2)
        Me.listPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listPanel.Location = New System.Drawing.Point(0, 0)
        Me.listPanel.Name = "listPanel"
        Me.listPanel.RowCount = 4
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listPanel.Size = New System.Drawing.Size(620, 308)
        Me.listPanel.TabIndex = 0
        '
        'listColorsBox
        '
        Me.listColorsBox.AutoSize = True
        Me.listColorsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listColorsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listColorsBox.Location = New System.Drawing.Point(3, 76)
        Me.listColorsBox.Name = "listColorsBox"
        Me.listColorsBox.Size = New System.Drawing.Size(614, 87)
        Me.listColorsBox.TabIndex = 1
        '
        'listNameBox
        '
        Me.listNameBox.AutoSize = True
        Me.listNameBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listNameBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listNameBox.Location = New System.Drawing.Point(3, 3)
        Me.listNameBox.Name = "listNameBox"
        Me.listNameBox.Size = New System.Drawing.Size(614, 67)
        Me.listNameBox.TabIndex = 0
        '
        'okButton
        '
        Me.okButton.AutoSize = True
        Me.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(3, 263)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(614, 42)
        Me.okButton.TabIndex = 3
        Me.okButton.Text = "Valider"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'columnsNumberBox
        '
        Me.columnsNumberBox.AutoSize = True
        Me.columnsNumberBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.columnsNumberBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.columnsNumberBox.Location = New System.Drawing.Point(3, 169)
        Me.columnsNumberBox.Name = "columnsNumberBox"
        Me.columnsNumberBox.Size = New System.Drawing.Size(614, 88)
        Me.columnsNumberBox.TabIndex = 2
        '
        'setListDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(620, 308)
        Me.Controls.Add(Me.listPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setListDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier la liste"
        Me.listPanel.ResumeLayout(False)
        Me.listPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listPanel As TableLayoutPanel
    Friend WithEvents listColorsBox As ColorsBox
    Friend WithEvents listNameBox As TextMessageBox
    Friend WithEvents okButton As Button
    Friend WithEvents columnsNumberBox As NumericMessageBox
End Class
