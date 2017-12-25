Imports Xamarin.Forms
Imports XamlVBCodeBehindGeneratorTestVB.Models
Imports XamlVBCodeBehindGeneratorTestVB.ViewModels

Namespace Views

    Partial Public Class ItemDetailPage
        Inherits ContentPage

        Private viewModel As ItemDetailViewModel

        Sub New(viewModel As ItemDetailViewModel)
            InitializeComponent()
            Me.viewModel = viewModel
            BindingContext = viewModel
        End Sub

        Private Sub OnComponentInitialized()
            Dim item1 As New Item With {
                             .Text = "Item 1",
                             .Description = "This is an item description."
                         }
            viewModel = New ItemDetailViewModel(item1)
            BindingContext = viewModel
        End Sub

    End Class
End Namespace