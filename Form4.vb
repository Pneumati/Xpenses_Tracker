﻿
Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting

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
        Me.Close()

    End Sub
    Private Sub ExpDate(sender As Object, e As EventArgs)
        ExpenseDate()
    End Sub
    Private Sub ExpenseDate()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT MAX(ExpDate) FROM EXPENSE"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim exT As New DataTable
            Try
                connection.Open()
                adapter.Fill(exT)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try
            If exT.Rows.Count > 0 AndAlso exT.Rows(0)(0) IsNot DBNull.Value Then
                ExpLastDate.Text = Convert.ToDateTime(exT.Rows(0)(0)).ToString("yyyy-MM-dd")
            Else
                ExpLastDate.Text = "No records found."
            End If
        End Using

    End Sub
    Private Sub IncDate(sender As Object, e As EventArgs)
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
    Private Sub IncomeAmt_Load(sender As Object, e As EventArgs)
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

    Private Sub IncGraph(sender As Object, e As EventArgs)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
    End Sub

    Private Sub HighIncCat(sender As Object, e As EventArgs)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT MAX(IncCat) AS TotalExpense FROM INCOME"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim incoTable As New DataTable()
            Try
                connection.Open()
                adapter.Fill(incoTable)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try
            If incoTable.Rows.Count > 0 Then
                HighIncome.Text = incoTable.Rows(0)("TotalExpense").ToString
            End If
        End Using
    End Sub

    Private Sub HighExpCat(sender As Object, e As EventArgs)
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Dim query As String = "SELECT MAX(ExpCat) AS HighExpense FROM EXPENSE"
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter(query, connection)
            Dim expTable As New DataTable()
            Try
                connection.Open()
                adapter.Fill(expTable)
                connection.Close()
            Catch ex As Exception
                MessageBox.Show("Error while fetching data: " & ex.Message)
            End Try
            If expTable.Rows.Count > 0 Then
                HighExp.Text = expTable.Rows(0)("HighExpense").ToString
            End If
        End Using
    End Sub

    Private Sub VisualizeData()

        ''  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Define your database connection string
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"

        ' Create a connection to the database
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT SUM(IncAmt) AS Amount, 'Income' AS Type FROM Income " &
                     "UNION " &
                     "SELECT SUM(ExpAmt) AS Amount, 'Expense' AS Type FROM Expense"


            ' Create a SqlCommand and execute the query
            Using cmd As New SqlCommand(query, connection)
                ' Create a DataTable to hold the data
                Dim dataTable As New DataTable()

                ' Use a DataAdapter to fill the DataTable
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using

                ' Set the data source for your chart
                Chart1.DataSource = dataTable

                ' Set the X and Y values for the chart
                Chart1.Series(0).XValueMember = "Type" ' Use the alias "Type" from your SQL query
                Chart1.Series(0).YValueMembers = "Amount"

                ' Set the chart type to Pie
                Chart1.Series(0).ChartType = SeriesChartType.Pie


                ' Optionally, set chart properties like titles
                Chart1.Titles.Add("Income by Category")

                ' Refresh the chart to display the data
                Chart1.DataBind()
            End Using
        End Using
    End Sub

    Private Sub Chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualizeData()
    End Sub

    Private Sub VisualizeExpInc()
        Dim connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Pneumatica Richie\Documents\ExpenseTracker.mdf;Integrated Security=True;Connect Timeout=30"
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim query As String = "SELECT DATEPART(MONTH, IncDate) As Month, DATEPART(YEAR, IncDate) As Year, SUM(IncAmt) As TotalIncome " &
                         "FROM Income " &
                         "GROUP BY DATEPART(MONTH, IncDate), DATEPART(YEAR, IncDate)"
            Using cmd As New SqlCommand(query, connection)
                ' Create a DataTable to hold the data
                Dim dataTable As New DataTable()

                ' Use a DataAdapter to fill the DataTable
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using

                ' Set the data source for your chart
                Chart2.DataSource = dataTable

                ' Set the X and Y values for the chart
                Chart2.Series(0).XValueMember = "Month" ' Use an alias "MonthYear" from your SQL query
                Chart2.Series(0).YValueMembers = "TotalIncome" ' Use an alias "TotalAmount" from your SQL query

                ' Set the chart type to Column (or any suitable chart type)
                Chart2.Series(0).ChartType = SeriesChartType.Column

                ' Optionally, set chart properties like titles and labels
                Chart2.Titles.Add("Income Over Time")
                Chart2.Series(0).XValueType = ChartValueType.String ' Use string as the X value type for month/year labels
                Chart2.Series(0).IsValueShownAsLabel = True ' Display data labels on the columns
                ' Set the color of the expense column (red)

                ' Refresh the chart to display the data
                Chart2.DataBind()

            End Using
        End Using

    End Sub

    Private Sub IncExp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisualizeExpInc()
    End Sub

    Private Sub HighIncome_Click(sender As Object, e As EventArgs) Handles HighIncome.Click

    End Sub
End Class