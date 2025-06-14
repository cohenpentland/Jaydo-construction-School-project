Imports System.IO
Imports System.Net.Http
Imports System.Net.Mail
Imports System.Text
Imports Newtonsoft.Json

Public Class FormCreation

    Private Sub FormCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbdataset.Items.Add("jobs.csv")
    End Sub

    Private Sub btnload_Click(sender As Object, e As EventArgs) Handles btnload.Click
        lstrawdatapreview.Items.Clear()
        Dim selectedDataset As String = If(cmbdataset.SelectedItem IsNot Nothing, cmbdataset.SelectedItem.ToString(), "")

        If selectedDataset = "jobs.csv" Then
            Dim filePath As String = Path.Combine(Application.StartupPath, "jobs.csv")
            If File.Exists(filePath) Then
                Dim lines As String() = File.ReadAllLines(filePath)
                For Each line As String In lines
                    lstrawdatapreview.Items.Add(line)
                Next
            Else
                MessageBox.Show("jobs.csv file not found in the application folder.")
            End If
        Else
            MessageBox.Show("Please select 'jobs.csv' from the dropdown.")
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        lstrawdatapreview.Items.Clear()
    End Sub

    Private Async Sub btngeneratereport_Click(sender As Object, e As EventArgs) Handles btngeneratereport.Click
        lstformpreview.Items.Clear()
        Dim csvPath As String = Path.Combine(Application.StartupPath, "jobs.csv")
        If Not File.Exists(csvPath) Then
            MessageBox.Show("jobs.csv not found.")
            Return
        End If

        Dim csvData As String = File.ReadAllText(csvPath)
        Dim report As String = Await GetChatGPTReportAsync(csvData)

        If Not String.IsNullOrEmpty(report) Then
            lstformpreview.Items.Add(report)
        End If
    End Sub

    Private Async Function GetChatGPTReportAsync(csvData As String) As Task(Of String)
        Dim apiKey As String = "replace with own key"
        If String.IsNullOrWhiteSpace(apiKey) Then
            MessageBox.Show("OpenAI API key is missing in the code.")
            Return ""
        End If

        ' Add a delay to help avoid rate limiting
        Await Task.Delay(1500)

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}")

            Dim prompt As String = $"You are a project manager. Based on the following CSV job data, write a professional progress report based off the following data only respond with the report:{vbCrLf}{csvData}"

            Dim requestData = New With {
                .model = "gpt-3.5-turbo",
                .messages = New Object() {
                    New With {.role = "user", .content = prompt}
                },
                .temperature = 0.7
            }

            Dim content = New StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json")
            Try
                Dim response = Await client.PostAsync("https://api.openai.com/v1/chat/completions", content)
                If response.IsSuccessStatusCode Then
                    Dim resultJson = Await response.Content.ReadAsStringAsync()
                    Dim parsed = JsonConvert.DeserializeObject(Of OpenAIResponse)(resultJson)
                    Return parsed.choices(0).message.content.Trim()
                Else
                    MessageBox.Show("Error generating report: " & response.StatusCode.ToString())
                    Return ""
                End If
            Catch ex As Exception
                MessageBox.Show("Error calling OpenAI API: " & ex.Message)
                Return ""
            End Try
        End Using
    End Function

    Private Sub btnsendemail_Click(sender As Object, e As EventArgs) Handles btnsendemail.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Enter a recipient email address.")
            Return
        End If

        Try
            Using smtp As New SmtpClient("smtp.gmail.com", 587)
                smtp.Credentials = New Net.NetworkCredential("cohendiscord@gmail.com", "ujom ynat acuc rdgw ")
                smtp.EnableSsl = True

                Dim body As New StringBuilder()
                For Each line In lstformpreview.Items
                    body.AppendLine(line.ToString())
                Next

                Using mail As New MailMessage("your_email@gmail.com", TextBox1.Text)
                    mail.Subject = "Automated Progress Report"
                    mail.Body = body.ToString()
                    smtp.Send(mail)
                End Using
            End Using
            MessageBox.Show("Email sent successfully.")
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub

    ' Optional: Show full report in a message box on double-click
    Private Sub lstformpreview_DoubleClick(sender As Object, e As EventArgs) Handles lstformpreview.DoubleClick
        If lstformpreview.SelectedItem IsNot Nothing Then
            MessageBox.Show(lstformpreview.SelectedItem.ToString(), "Full Progress Report")
        End If
    End Sub

    ' Helper classes to parse OpenAI response
    Public Class OpenAIResponse
        Public Property choices As List(Of Choice)
    End Class

    Public Class Choice
        Public Property message As Message
    End Class

    Public Class Message
        Public Property content As String
    End Class

End Class
