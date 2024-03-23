Imports System.Data.SqlClient

Module ReduceQuantity
    Private Function GetBillingDetails(billingNo As String) As DataTable
        Dim query As String = "SELECT Product_id, Quantity FROM Billing WHERE Billing_no = @BillingNo"
        Dim dataTable As New DataTable()

        Using con As New SqlConnection(cstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@BillingNo", billingNo)
                con.Open()
                Using adapter As New SqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
            End Using
        End Using

        Return dataTable
    End Function


    Public Function FinalizeBillingForReduceQuantity(billingNo As String) As Integer
        Try
            Dim billingDetails As DataTable = GetBillingDetails(billingNo)
            For Each row As DataRow In billingDetails.Rows
                Dim productId As String = row("Product_id").ToString()
                Dim quantity As Integer = Convert.ToInt32(row("Quantity"))
                'Dim Quantitycheckdata As Int32 = QuantityCheck(Convert.ToInt32(productId), Convert.ToInt32(quantity))
                UpdateProductQuantity(productId, quantity)
            Next
            Return 1

        Catch ex As Exception
            MsgBox($"SQL Exception occurred FinalizeBillingForReduceQuantity: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Return -1
        End Try
    End Function

    Public Sub UpdateProductQuantity(productId As String, quantity As Integer)
        Dim query As String = "UPDATE Products SET Quantity = Quantity - @Quantity WHERE Product_id = @ProductId"

        Using con As New SqlConnection(cstring)
            Using cmd As New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(productId))
                cmd.Parameters.AddWithValue("@Quantity", quantity)
                con.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
