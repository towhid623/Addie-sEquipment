<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelGrandTotal = New System.Windows.Forms.Label()
        Me.LabelDiscount = New System.Windows.Forms.Label()
        Me.LabelTotalValue = New System.Windows.Forms.Label()
        Me.LabelAddressValue = New System.Windows.Forms.Label()
        Me.LabelPhoneNumberValue = New System.Windows.Forms.Label()
        Me.LabelMobileNumberValue = New System.Windows.Forms.Label()
        Me.LabelCustomerNameValue = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.LabelGrandTotal)
        Me.GroupBox1.Controls.Add(Me.LabelDiscount)
        Me.GroupBox1.Controls.Add(Me.LabelTotalValue)
        Me.GroupBox1.Controls.Add(Me.LabelAddressValue)
        Me.GroupBox1.Controls.Add(Me.LabelPhoneNumberValue)
        Me.GroupBox1.Controls.Add(Me.LabelMobileNumberValue)
        Me.GroupBox1.Controls.Add(Me.LabelCustomerNameValue)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1056, 407)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.Days, Me.Rate, Me.Total})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(447, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(606, 386)
        Me.DataGridView1.TabIndex = 8
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Days
        '
        Me.Days.HeaderText = "No of Days"
        Me.Days.Name = "Days"
        Me.Days.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'LabelGrandTotal
        '
        Me.LabelGrandTotal.AutoSize = True
        Me.LabelGrandTotal.Location = New System.Drawing.Point(177, 324)
        Me.LabelGrandTotal.Name = "LabelGrandTotal"
        Me.LabelGrandTotal.Size = New System.Drawing.Size(0, 17)
        Me.LabelGrandTotal.TabIndex = 1
        '
        'LabelDiscount
        '
        Me.LabelDiscount.AutoSize = True
        Me.LabelDiscount.Location = New System.Drawing.Point(177, 277)
        Me.LabelDiscount.Name = "LabelDiscount"
        Me.LabelDiscount.Size = New System.Drawing.Size(0, 17)
        Me.LabelDiscount.TabIndex = 1
        '
        'LabelTotalValue
        '
        Me.LabelTotalValue.AutoSize = True
        Me.LabelTotalValue.Location = New System.Drawing.Point(177, 230)
        Me.LabelTotalValue.Name = "LabelTotalValue"
        Me.LabelTotalValue.Size = New System.Drawing.Size(0, 17)
        Me.LabelTotalValue.TabIndex = 1
        '
        'LabelAddressValue
        '
        Me.LabelAddressValue.AutoSize = True
        Me.LabelAddressValue.Location = New System.Drawing.Point(177, 186)
        Me.LabelAddressValue.Name = "LabelAddressValue"
        Me.LabelAddressValue.Size = New System.Drawing.Size(0, 17)
        Me.LabelAddressValue.TabIndex = 1
        '
        'LabelPhoneNumberValue
        '
        Me.LabelPhoneNumberValue.AutoSize = True
        Me.LabelPhoneNumberValue.Location = New System.Drawing.Point(177, 89)
        Me.LabelPhoneNumberValue.Name = "LabelPhoneNumberValue"
        Me.LabelPhoneNumberValue.Size = New System.Drawing.Size(0, 17)
        Me.LabelPhoneNumberValue.TabIndex = 1
        '
        'LabelMobileNumberValue
        '
        Me.LabelMobileNumberValue.AutoSize = True
        Me.LabelMobileNumberValue.Location = New System.Drawing.Point(177, 139)
        Me.LabelMobileNumberValue.Name = "LabelMobileNumberValue"
        Me.LabelMobileNumberValue.Size = New System.Drawing.Size(0, 17)
        Me.LabelMobileNumberValue.TabIndex = 1
        '
        'LabelCustomerNameValue
        '
        Me.LabelCustomerNameValue.AutoSize = True
        Me.LabelCustomerNameValue.Location = New System.Drawing.Point(177, 42)
        Me.LabelCustomerNameValue.Name = "LabelCustomerNameValue"
        Me.LabelCustomerNameValue.Size = New System.Drawing.Size(0, 17)
        Me.LabelCustomerNameValue.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Grand Total"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(36, 277)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(63, 17)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Discount"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mobile Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 407)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Report"
        Me.Text = "Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelAddressValue As Label
    Friend WithEvents LabelPhoneNumberValue As Label
    Friend WithEvents LabelMobileNumberValue As Label
    Friend WithEvents LabelCustomerNameValue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Days As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents LabelGrandTotal As Label
    Friend WithEvents LabelDiscount As Label
    Friend WithEvents LabelTotalValue As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label5 As Label
End Class
