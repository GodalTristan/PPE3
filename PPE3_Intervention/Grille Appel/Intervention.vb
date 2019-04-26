Public Class Intervention

    Private _id As Integer
    Private _lieu As String
    Private _No As String
    Private _Ext As String
    Private _Etage As String
    Private _Porte As String
    Private _Bat As String
    Private _Code As String
    Private _Commentaire As String
    Private _statut As String
    Private _sin As Integer
    Private _date As Date
    Private _commune As Integer
    Private _sinobserv As String
    Private _demandid As Integer

    Public Sub New(ByVal id, ByVal unlieu, ByVal unno, ByVal unext, ByVal unetage, ByVal unporte, ByVal unbat, ByVal uncode, ByVal commentaire, ByVal unSinistre, ByVal uneDate, ByVal uneCommune, ByVal sinobserv, ByVal demandid)
        _id = id
        _lieu = lieu
        lieu = unlieu
        no = unno
        ext = unext
        etage = unetage
        porte = unporte
        bat = unbat
        code = uncode
        _Commentaire = commentaire
        _statut = "test"
        _sin = unSinistre
        _date = uneDate
        _commune = uneCommune
        _sinobserv = sinobserv
        _demandid = demandid
    End Sub
    Public Property demandid As Integer
        Get
            Return _demandid
        End Get
        Set(ByVal value As Integer)
            _demandid = value
        End Set
    End Property

    Public Property statut As String
        Get
            Return _statut
        End Get
        Set(ByVal value As String)
            _statut = value
        End Set
    End Property

    Public Property sinobserv As String
        Get
            Return _sinobserv
        End Get
        Set(ByVal value As String)
                _sinobserv = value
        End Set
    End Property

    Public Property commune As Integer
        Get
            Return _commune
        End Get
        Set(ByVal value As Integer)
            _commune = value
        End Set
    End Property
    Public Property dte As Date
        Get
            Return _date
        End Get
        Set(ByVal value As Date)
            _date = value
        End Set
    End Property

    Public Property sin As Integer
        Get
            Return _sin
        End Get
        Set(ByVal value As Integer)
            _sin = value
        End Set
    End Property

    Public Property commentaire As String
        Get
            Return _Commentaire
        End Get
        Set(ByVal value As String)
                _Commentaire = value
        End Set
    End Property

    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property lieu As String
        Get
            Return _lieu
        End Get
        Set(ByVal value As String)
                _lieu = value
        End Set
    End Property

    Public Property no As String
        Get
            Return _No
        End Get
        Set(ByVal value As String)
            If value = "" Then
                _No = "NULL"
            Else
                _No = value
            End If
        End Set
    End Property

    Public Property ext As String
        Get
            Return _Ext
        End Get
        Set(ByVal value As String)
            If value = "" Then
                _Ext = "NULL"
            Else
                _Ext = value
            End If
        End Set
    End Property

    Public Property etage As String
        Get
            Return _Etage
        End Get
        Set(ByVal value As String)
            If value = "" Then
                _Etage = "NULL"
            Else
                _Etage = value
            End If
        End Set
    End Property

    Public Property porte As String
        Get
            Return _Porte
        End Get
        Set(ByVal value As String)
            If value = "" Then
                _Porte = "NULL"
            Else
                _Porte = value
            End If
        End Set
    End Property

    Public Property bat As String
        Get
            Return _Bat
        End Get
        Set(ByVal value As String)
            If value = "" Then
                _Bat = "NULL"
            Else
                _Bat = value
            End If
        End Set

    End Property
    Public Property code As String
        Get
            Return _Code
        End Get
        Set(ByVal value As String)
            If value = "" Then
                _Code = "NULL"
            Else
                _Code = value
            End If
        End Set
    End Property
End Class

