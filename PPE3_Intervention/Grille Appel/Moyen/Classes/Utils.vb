Public Class Utils

    Const PI = 3.1415926535897931

    Public Shared Function getDistance(ByVal lat1, ByVal lon1, ByVal lat2, ByVal lon2, Optional ByVal unit = "K")
        Dim theta, dist
        theta = lon1 - lon2
        dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta))
        dist = Math.Acos(dist)
        dist = rad2deg(dist)
        getDistance = dist * 60 * 1.1515
        Select Case UCase(unit)
            Case "K"
                Return getDistance = getDistance * 1.609344
            Case "N"
                Return getDistance = getDistance * 0.8684
        End Select
    End Function

    ' This function converts decimal degrees to radians             
    Private Shared Function deg2rad(ByVal Deg)
        deg2rad = CDbl(Deg * PI / 180)
    End Function

    ' This function converts radians to decimal degrees             
    Private Shared Function rad2deg(ByVal Rad)
        rad2deg = CDbl(Rad * 180 / PI)
    End Function

End Class
