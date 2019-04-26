<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF3_SelectionIntervention
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PF3_SelectionIntervention))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.selectInterComboBox = New System.Windows.Forms.ComboBox()
        Me.selectIntervButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sélectionnez une intervention en cours"
        '
        'selectInterComboBox
        '
        Me.selectInterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectInterComboBox.FormattingEnabled = True
        Me.selectInterComboBox.IntegralHeight = False
        Me.selectInterComboBox.Location = New System.Drawing.Point(41, 128)
        Me.selectInterComboBox.Name = "selectInterComboBox"
        Me.selectInterComboBox.Size = New System.Drawing.Size(282, 21)
        Me.selectInterComboBox.TabIndex = 1
        '
        'selectIntervButton
        '
        Me.selectIntervButton.Location = New System.Drawing.Point(86, 178)
        Me.selectIntervButton.Name = "selectIntervButton"
        Me.selectIntervButton.Size = New System.Drawing.Size(187, 20)
        Me.selectIntervButton.TabIndex = 2
        Me.selectIntervButton.Text = "Valider"
        Me.selectIntervButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Se deconnecter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PF3_SelectionIntervention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 261)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.selectIntervButton)
        Me.Controls.Add(Me.selectInterComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PF3_SelectionIntervention"
        Me.Text = "Selection d'une Intervention"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents selectInterComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents selectIntervButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
