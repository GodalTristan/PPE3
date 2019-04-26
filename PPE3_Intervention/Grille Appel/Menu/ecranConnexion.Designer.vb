<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ecranConnexion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ecranConnexion))
        Me.LB_Connexion = New System.Windows.Forms.Label()
        Me.TB_Identifiant = New System.Windows.Forms.TextBox()
        Me.TB_Motdepasse = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_Connexion = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Statut = New System.Windows.Forms.TextBox()
        Me.LB_message = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LB_Connexion
        '
        Me.LB_Connexion.AutoSize = True
        Me.LB_Connexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LB_Connexion.Location = New System.Drawing.Point(253, 109)
        Me.LB_Connexion.Name = "LB_Connexion"
        Me.LB_Connexion.Size = New System.Drawing.Size(143, 31)
        Me.LB_Connexion.TabIndex = 0
        Me.LB_Connexion.Text = "Connexion"
        '
        'TB_Identifiant
        '
        Me.TB_Identifiant.Location = New System.Drawing.Point(206, 185)
        Me.TB_Identifiant.Name = "TB_Identifiant"
        Me.TB_Identifiant.Size = New System.Drawing.Size(250, 20)
        Me.TB_Identifiant.TabIndex = 1
        '
        'TB_Motdepasse
        '
        Me.TB_Motdepasse.Location = New System.Drawing.Point(206, 256)
        Me.TB_Motdepasse.Name = "TB_Motdepasse"
        Me.TB_Motdepasse.Size = New System.Drawing.Size(250, 20)
        Me.TB_Motdepasse.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(84, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Identifiant :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(84, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mot de passe :"
        '
        'BT_Connexion
        '
        Me.BT_Connexion.Location = New System.Drawing.Point(292, 321)
        Me.BT_Connexion.Name = "BT_Connexion"
        Me.BT_Connexion.Size = New System.Drawing.Size(75, 23)
        Me.BT_Connexion.TabIndex = 5
        Me.BT_Connexion.Text = "Connexion"
        Me.BT_Connexion.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(203, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 6
        '
        'TB_Statut
        '
        Me.TB_Statut.BackColor = System.Drawing.SystemColors.Control
        Me.TB_Statut.Location = New System.Drawing.Point(365, 2)
        Me.TB_Statut.Multiline = True
        Me.TB_Statut.Name = "TB_Statut"
        Me.TB_Statut.Size = New System.Drawing.Size(272, 71)
        Me.TB_Statut.TabIndex = 9
        '
        'LB_message
        '
        Me.LB_message.AutoSize = True
        Me.LB_message.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LB_message.ForeColor = System.Drawing.Color.Red
        Me.LB_message.Location = New System.Drawing.Point(201, 365)
        Me.LB_message.Name = "LB_message"
        Me.LB_message.Size = New System.Drawing.Size(0, 25)
        Me.LB_message.TabIndex = 10
        Me.LB_message.Tag = ""
        '
        'ecranConnexion
        '
        Me.AcceptButton = Me.BT_Connexion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 446)
        Me.Controls.Add(Me.LB_message)
        Me.Controls.Add(Me.TB_Statut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BT_Connexion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Motdepasse)
        Me.Controls.Add(Me.TB_Identifiant)
        Me.Controls.Add(Me.LB_Connexion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(55, 55)
        Me.Name = "ecranConnexion"
        Me.Text = "SDIS29 Feuille de garde - Connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LB_Connexion As System.Windows.Forms.Label
    Friend WithEvents TB_Identifiant As System.Windows.Forms.TextBox
    Friend WithEvents TB_Motdepasse As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BT_Connexion As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LB_message As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents TB_Statut As System.Windows.Forms.TextBox

End Class
