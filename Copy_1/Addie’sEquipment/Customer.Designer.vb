<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.TextBoxCustomerName = New System.Windows.Forms.TextBox()
        Me.LabelMobileNumber = New System.Windows.Forms.Label()
        Me.TextBoxMobileNumber = New System.Windows.Forms.TextBox()
        Me.LabelPhoneNumber = New System.Windows.Forms.Label()
        Me.TextBoxPhoneNumber = New System.Windows.Forms.TextBox()
        Me.LabelAddress = New System.Windows.Forms.Label()
        Me.TextBoxAddress = New System.Windows.Forms.TextBox()
        Me.GroupBoxCustomerEntry = New System.Windows.Forms.GroupBox()
        Me.ListBoxItems = New System.Windows.Forms.ListBox()
        Me.LabelErrorMsg = New System.Windows.Forms.Label()
        Me.ButtonSubmitItem = New System.Windows.Forms.Button()
        Me.ButtonSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNoOfDays = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Days = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxCustomerEntry.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(17, 32)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(118, 17)
        Me.lblCustomerName.TabIndex = 0
        Me.lblCustomerName.Text = "Customer Name *"
        '
        'TextBoxCustomerName
        '
        Me.TextBoxCustomerName.Location = New System.Drawing.Point(20, 53)
        Me.TextBoxCustomerName.Name = "TextBoxCustomerName"
        Me.TextBoxCustomerName.Size = New System.Drawing.Size(226, 22)
        Me.TextBoxCustomerName.TabIndex = 1
        '
        'LabelMobileNumber
        '
        Me.LabelMobileNumber.AutoSize = True
        Me.LabelMobileNumber.Location = New System.Drawing.Point(270, 32)
        Me.LabelMobileNumber.Name = "LabelMobileNumber"
        Me.LabelMobileNumber.Size = New System.Drawing.Size(103, 17)
        Me.LabelMobileNumber.TabIndex = 0
        Me.LabelMobileNumber.Text = "Mobile Number"
        '
        'TextBoxMobileNumber
        '
        Me.TextBoxMobileNumber.Location = New System.Drawing.Point(273, 53)
        Me.TextBoxMobileNumber.Name = "TextBoxMobileNumber"
        Me.TextBoxMobileNumber.Size = New System.Drawing.Size(226, 22)
        Me.TextBoxMobileNumber.TabIndex = 2
        '
        'LabelPhoneNumber
        '
        Me.LabelPhoneNumber.AutoSize = True
        Me.LabelPhoneNumber.Location = New System.Drawing.Point(528, 32)
        Me.LabelPhoneNumber.Name = "LabelPhoneNumber"
        Me.LabelPhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.LabelPhoneNumber.TabIndex = 0
        Me.LabelPhoneNumber.Text = "Phone Number"
        '
        'TextBoxPhoneNumber
        '
        Me.TextBoxPhoneNumber.Location = New System.Drawing.Point(531, 53)
        Me.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber"
        Me.TextBoxPhoneNumber.Size = New System.Drawing.Size(226, 22)
        Me.TextBoxPhoneNumber.TabIndex = 3
        '
        'LabelAddress
        '
        Me.LabelAddress.AutoSize = True
        Me.LabelAddress.Location = New System.Drawing.Point(791, 32)
        Me.LabelAddress.Name = "LabelAddress"
        Me.LabelAddress.Size = New System.Drawing.Size(60, 17)
        Me.LabelAddress.TabIndex = 0
        Me.LabelAddress.Text = "Address"
        '
        'TextBoxAddress
        '
        Me.TextBoxAddress.Location = New System.Drawing.Point(794, 53)
        Me.TextBoxAddress.Name = "TextBoxAddress"
        Me.TextBoxAddress.Size = New System.Drawing.Size(226, 22)
        Me.TextBoxAddress.TabIndex = 4
        '
        'GroupBoxCustomerEntry
        '
        Me.GroupBoxCustomerEntry.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBoxCustomerEntry.Controls.Add(Me.LabelErrorMsg)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.ButtonSubmit)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.TextBoxCustomerName)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.TextBoxPhoneNumber)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.lblCustomerName)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.TextBoxMobileNumber)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.LabelMobileNumber)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.TextBoxAddress)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.LabelAddress)
        Me.GroupBoxCustomerEntry.Controls.Add(Me.LabelPhoneNumber)
        Me.GroupBoxCustomerEntry.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxCustomerEntry.Name = "GroupBoxCustomerEntry"
        Me.GroupBoxCustomerEntry.Size = New System.Drawing.Size(1038, 134)
        Me.GroupBoxCustomerEntry.TabIndex = 2
        Me.GroupBoxCustomerEntry.TabStop = False
        Me.GroupBoxCustomerEntry.Text = "Customer Entry"
        '
        'ListBoxItems
        '
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.ItemHeight = 16
        Me.ListBoxItems.Items.AddRange(New Object() {"Lawn Mower – Rotary", "Lawn Mower – Ride On", "Lawn Mower – Handheld", "Mobile Garden Sprinkler (small)", "Mobile Garden Sprinkler (large)", "Garden Spray – 5L", "Garden Spray – 10L", "Outdoor High Pressure Pump"})
        Me.ListBoxItems.Location = New System.Drawing.Point(20, 61)
        Me.ListBoxItems.Name = "ListBoxItems"
        Me.ListBoxItems.Size = New System.Drawing.Size(295, 132)
        Me.ListBoxItems.TabIndex = 4
        '
        'LabelErrorMsg
        '
        Me.LabelErrorMsg.AutoSize = True
        Me.LabelErrorMsg.ForeColor = System.Drawing.Color.Red
        Me.LabelErrorMsg.Location = New System.Drawing.Point(20, 181)
        Me.LabelErrorMsg.Name = "LabelErrorMsg"
        Me.LabelErrorMsg.Size = New System.Drawing.Size(0, 17)
        Me.LabelErrorMsg.TabIndex = 6
        '
        'ButtonSubmitItem
        '
        Me.ButtonSubmitItem.Location = New System.Drawing.Point(384, 166)
        Me.ButtonSubmitItem.Name = "ButtonSubmitItem"
        Me.ButtonSubmitItem.Size = New System.Drawing.Size(75, 27)
        Me.ButtonSubmitItem.TabIndex = 5
        Me.ButtonSubmitItem.Text = "Add Item"
        Me.ButtonSubmitItem.UseVisualStyleBackColor = True
        '
        'ButtonSubmit
        '
        Me.ButtonSubmit.BackColor = System.Drawing.Color.Green
        Me.ButtonSubmit.ForeColor = System.Drawing.Color.White
        Me.ButtonSubmit.Location = New System.Drawing.Point(905, 81)
        Me.ButtonSubmit.Name = "ButtonSubmit"
        Me.ButtonSubmit.Size = New System.Drawing.Size(115, 43)
        Me.ButtonSubmit.TabIndex = 5
        Me.ButtonSubmit.Text = "Submit"
        Me.ButtonSubmit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No of Days"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Items for Rental"
        '
        'TextBoxNoOfDays
        '
        Me.TextBoxNoOfDays.Location = New System.Drawing.Point(346, 61)
        Me.TextBoxNoOfDays.Name = "TextBoxNoOfDays"
        Me.TextBoxNoOfDays.Size = New System.Drawing.Size(113, 22)
        Me.TextBoxNoOfDays.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemName, Me.Days, Me.Rate, Me.Total, Me.Action})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 366)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1038, 254)
        Me.DataGridView1.TabIndex = 7
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
        'Action
        '
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox2.Controls.Add(Me.ListBoxItems)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBoxNoOfDays)
        Me.GroupBox2.Controls.Add(Me.ButtonSubmitItem)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1038, 208)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item Entry"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 632)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBoxCustomerEntry)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.GroupBoxCustomerEntry.ResumeLayout(False)
        Me.GroupBoxCustomerEntry.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblCustomerName As Label
    Friend WithEvents TextBoxCustomerName As TextBox
    Friend WithEvents LabelMobileNumber As Label
    Friend WithEvents TextBoxMobileNumber As TextBox
    Friend WithEvents LabelPhoneNumber As Label
    Friend WithEvents TextBoxPhoneNumber As TextBox
    Friend WithEvents LabelAddress As Label
    Friend WithEvents TextBoxAddress As TextBox
    Friend WithEvents GroupBoxCustomerEntry As GroupBox
    Friend WithEvents ButtonSubmit As Button
    Friend WithEvents LabelErrorMsg As Label
    Friend WithEvents ListBoxItems As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewItems As DataGridView
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents NoOfDays As DataGridViewTextBoxColumn
    Friend WithEvents DailyRate As DataGridViewTextBoxColumn
    Friend WithEvents DaysRate As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmount As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxNoOfDays As TextBox
    Friend WithEvents ButtonItemSubmit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonSubmitItem As Button
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Days As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
End Class
