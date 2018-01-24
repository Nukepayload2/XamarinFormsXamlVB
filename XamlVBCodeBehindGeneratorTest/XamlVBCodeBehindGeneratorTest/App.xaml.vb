Imports Xamarin.Forms
Imports XamlVBCodeBehindGeneratorTest.Views

'Xaml compilation is not supported by XamlC.
'<Assembly: Xaml.XamlCompilation(Xaml.XamlCompilationOptions.Compile)>
Public Class App
    Inherits Application

    Sub New()
        InitializeComponent()
        MainPage = New MainPage
    End Sub

    Protected Overrides Sub OnStart()

    End Sub

    Protected Overrides Sub OnSleep()

    End Sub

    Protected Overrides Sub OnResume()

    End Sub
End Class
