Namespace Services

    Public Interface IDataStore(Of T)

        Function AddItemAsync(item As T) As Task(Of Boolean)

        Function UpdateItemAsync(item As T) As Task(Of Boolean)

        Function DeleteItemAsync(item As T) As Task(Of Boolean)

        Function GetItemAsync(id As String) As Task(Of T)

        Function GetItemsAsync(Optional forceRefresh As Boolean = False) As Task(Of IEnumerable(Of T))

    End Interface
End Namespace