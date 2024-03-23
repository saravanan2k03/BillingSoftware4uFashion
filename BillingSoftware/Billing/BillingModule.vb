Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BILLING
    Public ProductId As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BarcodeCodetxt.Focus()
        LoadAutoComplete()
        GeneratetheBillNo()
        InitialLoad()
        Dim validate As New DataGridViewButtonColumn()
        Dim delete As New DataGridViewButtonColumn()
        With validate
            .Name = "val"
            .HeaderText = "UPDATE"
            .Text = "UPDATE"
            .UseColumnTextForButtonValue = True
            .CellTemplate = New DataGridViewButtonCell()
        End With
        With delete
            .Name = "del"
            .HeaderText = "DELETE"
            .Text = "DELETE"
            .CellTemplate = New DataGridViewButtonCell()
        End With
        validate.UseColumnTextForButtonValue = True
        delete.UseColumnTextForButtonValue = True
        BillingGrid.Columns.Add(validate)
        BillingGrid.Columns.Add(delete)

    End Sub



    Private Sub InitialLoad()
        BarcodeCodetxt.Focus()
        Me.BarcodeCodetxt.Clear()
        Me.ProductName.Clear()
        Me.Total.Text = 0
        Me.Price.Text = 0
        Me.Quantity.Text = 1
        Me.MobileNo.Text = ""
        LoadGrid(Me.Bill_no.Text)
    End Sub

    Private Sub GettheProduct(Barcodeval As String)
        Dim Query As String = "select pro.Product_id As 'PRODUCT ID',Pro.Product_name As 'PRODUCT NAME',pro.Quantity As 'QUANTITY',pro.price As 'PRICE' from dbo.Products As pro inner join Category As cat on cat.Cat_id = pro.Cat_id inner join Brands As Brand on Brand.Brand_id = pro.Brand_id where pro.Barcode = @Barcode And pro.Status = 1 And cat.Status = 1 And Brand.Status =1"
        Dim con As SqlConnection = New SqlConnection(cstring)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@Barcode", Barcodeval)
                con.Open()
                ' Execute the query
                Using reader As SqlDataReader = command.ExecuteReader()
                    ' Check if there are any rows returned
                    If reader.HasRows Then
                        While reader.Read()
                            Dim ProductName As String = reader("PRODUCT NAME").ToString
                            'Dim Quantity As String = reader("QUANTITY").ToString
                            Dim Price As String = reader("PRICE").ToString
                            ProductId = reader("PRODUCT ID").ToString
                            Me.ProductName.Text = ProductName
                            Me.Price.Text = Price
                            Me.Quantity.Focus()

                            'MessageBox.Show($"Product Name: {ProductName}{Environment.NewLine}Quantity: {Quantity}{Environment.NewLine}Price: {Price}", "Product Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            IncrementTheTotal(Me.Quantity.Text, Me.Price.Text)
                        End While
                    Else
                        ' No rows found - display an error message
                        MessageBox.Show("Invalid barcode. Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        BarcodeCodetxt.Clear()
                        BarcodeCodetxt.Focus()
                        InitialLoad()
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show($"An error occurred get the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub IncrementTheTotal(Quantity As String, Price As String)
        Try
            Dim Quan As Int32 = Convert.ToInt32(Quantity)
            Dim pri As Int32 = Convert.ToInt32(Price)

            If Quan >= 0 Then
                Dim sum As Int32 = Quan * pri
                Me.Total.Text = sum.ToString
            Else
                MsgBox("Provide an Appropriate Quantity")
                Me.Quantity.Clear()
                Me.Quantity.Text = 0
                Me.Quantity.Focus()
            End If
        Catch ex As Exception
            Me.Total.Text = 0
        End Try
    End Sub

    Private Sub AddProduct(Barcodeval As String, BillNo As String)
        If Convert.ToInt32(Me.Total.Text) > 0 Then
            Dim Query As String = "select Products.Product_id As 'PRODUCT ID',Product_Name As 'PRODUCT NAME',bill.Quantity As 'QUANTITY',bill.Price As 'PRICE',bill.Total As 'TOTAL',bill.GrandTotal As 'GRAND TOTAL' from dbo.Products inner join dbo.Billing As bill on bill.Product_id = Products.Product_id where Products.Barcode =@Barcode And bill.Billing_no=@BillNo And bill.Status = 0 "
            Dim con As SqlConnection = New SqlConnection(cstring)
            Try
                Using command As New SqlCommand(Query, con)
                    command.Parameters.AddWithValue("@Barcode", Barcodeval)
                    command.Parameters.AddWithValue("@BillNo", BillNo)
                    con.Open()
                    ' Execute the query
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Check if there are any rows returned
                        If reader.HasRows Then
                            While reader.Read()
                                Dim Quantity As Int32 = Convert.ToInt32(reader("QUANTITY"))
                                Dim Price As Int32 = Convert.ToInt32(reader("PRICE"))
                                Dim Total As Int32 = Convert.ToInt32(reader("TOTAL"))
                                Quantity += Convert.ToInt32(Me.Quantity.Text)
                                Total = Quantity * Price
                                Dim QuantityUpdateQuery As String = "update Billing set Quantity =@Quantity, Total=@Total where Billing_no =@BillNo and Status =0 and Barcode=@Barcodeval"
                                Dim parameter As New List(Of SqlParameter)
                                parameter.Add(New SqlParameter("@Quantity", Quantity))
                                parameter.Add(New SqlParameter("@Total", Total))
                                parameter.Add(New SqlParameter("@BillNo", BillNo))
                                parameter.Add(New SqlParameter("@Barcodeval", Barcodeval))
                                Dim QuantityCheckData As Int32 = QuantityCheck(Convert.ToInt32(reader("PRODUCT ID")), Quantity)
                                If QuantityCheckData = 1 Then
                                    QueryProcess(QuantityUpdateQuery, parameter)
                                Else
                                    MsgBox("Add Product In Inventory")
                                End If
                            End While
                        Else
                            Dim Query1 As String = "select * from Products where Barcode =@Barcodeval"
                            Dim con1 As SqlConnection = New SqlConnection(cstring)

                            Using command1 As New SqlCommand(Query1, con1)
                                command1.Parameters.AddWithValue("@Barcodeval", Barcodeval)
                                con1.Open()
                                Using reader1 As SqlDataReader = command1.ExecuteReader()
                                    If reader1.HasRows Then
                                        Dim InsertQuery As String = "Insert into Billing (Billing_no,Product_id,Quantity,Price,Total,Barcode,Billed_by,Date,Status,GrandTotal) values(@Billingno,@ProductId,@Quantity,@Price,@Total,@Barcode,@Billedby,GETDATE(),0,@Grandtotal)"
                                        Dim InsertParameter As New List(Of SqlParameter)
                                        InsertParameter.Add(New SqlParameter("@Billingno", BillNo))
                                        InsertParameter.Add(New SqlParameter("@ProductId", Convert.ToInt32(ProductId)))
                                        InsertParameter.Add(New SqlParameter("@Quantity", Convert.ToInt32(Me.Quantity.Text)))
                                        InsertParameter.Add(New SqlParameter("@Price", Convert.ToInt32(Me.Price.Text)))
                                        InsertParameter.Add(New SqlParameter("@Total", Convert.ToInt32(Me.Total.Text)))
                                        InsertParameter.Add(New SqlParameter("@Barcode", Me.BarcodeCodetxt.Text))
                                        InsertParameter.Add(New SqlParameter("@Billedby", 1))
                                        InsertParameter.Add(New SqlParameter("@Grandtotal", 0))
                                        Dim QuantityCheckDataelse As Int32 = QuantityCheck(Convert.ToInt32(ProductId), Convert.ToInt32(Me.Quantity.Text))
                                        If QuantityCheckDataelse = 1 Then
                                            InsertData(InsertQuery, InsertParameter)
                                        Else
                                            MsgBox("Add Product In Inventory")
                                        End If
                                    Else
                                        MessageBox.Show("Invalid barcode. Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        BarcodeCodetxt.Clear()
                                        BarcodeCodetxt.Focus()
                                        InitialLoad()
                                    End If
                                End Using

                            End Using


                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Handle any exceptions that may occur
                MessageBox.Show($"An error occurred add product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()

            End Try
        Else
            MsgBox("Please Add The Product!")
        End If

    End Sub


    Private Sub UpdateProduct(Ref_id As String, Quantity As String, Price As String)
        Dim a As Integer
        Dim t As String
        Dim newQuantity As String
        Dim Total As Int32
        newQuantity = InputBox("Enter the Quantity", "UPDATE")

        ' After loop, newQuantity is either a valid number or empty string
        If newQuantity <> "" And IsNumeric(newQuantity) Then
            ' If newQuantity is a valid number, perform calculations

            Total = CInt(newQuantity) * CInt(Price)
            t = "Please Confirm the details ..."
            t = t & vbCrLf & vbCrLf & "Quantity : " & newQuantity
            t = t & vbCrLf & "Price : " & Price
            t = t & vbCrLf & "Total : " & Total
            a = MsgBox(t, vbOKCancel, "Please Confirm ...")
            If a = vbOK Then
                Dim updateQuery As String = "update dbo.Billing set Quantity=@Quantity,Total=@Total where ref_id =@refid"
                Dim updateParameter As New List(Of SqlParameter)
                updateParameter.Add(New SqlParameter("@Quantity", Convert.ToInt32(newQuantity)))
                updateParameter.Add(New SqlParameter("@Total", Total))
                updateParameter.Add(New SqlParameter("@refid", Convert.ToInt32(Ref_id)))
                Dim GetProductId As Int32 = GetProductIdUsingRefId(Convert.ToInt32(Ref_id))
                If GetProductId <> -1 Then
                    Dim QuantityCheckDataelse As Int32 = QuantityCheck(GetProductId, Convert.ToInt32(newQuantity))
                    If QuantityCheckDataelse = 1 Then

                        If QueryProcess(updateQuery, updateParameter) = 1 Then
                            LoadGrid(Me.Bill_no.Text)
                            MsgBox("Product Updated!")
                        End If

                    Else
                        MsgBox("Add Product In Inventory")
                    End If
                End If

            End If
        Else
            Exit Sub
        End If
    End Sub




    Private Function DeleteProduct(Sqlquery As String, Parameters As List(Of SqlParameter))
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
    Private Sub LoadGrid(BillNo As String)
        Try
            Dim query As String = "select ref_id As 'REF ID',pro.Product_name As 'PRODUCT NAME',cat.Category As 'CATEGORY',Brand.Brand As 'BRAND',Bill.Quantity As 'QUANTITY',Bill.Price As 'PRICE',Bill.Total 'TOTAL' from dbo.Billing As Bill inner join Products As pro on pro.Product_id = Bill.Product_id  inner join Category As cat on cat.Cat_id = pro.Cat_id inner join Brands As Brand on Brand.Brand_id = pro.Brand_id where Bill.Status = 0 And Bill.Billing_no = @BillNO"
            Dim parameters As New List(Of SqlParameter)
            parameters.Add(New SqlParameter("@BillNO", BillNo))
            gridWithPram(BillingGrid, query, {0, 1, 2, 3, 4, 5, 6}.ToList, {100, 150, 150, 150, 80, 100, 100}.ToList, parameters)

            'CalCulate GrandTotal
            CalculateGrandTotal(BillNo)
        Catch ex As Exception
            MsgBox($"SQL Exception occurred loadgrid: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
            Debug.WriteLine(ex.ToString)
        End Try
        BillingGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Black
        BillingGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub
    Private Sub CalculateGrandTotal(BillNo As String)
        Dim Query As String = "select sum(Total) As 'Total'  from Billing where Billing_no =@BillNo"
        Dim con As SqlConnection = New SqlConnection(cstring)
        Try
            Using command As New SqlCommand(Query, con)
                command.Parameters.AddWithValue("@BillNo", BillNo)
                con.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            If reader("Total").ToString = "" Then
                                Me.grandtot.Text = "0"
                            Else
                                Me.grandtot.Text = reader("Total").ToString
                            End If
                        End While
                    End If
                End Using

            End Using
            ' Execute the query
        Catch ex As Exception
            MsgBox($"SQL Exception occurred CalculateGrandTotal: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
        Finally
            con.Close()
        End Try

    End Sub


    Private Sub GeneratetheBillNo()
        Dim random As New Random()
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim randomString As String = ""

        For i As Integer = 1 To 6
            Dim randomIndex As Integer = random.Next(0, characters.Length)
            randomString += characters(randomIndex)
        Next
        Me.Bill_no.Text = randomString
    End Sub

    Private Sub FinalizeBill()
        If HasDataCheck(Me.Bill_no.Text) = 1 Then

            If Len(Me.MobileNo.Text) <> 0 Then
                Dim Query As String = "Select Customer_id,CustomerName,MobileNo,Place from Customer where MobileNo=@Mobileno"
                Dim con As SqlConnection = New SqlConnection(cstring)
                Try
                    Using command As New SqlCommand(Query, con)
                        command.Parameters.AddWithValue("@Mobileno", Me.MobileNo.Text)
                        con.Open()
                        Using reader As SqlDataReader = command.ExecuteReader()
                            If reader.HasRows Then
                                While reader.Read()
                                    Dim CustomerId As Int32 = Convert.ToInt32(reader("Customer_id"))
                                    Dim InsertCusidQuery As String = "update Billing set Customer_id =@CustomerID,Status=1,GrandTotal=@GrandTotal where Billing_no =@BillNO"
                                    Dim parameters As New List(Of SqlParameter)
                                    parameters.Add(New SqlParameter("@BillNO", Me.Bill_no.Text))
                                    parameters.Add(New SqlParameter("@CustomerID", CustomerId))
                                    parameters.Add(New SqlParameter("@GrandTotal", Convert.ToInt32(Me.grandtot.Text)))
                                    Dim ReduceQuantity As Int32 = FinalizeBillingForReduceQuantity(Me.Bill_no.Text)
                                    If ReduceQuantity = 1 Then
                                        Dim Exec As Int32 = QueryProcess(InsertCusidQuery, parameters)
                                        If Exec = 1 Then
                                            GeneratetheBillNo()
                                            InitialLoad()
                                        End If
                                    End If
                                End While
                            Else
                                MessageBox.Show($"An error occurred User Mobile Number: {Me.MobileNo.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using

                    End Using
                    ' Execute the query
                Catch ex As Exception
                    MsgBox($"SQL Exception occurred FinalizeBill: {ex.Message}", MsgBoxStyle.Critical, "SQL Error")
                Finally
                    con.Close()
                End Try
            Else
                MessageBox.Show($"Please provide mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.MobileNo.Focus()
            End If
        Else
            MessageBox.Show($"Please Buy Product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.BarcodeCodetxt.Focus()
        End If
    End Sub

    Private Sub GenerateBill()

    End Sub

    Private Sub LoadAutoComplete()
        Dim con As New SqlConnection(cstring)

        Try
            Dim cmd As SqlCommand
            Dim da As SqlDataAdapter
            Dim ds As DataSet
            Dim dt As DataTable
            con.Open()
            Dim query As String = "SELECT DISTINCT MobileNo FROM Customer"
            cmd = New SqlCommand(query, con)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds, "MobileNo")
            dt = ds.Tables("MobileNo")

            Dim col As New AutoCompleteStringCollection
            For Each row As DataRow In dt.Rows
                col.Add(row("MobileNo").ToString())
            Next
            MobileNo.AutoCompleteCustomSource = col
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub






    Private Sub BarcodeCodetxt_KeyDown(sender As Object, e As KeyEventArgs) Handles BarcodeCodetxt.KeyDown
        If e.KeyCode = Keys.Enter Then
            GettheProduct(BarcodeCodetxt.Text)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub Quantity_TextChanged(sender As Object, e As EventArgs) Handles Quantity.TextChanged
        IncrementTheTotal(Me.Quantity.Text, Me.Price.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AddProduct(Me.BarcodeCodetxt.Text, Me.Bill_no.Text)
        InitialLoad()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        InitialLoad()
    End Sub

    Private Sub Quantity_KeyDown(sender As Object, e As KeyEventArgs) Handles Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2.PerformClick()
        End If
    End Sub

    Private Sub Billbtn_Click(sender As Object, e As EventArgs) Handles Billbtn.Click
        FinalizeBill()
    End Sub




    Private Sub AddUserbtn_Click(sender As Object, e As EventArgs) Handles AddUserbtn.Click
        Dim frm2 = AddUser
        frm2.Show()
    End Sub



    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F3
                BarcodeCodetxt.Focus()
        End Select
        Select Case e.Alt And e.KeyCode

            Case Keys.F7
                Billbtn.PerformClick()

        End Select
    End Sub

    Private Sub BillingGrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BillingGrid.CellContentClick
        If BillingGrid.Columns(e.ColumnIndex).Name = "del" Then ' Ensure a valid cell is clicked
            Dim RefId As String = BillingGrid.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim DeleteQuery As String = "DELETE FROM Billing WHERE ref_id=@RefId;"
            Dim parameters As New List(Of SqlParameter)
            parameters.Add(New SqlParameter("@RefId", Convert.ToInt32(RefId)))
            If DeleteProduct(DeleteQuery, parameters) = 1 Then
                LoadGrid(Me.Bill_no.Text)
                CalculateGrandTotal(Me.Bill_no.Text)
                MsgBox("Deleted The Product!")
            End If

        ElseIf BillingGrid.Columns(e.ColumnIndex).Name = "val" Then
                Dim RefId As String = BillingGrid.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim Quantity As String = BillingGrid.Rows(e.RowIndex).Cells(6).Value.ToString()
            Dim Price As String = BillingGrid.Rows(e.RowIndex).Cells(7).Value.ToString()
            BillingGrid.Rows(e.RowIndex).Selected = True
            Dim dr As DataGridViewRow = BillingGrid.SelectedRows(0)
            UpdateProduct(RefId, Quantity, Price)
        End If
    End Sub


    Private Sub MobileNo_KeyDown(sender As Object, e As KeyEventArgs) Handles MobileNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Billbtn.PerformClick()
        End If
    End Sub

    Private Sub BILLING_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class
