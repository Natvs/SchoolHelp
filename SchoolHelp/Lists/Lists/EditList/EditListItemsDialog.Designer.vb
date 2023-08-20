<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditListItemsDialog
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
        Me.mainBox = New System.Windows.Forms.TableLayoutPanel()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.listItemsBox = New System.Windows.Forms.TableLayoutPanel()
        Me.addLignButton = New System.Windows.Forms.Button()
        Me.mainBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainBox
        '
        Me.mainBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainBox.ColumnCount = 1
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainBox.Controls.Add(Me.closeButton, 0, 2)
        Me.mainBox.Controls.Add(Me.listItemsBox, 0, 1)
        Me.mainBox.Controls.Add(Me.addLignButton, 0, 0)
        Me.mainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainBox.Location = New System.Drawing.Point(0, 0)
        Me.mainBox.Name = "mainBox"
        Me.mainBox.RowCount = 3
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainBox.Size = New System.Drawing.Size(850, 454)
        Me.mainBox.TabIndex = 0
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.closeButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.closeButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.closeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeButton.Location = New System.Drawing.Point(3, 410)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(844, 41)
        Me.closeButton.TabIndex = 2
        Me.closeButton.Text = "Fermer"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'listItemsBox
        '
        Me.listItemsBox.AutoScroll = True
        Me.listItemsBox.AutoSize = True
        Me.listItemsBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.listItemsBox.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.listItemsBox.ColumnCount = 1
        Me.listItemsBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.listItemsBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listItemsBox.Location = New System.Drawing.Point(3, 50)
        Me.listItemsBox.Name = "listItemsBox"
        Me.listItemsBox.RowCount = 1
        Me.listItemsBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.listItemsBox.Size = New System.Drawing.Size(844, 354)
        Me.listItemsBox.TabIndex = 1
        '
        'addLignButton
        '
        Me.addLignButton.AutoSize = True
        Me.addLignButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.addLignButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addLignButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addLignButton.Location = New System.Drawing.Point(3, 3)
        Me.addLignButton.Name = "addLignButton"
        Me.addLignButton.Size = New System.Drawing.Size(844, 41)
        Me.addLignButton.TabIndex = 0
        Me.addLignButton.Text = "Ajouter une ligne"
        Me.addLignButton.UseVisualStyleBackColor = True
        '
        'EditListItemsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(850, 454)
        Me.Controls.Add(Me.mainBox)
        Me.Name = "EditListItemsDialog"
        Me.Text = "Modifier les items de la liste"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mainBox.ResumeLayout(False)
        Me.mainBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainBox As TableLayoutPanel
    Friend WithEvents closeButton As Button
    Friend WithEvents listItemsBox As TableLayoutPanel
    Friend WithEvents addLignButton As Button
End Class
