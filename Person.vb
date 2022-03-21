Imports Microsoft.VisualBasic


Class Person
    Private Id As String
    Private Firstname As String
    Private Lastname As String
    Private Middlename As String
    Private Address As String

    Public Sub New(mId As String, mFirstname As String, mLastname As String, mMiddlename As String, mAddress As String)
        Id = mId
        Firstname = mFirstname
        Lastname = mLastname
        Middlename = mMiddlename
        Address = mAddress
    End Sub

End Class