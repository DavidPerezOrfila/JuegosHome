<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Juegos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DadoTurno = New System.Windows.Forms.Button()
        Me.EmpezarBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Jugador1Btn = New System.Windows.Forms.Button()
        Me.Jugador2Btn = New System.Windows.Forms.Button()
        Me.Jugador3Btn = New System.Windows.Forms.Button()
        Me.Jugador4Btn = New System.Windows.Forms.Button()
        Me.Jugador5Btn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JuegoDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoJuegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoJuegoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.JuegoCartasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdivinaLaParejaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoJuegoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Lblfecha = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DadoTurno
        '
        Me.DadoTurno.Location = New System.Drawing.Point(246, 399)
        Me.DadoTurno.Name = "DadoTurno"
        Me.DadoTurno.Size = New System.Drawing.Size(142, 54)
        Me.DadoTurno.TabIndex = 0
        Me.DadoTurno.Text = "Lanzar Dado!"
        Me.DadoTurno.UseVisualStyleBackColor = True
        '
        'EmpezarBtn
        '
        Me.EmpezarBtn.Location = New System.Drawing.Point(23, 399)
        Me.EmpezarBtn.Name = "EmpezarBtn"
        Me.EmpezarBtn.Size = New System.Drawing.Size(142, 54)
        Me.EmpezarBtn.TabIndex = 1
        Me.EmpezarBtn.Text = "Empezar Partida"
        Me.EmpezarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(204, 223)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elige el número de Jugadores:"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(83, 134)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton5.TabIndex = 4
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(84, 107)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton4.TabIndex = 3
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(84, 80)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton3.TabIndex = 2
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(84, 53)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(37, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Jugador1Btn
        '
        Me.Jugador1Btn.Location = New System.Drawing.Point(372, 101)
        Me.Jugador1Btn.Name = "Jugador1Btn"
        Me.Jugador1Btn.Size = New System.Drawing.Size(102, 39)
        Me.Jugador1Btn.TabIndex = 5
        Me.Jugador1Btn.Text = "Jugador1"
        Me.Jugador1Btn.UseVisualStyleBackColor = True
        '
        'Jugador2Btn
        '
        Me.Jugador2Btn.Location = New System.Drawing.Point(493, 101)
        Me.Jugador2Btn.Name = "Jugador2Btn"
        Me.Jugador2Btn.Size = New System.Drawing.Size(102, 39)
        Me.Jugador2Btn.TabIndex = 6
        Me.Jugador2Btn.Text = "Jugador 2"
        Me.Jugador2Btn.UseVisualStyleBackColor = True
        '
        'Jugador3Btn
        '
        Me.Jugador3Btn.Location = New System.Drawing.Point(372, 163)
        Me.Jugador3Btn.Name = "Jugador3Btn"
        Me.Jugador3Btn.Size = New System.Drawing.Size(102, 39)
        Me.Jugador3Btn.TabIndex = 7
        Me.Jugador3Btn.Text = "Jugador 3"
        Me.Jugador3Btn.UseVisualStyleBackColor = True
        '
        'Jugador4Btn
        '
        Me.Jugador4Btn.Location = New System.Drawing.Point(493, 163)
        Me.Jugador4Btn.Name = "Jugador4Btn"
        Me.Jugador4Btn.Size = New System.Drawing.Size(102, 39)
        Me.Jugador4Btn.TabIndex = 8
        Me.Jugador4Btn.Text = "Jugador 4"
        Me.Jugador4Btn.UseVisualStyleBackColor = True
        '
        'Jugador5Btn
        '
        Me.Jugador5Btn.Location = New System.Drawing.Point(372, 224)
        Me.Jugador5Btn.Name = "Jugador5Btn"
        Me.Jugador5Btn.Size = New System.Drawing.Size(102, 39)
        Me.Jugador5Btn.TabIndex = 9
        Me.Jugador5Btn.Text = "Jugador 5"
        Me.Jugador5Btn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JuegoDadosToolStripMenuItem, Me.JuegoCartasToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'JuegoDadosToolStripMenuItem
        '
        Me.JuegoDadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoJuegoToolStripMenuItem})
        Me.JuegoDadosToolStripMenuItem.Name = "JuegoDadosToolStripMenuItem"
        Me.JuegoDadosToolStripMenuItem.Size = New System.Drawing.Size(107, 24)
        Me.JuegoDadosToolStripMenuItem.Text = "Juego Dados"
        '
        'NuevoJuegoToolStripMenuItem
        '
        Me.NuevoJuegoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoJuegoToolStripMenuItem1})
        Me.NuevoJuegoToolStripMenuItem.Name = "NuevoJuegoToolStripMenuItem"
        Me.NuevoJuegoToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.NuevoJuegoToolStripMenuItem.Text = "Dados Poker"
        '
        'NuevoJuegoToolStripMenuItem1
        '
        Me.NuevoJuegoToolStripMenuItem1.Name = "NuevoJuegoToolStripMenuItem1"
        Me.NuevoJuegoToolStripMenuItem1.Size = New System.Drawing.Size(170, 26)
        Me.NuevoJuegoToolStripMenuItem1.Text = "Nuevo Juego"
        '
        'JuegoCartasToolStripMenuItem
        '
        Me.JuegoCartasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdivinaLaParejaToolStripMenuItem})
        Me.JuegoCartasToolStripMenuItem.Name = "JuegoCartasToolStripMenuItem"
        Me.JuegoCartasToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.JuegoCartasToolStripMenuItem.Text = "Juego Cartas"
        '
        'AdivinaLaParejaToolStripMenuItem
        '
        Me.AdivinaLaParejaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoJuegoToolStripMenuItem2})
        Me.AdivinaLaParejaToolStripMenuItem.Name = "AdivinaLaParejaToolStripMenuItem"
        Me.AdivinaLaParejaToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AdivinaLaParejaToolStripMenuItem.Text = "Adivina la pareja"
        '
        'NuevoJuegoToolStripMenuItem2
        '
        Me.NuevoJuegoToolStripMenuItem2.Name = "NuevoJuegoToolStripMenuItem2"
        Me.NuevoJuegoToolStripMenuItem2.Size = New System.Drawing.Size(170, 26)
        Me.NuevoJuegoToolStripMenuItem2.Text = "Nuevo Juego"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(477, 301)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 21
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(371, 301)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(265, 301)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(159, 301)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(53, 301)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(369, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Introduce los datos de cada jugador:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'Lblfecha
        '
        Me.Lblfecha.AutoSize = True
        Me.Lblfecha.Location = New System.Drawing.Point(372, 32)
        Me.Lblfecha.Name = "Lblfecha"
        Me.Lblfecha.Size = New System.Drawing.Size(0, 17)
        Me.Lblfecha.TabIndex = 23
        Me.Lblfecha.Visible = False
        '
        'Juegos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 523)
        Me.Controls.Add(Me.Lblfecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Jugador5Btn)
        Me.Controls.Add(Me.Jugador4Btn)
        Me.Controls.Add(Me.Jugador3Btn)
        Me.Controls.Add(Me.Jugador2Btn)
        Me.Controls.Add(Me.Jugador1Btn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.EmpezarBtn)
        Me.Controls.Add(Me.DadoTurno)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Juegos"
        Me.ShowIcon = False
        Me.Text = "Juegos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DadoTurno As Button
    Friend WithEvents EmpezarBtn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Jugador1Btn As Button
    Friend WithEvents Jugador2Btn As Button
    Friend WithEvents Jugador3Btn As Button
    Friend WithEvents Jugador4Btn As Button
    Friend WithEvents Jugador5Btn As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JuegoDadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoJuegoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoJuegoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents JuegoCartasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdivinaLaParejaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoJuegoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Lblfecha As Label
End Class
