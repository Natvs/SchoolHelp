<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListItemsBox
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
        Me.lignBox = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'lignBox
        '
        Me.lignBox.AutoSize = True
        Me.lignBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lignBox.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.lignBox.ColumnCount = 1
        Me.lignBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.lignBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lignBox.Location = New System.Drawing.Point(0, 0)
        Me.lignBox.Name = "lignBox"
        Me.lignBox.RowCount = 1
        Me.lignBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.lignBox.Size = New System.Drawing.Size(715, 29)
        Me.lignBox.TabIndex = 0
        '
        'ListItemsBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.lignBox)
        Me.Name = "ListItemsBox"
        Me.Size = New System.Drawing.Size(715, 29)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lignBox As TableLayoutPanel
End Class
