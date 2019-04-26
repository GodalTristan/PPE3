<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sinistreComboBox = New System.Windows.Forms.ComboBox()
        Me.sinistreTextBox2 = New System.Windows.Forms.TextBox()
        Me.sinistreTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SINISTREBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Grille_Appel.DataSet1()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LocaPreTextBox = New System.Windows.Forms.TextBox()
        Me.LocaAppTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LocalCheckBox = New System.Windows.Forms.CheckBox()
        Me.LocaBatTextBox = New System.Windows.Forms.TextBox()
        Me.LocaCodeTextBox = New System.Windows.Forms.TextBox()
        Me.LocaEtageTextBox = New System.Windows.Forms.TextBox()
        Me.LocaNoTextBox = New System.Windows.Forms.TextBox()
        Me.localisationComboBox = New System.Windows.Forms.ComboBox()
        Me.LocaLieuTextBox = New System.Windows.Forms.TextBox()
        Me.LocaComTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.COMMUNEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.NomTextBox = New System.Windows.Forms.TextBox()
        Me.PrenomTextBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DemPreTextBox = New System.Windows.Forms.TextBox()
        Me.DemPorteTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DemCheckBox = New System.Windows.Forms.CheckBox()
        Me.DemBatTextBox = New System.Windows.Forms.TextBox()
        Me.DemCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DemEtageTextBox = New System.Windows.Forms.TextBox()
        Me.DemNoTextBox = New System.Windows.Forms.TextBox()
        Me.DemComboBox = New System.Windows.Forms.ComboBox()
        Me.DemLieuTextBox = New System.Windows.Forms.TextBox()
        Me.DemComTextBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DepartListBox = New System.Windows.Forms.ListBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.SINISTRETableAdapter = New Grille_Appel.DataSet1TableAdapters.SINISTRETableAdapter()
        Me.COMMUNETableAdapter = New Grille_Appel.DataSet1TableAdapters.COMMUNETableAdapter()
        Me.Envoyer = New System.Windows.Forms.Button()
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.error1 = New System.Windows.Forms.Label()
        Me.error2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SINISTREBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.COMMUNEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sinistreComboBox)
        Me.GroupBox1.Controls.Add(Me.sinistreTextBox2)
        Me.GroupBox1.Controls.Add(Me.sinistreTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 107)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SINISTRE"
        '
        'sinistreComboBox
        '
        Me.sinistreComboBox.FormattingEnabled = True
        Me.sinistreComboBox.Location = New System.Drawing.Point(143, 22)
        Me.sinistreComboBox.Name = "sinistreComboBox"
        Me.sinistreComboBox.Size = New System.Drawing.Size(164, 21)
        Me.sinistreComboBox.TabIndex = 4
        '
        'sinistreTextBox2
        '
        Me.sinistreTextBox2.Location = New System.Drawing.Point(102, 51)
        Me.sinistreTextBox2.Multiline = True
        Me.sinistreTextBox2.Name = "sinistreTextBox2"
        Me.sinistreTextBox2.Size = New System.Drawing.Size(442, 50)
        Me.sinistreTextBox2.TabIndex = 3
        '
        'sinistreTextBox
        '
        Me.sinistreTextBox.Location = New System.Drawing.Point(102, 23)
        Me.sinistreTextBox.Name = "sinistreTextBox"
        Me.sinistreTextBox.ReadOnly = True
        Me.sinistreTextBox.Size = New System.Drawing.Size(23, 20)
        Me.sinistreTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Observations"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nature *"
        '
        'SINISTREBindingSource
        '
        Me.SINISTREBindingSource.DataMember = "SINISTRE"
        Me.SINISTREBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.LocaPreTextBox)
        Me.GroupBox2.Controls.Add(Me.LocaAppTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LocalCheckBox)
        Me.GroupBox2.Controls.Add(Me.LocaBatTextBox)
        Me.GroupBox2.Controls.Add(Me.LocaCodeTextBox)
        Me.GroupBox2.Controls.Add(Me.LocaEtageTextBox)
        Me.GroupBox2.Controls.Add(Me.LocaNoTextBox)
        Me.GroupBox2.Controls.Add(Me.localisationComboBox)
        Me.GroupBox2.Controls.Add(Me.LocaLieuTextBox)
        Me.GroupBox2.Controls.Add(Me.LocaComTextBox)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(550, 168)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "LOCALISATION"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Précisions"
        '
        'LocaPreTextBox
        '
        Me.LocaPreTextBox.Location = New System.Drawing.Point(102, 112)
        Me.LocaPreTextBox.Multiline = True
        Me.LocaPreTextBox.Name = "LocaPreTextBox"
        Me.LocaPreTextBox.Size = New System.Drawing.Size(442, 49)
        Me.LocaPreTextBox.TabIndex = 17
        '
        'LocaAppTextBox
        '
        Me.LocaAppTextBox.Location = New System.Drawing.Point(314, 77)
        Me.LocaAppTextBox.Name = "LocaAppTextBox"
        Me.LocaAppTextBox.Size = New System.Drawing.Size(35, 20)
        Me.LocaAppTextBox.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(103, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ext"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(164, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Etage"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "App/Porte"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Bat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(436, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Code accès"
        '
        'LocalCheckBox
        '
        Me.LocalCheckBox.AutoSize = True
        Me.LocalCheckBox.Location = New System.Drawing.Point(131, 79)
        Me.LocalCheckBox.Name = "LocalCheckBox"
        Me.LocalCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.LocalCheckBox.TabIndex = 9
        Me.LocalCheckBox.UseVisualStyleBackColor = True
        '
        'LocaBatTextBox
        '
        Me.LocaBatTextBox.Location = New System.Drawing.Point(384, 76)
        Me.LocaBatTextBox.Name = "LocaBatTextBox"
        Me.LocaBatTextBox.Size = New System.Drawing.Size(35, 20)
        Me.LocaBatTextBox.TabIndex = 8
        '
        'LocaCodeTextBox
        '
        Me.LocaCodeTextBox.Location = New System.Drawing.Point(506, 76)
        Me.LocaCodeTextBox.Name = "LocaCodeTextBox"
        Me.LocaCodeTextBox.Size = New System.Drawing.Size(38, 20)
        Me.LocaCodeTextBox.TabIndex = 7
        '
        'LocaEtageTextBox
        '
        Me.LocaEtageTextBox.Location = New System.Drawing.Point(205, 77)
        Me.LocaEtageTextBox.Name = "LocaEtageTextBox"
        Me.LocaEtageTextBox.Size = New System.Drawing.Size(36, 20)
        Me.LocaEtageTextBox.TabIndex = 6
        '
        'LocaNoTextBox
        '
        Me.LocaNoTextBox.Location = New System.Drawing.Point(73, 76)
        Me.LocaNoTextBox.Name = "LocaNoTextBox"
        Me.LocaNoTextBox.Size = New System.Drawing.Size(23, 20)
        Me.LocaNoTextBox.TabIndex = 5
        '
        'localisationComboBox
        '
        Me.localisationComboBox.FormattingEnabled = True
        Me.localisationComboBox.Location = New System.Drawing.Point(186, 22)
        Me.localisationComboBox.Name = "localisationComboBox"
        Me.localisationComboBox.Size = New System.Drawing.Size(121, 21)
        Me.localisationComboBox.TabIndex = 4
        '
        'LocaLieuTextBox
        '
        Me.LocaLieuTextBox.Location = New System.Drawing.Point(102, 51)
        Me.LocaLieuTextBox.Name = "LocaLieuTextBox"
        Me.LocaLieuTextBox.Size = New System.Drawing.Size(442, 20)
        Me.LocaLieuTextBox.TabIndex = 3
        '
        'LocaComTextBox
        '
        Me.LocaComTextBox.Location = New System.Drawing.Point(102, 23)
        Me.LocaComTextBox.Name = "LocaComTextBox"
        Me.LocaComTextBox.ReadOnly = True
        Me.LocaComTextBox.Size = New System.Drawing.Size(56, 20)
        Me.LocaComTextBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Lieu *"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Commune *"
        '
        'COMMUNEBindingSource
        '
        Me.COMMUNEBindingSource.DataMember = "COMMUNE"
        Me.COMMUNEBindingSource.DataSource = Me.DataSet1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TelTextBox)
        Me.GroupBox3.Controls.Add(Me.NomTextBox)
        Me.GroupBox3.Controls.Add(Me.PrenomTextBox)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.DemPreTextBox)
        Me.GroupBox3.Controls.Add(Me.DemPorteTextBox)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.DemCheckBox)
        Me.GroupBox3.Controls.Add(Me.DemBatTextBox)
        Me.GroupBox3.Controls.Add(Me.DemCodeTextBox)
        Me.GroupBox3.Controls.Add(Me.DemEtageTextBox)
        Me.GroupBox3.Controls.Add(Me.DemNoTextBox)
        Me.GroupBox3.Controls.Add(Me.DemComboBox)
        Me.GroupBox3.Controls.Add(Me.DemLieuTextBox)
        Me.GroupBox3.Controls.Add(Me.DemComTextBox)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 299)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(550, 212)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DEMANDEUR"
        '
        'TelTextBox
        '
        Me.TelTextBox.Location = New System.Drawing.Point(55, 19)
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(144, 20)
        Me.TelTextBox.TabIndex = 20
        '
        'NomTextBox
        '
        Me.NomTextBox.Location = New System.Drawing.Point(255, 19)
        Me.NomTextBox.Name = "NomTextBox"
        Me.NomTextBox.Size = New System.Drawing.Size(115, 20)
        Me.NomTextBox.TabIndex = 19
        '
        'PrenomTextBox
        '
        Me.PrenomTextBox.Location = New System.Drawing.Point(425, 19)
        Me.PrenomTextBox.Name = "PrenomTextBox"
        Me.PrenomTextBox.Size = New System.Drawing.Size(119, 20)
        Me.PrenomTextBox.TabIndex = 18
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(376, 22)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Prenom *"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(220, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(36, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Nom *"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(27, 22)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Tel *"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Précisions"
        '
        'DemPreTextBox
        '
        Me.DemPreTextBox.Location = New System.Drawing.Point(102, 154)
        Me.DemPreTextBox.Multiline = True
        Me.DemPreTextBox.Name = "DemPreTextBox"
        Me.DemPreTextBox.Size = New System.Drawing.Size(442, 49)
        Me.DemPreTextBox.TabIndex = 17
        '
        'DemPorteTextBox
        '
        Me.DemPorteTextBox.Location = New System.Drawing.Point(314, 119)
        Me.DemPorteTextBox.Name = "DemPorteTextBox"
        Me.DemPorteTextBox.Size = New System.Drawing.Size(35, 20)
        Me.DemPorteTextBox.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(45, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "No"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(103, 121)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(22, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Ext"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(164, 121)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Etage"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(252, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "App/Porte"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(355, 121)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Bat"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(436, 121)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Code accès"
        '
        'DemCheckBox
        '
        Me.DemCheckBox.AutoSize = True
        Me.DemCheckBox.Location = New System.Drawing.Point(131, 121)
        Me.DemCheckBox.Name = "DemCheckBox"
        Me.DemCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DemCheckBox.TabIndex = 9
        Me.DemCheckBox.UseVisualStyleBackColor = True
        '
        'DemBatTextBox
        '
        Me.DemBatTextBox.Location = New System.Drawing.Point(384, 118)
        Me.DemBatTextBox.Name = "DemBatTextBox"
        Me.DemBatTextBox.Size = New System.Drawing.Size(35, 20)
        Me.DemBatTextBox.TabIndex = 8
        '
        'DemCodeTextBox
        '
        Me.DemCodeTextBox.Location = New System.Drawing.Point(506, 118)
        Me.DemCodeTextBox.Name = "DemCodeTextBox"
        Me.DemCodeTextBox.Size = New System.Drawing.Size(38, 20)
        Me.DemCodeTextBox.TabIndex = 7
        '
        'DemEtageTextBox
        '
        Me.DemEtageTextBox.Location = New System.Drawing.Point(205, 119)
        Me.DemEtageTextBox.Name = "DemEtageTextBox"
        Me.DemEtageTextBox.Size = New System.Drawing.Size(36, 20)
        Me.DemEtageTextBox.TabIndex = 6
        '
        'DemNoTextBox
        '
        Me.DemNoTextBox.Location = New System.Drawing.Point(73, 118)
        Me.DemNoTextBox.Name = "DemNoTextBox"
        Me.DemNoTextBox.Size = New System.Drawing.Size(23, 20)
        Me.DemNoTextBox.TabIndex = 5
        '
        'DemComboBox
        '
        Me.DemComboBox.FormattingEnabled = True
        Me.DemComboBox.Location = New System.Drawing.Point(186, 64)
        Me.DemComboBox.Name = "DemComboBox"
        Me.DemComboBox.Size = New System.Drawing.Size(121, 21)
        Me.DemComboBox.TabIndex = 4
        '
        'DemLieuTextBox
        '
        Me.DemLieuTextBox.Location = New System.Drawing.Point(102, 93)
        Me.DemLieuTextBox.Name = "DemLieuTextBox"
        Me.DemLieuTextBox.Size = New System.Drawing.Size(442, 20)
        Me.DemLieuTextBox.TabIndex = 3
        '
        'DemComTextBox
        '
        Me.DemComTextBox.Location = New System.Drawing.Point(102, 65)
        Me.DemComTextBox.Name = "DemComTextBox"
        Me.DemComTextBox.ReadOnly = True
        Me.DemComTextBox.Size = New System.Drawing.Size(56, 20)
        Me.DemComTextBox.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(27, 96)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Lieu *"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(27, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Commune *"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DepartListBox)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 533)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(550, 107)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DEPART"
        '
        'DepartListBox
        '
        Me.DepartListBox.FormattingEnabled = True
        Me.DepartListBox.Location = New System.Drawing.Point(106, 30)
        Me.DepartListBox.Name = "DepartListBox"
        Me.DepartListBox.Size = New System.Drawing.Size(93, 69)
        Me.DepartListBox.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(27, 30)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(66, 13)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Depart Type"
        '
        'SINISTRETableAdapter
        '
        Me.SINISTRETableAdapter.ClearBeforeFill = True
        '
        'COMMUNETableAdapter
        '
        Me.COMMUNETableAdapter.ClearBeforeFill = True
        '
        'Envoyer
        '
        Me.Envoyer.Location = New System.Drawing.Point(451, 646)
        Me.Envoyer.Name = "Envoyer"
        Me.Envoyer.Size = New System.Drawing.Size(75, 23)
        Me.Envoyer.TabIndex = 19
        Me.Envoyer.Text = "Envoyer"
        Me.Envoyer.UseVisualStyleBackColor = True
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'error1
        '
        Me.error1.AutoSize = True
        Me.error1.Location = New System.Drawing.Point(92, 289)
        Me.error1.Name = "error1"
        Me.error1.Size = New System.Drawing.Size(45, 13)
        Me.error1.TabIndex = 18
        Me.error1.Text = "Label25"
        '
        'error2
        '
        Me.error2.AutoSize = True
        Me.error2.Location = New System.Drawing.Point(33, 514)
        Me.error2.Name = "error2"
        Me.error2.Size = New System.Drawing.Size(45, 13)
        Me.error2.TabIndex = 21
        Me.error2.Text = "Label26"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 681)
        Me.Controls.Add(Me.error1)
        Me.Controls.Add(Me.error2)
        Me.Controls.Add(Me.Envoyer)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.SINISTREBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.COMMUNEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sinistreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents sinistreTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents sinistreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents LocalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LocaBatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocaCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocaEtageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocaNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents localisationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LocaLieuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocaComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LocaPreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LocaAppTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrenomTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DemPreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DemPorteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DemCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents DemBatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DemCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DemEtageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DemNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DemComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DemLieuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DemComTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents DataSet1 As Grille_Appel.DataSet1
    Friend WithEvents SINISTREBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SINISTRETableAdapter As Grille_Appel.DataSet1TableAdapters.SINISTRETableAdapter
    Friend WithEvents COMMUNEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMMUNETableAdapter As Grille_Appel.DataSet1TableAdapters.COMMUNETableAdapter
    Friend WithEvents DepartListBox As System.Windows.Forms.ListBox
    Friend WithEvents Envoyer As System.Windows.Forms.Button
    Friend WithEvents DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents error1 As System.Windows.Forms.Label
    Friend WithEvents error2 As System.Windows.Forms.Label

End Class
