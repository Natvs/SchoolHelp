<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditColorsByNumberBox
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
        Me.mainTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.mainLabel = New System.Windows.Forms.Label()
        Me.mainTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainTableLayoutPanel
        '
        Me.mainTableLayoutPanel.AutoSize = True
        Me.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainTableLayoutPanel.ColumnCount = 1
        Me.mainTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.Controls.Add(Me.mainLabel, 0, 0)
        Me.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainTableLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainTableLayoutPanel.Name = "mainTableLayoutPanel"
        Me.mainTableLayoutPanel.RowCount = 2
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainTableLayoutPanel.Size = New System.Drawing.Size(306, 31)
        Me.mainTableLayoutPanel.TabIndex = 0
        '
        'mainLabel
        '
        Me.mainLabel.AutoSize = True
        Me.mainLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainLabel.ForeColor = System.Drawing.Color.Red
        Me.mainLabel.Location = New System.Drawing.Point(3, 0)
        Me.mainLabel.Name = "mainLabel"
        Me.mainLabel.Size = New System.Drawing.Size(300, 31)
        Me.mainLabel.TabIndex = 0
        Me.mainLabel.Text = "Intervalles des couleurs"
        Me.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EditColorsByNumberBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.mainTableLayoutPanel)
        Me.Name = "EditColorsByNumberBox"
        Me.Size = New System.Drawing.Size(306, 31)
        Me.mainTableLayoutPanel.ResumeLayout(False)
        Me.mainTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainTableLayoutPanel As TableLayoutPanel
    Friend WithEvents mainLabel As Label
End Class
