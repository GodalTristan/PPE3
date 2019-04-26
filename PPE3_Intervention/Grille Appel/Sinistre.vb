Public Class Sinistre

    Private _id As Integer
    Private _nature As String


    Public Sub New(ByVal id, ByVal nature)
        _id = id
        _nature = nature
    End Sub

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property nature As String
        Get
            Return _nature
        End Get
        Set(ByVal value As String)
            _nature = value
        End Set
    End Property



End Class
