Imports System.IO

Public Class datainputform

    ' Form Load - Populate ComboBox when the form starts
    Private Sub datainputform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(New String() {"1 Week", "2 Weeks", "3 Weeks", "1 Month", "2 Months"})
        ComboBox1.SelectedIndex = 0 ' Optional: set default to "1 Week"
    End Sub

    ' Save Button Click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Get values from input fields
        Dim jobName As String = TextBox1.Text.Trim()
        Dim employees As String = TextBox2.Text.Trim()
        Dim costInput As String = TextBox3.Text.Trim()
        Dim timeFrame As String = ComboBox1.SelectedItem?.ToString()

        ' Validate input
        If String.IsNullOrWhiteSpace(jobName) Then
            MessageBox.Show("Please enter the job name.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(employees) Then
            MessageBox.Show("Please enter the number of employees.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(costInput) Then
            MessageBox.Show("Please enter the cost(s).")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(timeFrame) Then
            MessageBox.Show("Please select a time frame.")
            Exit Sub
        End If

        ' Calculate total cost
        Dim totalCost As Decimal = 0
        Try
            Dim costs = costInput.Split(","c)
            For Each cost In costs
                totalCost += Decimal.Parse(cost.Trim())
            Next
        Catch ex As Exception
            MessageBox.Show("Invalid cost format. Use commas to separate values.")
            Exit Sub
        End Try

        ' Format CSV line
        Dim csvLine As String = $"{jobName},{employees},{totalCost},{timeFrame}"
        Dim csvPath As String = "jobs.csv"

        ' Write to CSV
        Dim fileExists As Boolean = File.Exists(csvPath)
        Using writer As StreamWriter = New StreamWriter(csvPath, append:=True)
            If Not fileExists Then
                writer.WriteLine("Job Name,Employees,Total Cost,Time Frame")
            End If
            writer.WriteLine(csvLine)
        End Using

        MessageBox.Show("Job saved successfully.")

        If MainMenu.instance IsNot Nothing Then
            MainMenu.instance.lstnotifications.Items.Add($"New job added: {jobName} at {DateTime.Now.ToShortTimeString()}")
        End If
        ' Clear inputs
        ClearForm()
    End Sub

    ' Clear all inputs
    Private Sub ClearForm()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = 0 ' Reset to default
    End Sub


End Class
