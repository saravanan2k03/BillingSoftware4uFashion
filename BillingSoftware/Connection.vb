Imports System.Data.SqlClient

Module Connection


    Public cstring As String = "Data Source=(localdb)\local;Initial Catalog=4ufashion;Integrated Security=True"



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

    Public Sub InsertData(Sqlquery As String, Parameters As List(Of SqlParameter))
        Try
            Using con As SqlConnection = New SqlConnection(cstring)
                con.Open()
                Using command1 As New SqlCommand(Sqlquery, con)
                    ' Add parameters to the SqlCommand
                    For Each parameter As SqlParameter In Parameters
                        command1.Parameters.Add(parameter)
                    Next
                    command1.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            ' Log the exception or handle it appropriately
            MsgBox("Something Went Wrong!" & ex.Message)
            Debug.WriteLine("An error occurred: " & ex.Message)

        End Try
    End Sub

    Public Function QueryProcess(Sqlquery As String, Parameters As List(Of SqlParameter)) As Integer
        Try
            Using con As SqlConnection = New SqlConnection(cstring)
                con.Open()
                Using command1 As New SqlCommand(Sqlquery, con)
                    ' Add parameters to the SqlCommand
                    For Each parameter As SqlParameter In Parameters
                        command1.Parameters.Add(parameter)
                    Next
                    command1.ExecuteNonQuery()
                End Using
            End Using
            ' If execution completes without errors, return 1
            Return 1
        Catch ex As Exception
            ' Log the exception or handle it appropriately
            Debug.WriteLine("An error occurred: " & ex.Message)
            ' If an error occurs, return -1
            Return -1
        End Try
    End Function



End Module
