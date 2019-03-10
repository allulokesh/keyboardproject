Public Class Home

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AbstractBt.Click

        ABSTRACT.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ProceedBt.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExitBt.Click
        Me.Close()
    End Sub

    Shared Sub NativeWindow()
        Throw New NotImplementedException
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
