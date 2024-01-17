

using MakeupStore.ViewModels;

namespace MakeupStore.Views;

public partial class Categories : ContentPage
{
    CategoryPageViewModel CategoryPageViewModel;
   
    public Categories()
	{
        InitializeComponent();
        
        CategoryPageViewModel = new CategoryPageViewModel(this.Navigation);

        BindingContext = CategoryPageViewModel;

    }
}