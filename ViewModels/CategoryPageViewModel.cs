using MakeupStore.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MakeupStore.ViewModels
{
    public class CategoryPageViewModel
    {
        public Category SelectedCategory { get; set; }

        public ICommand ItemClicked { get; set; }
            
        public ObservableCollection<Category> Category { get; set; }


        public CategoryPageViewModel()
        {
            Category = new ObservableCollection<Category>
            {
                new Category { Id = 1, Name = "Face Products", Price = "$6", Description = "Foundation", Image = "foundation.jpg"},
                new Category { Id = 2, Name = "Lip Products", Price = "$4", Description = "Lip", Image = "lip.jpg"},
                new Category { Id = 3, Name = "Eye Products", Price = "$3", Description = "Eyeshadow", Image = "eye.jpg"},
                new Category { Id = 4, Name = "Skincare Products", Price = "$10", Description = "Skincare", Image = "skincare.jpg"},

            };

        }
        
    }
}
