Imports System.Data.SqlClient


Public Class Form3
    Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles Cp.TextChanged
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Signup.Click

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                ' Assuming you have textboxes to capture user information,
                ' replace txtName, txtEmail, and txtPhone with the actual names of your textboxes.
                Dim query As String = "INSERT INTO [User] (UserName, Email, Password, ConfirmP) VALUES (@UserName, @Email, @Password, @ConfirmP)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserName", Username.Text)
                command.Parameters.AddWithValue("@Email", Email.Text)
                command.Parameters.AddWithValue("@Password", Password.Text)
                command.Parameters.AddWithValue("@ConfirmP", Cp.Text)
                command.ExecuteNonQuery()

                MessageBox.Show("Account created successfully. Go to home page and login")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occured while trying to create your account. Please check to make sure all details are correct:" & ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class