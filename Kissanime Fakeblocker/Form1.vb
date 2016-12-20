Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Hosts As String = Environment.SystemDirectory & "\drivers\etc\hosts"
        Dim sr As New IO.StreamReader(Hosts)
        Dim input As String = sr.ReadToEnd()
        sr.Close()
        Dim output As String = input + vbNewLine + "104.25.20.21 kiss-anime.me"
        Dim output1 As String = vbNewLine + "104.25.20.21 kissanime.to"
        Dim output2 As String = vbNewLine + "104.25.20.21 kissanime.ru"
        Dim output3 As String = vbNewLine + "104.25.20.21 kissanime.io"
        Dim output4 As String = vbNewLine + "104.25.20.21 kissanime.com"
        Dim output5 As String = vbNewLine + "104.25.20.21 www.kiss-anime.me"
        Dim output6 As String = vbNewLine + "104.25.20.21 www.kissanime.to"
        Dim output7 As String = vbNewLine + "104.25.20.21 www.kissanime.ru"
        Dim output8 As String = vbNewLine + "104.25.20.21 www.kissanime.io"
        Dim output9 As String = vbNewLine + "104.25.20.21 www.kissanime.com"
        Dim sw As New IO.StreamWriter(Hosts)
        sw.Write(output)
        sw.Write(output1)
        sw.Write(output2)
        sw.Write(output3)
        sw.Write(output4)
        sw.Write(output5)
        sw.Write(output6)
        sw.Write(output7)
        sw.Write(output8)
        sw.Write(output9)
        sw.Close()
    End Sub
End Class
