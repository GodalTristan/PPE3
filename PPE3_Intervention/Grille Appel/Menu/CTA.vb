Public Class CTA

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        PF1_GrilleAppel.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim ListingRapport As New PF2_Listing_Rapport(Nothing)
        ListingRapport.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim connect As New ecranConnexion
        connect.Show()
    End Sub
End Class