<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MarksOptionsDialog
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
        Me.optionsTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.optionLabel = New System.Windows.Forms.Label()
        Me.EditMarksColorsByNumberBox = New SchoolHelp.EditColorsByNumberBox()
        Me.EditMarksCollectionsColorsByNumberBox = New SchoolHelp.EditColorsByNumberBox()
        Me.optionsTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'optionsTableLayoutPanel
        '
        Me.optionsTableLayoutPanel.AutoSize = True
        Me.optionsTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.optionsTableLayoutPanel.ColumnCount = 2
        Me.optionsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.optionsTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.optionsTableLayoutPanel.Controls.Add(Me.optionLabel, 0, 0)
        Me.optionsTableLayoutPanel.Controls.Add(Me.EditMarksColorsByNumberBox, 0, 1)
        Me.optionsTableLayoutPanel.Controls.Add(Me.EditMarksCollectionsColorsByNumberBox, 1, 1)
        Me.optionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optionsTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.optionsTableLayoutPanel.Name = "optionsTableLayoutPanel"
        Me.optionsTableLayoutPanel.RowCount = 2
        Me.optionsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionsTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.optionsTableLayoutPanel.Size = New System.Drawing.Size(606, 192)
        Me.optionsTableLayoutPanel.TabIndex = 0
        '
        'optionLabel
        '
        Me.optionLabel.AutoSize = True
        Me.optionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.optionsTableLayoutPanel.SetColumnSpan(Me.optionLabel, 2)
        Me.optionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optionLabel.ForeColor = System.Drawing.Color.Red
        Me.optionLabel.Location = New System.Drawing.Point(3, 0)
        Me.optionLabel.Name = "optionLabel"
        Me.optionLabel.Size = New System.Drawing.Size(618, 33)
        Me.optionLabel.TabIndex = 0
        Me.optionLabel.Text = "Options des notes"
        Me.optionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditMarksColorsByNumberBox
        '
        Me.EditMarksColorsByNumberBox.AutoSize = True
        Me.EditMarksColorsByNumberBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditMarksColorsByNumberBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditMarksColorsByNumberBox.Location = New System.Drawing.Point(3, 36)
        Me.EditMarksColorsByNumberBox.Name = "EditMarksColorsByNumberBox"
        Me.EditMarksColorsByNumberBox.Size = New System.Drawing.Size(306, 153)
        Me.EditMarksColorsByNumberBox.TabIndex = 1
        '
        'EditMarksCollectionsColorsByNumberBox
        '
        Me.EditMarksCollectionsColorsByNumberBox.AutoSize = True
        Me.EditMarksCollectionsColorsByNumberBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.EditMarksCollectionsColorsByNumberBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditMarksCollectionsColorsByNumberBox.Location = New System.Drawing.Point(315, 36)
        Me.EditMarksCollectionsColorsByNumberBox.Name = "EditMarksCollectionsColorsByNumberBox"
        Me.EditMarksCollectionsColorsByNumberBox.Size = New System.Drawing.Size(306, 153)
        Me.EditMarksCollectionsColorsByNumberBox.TabIndex = 2
        '
        'MarksOptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(606, 192)
        Me.Controls.Add(Me.optionsTableLayoutPanel)
        Me.Name = "MarksOptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options des notes"
        Me.optionsTableLayoutPanel.ResumeLayout(False)
        Me.optionsTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optionsTableLayoutPanel As TableLayoutPanel
    Friend WithEvents optionLabel As Label
    Friend WithEvents EditMarksColorsByNumberBox As EditColorsByNumberBox
    Friend WithEvents EditMarksCollectionsColorsByNumberBox As EditColorsByNumberBox
End Class
