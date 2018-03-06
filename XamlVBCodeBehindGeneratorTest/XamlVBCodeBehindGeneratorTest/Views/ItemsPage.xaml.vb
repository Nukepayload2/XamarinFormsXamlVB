Imports Xamarin.Forms
Imports XamlVBCodeBehindGeneratorTest.Models
Imports XamlVBCodeBehindGeneratorTest.ViewModels

Namespace Views

    Partial Public Class ItemsPage
        Inherits ContentPage

        Private viewModel As New ItemsViewModel

        Private Async Sub ItemsListView_ItemSelected(sender As Object, e As SelectedItemChangedEventArgs) Handles ItemsListViewWithEvents.ItemSelected
            Dim item = TryCast(e.SelectedItem, Item)
            If item Is Nothing Then Return
            Await Navigation.PushAsync(New ItemDetailPage(New ItemDetailViewModel(item)))
            ItemsListView.SelectedItem = Nothing
        End Sub

        Private Async Sub AddItem_Clicked(sender As Object, e As EventArgs) Handles AddItemWithEvents.Clicked
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
