using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color = System.Drawing.Color;

namespace MakeupStore.Models
{
    public class Category
    {
       
        public int Id { get; set; }
        public string Name { get; set; }

        public string Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

    

    }
    

}
