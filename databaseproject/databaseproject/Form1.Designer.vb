<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Login))
        Me.Button_TestConn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Username = New System.Windows.Forms.TextBox()
        Me.TextBox_Password = New System.Windows.Forms.TextBox()
        Me.CheckBox_Show = New System.Windows.Forms.CheckBox()
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_TestConn
        '
        Me.Button_TestConn.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button_TestConn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_TestConn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_TestConn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_TestConn.Location = New System.Drawing.Point(459, 300)
        Me.Button_TestConn.Name = "Button_TestConn"
        Me.Button_TestConn.Size = New System.Drawing.Size(111, 23)
        Me.Button_TestConn.TabIndex = 0
        Me.Button_TestConn.Text = "Test Connection"
        Me.Button_TestConn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(119, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IMPORT EXPORT DATABASE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(82, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "USERNAME :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(82, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "PASSWORD :"
        '
        'TextBox_Username
        '
        Me.TextBox_Username.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Username.ForeColor = System.Drawing.SystemColors.InfoText
        Me.TextBox_Username.Location = New System.Drawing.Point(191, 110)
        Me.TextBox_Username.Name = "TextBox_Username"
        Me.TextBox_Username.Size = New System.Drawing.Size(200, 22)
        Me.TextBox_Username.TabIndex = 4
        '
        'TextBox_Password
        '
        Me.TextBox_Password.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TextBox_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Password.Location = New System.Drawing.Point(191, 149)
        Me.TextBox_Password.Name = "TextBox_Password"
        Me.TextBox_Password.Size = New System.Drawing.Size(200, 22)
        Me.TextBox_Password.TabIndex = 5
        Me.TextBox_Password.UseSystemPasswordChar = True
        '
        'CheckBox_Show
        '
        Me.CheckBox_Show.AutoSize = True
        Me.CheckBox_Show.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_Show.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CheckBox_Show.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox_Show.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Show.ForeColor = System.Drawing.Color.DimGray
        Me.CheckBox_Show.Location = New System.Drawing.Point(397, 154)
        Me.CheckBox_Show.Name = "CheckBox_Show"
        Me.CheckBox_Show.Size = New System.Drawing.Size(50, 13)
        Me.CheckBox_Show.TabIndex = 6
        Me.CheckBox_Show.Text = "SHOW"
        Me.CheckBox_Show.UseVisualStyleBackColor = False
        '
        'Button_Login
        '
        Me.Button_Login.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Login.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button_Login.Location = New System.Drawing.Point(246, 190)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(75, 23)
        Me.Button_Login.TabIndex = 7
        Me.Button_Login.Text = "SIGN IN"
        Me.Button_Login.UseVisualStyleBackColor = False
        '
        'Button_Exit
        '
        Me.Button_Exit.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button_Exit.Location = New System.Drawing.Point(12, 300)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(111, 23)
        Me.Button_Exit.TabIndex = 8
        Me.Button_Exit.Text = "EXIT"
        Me.Button_Exit.UseVisualStyleBackColor = False
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 335)
        Me.Controls.Add(Me.Button_Exit)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.CheckBox_Show)
        Me.Controls.Add(Me.TextBox_Password)
        Me.Controls.Add(Me.TextBox_Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_TestConn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_Login"
        Me.Opacity = 0.93R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_TestConn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents CheckBox_Show As CheckBox
    Friend WithEvents Button_Login As Button
    Friend WithEvents Button_Exit As Button
End Class
