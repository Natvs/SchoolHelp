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
        Me.mainBox = New System.Windows.Forms.TableLayoutPanel()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.mainBox.SuspendLayout()
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
        Me.lignBox.Location = New System.Drawing.Point(38, 3)
        Me.lignBox.Name = "lignBox"
        Me.lignBox.RowCount = 1
        Me.lignBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.lignBox.Size = New System.Drawing.Size(674, 38)
        Me.lignBox.TabIndex = 1
        '
        'mainBox
        '
        Me.mainBox.ColumnCount = 2
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.0!))
        Me.mainBox.Controls.Add(Me.lignBox, 1, 0)
        Me.mainBox.Controls.Add(Me.deleteButton, 0, 0)
        Me.mainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainBox.Location = New System.Drawing.Point(0, 0)
        Me.mainBox.Name = "mainBox"
        Me.mainBox.RowCount = 1
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainBox.Size = New System.Drawing.Size(715, 44)
        Me.mainBox.TabIndex = 0
        '
        'deleteButton
        '
        Me.deleteButton.BackgroundImage = Global.SchoolHelp.My.Resources.Resources.cross
        Me.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteButton.Location = New System.Drawing.Point(3, 3)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(29, 38)
        Me.deleteButton.TabIndex = 0
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'ListItemsBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.mainBox)
        Me.Name = "ListItemsBox"
        Me.Size = New System.Drawing.Size(715, 44)
        Me.mainBox.ResumeLayout(False)
        Me.mainBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lignBox As TableLayoutPanel
    Friend WithEvents mainBox As TableLayoutPanel
    Friend WithEvents deleteButton As Button
End Class
