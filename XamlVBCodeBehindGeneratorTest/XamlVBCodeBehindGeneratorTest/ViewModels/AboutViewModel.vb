Imports Xamarin.Forms

Namespace ViewModels

    Public Class AboutViewModel
        Inherits BaseViewModel

        Public Sub New()
            Title = "About"
        End Sub

        Public ReadOnly Property OpenWebCommand As New Command(Sub() Device.OpenUri(New Uri("https://xamarin.com/platform")))

        Public ReadOnly Property OpenVBXamlCommand As New Command(Sub() Device.OpenUri(New Uri("https://github.com/Nukepayload2/XamarinFormsXamlVB")))
    End Class
End Namespace