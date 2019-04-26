Public Class CurdIntervention

    ''LIAISON AVEC IHM
    Public Sub afficheIHMinterv(ByVal uneFeuille As Form, ByVal uneListView As ListView, ByVal spMatricule As String)

        uneListView.Clear()
        uneListView.Columns.Add("N°", 30, HorizontalAlignment.Left)
        uneListView.Columns.Add("Lieu", 70, HorizontalAlignment.Left)
        uneListView.Columns.Add("Date", 90, HorizontalAlignment.Left)
        uneListView.Columns.Add("ID", 120, HorizontalAlignment.Left)
        uneListView.Columns.Add("Nature du sinistre", 90, HorizontalAlignment.Left)

        Dim info(5) As String
        Dim itm As ListViewItem

        If spMatricule = Nothing Then
            Dim interv As DataTable = Connexion.ORA.Table("SELECT inter.interv_id ,interv_lieu, interv_dte , SIN_ID , SIN_NATURE from intervention inter, sinistre sin where inter.interv_sin_id=sin.sin_id and statut_interv='TERMINE';")
            For Each nom As DataRow In interv.Rows
                info(0) = nom("interv_id").ToString
                info(1) = nom("interv_lieu").ToString
                info(2) = nom("interv_dte").ToString
                info(3) = nom("SIN_ID").ToString
                info(4) = nom("SIN_NATURE").ToString

                itm = New ListViewItem(info)

                uneListView.Items.Add(itm)


            Next
        Else
            Dim interv As DataTable = Connexion.ORA.Table("SELECT inter.interv_id ,interv_lieu, interv_dte , SIN_ID , SIN_NATURE from intervention inter, sinistre sin, participe par, depart dep where inter.interv_sin_id=sin.sin_id and dep.interv_id=inter.interv_id and par.dep_id=dep.dep_id and sp_matricule='" & spMatricule & "' and statut_interv='TERMINE';")
            For Each nom As DataRow In interv.Rows
                info(0) = nom("interv_id").ToString
                info(1) = nom("interv_lieu").ToString
                info(2) = nom("interv_dte").ToString
                info(3) = nom("SIN_ID").ToString
                info(4) = nom("SIN_NATURE").ToString

                itm = New ListViewItem(info)

                uneListView.Items.Add(itm)


            Next
        End If
        uneListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

End Class
