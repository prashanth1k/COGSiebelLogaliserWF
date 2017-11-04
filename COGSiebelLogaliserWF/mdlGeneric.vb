Imports System.IO
Imports System.Web
Imports System.Text

Module mdlGeneric
    Function GetLineCount(ByVal sFileName As String) As Long
        Dim arrByteBuffer(16784) As Byte '16k buffer read at one time
        Dim lLineCount As Long = -1
        Dim iBuffer As Integer

        Try
            Using fs As New FileStream(sFileName, FileMode.Open, FileAccess.Read, FileShare.Read, arrByteBuffer.Length)
                lLineCount = 0
                iBuffer = fs.Read(arrByteBuffer, 0, arrByteBuffer.Length)
                While (iBuffer > 0)
                    For iCount As Integer = 0 To (iBuffer - 1) Step 1
                        If arrByteBuffer(iCount) = &HD Then lLineCount += 1
                    Next
                    iBuffer = fs.Read(arrByteBuffer, 0, arrByteBuffer.Length)
                End While
                fs.Close()
                lLineCount += 1
            End Using

        Catch ex As Exception
            lLineCount = -1
            Err.Raise(Err.Number, "GetLineCount" & Err.Description, Err.Description)
        Finally
            arrByteBuffer = Nothing
        End Try

        Return lLineCount
    End Function
    Public Sub ExportFile(ByVal sFileName As String, ByVal iFileType As Integer, ByRef dgData As DataGridView, Optional ByVal sDelim As String = ",")
        Try
            Select Case iFileType
                Case 1, 2
                    Dim sb As New StringBuilder()
                    'create columnNames:
                    For i As Integer = 0 To dgData.Rows.Count - 1
                        Dim array As String() = New String(dgData.Columns.Count - 1) {}
                        If i.Equals(0) Then
                            'get column header text from all columns:
                            For j As Integer = 0 To dgData.Columns.Count - 1
                                array(j) = dgData.Columns(j).HeaderText
                            Next
                            sb.AppendLine([String].Join(sDelim, array))
                        End If
                        'get values from columns for specific row (row[i]):
                        For j As Integer = 0 To dgData.Columns.Count - 1
                            If Not dgData.Rows(i).IsNewRow Then
                                array(j) = """" + dgData(j, i).Value.ToString() + """"
                            End If
                        Next
                        If Not dgData.Rows(i).IsNewRow Then
                            sb.AppendLine([String].Join(sDelim, array))
                        End If
                    Next
                    File.WriteAllText(sFileName, sb.ToString())
            End Select
        Catch ex As Exception

        End Try
    End Sub
   
    Public Function IndexOfN(ByVal sString As String, ByVal cSearchChar As Char, Optional ByVal iNthPosition As Integer = 0) As Integer
        Dim iReturn As Integer = -1
        Try
            Dim iOccur As Integer = 0
            Dim iPos As Integer = sString.IndexOf(cSearchChar, 0)
            While (iPos <> -1)
                iOccur += 1
                If iOccur = iNthPosition Then
                    iReturn = iPos
                    iPos = -1
                Else
                    iPos = sString.IndexOf(cSearchChar, iPos + 1)
                End If
            End While
        Catch ex As Exception
        Finally
            IndexOfN = iReturn
        End Try
    End Function

    Public Function ExportDataToFileExp1(ByRef dtTable As DataTable, ByVal sFile As String, Optional ByVal sSeparator As String = ",")
        ' EXPERIMENTAL
        'Export data from data table to a file
        'dtTable.WriteXml("1.xml")
        Dim writer As System.IO.StreamWriter
        Try
            Dim sTempSep As String = ""
            Dim builder As New System.Text.StringBuilder

            writer = New System.IO.StreamWriter(sFile)
            For Each col As DataColumn In dtTable.Columns
                builder.Append(sTempSep).Append("""").Append(col.Caption).Append("""")
                sTempSep = sSeparator
            Next
            writer.WriteLine(builder.ToString())

            For Each row As DataRow In dtTable.Rows
                sTempSep = ""
                builder = New System.Text.StringBuilder

                For Each col As DataColumn In dtTable.Columns
                    builder.Append(sTempSep).Append("""").Append(row(col.Caption)).Append("""")

                    sTempSep = sSeparator
                Next
                writer.WriteLine(builder.ToString())
            Next
            writer.Close()

            ExportDataToFileExp1 = ""

        Catch ex As Exception
            ExportDataToFileExp1 = ex.Message
        Finally

        End Try
    End Function

    
End Module
