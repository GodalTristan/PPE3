Public Class Utilisateur
    Private _matricule As String
    Private _login As String
    Private _mdp As String
    Private _profil As String


    Public Sub New(ByRef unLogin As String, ByRef unmdp As String)
        Dim unmatricule = Connexion.ORA.Champ("SELECT SP_MATRICULE FROM LOGIN WHERE LOG_LOGIN='" & unLogin & "';")
        Dim unprofil = Connexion.ORA.Champ("SELECT LOG_PROFIL FROM LOGIN WHERE LOG_LOGIN='" & unLogin & "';")
        _login = unLogin
        _mdp = unmdp
        _matricule = unmatricule("SP_MATRICULE")
        _profil = unprofil("LOG_PROFIL")
    End Sub


    Public Property login As String
        Get
            Return _login
        End Get
        Set(ByVal value As String)
            _login = value
        End Set
    End Property


    Public Property mdp As String
        Get
            Return _mdp
        End Get
        Set(ByVal value As String)
            _mdp = value
        End Set
    End Property


    Public Property matricule As String
        Get
            Return _matricule
        End Get
        Set(ByVal value As String)
            _matricule = value
        End Set
    End Property

    Public Property profil As String
        Get
            Return _profil
        End Get
        Set(ByVal value As String)
            _profil = value
        End Set
    End Property
End Class
