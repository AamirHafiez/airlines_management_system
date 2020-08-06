Imports MySql.Data.MySqlClient
Public Class ProductForm
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Public Function Clearing_Textboxes()
        TextBox_ProdName.Clear()
        TextBox_ProdID.Clear()
        TextBox_PricePerProd.Clear()
        TextBox_ExpID.Clear()
        TextBox_ImpID.Clear()
        Return 0
    End Function

    Public Function LoadsTable()
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from importexport.prod"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & "TRY AGAIN")
            ClearGridView()
        End Try
        Return 0
    End Function
    Public Function ClearGridView()
        dbDataSet.Rows.Clear()
        dbDataSet.Columns.Clear()
        DataGridView1.DataSource = dbDataSet
        Return 0
    End Function
    Private Sub ProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadsTable()
        Panel_Attributes.Visible = False
        Panel_Save.Visible = False
        Panel_Update.Visible = False
        Panel_Delete.Visible = False
        Me.ToolTip_Refresh.SetToolTip(Me.Button_LoadTable, "REFRESH")
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)

                TextBox_ProdID.Text = row.Cells("prod_id").Value.ToString
                TextBox_ProdName.Text = row.Cells("prod_name").Value.ToString
                TextBox_PricePerProd.Text = row.Cells("price_per_prod").Value.ToString
                TextBox_ImpID.Text = row.Cells("imp_id").Value.ToString
                TextBox_ExpID.Text = row.Cells("exp_id").Value.ToString

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub INSERTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles INSERTToolStripMenuItem.Click
        Panel_Attributes.Show()
        Panel_Save.Show()
        Label_Welcome.Visible = False
        Panel_Update.Visible = False
        Panel_Delete.Visible = False
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

    Private Sub BACKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BACKToolStripMenuItem.Click
        Me.Hide()
        MainMenu.Show()
    End Sub


    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        Clearing_Textboxes()
    End Sub

    Private Sub Button_LoadTable_Click(sender As Object, e As EventArgs) Handles Button_LoadTable.Click
        ClearGridView()
        LoadsTable()
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Try
            Dim READER As MySqlDataReader
            Dim Query1, Query2, Query3 As String

            MysqlConn.Open()
            Query1 = "INSERT INTO importexport.exporter (prod_id, prod_name, imp_id, exp_id) VALUES ('" & TextBox_ProdID.Text & "', '" & TextBox_ProdName.Text & "','" & TextBox_ImpID.Text & "', '" & TextBox_ExpID.Text & "');"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query2 = "INSERT INTO importexport.importer (prod_id, prod_name, imp_id, exp_id) VALUES ('" & TextBox_ProdID.Text & "', '" & TextBox_ProdName.Text & "','" & TextBox_ImpID.Text & "', '" & TextBox_ExpID.Text & "');"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query3 = "INSERT INTO importexport.prod (prod_id, prod_name, price_per_prod, imp_id, exp_id) VALUES ('" & TextBox_ProdID.Text & "', '" & TextBox_ProdName.Text & "' ,'" & TextBox_PricePerProd.Text & "','" & TextBox_ImpID.Text & "', '" & TextBox_ExpID.Text & "');"
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

    Private Sub Button_Update_Click(sender As Object, e As EventArgs) Handles Button_Update.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;password=aamir786;database=importexport"

        Try
            Dim READER As MySqlDataReader
            Dim Query1, Query2, Query3 As String

            MysqlConn.Open()
            Query1 = " update importexport.exporter set prod_name = '" & TextBox_ProdName.Text & "',imp_id = '" & TextBox_ImpID.Text & "', exp_id = '" & TextBox_ExpID.Text & "' where prod_id = '" & TextBox_ProdID.Text & "';"
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query2 = " update importexport.importer set prod_name = '" & TextBox_ProdName.Text & "',imp_id = '" & TextBox_ImpID.Text & "', exp_id = '" & TextBox_ExpID.Text & "' where prod_id = '" & TextBox_ProdID.Text & "';"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query3 = " update importexport.prod set  price_per_prod = '" & TextBox_PricePerProd.Text & "', prod_name = '" & TextBox_ProdName.Text & "', imp_id = '" & TextBox_ImpID.Text & "', exp_id = '" & TextBox_ExpID.Text & "' where prod_id = '" & TextBox_ProdID.Text & "';"
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
            Query1 = " delete from importexport.exporter where prod_id = '" & TextBox_ProdID.Text & "'; "
            COMMAND = New MySqlCommand(Query1, MysqlConn)
            READER = COMMAND.ExecuteReader
            MysqlConn.Close()

            MysqlConn.Open()
            Query2 = " delete from importexport.importer where prod_id = '" & TextBox_ProdID.Text & "'; "
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

    Private Sub TextBox_Search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Search.TextChanged
        Dim DV As New DataView(dbDataSet)
        Try
            DV.RowFilter = String.Format("prod_name Like '%{0}%'", TextBox_Search.Text)
            DataGridView1.DataSource = DV
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DataGridView1.Rows(e.RowIndex)

                TextBox_ExpID.Text = row.Cells("exp_id").Value.ToString
                TextBox_ImpID.Text = row.Cells("imp_id").Value.ToString
                TextBox_ProdID.Text = row.Cells("prod_id").Value.ToString
                TextBox_ProdName.Text = row.Cells("prod_name").Value.ToString
                TextBox_PricePerProd.Text = row.Cells("price_per_prod").Value.ToString

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class