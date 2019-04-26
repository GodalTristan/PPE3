Public Class Engin

    Private _id As Integer
    Private _etat As String
    Private _nom As String
    Private _type As TypeEngin


    Public Sub New(ByVal id, ByVal nom, ByVal etat, ByVal type)
        _id = id
        _nom = nom
        _etat = etat
        _type = type
    End Sub

    Public Sub New(ByVal str)
        _id = str("ENGIN_ID")
        _nom = str("ENGIN_NOM")
        _etat = str("ENGIN_ETAT")
        _type = New TypeEngin(str("TYPE_ENG_ID"))
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Public Property Etat As String
        Get
            Return _etat

        End Get
        Set(ByVal value As String)
            _etat = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property Type As TypeEngin
        Get
            Return _type
        End Get
        Set(ByVal value As TypeEngin)
            _type = value
        End Set
    End Property

End Class