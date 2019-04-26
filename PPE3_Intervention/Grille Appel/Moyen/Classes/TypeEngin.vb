Public Class TypeEngin

    Private _id As Integer
    Private _nom As String
    Private _nbPlace As Integer
    Private _fonctions As List(Of Fonction)


    Public Sub New(ByVal id, ByVal nom, ByVal nbPlace)
        _id = id
        _nom = nom
        _nbPlace = nbPlace
    End Sub

    Public Sub New(ByVal id)
        Dim Str As DataRow = Connexion.ORA.Champ("SELECT * FROM TYPE_ENGIN WHERE TYPE_ENG_ID = " & id)

        _id = Str("TYPE_ENG_ID")
        _nom = Str("TYPE_ENG_NOM")
        _nbPlace = Str("TYPE_ENG_PLACES")
        _fonctions = New List(Of Fonction)
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property nbPlace As Integer
        Get
            Return _nbPlace
        End Get
        Set(ByVal value As Integer)
            _nbPlace = value
        End Set
    End Property

    Public Property Fonctions As List(Of Fonction)
        Get
            Return _fonctions
        End Get
        Set(ByVal value As List(Of Fonction))
            _fonctions = value
        End Set
    End Property


    Public Sub LoadFonctions()
        Dim table As DataTable = New DataTable("SELECT FCT_ID, FCT_LIBELLE FROM FONCTION, TYPE_ENGIN")
    End Sub


End Class