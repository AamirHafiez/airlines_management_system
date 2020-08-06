<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.Button_SignOut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Importer = New System.Windows.Forms.Button()
        Me.Button_Product = New System.Windows.Forms.Button()
        Me.Button_Expoter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip_SignOut = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Button_SignOut
        '
        Me.Button_SignOut.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button_SignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_SignOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_SignOut.Image = CType(resources.GetObject("Button_SignOut.Image"), System.Drawing.Image)
        Me.Button_SignOut.Location = New System.Drawing.Point(611, 12)
        Me.Button_SignOut.Name = "Button_SignOut"
        Me.Button_SignOut.Size = New System.Drawing.Size(64, 59)
        Me.Button_SignOut.TabIndex = 0
        Me.Button_SignOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Mistral", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CHOOSE DATABASE"
        '
        'Button_Importer
        '
        Me.Button_Importer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Importer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Importer.Image = CType(resources.GetObject("Button_Importer.Image"), System.Drawing.Image)
        Me.Button_Importer.Location = New System.Drawing.Point(78, 117)
        Me.Button_Importer.Name = "Button_Importer"
        Me.Button_Importer.Size = New System.Drawing.Size(117, 102)
        Me.Button_Importer.TabIndex = 3
        Me.Button_Importer.UseVisualStyleBackColor = True
        '
        'Button_Product
        '
        Me.Button_Product.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Product.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Product.Image = CType(resources.GetObject("Button_Product.Image"), System.Drawing.Image)
        Me.Button_Product.Location = New System.Drawing.Point(272, 117)
        Me.Button_Product.Name = "Button_Product"
        Me.Button_Product.Size = New System.Drawing.Size(117, 102)
        Me.Button_Product.TabIndex = 4
        Me.Button_Product.UseVisualStyleBackColor = True
        '
        'Button_Expoter
        '
        Me.Button_Expoter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Expoter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Expoter.Image = CType(resources.GetObject("Button_Expoter.Image"), System.Drawing.Image)
        Me.Button_Expoter.Location = New System.Drawing.Point(466, 117)
        Me.Button_Expoter.Name = "Button_Expoter"
        Me.Button_Expoter.Size = New System.Drawing.Size(117, 102)
        Me.Button_Expoter.TabIndex = 5
        Me.Button_Expoter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Pink
        Me.Label3.Location = New System.Drawing.Point(94, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IMPORTER"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Pink
        Me.Label4.Location = New System.Drawing.Point(284, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PRODUCT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Pink
        Me.Label5.Location = New System.Drawing.Point(478, 239)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EXPORTER"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(687, 387)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_Expoter)
        Me.Controls.Add(Me.Button_Product)
        Me.Controls.Add(Me.Button_Importer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_SignOut)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainMenu"
        Me.Opacity = 0.93R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_SignOut As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Importer As Button
    Friend WithEvents Button_Product As Button
    Friend WithEvents Button_Expoter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolTip_SignOut As ToolTip
End Class
