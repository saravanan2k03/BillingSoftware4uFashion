Imports System.Data.SqlClient

Module CrudFile
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
