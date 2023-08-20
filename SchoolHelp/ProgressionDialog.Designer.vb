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
        Me.ProgressionBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressionBox = New System.Windows.Forms.TableLayoutPanel()
        Me.ProgressionLabel = New System.Windows.Forms.Label()
        Me.ProgressionBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgressionBar
        '
        Me.ProgressionBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressionBar.Location = New System.Drawing.Point(3, 34)
        Me.ProgressionBar.Name = "ProgressionBar"
        Me.ProgressionBar.Size = New System.Drawing.Size(566, 38)
        Me.ProgressionBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressionBar.TabIndex = 0
        '
        'ProgressionBox
        '
        Me.ProgressionBox.AutoSize = True
        Me.ProgressionBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ProgressionBox.ColumnCount = 1
        Me.ProgressionBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ProgressionBox.Controls.Add(Me.ProgressionBar, 0, 1)
        Me.ProgressionBox.Controls.Add(Me.ProgressionLabel, 0, 0)
        Me.ProgressionBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressionBox.Location = New System.Drawing.Point(0, 0)
        Me.ProgressionBox.Name = "ProgressionBox"
        Me.ProgressionBox.RowCount = 2
        Me.ProgressionBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ProgressionBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.ProgressionBox.Size = New System.Drawing.Size(572, 75)
        Me.ProgressionBox.TabIndex = 1
        '
        'ProgressionLabel
        '
        Me.ProgressionLabel.AutoSize = True
        Me.ProgressionLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressionLabel.Location = New System.Drawing.Point(3, 0)
        Me.ProgressionLabel.Name = "ProgressionLabel"
        Me.ProgressionLabel.Size = New System.Drawing.Size(566, 31)
        Me.ProgressionLabel.TabIndex = 1
        Me.ProgressionLabel.Text = "Message de progression"
        Me.ProgressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(572, 75)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressionBox)
        Me.Name = "ProgressionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Veuillez patienter"
        Me.ProgressionBox.ResumeLayout(False)
        Me.ProgressionBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressionBar As ProgressBar
    Friend WithEvents ProgressionBox As TableLayoutPanel
    Friend WithEvents ProgressionLabel As Label
End Class
