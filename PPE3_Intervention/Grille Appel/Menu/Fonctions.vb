''' ###############################################################################################################
''' #                                               INFORMATIONS                                                  #
''' ###############################################################################################################
''' #                                                                                                             #
''' # Nom du fichier         :  Fonction.vb                                                                       #                                                             
''' # Rôle du fichier        :  Contient toute les fonctions                                                      #
''' # Langage                :  Visual Basic                                                                      #
''' # Auteur                 :  Kilian Magniez                                                                    #
''' # Dernière modification  :  23/11/2018                                                                        #
''' # Description            :  Ajout de commentaires                                                             #
''' #                                                                                                             #
''' ###############################################################################################################
''' #                                                 FONCTIONS                                                   #
''' ###############################################################################################################
''' #                                                                                                             #                                                             
''' # GetHostname()  : Retourne le nom de la machine locale                                                       #
''' # GetTP()        : Retourne l'adresse IP de la machine Locale                                                 #
''' #                                                                                                             #
''' ###############################################################################################################
'''  #                                                VARIABLES                                                   #
''' ###############################################################################################################
''' #                                                                                                             #
''' # Hostname   : String                                                                                         #                                                             
''' # Hostname2  : String                                                                                         #
''' # ip         : Objet                                                                                          #
''' #                                                                                                             #
''' ###############################################################################################################



Module Fonctions


    Public Function GetHostname()
        'Retourne le nom de la machine locale

        Dim hostname As String

        hostname = Environment.MachineName()

        Return hostname

    End Function



    Public Function GetIP()

        'retourne l'adresse IP locale en IPv6

        Dim HostName As String

        HostName = Environment.MachineName()

        Dim Hostname2 As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(HostName)
        Dim ip As System.Net.IPAddress() = Hostname2.AddressList


        Return ip(0).ToString




    End Function


End Module
