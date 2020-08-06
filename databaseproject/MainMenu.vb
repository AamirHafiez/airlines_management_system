Public Class MainMenu
    Private Sub Button_SignOut_Click(sender As Object, e As EventArgs) Handles Button_SignOut.Click
        Form_Login.Show()
        ImporterForm.Dispose()
        ExporterForm.Dispose()
        ProductForm.Dispose()
        Me.Dispose()
    End Sub

    Private Sub Button_Importer_Click(sender As Object, e As EventArgs) Handles Button_Importer.Click
        ImporterForm.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ToolTip_SignOut.SetToolTip(Button_SignOut,"SIGN OUT")
    End Sub

    Private Sub Button_Product_Click(sender As Object, e As EventArgs) Handles Button_Product.Click
        ProductForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Expoter_Click(sender As Object, e As EventArgs) Handles Button_Expoter.Click
        ExporterForm.Show()
        Me.Hide()
    End Sub
End Class