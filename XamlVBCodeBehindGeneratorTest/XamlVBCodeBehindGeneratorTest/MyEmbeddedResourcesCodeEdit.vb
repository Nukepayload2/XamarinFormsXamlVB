Imports System.IO
Imports System.Text

Public Class MyEmbeddedResourcesCodeEdit
    Sub Run(projDir$)
        Dim myResources$
        Dim myResourcesBuilder As New StringBuilder
        Dim embeddedResourcesDirs = {"Assets"}
        Dim rootNamespace = projDir.Split({Path.DirectorySeparatorChar}, StringSplitOptions.RemoveEmptyEntries).Last
        Dim getFiles As Func(Of String, Integer, IEnumerable(Of String)) =
            Iterator Function(dir, iterCount)
                Directory.SetCurrentDirectory(dir)
                If iterCount > 3 Then Return ' Special handling for recursive directory junction, to avoid infinite loop.
                Dim innerDirs = Directory.GetDirectories(dir)
                For Each f In Directory.GetFiles(dir)
                    Yield f
                Next
                For Each innerDir In innerDirs
                    For Each f In getFiles(innerDir, iterCount + 1)
                        Yield f
                    Next
                Next
            End Function
        myResourcesBuilder.Append("Imports System.IO
Imports System.Reflection

Namespace My
    ''' <summary>
    ''' 提供对内嵌资源的访问。
    ''' </summary>
    Public Class EmbeddedResources
        Private Shared s_currentAssembly As Assembly = Assembly.GetExecutingAssembly
")
        For Each resourceDir In embeddedResourcesDirs
            For Each fp In getFiles(Path.Combine(projDir, resourceDir), 0)
                myResourcesBuilder.Append($"
        ''' <summary>
        ''' 查找资源 {fp.Substring(projDir.Length)}
        ''' </summary>
        Public Shared ReadOnly Property {Path.GetFileNameWithoutExtension(fp)} As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream(""{rootNamespace}.{Path.GetFileName(fp)}"")
            End Get
        End Property
")
            Next
        Next

        myResourcesBuilder.Append("
    End Class
End Namespace
")
        myResources = myResourcesBuilder.ToString
    End Sub
End Class
