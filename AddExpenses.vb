Imports System.Data.SqlClient
Public Class AddExpenses
    Private Sub ExpAdd_Click(sender As Object, e As EventArgs) Handles ExpAdd.Click
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "INSERT [Expense] (ExpName, ExpAmt, ExpCat, ExpDate) VALUES (@ExpName, @ExpAmt, @ExpCat, @ExpDate)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@ExpName", ExpName.Text)
                command.Parameters.AddWithValue("@ExpAmt", Amt.Text.ToString)
                command.Parameters.AddWithValue("@ExpCat", ExpCategory.SelectedItem.ToString)
                command.Parameters.AddWithValue("@ExpDate", ExxpDate.Value.Date)
                command.ExecuteNonQuery()
                MessageBox.Show("Expense added successfully")
                Me.Close
            End Using
        Catch ex As Exception
            MessageBox.Show("Couldn't add income. Check to see if all details are correct" & ex.Message)
        End Try
    End Sub
End Class