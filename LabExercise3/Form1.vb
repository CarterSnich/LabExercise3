
Public Class Form1

    Public Persons As New List(Of Person)()

    Public LastIdUsed As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim AddForm As New Form2
        AddForm.SetParent(Me)
        AddForm.ShowDialog(Me)
    End Sub

    Public Sub UpdateTable()
        PersonsTable.Rows.Clear()

        For Each _Person As Person In Persons
            PersonsTable.Rows.Add(
                _Person.Id,
                _Person.Firstname,
                _Person.Lastname,
                _Person.Middlename,
                _Person.Address
            )
        Next
        ResetViews()
    End Sub

    Public Sub IncrementLastUsedId()
        LastIdUsed += 1
    End Sub

    Public Sub ResetViews()
        IdNumberTextbox.Clear()
        FirstnameTextbox.Clear()
        LastnameTextbox.Clear()
        MiddlenameTextbox.Clear()
        AddressTextbox.Clear()
        PersonsTable.ClearSelection()
    End Sub

    Private Sub ViewPersonData(sender As Object, e As DataGridViewCellMouseEventArgs) Handles PersonsTable.CellMouseDoubleClick
        If e.RowIndex > -1 Then
            Dim _Person As Person = Persons.Item(e.RowIndex)
            IdNumberTextbox.Text = _Person.Id
            FirstnameTextbox.Text = _Person.Firstname
            LastnameTextbox.Text = _Person.Lastname
            MiddlenameTextbox.Text = _Person.Middlename
            AddressTextbox.Text = _Person.Address
        Else
            PersonsTable.ClearSelection()
        End If
    End Sub

    Private Sub Editbtn_Click(sender As Object, e As EventArgs) Handles Editbtn.Click
        If IsNothing(PersonsTable.CurrentRow) Then Return

        Dim RowIndex As Integer = PersonsTable.CurrentRow.Index
        If RowIndex > -1 Then
            Dim EditForm As New Form3()
            EditForm.SetParent(Me)
            EditForm.SetSelectedRowIndex(RowIndex)
            EditForm.SetCurrentData(Persons.Item(RowIndex))
            EditForm.ShowDialog(Me)
        Else
            MessageBox.Show("No row selected.", "Edit person", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If IsNothing(PersonsTable.CurrentRow) Then
            MessageBox.Show("No row selected.", "Delete person", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim RowIndex As Integer = PersonsTable.CurrentRow.Index
            Dim _Person As Person = Persons.Item(RowIndex)
            Dim FullName As String = _Person.Firstname + " " + _Person.Lastname
            Dim Result As DialogResult = MessageBox.Show("Delete person?" & vbCrLf & FullName, "Delete person", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If Result = DialogResult.Yes Then
                Persons.RemoveAt(RowIndex)
                UpdateTable()
                MessageBox.Show("Deleted person successfully.", "Delete person", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class