Imports XamlVBCodeBehindGeneratorTest.Models

<Assembly: Xamarin.Forms.Dependency(GetType(Services.MockDataStore))>
Namespace Services

    Public Class MockDataStore
        Implements IDataStore(Of Item)

        Private items As New List(Of Item)

        Public Sub New()
            Dim mockItems As New List(Of Item) From {
                New Item With {
                    .Id = Guid.NewGuid().ToString(),
                    .Text = "First item",
                    .Description = "This is an item description."
                },
                New Item With {
                    .Id = Guid.NewGuid().ToString(),
                    .Text = "Second item",
                    .Description = "This is an item description."
                },
                New Item With {
                    .Id = Guid.NewGuid().ToString(),
                    .Text = "Third item",
                    .Description = "This is an item description."
                },
                New Item With {
                    .Id = Guid.NewGuid().ToString(),
                    .Text = "Fourth item",
                    .Description = "This is an item description."
                },
                New Item With {
                    .Id = Guid.NewGuid().ToString(),
                    .Text = "Fifth item",
                    .Description = "This is an item description."
                },
                New Item With {
                    .Id = Guid.NewGuid().ToString(),
                    .Text = "Sixth item",
                    .Description = "This is an item description."
                }
            }
            For Each item In mockItems
                items.Add(item)
            Next
        End Sub

        Public Async Function AddItemAsync(item As Item) As Task(Of Boolean) Implements IDataStore(Of Item).AddItemAsync
            items.Add(item)
            Return Await Task.FromResult(True)
        End Function

        Public Async Function UpdateItemAsync(item As Item) As Task(Of Boolean) Implements IDataStore(Of Item).UpdateItemAsync
            Dim _item = items.Where(Function(arg) arg.Id = item.Id).FirstOrDefault()
            items.Remove(_item)
            items.Add(item)
            Return Await Task.FromResult(True)
        End Function

        Public Async Function DeleteItemAsync(item As Item) As Task(Of Boolean) Implements IDataStore(Of Item).DeleteItemAsync
            Dim _item = items.Where(Function(arg) arg.Id = item.Id).FirstOrDefault()
            items.Remove(_item)
            Return Await Task.FromResult(True)
        End Function

        Public Async Function GetItemAsync(id As String) As Task(Of Item) Implements IDataStore(Of Item).GetItemAsync
            Return Await Task.FromResult(items.FirstOrDefault(Function(s) s.Id = id))
        End Function

        Public Async Function GetItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of IEnumerable(Of Item)) Implements IDataStore(Of Item).GetItemsAsync
            Return Await Task.FromResult(items)
        End Function
    End Class
End Namespace
