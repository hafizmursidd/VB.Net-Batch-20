Namespace PartTwo
    Module ModuleArray

        Function GetArray() As Integer()
            Dim arr() As Integer = New Integer(2) {1, 2, 3}
            Return arr
        End Function

        Sub DisplayArray()
            Dim arrayTemp() As Integer

            arrayTemp = GetArray()

            Console.WriteLine("Count : " & arrayTemp.Count)
            Console.WriteLine("Length : " & arrayTemp.Length)

            For i = 0 To arrayTemp.Count - 1
                Console.Write(arrayTemp(i))

            Next
        End Sub

        Sub InitListGeneric()
            Dim listCode As New List(Of String) From {"Codeid", "CodeX", "CodingId"}

            For Each list In listCode
                Console.WriteLine(list)
            Next
        End Sub

    End Module
End Namespace


