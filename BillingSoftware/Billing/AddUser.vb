Imports System.Data.SqlClient

Public Class AddUser
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If Len(Me.Nametxt.Text) <> 0 And Len(Me.Mobiletxt.Text) <> 0 And Len(Me.placetxt.Text) <> 0 Then
            If HasDataCheck(Me.Mobiletxt.Text) = 1 Then
                MsgBox("User Already Exist!")

            Else
                AddUser()
            End If
        End If
    End Sub


    Private Sub AddUser()
        Dim query As String = "Insert into Customer(CustomerName,MobileNo,Place)values(@CustomerName,@MobileNo,@Place)"
        Dim InsertParameter As New List(Of SqlParameter)
        InsertParameter.Add(New SqlParameter("@CustomerName", Me.Nametxt.Text))
        InsertParameter.Add(New SqlParameter("@MobileNo", Me.Mobiletxt.Text))
        InsertParameter.Add(New SqlParameter("@Place", Me.placetxt.Text))
        Dim Completed As Int32 = QueryProcess(query, InsertParameter)
        If Completed = 1 Then
            MsgBox("User Added")
            Me.Nametxt.Clear()
            Me.Mobiletxt.Clear()
            Me.placetxt.Clear()
            Me.Close()
        Else
            MsgBox("User Not Added")
        End If
    End Sub '


    Private Function HasDataCheck(MobileNo As String) As Integer
        Dim Query As String = "SELECT * FROM Customer WHERE MobileNo = @MobileNo"
        Dim con As SqlConnection = New SqlConnection(cstring)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@MobileNo", MobileNo)
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

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Nametxt.Focus()
        Me.Nametxt.Clear()
        Me.Mobiletxt.Clear()
        Me.placetxt.Clear()
        Me.Nametxt.Focus()
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Me.Nametxt.Clear()
        Me.Mobiletxt.Clear()
        Me.placetxt.Clear()
        Me.Nametxt.Focus()

    End Sub


    Private Sub placetxt_KeyDown(sender As Object, e As KeyEventArgs) Handles placetxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            addbtn.PerformClick()
        End If
    End Sub
End Class