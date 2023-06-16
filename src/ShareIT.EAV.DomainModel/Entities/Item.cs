namespace ShareIT.EAV.DomainModel.Entities
{
    public class Item
    {
        public long ItemId { get; set; }
        public long ProductDefinitionId { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ICollection<ItemIntValue> ItemIntValues { get; set; }
        public ICollection<ItemStringValue> ItemStringValues { get; set; }
        public ICollection<ItemDecimalValue> ItemDecimalValues { get; set; }
        public ICollection<ItemBoolValue> ItemBoolValues { get; set; }
        public ICollection<ItemDateTimeValue> ItemDateTimeValues { get; set; }
        public Item()
        {
            this.ItemIntValues = new HashSet<ItemIntValue>();
            this.ItemStringValues = new HashSet<ItemStringValue>();
            this.ItemDecimalValues = new HashSet<ItemDecimalValue>();
            this.ItemBoolValues = new HashSet<ItemBoolValue>();
            this.ItemDateTimeValues = new HashSet<ItemDateTimeValue>();
        }
    }
}