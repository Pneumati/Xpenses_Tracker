<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddIncome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        IncDate = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Category = New ComboBox()
        Amt = New TextBox()
        AddInc = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(130, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 35)
        Button1.TabIndex = 17
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(239, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 16
        Label4.Text = "Category"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(239, 102)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 17)
        Label3.TabIndex = 15
        Label3.Text = "Date"
        ' 
        ' IncDate
        ' 
        IncDate.Format = DateTimePickerFormat.Short
        IncDate.Location = New Point(239, 133)
        IncDate.Name = "IncDate"
        IncDate.Size = New Size(121, 23)
        IncDate.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(22, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(58, 17)
        Label2.TabIndex = 13
        Label2.Text = "Amount"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(22, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 17)
        Label1.TabIndex = 12
        Label1.Text = "Income Name"
        ' 
        ' Category
        ' 
        Category.FormattingEnabled = True
        Category.Items.AddRange(New Object() {"Salary", "Allowances", "Stipend", "Bonuses"})
        Category.Location = New Point(239, 51)
        Category.Name = "Category"
        Category.Size = New Size(121, 23)
        Category.TabIndex = 11
        ' 
        ' Amt
        ' 
        Amt.Location = New Point(22, 133)
        Amt.Name = "Amt"
        Amt.Size = New Size(119, 23)
        Amt.TabIndex = 10
        ' 
        ' AddInc
        ' 
        AddInc.Location = New Point(22, 51)
        AddInc.Multiline = True
        AddInc.Name = "AddInc"
        AddInc.Size = New Size(119, 23)
        AddInc.TabIndex = 9
        ' 
        ' AddIncome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 265)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(IncDate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Category)
        Controls.Add(Amt)
        Controls.Add(AddInc)
        Name = "AddIncome"
        Text = "AddIncome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IncDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Category As ComboBox
    Friend WithEvents Amt As TextBox
    Friend WithEvents AddInc As TextBox
End Class
