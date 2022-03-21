
Public Class Person
    Public Id As String
    Public Firstname As String
    Public Lastname As String
    Public Middlename As String
    Public Address As String

    Public Sub New(mId As String, mFirstname As String, mLastname As String, mMiddlename As String, mAddress As String)
        Id = mId
        Firstname = mFirstname
        Lastname = mLastname
        Middlename = mMiddlename
        Address = mAddress
    End Sub

End Class