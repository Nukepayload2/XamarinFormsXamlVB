Imports System.Windows.Input
Imports Xamarin.Forms

Namespace ViewModels

    Public Class AboutViewModel
        Inherits BaseViewModel

        Public Sub New()
            Title = "About"
            OpenWebCommand = New Command(Sub() Device.OpenUri(New Uri("https://xamarin.com/platform")))
        End Sub

        Public Property OpenWebCommand As ICommand
    End Class
End Namespace