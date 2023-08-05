<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddExpenses
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
        ExpAdd = New Button()
        ExpCat = New Label()
        ExpDate = New Label()
        ExxpDate = New DateTimePicker()
        ExpAmt = New Label()
        AddExp = New Label()
        ExpCategory = New ComboBox()
        Amt = New TextBox()
        ExpName = New TextBox()
        SuspendLayout()
        ' 
        ' ExpAdd
        ' 
        ExpAdd.BackColor = Color.Navy
        ExpAdd.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExpAdd.ForeColor = Color.White
        ExpAdd.Location = New Point(130, 207)
        ExpAdd.Name = "ExpAdd"
        ExpAdd.Size = New Size(137, 35)
        ExpAdd.TabIndex = 26
        ExpAdd.Text = "Add"
        ExpAdd.UseVisualStyleBackColor = False
        ' 
        ' ExpCat
        ' 
        ExpCat.AutoSize = True
        ExpCat.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExpCat.Location = New Point(239, 23)
        ExpCat.Name = "ExpCat"
        ExpCat.Size = New Size(64, 17)
        ExpCat.TabIndex = 25
        ExpCat.Text = "Category"
        ' 
        ' ExpDate
        ' 
        ExpDate.AutoSize = True
        ExpDate.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExpDate.Location = New Point(239, 102)
        ExpDate.Name = "ExpDate"
        ExpDate.Size = New Size(37, 17)
        ExpDate.TabIndex = 24
        ExpDate.Text = "Date"
        ' 
        ' ExxpDate
        ' 
        ExxpDate.Format = DateTimePickerFormat.Short
        ExxpDate.Location = New Point(239, 133)
        ExxpDate.Name = "ExxpDate"
        ExxpDate.Size = New Size(121, 23)
        ExxpDate.TabIndex = 23
        ' 
        ' ExpAmt
        ' 
        ExpAmt.AutoSize = True
        ExpAmt.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExpAmt.Location = New Point(22, 102)
        ExpAmt.Name = "ExpAmt"
        ExpAmt.Size = New Size(58, 17)
        ExpAmt.TabIndex = 22
        ExpAmt.Text = "Amount"
        ' 
        ' AddExp
        ' 
        AddExp.AutoSize = True
        AddExp.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        AddExp.Location = New Point(22, 23)
        AddExp.Name = "AddExp"
        AddExp.Size = New Size(93, 17)
        AddExp.TabIndex = 21
        AddExp.Text = "Add Expenses"
        ' 
        ' ExpCategory
        ' 
        ExpCategory.FormattingEnabled = True
        ExpCategory.Items.AddRange(New Object() {"Food & Groceries", "Travelling", "Utility (Electricity, Water)", "Internet Bundle", "Miscellanious"})
        ExpCategory.Location = New Point(239, 51)
        ExpCategory.Name = "ExpCategory"
        ExpCategory.Size = New Size(121, 23)
        ExpCategory.TabIndex = 20
        ' 
        ' Amt
        ' 
        Amt.Location = New Point(22, 133)
        Amt.Name = "Amt"
        Amt.Size = New Size(119, 23)
        Amt.TabIndex = 19
        ' 
        ' ExpName
        ' 
        ExpName.Location = New Point(22, 51)
        ExpName.Multiline = True
        ExpName.Name = "ExpName"
        ExpName.Size = New Size(119, 23)
        ExpName.TabIndex = 18
        ' 
        ' AddExpenses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 265)
        Controls.Add(ExpAdd)
        Controls.Add(ExpCat)
        Controls.Add(ExpDate)
        Controls.Add(ExxpDate)
        Controls.Add(ExpAmt)
        Controls.Add(AddExp)
        Controls.Add(ExpCategory)
        Controls.Add(Amt)
        Controls.Add(ExpName)
        Name = "AddExpenses"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddExpenses"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ExpAdd As Button
    Friend WithEvents ExpCat As Label
    Friend WithEvents ExpDate As Label
    Friend WithEvents ExxpDate As DateTimePicker
    Friend WithEvents ExpAmt As Label
    Friend WithEvents AddExp As Label
    Friend WithEvents ExpCategory As ComboBox
    Friend WithEvents Amt As TextBox
    Friend WithEvents ExpName As TextBox
End Class
