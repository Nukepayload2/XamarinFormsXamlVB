Imports System.IO
Imports System.Reflection

Namespace My
    ''' <summary>
    ''' �ṩ����Ƕ��Դ�ķ��ʡ�
    ''' </summary>
    Public Class EmbeddedResources
        Private Shared s_currentAssembly As Assembly = Assembly.GetExecutingAssembly

        ''' <summary>
        ''' ������Դ Assets\���յ���_22_omega.png
        ''' </summary>
        Public Shared ReadOnly Property ���յ���_22_omega As UnmanagedMemoryStream
            Get
                Return s_currentAssembly.GetManifestResourceStream("XamlVBCodeBehindGeneratorTest.���յ���_22_omega.png")
            End Get
        End Property

    End Class
End Namespace
