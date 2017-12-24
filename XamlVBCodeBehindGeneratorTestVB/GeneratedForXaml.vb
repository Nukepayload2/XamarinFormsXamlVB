Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml

Namespace Global.XamlVBCodeBehindGeneratorTestVB
Partial Public Class App
    Inherits Application

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(App))
    End Sub
End Class

End Namespace

Namespace Global.XamlVBCodeBehindGeneratorTestVB
Partial Public Class MainPage
    Inherits ContentPage
WithEvents BtnOk As Button
    Sub New()
        InitializeComponent()
BtnOk = Content.FindByName(Of Button)(NameOf(BtnOk))
    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(MainPage))
    End Sub
End Class
End Namespace

