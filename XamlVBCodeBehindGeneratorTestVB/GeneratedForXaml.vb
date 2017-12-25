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

Namespace Global.XamlVBCodeBehindGeneratorTestVB.Views
Partial Public Class AboutPage
    Inherits ContentPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(AboutPage))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTestVB.Views
Partial Public Class ItemDetailPage
    Inherits ContentPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ItemDetailPage))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTestVB.Views
Partial Public Class ItemsPage
    Inherits ContentPage
WithEvents ItemsListView As ListView
    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ItemsPage))
ItemsListView = Content.FindByName(Of ListView)(NameOf(ItemsListView))
    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTestVB.Views
Partial Public Class MainPage
    Inherits TabbedPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(MainPage))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTestVB.Views
Partial Public Class NewItemPage
    Inherits ContentPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(NewItemPage))

    End Sub
End Class
End Namespace

