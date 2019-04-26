Public Class PF3_Intervention

    Dim OracleUtils As Connexion
    Dim idIntervention As String
    Dim sdisQuery As String
    Dim equQuery As String
    Dim caQuery As String
    Dim condQuery As String
    Dim ce1Query As String
    Dim ce2Query As String
    Dim equ2Query As String
    Dim sdisQueryEtat As String
    Dim enginID As Integer
    Dim googleMapsInterventionLink As String

    Dim vehiculeType As String
    Dim vehiculeNom As String
    Dim vehiculeCS As String

    'Adresse Postale
    Dim adresse As String
    Dim ville As String

    Public Sub New()

        InitializeComponent()

        idIntervention = Nothing
    End Sub

    Public Sub New(ByVal _idIntervention As String, ByVal _title As String)
        InitializeComponent()

        idIntervention = _idIntervention
        labelInterName.Text = _title
    End Sub


    Public Property Intervention() As String
        Get
            Return Me.idIntervention
        End Get
        Set(ByVal Value As String)
            Me.idIntervention = Value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return Me.labelInterName.Text
        End Get
        Set(ByVal Value As String)
            Me.labelInterName.Text = Value
        End Set
    End Property

    Private Sub INTERVENTION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblSP5.Hide()
        txtSP5.Hide()
        lblSP6.Hide()
        txtSP6.Hide()
        lblSP4.Hide()
        txtSP4.Hide()
        lblSP3.Hide()
        txtSP3.Hide()
        lblSP2.Hide()
        txtSP2.Hide()
        lblSP1.Hide()
        txtSP1.Hide()

        Try
            idIntervention = Integer.Parse(idIntervention)
        Catch ex As Exception
            MsgBox(ex)
        End Try

        'Connexion à la DB
        OracleUtils = New Connexion("SDIS29_PPE3", "SDIS29", "Iroise29")

        'Requête Véhicules
        Dim resultSelect As DataTable
        sdisQuery = "SELECT ENGIN_NOM || ' ' || CASERNE.CIS_NOM FROM ENGIN, DEPART, CASERNE, INTERVENTION WHERE DEPART.ENGIN_ID=ENGIN.ENGIN_ID AND INTERVENTION.INTERV_ID=DEPART.INTERV_ID AND ENGIN.CIS_ID=CASERNE.CIS_ID AND INTERVENTION.INTERV_ID=" & idIntervention
        resultSelect = OracleUtils.Table(sdisQuery)
        Dim resultVehicule = ""

        Dim listeVehicule As List(Of String)
        listeVehicule = New List(Of String)

        For Each resultSelectFinal As DataRow In resultSelect.Rows
            resultVehicule = resultSelectFinal.Item(0).ToString
            listeVehicule.Add(resultVehicule)
        Next

        comboBoxVehicule.DataSource = listeVehicule



        Dim resultAdress As DataTable
        Dim sdisAdress As String
        sdisAdress = "SELECT INTERV_NO || ' ' || INTERV_LIEU, CIS_NOM FROM INTERVENTION a, CASERNE b WHERE b.CIS_ID=a.INTERV_COMMUNE AND a.INTERV_ID=" & idIntervention
        resultAdress = OracleUtils.Table(sdisAdress)

        For Each resultSelectFinal As DataRow In resultAdress.Rows
            adresse = resultSelectFinal.Item(0).ToString
            ville = resultSelectFinal.Item(1).ToString
        Next



        'Google Maps
        googleMapsInterventionLink = "https://maps.googleapis.com/maps/api/staticmap?center=" & adresse & "," & ville & "&zoom=16&size=600x300&maptype=hybrid&markers=color:red|" & adresse & "," & ville & "&key=AIzaSyCjY3QJTwRk4hBp4oTLhfC-4i9_Q3BKamE"
        GoogleMaps.Navigate(googleMapsInterventionLink)

    End Sub

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click

        Dim result As Integer = MessageBox.Show("Êtes vous sûr(e) de vouloir mettre fin à l'intervention? Cette action est irréversible.", "Fin de l'intervention", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Me.Hide()
            Dim FinInterventionQuery As String
            FinInterventionQuery = "UPDATE INTERVENTION SET STATUT_INTERV='TERMINE' WHERE INTERV_ID=" & idIntervention
            OracleUtils.Execute(FinInterventionQuery)

            Dim SelectionIntervention As New PF3_SelectionIntervention
            SelectionIntervention.Show()
        End If






    End Sub

    Private Sub comboBoxVehicule_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboBoxVehicule.SelectedIndexChanged


        Dim valeurVehicule As String
        Dim RemoveChars As String = "0123456789"
        valeurVehicule = comboBoxVehicule.SelectedValue.ToString
        vehiculeNom = Split(valeurVehicule, " ")(0)
        vehiculeCS = valeurVehicule.Skip(vehiculeNom.Length + 1).ToArray

        Dim typeVehicule() As Char = valeurVehicule.ToCharArray()
        vehiculeType = ""
        For Each ch As Char In typeVehicule
            If Not RemoveChars.Contains(ch) Then
                vehiculeType &= ch
            End If
        Next

        vehiculeType = Split(vehiculeType, " ")(0)

        Dim resultSelectEtat As DataTable
        sdisQueryEtat = "SELECT ENGIN_ETAT, ENGIN_ID FROM ENGIN, CASERNE WHERE ENGIN.CIS_ID=CASERNE.CIS_ID AND ENGIN_NOM='" & vehiculeNom & "' AND CIS_NOM='" & vehiculeCS & "'"
        resultSelectEtat = OracleUtils.Table(sdisQueryEtat)
        txtStatut.Text = resultSelectEtat.Rows(0)("ENGIN_ETAT")
        enginID = resultSelectEtat.Rows(0)("ENGIN_ID")


        'Requête état véhicule
        Dim resultSelectType As DataTable
        Dim qSelPlaces As String = "SELECT TYPE_ENG_PLACES FROM TYPE_ENGIN WHERE TYPE_ENG_NOM = '" & vehiculeType & "';"
        resultSelectType = OracleUtils.Table(qSelPlaces)
        Me.ajustIHM(resultSelectType.Rows(0)("TYPE_ENG_PLACES"))


        'Fin requête état véhicule

        'Début gestion affichage personnel



    End Sub

    Private Sub btnModif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModif.Click
        Dim Statut As New PF3_Statut(vehiculeNom, vehiculeCS, labelInterName.Text, idIntervention)
        Statut.Show()
        Me.Hide()


    End Sub

    Function ajustIHM(ByVal unNbComp As Integer)

        Select Case unNbComp

            Case 6
                lblSP5.Show()
                txtSP5.Show()
                lblSP6.Show()
                txtSP6.Show()
                lblSP4.Show()
                txtSP4.Show()
                lblSP3.Show()
                txtSP3.Show()
                lblSP2.Show()
                txtSP2.Show()
                lblSP1.Show()
                txtSP1.Show()
                panSP.Size = New Point(215, 170)
                panInter.Size = New Point(582, 231)
                GoogleMaps.Size = New Point(582, 250)
                GoogleMaps.Location = New Point(37, 307)

                'Récupération des noms des SP engagés dans le véhicule
                Dim caFPT As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=7 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                caFPT = OracleUtils.Table(caQuery)

                Dim condFPT As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=13 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                condFPT = OracleUtils.Table(condQuery)

                Dim ce1FPT As DataTable
                ce1Query = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=19 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                ce1FPT = OracleUtils.Table(ce1Query)

                Dim ce2FPT As DataTable
                ce2Query = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=2 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ") AND ROWNUM=1 ORDER BY SP_NOM DESC"
                ce2FPT = OracleUtils.Table(ce2Query)

                Dim equ1FPT As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=2 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ") ORDER BY SP_NOM ASC"
                equ1FPT = OracleUtils.Table(equQuery)

                Dim equ2FPT As DataTable
                equ2Query = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=2 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ") AND ROWNUM=1 AND PARTICIPE.SP_MATRICULE <> " & ce2FPT.Rows(0)("SP_MATRICULE") & " AND PARTICIPE.SP_MATRICULE <> " & equ1FPT.Rows(0)("SP_MATRICULE")
                equ2FPT = OracleUtils.Table(equ2Query)


                lblSP1.Text = "CA " & vehiculeType
                txtSP1.Text = caFPT.Rows(0)("SP_NOM") & " " & caFPT.Rows(0)("SP_PRENOM")
                lblSP2.Text = "COND " & vehiculeType
                txtSP2.Text = condFPT.Rows(0)("SP_NOM") & " " & condFPT.Rows(0)("SP_PRENOM")
                lblSP3.Text = "CE1 " & vehiculeType
                txtSP3.Text = ce1FPT.Rows(0)("SP_NOM") & " " & ce1FPT.Rows(0)("SP_PRENOM")
                lblSP4.Text = "CE2 " & vehiculeType
                txtSP4.Text = ce2FPT.Rows(0)("SP_NOM") & " " & ce2FPT.Rows(0)("SP_PRENOM")
                lblSP6.Text = "EQU " & vehiculeType
                txtSP5.Text = equ1FPT.Rows(0)("SP_NOM") & " " & equ1FPT.Rows(0)("SP_PRENOM")
                lblSP5.Text = "EQU " & vehiculeType
                txtSP6.Text = equ2FPT.Rows(0)("SP_NOM") & " " & equ2FPT.Rows(0)("SP_PRENOM")


            Case 4
                lblSP5.Hide()
                txtSP5.Hide()
                lblSP6.Hide()
                txtSP6.Hide()

                lblSP4.Show()
                txtSP4.Show()
                lblSP3.Show()
                txtSP3.Show()
                lblSP2.Show()
                txtSP2.Show()
                lblSP1.Show()
                txtSP1.Show()
                panSP.Size = New Point(215, 119)
                panInter.Size = New Point(582, 171)
                GoogleMaps.Size = New Point(582, 310)
                GoogleMaps.Location = New Point(37, 241)

                'Récupération des noms des SP engagés dans le véhicule
                Dim caCCF As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=8 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                caCCF = OracleUtils.Table(caQuery)

                Dim condCCF As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=14 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                condCCF = OracleUtils.Table(condQuery)

                Dim ceCCF As DataTable
                ce1Query = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=18 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                ceCCF = OracleUtils.Table(ce1Query)

                Dim equCCF As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM, PARTICIPE.SP_MATRICULE FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=3 AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                equCCF = OracleUtils.Table(equQuery)






                lblSP1.Text = "CA " & vehiculeType
                txtSP1.Text = caCCF.Rows(0)("SP_NOM") & " " & caCCF.Rows(0)("SP_PRENOM")
                lblSP2.Text = "COND " & vehiculeType
                txtSP2.Text = condCCF.Rows(0)("SP_NOM") & " " & condCCF.Rows(0)("SP_PRENOM")
                lblSP3.Text = "CE1 " & vehiculeType
                txtSP3.Text = ceCCF.Rows(0)("SP_NOM") & " " & ceCCF.Rows(0)("SP_PRENOM")
                lblSP4.Text = "EQU " & vehiculeType
                txtSP4.Text = equCCF.Rows(0)("SP_NOM") & " " & equCCF.Rows(0)("SP_PRENOM")
            Case 3
                lblSP5.Hide()
                txtSP5.Hide()
                lblSP6.Hide()
                txtSP6.Hide()
                lblSP4.Hide()
                txtSP4.Hide()
                txtSP3.Show()
                lblSP3.Show()
                lblSP2.Show()
                txtSP2.Show()
                lblSP1.Show()
                txtSP1.Show()
                panSP.Size = New Point(215, 91)
                panInter.Size = New Point(582, 140)
                GoogleMaps.Size = New Point(582, 335)
                GoogleMaps.Location = New Point(37, 216)


                'Récupération des noms des SP engagés dans le véhicule

                Dim fonctionEQU As Integer
                Dim fonctionCOND As Integer
                Dim fonctionCA As Integer

                If vehiculeType = "VSAV" Then
                    fonctionEQU = 1
                    fonctionCOND = 10
                    fonctionCA = 4
                End If

                If vehiculeType = "VTU" Then
                    fonctionEQU = 17
                    fonctionCOND = 12
                    fonctionCA = 5
                End If

                Dim equVSAV As DataTable
                equQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionEQU & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                equVSAV = OracleUtils.Table(equQuery)

                Dim caVSAV As DataTable
                caQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionCA & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                caVSAV = OracleUtils.Table(caQuery)

                Dim condVSAV As DataTable
                condQuery = "SELECT SP_NOM, SP_PRENOM FROM POMPIER, PARTICIPE WHERE POMPIER.SP_MATRICULE=PARTICIPE.SP_MATRICULE AND FONCTION_OCCUPEE=" & fonctionCOND & " AND DEP_ID=(SELECT DEP_ID FROM DEPART WHERE INTERV_ID=" & idIntervention & " AND ENGIN_ID=" & enginID & ")"
                condVSAV = OracleUtils.Table(condQuery)

                'MAJ de l'IHM

                lblSP1.Text = "CA " & vehiculeType
                txtSP1.Text = condVSAV.Rows(0)("SP_NOM") & " " & condVSAV.Rows(0)("SP_PRENOM")
                lblSP2.Text = "COND " & vehiculeType
                txtSP2.Text = caVSAV.Rows(0)("SP_NOM") & " " & caVSAV.Rows(0)("SP_PRENOM")
                lblSP3.Text = "EQU " & vehiculeType
                txtSP3.Text = equVSAV.Rows(0)("SP_NOM") & " " & equVSAV.Rows(0)("SP_PRENOM")
            Case 2
                lblSP5.Hide()
                txtSP5.Hide()
                lblSP6.Hide()
                txtSP6.Hide()
                lblSP4.Hide()
                txtSP4.Hide()
                lblSP3.Hide()
                txtSP3.Hide()
                lblSP2.Show()
                txtSP2.Show()
                lblSP1.Show()
                txtSP1.Show()
                panSP.Size = New Point(215, 66)
                panInter.Size = New Point(582, 117)
                GoogleMaps.Size = New Point(582, 361)
                GoogleMaps.Location = New Point(37, 190)

                'Récupération des noms des SP engagés dans le véhicule


                lblSP1.Text = "CA " & vehiculeType
                lblSP2.Text = "COND " & vehiculeType


        End Select

        Return 0

    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        'Dim connect As New ecranConnexion
        'connect.Show()
    End Sub
End Class
