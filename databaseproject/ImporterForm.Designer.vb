<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ImporterForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImporterForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.INSERTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UPDATEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMPORTANDPRODUCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BACKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Save = New System.Windows.Forms.Panel()
        Me.Button_Save = New System.Windows.Forms.Button()
        Me.Panel_Update = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button_Update = New System.Windows.Forms.Button()
        Me.Panel_Delete = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button_Delete = New System.Windows.Forms.Button()
        Me.TextBox_ImpID = New System.Windows.Forms.TextBox()
        Me.TextBox_ExpID = New System.Windows.Forms.TextBox()
        Me.TextBox_ProdID = New System.Windows.Forms.TextBox()
        Me.TextBox_ProdName = New System.Windows.Forms.TextBox()
        Me.TextBox_ProdQuant = New System.Windows.Forms.TextBox()
        Me.TextBox_ImpAdd = New System.Windows.Forms.TextBox()
        Me.TextBox_Charges = New System.Windows.Forms.TextBox()
        Me.TextBox_ImpContact = New System.Windows.Forms.TextBox()
        Me.Panel_Attributes = New System.Windows.Forms.Panel()
        Me.DateTimePicker_Departure = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_Arrival = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Welcome = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_LoadTable = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox_Search = New System.Windows.Forms.TextBox()
        Me.ToolTip_Refresh = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel_Save.SuspendLayout()
        Me.Panel_Update.SuspendLayout()
        Me.Panel_Delete.SuspendLayout()
        Me.Panel_Attributes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INSERTToolStripMenuItem, Me.UPDATEToolStripMenuItem, Me.DELETEToolStripMenuItem, Me.IMPORTANDPRODUCTToolStripMenuItem, Me.BACKToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 0
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
        'IMPORTANDPRODUCTToolStripMenuItem
        '
        Me.IMPORTANDPRODUCTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IMPORTANDPRODUCTToolStripMenuItem.Name = "IMPORTANDPRODUCTToolStripMenuItem"
        Me.IMPORTANDPRODUCTToolStripMenuItem.Size = New System.Drawing.Size(148, 20)
        Me.IMPORTANDPRODUCTToolStripMenuItem.Text = "IMPORT AND PRODUCT"
        '
        'BACKToolStripMenuItem
        '
        Me.BACKToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BACKToolStripMenuItem.Name = "BACKToolStripMenuItem"
        Me.BACKToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.BACKToolStripMenuItem.Text = "BACK"
        '
        'Panel_Save
        '
        Me.Panel_Save.Controls.Add(Me.Button_Save)
        Me.Panel_Save.Location = New System.Drawing.Point(54, 318)
        Me.Panel_Save.Name = "Panel_Save"
        Me.Panel_Save.Size = New System.Drawing.Size(359, 35)
        Me.Panel_Save.TabIndex = 1
        '
        'Button_Save
        '
        Me.Button_Save.Location = New System.Drawing.Point(265, 3)
        Me.Button_Save.Name = "Button_Save"
        Me.Button_Save.Size = New System.Drawing.Size(75, 23)
        Me.Button_Save.TabIndex = 0
        Me.Button_Save.Text = "SAVE"
        Me.Button_Save.UseVisualStyleBackColor = True
        '
        'Panel_Update
        '
        Me.Panel_Update.Controls.Add(Me.Label11)
        Me.Panel_Update.Controls.Add(Me.Button_Update)
        Me.Panel_Update.Location = New System.Drawing.Point(54, 318)
        Me.Panel_Update.Name = "Panel_Update"
        Me.Panel_Update.Size = New System.Drawing.Size(359, 35)
        Me.Panel_Update.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label11.Location = New System.Drawing.Point(3, 10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(232, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "(UPDATE through PRODUCT ID)"
        '
        'Button_Update
        '
        Me.Button_Update.Location = New System.Drawing.Point(265, 7)
        Me.Button_Update.Name = "Button_Update"
        Me.Button_Update.Size = New System.Drawing.Size(75, 23)
        Me.Button_Update.TabIndex = 0
        Me.Button_Update.Text = "UPDATE"
        Me.Button_Update.UseVisualStyleBackColor = True
        '
        'Panel_Delete
        '
        Me.Panel_Delete.Controls.Add(Me.Label12)
        Me.Panel_Delete.Controls.Add(Me.Button_Delete)
        Me.Panel_Delete.Location = New System.Drawing.Point(54, 318)
        Me.Panel_Delete.Name = "Panel_Delete"
        Me.Panel_Delete.Size = New System.Drawing.Size(359, 35)
        Me.Panel_Delete.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(3, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(216, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "(Delete through PRODUCT ID)"
        '
        'Button_Delete
        '
        Me.Button_Delete.Location = New System.Drawing.Point(265, 6)
        Me.Button_Delete.Name = "Button_Delete"
        Me.Button_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Button_Delete.TabIndex = 0
        Me.Button_Delete.Text = "DELETE"
        Me.Button_Delete.UseVisualStyleBackColor = True
        '
        'TextBox_ImpID
        '
        Me.TextBox_ImpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ImpID.Location = New System.Drawing.Point(209, 3)
        Me.TextBox_ImpID.Name = "TextBox_ImpID"
        Me.TextBox_ImpID.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ImpID.TabIndex = 3
        '
        'TextBox_ExpID
        '
        Me.TextBox_ExpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ExpID.Location = New System.Drawing.Point(209, 29)
        Me.TextBox_ExpID.Name = "TextBox_ExpID"
        Me.TextBox_ExpID.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ExpID.TabIndex = 4
        '
        'TextBox_ProdID
        '
        Me.TextBox_ProdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProdID.Location = New System.Drawing.Point(209, 55)
        Me.TextBox_ProdID.Name = "TextBox_ProdID"
        Me.TextBox_ProdID.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ProdID.TabIndex = 5
        '
        'TextBox_ProdName
        '
        Me.TextBox_ProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProdName.Location = New System.Drawing.Point(209, 81)
        Me.TextBox_ProdName.Name = "TextBox_ProdName"
        Me.TextBox_ProdName.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ProdName.TabIndex = 6
        '
        'TextBox_ProdQuant
        '
        Me.TextBox_ProdQuant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ProdQuant.Location = New System.Drawing.Point(209, 107)
        Me.TextBox_ProdQuant.Name = "TextBox_ProdQuant"
        Me.TextBox_ProdQuant.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ProdQuant.TabIndex = 7
        '
        'TextBox_ImpAdd
        '
        Me.TextBox_ImpAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ImpAdd.Location = New System.Drawing.Point(209, 133)
        Me.TextBox_ImpAdd.Name = "TextBox_ImpAdd"
        Me.TextBox_ImpAdd.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ImpAdd.TabIndex = 8
        '
        'TextBox_Charges
        '
        Me.TextBox_Charges.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Charges.Location = New System.Drawing.Point(209, 159)
        Me.TextBox_Charges.Name = "TextBox_Charges"
        Me.TextBox_Charges.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_Charges.TabIndex = 9
        '
        'TextBox_ImpContact
        '
        Me.TextBox_ImpContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ImpContact.Location = New System.Drawing.Point(209, 237)
        Me.TextBox_ImpContact.Name = "TextBox_ImpContact"
        Me.TextBox_ImpContact.Size = New System.Drawing.Size(191, 22)
        Me.TextBox_ImpContact.TabIndex = 12
        '
        'Panel_Attributes
        '
        Me.Panel_Attributes.Controls.Add(Me.DateTimePicker_Departure)
        Me.Panel_Attributes.Controls.Add(Me.DateTimePicker_Arrival)
        Me.Panel_Attributes.Controls.Add(Me.Label10)
        Me.Panel_Attributes.Controls.Add(Me.Label9)
        Me.Panel_Attributes.Controls.Add(Me.Label8)
        Me.Panel_Attributes.Controls.Add(Me.Label7)
        Me.Panel_Attributes.Controls.Add(Me.Label6)
        Me.Panel_Attributes.Controls.Add(Me.Label5)
        Me.Panel_Attributes.Controls.Add(Me.Label4)
        Me.Panel_Attributes.Controls.Add(Me.Label3)
        Me.Panel_Attributes.Controls.Add(Me.Label2)
        Me.Panel_Attributes.Controls.Add(Me.Label1)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ImpID)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ImpContact)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ExpID)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ProdID)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ProdName)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_Charges)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ProdQuant)
        Me.Panel_Attributes.Controls.Add(Me.TextBox_ImpAdd)
        Me.Panel_Attributes.Location = New System.Drawing.Point(7, 36)
        Me.Panel_Attributes.Name = "Panel_Attributes"
        Me.Panel_Attributes.Size = New System.Drawing.Size(443, 276)
        Me.Panel_Attributes.TabIndex = 13
        '
        'DateTimePicker_Departure
        '
        Me.DateTimePicker_Departure.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_Departure.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Departure.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Departure.Location = New System.Drawing.Point(209, 214)
        Me.DateTimePicker_Departure.Name = "DateTimePicker_Departure"
        Me.DateTimePicker_Departure.Size = New System.Drawing.Size(118, 22)
        Me.DateTimePicker_Departure.TabIndex = 24
        '
        'DateTimePicker_Arrival
        '
        Me.DateTimePicker_Arrival.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker_Arrival.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker_Arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker_Arrival.Location = New System.Drawing.Point(209, 188)
        Me.DateTimePicker_Arrival.Name = "DateTimePicker_Arrival"
        Me.DateTimePicker_Arrival.Size = New System.Drawing.Size(118, 22)
        Me.DateTimePicker_Arrival.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "CHARGES"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(179, 18)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "IMPORTER CONTACT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 18)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "DEPARTURE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "ARRIVAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "IMPORTER ADDRESS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "PRODUCT QUANTITY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PRODUCT NAME*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "PRODUCT ID*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "EXPORTER ID*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "IMPORTER ID*"
        '
        'Label_Welcome
        '
        Me.Label_Welcome.AutoSize = True
        Me.Label_Welcome.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Welcome.Location = New System.Drawing.Point(12, 106)
        Me.Label_Welcome.Name = "Label_Welcome"
        Me.Label_Welcome.Size = New System.Drawing.Size(438, 25)
        Me.Label_Welcome.TabIndex = 14
        Me.Label_Welcome.Text = "WELCOME SELECT OPTIONS FROM ABOVE"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(456, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(464, 245)
        Me.DataGridView1.TabIndex = 15
        '
        'Button_LoadTable
        '
        Me.Button_LoadTable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_LoadTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_LoadTable.Image = CType(resources.GetObject("Button_LoadTable.Image"), System.Drawing.Image)
        Me.Button_LoadTable.Location = New System.Drawing.Point(877, 25)
        Me.Button_LoadTable.Name = "Button_LoadTable"
        Me.Button_LoadTable.Size = New System.Drawing.Size(43, 34)
        Me.Button_LoadTable.TabIndex = 16
        Me.Button_LoadTable.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label13.Location = New System.Drawing.Point(453, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(203, 16)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "SEARCH PRODUCT NAME :"
        '
        'TextBox_Search
        '
        Me.TextBox_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Search.Location = New System.Drawing.Point(662, 321)
        Me.TextBox_Search.Name = "TextBox_Search"
        Me.TextBox_Search.Size = New System.Drawing.Size(258, 24)
        Me.TextBox_Search.TabIndex = 18
        '
        'Button_Reset
        '
        Me.Button_Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button_Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reset.Location = New System.Drawing.Point(456, 36)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.Button_Reset.TabIndex = 25
        Me.Button_Reset.Text = "RESET"
        Me.Button_Reset.UseVisualStyleBackColor = True
        '
        'ImporterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(932, 358)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.TextBox_Search)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button_LoadTable)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label_Welcome)
        Me.Controls.Add(Me.Panel_Attributes)
        Me.Controls.Add(Me.Panel_Delete)
        Me.Controls.Add(Me.Panel_Update)
        Me.Controls.Add(Me.Panel_Save)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "ImporterForm"
        Me.Opacity = 0.91R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel_Save.ResumeLayout(False)
        Me.Panel_Update.ResumeLayout(False)
        Me.Panel_Update.PerformLayout()
        Me.Panel_Delete.ResumeLayout(False)
        Me.Panel_Delete.PerformLayout()
        Me.Panel_Attributes.ResumeLayout(False)
        Me.Panel_Attributes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents INSERTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UPDATEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IMPORTANDPRODUCTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Save As Panel
    Friend WithEvents Button_Save As Button
    Friend WithEvents BACKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Update As Panel
    Friend WithEvents Button_Update As Button
    Friend WithEvents Panel_Delete As Panel
    Friend WithEvents Button_Delete As Button
    Friend WithEvents TextBox_ImpID As TextBox
    Friend WithEvents TextBox_ExpID As TextBox
    Friend WithEvents TextBox_ProdID As TextBox
    Friend WithEvents TextBox_ProdName As TextBox
    Friend WithEvents TextBox_ProdQuant As TextBox
    Friend WithEvents TextBox_ImpAdd As TextBox
    Friend WithEvents TextBox_Charges As TextBox
    Friend WithEvents TextBox_ImpContact As TextBox
    Friend WithEvents Panel_Attributes As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker_Departure As DateTimePicker
    Friend WithEvents DateTimePicker_Arrival As DateTimePicker
    Friend WithEvents Label_Welcome As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_LoadTable As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox_Search As TextBox
    Friend WithEvents ToolTip_Refresh As ToolTip
    Friend WithEvents Button_Reset As Button
End Class
