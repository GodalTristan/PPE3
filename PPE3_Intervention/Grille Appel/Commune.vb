Public Class Commune
    Private _code As Integer
    Private _nom As String

    Public Sub New(ByVal code, ByVal nom)
        _code = code
        _nom = nom
    End Sub

    Public Property code As Integer
        Get
            Return _code
        End Get
        Set(ByVal value As Integer)
            _code = value
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
End Class
