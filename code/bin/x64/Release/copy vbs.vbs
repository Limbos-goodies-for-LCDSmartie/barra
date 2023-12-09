' Define file paths
Dim fileToDelete, fileToCopy, destinationPath, resultMessage
fileToDelete = "D:\SLAVE\!Programs\LCD Smartie\LCD_Smartie\Latest\LCDSmartie_x64\plugins\barra.dll"
fileToCopy = "E:\Nextcloud\Development\LCD Smartie Plugins\barra\barra\bin\x64\Release\barra.dll"
destinationPath = "D:\SLAVE\!Programs\LCD Smartie\LCD_Smartie\Latest\LCDSmartie_x64\plugins\barra.dll"

' Attempt to delete the file
On Error Resume Next
Set objFSO = CreateObject("Scripting.FileSystemObject")
objFSO.DeleteFile(fileToDelete)
On Error GoTo 0

' Check if the file was deleted
If objFSO.FileExists(fileToDelete) = False Then
    ' Attempt to copy the new file
    objFSO.CopyFile fileToCopy, destinationPath

    ' Check if the file was copied
    If objFSO.FileExists(destinationPath) = True Then
        resultMessage = "File deleted and copied successfully."
    Else
        resultMessage = "File deleted but not copied. There was an error copying the file."
    End If
Else
    resultMessage = "File not deleted. There was an error deleting the file."
End If

' Display the result message
MsgBox resultMessage, vbOKOnly, "File Operation Result"
