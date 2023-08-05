<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Create = New LinkLabel()
        SignIn = New Button()
        Pass = New TextBox()
        User = New TextBox()
        Button1 = New Button()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.WhatsApp_Image_2023_06_29_at_14_20_19
        PictureBox1.Location = New Point(12, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 56)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(114, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 30)
        Label1.TabIndex = 1
        Label1.Text = "eXpense Tracker"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Window
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(24, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 25)
        Label2.TabIndex = 9
        Label2.Text = "WELCOME BACK!!!"
        ' 
        ' Create
        ' 
        Create.AutoSize = True
        Create.Location = New Point(134, 350)
        Create.Name = "Create"
        Create.Size = New Size(105, 15)
        Create.TabIndex = 8
        Create.TabStop = True
        Create.Text = "Create an Account"
        ' 
        ' SignIn
        ' 
        SignIn.BackColor = Color.Navy
        SignIn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        SignIn.ForeColor = Color.White
        SignIn.Location = New Point(24, 281)
        SignIn.Name = "SignIn"
        SignIn.Size = New Size(334, 37)
        SignIn.TabIndex = 7
        SignIn.Text = "SIGN IN"
        SignIn.UseVisualStyleBackColor = False
        ' 
        ' Pass
        ' 
        Pass.Location = New Point(24, 215)
        Pass.Multiline = True
        Pass.Name = "Pass"
        Pass.Size = New Size(334, 37)
        Pass.TabIndex = 6
        Pass.Text = "Password"
        Pass.UseWaitCursor = True
        ' 
        ' User
        ' 
        User.Location = New Point(24, 155)
        User.Multiline = True
        User.Name = "User"
        User.Size = New Size(334, 37)
        User.TabIndex = 5
        User.Text = "Username"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(336, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(41, 29)
        Button1.TabIndex = 10
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(319, 215)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(29, 22)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(382, 453)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Create)
        Controls.Add(SignIn)
        Controls.Add(Pass)
        Controls.Add(User)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Xpense Tracker"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Create As LinkLabel
    Friend WithEvents SignIn As Button
    Friend WithEvents Pass As TextBox
    Friend WithEvents User As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
