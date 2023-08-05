Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient

Public Class Income
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AddIncome.Show()
    End Sub

    Private Sub Income_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call a method to load and display income data in the DataGridView
        LoadIncomeData()
    End Sub

    Private Sub LoadIncomeData()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30" ' Replace with your actual connection string
        Dim query As String = "SELECT * FROM [Income]" ' Replace with the name of your income table

        ' Create a SqlConnection and SqlDataAdapter to fetch data from the database
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim incomeTable As New DataTable()

            Try
                ' Open the connection, fill the data into the incomeTable, and close the connection
                connection.Open()
                adapter.Fill(incomeTable)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try

            ' Bind the incomeTable to the DataGridView
            DataGridView1.DataSource = incomeTable
        End Using
    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Expenses.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
