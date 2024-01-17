using Android.Content.Res;
using AndroidX.Navigation;
using MakeupStore.Models;
using MakeupStore.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MakeupStore.ViewModels
{
    public class CategoryPageViewModel
    {
        public Category SelectedCategory { get; set; }

        public ICommand CategoryClick { get; set; }

        public INavigation navigation;
        

        public ObservableCollection<Category> Category { get; set; }


        public CategoryPageViewModel(INavigation navigation)
        {
            Category = new ObservableCollection<Category>
            {
                new Category { Id = 1, Name = "Face Products", Price = "$6", Description = "Foundation", Image = "foundation.jpg"},
                new Category { Id = 2, Name = "Lip Products", Price = "$4", Description = "Lip", Image = "lip.jpg"},
                new Category { Id = 3, Name = "Eye Products", Price = "$3", Description = "Eyeshadow", Image = "eye.jpg"},
                new Category { Id = 4, Name = "Skincare Products", Price = "$10", Description = "Skincare", Image = "skincare.jpg"},

            };
            this.navigation = navigation;
            CategoryClick = new Command<Category>(executecategoryclickcommand);
        }
       
        async void executecategoryclickcommand(Category category)
        {
            SelectedCategory = category;
            await navigation.PushModalAsync(new Detail(this));
            
        }
        
    }
}
