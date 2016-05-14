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
    Private lanzarDado As Integer

    Public Function lanzar() As Integer
        Dim poker1 As New Dados
        poker1.girar()
        Return lanzarDado
    End Function
End Class
