Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports Xamarin.Forms
Imports XamlVBCodeBehindGeneratorTestVB.Models
Imports XamlVBCodeBehindGeneratorTestVB.Services

Namespace ViewModels

    Public Class BaseViewModel
        Implements INotifyPropertyChanged

        Public ReadOnly Property DataStore As IDataStore(Of Item)
            Get
                Return If(DependencyService.Get(Of IDataStore(Of Item))(), New MockDataStore())
            End Get
        End Property

        Private _isBusy As Boolean = False

        Public Property IsBusy As Boolean
            Get
                Return _isBusy
            End Get
            Set(value As Boolean)
                SetProperty(_isBusy, value)
            End Set
        End Property

        Private _title As String = String.Empty

        Public Property Title As String
            Get
                Return _title
            End Get

            Set(value As String)
                SetProperty(_title, value)
            End Set
        End Property

        Protected Function SetProperty(Of T)(ByRef backingStore As T, value As T, <CallerMemberName> Optional propertyName As String = "", Optional onChanged As Action = Nothing) As Boolean
            If EqualityComparer(Of T).[Default].Equals(backingStore, value) Then Return False
            backingStore = value
            onChanged?.Invoke()
            OnPropertyChanged(propertyName)
            Return True
        End Function

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
    End Class
End Namespace
