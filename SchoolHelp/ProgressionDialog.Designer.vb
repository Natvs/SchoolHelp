<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProgressionDialog
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
        Me.progressionBar = New System.Windows.Forms.ProgressBar()
        Me.progressionLabel = New System.Windows.Forms.Label()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.progressionBar, 0, 1)
        Me.mainTableLayoutPanel.Controls.Add(Me.progressionLabel, 0, 0)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 2
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(621, 90)
        Me.mainTableLayoutPanel.TabIndex = 0
        '
        'progressionBar
        '
        Me.progressionBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressionBar.Location = New System.Drawing.Point(3, 48)
        Me.progressionBar.Name = "progressionBar"
        Me.progressionBar.Size = New System.Drawing.Size(615, 39)
        Me.progressionBar.TabIndex = 1
        Me.progressionBar.Value = 50
        '
        'progressionLabel
        '
        Me.progressionLabel.AutoSize = True
        Me.progressionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.progressionLabel.Location = New System.Drawing.Point(3, 0)
        Me.progressionLabel.Name = "progressionLabel"
        Me.progressionLabel.Size = New System.Drawing.Size(615, 45)
        Me.progressionLabel.TabIndex = 2
        Me.progressionLabel.Text = "Veuillez patienter..."
        Me.progressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "ProgressionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progression"
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents progressionBar As ProgressBar
    Friend WithEvents progressionLabel As Label
End Class
