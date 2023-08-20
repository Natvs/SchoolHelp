<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SchoolHelpDialog
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
        Me.dialogBox = New System.Windows.Forms.TableLayoutPanel()
        Me.messageLabel = New System.Windows.Forms.Label()
        Me.dialogBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'dialogBox
        '
        Me.dialogBox.AutoSize = True
        Me.dialogBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.dialogBox.ColumnCount = 1
        Me.dialogBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.dialogBox.Controls.Add(Me.messageLabel, 0, 0)
        Me.dialogBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dialogBox.Location = New System.Drawing.Point(0, 0)
        Me.dialogBox.Name = "dialogBox"
        Me.dialogBox.RowCount = 2
        Me.dialogBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.dialogBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.dialogBox.Size = New System.Drawing.Size(588, 130)
        Me.dialogBox.TabIndex = 0
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.messageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messageLabel.Location = New System.Drawing.Point(3, 0)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(582, 31)
        Me.messageLabel.TabIndex = 0
        Me.messageLabel.Text = "Message"
        Me.messageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SchoolHelpDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(588, 130)
        Me.ControlBox = False
        Me.Controls.Add(Me.dialogBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "SchoolHelpDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Boite de dialogue"
        Me.dialogBox.ResumeLayout(False)
        Me.dialogBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dialogBox As TableLayoutPanel
    Friend WithEvents messageLabel As Label
End Class
