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

    Public Sub grid(Grid As DataGridView, Sqlquery As String, GridColumn As List(Of Int32), Gridsize As List(Of Int32))
        Try
            Dim con As SqlConnection = New SqlConnection(cstring)
            Dim command1 As New SqlCommand(Sqlquery, con)
            Dim sda1 As New SqlDataAdapter(command1)
            Dim dt1 As New DataTable
            sda1.Fill(dt1)
            Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Grid.DataSource = dt1
            Grid.AllowUserToAddRows = False
            Grid.AllowUserToDeleteRows = False
            Grid.AllowUserToResizeColumns = False
            Grid.Columns(0).Visible = True
            Grid.ColumnHeadersVisible = True
            Grid.ColumnHeadersHeight = 80 ' Set the desired height in pixels
            Grid.ClearSelection()
            For i As Integer = 0 To GridColumn.Count - 1
                Grid.Columns(GridColumn(i)).Width = Gridsize(i)
            Next

            For Each row As DataGridViewRow In Grid.Rows
                If row.Index Mod 2 = 0 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub gridWithPram(Grid As DataGridView, Sqlquery As String, GridColumn As List(Of Int32), Gridsize As List(Of Int32), Parameters As List(Of SqlParameter))
        Try
            Dim con As SqlConnection = New SqlConnection(cstring)
            Dim command1 As New SqlCommand(Sqlquery, con)

            ' Add parameters to the SqlCommand
            For Each parameter As SqlParameter In Parameters
                command1.Parameters.Add(parameter)
            Next

            Dim sda1 As New SqlDataAdapter(command1)
            Dim dt1 As New DataTable
            sda1.Fill(dt1)
            Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Grid.DataSource = dt1
            Grid.AllowUserToAddRows = False
            Grid.AllowUserToDeleteRows = False
            Grid.AllowUserToResizeColumns = False
            Grid.Columns(0).Visible = True
            Grid.ColumnHeadersVisible = True
            Grid.ClearSelection()
            For i As Integer = 0 To GridColumn.Count - 1
                Grid.Columns(GridColumn(i)).Width = Gridsize(i)
            Next

            For Each row As DataGridViewRow In Grid.Rows
                If row.Index Mod 2 = 0 Then
                    row.DefaultCellStyle.BackColor = Color.LightBlue
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
