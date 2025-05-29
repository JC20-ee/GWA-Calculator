Public Class Form1
    Dim gradeList As New List(Of Double)
    Dim unitList As New List(Of Double)
    Private Sub BtnInput_Click(sender As Object, e As EventArgs) Handles BtnInput.Click
        If txtGrade.Text = "" Or txtUnits.Text = "" Then
            MessageBox.Show("Please enter both grade and units.", "Missing Input")
            Exit Sub
        End If

        Dim grade As Double
        Dim units As Double

        If Not Double.TryParse(txtGrade.Text, grade) Then
            MessageBox.Show("Grade must be a number.", "Invalid Input")
            Exit Sub
        End If

        If Not Double.TryParse(txtUnits.Text, units) Then
            MessageBox.Show("Units must be a number.", "Invalid Input")
            Exit Sub
        End If

        gradeList.Add(grade)
        unitList.Add(units)

        txtGrade.Clear()
        txtUnits.Clear()
        txtGrade.Focus()
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If gradeList.Count = 0 Then
            MessageBox.Show("No data to compute. Please input at least one course.", "No Entries")
            FormReset(Nothing, Nothing)
            Exit Sub
        End If

        Dim totalWeightedGrade As Double = 0
        Dim totalUnits As Double = 0

        For i As Integer = 0 To gradeList.Count - 1
            totalWeightedGrade += gradeList(i) * unitList(i)
            totalUnits += unitList(i)
        Next

        Dim gwa As Double = totalWeightedGrade / totalUnits

        txtGWA.Text = "GWA: " & Math.Round(gwa, 3)
    End Sub
    Private Sub FormReset(sender As Object, e As EventArgs) Handles Me.Load, btnReset.Click, ResetToolStripMenuItem.Click
        gradeList.Clear()
        unitList.Clear()
        txtGrade.Clear()
        txtUnits.Clear()
        txtGWA.Text = "GWA: N/A"
        txtGrade.Focus()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("This calculator helps compute your GWA.")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
