
Imports System.Reflection.Emit

Public Class LCDSmartie

    Dim topValue As Integer = 100

    Dim numVisibleBlocks1 As Integer = 0
    Dim remainingLinesToShow1 As Integer = 0
    Dim remainingBlocks1 As Integer = 0

    Dim numVisibleBlocks2 As Integer = 0
    Dim remainingLinesToShow2 As Integer = 0
    Dim remainingBlocks2 As Integer = 0

    Dim numVisibleBlocks3 As Integer = 0
    Dim remainingLinesToShow3 As Integer = 0
    Dim remainingBlocks3 As Integer = 0

    Dim numVisibleBlocks4 As Integer = 0
    Dim remainingLinesToShow4 As Integer = 0
    Dim remainingBlocks4 As Integer = 0

    Dim numVisibleBlocks5 As Integer = 0
    Dim remainingLinesToShow5 As Integer = 0
    Dim remainingBlocks5 As Integer = 0


    Dim numVisibleBlocks6 As Integer = 0
    Dim remainingLinesToShow6 As Integer = 0
    Dim remainingBlocks6 As Integer = 0

    Dim numVisibleBlocks7 As Integer = 0
    Dim remainingLinesToShow7 As Integer = 0
    Dim remainingBlocks7 As Integer = 0

    Dim numVisibleBlocks8 As Integer = 0
    Dim remainingLinesToShow8 As Integer = 0
    Dim remainingBlocks8 As Integer = 0

    Dim numVisibleBlocks9 As Integer = 0
    Dim remainingLinesToShow9 As Integer = 0
    Dim remainingBlocks9 As Integer = 0

    Dim numVisibleBlocks10 As Integer = 0
    Dim remainingLinesToShow10 As Integer = 0
    Dim remainingBlocks10 As Integer = 0


    Dim numVisibleBlocks11 As Integer = 0
    Dim remainingLinesToShow11 As Integer = 0
    Dim remainingBlocks11 As Integer = 0

    Dim numVisibleBlocks12 As Integer = 0
    Dim remainingLinesToShow12 As Integer = 0
    Dim remainingBlocks12 As Integer = 0

    Dim numVisibleBlocks13 As Integer = 0
    Dim remainingLinesToShow13 As Integer = 0
    Dim remainingBlocks13 As Integer = 0

    Dim numVisibleBlocks14 As Integer = 0
    Dim remainingLinesToShow14 As Integer = 0
    Dim remainingBlocks14 As Integer = 0

    Dim numVisibleBlocks15 As Integer = 0
    Dim remainingLinesToShow15 As Integer = 0
    Dim remainingBlocks15 As Integer = 0




    Public Sub CalculateNumberOfVisibleBlocks(valIn As Integer, valInBlocks As Integer, funcNo As Integer)
        Dim percentage As Double = (valIn * 100.0) / topValue

        Dim totalNumberOfLines As Integer = valInBlocks * 5
        Dim barValue As Double = (percentage / 100) * valInBlocks ' this is the actual percentage of bars 
        Dim lineValue As Double = (percentage / 100) * (valInBlocks * 5) ' this is the actual percentage of bars 

        If funcNo = 1 Then
            numVisibleBlocks1 = CInt(Fix(barValue))
            remainingLinesToShow1 = lineValue - (numVisibleBlocks1 * 5)
            remainingBlocks1 = valInBlocks - numVisibleBlocks1
        ElseIf funcNo = 2 Then
            numVisibleBlocks2 = CInt(Fix(barValue))
            remainingLinesToShow2 = lineValue - (numVisibleBlocks2 * 5)
            remainingBlocks2 = valInBlocks - numVisibleBlocks2
        ElseIf funcNo = 3 Then
            numVisibleBlocks3 = CInt(Fix(barValue))
            remainingLinesToShow3 = lineValue - (numVisibleBlocks3 * 5)
            remainingBlocks3 = valInBlocks - numVisibleBlocks3
        ElseIf funcNo = 4 Then
            numVisibleBlocks4 = CInt(Fix(barValue))
            remainingLinesToShow4 = lineValue - (numVisibleBlocks4 * 5)
            remainingBlocks4 = valInBlocks - numVisibleBlocks4
        ElseIf funcNo = 5 Then
            numVisibleBlocks5 = CInt(Fix(barValue))
            remainingLinesToShow5 = lineValue - (numVisibleBlocks5 * 5)
            remainingBlocks5 = valInBlocks - numVisibleBlocks5
        ElseIf funcNo = 6 Then
            numVisibleBlocks6 = CInt(Fix(barValue))
            remainingLinesToShow6 = lineValue - (numVisibleBlocks6 * 5)
            remainingBlocks6 = valInBlocks - numVisibleBlocks6
        ElseIf funcNo = 7 Then
            numVisibleBlocks7 = CInt(Fix(barValue))
            remainingLinesToShow7 = lineValue - (numVisibleBlocks7 * 5)
            remainingBlocks7 = valInBlocks - numVisibleBlocks7
        ElseIf funcNo = 8 Then
            numVisibleBlocks8 = CInt(Fix(barValue))
            remainingLinesToShow8 = lineValue - (numVisibleBlocks8 * 5)
            remainingBlocks8 = valInBlocks - numVisibleBlocks8
        ElseIf funcNo = 9 Then
            numVisibleBlocks9 = CInt(Fix(barValue))
            remainingLinesToShow9 = lineValue - (numVisibleBlocks9 * 5)
            remainingBlocks9 = valInBlocks - numVisibleBlocks9
        ElseIf funcNo = 10 Then
            numVisibleBlocks10 = CInt(Fix(barValue))
            remainingLinesToShow10 = lineValue - (numVisibleBlocks10 * 5)
            remainingBlocks10 = valInBlocks - numVisibleBlocks10


        ElseIf funcNo = 11 Then
            numVisibleBlocks11 = CInt(Fix(barValue))
            remainingLinesToShow11 = lineValue - (numVisibleBlocks11 * 5)
            remainingBlocks5 = valInBlocks - numVisibleBlocks5
        ElseIf funcNo = 12 Then
            numVisibleBlocks12 = CInt(Fix(barValue))
            remainingLinesToShow12 = lineValue - (numVisibleBlocks12 * 5)
            remainingBlocks5 = valInBlocks - numVisibleBlocks5
        ElseIf funcNo = 13 Then
            numVisibleBlocks13 = CInt(Fix(barValue))
            remainingLinesToShow13 = lineValue - (numVisibleBlocks13 * 5)
            remainingBlocks5 = valInBlocks - numVisibleBlocks5
        ElseIf funcNo = 14 Then
            numVisibleBlocks14 = CInt(Fix(barValue))
            remainingLinesToShow14 = lineValue - (numVisibleBlocks14 * 5)
            remainingBlocks5 = valInBlocks - numVisibleBlocks5
        ElseIf funcNo = 15 Then
            numVisibleBlocks15 = CInt(Fix(barValue))
            remainingLinesToShow15 = lineValue - (numVisibleBlocks15 * 5)
            remainingBlocks5 = valInBlocks - numVisibleBlocks5
        End If



    End Sub



    Public Function function1(param1 As String, param2 As String)

        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "1 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 1)
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
            Dim visibleBar As String

            If remainingLinesToShow1 = 1 Then
                numVisibleBlocks1 = numVisibleBlocks1 - 1
            ElseIf remainingLinesToShow1 = 2 Then
                numVisibleBlocks1 = numVisibleBlocks1 - 1
            ElseIf remainingLinesToShow1 = 3 Then
                numVisibleBlocks1 = numVisibleBlocks1 - 1
            ElseIf remainingLinesToShow1 = 4 Then
                numVisibleBlocks1 = numVisibleBlocks1 - 1
            ElseIf remainingLinesToShow1 = 5 Then
                numVisibleBlocks1 = numVisibleBlocks1 - 1
            End If


            For i As Integer = 1 To numVisibleBlocks1
                visibleBar &= callBlockFull
            Next

            If remainingLinesToShow1 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow1 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow1 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow1 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow1 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks1
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks

        End If

    End Function

    Public Function function2(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "2 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 2)
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
            Dim visibleBar As String

            If remainingLinesToShow2 = 1 Then
                numVisibleBlocks2 = numVisibleBlocks2 - 1
            ElseIf remainingLinesToShow2 = 2 Then
                numVisibleBlocks2 = numVisibleBlocks2 - 1
            ElseIf remainingLinesToShow2 = 3 Then
                numVisibleBlocks2 = numVisibleBlocks2 - 1
            ElseIf remainingLinesToShow2 = 4 Then
                numVisibleBlocks2 = numVisibleBlocks2 - 1
            ElseIf remainingLinesToShow2 = 5 Then
                numVisibleBlocks2 = numVisibleBlocks2 - 1
            End If


            For i As Integer = 1 To numVisibleBlocks2
                visibleBar &= callBlockFull
            Next

            If remainingLinesToShow2 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow2 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow2 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow2 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow2 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks2
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks


        End If
    End Function


    Public Function function3(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "3 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 3)
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
            If remainingLinesToShow3 = 1 Then
                numVisibleBlocks3 = numVisibleBlocks3 - 1
            ElseIf remainingLinesToShow3 = 2 Then
                numVisibleBlocks3 = numVisibleBlocks3 - 1
            ElseIf remainingLinesToShow3 = 3 Then
                numVisibleBlocks3 = numVisibleBlocks3 - 1
            ElseIf remainingLinesToShow3 = 4 Then
                numVisibleBlocks3 = numVisibleBlocks3 - 1
            ElseIf remainingLinesToShow3 = 5 Then
                numVisibleBlocks3 = numVisibleBlocks3 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks3
                visibleBar &= callBlockFull
            Next

            If remainingLinesToShow3 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow3 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow3 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow3 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow3 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If
            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks3
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks




        End If
    End Function


    Public Function function4(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "4 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 4)
            Dim BlockFull As String = "$CustomChar(1,0,0,0,31,0,0,0,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,0,16,0,0,0,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,0,24,0,0,0,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,0,24,0,0,0,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,0,28,0,0,0,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,4,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            If remainingLinesToShow4 = 1 Then
                numVisibleBlocks4 = numVisibleBlocks4 - 1
            ElseIf remainingLinesToShow4 = 2 Then
                numVisibleBlocks4 = numVisibleBlocks4 - 1
            ElseIf remainingLinesToShow4 = 3 Then
                numVisibleBlocks4 = numVisibleBlocks4 - 1
            ElseIf remainingLinesToShow4 = 4 Then
                numVisibleBlocks4 = numVisibleBlocks4 - 1
            ElseIf remainingLinesToShow4 = 5 Then
                numVisibleBlocks4 = numVisibleBlocks4 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks4
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow4 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow4 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow4 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow4 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow4 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If


            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks4
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks


        End If
    End Function

    Public Function function5(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "5 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 5)
            Dim BlockFull As String = "$CustomChar(1,0,0,21,10,21,10,21,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,0,16,0,16,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,16,8,16,8,16,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,20,8,20,8,20,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,20,10,20,10,20,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,0,0,21)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            If remainingLinesToShow5 = 1 Then
                numVisibleBlocks5 = numVisibleBlocks5 - 1
            ElseIf remainingLinesToShow5 = 2 Then
                numVisibleBlocks5 = numVisibleBlocks5 - 1
            ElseIf remainingLinesToShow5 = 3 Then
                numVisibleBlocks5 = numVisibleBlocks5 - 1
            ElseIf remainingLinesToShow5 = 4 Then
                numVisibleBlocks5 = numVisibleBlocks5 - 1
            ElseIf remainingLinesToShow5 = 5 Then
                numVisibleBlocks5 = numVisibleBlocks5 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks5
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow5 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow5 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow5 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow5 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow5 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If


            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks5
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks


        End If
    End Function


    Public Function function6(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "6 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 6)
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

            If remainingLinesToShow6 = 1 Then
                numVisibleBlocks6 = numVisibleBlocks6 - 1
            ElseIf remainingLinesToShow6 = 2 Then
                numVisibleBlocks6 = numVisibleBlocks6 - 1
            ElseIf remainingLinesToShow6 = 3 Then
                numVisibleBlocks6 = numVisibleBlocks6 - 1
            ElseIf remainingLinesToShow6 = 4 Then
                numVisibleBlocks6 = numVisibleBlocks6 - 1
            ElseIf remainingLinesToShow6 = 5 Then
                numVisibleBlocks6 = numVisibleBlocks6 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks6
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow6 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow6 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow6 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow6 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow6 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If


            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks6
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks


        End If
    End Function


    Public Function function7(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "7 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 7)
            Dim BlockFull As String = "$CustomChar(1,0,0,0,31,31,31,0,0)"
            Dim BlockOne As String = "$CustomChar(2,16,16,16,31,31,31,16,0)"
            Dim BlockTwo As String = "$CustomChar(3,8,8,8,31,31,31,8,0)"
            Dim BlockThree As String = "$CustomChar(4,4,4,4,31,31,31,4,0)"
            Dim BlockFour As String = "$CustomChar(5,2,2,2,31,31,31,2,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,31,0,0)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            If remainingLinesToShow7 = 1 Then
                numVisibleBlocks7 = numVisibleBlocks7 - 1
            ElseIf remainingLinesToShow7 = 2 Then
                numVisibleBlocks7 = numVisibleBlocks7 - 1
            ElseIf remainingLinesToShow7 = 3 Then
                numVisibleBlocks7 = numVisibleBlocks7 - 1
            ElseIf remainingLinesToShow7 = 4 Then
                numVisibleBlocks7 = numVisibleBlocks7 - 1
            ElseIf remainingLinesToShow7 = 5 Then
                numVisibleBlocks7 = numVisibleBlocks7 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks7
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow7 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow7 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow7 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow7 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow7 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks7
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
        End If
    End Function

    Public Function function8(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "8 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 8)
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

            If remainingLinesToShow8 = 1 Then
                numVisibleBlocks8 = numVisibleBlocks8 - 1
            ElseIf remainingLinesToShow8 = 2 Then
                numVisibleBlocks8 = numVisibleBlocks8 - 1
            ElseIf remainingLinesToShow8 = 3 Then
                numVisibleBlocks8 = numVisibleBlocks8 - 1
            ElseIf remainingLinesToShow8 = 4 Then
                numVisibleBlocks8 = numVisibleBlocks8 - 1
            ElseIf remainingLinesToShow8 = 5 Then
                numVisibleBlocks8 = numVisibleBlocks8 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks8
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow8 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow8 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow8 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow8 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow8 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks8
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
        End If
    End Function

    Public Function function9(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "9 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 9)
            Dim BlockFull As String = "$CustomChar(1,0,0,31,31,0,0,0,17)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,16,0,0,0,17)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,24,24,0,0,0,17)"
            Dim BlockThree As String = "$CustomChar(4,0,0,28,28,0,0,0,17)"
            Dim BlockFour As String = "$CustomChar(5,0,0,30,30,0,0,0,17)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,0,0,17)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            If remainingLinesToShow9 = 1 Then
                numVisibleBlocks9 = numVisibleBlocks9 - 1
            ElseIf remainingLinesToShow9 = 2 Then
                numVisibleBlocks9 = numVisibleBlocks9 - 1
            ElseIf remainingLinesToShow9 = 3 Then
                numVisibleBlocks9 = numVisibleBlocks9 - 1
            ElseIf remainingLinesToShow9 = 4 Then
                numVisibleBlocks9 = numVisibleBlocks9 - 1
            ElseIf remainingLinesToShow9 = 5 Then
                numVisibleBlocks9 = numVisibleBlocks9 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks9
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow9 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow9 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow9 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow9 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow9 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks9
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
        End If
    End Function

    Public Function function10(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "10 bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 10)
            Dim BlockFull As String = "$CustomChar(1,0,0,21,10,21,10,21,0)"
            Dim BlockOne As String = "$CustomChar(2,0,0,16,0,16,0,16,0)"
            Dim BlockTwo As String = "$CustomChar(3,0,0,16,8,16,8,16,0)"
            Dim BlockThree As String = "$CustomChar(4,0,0,20,8,20,8,20,0)"
            Dim BlockFour As String = "$CustomChar(5,0,0,20,10,20,10,20,0)"
            Dim BlockEmpty As String = "$CustomChar(6,0,0,0,0,0,0,0,21)"
            Dim callBlockFull As String = "$Chr(0)"
            Dim callBlockOne As String = "$Chr(1)"
            Dim callBlockTwo As String = "$Chr(2)"
            Dim callBlockThree As String = "$Chr(3)"
            Dim callBlockFour As String = "$Chr(4)"
            Dim callBlockEmpty As String = "$Chr(5)"

            Dim visibleBar As String = ""

            If remainingLinesToShow10 = 1 Then
                numVisibleBlocks10 = numVisibleBlocks10 - 1
            ElseIf remainingLinesToShow10 = 2 Then
                numVisibleBlocks10 = numVisibleBlocks10 - 1
            ElseIf remainingLinesToShow10 = 3 Then
                numVisibleBlocks10 = numVisibleBlocks10 - 1
            ElseIf remainingLinesToShow10 = 4 Then
                numVisibleBlocks10 = numVisibleBlocks10 - 1
            ElseIf remainingLinesToShow10 = 5 Then
                numVisibleBlocks10 = numVisibleBlocks10 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks10
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow10 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow10 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow10 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow10 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow10 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim remainBlocks As String
            For i As Integer = 1 To remainingBlocks10
                remainBlocks &= callBlockEmpty
            Next

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty
            Return defineChars & visibleBar & remainBlocks
        End If
    End Function





    Public Function function13(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "13 tailless bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 13)
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

            If remainingLinesToShow13 = 1 Then
                numVisibleBlocks13 = numVisibleBlocks13 - 1
            ElseIf remainingLinesToShow13 = 2 Then
                numVisibleBlocks13 = numVisibleBlocks13 - 1
            ElseIf remainingLinesToShow13 = 3 Then
                numVisibleBlocks13 = numVisibleBlocks13 - 1
            ElseIf remainingLinesToShow13 = 4 Then
                numVisibleBlocks13 = numVisibleBlocks13 - 1
            ElseIf remainingLinesToShow13 = 5 Then
                numVisibleBlocks13 = numVisibleBlocks13 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks13
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow13 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow13 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow13 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow13 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow13 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty

            Return defineChars & visibleBar



        End If
    End Function

    Public Function function14(param1 As String, param2 As String)
        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "14 tailless bar"
        Else
            If param1 = Nothing Then param1 = 0
            If param2 = Nothing Then param2 = 0
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 14)
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

            If remainingLinesToShow14 = 1 Then
                numVisibleBlocks14 = numVisibleBlocks14 - 1
            ElseIf remainingLinesToShow14 = 2 Then
                numVisibleBlocks14 = numVisibleBlocks14 - 1
            ElseIf remainingLinesToShow14 = 3 Then
                numVisibleBlocks14 = numVisibleBlocks14 - 1
            ElseIf remainingLinesToShow14 = 4 Then
                numVisibleBlocks14 = numVisibleBlocks14 - 1
            ElseIf remainingLinesToShow14 = 5 Then
                numVisibleBlocks14 = numVisibleBlocks14 - 1
            End If
            For i As Integer = 1 To numVisibleBlocks14
                visibleBar &= callBlockFull
            Next
            If remainingLinesToShow14 = 1 Then
                visibleBar = visibleBar & "$Chr(1)"
            ElseIf remainingLinesToShow14 = 2 Then
                visibleBar = visibleBar & "$Chr(2)"
            ElseIf remainingLinesToShow14 = 3 Then
                visibleBar = visibleBar & "$Chr(3)"
            ElseIf remainingLinesToShow14 = 4 Then
                visibleBar = visibleBar & "$Chr(4)"
            ElseIf remainingLinesToShow14 = 5 Then
                visibleBar = visibleBar & "$Chr(0)"
            End If

            Dim defineChars = BlockFull & BlockOne & BlockTwo & BlockThree & BlockFour & BlockEmpty

            Return defineChars & visibleBar



        End If
    End Function



    Public Function function19(param1 As String, param2 As String)

        If LCase(param1) = "about" Or LCase(param1) = "about" Then
            Return "diagnostics for barra "
        Else
            CalculateNumberOfVisibleBlocks(Convert.ToInt64(param1), Convert.ToInt64(param2), 1)
            Return "VisibleBlocks:" & numVisibleBlocks1 & " RemainBlocks:" & remainingBlocks1 & " RemainLines:" & remainingLinesToShow1
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
        demolist.AppendLine("---------------------------------------------------------------------------------------------------------")
        demolist.AppendLine(" *** Visit ***")
        demolist.AppendLine("> Old home page")
        demolist.AppendLine("https://lcdsmartie.sourceforge.net")
        demolist.AppendLine("> Forums")
        demolist.AppendLine("https://www.lcdsmartie.org")
        demolist.AppendLine("> New official development branch (latest version)")
        demolist.AppendLine("https://github.com/LCD-Smartie/LCDSmartie")
        demolist.AppendLine("")

        Dim result As String = demolist.ToString()
        Return result
    End Function

    Public Function SmartieInfo()
        Return "Developer: Nikos Georgousis (limbo)" & vbNewLine & "Version: 1.0 "
    End Function

    Public Function GetMinRefreshInterval() As Integer

        Return 5 ' 5 ms 

    End Function



End Class
