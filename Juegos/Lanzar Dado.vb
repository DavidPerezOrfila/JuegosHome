Public Class Lanzar_Dado
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ran As New Random

        Dim j As Integer = ran.Next(0, ImageList1.Images.Count)

        PictureBox1.Image = ImageList1.Images(j)

    End Sub
End Class