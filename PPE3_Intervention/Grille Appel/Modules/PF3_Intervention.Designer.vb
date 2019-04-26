<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF3_Intervention
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PF3_Intervention))
        Me.GoogleMaps = New System.Windows.Forms.WebBrowser()
        Me.panInter = New System.Windows.Forms.Panel()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.txtStatut = New System.Windows.Forms.TextBox()
        Me.labelStatut = New System.Windows.Forms.Label()
        Me.panSP = New System.Windows.Forms.Panel()
        Me.lblSP6 = New System.Windows.Forms.Label()
        Me.lblSP5 = New System.Windows.Forms.Label()
        Me.lblSP4 = New System.Windows.Forms.Label()
        Me.txtSP6 = New System.Windows.Forms.TextBox()
        Me.txtSP5 = New System.Windows.Forms.TextBox()
        Me.txtSP4 = New System.Windows.Forms.TextBox()
        Me.txtSP3 = New System.Windows.Forms.TextBox()
        Me.txtSP2 = New System.Windows.Forms.TextBox()
        Me.txtSP1 = New System.Windows.Forms.TextBox()
        Me.lblSP3 = New System.Windows.Forms.Label()
        Me.lblSP2 = New System.Windows.Forms.Label()
        Me.lblSP1 = New System.Windows.Forms.Label()
        Me.comboBoxVehicule = New System.Windows.Forms.ComboBox()
        Me.labelVehicule = New System.Windows.Forms.Label()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.labelInterName = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.panInter.SuspendLayout()
        Me.panSP.SuspendLayout()
        Me.SuspendLayout()
        '
        'GoogleMaps
        '
        Me.GoogleMaps.Location = New System.Drawing.Point(37, 307)
        Me.GoogleMaps.MinimumSize = New System.Drawing.Size(20, 20)
        Me.GoogleMaps.Name = "GoogleMaps"
        Me.GoogleMaps.Size = New System.Drawing.Size(582, 250)
        Me.GoogleMaps.TabIndex = 6
        '
        'panInter
        '
        Me.panInter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panInter.Controls.Add(Me.btnModif)
        Me.panInter.Controls.Add(Me.txtStatut)
        Me.panInter.Controls.Add(Me.labelStatut)
        Me.panInter.Controls.Add(Me.panSP)
        Me.panInter.Controls.Add(Me.comboBoxVehicule)
        Me.panInter.Controls.Add(Me.labelVehicule)
        Me.panInter.Location = New System.Drawing.Point(37, 70)
        Me.panInter.Name = "panInter"
        Me.panInter.Size = New System.Drawing.Size(582, 231)
        Me.panInter.TabIndex = 5
        '
        'btnModif
        '
        Me.btnModif.Location = New System.Drawing.Point(416, 47)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(88, 22)
        Me.btnModif.TabIndex = 5
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'txtStatut
        '
        Me.txtStatut.Location = New System.Drawing.Point(377, 15)
        Me.txtStatut.Name = "txtStatut"
        Me.txtStatut.ReadOnly = True
        Me.txtStatut.Size = New System.Drawing.Size(127, 20)
        Me.txtStatut.TabIndex = 4
        '
        'labelStatut
        '
        Me.labelStatut.AutoSize = True
        Me.labelStatut.Location = New System.Drawing.Point(321, 16)
        Me.labelStatut.Name = "labelStatut"
        Me.labelStatut.Size = New System.Drawing.Size(41, 13)
        Me.labelStatut.TabIndex = 3
        Me.labelStatut.Text = "Statut :"
        '
        'panSP
        '
        Me.panSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panSP.Controls.Add(Me.lblSP6)
        Me.panSP.Controls.Add(Me.lblSP5)
        Me.panSP.Controls.Add(Me.lblSP4)
        Me.panSP.Controls.Add(Me.txtSP6)
        Me.panSP.Controls.Add(Me.txtSP5)
        Me.panSP.Controls.Add(Me.txtSP4)
        Me.panSP.Controls.Add(Me.txtSP3)
        Me.panSP.Controls.Add(Me.txtSP2)
        Me.panSP.Controls.Add(Me.txtSP1)
        Me.panSP.Controls.Add(Me.lblSP3)
        Me.panSP.Controls.Add(Me.lblSP2)
        Me.panSP.Controls.Add(Me.lblSP1)
        Me.panSP.Location = New System.Drawing.Point(17, 42)
        Me.panSP.Name = "panSP"
        Me.panSP.Size = New System.Drawing.Size(215, 170)
        Me.panSP.TabIndex = 2
        '
        'lblSP6
        '
        Me.lblSP6.AutoSize = True
        Me.lblSP6.Location = New System.Drawing.Point(12, 117)
        Me.lblSP6.Name = "lblSP6"
        Me.lblSP6.Size = New System.Drawing.Size(68, 13)
        Me.lblSP6.TabIndex = 11
        Me.lblSP6.Text = "Equipier BAL"
        '
        'lblSP5
        '
        Me.lblSP5.AutoSize = True
        Me.lblSP5.Location = New System.Drawing.Point(12, 143)
        Me.lblSP5.Name = "lblSP5"
        Me.lblSP5.Size = New System.Drawing.Size(52, 13)
        Me.lblSP5.TabIndex = 10
        Me.lblSP5.Text = "Chef BAL"
        '
        'lblSP4
        '
        Me.lblSP4.AutoSize = True
        Me.lblSP4.Location = New System.Drawing.Point(12, 92)
        Me.lblSP4.Name = "lblSP4"
        Me.lblSP4.Size = New System.Drawing.Size(53, 13)
        Me.lblSP4.TabIndex = 9
        Me.lblSP4.Text = "Chef BAT"
        '
        'txtSP6
        '
        Me.txtSP6.Location = New System.Drawing.Point(100, 140)
        Me.txtSP6.Name = "txtSP6"
        Me.txtSP6.ReadOnly = True
        Me.txtSP6.Size = New System.Drawing.Size(104, 20)
        Me.txtSP6.TabIndex = 8
        '
        'txtSP5
        '
        Me.txtSP5.Location = New System.Drawing.Point(100, 114)
        Me.txtSP5.Name = "txtSP5"
        Me.txtSP5.ReadOnly = True
        Me.txtSP5.Size = New System.Drawing.Size(104, 20)
        Me.txtSP5.TabIndex = 7
        '
        'txtSP4
        '
        Me.txtSP4.Location = New System.Drawing.Point(100, 89)
        Me.txtSP4.Name = "txtSP4"
        Me.txtSP4.ReadOnly = True
        Me.txtSP4.Size = New System.Drawing.Size(104, 20)
        Me.txtSP4.TabIndex = 6
        '
        'txtSP3
        '
        Me.txtSP3.Location = New System.Drawing.Point(100, 63)
        Me.txtSP3.Name = "txtSP3"
        Me.txtSP3.ReadOnly = True
        Me.txtSP3.Size = New System.Drawing.Size(104, 20)
        Me.txtSP3.TabIndex = 5
        '
        'txtSP2
        '
        Me.txtSP2.Location = New System.Drawing.Point(100, 37)
        Me.txtSP2.Name = "txtSP2"
        Me.txtSP2.ReadOnly = True
        Me.txtSP2.Size = New System.Drawing.Size(104, 20)
        Me.txtSP2.TabIndex = 4
        '
        'txtSP1
        '
        Me.txtSP1.Location = New System.Drawing.Point(100, 12)
        Me.txtSP1.Name = "txtSP1"
        Me.txtSP1.ReadOnly = True
        Me.txtSP1.Size = New System.Drawing.Size(104, 20)
        Me.txtSP1.TabIndex = 3
        '
        'lblSP3
        '
        Me.lblSP3.AutoSize = True
        Me.lblSP3.Location = New System.Drawing.Point(12, 66)
        Me.lblSP3.Name = "lblSP3"
        Me.lblSP3.Size = New System.Drawing.Size(45, 13)
        Me.lblSP3.TabIndex = 2
        Me.lblSP3.Text = "Equipier"
        '
        'lblSP2
        '
        Me.lblSP2.AutoSize = True
        Me.lblSP2.Location = New System.Drawing.Point(12, 40)
        Me.lblSP2.Name = "lblSP2"
        Me.lblSP2.Size = New System.Drawing.Size(62, 13)
        Me.lblSP2.TabIndex = 1
        Me.lblSP2.Text = "Conducteur"
        '
        'lblSP1
        '
        Me.lblSP1.AutoSize = True
        Me.lblSP1.Location = New System.Drawing.Point(12, 15)
        Me.lblSP1.Name = "lblSP1"
        Me.lblSP1.Size = New System.Drawing.Size(66, 13)
        Me.lblSP1.TabIndex = 0
        Me.lblSP1.Text = "Chef d'agrès"
        '
        'comboBoxVehicule
        '
        Me.comboBoxVehicule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxVehicule.FormattingEnabled = True
        Me.comboBoxVehicule.Location = New System.Drawing.Point(79, 14)
        Me.comboBoxVehicule.Name = "comboBoxVehicule"
        Me.comboBoxVehicule.Size = New System.Drawing.Size(154, 21)
        Me.comboBoxVehicule.TabIndex = 1
        '
        'labelVehicule
        '
        Me.labelVehicule.AutoSize = True
        Me.labelVehicule.Location = New System.Drawing.Point(14, 16)
        Me.labelVehicule.Name = "labelVehicule"
        Me.labelVehicule.Size = New System.Drawing.Size(54, 13)
        Me.labelVehicule.TabIndex = 0
        Me.labelVehicule.Text = "Véhicule :"
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(37, 564)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(179, 24)
        Me.btnEnd.TabIndex = 8
        Me.btnEnd.Text = "Fin de l'intervention"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'labelInterName
        '
        Me.labelInterName.AutoSize = True
        Me.labelInterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInterName.Location = New System.Drawing.Point(41, 33)
        Me.labelInterName.Name = "labelInterName"
        Me.labelInterName.Size = New System.Drawing.Size(0, 20)
        Me.labelInterName.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(9, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Se deconnecter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PF3_Intervention
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 614)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.labelInterName)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.GoogleMaps)
        Me.Controls.Add(Me.panInter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PF3_Intervention"
        Me.Text = "Intervention"
        Me.panInter.ResumeLayout(False)
        Me.panInter.PerformLayout()
        Me.panSP.ResumeLayout(False)
        Me.panSP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GoogleMaps As System.Windows.Forms.WebBrowser
    Friend WithEvents panInter As System.Windows.Forms.Panel
    Friend WithEvents btnModif As System.Windows.Forms.Button
    Friend WithEvents txtStatut As System.Windows.Forms.TextBox
    Friend WithEvents labelStatut As System.Windows.Forms.Label
    Friend WithEvents panSP As System.Windows.Forms.Panel
    Friend WithEvents txtSP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSP3 As System.Windows.Forms.Label
    Friend WithEvents lblSP2 As System.Windows.Forms.Label
    Friend WithEvents lblSP1 As System.Windows.Forms.Label
    Friend WithEvents comboBoxVehicule As System.Windows.Forms.ComboBox
    Friend WithEvents labelVehicule As System.Windows.Forms.Label
    Friend WithEvents btnEnd As System.Windows.Forms.Button
    Friend WithEvents labelInterName As System.Windows.Forms.Label
    Friend WithEvents lblSP6 As System.Windows.Forms.Label
    Friend WithEvents lblSP5 As System.Windows.Forms.Label
    Friend WithEvents lblSP4 As System.Windows.Forms.Label
    Friend WithEvents txtSP6 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP5 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP4 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
