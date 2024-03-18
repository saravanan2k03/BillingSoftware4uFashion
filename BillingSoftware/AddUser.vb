Imports System.Data.SqlClient

Public Class AddUser
    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        If Len(Me.Nametxt.Text) <> 0 And Len(Me.Mobiletxt.Text) <> 0 And Len(Me.placetxt.Text) <> 0 Then
            AddUser()
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
    End Sub

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