Imports XamlVBCodeBehindGeneratorTest.Models

Namespace ViewModels

    Public Class ItemDetailViewModel
        Inherits BaseViewModel

        Public Property Item As Item

        Public Sub New(Optional item As Item = Nothing)
            Title = item?.Text
            item = item
        End Sub
    End Class
End Namespace
