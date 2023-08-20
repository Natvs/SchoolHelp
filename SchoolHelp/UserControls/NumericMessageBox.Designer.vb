<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumericMessageBox
    Inherits System.Windows.Forms.UserControl

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
        Me.MainBox = New System.Windows.Forms.TableLayoutPanel()
        Me.valueNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.MainBox.SuspendLayout()
        CType(Me.valueNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainBox
        '
        Me.MainBox.AutoSize = True
        Me.MainBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainBox.ColumnCount = 1
        Me.MainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainBox.Controls.Add(Me.valueNumericUpDown, 0, 1)
        Me.MainBox.Controls.Add(Me.messageLabel, 0, 0)
        Me.MainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBox.Location = New System.Drawing.Point(0, 0)
        Me.MainBox.Name = "MainBox"
        Me.MainBox.RowCount = 2
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainBox.Size = New System.Drawing.Size(130, 88)
        Me.MainBox.TabIndex = 0
        '
        'valueNumericUpDown
        '
        Me.valueNumericUpDown.AutoSize = True
        Me.valueNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.valueNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueNumericUpDown.Location = New System.Drawing.Point(3, 47)
        Me.valueNumericUpDown.Name = "valueNumericUpDown"
        Me.valueNumericUpDown.Size = New System.Drawing.Size(124, 38)
        Me.valueNumericUpDown.TabIndex = 0
        Me.valueNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.messageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageLabel.ForeColor = System.Drawing.Color.Red
        Me.messageLabel.Location = New System.Drawing.Point(3, 0)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(124, 44)
        Me.messageLabel.TabIndex = 1
        Me.messageLabel.Text = "Message"
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.MainBox)
        Me.Name = "NumericTextBox"
        Me.Size = New System.Drawing.Size(130, 88)
        Me.MainBox.ResumeLayout(False)
        Me.MainBox.PerformLayout()
        CType(Me.valueNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainBox As TableLayoutPanel
    Friend WithEvents valueNumericUpDown As NumericUpDown
    Friend WithEvents messageLabel As Label
End Class
