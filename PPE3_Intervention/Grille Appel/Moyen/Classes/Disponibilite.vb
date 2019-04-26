Public Class Disponibilite

    Private _id As Integer
    Private _libelle As String


    Public Sub New(ByVal id, ByVal libelle)
        _id = id
        _libelle = libelle
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property DispoLib As String
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value
        End Set
    End Property
End Class
