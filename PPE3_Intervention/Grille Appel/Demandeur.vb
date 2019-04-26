Public Class Demandeur

    Private _id As Integer
    Private _nom As String
    Private _prenom As String
    Private _tel As String
    Private _lieu As String
    Private _No As String
    Private _Ext As String
    Private _Etage As String
    Private _Porte As String
    Private _Bat As String
    Private _commentaire As String
    Private _Code As String
    Private _CodeCommune As Integer

    Public Sub New(ByVal id, ByVal nom, ByVal prenom, ByVal tel, ByVal unlieu, ByVal unno, ByVal unext, ByVal unetage, ByVal unporte, ByVal unbat, ByVal uncode, ByVal commune, ByVal commentaire)
        _id = id
        _nom = nom
        _prenom = prenom
        _tel = tel
        lieu = unlieu
        no = unno
        ext = unext
        etage = unetage
        porte = unporte
        bat = unbat
        code = uncode
        _CodeCommune = commune
        _commentaire = commentaire
    End Sub

    Public Property commentaire As String
        Get
            Return _commentaire
        End Get
        Set(ByVal value As String)
            _commentaire = value
        End Set
    End Property

    Public Property codecommune As Integer
        Get
            Return _CodeCommune
        End Get
        Set(ByVal value As Integer)
            _CodeCommune = value
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

    Public Property nom As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property prenom As String
        Get
            Return _prenom
        End Get
        Set(ByVal value As String)
            _prenom = value
        End Set
    End Property

    Public Property tel As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = value
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
