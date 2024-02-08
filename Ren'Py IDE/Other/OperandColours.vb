Imports System.Runtime.InteropServices

Public Class OperandColours
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Declare Function LockWindowUpdate Lib "user32" (ByVal hWnd As Integer) As Integer

    'color light blue
    Dim scriptKeyWords() As String = {"return", "with", "try", "except", "if", "def", "not", "elif"}
    'color orangered
    Dim scriptOperatorKeyWords() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
    'color hot pink
    Dim scriptOperatorKeyWords1() As String = {"drag_placed", "-", "*", "/", "\", "-", "&", "=", "<>", "<", "<=", ">", ">="}
    'color magenta
    Dim commentChar As String = "#"

    Private Enum EditMessages
        LineIndex = 187
        LineFromChar = 201
        GetFirstVisibleLine = 206
        CharFromPos = 215
        PosFromChar = 1062
    End Enum

    Public Function GetCharFromLineIndex(ByVal LineIndex As Integer, rtb As RichTextBox) As Integer
        Return SendMessage(rtb.Handle.ToInt32, EditMessages.LineIndex, LineIndex, 0)
    End Function
    Public Function FirstVisibleLine(rtb As RichTextBox) As Integer
        Return SendMessage(rtb.Handle.ToInt32, EditMessages.GetFirstVisibleLine, 0, 0)
    End Function
    Public Function LastVisibleLine(rtb As RichTextBox) As Integer
        Dim LastLine As Integer = FirstVisibleLine(rtb) + (rtb.Height / rtb.Font.Height)

        If LastLine > rtb.Lines.Length Or LastLine = 0 Then
            LastLine = rtb.Lines.Length
        End If
        Return LastLine
    End Function
    Public Sub ColorRtb(ByRef rtb As RichTextBox)
        Dim FirstVisibleChar As Integer
        Dim i As Integer = 0
        While i < rtb.Lines.Length
            FirstVisibleChar = GetCharFromLineIndex(i, rtb)
            ColorLineNumber(rtb, i, FirstVisibleChar)
            i += 1
        End While
    End Sub
    Public Sub ColorLineNumber(ByVal rtb As RichTextBox, ByVal LineIndex As Integer, ByVal lStart As Integer)
        Dim TLine As String = rtb.Lines(LineIndex) '.ToLower
        Dim i As Integer = 0
        Dim instance As Integer
        Dim SelectionAt As Integer = rtb.SelectionStart
        ' Lock the update
        LockWindowUpdate(rtb.Handle.ToInt32)
        ' Color the line white to remove any previous coloring 
        rtb.SelectionStart = lStart
        rtb.SelectionLength = TLine.Length
        rtb.SelectionColor = Color.White
        HighLightOperatorKey(rtb) 'operator keyword
        HighLightKeywords(rtb) 'keyword
        ' Find any comments 
        instance = TLine.IndexOf(commentChar) + 1
        ' If there are comments, color them 
        If instance <> 0 Then
            rtb.SelectionStart = (lStart + instance - 1) 'rtb.SelectionStart = (lStart + instance - 1)
            rtb.SelectionLength = (TLine.Length - instance + 1)
            rtb.SelectionColor = Color.LightBlue
        End If

        If instance = 1 Then
            ' Unlock the update, restore the start and exit 
            rtb.SelectionStart = SelectionAt
            rtb.SelectionLength = 0
            LockWindowUpdate(0)
            Exit Sub
            'Return ' TODO: might not be correct. Was : Exit Sub 
        End If

        ' Restore the selectionstart 
        rtb.SelectionStart = SelectionAt
        rtb.SelectionLength = 0

        ' Unlock the update 
        LockWindowUpdate(0)

    End Sub
    Public Sub HighLightKeywords(ByVal rtb As RichTextBox)
        For Each oneWord As String In scriptKeyWords
            Dim pos As Integer = 0
            Do While rtb.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0
                pos = rtb.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)
                rtb.Select(pos, oneWord.Length)
                rtb.SelectionColor = Color.LightBlue

                pos += 1

            Loop

        Next

    End Sub

    Public Sub HighLightOperatorKey(ByVal rtb As RichTextBox)
        For Each oneWord As String In scriptOperatorKeyWords

            Dim pos As Integer = 0

            Do While rtb.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0

                pos = rtb.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)

                rtb.Select(pos, oneWord.Length)
                rtb.SelectionColor = Color.OrangeRed

                pos += 1

            Loop

        Next
    End Sub

    Public Sub HighLightOperatorKey1(ByVal rtb As RichTextBox)
        For Each oneWord As String In scriptOperatorKeyWords1

            Dim pos As Integer = 0

            Do While rtb.Text.ToUpper.IndexOf(oneWord.ToUpper, pos) >= 0

                pos = rtb.Text.ToUpper.IndexOf(oneWord.ToUpper, pos)

                rtb.Select(pos, oneWord.Length)
                rtb.SelectionColor = Color.HotPink

                pos += 1

            Loop

        Next
    End Sub

    Public Sub ColorVisibleLines(ByVal rtb As RichTextBox)
        Dim FirstLine As Integer = FirstVisibleLine(rtb)
        Dim LastLine As Integer = LastVisibleLine(rtb)
        Dim FirstVisibleChar As Integer
        Dim i As Integer = FirstLine
        If (FirstLine = 0) And (LastLine = 0) Then
            'If there is no text it will error, so exit the sub
            Exit Sub
        Else
            While i < LastLine
                FirstVisibleChar = GetCharFromLineIndex(FirstLine, rtb)
                ColorLineNumber(rtb, FirstLine, FirstVisibleChar)
                FirstLine += 1
                i += 1
            End While
        End If

    End Sub
End Class
