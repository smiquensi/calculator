Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Result.Text = Result.Text & 1



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Result.Text = Result.Text & 2
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Result.Text = Result.Text & 3
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Result.Text = Result.Text & 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Result.Text = Result.Text & 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Result.Text = Result.Text & 6
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Result.Text = Result.Text & 7
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Result.Text = Result.Text & 8
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Result.Text = Result.Text & 9
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Result.Text = Result.Text & 0
    End Sub

    Private Sub ButtonSum_Click(sender As Object, e As EventArgs) Handles ButtonSum.Click
        label1num.Text = Result.Text

        Result.Text = ""
        lblOperador.Text = "+"
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        'Result.Text = Val(labelTop.Text) + Val(Result.Text)'

        If lblOperador.Text = "+" Then
            Result.Text = Val(label1num.Text) + Val(Result.Text)
        End If
        If lblOperador.Text = "-" Then
            Result.Text = Val(label1num.Text) - Val(Result.Text)
        End If
        If lblOperador.Text = "*" Then
            Result.Text = Val(label1num.Text) * Val(Result.Text)
        End If
        If lblOperador.Text = "/" Then
            Result.Text = Val(label1num.Text) / Val(Result.Text)
        End If

        'MsgBox(Val(label1num.Text) + Val(Result.Text))'

    End Sub



    Private Sub ButtonRest_Click(sender As Object, e As EventArgs) Handles ButtonRest.Click
        label1num.Text = Result.Text

        Result.Text = ""
        lblOperador.Text = "-"
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        label1num.Text = Result.Text

        Result.Text = ""
        lblOperador.Text = "*"
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        label1num.Text = Result.Text

        Result.Text = ""
        lblOperador.Text = "/"
    End Sub

End Class
