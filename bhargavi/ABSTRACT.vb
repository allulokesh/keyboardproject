Public Class ABSTRACT

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BackBt.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub ABSTRACT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.TextAlign = "            Authentication is a common approach to protect user information in the information systems such as ATMs. One of the easiest ways for user authentication uses Personal Identification Number (PIN). PINs are vulnerable to malicious attacks. The tendency of users to select easy passwords or short password makes the passwords vulnerable to many attacks like camera recording attack and adversary shoulder attacks. In this project, the proposed textual password authentication scheme is introduced as an alternative to graphical password schemes. In this technique, no need to use the traditional keyboard or even pressing the keys that represent the password characters. This technique gives the user a more secure session to enter the password."

    End Sub
End Class