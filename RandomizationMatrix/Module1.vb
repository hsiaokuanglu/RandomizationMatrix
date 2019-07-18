Imports System.IO
Imports RandomizedAry

Module Module1

    Sub Main()
        Dim fileNm As String = ""
        Dim width As Integer
        Dim height As Integer
        Dim types As Integer
        Dim data As InputInfo = New InputInfo
        'Console.WriteLine("Three columns:")
        'data.GetInput()
        'fileNm = data.fileNm
        'width = data.width
        'height = data.height
        'types = data.types

        'Console.WriteLine("initializing...")
        'Dim dataAry As DataAry = New DataAry(width, height, fileNm)
        'dataAry.WriteAry()
        'Console.WriteLine("Randomizing...")
        'dataAry.Randomize()
        'Console.WriteLine("Done Randomizing")
        'Console.WriteLine("Writing to File...")
        'Try
        '    dataAry.WriteAry()
        '    Console.WriteLine("Done Writing.")
        'Catch ex As Exception
        '    Console.WriteLine("Invalid file path")
        'End Try

        Console.WriteLine("Four columns (with types):")
        data.GetInput()
        fileNm = data.fileNm
        width = data.width
        height = data.height
        types = data.types
        Dim testDataAry As TestDataAry = New TestDataAry(width, height, fileNm, types)
        testDataAry.RandomizeTestAry()
        Try
            testDataAry.WriteTestAry()
        Catch ex As Exception
            Console.WriteLine("Invalid file path")
        End Try


        Console.ReadKey(True)
    End Sub

    Sub WriteToFileTest(ByVal a As Integer, ByVal b As Integer, ByVal d As Integer, ByVal fileLoc As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(fileLoc, True)
        file.WriteLine($"{a},{b},1,{d}")
        'Console.WriteLine($"{a},{b},1")
        file.Close()
    End Sub
End Module
