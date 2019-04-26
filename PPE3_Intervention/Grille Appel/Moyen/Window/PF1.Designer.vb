<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF1
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
        Me.btnValider = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btnValider
        '
        Me.btnValider.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnValider.Location = New System.Drawing.Point(323, 494)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(75, 23)
        Me.btnValider.TabIndex = 13
        Me.btnValider.Text = "Valider"
        Me.btnValider.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(24, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 420)
        Me.Panel1.TabIndex = 21
        '
        'PF1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnValider)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "PF1"
        Me.Text = "l"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnValider As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
