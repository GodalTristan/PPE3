Public Class PF3_Statut

    Dim OracleUtils As Connexion
    Dim sdisQuery As String
    Dim sdisQueryEtat As String
    Dim valeurComboBox As String
    Dim interventionID As String
    Private _vehiculeNom As String
    Private _vehiculeCS As String
    Private _idIntervention As String
    Private _title As String

    Public Sub New(ByVal vehiculeNom As String, ByVal vehiculeCS As String, ByVal title As String, ByVal id_intervention As String)
        InitializeComponent()

        _vehiculeNom = vehiculeNom
        _vehiculeCS = vehiculeCS
        _title = title
        _idIntervention = id_intervention
    End Sub


    Public Property VehiculeNomGS() As String
        Get
            Return Me._vehiculeNom
        End Get
        Set(ByVal Value As String)
            Me._vehiculeNom = Value
        End Set
    End Property

    Public Property Intervention() As String
        Get
            Return Me._idIntervention
        End Get
        Set(ByVal Value As String)
            Me._idIntervention = Value
        End Set
    End Property

    Public Property VehiculeCsGS() As String
        Get
            Return Me._vehiculeCS
        End Get
        Set(ByVal Value As String)
            Me._vehiculeCS = Value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return Me._title
        End Get
        Set(ByVal Value As String)
            Me._title = Value
        End Set
    End Property


    Private Sub Statut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            interventionID = Integer.Parse(_idIntervention)
        Catch ex As Exception
            MsgBox(ex)
        End Try

        OracleUtils = New Connexion("SDIS29_PPE3", "SDIS29", "Iroise29")

        lblInterName.Text = _vehiculeNom & " " & _vehiculeCS


        Dim resultSelectEtat As DataTable
        sdisQueryEtat = "SELECT ENGIN_ETAT FROM ENGIN, CASERNE WHERE ENGIN.CIS_ID=CASERNE.CIS_ID AND ENGIN_NOM='" & _vehiculeNom & "' AND CIS_NOM='" & _vehiculeCS & "'"
        resultSelectEtat = OracleUtils.Table(sdisQueryEtat)
        Me.txtStatutActuel.Text = resultSelectEtat.Rows(0)("ENGIN_ETAT")


        Me.comboBoxStatutDesire.Text = resultSelectEtat.Rows(0)("ENGIN_ETAT")
        comboBoxStatutDesire.Items.Add("En alerte")
        comboBoxStatutDesire.Items.Add("Parti")
        comboBoxStatutDesire.Items.Add("Sur les lieux")
        comboBoxStatutDesire.Items.Add("Transport Hôpital")
        comboBoxStatutDesire.Items.Add("Disponible")
        comboBoxStatutDesire.Items.Add("Rentré")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        sdisQueryEtat = "UPDATE ENGIN SET ENGIN_ETAT='" & comboBoxStatutDesire.Text & "' WHERE ENGIN_NOM='" & _vehiculeNom & "' AND CIS_ID=(SELECT CIS_ID FROM CASERNE WHERE CIS_NOM='" & _vehiculeCS & "')"

        Try
            Dim InterventionForm As New PF3_Intervention(interventionID, _title)
            OracleUtils.Execute(sdisQueryEtat)
            Me.Close()
            InterventionForm.Show()
        Catch ex As Exception
            MsgBox("Impossible de mettre à jour le statut du véhicule")
        End Try
    End Sub

End Class