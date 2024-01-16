namespace MakeupStore.Models
{
    public class Product
    {

        public short Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public short categoryId { get; set; }
        public string categoryName { get; set; }

    }


}
