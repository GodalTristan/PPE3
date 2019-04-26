Public Class Service

    Private _id As Integer
    Private _disponibilite As Disponibilite
    Private _pompier As Pompier


    Public Sub New(ByVal id, ByVal disponibilite, ByVal pompier)
        _id = id
        _disponibilite = disponibilite
        _pompier = pompier
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Disponibilite As Disponibilite
        Get
            Return _disponibilite
        End Get
        Set(ByVal value As Disponibilite)
            _disponibilite = value
        End Set
    End Property

    Public Property Pompier As Pompier
        Get
            Return _pompier
        End Get
        Set(ByVal value As Pompier)
            _pompier = value
        End Set
    End Property
End Class
