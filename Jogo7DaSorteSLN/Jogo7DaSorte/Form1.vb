Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TituloJogo.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Num1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        End
    End Sub

    Private Sub BtnJogar_Click(sender As Object, e As EventArgs) Handles BtnJogar.Click
        ImagemResultado.Visible = False
        Randomize()
        Num1.Text = CStr(Int(Rnd() * 10))
        Num2.Text = CStr(Int(Rnd() * 10))
        Num3.Text = CStr(Int(Rnd() * 10))

        'Se todos os números forem 7
        If (Num1.Text = "7") And (Num2.Text = "7") And (Num3.Text = "7") Then
            ImagemResultado.Image = Image.FromFile("C:\Users\Matheus\source\repos\Jogo7DaSorteSLN\777.jpg")
            ImagemResultado.Visible = True
            Beep()

            'Se algum número for 7
        ElseIf (Num1.Text = "7") Or (Num2.Text = "7") Or (Num3.Text = "7") Then
            ImagemResultado.Image = Image.FromFile("C:\Users\Matheus\source\repos\Jogo7DaSorteSLN\voceganhou.jfif")
            ImagemResultado.Visible = True

            'Se nenhum número for 7
        Else
            ImagemResultado.Image = Image.FromFile("C:\Users\Matheus\source\repos\Jogo7DaSorteSLN\perdeu.jfif")
            ImagemResultado.Visible = True
        End If
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles TotalPontos.Click

    End Sub
End Class
