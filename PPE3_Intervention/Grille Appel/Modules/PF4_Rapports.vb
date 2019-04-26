Public Class PF4_Rapports

    Dim OracleUtils As Connexion
    Dim queryIntervention As String
    Dim queryDepart As String
    Dim queryRapport As String
    Dim querySequence As String
    Dim idIntervention As Integer
    Dim spMatricule As Integer

    Dim equQuery As String
    Dim caQuery As String
    Dim condQuery As String
    Dim ce1Query As String
    Dim ce2Query As String
    Dim equ2Query As String
    Dim vehiculeType As String
    Dim enginID As Integer


    'RAPPORT
    Dim finalQuery As String
    Dim queryMode As String
    Dim idRapport As Integer

    'Paramètres de classe
    Public Sub New()

        InitializeComponent()

        idIntervention = Nothing
    End Sub

    Public Sub New(ByVal _idIntervention As String, ByVal _spMatricule As String)
        InitializeComponent()

        idIntervention = _idIntervention
        spMatricule = _spMatricule
    End Sub


    Public Property Intervention() As String
        Get
            Return Me.idIntervention
        End Get
        Set(ByVal Value As String)
            Me.idIntervention = Value
        End Set
    End Property

    Public Property Matricule() As String
        Get
            Return Me.spMatricule
        End Get
        Set(ByVal Value As String)
            Me.spMatricule = Value
        End Set
    End Property



    Private Sub PF4_Creer_Rapport_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        OracleUtils = New Connexion("SDIS29_PPE3", "SDIS29", "Iroise29")

        'GESTION Côté INTERVENTION

        txtIdIntervention.Text = idIntervention

        Dim resultIntervention As DataTable
        queryIntervention = "SELECT INTERV_DTE, INTERV_COMMENTAIRE, SIN_NATURE FROM INTERVENTION, SINISTRE WHERE INTERVENTION.INTERV_SIN_ID=SINISTRE.SIN_ID AND INTERV_ID=" & idIntervention
        resultIntervention = OracleUtils.Table(queryIntervention)

        dtePickerInterv.Text = resultIntervention.Rows(0)("INTERV_DTE")
        txtSinistre.Text = resultIntervention.Rows(0)("SIN_NATURE")

        If (resultIntervention.Rows(0)("INTERV_COMMENTAIRE") Is DBNull.Value) Then
            txtCommentaireInterv.Text = "Aucun commentaire"
        Else
            txtCommentaireInterv.Text = resultIntervention.Rows(0)("INTERV_COMMENTAIRE")
        End If

        'GESTION Côté DEPART
        Dim resultDepart As DataTable
        queryDepart = "SELECT a.DEP_ID, DEP_DTE_DEPART, b.ENGIN_ID, TYPE_ENG_PLACES, DEP_DTE_RETOUR, ENGIN_NOM, TYPE_ENG_NOM, CIS_NOM FROM DEPART a, ENGIN b, TYPE_ENGIN c, PARTICIPE d, CASERNE e WHERE a.ENGIN_ID=b.ENGIN_ID AND d.DEP_ID=a.DEP_ID AND b.CIS_ID=e.CIS_ID AND b.TYPE_ENG_ID = c.TYPE_ENG_ID AND d.SP_MATRICULE=" & spMatricule & " AND a.INTERV_ID=" & idIntervention
        resultDepart = OracleUtils.Table(queryDepart)

        txtDepart.Text = resultDepart.Rows(0)("DEP_ID")
        dtePickerDepart.Text = resultDepart.Rows(0)("DEP_DTE_DEPART")
        dtePickerRetour.Text = resultDepart.Rows(0)("DEP_DTE_RETOUR")
        txtEngin.Text = resultDepart.Rows(0)("ENGIN_NOM")
        txtTypeEngin.Text = resultDepart.Rows(0)("TYPE_ENG_NOM")
        txtCentre.Text = resultDepart.Rows(0)("CIS_NOM")
        vehiculeType = resultDepart.Rows(0)("TYPE_ENG_NOM")
        enginID = resultDepart.Rows(0)("ENGIN_ID")

        Me.ajustIHM(resultDepart.Rows(0)("TYPE_ENG_PLACES"))
        'GESTION Côté RAPPORT
        Dim resultRapport As DataTable
        queryRapport = "SELECT ID_RAPPORT, NB_KM, RAPPORT_COMMENTAIRE FROM RAPPORT_INTERVENTION WHERE INTERV_ID=" & idIntervention & " AND SP_MATRICULE=" & spMatricule
        resultRapport = OracleUtils.Table(queryRapport)

        'SEQUENCE ID RAPPORT
        Dim resultSequence As DataTable
        querySequence = "SELECT MAX(ID_RAPPORT) FROM RAPPORT_INTERVENTION"
        resultSequence = OracleUtils.Table(querySequence)

        If resultSequence.Rows.Count < 1 Or resultSequence.Rows(0)("MAX(ID_RAPPORT)") Is DBNull.Value Then
            idRapport = 0
        Else
            idRapport = resultSequence.Rows(0)("MAX(ID_RAPPORT)") + 1
        End If

        If resultRapport.Rows.Count < 1 Then
            queryMode = "INSERT"
        Else
            If resultRapport.Rows(0)("NB_KM") Is DBNull.Value Then
                txtNombreKilometres.Text = 0
            Else
                txtNombreKilometres.Text = resultRapport.Rows(0)("NB_KM")
            End If

            If resultRapport.Rows(0)("RAPPORT_COMMENTAIRE") Is DBNull.Value Then
                txtCommRapport.Text = "Aucun commentaire"
            Else
                txtCommRapport.Text = resultRapport.Rows(0)("RAPPORT_COMMENTAIRE")
            End If
            queryMode = "UPDATE"
        End If


    End Sub

    'Ajuste l'IHM en fonction du nombre de places dans l'engin
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

                'Récupération des noms des SP engagés dans le véhicule


                lblSP1.Text = "CA " & vehiculeType
                lblSP2.Text = "COND " & vehiculeType


        End Select

        Return 0

    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If queryMode = "INSERT" Then
            finalQuery = "INSERT INTO RAPPORT_INTERVENTION VALUES (" & idRapport & "," & idIntervention & ",'" & txtCommRapport.Text & "','" & txtNombreKilometres.Text & "','" & spMatricule & "')"
        End If

        If queryMode = "UPDATE" Then
            finalQuery = "UPDATE RAPPORT_INTERVENTION SET NB_KM='" & txtNombreKilometres.Text & "', RAPPORT_COMMENTAIRE='" & txtCommRapport.Text & "' WHERE INTERV_ID=" & idIntervention & " AND SP_MATRICULE='" & spMatricule & "'"
        End If

        OracleUtils.Execute(finalQuery)

        Me.Hide()

        Dim ListingRapport As New PF2_Listing_Rapport(spMatricule)
        ListingRapport.Show()



        MsgBox("Rapport enregistré.")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim connect As New ecranConnexion
        connect.Show()
    End Sub
End Class