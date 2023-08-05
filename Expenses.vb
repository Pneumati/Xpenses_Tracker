Imports System.Data
Imports System.Data.SqlClient

Public Class Expenses
    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call a method to load and display income data in the DataGridView
        LoadExpensesData()
    End Sub

    Private Sub LoadExpensesData()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30" ' Replace with your actual connection string
        Dim query As String = "SELECT * FROM [Expense]" ' Replace with the name of your income table

        ' Create a SqlConnection and SqlDataAdapter to fetch data from the database
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim expenseTable As New DataTable()

            Try
                ' Open the connection, fill the data into the incomeTable, and close the connection
                connection.Open()
                adapter.Fill(expenseTable)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try

            ' Bind the incomeTable to the DataGridView
            DataGridView1.DataSource = expenseTable
        End Using
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Income.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddExpenses.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub
End Class