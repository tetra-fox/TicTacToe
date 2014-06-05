Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If Label3.Text = "X" Then
            Button1.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button1.Text = "O"
        End If
        If Button1.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button1.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        If Label3.Text = "X" Then
            Button2.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button2.Text = "O"
        End If
        If Button2.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button2.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.Enabled = False
        If Label3.Text = "X" Then
            Button3.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button3.Text = "O"
        End If
        If Button3.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button3.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.Enabled = False
        If Label3.Text = "X" Then
            Button4.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button4.Text = "O"
        End If
        If Button4.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button4.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        If Label3.Text = "X" Then
            Button5.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button5.Text = "O"
        End If
        If Button5.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button5.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Enabled = False
        If Label3.Text = "X" Then
            Button6.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button6.Text = "O"
        End If
        If Button6.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button6.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False
        If Label3.Text = "X" Then
            Button7.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button7.Text = "O"
        End If
        If Button7.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button7.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button8.Enabled = False
        If Label3.Text = "X" Then
            Button8.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button8.Text = "O"
        End If
        If Button8.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button8.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button9.Enabled = False
        If Label3.Text = "X" Then
            Button9.Text = "X"
        End If
        If Label3.Text = "O" Then
            Button9.Text = "O"
        End If
        If Button9.Text = "X" Then
            Label3.Text = "O"
        End If
        If Button9.Text = "O" Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Enabled = True
        Button1.Text = ""
        Button2.Enabled = True
        Button2.Text = ""
        Button3.Enabled = True
        Button3.Text = ""
        Button4.Enabled = True
        Button4.Text = ""
        Button5.Enabled = True
        Button5.Text = ""
        Button6.Enabled = True
        Button6.Text = ""
        Button7.Enabled = True
        Button7.Text = ""
        Button8.Enabled = True
        Button8.Text = ""
        Button9.Enabled = True
        Button9.Text = ""
        Label3.Text = "X"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            MsgBox("im too lazy to implement a win detector so find the fucking win yourself")
        End If
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Label3.Text = "X"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False And Button8.Enabled = False And Button9.Enabled = False Then
            Timer1.Stop()
        End If
    End Sub
End Class
