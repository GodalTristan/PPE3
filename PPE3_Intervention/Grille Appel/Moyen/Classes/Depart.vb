Public Class Depart
    Private _id As Integer
    Private _engin As Engin
    Private _intervention As Intervention
    Private _dteDepart As Date
    Private _dteRetour As Date
    Private _kilometrage As Integer
    Private _commentaire As String


    Public Sub New(ByVal id, ByVal engin, ByVal intervention, ByVal dteDepart, ByVal dteRetour, ByVal kilometrage, ByVal commentaire)
        _id = id
        _engin = engin
        _intervention = intervention
        _dteDepart = dteDepart
        _dteRetour = dteRetour
        _kilometrage = kilometrage
        _commentaire = commentaire
    End Sub




    Public Property Commentaire As Integer
        Get
            Return _commentaire
        End Get
        Set(ByVal value As Integer)

            _commentaire = value
        End Set
    End Property

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)

            _ID = value
        End Set
    End Property

    Public Property DateDepart As Date
        Get
            Return _dteDepart
        End Get
        Set(ByVal value As Date)

            _dteDepart = value
        End Set
    End Property

    Public Property DateRetour As Date
        Get
            Return _dteRetour

        End Get
        Set(ByVal value As Date)
            _dteRetour = value
        End Set
    End Property

    Public Property Engin As Engin
        Get
            Return _engin
        End Get
        Set(ByVal value As Engin)
            _engin = value
        End Set
    End Property

    Public Property Intervention As Intervention
        Get
            Return _intervention
        End Get
        Set(ByVal value As Intervention)

            _intervention = value
        End Set
    End Property

    Public Property Kilometrage As Integer
        Get
            Return _kilometrage
        End Get
        Set(ByVal value As Integer)

            _kilometrage = value
        End Set
    End Property

End Class
