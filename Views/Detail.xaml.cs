using MakeupStore.ViewModels;

namespace MakeupStore.Views;

public partial class Detail : ContentPage
{
    public Detail(CategoryPageViewModel category)
    {
        InitializeComponent();
        BindingContext = category;
    }
}