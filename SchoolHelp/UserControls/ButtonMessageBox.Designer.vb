<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ButtonMessageBox
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
        Me.mainBox = New System.Windows.Forms.TableLayoutPanel()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.actionButton = New System.Windows.Forms.Button()
        Me.mainBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainBox
        '
        Me.mainBox.AutoSize = True
        Me.mainBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainBox.ColumnCount = 1
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainBox.Controls.Add(Me.messageLabel, 0, 0)
        Me.mainBox.Controls.Add(Me.actionButton, 0, 1)
        Me.mainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainBox.Location = New System.Drawing.Point(0, 0)
        Me.mainBox.Name = "mainBox"
        Me.mainBox.RowCount = 2
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainBox.Size = New System.Drawing.Size(130, 78)
        Me.mainBox.TabIndex = 0
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.messageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageLabel.ForeColor = System.Drawing.Color.Red
        Me.messageLabel.Location = New System.Drawing.Point(3, 0)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(124, 31)
        Me.messageLabel.TabIndex = 0
        Me.messageLabel.Text = "Message"
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'actionButton
        '
        Me.actionButton.AutoSize = True
        Me.actionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.actionButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.actionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.actionButton.ForeColor = System.Drawing.Color.Black
        Me.actionButton.Location = New System.Drawing.Point(3, 34)
        Me.actionButton.Name = "actionButton"
        Me.actionButton.Size = New System.Drawing.Size(124, 41)
        Me.actionButton.TabIndex = 1
        Me.actionButton.Text = "Action"
        Me.actionButton.UseVisualStyleBackColor = True
        '
        'ButtonTextBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.mainBox)
        Me.Name = "ButtonTextBox"
        Me.Size = New System.Drawing.Size(130, 78)
        Me.mainBox.ResumeLayout(False)
        Me.mainBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainBox As TableLayoutPanel
    Friend WithEvents messageLabel As Label
    Friend WithEvents actionButton As Button
End Class
