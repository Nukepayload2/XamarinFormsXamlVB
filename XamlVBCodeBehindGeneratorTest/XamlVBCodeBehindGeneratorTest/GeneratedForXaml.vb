Option Strict On
Imports System.ComponentModel
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

Namespace Global.XamlVBCodeBehindGeneratorTest
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Themes\MyUserControlTemplates.xaml")>
Partial Public Class MyUserControlTemplates
    Inherits Global.Xamarin.Forms.ResourceDictionary


    Private _TestMyButtonTemplate As Global.Xamarin.Forms.DataTemplate
    Public ReadOnly Property TestMyButtonTemplate As Global.Xamarin.Forms.DataTemplate
        Get
            If _TestMyButtonTemplate Is Nothing Then
                _TestMyButtonTemplate = DirectCast(Me!TestMyButtonTemplate, Global.Xamarin.Forms.DataTemplate)
            End If
            Return _TestMyButtonTemplate
        End Get
    End Property
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

    End Sub

    Partial Private Sub OnComponentInitialized()

    End Sub

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "0.0.0.0")>
    Private Sub InitializeComponent()
        Extensions.LoadFromXaml(Me, GetType(MyUserControlTemplates))

    End Sub
End Class
End Namespace
Namespace Global.XamlVBCodeBehindGeneratorTest.Views
<Global.Xamarin.Forms.Xaml.XamlFilePath("G:\vs2017\XamarinFormsXamlVB\XamlVBCodeBehindGeneratorTest\XamlVBCodeBehindGeneratorTest\Views\AboutPage.xaml")>
Partial Public Class AboutPage
    Inherits Global.Xamarin.Forms.ContentPage


    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

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
    Inherits Global.Xamarin.Forms.ContentPage


    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

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
    Inherits Global.Xamarin.Forms.ContentPage
Private  BrowseItemsPage As Global.Xamarin.Forms.ContentPage
Private  AddItem As Global.Xamarin.Forms.ToolbarItem
Private  ItemsListView As Global.Xamarin.Forms.ListView
Private WithEvents BrowseItemsPageWithEvents As Global.Xamarin.Forms.ContentPage
Private WithEvents AddItemWithEvents As Global.Xamarin.Forms.ToolbarItem
Private WithEvents ItemsListViewWithEvents As Global.Xamarin.Forms.ListView
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
BrowseItemsPageWithEvents = BrowseItemsPage
AddItemWithEvents = AddItem
ItemsListViewWithEvents = ItemsListView
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
    Inherits Global.Xamarin.Forms.TabbedPage


    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()

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
    Inherits Global.Xamarin.Forms.ContentPage
Private  Save As Global.Xamarin.Forms.ToolbarItem
Private WithEvents SaveWithEvents As Global.Xamarin.Forms.ToolbarItem
    Sub New()
        InitializeComponent()
        InitializeWithEvents()
        OnComponentInitialized()
    End Sub

    Private Sub InitializeWithEvents()
SaveWithEvents = Save
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

