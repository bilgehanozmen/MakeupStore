using CommunityToolkit.Mvvm.ComponentModel;

namespace MakeupStore.Models
{
    public partial class BasketItem: ObservableObject

    {   
        public Guid Id { get; set; }

        public short productId { get; set; }

        public string productName { get; set; }

        public decimal Price { get; set; }


    }


}
