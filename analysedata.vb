Imports System.IO

Public Class analysedata
    Dim jobs As New List(Of String())

    Private Sub analysedata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set up combo box
        cmbsortype.Items.AddRange(New String() {"Sort by Cost", "Sort by Employees", "Sort by Time Frame"})
        cmbsortype.SelectedIndex = 0

        ' Load CSV automatically
        LoadJobsFromCSV()
    End Sub

    Private Sub LoadJobsFromCSV()
        lstrawdata.Items.Clear()
        jobs.Clear()

        If Not File.Exists("jobs.csv") Then
            MessageBox.Show("jobs.csv file not found.")
            Return
        End If

        Dim lines = File.ReadAllLines("jobs.csv").ToList()
        If lines.Count <= 1 Then
            MessageBox.Show("No job data found.")
            Return
        End If

        lines.RemoveAt(0) ' Remove header line

        For Each line In lines
            Dim parts = line.Split(","c)
            If parts.Length = 4 Then jobs.Add(parts)
        Next

        DisplayJobs(jobs)
    End Sub

    Private Sub btnsort_Click(sender As Object, e As EventArgs) Handles btnsort.Click
        If jobs.Count = 0 Then
            MessageBox.Show("No job data to sort.")
            Return
        End If

        Dim sortType = cmbsortype.SelectedItem.ToString()
        Dim sortedJobs = BinaryInsertionSort(jobs, sortType)

        DisplayJobs(sortedJobs)
    End Sub

    Private Sub DisplayJobs(jobList As List(Of String()))
        lstrawdata.Items.Clear()
        For Each job In jobList
            lstrawdata.Items.Add($"{job(0)} - {job(1)} employees - ${job(2)} - {job(3)}")
        Next
    End Sub

    Private Function BinaryInsertionSort(input As List(Of String()), sortBy As String) As List(Of String())
        Dim sortedList As New List(Of String())

        For Each job In input
            Dim left As Integer = 0
            Dim right As Integer = sortedList.Count - 1
            Dim valToInsert = GetSortableField(job, sortBy)

            While left <= right
                Dim mid = (left + right) \ 2
                Dim midVal = GetSortableField(sortedList(mid), sortBy)

                If valToInsert.CompareTo(midVal) < 0 Then
                    right = mid - 1
                Else
                    left = mid + 1
                End If
            End While

            sortedList.Insert(left, job)
        Next

        Return sortedList
    End Function

    Private Function GetSortableField(job As String(), sortBy As String) As IComparable
        Select Case sortBy
            Case "Sort by Cost"
                Return Decimal.Parse(job(2))
            Case "Sort by Employees"
                Return Integer.Parse(job(1))
            Case "Sort by Time Frame"
                Return ConvertTimeFrameToDays(job(3))
            Case Else
                Return job(0)
        End Select
    End Function

    Private Function ConvertTimeFrameToDays(timeFrame As String) As Integer
        Dim parts = timeFrame.Split(" "c)
        If parts.Length < 2 Then Return 0

        Dim num As Integer = Integer.Parse(parts(0))
        Dim unit As String = parts(1).ToLower()

        Select Case unit
            Case "week", "weeks" : Return num * 7
            Case "month", "months" : Return num * 30
            Case Else : Return num
        End Select
    End Function
End Class
