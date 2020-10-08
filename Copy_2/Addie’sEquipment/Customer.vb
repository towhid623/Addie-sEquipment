
Imports System.IO
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json

Public Class Customer
    Private Sub ButtonSubmit_Click(sender As Object, e As EventArgs) Handles ButtonSubmit.Click
        Dim valid As Boolean = True
        Dim name As String = TextBoxCustomerName.Text
        Dim mobile As String = TextBoxMobileNumber.Text
        Dim phone As String = TextBoxPhoneNumber.Text
        Dim address As String = TextBoxAddress.Text

        If name = "" Then
            MessageBox.Show("Name is required")
            valid = False
        ElseIf ContainsNumbers(name) Then
            MessageBox.Show("Name should not be numeric")
            valid = False
        ElseIf mobile = "" Then
            MessageBox.Show("Mobile number is required")
            valid = False
        ElseIf Not (IsNumeric(mobile)) Then
            MessageBox.Show("Mobile number should be numeric")
            valid = False
        ElseIf phone = "" Then
            MessageBox.Show("Phone number is required")
            valid = False
        ElseIf Not (IsNumeric(phone)) Then
            MessageBox.Show("Phone number should be numeric")
            valid = False
        ElseIf address = "" Then
            MessageBox.Show("Address is required")
            valid = False
        End If

        If valid Then
            Dim report As Report = New Report()
            report.LabelCustomerNameValue.Text = name
            report.LabelMobileNumberValue.Text = mobile
            report.LabelPhoneNumberValue.Text = phone
            report.LabelAddressValue.Text = address
            report.DataGridView1.Rows.Clear()
            Dim total As Decimal = 0
            Dim discount As Decimal = 0
            Dim grandTotal As Decimal = 0
            Dim noOfItems As Decimal = 0
            For Each i In DataGridView1.Rows
                report.DataGridView1.Rows.Add({i.Cells(0).Value, i.Cells(1).Value, i.Cells(2).Value, i.Cells(3).Value})
                If Not (i.Cells(3).Value = "") Then
                    total = total + Decimal.Parse(i.Cells(3).Value)
                    noOfItems += 1
                End If
            Next
            grandTotal = total
            If noOfItems > 2 Then
                discount = (15 * total) / 100
                grandTotal = total - discount
            End If
            report.LabelTotalValue.Text = "RM " + total.ToString()
            report.LabelGrandTotal.Text = "RM " + grandTotal.ToString()
            report.LabelDiscount.Text = "RM " + discount.ToString()
            report.Show()
        End If
    End Sub

    Private Sub ButtonSubmitItem_Click(sender As Object, e As EventArgs) Handles ButtonSubmitItem.Click
        Dim days As String = TextBoxNoOfDays.Text.Trim()
        Dim valid As Boolean = True
        If ListBoxItems.SelectedItems.Count <= 0 Then
            MessageBox.Show("Select an Item for Rental")
            valid = False
        ElseIf days = "" Then
            MessageBox.Show("Only numbers between 1-14 are allowed for No of Days field")
            valid = False
        ElseIf Not (IsNumeric(days)) Then
            MessageBox.Show("Only numbers between 1-14 are allowed for No of Days field")
            valid = False
        ElseIf Integer.Parse(days) > 14 Or Integer.Parse(days) < 1 Then
            MessageBox.Show("Only numbers between 1-14 are allowed for No of Days field")
            valid = False
        End If


        If valid Then
            Dim selectedItem As String = ListBoxItems.SelectedItems(0).Replace("–", "-")
            Dim FileName As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "items.json")
            Dim value As String = File.ReadAllText(FileName)
            Dim items As List(Of Item) = JsonConvert.DeserializeObject(Of List(Of Item))(value)
            For Each i In items
                i.EquipmentType = i.EquipmentType.Replace("�", "-")
            Next
            Dim rate As String = 0
            Dim total As String = 0
            Dim item As Item = items.FirstOrDefault(Function(w) w.EquipmentType = selectedItem)
            If days = "1" Then
                rate = item.DailyRate + " (Daily)"
                total = item.DailyRate * days
            Else
                rate = item.DaysRate + " (Days)"
                total = item.DaysRate * days
            End If
            DataGridView1.Rows.Add({item.EquipmentType, days, rate, total, "Delete"})
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.ColumnIndex = 4 Then

                DataGridView1.Rows.Remove(DataGridView1.Rows(e.RowIndex))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Function ContainsNumbers(input As String) As Boolean
        Return Regex.IsMatch(input, "[0-9]")
    End Function
End Class