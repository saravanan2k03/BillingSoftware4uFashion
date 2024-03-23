Imports System.Data.SqlClient

Module GlobalFunction
    Public Function QuantityCheck(Product_id As Int32, CurrentQuantity As Int32) As Integer

        Dim Query As String = "select Product_id,Quantity from Products where Product_id =@Product_id"
        Dim con As SqlConnection = New SqlConnection(cstring)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@Product_id", Product_id)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Dim Quantity As Int32 = reader("Quantity")
                            If CurrentQuantity <= Quantity Then
                                Return 1
                            Else
                                Return -1
                            End If
                        End While
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred QuantityCheck: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Return -1
        Finally
            con.Close()
        End Try
        Return -1
    End Function


    Public Function GetProductIdUsingRefId(ref_id As Int32)
        Dim Query As String = "select Product_id  from Billing where ref_id =@ref_id"
        Dim con As SqlConnection = New SqlConnection(cstring)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@ref_id", ref_id)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Return Convert.ToInt32(reader("Product_id"))
                        End While
                    Else
                        Return -1
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred GetProductIdUsingRefId: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Return -1
        Finally
            con.Close()
        End Try
        Return -1
    End Function


    Public Function HasDataCheck(BillNo As String) As Integer
        Dim Query As String = "SELECT * FROM Billing WHERE Billing_no = @BillNo"
        Dim con As SqlConnection = New SqlConnection(cstring)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", BillNo)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        Return 1
                    Else
                        Return -1
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"SQL Exception occurred in HasDataCheck: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Return -1
        Finally
            con.Close()
        End Try
    End Function
End Module
