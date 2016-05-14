Public Class Jugador


    Private nombreJugador As String

    Public Function getNombre(ByVal registroJugadores As String)
        nombreJugador = registroJugadores
        Return nombreJugador
    End Function

    Public Sub setNombre(ByVal nombreJugador As String)
        Me.nombreJugador = Me.nombreJugador
    End Sub

    Private sumarPuntuacion As Integer
    Private Dadomax As Integer

    Public Function escogerturno() As Integer
        Dim poker1 As New Dados
        Dadomax = poker1.girar()
        Return dadomax
    End Function

    Public Sub turno()

    End Sub
End Class
