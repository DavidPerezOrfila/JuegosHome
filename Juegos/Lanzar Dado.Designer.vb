<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lanzar_Dado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lanzar_Dado))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Resultado = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "blacks.PNG")
        Me.ImageList1.Images.SetKeyName(1, "reds.PNG")
        Me.ImageList1.Images.SetKeyName(2, "sota.PNG")
        Me.ImageList1.Images.SetKeyName(3, "Queen.PNG")
        Me.ImageList1.Images.SetKeyName(4, "king.PNG")
        Me.ImageList1.Images.SetKeyName(5, "as.PNG")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(54, 68)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Resultado
        '
        Me.Resultado.FormattingEnabled = True
        Me.Resultado.ItemHeight = 16
        Me.Resultado.Location = New System.Drawing.Point(247, 68)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(133, 116)
        Me.Resultado.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(144, 244)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 70)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lanzar_Dado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 382)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Lanzar_Dado"
        Me.Text = "Lanzar Dado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Resultado As ListBox
    Friend WithEvents Button1 As Button
End Class
