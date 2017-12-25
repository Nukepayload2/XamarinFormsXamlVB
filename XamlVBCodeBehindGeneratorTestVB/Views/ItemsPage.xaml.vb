Imports Xamarin.Forms
Imports Xamarin.Forms.Xaml
Imports XamlVBCodeBehindGeneratorTestVB.Models
Imports XamlVBCodeBehindGeneratorTestVB.ViewModels

Namespace Views

    <XamlCompilation(XamlCompilationOptions.Compile)>
    Partial Public Class ItemsPage
        Inherits ContentPage

        Private viewModel As New ItemsViewModel

        Private Async Sub OnItemSelected(ByVal sender As Object, ByVal args As SelectedItemChangedEventArgs)
            Dim item = TryCast(args.SelectedItem, Item)
            If item Is Nothing Then Return
            Await Navigation.PushAsync(New ItemDetailPage(New ItemDetailViewModel(item)))
            ItemsListView.SelectedItem = Nothing
        End Sub

        Private Async Sub AddItem_Clicked(ByVal sender As Object, ByVal e As EventArgs)
            Await Navigation.PushModalAsync(New NavigationPage(New NewItemPage()))
        End Sub

        Protected Overrides Sub OnAppearing()
            MyBase.OnAppearing()
            If viewModel.Items.Count = 0 Then viewModel.LoadItemsCommand.Execute(Nothing)
        End Sub

        Private Sub OnComponentInitialized()
            BindingContext = viewModel
        End Sub
    End Class
End Namespace
