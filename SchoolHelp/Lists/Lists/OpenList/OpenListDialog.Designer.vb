<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpenListDialog
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
        Me.MainBox = New System.Windows.Forms.TableLayoutPanel()
        Me.LaunchListMode2Box = New System.Windows.Forms.TableLayoutPanel()
        Me.EditListBox = New SchoolHelp.ButtonMessageBox()
        Me.LaunchListMode1Box = New System.Windows.Forms.TableLayoutPanel()
        Me.MainBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainBox
        '
        Me.MainBox.AutoSize = True
        Me.MainBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainBox.BackColor = System.Drawing.Color.Cornsilk
        Me.MainBox.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.MainBox.ColumnCount = 2
        Me.MainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.MainBox.Controls.Add(Me.LaunchListMode2Box, 1, 1)
        Me.MainBox.Controls.Add(Me.EditListBox, 0, 0)
        Me.MainBox.Controls.Add(Me.LaunchListMode1Box, 0, 1)
        Me.MainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainBox.Location = New System.Drawing.Point(0, 0)
        Me.MainBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MainBox.Name = "MainBox"
        Me.MainBox.RowCount = 2
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.MainBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MainBox.Size = New System.Drawing.Size(921, 329)
        Me.MainBox.TabIndex = 0
        '
        'LaunchListMode2Box
        '
        Me.LaunchListMode2Box.AutoSize = True
        Me.LaunchListMode2Box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LaunchListMode2Box.ColumnCount = 1
        Me.LaunchListMode2Box.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LaunchListMode2Box.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LaunchListMode2Box.Location = New System.Drawing.Point(461, 130)
        Me.LaunchListMode2Box.Margin = New System.Windows.Forms.Padding(0)
        Me.LaunchListMode2Box.Name = "LaunchListMode2Box"
        Me.LaunchListMode2Box.RowCount = 1
        Me.LaunchListMode2Box.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LaunchListMode2Box.Size = New System.Drawing.Size(459, 198)
        Me.LaunchListMode2Box.TabIndex = 2
        '
        'EditListBox
        '
        Me.EditListBox.AutoSize = True
        Me.EditListBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MainBox.SetColumnSpan(Me.EditListBox, 2)
        Me.EditListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EditListBox.Location = New System.Drawing.Point(7, 9)
        Me.EditListBox.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.EditListBox.Name = "EditListBox"
        Me.EditListBox.Size = New System.Drawing.Size(907, 112)
        Me.EditListBox.TabIndex = 0
        '
        'LaunchListMode1Box
        '
        Me.LaunchListMode1Box.AutoSize = True
        Me.LaunchListMode1Box.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.LaunchListMode1Box.ColumnCount = 1
        Me.LaunchListMode1Box.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LaunchListMode1Box.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LaunchListMode1Box.Location = New System.Drawing.Point(1, 130)
        Me.LaunchListMode1Box.Margin = New System.Windows.Forms.Padding(0)
        Me.LaunchListMode1Box.Name = "LaunchListMode1Box"
        Me.LaunchListMode1Box.RowCount = 1
        Me.LaunchListMode1Box.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LaunchListMode1Box.Size = New System.Drawing.Size(459, 198)
        Me.LaunchListMode1Box.TabIndex = 1
        '
        'OpenListDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(921, 329)
        Me.Controls.Add(Me.MainBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OpenListDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ouvrir la liste"
        Me.MainBox.ResumeLayout(False)
        Me.MainBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainBox As TableLayoutPanel
    Friend WithEvents EditListBox As ButtonMessageBox
    Friend WithEvents LaunchListMode1Box As TableLayoutPanel
    Friend WithEvents LaunchListMode2Box As TableLayoutPanel
End Class
