Imports Xamarin.Forms
Imports XamlVBCodeBehindGeneratorTest.Models

Namespace Views

    Partial Public Class NewItemPage
        Public Property Item As Item

        Private Async Sub Save_Clicked(sender As Object, e As EventArgs) Handles Save.Clicked
            MessagingCenter.Send(Me, "AddItem", Item)
            Await Navigation.PopModalAsync()
        End Sub

        Private Sub OnComponentInitialized()
            Item = New Item With {.Text = "Item name", .Description = "This is an item description."}
            BindingContext = Me
        End Sub
    End Class
End Namespace
