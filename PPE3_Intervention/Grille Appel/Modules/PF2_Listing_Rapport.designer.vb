<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PF2_Listing_Rapport
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
        Me.btnselect = New System.Windows.Forms.Button()
        Me.LabelSélection = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.INTERVENTIONBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.INTERVENTIONBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.INTERVENTIONBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INTERVENTIONBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnselect
        '
        Me.btnselect.Location = New System.Drawing.Point(384, 226)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(132, 42)
        Me.btnselect.TabIndex = 0
        Me.btnselect.Text = "Sélectionner"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'LabelSélection
        '
        Me.LabelSélection.AutoSize = True
        Me.LabelSélection.Location = New System.Drawing.Point(31, 46)
        Me.LabelSélection.Name = "LabelSélection"
        Me.LabelSélection.Size = New System.Drawing.Size(211, 13)
        Me.LabelSélection.TabIndex = 1
        Me.LabelSélection.Text = "Veuillez sélectionner le rapport à consulter :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(753, 333)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(25, 36)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(669, 175)
        '
        'ListView1
        '
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(34, 80)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(522, 111)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(644, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Se deconnecter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PF2_Listing_Rapport
        '
        Me.AcceptButton = Me.btnselect
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 333)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.LabelSélection)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "PF2_Listing_Rapport"
        Me.Text = "Consulter les rapports"
        CType(Me.INTERVENTIONBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INTERVENTIONBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents LabelSélection As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents INTERVENTIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INTERVENTIONBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents INTERVENTIONBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents INTERVENTIONBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
