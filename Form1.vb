Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Create.LinkClicked
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignIn.Click
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT COUNT(*) FROM [User] WHERE UserName = @UserName AND Password = @Password"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserName", User.Text)
                command.Parameters.AddWithValue("@Password", Pass.Text)

                Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                If result > 0 Then
                    MessageBox.Show("Login successful. Welcome!")
                    Form4.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password. Please try again.")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while trying to log in. Please try again: " & ex.Message)
        End Try
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Pass_TextChanged(sender As Object, e As EventArgs) Handles Pass.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Pass.Visible = True
    End Sub
End Class
