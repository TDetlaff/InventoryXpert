namespace InventoryXpert.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int CategoryId { get; set; }
        public int StockedQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public int QuantityOnOrder { get; set; }
        public float Price { get; set; }
        public string Location { get; set; }
        public string TagA { get; set; }
        public string TagB { get; set; }
        public string TagC { get; set; }
        public string TagD { get; set; }
        public string TagE { get; set; }

        public Item() { }
    }
}
