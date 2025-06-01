Imports System.Reflection.Emit

Public Class LCDSmartie
    Dim topValue As Integer = 100
    Dim numVisibleBlocks(15) As Integer
    Dim remainingLinesToShow(15) As Integer
    Dim remainingBlocks(15) As Integer

    ' Corrected Calculation Method - Guarantees exact block count
    Public Sub CalculateNumberOfVisibleBlocks1(valIn As Integer, valInBlocks As Integer, funcNo As Integer)
        ' Ensure value is within 0-100 range
        valIn = Math.Max(0, Math.Min(valIn, 100))

        Dim percentage As Double = valIn / 100.0
        Dim totalLines As Integer = valInBlocks * 5
        Dim linesToFill As Integer = CInt(Math.Floor(totalLines * percentage))

        ' Calculate full blocks and partial block lines
        numVisibleBlocks(funcNo) = linesToFill \ 5
        remainingLinesToShow(funcNo) = linesToFill Mod 5

        ' Remaining blocks are always total blocks - full blocks - (1 if partial exists)
        remainingBlocks(funcNo) = valInBlocks - numVisibleBlocks(funcNo) - IIf(remainingLinesToShow(funcNo) > 0, 1, 0)
    End Sub

    ' Unified block generation method for all functions
    Private Function GenerateBar(funcNo As Integer, totalBlocks As Integer) As String
        Dim visibleBar As String = ""

        ' Add full blocks
        For i As Integer = 1 To numVisibleBlocks(funcNo)
            visibleBar &= "$Chr(0)" ' Full block
        Next

        ' Add partial block if needed
        If remainingLinesToShow(funcNo) > 0 Then
            visibleBar &= "$Chr(" & remainingLinesToShow(funcNo) & ")" ' Partial blocks 1-4
        End If

        ' Add empty blocks to reach exact count
        Dim emptyBlocksNeeded As Integer = totalBlocks - numVisibleBlocks(funcNo) - IIf(remainingLinesToShow(funcNo) > 0, 1, 0)
        For i As Integer = 1 To emptyBlocksNeeded
            visibleBar &= "$Chr(5)" ' Empty block
        Next

        Return visibleBar
    End Function

    ' Function 1 - Solid block with frame
    Public Function function1(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "1 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 1)

            Dim defineChars As String = "$CustomChar(1,0,31,0,31,31,0,31,0)" &  ' Full
                                       "$CustomChar(2,0,31,0,16,16,0,31,0)" &  ' 1/5
                                       "$CustomChar(3,0,31,0,24,24,0,31,0)" &  ' 2/5
                                       "$CustomChar(4,0,31,0,28,28,0,31,0)" &  ' 3/5
                                       "$CustomChar(5,0,31,0,30,30,0,31,0)" &  ' 4/5
                                       "$CustomChar(6,0,31,0,0,0,0,31,0)"      ' Empty

            Return defineChars & GenerateBar(1, totalBlocks)
        End If
    End Function

    ' Function 2 - Thin horizontal bar
    Public Function function2(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "2 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 2)

            Dim defineChars As String = "$CustomChar(1,0,0,0,31,31,0,0,0)" &
                                       "$CustomChar(2,0,0,0,16,21,0,0,0)" &
                                       "$CustomChar(3,0,0,0,24,29,0,0,0)" &
                                       "$CustomChar(4,0,0,0,28,29,0,0,0)" &
                                       "$CustomChar(5,0,0,0,30,31,0,0,0)" &
                                       "$CustomChar(6,0,0,0,0,21,0,0,0)"

            Return defineChars & GenerateBar(2, totalBlocks)
        End If
    End Function

    ' Function 3 - Thick centered bar
    Public Function function3(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "3 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 3)

            Dim defineChars As String = "$CustomChar(1,0,0,31,31,31,31,0,0)" &
                                       "$CustomChar(2,0,0,16,16,16,23,0,0)" &
                                       "$CustomChar(3,0,0,24,24,24,27,0,0)" &
                                       "$CustomChar(4,0,0,28,28,28,29,0,0)" &
                                       "$CustomChar(5,0,0,30,30,30,30,0,0)" &
                                       "$CustomChar(6,0,0,0,0,0,31,0,0)"

            Return defineChars & GenerateBar(3, totalBlocks)
        End If
    End Function

    ' Function 4 - Vertical line
    Public Function function4(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "4 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 4)

            Dim defineChars As String = "$CustomChar(1,0,0,0,31,0,0,0,0)" &
                                       "$CustomChar(2,0,0,0,16,0,0,0,0)" &
                                       "$CustomChar(3,0,0,0,24,0,0,0,0)" &
                                       "$CustomChar(4,0,0,0,24,0,0,0,0)" &
                                       "$CustomChar(5,0,0,0,28,0,0,0,0)" &
                                       "$CustomChar(6,0,0,0,4,0,0,0,0)"

            Return defineChars & GenerateBar(4, totalBlocks)
        End If
    End Function

    ' Function 5 - Checkerboard pattern
    Public Function function5(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "5 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 5)

            Dim defineChars As String = "$CustomChar(1,0,0,21,10,21,10,21,0)" &
                                       "$CustomChar(2,0,0,21,0,16,0,21,0)" &
                                       "$CustomChar(3,0,0,21,8,16,8,21,0)" &
                                       "$CustomChar(4,0,0,21,8,20,8,21,0)" &
                                       "$CustomChar(5,0,0,12,10,20,10,21,0)" &
                                       "$CustomChar(6,0,0,21,0,0,0,21,0)"

            Return defineChars & GenerateBar(5, totalBlocks)
        End If
    End Function

    ' Function 6 - Block with side borders
    Public Function function6(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "6 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 6)

            Dim defineChars As String = "$CustomChar(1,31,0,31,31,31,31,0,31)" &
                                       "$CustomChar(2,31,0,16,16,16,16,0,31)" &
                                       "$CustomChar(3,31,0,24,24,24,24,0,31)" &
                                       "$CustomChar(4,31,0,28,28,28,28,0,31)" &
                                       "$CustomChar(5,31,0,30,30,30,30,0,31)" &
                                       "$CustomChar(6,31,0,0,0,0,0,0,31)"

            Return defineChars & GenerateBar(6, totalBlocks)
        End If
    End Function

    ' Function 7 - Bottom-heavy block
    Public Function function7(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "7 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 7)

            Dim defineChars As String = "$CustomChar(1,31,31,31,0,31,31,31,0)" &
                                     "$CustomChar(2,31,16,31,0,31,16,31,0)" &
                                       "$CustomChar(3,31,24,31,0,31,24,31,0)" &
                                       "$CustomChar(4,31,28,31,0,31,28,31,0)" &
                                      "$CustomChar(5,31,30,31,0,31,30,31,0)" &
                                       "$CustomChar(6,31,0,31,0,31,0,31,0)"

            Return defineChars & GenerateBar(7, totalBlocks)
        End If
    End Function

    ' Function 8 - Top-heavy block
    Public Function function8(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "8 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 8)

            Dim defineChars As String = "$CustomChar(1,0,0,0,31,31,31,0,0)" &
                                     "$CustomChar(2,0,0,0,16,31,16,0,0)" &
                                  "$CustomChar(3,0,0,0,24,31,24,0,0)" &
                                   "$CustomChar(4,0,0,0,28,31,28,0,0)" &
                                     "$CustomChar(5,0,0,0,30,31,30,0,0)" &
                                      "$CustomChar(6,0,0,0,0,31,0,0,0)"

            Return defineChars & GenerateBar(8, totalBlocks)
        End If
    End Function

    ' Function 9 - Small top block
    Public Function function9(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "9 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 9)

            Dim defineChars As String = "$CustomChar(1,0,0,31,31,0,0,0,0)" &
                                       "$CustomChar(2,0,0,16,31,0,0,0,0)" &
                                       "$CustomChar(3,0,0,24,31,0,0,0,0)" &
                                       "$CustomChar(4,0,0,28,31,0,0,0,0)" &
                                       "$CustomChar(5,0,0,30,31,0,0,0,0)" &
                                        "$CustomChar(6,0,0,0,31,0,0,0,0)"

            Return defineChars & GenerateBar(9, totalBlocks)
        End If
    End Function

    ' Function 10 - Diagonal pattern
    Public Function function10(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "10 bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 10)

            Dim defineChars As String = "$CustomChar(1,0,0,21,10,21,10,21,0)" &
                                       "$CustomChar(2,0,0,16,0,16,10,21,0)" &
                                       "$CustomChar(3,0,0,16,8,16,10,21,0)" &
                                       "$CustomChar(4,0,0,20,8,20,10,21,0)" &
                                       "$CustomChar(5,0,0,20,10,20,10,21,0)" &
                                       "$CustomChar(6,0,0,0,0,0,10,21,0)"

            Return defineChars & GenerateBar(10, totalBlocks)
        End If
    End Function
    Public Function function11(param1 As String, param2 As String) As String
        '  If LCase(param1) = "about" Then

        Return "not defined"
        '   End If
    End Function
    Public Function function12(param1 As String, param2 As String) As String
        ' If LCase(param1) = "about" Then

        Return "not defined"
        '  End If
    End Function

    ' Function 13 - Tailless block (variant 1)
    Public Function function13(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "13 tailless bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 13)

            Dim defineChars As String = "$CustomChar(1,0,0,31,31,31,31,0,0)" &
                                       "$CustomChar(2,0,0,16,16,16,16,0,0)" &
                                       "$CustomChar(3,0,0,24,24,24,24,0,0)" &
                                       "$CustomChar(4,0,0,28,28,28,28,0,0)" &
                                       "$CustomChar(5,0,0,30,30,30,30,0,0)" &
                                       "$CustomChar(6,0,0,0,0,0,0,0,0)"

            Return defineChars & GenerateBar(13, totalBlocks)
        End If
    End Function

    ' Function 14 - Tailless block (variant 2)
    Public Function function14(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "14 tailless bar"
        Else
            If String.IsNullOrEmpty(param1) Then param1 = "0"
            If String.IsNullOrEmpty(param2) Then param2 = "0"

            Dim value As Integer = Convert.ToInt32(param1)
            Dim totalBlocks As Integer = Convert.ToInt32(param2)
            If totalBlocks <= 0 Then Return String.Empty

            CalculateNumberOfVisibleBlocks1(value, totalBlocks, 14)

            Dim defineChars As String = "$CustomChar(1,0,0,0,31,0,0,0,0)" &
                                       "$CustomChar(2,0,0,0,16,0,0,0,0)" &
                                       "$CustomChar(3,0,0,0,24,0,0,0,0)" &
                                       "$CustomChar(4,0,0,0,24,0,0,0,0)" &
                                       "$CustomChar(5,0,0,0,28,0,0,0,0)" &
                                       "$CustomChar(6,0,0,0,0,0,0,0,0)"

            Return defineChars & GenerateBar(14, totalBlocks)
        End If
    End Function


    Public Function function15(param1 As String, param2 As String) As String
        '   If LCase(param1) = "about" Then

        Return "Not defined. Use functions 1~10 and 13,14"
        '   End If
    End Function
    Public Function function16(param1 As String, param2 As String) As String
        '  If LCase(param1) = "about" Then


        Return "Not defined. Use functions 1~10 and 13,14"
        '  End If
    End Function
    Public Function function17(param1 As String, param2 As String) As String
        '  If LCase(param1) = "about" Then


        Return "Not defined. Use functions 1~10 and 13,14"
        '  End If
    End Function
    Public Function function18(param1 As String, param2 As String) As String
        '   If LCase(param1) = "about" Then

        Return "Not defined. Use functions 1~10 and 13,14"
        '  End If
    End Function

    ' Diagnostic function
    Public Function function19(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "diagnostics for barra"
        Else
            Return "Not in dev mode"
        End If
    End Function

    ' Credits function
    Public Function function20(param1 As String, param2 As String) As String
        If LCase(param1) = "about" Then
            Return "barra from LCD Smartie"
        Else
            Return "barra ver1.3 created by limbo"
        End If
    End Function

    ' Demo function
    Public Function SmartieDemo() As String
        Dim demolist As New Text.StringBuilder()
        demolist.AppendLine("barra for LCD Smartie")
        demolist.AppendLine("This plugin creates customized bars from LCD Smartie")
        demolist.AppendLine("----- Functions 1 to 10 are ten different styles of bars -----")
        demolist.AppendLine("$dll(barra,FunctionNo,Value,NoOfBlocks)")
        demolist.AppendLine("see EXAMPLES below")
        demolist.AppendLine("------ Function20 ------")
        demolist.AppendLine(">>> Credits <<<")
        demolist.AppendLine("---------------------------------------------------------------------------------------------------------")
        demolist.AppendLine("### EXAMPLES ###")
        demolist.AppendLine("CPU $dll(barra,1,$SysCPUUsage,16)")
        demolist.AppendLine("MEM $dll(barra,1,$MemU%,20)")
        demolist.AppendLine("Test for value 74% on 40 blocks $dll(barra,4,74,40)")
        demolist.AppendLine("Test for value 57% on 10 blocks $dll(barra,3,57,10)")
        demolist.AppendLine("Note: Functions available: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13 & 14")
        demolist.AppendLine("Note: 13 And 14 are headless bars")
        demolist.AppendLine("*** Visit ***")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> New official development branch (latest version)")
        demolist.AppendLine("https://github.com/LCD-Smartie/LCDSmartie")
        Return demolist.ToString()
    End Function

    ' Info function
    Public Function SmartieInfo() As String
        Return "Developer: Nikos Georgousis (Limbo)" & vbNewLine & "Version: 1.3 "
    End Function

    ' Refresh interval
    Public Function GetMinRefreshInterval() As Integer
        Return 5 ' 5 ms
    End Function
End Class