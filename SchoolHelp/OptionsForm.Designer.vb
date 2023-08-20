<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OptionsForm
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
        Me.mainPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.chooseFunctionLabel = New System.Windows.Forms.Label()
        Me.optionsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainPanel
        '
        Me.mainPanel.ColumnCount = 1
        Me.mainPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainPanel.Controls.Add(Me.chooseFunctionLabel, 0, 0)
        Me.mainPanel.Controls.Add(Me.optionsPanel, 0, 1)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.RowCount = 2
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.84422!))
        Me.mainPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.15578!))
        Me.mainPanel.Size = New System.Drawing.Size(914, 398)
        Me.mainPanel.TabIndex = 0
        '
        'chooseFunctionLabel
        '
        Me.chooseFunctionLabel.AutoSize = True
        Me.chooseFunctionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chooseFunctionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chooseFunctionLabel.Location = New System.Drawing.Point(3, 0)
        Me.chooseFunctionLabel.Name = "chooseFunctionLabel"
        Me.chooseFunctionLabel.Size = New System.Drawing.Size(908, 74)
        Me.chooseFunctionLabel.TabIndex = 0
        Me.chooseFunctionLabel.Text = "Choisissez une option"
        Me.chooseFunctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optionsPanel
        '
        Me.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.optionsPanel.Location = New System.Drawing.Point(3, 77)
        Me.optionsPanel.Name = "optionsPanel"
        Me.optionsPanel.Size = New System.Drawing.Size(908, 318)
        Me.optionsPanel.TabIndex = 1
        '
        'OptionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 398)
        Me.Controls.Add(Me.mainPanel)
        Me.Name = "OptionsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aides pour la scolarité"
        Me.mainPanel.ResumeLayout(False)
        Me.mainPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As TableLayoutPanel
    Friend WithEvents chooseFunctionLabel As Label
    Friend WithEvents optionsPanel As FlowLayoutPanel
End Class
