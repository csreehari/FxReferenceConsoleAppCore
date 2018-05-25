Imports System
Imports PersonLibrary

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim persons = New List(Of Person)
        Dim personRepository As New PersonRepository()
        persons = personRepository.GetPersons()
        For Each person In persons
            Console.WriteLine($"{person.FirstName} {person.LastName} {person.DateOfBirth}")
        Next
        Console.ReadLine()
    End Sub
End Module
