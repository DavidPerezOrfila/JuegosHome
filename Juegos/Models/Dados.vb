Public Class Dados

    'Creo la clase dados, las propiedades de esta clase son los lados que tiene el dado y el valor de cada lado
    Dim lados As Integer = 6
    Private valorLados As Integer
    Private Negras As Integer
    Private Rojas As Integer
    Private Jack As Integer
    Private Queen As Integer
    Private King As Integer
    Private Ace As Integer

    'Construyo los getters y los setters
    Public Function getvalorLados() As Integer
        Return valorLados
    End Function


    Public Sub setvalorLados(ByVal valor As Integer)
        valorLados = valor
    End Sub


    'Creo el método girar que devolverá un valor aleatorio del 1 al 6 y asigna el valor del dado a una figura
    Public Function girar() As Integer

        valorLados = CInt(Int((lados * Rnd()) + 1))
        Select Case valorLados
            Case 1
                Negras = 1

            Case 2
                Rojas = 2
            Case 3
                Jack = 3
            Case 4
                Queen = 4
            Case 5
                Queen = 5
            Case 6
                Ace = 6
        End Select

        Return valorLados
    End Function

    'Modifico toString para que muestre el resultado

    Public Overrides Function toString() As String
        Dim resultado As String
        resultado = valorLados.ToString
        Return resultado
    End Function


End Class
