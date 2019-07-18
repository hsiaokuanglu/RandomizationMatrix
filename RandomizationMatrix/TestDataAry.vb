Imports RandomizedAry

Public Class TestDataAry
    Inherits DataAry
    Public TestRndAry() As Tuple
    Public Types As Integer

    Public Sub New(_width As Integer, _height As Integer, _fileNm As String, _types As Integer)
        MyBase.New(_width, _height, _fileNm)
        Types = _types
        TestRndAry = New Tuple(Width * Height - 1) {}
        'initalize testAry
        For a As Integer = 1 To Width
            For b As Integer = 1 To Height
                TestRndAry((a - 1) * Height + b - 1) = New Tuple(a, b)
            Next
        Next
        Dim numOfItem = Width * Height / Types
        For g As Integer = 0 To Types - 1
            For n As Integer = 0 To numOfItem - 1
                TestRndAry(n + (numOfItem * g)).SetD(g + 1)
            Next
        Next
    End Sub

    Public Sub RandomizeTestAry()
        Dim rnd As New Random()
        Shuffle(Of Tuple)(TestRndAry, rnd)
    End Sub

    Public Sub WriteTestAry()
        Using writer As System.IO.StreamWriter = New System.IO.StreamWriter(FileName)
            For i As Integer = 0 To Height * Width - 1
                writer.WriteLine($"{TestRndAry(i).A},{TestRndAry(i).B},1,{TestRndAry(i).D}")
            Next
        End Using
    End Sub
End Class
