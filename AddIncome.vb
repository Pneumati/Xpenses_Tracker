Imports System.Data.SqlClient
Public Class AddIncome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conncetionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            Using connection As New SqlConnection(conncetionString)
                connection.Open()
                Dim query As String = "INSERT INTO [Income] (IncName, IncAmt, IncCat, IncDate) VALUES (@IncName, @IncAmt, @IncCat, @IncDate)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@IncName", AddInc.Text)
                command.Parameters.AddWithValue("@IncAmt", Amt.Text.ToString)
                command.Parameters.AddWithValue("@IncCat", Category.SelectedItem.ToString)
                command.Parameters.AddWithValue("@IncDate", IncDate.Value.Date)
                command.ExecuteNonQuery()
                MessageBox.Show("Income added successfully")
                Me.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Couldn't add income. Check to see if all details are correct" & ex.Message)

        End Try
    End Sub
End Class