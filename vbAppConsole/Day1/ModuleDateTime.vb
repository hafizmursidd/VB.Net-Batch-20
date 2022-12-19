Module ModuleDateTime

    Sub ShowDate()
        Dim date1 As Date = #12/15/2022 10:55:00 AM#

        Console.WriteLine("Date1 : " & date1)

        Dim currentDate As Date = Date.Now

        Dim lusa As Date
        lusa = date1.AddDays(6)
        Console.WriteLine("Six days after date : " & lusa)

        Dim hari, bulan, tahun As Integer

        hari = Day(currentDate)
        bulan = Month(currentDate)
        tahun = Year(currentDate)

        Console.WriteLine("Tahun : " & tahun & vbCrLf & "Bulan : " & bulan & vbCrLf & "Hari : " & hari)

    End Sub
End Module
