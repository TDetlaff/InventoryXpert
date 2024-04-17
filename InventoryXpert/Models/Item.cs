namespace InventoryXpert.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool active { get; set; }
        public int CategoryId { get; set; }
        public int StockedQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int QuantityOnOrder { get; set; }
        public float Price { get; set; }
        public string Location { get; set; }
        public string tagA { get; set; }
        public string tagB { get; set; }
        public string tagC { get; set; }
        public string tagD { get; set; }
        public string tagE { get; set; }

        public Item() { }
    }
}
