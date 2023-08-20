<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextMessageBox
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
        Me.TextPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.TextTextBox = New System.Windows.Forms.TextBox()
        Me.TextPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextPanel
        '
        Me.TextPanel.AutoSize = True
        Me.TextPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TextPanel.ColumnCount = 1
        Me.TextPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TextPanel.Controls.Add(Me.MessageLabel, 0, 0)
        Me.TextPanel.Controls.Add(Me.TextTextBox, 0, 1)
        Me.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextPanel.Location = New System.Drawing.Point(0, 0)
        Me.TextPanel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextPanel.Name = "TextPanel"
        Me.TextPanel.RowCount = 2
        Me.TextPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TextPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TextPanel.Size = New System.Drawing.Size(193, 97)
        Me.TextPanel.TabIndex = 0
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageLabel.ForeColor = System.Drawing.Color.Red
        Me.MessageLabel.Location = New System.Drawing.Point(4, 0)
        Me.MessageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(185, 46)
        Me.MessageLabel.TabIndex = 0
        Me.MessageLabel.Text = "Message"
        Me.MessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextTextBox
        '
        Me.TextTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.TextTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTextBox.Location = New System.Drawing.Point(4, 51)
        Me.TextTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextTextBox.Name = "TextTextBox"
        Me.TextTextBox.Size = New System.Drawing.Size(185, 41)
        Me.TextTextBox.TabIndex = 1
        Me.TextTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.TextPanel)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "TextMessageBox"
        Me.Size = New System.Drawing.Size(193, 97)
        Me.TextPanel.ResumeLayout(False)
        Me.TextPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextPanel As TableLayoutPanel
    Friend WithEvents MessageLabel As Label
    Friend WithEvents TextTextBox As TextBox
End Class
