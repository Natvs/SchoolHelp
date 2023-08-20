<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class setMarkDialog
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.coefNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.coefLabel = New System.Windows.Forms.Label()
        Me.markLabel = New System.Windows.Forms.Label()
        Me.markNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.okButton = New System.Windows.Forms.Button()
        Me.backColorsBox = New SchoolHelp.ColorsBox()
        Me.mainTableLayoutPanel.SuspendLayout()
        CType(Me.coefNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.markNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.AutoSize = True
        Me.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainTableLayoutPanel.ColumnCount = 2
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.coefNumericUpDown, 1, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.coefLabel, 1, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.markLabel, 0, 0)
        Me.mainTableLayoutPanel.Controls.Add(Me.markNumericUpDown, 0, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.okButton, 0, 3)
        Me.mainTableLayoutPanel.Controls.Add(Me.backColorsBox, 0, 2)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 4
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(341, 220)
        Me.mainTableLayoutPanel.TabIndex = 0
        '
        'coefNumericUpDown
        '
        Me.coefNumericUpDown.AutoSize = True
        Me.coefNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.coefNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coefNumericUpDown.Location = New System.Drawing.Point(173, 34)
        Me.coefNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.coefNumericUpDown.Name = "coefNumericUpDown"
        Me.coefNumericUpDown.Size = New System.Drawing.Size(165, 45)
        Me.coefNumericUpDown.TabIndex = 3
        Me.coefNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.coefNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'coefLabel
        '
        Me.coefLabel.AutoSize = True
        Me.coefLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.coefLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coefLabel.ForeColor = System.Drawing.Color.Red
        Me.coefLabel.Location = New System.Drawing.Point(173, 0)
        Me.coefLabel.Name = "coefLabel"
        Me.coefLabel.Size = New System.Drawing.Size(165, 31)
        Me.coefLabel.TabIndex = 1
        Me.coefLabel.Text = "Coefficient"
        Me.coefLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'markLabel
        '
        Me.markLabel.AutoSize = True
        Me.markLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.markLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markLabel.ForeColor = System.Drawing.Color.Red
        Me.markLabel.Location = New System.Drawing.Point(3, 0)
        Me.markLabel.Name = "markLabel"
        Me.markLabel.Size = New System.Drawing.Size(164, 31)
        Me.markLabel.TabIndex = 0
        Me.markLabel.Text = "Note"
        Me.markLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'markNumericUpDown
        '
        Me.markNumericUpDown.AutoSize = True
        Me.markNumericUpDown.DecimalPlaces = 1
        Me.markNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.markNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markNumericUpDown.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.markNumericUpDown.Location = New System.Drawing.Point(3, 34)
        Me.markNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.markNumericUpDown.Name = "markNumericUpDown"
        Me.markNumericUpDown.Size = New System.Drawing.Size(164, 45)
        Me.markNumericUpDown.TabIndex = 2
        Me.markNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'okButton
        '
        Me.okButton.AutoSize = True
        Me.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainTableLayoutPanel.SetColumnSpan(Me.okButton, 2)
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.okButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(3, 178)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(335, 41)
        Me.okButton.TabIndex = 4
        Me.okButton.Text = "Valider"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'backColorsBox
        '
        Me.backColorsBox.AutoSize = True
        Me.backColorsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainTableLayoutPanel.SetColumnSpan(Me.backColorsBox, 2)
        Me.backColorsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backColorsBox.Location = New System.Drawing.Point(3, 85)
        Me.backColorsBox.Name = "backColorsBox"
        Me.backColorsBox.Size = New System.Drawing.Size(335, 87)
        Me.backColorsBox.TabIndex = 5
        '
        'setMarkDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(341, 220)
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "setMarkDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier la note"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        CType(Me.coefNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.markNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents coefNumericUpDown As NumericUpDown
    Friend WithEvents coefLabel As Label
    Friend WithEvents markLabel As Label
    Friend WithEvents markNumericUpDown As NumericUpDown
    Friend WithEvents okButton As Button
    Friend WithEvents backColorsBox As ColorsBox
End Class
