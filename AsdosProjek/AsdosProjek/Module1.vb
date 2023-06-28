Imports ADODB

Module Module1
    Public Function jalankanSQL(ByVal SQL As String) As ADODB.Recordset
        On Error GoTo Err
        Dim conn As New ADODB.Connection

        If conn.State = ObjectStateEnum.adStateOpen Then
            conn.Close()
            conn = Nothing
        End If
        conn.CursorLocation = CursorLocationEnum.adUseClient
        conn.Properties.Refresh()

        conn.Open("DSN=DSNLOGIN")
        jalankanSQL = conn.Execute(SQL)
        Exit Function

Err:
        MsgBox("Koneksi Error!", vbCritical + vbOKOnly, "Error")
        End

    End Function
End Module