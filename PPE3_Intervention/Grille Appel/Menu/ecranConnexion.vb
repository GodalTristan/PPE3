Imports System.Security.Cryptography
Imports System.Text

Public Class ecranConnexion
    Public listeUtilisateur As New ArrayList
    Dim Result As DataRow
    Dim requeteConnexion As String
    Dim requeteInfoPompier As String

    Public Shared instance As Connexion

    Private Sub Connexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Affichage du nom de la machine local avec la fonction GetHostname
        TB_Statut.Text = "Nom du PC : " & GetHostname()

        'Affichage de l'adresse IP de la machine local avec la fonction GetIP()
        TB_Statut.Text = TB_Statut.Text & vbCrLf & "IP du PC : " & GetIP()


        TB_Statut.Text = TB_Statut.Text & vbCrLf & ""
        TB_Statut.Text = TB_Statut.Text & vbCrLf & "Connexion à la base SDIS29..."
        instance = New Connexion("SDIS29_PPE3", "SDIS29", "Iroise29")

        'Masquage des caractères écrit dans la TextBox TB_Motdepasse. Les caractère sont remplacés par des étoiles ("*")
        TB_Motdepasse.PasswordChar = "*"




    End Sub


    Private Sub BT_Connexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Connexion.Click
        Dim requeteConnexion As DataTable = Connexion.ORA.Table("SELECT * FROM LOGIN WHERE LOG_LOGIN='" & TB_Identifiant.Text & "' AND LOG_MDP='" & GetHash(TB_Motdepasse.Text) & "';")
        If requeteConnexion.Rows.Count > 0 Then
            Dim query As DataTable = Connexion.ORA.Table("SELECT LOG_NOM,LOG_PRENOM, LOG_PROFIL FROM LOGIN WHERE LOG_LOGIN='" & TB_Identifiant.Text & "';")

            Try
                Dim profil As String = query.Rows(0)("LOG_PROFIL")
                Select Case profil
                    Case "CTA"
                        Me.Hide()
                        Dim CTAView As New CTA
                        CTAView.Show()
                    Case "COD"
                        Me.Hide()
                        Dim SuiviIntervention As New PF3_SelectionIntervention
                        Try
                            SuiviIntervention.Show()
                        Catch ex As Exception
                            MsgBox(ex)
                        End Try
                    Case "SP"
                        Dim spMatricule As DataTable = Connexion.ORA.Table("SELECT SP_MATRICULE FROM LOGIN WHERE LOG_LOGIN='" & TB_Identifiant.Text & "'")
                        Dim requeteChef As DataTable = Connexion.ORA.Table("SELECT COUNT(*) FROM EXERCER WHERE SP_MATRICULE='" & spMatricule.Rows(0)("SP_MATRICULE") & "' AND FCT_ID=4")
                        Dim chef_agres As String = requeteChef.Rows(0)("COUNT(*)")

                        If chef_agres = 1 Then
                            Me.Hide()
                            Dim ListingRapport As New PF2_Listing_Rapport(spMatricule.Rows(0)("SP_MATRICULE"))
                            Try
                                ListingRapport.Show()
                            Catch ex As Exception
                                MsgBox(ex)
                            End Try
                        End If
                End Select



            Catch ex As Exception
                LB_message.Text = "/!\ Problème de Connexion /!\"


            End Try
        Else
            LB_message.Text = "/!\ Identifiant incorrects /!\"
        End If



    End Sub

    Shared Function GetHash(ByVal theInput As String) As String

        Using hasher As MD5 = MD5.Create()    ' create hash object

            ' Convert to byte array and get hash
            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            ' sb to create string from bytes
            Dim sBuilder As New StringBuilder()

            ' convert byte data to hex string
            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function
End Class
