namespace InventoryXpert.Models
{
    public class Category
    {
        public Category() { }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Group { get; set; }
        public int SupplierId { get; set; }
    }
}
