<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF3_Statut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PF3_Statut))
        Me.comboBoxStatutDesire = New System.Windows.Forms.ComboBox()
        Me.txtStatutActuel = New System.Windows.Forms.TextBox()
        Me.lblStatutDesire = New System.Windows.Forms.Label()
        Me.lblStatutActuel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblInterName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'comboBoxStatutDesire
        '
        Me.comboBoxStatutDesire.FormattingEnabled = True
        Me.comboBoxStatutDesire.Location = New System.Drawing.Point(118, 102)
        Me.comboBoxStatutDesire.Name = "comboBoxStatutDesire"
        Me.comboBoxStatutDesire.Size = New System.Drawing.Size(114, 21)
        Me.comboBoxStatutDesire.TabIndex = 12
        '
        'txtStatutActuel
        '
        Me.txtStatutActuel.Location = New System.Drawing.Point(118, 75)
        Me.txtStatutActuel.Name = "txtStatutActuel"
        Me.txtStatutActuel.ReadOnly = True
        Me.txtStatutActuel.Size = New System.Drawing.Size(114, 20)
        Me.txtStatutActuel.TabIndex = 11
        Me.txtStatutActuel.Text = "Parti"
        '
        'lblStatutDesire
        '
        Me.lblStatutDesire.AutoSize = True
        Me.lblStatutDesire.Location = New System.Drawing.Point(29, 105)
        Me.lblStatutDesire.Name = "lblStatutDesire"
        Me.lblStatutDesire.Size = New System.Drawing.Size(72, 13)
        Me.lblStatutDesire.TabIndex = 10
        Me.lblStatutDesire.Text = "Statut désiré :"
        '
        'lblStatutActuel
        '
        Me.lblStatutActuel.AutoSize = True
        Me.lblStatutActuel.Location = New System.Drawing.Point(29, 78)
        Me.lblStatutActuel.Name = "lblStatutActuel"
        Me.lblStatutActuel.Size = New System.Drawing.Size(73, 13)
        Me.lblStatutActuel.TabIndex = 9
        Me.lblStatutActuel.Text = "Statut actuel :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblInterName
        '
        Me.lblInterName.AutoSize = True
        Me.lblInterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterName.Location = New System.Drawing.Point(29, 35)
        Me.lblInterName.Name = "lblInterName"
        Me.lblInterName.Size = New System.Drawing.Size(261, 16)
        Me.lblInterName.TabIndex = 7
        Me.lblInterName.Text = "48 - Malaise Léger  VP - Saint Renan"
        '
        'PF3_Statut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 195)
        Me.Controls.Add(Me.comboBoxStatutDesire)
        Me.Controls.Add(Me.txtStatutActuel)
        Me.Controls.Add(Me.lblStatutDesire)
        Me.Controls.Add(Me.lblStatutActuel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblInterName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PF3_Statut"
        Me.Text = "Statut"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboBoxStatutDesire As System.Windows.Forms.ComboBox
    Friend WithEvents txtStatutActuel As System.Windows.Forms.TextBox
    Friend WithEvents lblStatutDesire As System.Windows.Forms.Label
    Friend WithEvents lblStatutActuel As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblInterName As System.Windows.Forms.Label
End Class
