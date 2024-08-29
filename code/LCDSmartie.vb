
Imports System.Reflection.Emit

Public Class LCDSmartie

    Dim topValue As Integer = 100

    Dim topValue1 As Integer = 100
    Dim numVisibleBlocks(15) As Integer
    Dim remainingLinesToShow(15) As Integer
    Dim remainingBlocks(15) As Integer

    ' Simplified Calculation Method
    Public Sub CalculateNumberOfVisibleBlocks1(valIn As Integer, valInBlocks As Integer, funcNo As Integer)
        Dim percentage As Double = (valIn * 100.0) / topValue

        Dim totalNumberOfLines As Integer = valInBlocks * 5
        Dim barValue As Double = (percentage / 100) * valInBlocks
        Dim lineValue As Double = (percentage / 100) * totalNumberOfLines

        numVisibleBlocks(funcNo) = CInt(Fix(barValue))
        remainingLinesToShow(funcNo) = lineValue - (numVisibleBlocks(funcNo) * 5)
        remainingBlocks(funcNo) = valInBlocks - numVisibleBlocks(funcNo)
    End Sub

    ' Simplified Function for Output
    Public Function function1(param1 As String, param2 As String) As String
        ' Dim blocksProduced As Integer = 0
        If LCase(param1) = "about" Then
            Return "1 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0

            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 1)

            Dim BlockFull As String = "$CustomChar(1,0,31,0,31,31,0,31,0)"
            Dim BlockOne As String = "$CustomChar(2,0,31,0,16,16,0,31,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,31,0,24,24,0,31,0)"
            Dim BlockThree As String = "$CustomChar(4,0,31,0,28,28,0,31,0)"
            Dim BlockFour As String = "$CustomChar(5,0,31,0,30,30,0,31,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,31,0,0,0,0,31,0)"

            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(1)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(1)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(1)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(1) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If

    End Function


    Public Function function2(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "2 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 2)
            Dim BlockFull As String = "$CustomChar(1,0,0,0,31,31,0,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,0,16,21,0,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,0,24,29,0,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,0,28,29,0,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,0,30,31,0,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,21,0,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"
            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(2)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(2)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(2)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(2) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function


    Public Function function3(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "3 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 3)
            Dim BlockFull As String = "$CustomChar(1,0,0,31,31,31,31,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,16,16,23,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,24,24,24,27,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,28,28,28,29,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,30,30,30,30,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,31,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"
            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(3)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(3)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(3)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(3) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function


    Public Function function4(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "4 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 4)
            Dim BlockFull As String = "$CustomChar(1,0,0,0,31,0,0,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,0,16,0,0,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,0,24,0,0,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,0,24,0,0,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,0,28,0,0,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,4,0,0,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(4)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(4)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(4)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(4) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function

    Public Function function5(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "5 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 5)
            Dim BlockFull As String = "$CustomChar(1,0,0,21,10,21,10,21,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,0,16,0,16,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,16,8,16,8,16,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,20,8,20,8,20,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,20,10,20,10,20,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,21,0,0,0,21,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(5)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(5)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(5)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(5) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function


    Public Function function6(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "6 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 6)
            Dim BlockFull As String = "$CustomChar(1,31,0,31,31,31,31,0,31)"
            Dim BlockOne As String = "$CustomChar(2,31,0,16,16,16,16,0,31)"
            Dim BlockTwo As String = "$CustomChar(3,31,0,24,24,24,24,0,31)"
            Dim BlockThree As String = "$CustomChar(4,31,0,28,28,28,28,0,31)"
            Dim BlockFour As String = "$CustomChar(5,31,0,30,30,30,30,0,31)"
            Dim BlockEmpty As String = "$CustomChar(6,31,0,0,0,0,0,0,31)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(6)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(6)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(6)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(6) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function
    Public Function function7(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "8 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 8)
            Dim BlockFull As String = "$CustomChar(1,31,31,31,0,31,31,31,0)"
            Dim BlockOne As String = "$CustomChar(2,31,16,31,0,31,16,31,0)"
            Dim BlockTwo As String = "$CustomChar(3,31,24,31,0,31,24,31,0)"
            Dim BlockThree As String = "$CustomChar(4,31,28,31,0,31,28,31,0)"
            Dim BlockFour As String = "$CustomChar(5,31,30,31,0,31,30,31,0)"
            Dim BlockEmpty As String = "$CustomChar(6,31,0,31,0,31,0,31,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(8)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(8)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(8)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(8) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function

    Public Function function8(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "7 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 7)
            Dim BlockFull As String = "$CustomChar(1,0,0,0,31,31,31,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,0,16,16,16,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,0,24,24,24,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,0,28,28,28,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,0,30,30,30,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,0,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"
            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(7)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(7)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(7)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(7) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function



    Public Function function9(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "9 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 9)
            Dim BlockFull As String = "$CustomChar(1,0,0,31,31,0,0,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,16,0,0,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,24,24,0,0,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,28,28,0,0,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,30,30,0,0,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,0,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(9)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(9)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(9)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(9) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function

    Public Function function10(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "10 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 10)
            Dim BlockFull As String = "$CustomChar(1,0,0,21,10,21,10,21,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,0,16,0,16,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,16,8,16,8,16,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,20,8,20,8,20,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,20,10,20,10,20,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,0,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(10)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(10)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(10)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(10) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function





    Public Function function13(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "13 tailless bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 13)
            Dim BlockFull As String = "$CustomChar(1,0,0,31,31,31,31,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,16,16,16,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,24,24,24,24,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,28,28,28,28,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,30,30,30,30,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,30,30,30,30,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"
            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(13)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(13)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(13)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(13) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function

    Public Function function14(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "14 tailless bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 14)
            Dim BlockFull As String = "$CustomChar(1,0,0,0,31,0,0,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,0,16,0,0,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,0,24,0,0,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,0,24,0,0,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,0,28,0,0,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,30,0,0,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            For i As Integer = 1 To numVisibleBlocks(14)
                visibleBar &= callBlockFull
                '  blocksProduced = blocksProduced + 1
            Next

            Select Case remainingLinesToShow(14)
                Case 1
                    visibleBar &= callBlockOne
                Case 2
                    visibleBar &= callBlockTwo
                Case 3
                    visibleBar &= callBlockThree
                Case 4
                    visibleBar &= callBlockFour
                Case 5
                    visibleBar &= callBlockFull
            End Select

            Dim remainBlocks As String = ""
            If param1 Mod 10 = 0 Then
                For i As Integer = 1 To remainingBlocks(14)
                    remainBlocks &= callBlockEmpty
                Next
            Else
                For i As Integer = 1 To remainingBlocks(14) - 1
                    remainBlocks &= callBlockEmpty
                Next
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
            ' Return " Full:" & blocksProduced & " Remain:" & remainingBlocks(1)
        End If
    End Function



    Public Function function19(param1 As String, param2 As String)

        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "diagnostics for barra "
        Else
            '  CalculateNumberOfVisibleBlocks1(Convert.ToInt64(param1), Convert.ToInt64(param2), 1)
            Return "Not in dev mode"
        End If

    End Function


    Public Function function20(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "barra from LCD Smartie"
        Else
            Return "barra ver1.0 created by limbo"
        End If
    End Function



    Public Function SmartieDemo()
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
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function

    Public Function SmartieInfo()
        Return "Developer: Nikos Georgousis (Limbo)" & vbNewLine & "Version: 1.2 "
    End Function

    Public Function GetMinRefreshInterval() As Integer

        Return 5 ' 5 ms 

    End Function



End Class
