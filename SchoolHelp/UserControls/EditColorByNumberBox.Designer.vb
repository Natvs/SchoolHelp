<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditColorByNumberBox
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
        Me.toNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.toLabel = New System.Windows.Forms.Label()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.fromNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.colorButton = New System.Windows.Forms.Button()
        Me.mainBox.SuspendLayout()
        CType(Me.toNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fromNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainBox
        '
        Me.mainBox.AutoSize = True
        Me.mainBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.mainBox.ColumnCount = 5
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainBox.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.mainBox.Controls.Add(Me.toNumericUpDown, 3, 0)
        Me.mainBox.Controls.Add(Me.toLabel, 2, 0)
        Me.mainBox.Controls.Add(Me.FromLabel, 0, 0)
        Me.mainBox.Controls.Add(Me.fromNumericUpDown, 1, 0)
        Me.mainBox.Controls.Add(Me.colorButton, 4, 0)
        Me.mainBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainBox.Location = New System.Drawing.Point(0, 0)
        Me.mainBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mainBox.Name = "mainBox"
        Me.mainBox.RowCount = 1
        Me.mainBox.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.mainBox.Size = New System.Drawing.Size(522, 87)
        Me.mainBox.TabIndex = 0
        '
        'toNumericUpDown
        '
        Me.toNumericUpDown.AutoSize = True
        Me.toNumericUpDown.DecimalPlaces = 2
        Me.toNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.toNumericUpDown.Location = New System.Drawing.Point(288, 5)
        Me.toNumericUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.toNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.toNumericUpDown.MinimumSize = New System.Drawing.Size(147, 0)
        Me.toNumericUpDown.Name = "toNumericUpDown"
        Me.toNumericUpDown.Size = New System.Drawing.Size(147, 53)
        Me.toNumericUpDown.TabIndex = 4
        Me.toNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'toLabel
        '
        Me.toLabel.AutoSize = True
        Me.toLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toLabel.ForeColor = System.Drawing.Color.Red
        Me.toLabel.Location = New System.Drawing.Point(238, 0)
        Me.toLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.toLabel.Name = "toLabel"
        Me.toLabel.Size = New System.Drawing.Size(42, 87)
        Me.toLabel.TabIndex = 2
        Me.toLabel.Text = "à"
        Me.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FromLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromLabel.ForeColor = System.Drawing.Color.Red
        Me.FromLabel.Location = New System.Drawing.Point(4, 0)
        Me.FromLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(71, 87)
        Me.FromLabel.TabIndex = 0
        Me.FromLabel.Text = "De"
        Me.FromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fromNumericUpDown
        '
        Me.fromNumericUpDown.AutoSize = True
        Me.fromNumericUpDown.DecimalPlaces = 2
        Me.fromNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fromNumericUpDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromNumericUpDown.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.fromNumericUpDown.Location = New System.Drawing.Point(83, 5)
        Me.fromNumericUpDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fromNumericUpDown.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.fromNumericUpDown.MinimumSize = New System.Drawing.Size(147, 0)
        Me.fromNumericUpDown.Name = "fromNumericUpDown"
        Me.fromNumericUpDown.Size = New System.Drawing.Size(147, 53)
        Me.fromNumericUpDown.TabIndex = 3
        Me.fromNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'colorButton
        '
        Me.colorButton.AutoSize = True
        Me.colorButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.colorButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.colorButton.Location = New System.Drawing.Point(443, 5)
        Me.colorButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.colorButton.MinimumSize = New System.Drawing.Size(75, 77)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(75, 77)
        Me.colorButton.TabIndex = 5
        Me.colorButton.UseVisualStyleBackColor = False
        '
        'EditColorByNumberBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.mainBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditColorByNumberBox"
        Me.Size = New System.Drawing.Size(522, 87)
        Me.mainBox.ResumeLayout(False)
        Me.mainBox.PerformLayout()
        CType(Me.toNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fromNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainBox As TableLayoutPanel
    Friend WithEvents FromLabel As Label
    Friend WithEvents toLabel As Label
    Friend WithEvents toNumericUpDown As NumericUpDown
    Friend WithEvents fromNumericUpDown As NumericUpDown
    Friend WithEvents colorButton As Button
End Class
