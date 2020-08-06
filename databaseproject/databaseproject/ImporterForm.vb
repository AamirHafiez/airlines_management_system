Imports MySql.Data.MySqlClient
Public Class ImporterForm

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Public Function Clearing_Textboxes()
        TextBox_Charges.Clear()
        TextBox_ImpContact.Clear()
        TextBox_ExpID.Clear()
        TextBox_ImpAdd.Clear()
        TextBox_ImpID.Clear()
        TextBox_ProdName.Clear()
        TextBox_ProdID.Clear()
        TextBox_ProdQuant.Clear()
        DateTimePicker_Arrival.ResetText()
        DateTimePicker_Departure.ResetText()
        Return 0
    End Function
    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub INSERTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTToolStripMenuItem.Click

        Panel_Attributes.Show()
        Panel_Save.Show()
        Label_Welcome.Visible = False
        Panel_Update.Visible = False
        Panel_Delete.Visible = False
    End Sub

    Private Sub ImporterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadsTable()
        Panel_Attributes.Visible = False
        Panel_Save.Visible = False
        Panel_Update.Visible = False
        Panel_Delete.Visible = False
        Me.ToolTip_Refresh.SetToolTip(Me.Button_LoadTable, "REFRESH")
    End Sub

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Try
            Dim READER As MySqlDataReader
            Dim Query1, Query2, Query3 As String

            MysqlConn.Open()
            Query1 = " update importexport.importer set imp_id = '" & TextBox_ImpID.Text & "', exp_id = '" & TextBox_ExpID.Text & "', prod_name = '" & TextBox_ProdName.Text & "', prod_quant = '" & TextBox_ProdQuant.Text & "', imp_add = '" & TextBox_ImpAdd.Text & "', charges = '" & TextBox_Charges.Text & "', arrival = '" & DateTimePicker_Arrival.Text & "', departure = '" & DateTimePicker_Departure.Text & "', imp_contact = '" & TextBox_ImpContact.Text & "' where prod_id = '" & TextBox_ProdID.Text & "';"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query2 = " update importexport.exporter set imp_id = '" & TextBox_ImpID.Text & "', exp_id = '" & TextBox_ExpID.Text & "', prod_name = '" & TextBox_ProdName.Text & "', prod_quant = '" & TextBox_ProdQuant.Text & "', charges = '" & TextBox_Charges.Text & "', arrival = '" & DateTimePicker_Arrival.Text & "', departure = '" & DateTimePicker_Departure.Text & "' where prod_id = '" & TextBox_ProdID.Text & "';"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query3 = " update importexport.prod set imp_id = '" & TextBox_ImpID.Text & "', exp_id = '" & TextBox_ExpID.Text & "', prod_name = '" & TextBox_ProdName.Text & "'where prod_id = '" & TextBox_ProdID.Text & "';"
            COMMAND = New MySqlCommand(Query3, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            Clearing_Textboxes()

            MessageBox.Show("Data Updated")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button_Delete_Click(sender As Object, e As EventArgs) Handles Button_Delete.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Try
            Dim READER As MySqlDataReader
            Dim Query1, Query2, Query3 As String

            MysqlConn.Open()
            Query1 = " delete from importexport.importer where prod_id = '" & TextBox_ProdID.Text & "'; "
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query2 = " delete from importexport.exporter where prod_id = '" & TextBox_ProdID.Text & "'; "
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query3 = " delete from importexport.prod where prod_id = '" & TextBox_ProdID.Text & "'; "
            COMMAND = New MySqlCommand(Query3, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            Clearing_Textboxes()

            MessageBox.Show("Data Deleted")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub UPDATEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEToolStripMenuItem.Click

        Panel_Attributes.Show()
        Panel_Update.Show()
        Label_Welcome.Visible = False
        Panel_Save.Visible = False
        Panel_Delete.Visible = False
    End Sub

    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Panel_Attributes.Show()
        Panel_Delete.Show()
        Label_Welcome.Visible = False
        Panel_Save.Visible = False
        Panel_Update.Visible = False
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Try
            Dim READER As MySqlDataReader
            Dim Query1, Query2, Query3 As String

            MysqlConn.Open()
            Query1 = "INSERT INTO importexport.importer (imp_id, exp_id, prod_id, prod_name, prod_quant, imp_add, charges, arrival, departure, imp_contact) VALUES ('" & TextBox_ImpID.Text & "', '" & TextBox_ExpID.Text & "', '" & TextBox_ProdID.Text & "', '" & TextBox_ProdName.Text & "', '" & TextBox_ProdQuant.Text & "', '" & TextBox_ImpAdd.Text & "', '" & TextBox_Charges.Text & "', '" & DateTimePicker_Arrival.Text & "', '" & DateTimePicker_Departure.Text & "', '" & TextBox_ImpContact.Text & "');"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query2 = "INSERT INTO importexport.exporter (exp_id, imp_id, prod_id, prod_name, prod_quant, charges, arrival, departure) VALUES ('" & TextBox_ExpID.Text & "', '" & TextBox_ImpID.Text & "', '" & TextBox_ProdID.Text & "', '" & TextBox_ProdName.Text & "', '" & TextBox_ProdQuant.Text & "', '" & TextBox_Charges.Text & "', '" & DateTimePicker_Arrival.Text & "', '" & DateTimePicker_Departure.Text & "');"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query3 = "INSERT INTO importexport.prod (prod_id, imp_id, exp_id, prod_name) VALUES ('" & TextBox_ProdID.Text & "', '" & TextBox_ImpID.Text & "', '" & TextBox_ExpID.Text & "','" & TextBox_ProdName.Text & "' );"
            COMMAND = New MySqlCommand(Query3, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            Clearing_Textboxes()

            MessageBox.Show("Data Saved")

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button_LoadTable_Click(sender As Object, e As EventArgs) Handles Button_LoadTable.Click
        TextBox_Search.Clear()
        ClearGridView()
        LoadsTable()
    End Sub

    Public Function LoadsTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from importexport.importer"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & "TRY AGAIN")
            TextBox_Search.Clear()
            ClearGridView()
        End Try
        Return 0
    End Function

    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
        Dim DV As New DataView(dbDataSet)
        Try
            DV.RowFilter = String.Format("prod_name Like '%{0}%'", TextBox_Search.Text)
            DataGridView1.DataSource = DV
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub IMPORTANDPRODUCTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMPORTANDPRODUCTToolStripMenuItem.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Panel_Attributes.Visible = False
        Label_Welcome.Visible = False
        Panel_Delete.Visible = False
        Panel_Update.Visible = False
        Panel_Save.Visible = False

        ClearGridView()

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select importer.imp_id ,prod.prod_id, prod.prod_name, importer.charges from importexport.importer right join importexport.prod on importer.prod_id = prod.prod_id order by importer.imp_id;"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ClearGridView()
        dbDataSet.Rows.Clear()
        dbDataSet.Columns.Clear()
        DataGridView1.DataSource = dbDataSet
        Return 0
    End Function

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        Clearing_Textboxes()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)

                TextBox_ExpID.Text = row.Cells("exp_id").Value.ToString
                TextBox_ImpID.Text = row.Cells("imp_id").Value.ToString
                TextBox_ProdID.Text = row.Cells("prod_id").Value.ToString
                TextBox_ProdName.Text = row.Cells("prod_name").Value.ToString
                TextBox_ProdQuant.Text = row.Cells("prod_quant").Value.ToString
                TextBox_ImpAdd.Text = row.Cells("imp_add").Value.ToString
                TextBox_Charges.Text = row.Cells("charges").Value.ToString
                TextBox_ImpContact.Text = row.Cells("imp_contact").Value.ToString
                DateTimePicker_Arrival.Text = row.Cells("arrival").Value.ToString
                DateTimePicker_Departure.Text = row.Cells("departure").Value.ToString

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class