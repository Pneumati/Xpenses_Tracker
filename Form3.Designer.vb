<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Username = New TextBox()
        Email = New TextBox()
        Password = New TextBox()
        Cp = New TextBox()
        Signup = New Button()
        LinkLabel1 = New LinkLabel()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Username
        ' 
        Username.Location = New Point(26, 84)
        Username.Multiline = True
        Username.Name = "Username"
        Username.Size = New Size(306, 46)
        Username.TabIndex = 1
        Username.Text = "Username"
        ' 
        ' Email
        ' 
        Email.Location = New Point(26, 136)
        Email.Multiline = True
        Email.Name = "Email"
        Email.Size = New Size(306, 46)
        Email.TabIndex = 2
        Email.Text = "Email Address"
        ' 
        ' Password
        ' 
        Password.Location = New Point(26, 192)
        Password.Multiline = True
        Password.Name = "Password"
        Password.Size = New Size(306, 46)
        Password.TabIndex = 3
        Password.Text = "Password"
        ' 
        ' Cp
        ' 
        Cp.Location = New Point(26, 248)
        Cp.Multiline = True
        Cp.Name = "Cp"
        Cp.Size = New Size(306, 46)
        Cp.TabIndex = 4
        Cp.Text = "Confirm Password"
        ' 
        ' Signup
        ' 
        Signup.BackColor = Color.Navy
        Signup.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Signup.ForeColor = Color.White
        Signup.Location = New Point(26, 303)
        Signup.Name = "Signup"
        Signup.Size = New Size(306, 46)
        Signup.TabIndex = 5
        Signup.Text = "SIGN UP"
        Signup.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(105, 363)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(187, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Already have an account? Sign in!!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Window
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(28, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(264, 32)
        Label1.TabIndex = 7
        Label1.Text = "CREATE AN ACCOUNT"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(366, 414)
        Controls.Add(Label1)
        Controls.Add(LinkLabel1)
        Controls.Add(Signup)
        Controls.Add(Cp)
        Controls.Add(Password)
        Controls.Add(Email)
        Controls.Add(Username)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Username As TextBox
    Friend WithEvents Email As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents Cp As TextBox
    Friend WithEvents Signup As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
