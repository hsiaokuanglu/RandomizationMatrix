Public Class InputInfo
    Public fileNm As String
    Public width As Integer
    Public height As Integer
    Public types As Integer

    Public Sub GetInput()
        Try
            Console.Write("Save file to: ")
            fileNm = Console.ReadLine()
            Console.Write("width?: ")
            width = Console.ReadLine()
            Console.Write("height?: ")
            height = Console.ReadLine()
            Console.Write("types?: ")
            types = Console.ReadLine()
        Catch ex As Exception
            Console.WriteLine("Invalid format")
        End Try
    End Sub

End Class
