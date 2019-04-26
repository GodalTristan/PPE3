Public Class Fonction

    Private _id As Integer
    Private _libelle As String


    Public Sub New(ByVal id, ByVal libelle)
        _id = id
        _libelle = libelle
    End Sub

    Public Sub New(ByVal str As DataRow)
        _id = str("FCT_ID")
        _libelle = str("FCT_LIBELLE")
    End Sub

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Libelle As String
        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value
        End Set
    End Property
End Class
