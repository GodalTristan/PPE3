<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF4_Rapports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PF4_Rapports))
        Me.dtePickerInterv = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtePickerRetour = New System.Windows.Forms.DateTimePicker()
        Me.dtePickerDepart = New System.Windows.Forms.DateTimePicker()
        Me.txtCentre = New System.Windows.Forms.TextBox()
        Me.txtTypeEngin = New System.Windows.Forms.TextBox()
        Me.txtEngin = New System.Windows.Forms.TextBox()
        Me.panSP = New System.Windows.Forms.GroupBox()
        Me.txtSP6 = New System.Windows.Forms.TextBox()
        Me.txtSP4 = New System.Windows.Forms.TextBox()
        Me.txtSP2 = New System.Windows.Forms.TextBox()
        Me.txtSP5 = New System.Windows.Forms.TextBox()
        Me.txtSP3 = New System.Windows.Forms.TextBox()
        Me.txtSP1 = New System.Windows.Forms.TextBox()
        Me.lblSP6 = New System.Windows.Forms.Label()
        Me.lblSP4 = New System.Windows.Forms.Label()
        Me.lblSP2 = New System.Windows.Forms.Label()
        Me.lblSP5 = New System.Windows.Forms.Label()
        Me.lblSP3 = New System.Windows.Forms.Label()
        Me.lblSP1 = New System.Windows.Forms.Label()
        Me.txtCommRapport = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNombreKilometres = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDepart = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtIdIntervention = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCommentaireInterv = New System.Windows.Forms.TextBox()
        Me.txtSinistre = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.panSP.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtePickerInterv
        '
        Me.dtePickerInterv.Enabled = False
        Me.dtePickerInterv.Location = New System.Drawing.Point(212, 11)
        Me.dtePickerInterv.Name = "dtePickerInterv"
        Me.dtePickerInterv.Size = New System.Drawing.Size(172, 20)
        Me.dtePickerInterv.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtePickerRetour)
        Me.GroupBox1.Controls.Add(Me.dtePickerDepart)
        Me.GroupBox1.Controls.Add(Me.txtCentre)
        Me.GroupBox1.Controls.Add(Me.txtTypeEngin)
        Me.GroupBox1.Controls.Add(Me.txtEngin)
        Me.GroupBox1.Controls.Add(Me.panSP)
        Me.GroupBox1.Controls.Add(Me.txtCommRapport)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNombreKilometres)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDepart)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 308)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Départ"
        '
        'dtePickerRetour
        '
        Me.dtePickerRetour.Enabled = False
        Me.dtePickerRetour.Location = New System.Drawing.Point(305, 210)
        Me.dtePickerRetour.Name = "dtePickerRetour"
        Me.dtePickerRetour.Size = New System.Drawing.Size(159, 20)
        Me.dtePickerRetour.TabIndex = 28
        '
        'dtePickerDepart
        '
        Me.dtePickerDepart.Enabled = False
        Me.dtePickerDepart.Location = New System.Drawing.Point(73, 210)
        Me.dtePickerDepart.Name = "dtePickerDepart"
        Me.dtePickerDepart.Size = New System.Drawing.Size(158, 20)
        Me.dtePickerDepart.TabIndex = 27
        '
        'txtCentre
        '
        Me.txtCentre.Enabled = False
        Me.txtCentre.Location = New System.Drawing.Point(518, 57)
        Me.txtCentre.Name = "txtCentre"
        Me.txtCentre.Size = New System.Drawing.Size(134, 20)
        Me.txtCentre.TabIndex = 24
        '
        'txtTypeEngin
        '
        Me.txtTypeEngin.Enabled = False
        Me.txtTypeEngin.Location = New System.Drawing.Point(332, 57)
        Me.txtTypeEngin.Name = "txtTypeEngin"
        Me.txtTypeEngin.Size = New System.Drawing.Size(132, 20)
        Me.txtTypeEngin.TabIndex = 23
        '
        'txtEngin
        '
        Me.txtEngin.Enabled = False
        Me.txtEngin.Location = New System.Drawing.Point(59, 57)
        Me.txtEngin.Name = "txtEngin"
        Me.txtEngin.Size = New System.Drawing.Size(150, 20)
        Me.txtEngin.TabIndex = 22
        '
        'panSP
        '
        Me.panSP.Controls.Add(Me.txtSP6)
        Me.panSP.Controls.Add(Me.txtSP4)
        Me.panSP.Controls.Add(Me.txtSP2)
        Me.panSP.Controls.Add(Me.txtSP5)
        Me.panSP.Controls.Add(Me.txtSP3)
        Me.panSP.Controls.Add(Me.txtSP1)
        Me.panSP.Controls.Add(Me.lblSP6)
        Me.panSP.Controls.Add(Me.lblSP4)
        Me.panSP.Controls.Add(Me.lblSP2)
        Me.panSP.Controls.Add(Me.lblSP5)
        Me.panSP.Controls.Add(Me.lblSP3)
        Me.panSP.Controls.Add(Me.lblSP1)
        Me.panSP.Location = New System.Drawing.Point(95, 83)
        Me.panSP.Name = "panSP"
        Me.panSP.Size = New System.Drawing.Size(384, 121)
        Me.panSP.TabIndex = 16
        Me.panSP.TabStop = False
        Me.panSP.Text = "Composition de l'engin"
        '
        'txtSP6
        '
        Me.txtSP6.Enabled = False
        Me.txtSP6.Location = New System.Drawing.Point(256, 88)
        Me.txtSP6.Name = "txtSP6"
        Me.txtSP6.Size = New System.Drawing.Size(100, 20)
        Me.txtSP6.TabIndex = 14
        '
        'txtSP4
        '
        Me.txtSP4.Enabled = False
        Me.txtSP4.Location = New System.Drawing.Point(256, 56)
        Me.txtSP4.Name = "txtSP4"
        Me.txtSP4.Size = New System.Drawing.Size(100, 20)
        Me.txtSP4.TabIndex = 13
        '
        'txtSP2
        '
        Me.txtSP2.Enabled = False
        Me.txtSP2.Location = New System.Drawing.Point(256, 24)
        Me.txtSP2.Name = "txtSP2"
        Me.txtSP2.Size = New System.Drawing.Size(100, 20)
        Me.txtSP2.TabIndex = 12
        '
        'txtSP5
        '
        Me.txtSP5.Enabled = False
        Me.txtSP5.Location = New System.Drawing.Point(78, 88)
        Me.txtSP5.Name = "txtSP5"
        Me.txtSP5.Size = New System.Drawing.Size(100, 20)
        Me.txtSP5.TabIndex = 10
        '
        'txtSP3
        '
        Me.txtSP3.Enabled = False
        Me.txtSP3.Location = New System.Drawing.Point(78, 56)
        Me.txtSP3.Name = "txtSP3"
        Me.txtSP3.Size = New System.Drawing.Size(100, 20)
        Me.txtSP3.TabIndex = 9
        '
        'txtSP1
        '
        Me.txtSP1.Enabled = False
        Me.txtSP1.Location = New System.Drawing.Point(78, 24)
        Me.txtSP1.Name = "txtSP1"
        Me.txtSP1.Size = New System.Drawing.Size(100, 20)
        Me.txtSP1.TabIndex = 8
        '
        'lblSP6
        '
        Me.lblSP6.AutoSize = True
        Me.lblSP6.Location = New System.Drawing.Point(188, 91)
        Me.lblSP6.Name = "lblSP6"
        Me.lblSP6.Size = New System.Drawing.Size(54, 13)
        Me.lblSP6.TabIndex = 6
        Me.lblSP6.Text = "Membre 6"
        '
        'lblSP4
        '
        Me.lblSP4.AutoSize = True
        Me.lblSP4.Location = New System.Drawing.Point(188, 59)
        Me.lblSP4.Name = "lblSP4"
        Me.lblSP4.Size = New System.Drawing.Size(54, 13)
        Me.lblSP4.TabIndex = 5
        Me.lblSP4.Text = "Membre 4"
        '
        'lblSP2
        '
        Me.lblSP2.AutoSize = True
        Me.lblSP2.Location = New System.Drawing.Point(188, 27)
        Me.lblSP2.Name = "lblSP2"
        Me.lblSP2.Size = New System.Drawing.Size(54, 13)
        Me.lblSP2.TabIndex = 4
        Me.lblSP2.Text = "Membre 2"
        '
        'lblSP5
        '
        Me.lblSP5.AutoSize = True
        Me.lblSP5.Location = New System.Drawing.Point(10, 91)
        Me.lblSP5.Name = "lblSP5"
        Me.lblSP5.Size = New System.Drawing.Size(54, 13)
        Me.lblSP5.TabIndex = 2
        Me.lblSP5.Text = "Membre 5"
        '
        'lblSP3
        '
        Me.lblSP3.AutoSize = True
        Me.lblSP3.Location = New System.Drawing.Point(10, 59)
        Me.lblSP3.Name = "lblSP3"
        Me.lblSP3.Size = New System.Drawing.Size(54, 13)
        Me.lblSP3.TabIndex = 1
        Me.lblSP3.Text = "Membre 3"
        '
        'lblSP1
        '
        Me.lblSP1.AutoSize = True
        Me.lblSP1.Location = New System.Drawing.Point(10, 27)
        Me.lblSP1.Name = "lblSP1"
        Me.lblSP1.Size = New System.Drawing.Size(54, 13)
        Me.lblSP1.TabIndex = 0
        Me.lblSP1.Text = "Membre 1"
        '
        'txtCommRapport
        '
        Me.txtCommRapport.Location = New System.Drawing.Point(95, 242)
        Me.txtCommRapport.Multiline = True
        Me.txtCommRapport.Name = "txtCommRapport"
        Me.txtCommRapport.Size = New System.Drawing.Size(523, 45)
        Me.txtCommRapport.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Commentaire"
        '
        'txtNombreKilometres
        '
        Me.txtNombreKilometres.Location = New System.Drawing.Point(561, 210)
        Me.txtNombreKilometres.Name = "txtNombreKilometres"
        Me.txtNombreKilometres.Size = New System.Drawing.Size(57, 20)
        Me.txtNombreKilometres.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(19, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Départ N°"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(480, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nb kilometres"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(255, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Retour le"
        '
        'txtDepart
        '
        Me.txtDepart.Enabled = False
        Me.txtDepart.Location = New System.Drawing.Point(95, 23)
        Me.txtDepart.Name = "txtDepart"
        Me.txtDepart.Size = New System.Drawing.Size(150, 20)
        Me.txtDepart.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(19, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Engin"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(265, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Type Engin"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(480, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Centre"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 213)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Départ le"
        '
        'txtIdIntervention
        '
        Me.txtIdIntervention.Enabled = False
        Me.txtIdIntervention.Location = New System.Drawing.Point(82, 11)
        Me.txtIdIntervention.Name = "txtIdIntervention"
        Me.txtIdIntervention.Size = New System.Drawing.Size(100, 20)
        Me.txtIdIntervention.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 64)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Commentaire"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(400, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "Sinistre"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(185, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "Du"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(78, 13)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Intervention N°"
        '
        'txtCommentaireInterv
        '
        Me.txtCommentaireInterv.Enabled = False
        Me.txtCommentaireInterv.Location = New System.Drawing.Point(104, 64)
        Me.txtCommentaireInterv.Multiline = True
        Me.txtCommentaireInterv.Name = "txtCommentaireInterv"
        Me.txtCommentaireInterv.Size = New System.Drawing.Size(520, 46)
        Me.txtCommentaireInterv.TabIndex = 28
        '
        'txtSinistre
        '
        Me.txtSinistre.Enabled = False
        Me.txtSinistre.Location = New System.Drawing.Point(447, 11)
        Me.txtSinistre.Name = "txtSinistre"
        Me.txtSinistre.Size = New System.Drawing.Size(177, 20)
        Me.txtSinistre.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(586, 447)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Valider"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 447)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Se deconnecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PF4_Rapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 481)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtePickerInterv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIdIntervention)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtCommentaireInterv)
        Me.Controls.Add(Me.txtSinistre)
        Me.Controls.Add(Me.Button3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PF4_Rapports"
        Me.Text = "Rapport d'intervention"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.panSP.ResumeLayout(False)
        Me.panSP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtePickerInterv As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtePickerRetour As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtePickerDepart As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCentre As System.Windows.Forms.TextBox
    Friend WithEvents txtTypeEngin As System.Windows.Forms.TextBox
    Friend WithEvents txtEngin As System.Windows.Forms.TextBox
    Friend WithEvents panSP As System.Windows.Forms.GroupBox
    Friend WithEvents txtSP6 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP5 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSP1 As System.Windows.Forms.TextBox
    Friend WithEvents lblSP6 As System.Windows.Forms.Label
    Friend WithEvents lblSP4 As System.Windows.Forms.Label
    Friend WithEvents lblSP2 As System.Windows.Forms.Label
    Friend WithEvents lblSP5 As System.Windows.Forms.Label
    Friend WithEvents lblSP3 As System.Windows.Forms.Label
    Friend WithEvents lblSP1 As System.Windows.Forms.Label
    Friend WithEvents txtCommRapport As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNombreKilometres As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDepart As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtIdIntervention As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCommentaireInterv As System.Windows.Forms.TextBox
    Friend WithEvents txtSinistre As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
