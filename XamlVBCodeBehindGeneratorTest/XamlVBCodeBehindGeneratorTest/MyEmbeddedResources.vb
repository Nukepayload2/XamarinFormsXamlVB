Imports System.IO
Imports System.Reflection

Namespace My
    ''' <summary>
    ''' 提供对内嵌资源的访问。
    ''' </summary>
    Public Class EmbeddedResources
        Private Shared s_currentAssembly As Assembly = Assembly.GetExecutingAssembly
        Public Shared ReadOnly Property Assets(assetName As String) As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream($"XamlVBCodeBehindGeneratorTest.{assetName}")
            End Get
        End Property

        ''' <summary>
        ''' 查找资源 Assets\生日蛋糕_22_omega.png
        ''' </summary>
        Public Shared ReadOnly Property 生日蛋糕_22_omega As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("XamlVBCodeBehindGeneratorTest.生日蛋糕_22_omega.png")
            End Get
        End Property

    End Class
End Namespace

