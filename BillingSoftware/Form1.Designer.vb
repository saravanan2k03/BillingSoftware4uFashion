<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BILLING
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddUserbtn = New System.Windows.Forms.Button()
        Me.Billbtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MobileNo = New System.Windows.Forms.RichTextBox()
        Me.BarcodeCodetxt = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Bill_no = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProductName = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.RichTextBox()
        Me.BillingGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grandtot = New System.Windows.Forms.RichTextBox()
        Me.GrandTotal = New System.Windows.Forms.GroupBox()
        Me.GrandTotaltxt = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.BillingGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GrandTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddUserbtn)
        Me.GroupBox1.Controls.Add(Me.Billbtn)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.MobileNo)
        Me.GroupBox1.Controls.Add(Me.BarcodeCodetxt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Bill_no)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ProductName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Total)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Price)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Quantity)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 853)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BILLING SECTION"
        '
        'AddUserbtn
        '
        Me.AddUserbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserbtn.Location = New System.Drawing.Point(4, 756)
        Me.AddUserbtn.Name = "AddUserbtn"
        Me.AddUserbtn.Size = New System.Drawing.Size(136, 52)
        Me.AddUserbtn.TabIndex = 19
        Me.AddUserbtn.Text = "ADD USER"
        Me.AddUserbtn.UseVisualStyleBackColor = True
        '
        'Billbtn
        '
        Me.Billbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Billbtn.Location = New System.Drawing.Point(148, 756)
        Me.Billbtn.Name = "Billbtn"
        Me.Billbtn.Size = New System.Drawing.Size(148, 52)
        Me.Billbtn.TabIndex = 18
        Me.Billbtn.Text = "BILL"
        Me.Billbtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 669)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Mobile No:"
        '
        'MobileNo
        '
        Me.MobileNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MobileNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNo.Location = New System.Drawing.Point(6, 694)
        Me.MobileNo.Multiline = False
        Me.MobileNo.Name = "MobileNo"
        Me.MobileNo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.MobileNo.Size = New System.Drawing.Size(290, 58)
        Me.MobileNo.TabIndex = 15
        Me.MobileNo.Text = ""
        '
        'BarcodeCodetxt
        '
        Me.BarcodeCodetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BarcodeCodetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarcodeCodetxt.Location = New System.Drawing.Point(6, 140)
        Me.BarcodeCodetxt.Multiline = False
        Me.BarcodeCodetxt.Name = "BarcodeCodetxt"
        Me.BarcodeCodetxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.BarcodeCodetxt.Size = New System.Drawing.Size(290, 58)
        Me.BarcodeCodetxt.TabIndex = 0
        Me.BarcodeCodetxt.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Barcode :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Bill No :"
        '
        'Bill_no
        '
        Me.Bill_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bill_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bill_no.Location = New System.Drawing.Point(6, 46)
        Me.Bill_no.Multiline = False
        Me.Bill_no.Name = "Bill_no"
        Me.Bill_no.ReadOnly = True
        Me.Bill_no.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.Bill_no.Size = New System.Drawing.Size(290, 58)
        Me.Bill_no.TabIndex = 13
        Me.Bill_no.Text = ""
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 42)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "CLEAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 609)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 42)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Product Name :"
        '
        'ProductName
        '
        Me.ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductName.Location = New System.Drawing.Point(6, 234)
        Me.ProductName.Multiline = False
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        Me.ProductName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.ProductName.Size = New System.Drawing.Size(290, 58)
        Me.ProductName.TabIndex = 8
        Me.ProductName.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total :"
        '
        'Total
        '
        Me.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(6, 528)
        Me.Total.Multiline = False
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.Total.Size = New System.Drawing.Size(290, 58)
        Me.Total.TabIndex = 6
        Me.Total.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 405)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Price :"
        '
        'Price
        '
        Me.Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(6, 430)
        Me.Price.Multiline = False
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.Price.Size = New System.Drawing.Size(290, 58)
        Me.Price.TabIndex = 4
        Me.Price.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Quantity :"
        '
        'Quantity
        '
        Me.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(6, 333)
        Me.Quantity.Multiline = False
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.Quantity.Size = New System.Drawing.Size(290, 58)
        Me.Quantity.TabIndex = 1
        Me.Quantity.Text = ""
        '
        'BillingGrid
        '
        Me.BillingGrid.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillingGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.BillingGrid.ColumnHeadersHeight = 50
        Me.BillingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.BillingGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.BillingGrid.Location = New System.Drawing.Point(320, 12)
        Me.BillingGrid.Name = "BillingGrid"
        Me.BillingGrid.ReadOnly = True
        Me.BillingGrid.RowHeadersWidth = 51
        Me.BillingGrid.RowTemplate.Height = 40
        Me.BillingGrid.Size = New System.Drawing.Size(1183, 683)
        Me.BillingGrid.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Controls.Add(Me.GrandTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(320, 701)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1183, 156)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INSTRUCTION"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grandtot)
        Me.GroupBox2.Location = New System.Drawing.Point(922, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(255, 120)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GRAND TOTAL"
        '
        'grandtot
        '
        Me.grandtot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grandtot.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grandtot.Location = New System.Drawing.Point(6, 39)
        Me.grandtot.Multiline = False
        Me.grandtot.Name = "grandtot"
        Me.grandtot.ReadOnly = True
        Me.grandtot.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.grandtot.Size = New System.Drawing.Size(243, 58)
        Me.grandtot.TabIndex = 8
        Me.grandtot.Text = ""
        '
        'GrandTotal
        '
        Me.GrandTotal.Controls.Add(Me.GrandTotaltxt)
        Me.GrandTotal.Location = New System.Drawing.Point(1225, 41)
        Me.GrandTotal.Name = "GrandTotal"
        Me.GrandTotal.Size = New System.Drawing.Size(260, 109)
        Me.GrandTotal.TabIndex = 0
        Me.GrandTotal.TabStop = False
        Me.GrandTotal.Text = "Grand Total"
        '
        'GrandTotaltxt
        '
        Me.GrandTotaltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GrandTotaltxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrandTotaltxt.Location = New System.Drawing.Point(6, 38)
        Me.GrandTotaltxt.Multiline = False
        Me.GrandTotaltxt.Name = "GrandTotaltxt"
        Me.GrandTotaltxt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal
        Me.GrandTotaltxt.Size = New System.Drawing.Size(248, 58)
        Me.GrandTotaltxt.TabIndex = 7
        Me.GrandTotaltxt.Text = ""
        '
        'BILLING
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1515, 961)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BillingGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "BILLING"
        Me.Text = "BILLING"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.BillingGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GrandTotal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BillingGrid As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BarcodeCodetxt As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Price As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Quantity As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Total As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ProductName As RichTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Bill_no As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GrandTotal As GroupBox
    Friend WithEvents GrandTotaltxt As RichTextBox
    Friend WithEvents Billbtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents MobileNo As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grandtot As RichTextBox
    Friend WithEvents AddUserbtn As Button
End Class
