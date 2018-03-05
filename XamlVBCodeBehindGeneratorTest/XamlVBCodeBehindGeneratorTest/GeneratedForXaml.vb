Option Strict On
Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml

Namespace Global.XamlVBCodeBehindGeneratorTest
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\App.xaml")>
Partial Public Class App
    Inherits Application
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Global.Xamarin.Forms.Xaml.Extensions.LoadFromXaml(Me, GetType(App))
    End Sub
End Class

End Namespace

Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\AboutPage.xaml")>
Partial Public Class AboutPage
    Inherits ContentPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(AboutPage))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\ItemDetailPage.xaml")>
Partial Public Class ItemDetailPage
    Inherits ContentPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ItemDetailPage))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\ItemsPage.xaml")>
Partial Public Class ItemsPage
    Inherits ContentPage
WithEvents BrowseItemsPage As Global.Xamarin.Forms.ContentPage
WithEvents AddItem As Global.Xamarin.Forms.ToolbarItem
WithEvents ItemsListView As Global.Xamarin.Forms.ListView
    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(ItemsPage))
BrowseItemsPage = Content.FindByName(Of Global.Xamarin.Forms.ContentPage)(NameOf(BrowseItemsPage))
AddItem = Content.FindByName(Of Global.Xamarin.Forms.ToolbarItem)(NameOf(AddItem))
ItemsListView = Content.FindByName(Of Global.Xamarin.Forms.ListView)(NameOf(ItemsListView))
    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\MainPage.xaml")>
Partial Public Class MainPage
    Inherits TabbedPage

    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(MainPage))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\NewItemPage.xaml")>
Partial Public Class NewItemPage
    Inherits ContentPage
WithEvents Save As Global.Xamarin.Forms.ToolbarItem
    Sub New()
        InitializeComponent()
        OnComponentInitialized()
    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(NewItemPage))
Save = Content.FindByName(Of Global.Xamarin.Forms.ToolbarItem)(NameOf(Save))
    End Sub
End Class
End Namespace

