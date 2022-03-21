Imports System.Text.RegularExpressions

Public Class Form2

    Private CallerForm As Form1
    Private ReadOnly IdTemplate As String = "TMC-0000"

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub SetParent(_Parent As Form1)
        CallerForm = _Parent

        ' create custom Id number
        Dim LastId As String = CallerForm.LastIdUsed
        Dim Pattern As String = ".{0," + LastId.Length.ToString + "}$"
        Dim Regie As New Regex(Pattern)
        Dim NewIdNumber As String = Regie.Replace(IdTemplate, LastId.ToString, 1)

        IdNumberTextbox.Text = NewIdNumber
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If FirstnameTextbox.TextLength = 0 Or LastnameTextbox.TextLength = 0 Or AddressTextbox.TextLength = 0 Then
            MessageBox.Show("Please, fill-up all fields.", "Add person", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim NewPerson As New Person(
                IdNumberTextbox.Text,
                FirstnameTextbox.Text,
                LastnameTextbox.Text,
                MiddlenameTextbox.Text,
                AddressTextbox.Text
            )

            CallerForm.Persons.Add(NewPerson)
            CallerForm.UpdateTable()
            CallerForm.IncrementLastUsedId()

            Close()
        End If
    End Sub
End Class