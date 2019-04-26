
Imports System.Data.SqlClient


Public Class PF2_Listing_Rapport

    Dim spMatricule As String

    Public Sub New(ByVal _spMatricule As String)
        InitializeComponent()

        spMatricule = _spMatricule
    End Sub

    Public Property Matricule() As String
        Get
            Return Me.spMatricule
        End Get
        Set(ByVal Value As String)
            Me.spMatricule = Value
        End Set
    End Property

    Dim Interv As New CurdIntervention

    Dim connString As String
    Dim donnee As DataTable



    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Interv.afficheIHMinterv(Me, ListView1, spMatricule)

    End Sub


    Private Sub btnselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnselect.Click
        Me.Hide()
        Dim Rapport As New PF4_Rapports(ListView1.SelectedItems(0).Text, spMatricule)
        Rapport.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim connect As New ecranConnexion
        connect.Show()
    End Sub
End Class
