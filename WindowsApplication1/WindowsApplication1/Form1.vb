Public Class Form1

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox5.Image = PictureBox3.Image
        PictureBox3.Image = PictureBox1.Image
        PictureBox1.Image = PictureBox5.Image
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox5.Image = PictureBox2.Image
        PictureBox2.Image = PictureBox3.Image
        PictureBox3.Image = PictureBox5.Image
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox5.Image = PictureBox3.Image
        PictureBox3.Image = PictureBox4.Image
        PictureBox4.Image = PictureBox5.Image
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox5.Image = PictureBox4.Image
        PictureBox4.Image = PictureBox1.Image
        PictureBox1.Image = PictureBox5.Image
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            PictureBox5.Image = PictureBox4.Image
            PictureBox4.Image = PictureBox3.Image
            PictureBox3.Image = PictureBox5.Image
            PictureBox5.Image = PictureBox4.Image
            PictureBox4.Image = PictureBox2.Image
            PictureBox2.Image = PictureBox5.Image
            PictureBox5.Image = PictureBox1.Image
            PictureBox1.Image = PictureBox2.Image
            PictureBox2.Image = PictureBox5.Image
         
       
    End Sub
End Class
