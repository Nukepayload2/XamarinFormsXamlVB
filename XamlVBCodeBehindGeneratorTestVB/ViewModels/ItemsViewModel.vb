Imports System.Collections.ObjectModel
Imports Xamarin.Forms
Imports XamlVBCodeBehindGeneratorTestVB.Models
Imports XamlVBCodeBehindGeneratorTestVB.Views

Namespace ViewModels

    Public Class ItemsViewModel
        Inherits BaseViewModel

        Public ReadOnly Property Items As New ObservableCollection(Of Item)

        Public Property LoadItemsCommand As Command

        Public Sub New()
            Title = "Browse"
            LoadItemsCommand = New Command(Async Sub() Await ExecuteLoadItemsCommand())
            MessagingCenter.Subscribe(Of NewItemPage, Item)(Me, "AddItem", Async Sub(obj, item)
                                                                               Dim _item = TryCast(item, Item)
                                                                               Items.Add(_item)
                                                                               Await DataStore.AddItemAsync(_item)
                                                                           End Sub)
        End Sub

        Private Async Function ExecuteLoadItemsCommand() As Task
            If IsBusy Then Return
            IsBusy = True
            Try
                Items.Clear()
                Dim items2 = Await DataStore.GetItemsAsync(True)
                For Each item In items2
                    Items.Add(item)
                Next
            Catch ex As Exception
                Debug.WriteLine(ex)
            Finally
                IsBusy = False
            End Try
        End Function
    End Class
End Namespace
