Option Strict On
Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml

Namespace Global.XamlVBCodeBehindGeneratorTest
<Global.Xamarin.Forms.Xaml.XamlFilePath("D:\Projects\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\App.xaml")>
Partial Public Class App
    Inherits Application

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(App))
    End Sub
End Class

End Namespace

Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("D:\Projects\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\AboutPage.xaml")>
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
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("D:\Projects\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\ItemDetailPage.xaml")>
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
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("D:\Projects\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\ItemsPage.xaml")>
Partial Public Class ItemsPage
    Inherits ContentPage
WithEvents ItemsListView As Global.Xamarin.Forms.ListView
    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ItemsPage))
ItemsListView = Content.FindByName(Of Global.Xamarin.Forms.ListView)(NameOf(ItemsListView))
    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("D:\Projects\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\MainPage.xaml")>
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
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("D:\Projects\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\NewItemPage.xaml")>
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

