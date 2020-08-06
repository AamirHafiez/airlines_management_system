<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.INSERTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Attributes = New System.Windows.Forms.Panel()
        Me.TextBox_ImpID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_ExpID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_ProdID = New System.Windows.Forms.TextBox()
        Me.TextBox_ProdName = New System.Windows.Forms.TextBox()
        Me.TextBox_PricePerProd = New System.Windows.Forms.TextBox()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.Button_LoadTable = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel_Update = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Panel_Delete = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.Panel_Save = New System.Windows.Forms.Panel()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.ToolTip_Refresh = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label_Welcome = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_Attributes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Update.SuspendLayout()
        Me.Panel_Delete.SuspendLayout()
        Me.Panel_Save.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERTToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.BACKToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'INSERTToolStripMenuItem
        '
        Me.INSERTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.INSERTToolStripMenuItem.Name = "INSERTToolStripMenuItem"
        Me.INSERTToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.INSERTToolStripMenuItem.Text = "INSERT"
        '
        'UPDATEToolStripMenuItem
        '
        Me.UPDATEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UPDATEToolStripMenuItem.Name = "UPDATEToolStripMenuItem"
        Me.UPDATEToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.UPDATEToolStripMenuItem.Text = "UPDATE"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'Panel_Attributes
        '
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ImpID)
        Me.Panel_Attributes.Controls.Add(Me.Label6)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ExpID)
        Me.Panel_Attributes.Controls.Add(Me.Label2)
        Me.Panel_Attributes.Controls.Add(Me.Label5)
        Me.Panel_Attributes.Controls.Add(Me.Label4)
        Me.Panel_Attributes.Controls.Add(Me.Label3)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ProdID)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ProdName)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_PricePerProd)
        Me.Panel_Attributes.Location = New System.Drawing.Point(0, 27)
        Me.Panel_Attributes.Name = "Panel_Attributes"
        Me.Panel_Attributes.Size = New System.Drawing.Size(423, 159)
        Me.Panel_Attributes.TabIndex = 15
        Me.Panel_Attributes.Visible = False
        '
        'TextBox_ImpID
        '
        Me.TextBox_ImpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ImpID.Location = New System.Drawing.Point(209, 71)
        Me.TextBox_ImpID.Name = "TextBox_ImpID"
        Me.TextBox_ImpID.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ImpID.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 18)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "IMPORTER ID*"
        '
        'TextBox_ExpID
        '
        Me.TextBox_ExpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ExpID.Location = New System.Drawing.Point(209, 99)
        Me.TextBox_ExpID.Name = "TextBox_ExpID"
        Me.TextBox_ExpID.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ExpID.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "EXPORTER ID*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "PRICE PER PRODUCT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PRODUCT NAME*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "PRODUCT ID*"
        '
        'TextBox_ProdID
        '
        Me.TextBox_ProdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProdID.Location = New System.Drawing.Point(209, 12)
        Me.TextBox_ProdID.Name = "TextBox_ProdID"
        Me.TextBox_ProdID.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ProdID.TabIndex = 5
        '
        'TextBox_ProdName
        '
        Me.TextBox_ProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProdName.Location = New System.Drawing.Point(209, 40)
        Me.TextBox_ProdName.Name = "TextBox_ProdName"
        Me.TextBox_ProdName.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ProdName.TabIndex = 6
        '
        'TextBox_PricePerProd
        '
        Me.TextBox_PricePerProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_PricePerProd.Location = New System.Drawing.Point(209, 127)
        Me.TextBox_PricePerProd.Name = "TextBox_PricePerProd"
        Me.TextBox_PricePerProd.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_PricePerProd.TabIndex = 7
        '
        'Button_Reset
        '
        Me.Button_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reset.Location = New System.Drawing.Point(336, 192)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reset.TabIndex = 25
        Me.Button_Reset.Text = "RESET"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'Button_LoadTable
        '
        Me.Button_LoadTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_LoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_LoadTable.Image = CType(resources.GetObject("Button_LoadTable.Image"), System.Drawing.Image)
        Me.Button_LoadTable.Location = New System.Drawing.Point(368, 221)
        Me.Button_LoadTable.Name = "Button_LoadTable"
        Me.Button_LoadTable.Size = New System.Drawing.Size(43, 34)
        Me.Button_LoadTable.TabIndex = 26
        Me.Button_LoadTable.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 261)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(423, 107)
        Me.DataGridView1.TabIndex = 27
        '
        'Panel_Update
        '
        Me.Panel_Update.Controls.Add(Me.Label14)
        Me.Panel_Update.Controls.Add(Me.Button_Update)
        Me.Panel_Update.Location = New System.Drawing.Point(12, 192)
        Me.Panel_Update.Name = "Panel_Update"
        Me.Panel_Update.Size = New System.Drawing.Size(318, 35)
        Me.Panel_Update.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(84, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(221, 16)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "(Update through PRODUCT ID)"
        '
        'Button_Update
        '
        Me.Button_Update.Location = New System.Drawing.Point(3, 9)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Update.TabIndex = 0
        Me.Button_Update.Text = "UPDATE"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'Panel_Delete
        '
        Me.Panel_Delete.Controls.Add(Me.Label1)
        Me.Panel_Delete.Controls.Add(Me.Button_Delete)
        Me.Panel_Delete.Location = New System.Drawing.Point(12, 192)
        Me.Panel_Delete.Name = "Panel_Delete"
        Me.Panel_Delete.Size = New System.Drawing.Size(318, 35)
        Me.Panel_Delete.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(84, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(Delete through PRODUCT ID)"
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(3, 9)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Delete.TabIndex = 0
        Me.Button_Delete.Text = "DELETE"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'Panel_Save
        '
        Me.Panel_Save.Controls.Add(Me.Button_Save)
        Me.Panel_Save.Location = New System.Drawing.Point(12, 192)
        Me.Panel_Save.Name = "Panel_Save"
        Me.Panel_Save.Size = New System.Drawing.Size(318, 35)
        Me.Panel_Save.TabIndex = 31
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(3, 9)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 0
        Me.Button_Save.Text = "SAVE"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Label_Welcome
        '
        Me.Label_Welcome.AutoSize = True
        Me.Label_Welcome.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Welcome.Location = New System.Drawing.Point(3, 62)
        Me.Label_Welcome.Name = "Label_Welcome"
        Me.Label_Welcome.Size = New System.Drawing.Size(420, 24)
        Me.Label_Welcome.TabIndex = 32
        Me.Label_Welcome.Text = "WELCOME SELECT OPTIONS FROM ABOVE"
        '
        'ProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(434, 373)
        Me.Controls.Add(Me.Label_Welcome)
        Me.Controls.Add(Me.Panel_Delete)
        Me.Controls.Add(Me.Panel_Save)
        Me.Controls.Add(Me.Panel_Update)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button_LoadTable)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Panel_Attributes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ProductForm"
        Me.Opacity = 0.91R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_Attributes.ResumeLayout(False)
        Me.Panel_Attributes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Update.ResumeLayout(False)
        Me.Panel_Update.PerformLayout()
        Me.Panel_Delete.ResumeLayout(False)
        Me.Panel_Delete.PerformLayout()
        Me.Panel_Save.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents INSERTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Attributes As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_ProdID As TextBox
    Friend WithEvents TextBox_ProdName As TextBox
    Friend WithEvents TextBox_PricePerProd As TextBox
    Friend WithEvents Button_Reset As Button
    Friend WithEvents Button_LoadTable As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel_Update As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Button_Update As Button
    Friend WithEvents Panel_Delete As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_Delete As Button
    Friend WithEvents Panel_Save As Panel
    Friend WithEvents Button_Save As Button
    Friend WithEvents ToolTip_Refresh As ToolTip
    Friend WithEvents Label_Welcome As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ExpID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_ImpID As TextBox
End Class
