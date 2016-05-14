Public Class Juegos

    Dim jugador1 As New Jugador
    Dim jugador2 As New Jugador
    Dim jugador3 As New Jugador
    Dim jugador4 As New Jugador
    Dim jugador5 As New Jugador
    Dim poker1 As New Dados
    Dim poker2 As New Dados
    Dim poker3 As New Dados
    Dim poker4 As New Dados
    Dim poker5 As New Dados


    Private Sub Juegos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = False
        DadoTurno.Visible = False
        EmpezarBtn.Visible = False
        GroupBox1.Visible = False
        Jugador1Btn.Visible = False
        Jugador2Btn.Visible = False
        Jugador3Btn.Visible = False
        Jugador4Btn.Visible = False
        Jugador5Btn.Visible = False
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        If RadioButton2.Checked = True Then

            RadioButton2.Enabled = True

        ElseIf RadioButton3.Checked = True Then

            RadioButton3.Enabled = True

        ElseIf RadioButton4.Checked = True Then

            RadioButton4.Enabled = True

        ElseIf RadioButton5.Checked = True Then

            RadioButton5.Enabled = True

        End If
    End Sub

    Public Function registroJugadores() As String
        Dim registro As String
        registro = InputBox("Ingrese su nombre:", "Nombre del Jugador", "Nombre", 100, 50)
        Return (registro)
    End Function


    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Visible = True
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = False
        Jugador4Btn.Visible = False
        Jugador5Btn.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        RadioButton5.Visible = False
        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Visible = True
        RadioButton2.Visible = False
        RadioButton4.Visible = False
        RadioButton5.Visible = False
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = True
        Jugador4Btn.Visible = False
        Jugador5Btn.Visible = False
        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Visible = True
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton5.Visible = False
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = True
        Jugador4Btn.Visible = True
        Jugador5Btn.Visible = False
        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Label1.Visible = True
        RadioButton5.Enabled = True
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        Jugador1Btn.Visible = True
        Jugador2Btn.Visible = True
        Jugador3Btn.Visible = True
        Jugador4Btn.Visible = True
        Jugador5Btn.Visible = True
        If Jugador1Btn.Created And Jugador2Btn.Created Then
            EmpezarBtn.Visible = True

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Jugador1Btn.Click


        jugador1.setNombre(Me.registroJugadores)



    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Jugador2Btn.Click

        jugador2.getNombre(Me.registroJugadores)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Jugador3Btn.Click

        jugador3.getNombre(Me.registroJugadores)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Jugador4Btn.Click

        jugador4.getNombre(Me.registroJugadores)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Jugador5Btn.Click

        jugador5.getNombre(Me.registroJugadores)

    End Sub

    Private Sub NuevoJuegoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NuevoJuegoToolStripMenuItem1.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub NuevoJuegoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles NuevoJuegoToolStripMenuItem2.Click
        GroupBox1.Visible = True
    End Sub

    Private Sub EmpezarBtn_Click(sender As Object, e As EventArgs) Handles EmpezarBtn.Click
        MessageBox.Show("El orden de los turnos vendrá determinado por el dado más alto")
        DadoTurno.Visible = True

    End Sub

    Private Sub LanzarBtn_Click(sender As Object, e As EventArgs) Handles DadoTurno.Click
        MessageBox.Show(jugador1.ToString)

        jugador1.lanzar()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente quieres salir del Juego?", "Salir del Juego", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub EventLog1_EntryWritten(sender As Object, e As EntryWrittenEventArgs) Handles EventLog1.EntryWritten

    End Sub
End Class
