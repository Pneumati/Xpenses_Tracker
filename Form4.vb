
Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form4
    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Income.Show()
        Me.Close()

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub



    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Expenses.Show()

    End Sub

    Private Sub IncDate(sender As Object, e As EventArgs) Handles MyBase.Load
        IncomeDate()
    End Sub

    Private Sub IncomeDate()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT MAX(IncDate) FROM INCOME"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim inT As New DataTable
            Try
                connection.Open()
                adapter.Fill(inT)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try
            If inT.Rows.Count > 0 AndAlso inT.Rows(0)(0) IsNot DBNull.Value Then
                IncLastDate.Text = Convert.ToDateTime(inT.Rows(0)(0)).ToString("yyyy-MM-dd")
            Else
                IncLastDate.Text = "No records found."
            End If
        End Using

    End Sub

    ''Dim connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub ExpenseAmt_Load(sender As Object, e As EventArgs)
        GetExpense()
    End Sub

    Private Sub GetExpense()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT SUM(ExpAmt) AS TotalExpense FROM EXPENSE"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim expenseTable As New DataTable()
            Try
                connection.Open()
                adapter.Fill(expenseTable)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try
            If expenseTable.Rows.Count > 0 Then
                ExpDisplay.Text = expenseTable.Rows(0)("TotalExpense").ToString
            End If
        End Using
    End Sub
    Private Sub IncomeAmt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetIncome()
    End Sub
    Private Sub GetIncome()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30" ' Replace with your actual connection string
        Dim query As String = "SELECT SUM(IncAmt) AS TotalIncome FROM INCOME"
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
            If incomeTable.Rows.Count > 0 Then
                IncDisplay.Text = incomeTable.Rows(0)("TotalIncome").ToString()
            End If
        End Using
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles IncLastDate.Click

    End Sub
End Class