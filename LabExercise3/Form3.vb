Public Class Form3
    Private CallerForm As Form1
    Private RowIndex As Integer

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Sub SetParent(mParent As Form1)
        CallerForm = mParent
    End Sub

    Public Sub SetSelectedRowIndex(mRowIndex As Integer)
        RowIndex = mRowIndex
    End Sub

    Public Sub SetCurrentData(mPerson As Person)
        IdNumberTextbox.Text = mPerson.Id
        FirstnameTextbox.Text = mPerson.Firstname
        LastnameTextbox.Text = mPerson.Lastname
        MiddlenameTextbox.Text = mPerson.Middlename
        AddressTextbox.Text = mPerson.Address
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Close()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If FirstnameTextbox.TextLength = 0 Or LastnameTextbox.TextLength = 0 Or AddressTextbox.TextLength = 0 Then
            MessageBox.Show("Please, fill-up all fields.", "Edit person", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim NewPerson As New Person(
                IdNumberTextbox.Text,
                FirstnameTextbox.Text,
                LastnameTextbox.Text,
                MiddlenameTextbox.Text,
                AddressTextbox.Text
            )

            CallerForm.Persons.Item(RowIndex) = NewPerson
            CallerForm.UpdateTable()

            Close()
        End If
    End Sub

End Class