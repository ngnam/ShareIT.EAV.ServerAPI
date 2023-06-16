namespace ShareIT.EAV.DomainModel.Entities
{
    public class ProductDefinition
    {
        public long ProductDefinitionId { get; set; }
        public string Name { get; set; }
        public ICollection<ProductAttribute> ProductAttributes { get; set; }
        public ICollection<ItemIntValue> ItemIntValues { get; set; }
        public ICollection<ItemStringValue> ItemStringValues { get; set; }
        public ICollection<ItemDecimalValue> ItemDecimalValues { get; set; }
        public ICollection<ItemBoolValue> ItemBoolValues { get; set; }
        public ICollection<ItemDateTimeValue> ItemDateTimeValues { get; set; }
        public ICollection<Item> Items { get; set; }

        public ProductDefinition()
        {
            this.ProductAttributes = new HashSet<ProductAttribute>();
            this.ItemIntValues = new HashSet<ItemIntValue>();
            this.ItemStringValues = new HashSet<ItemStringValue>();
            this.ItemDecimalValues = new HashSet<ItemDecimalValue>();
            this.ItemBoolValues = new HashSet<ItemBoolValue>();
            this.ItemDateTimeValues = new HashSet<ItemDateTimeValue>();
            this.Items = new HashSet<Item>();
        }
    }
}
