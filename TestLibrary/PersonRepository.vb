Public Class PersonRepository

    Function GetPersons() As List(Of Person)
        Dim persons As List(Of Person) = New List(Of Person)
        Dim sree As Person = New Person()
        Dim dOB As String = "16/10/1988"
        sree.FirstName = "Sreehari"
        sree.LastName = "Chinta"
        If IsDate(dOB) Then
            sree.DateOfBirth = DateTime.Parse(dOB)
        End If
        Return persons
    End Function

End Class
