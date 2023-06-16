namespace ShareIT.EAV.DomainModel.Entities
{
    public class ProductAttribute
    {
        public long ProductAttributeId { get; set; }
        public string Name { get; set; }
        public long AttributeTypeId { get; set; }
        public AttributeType AttributeType { get; set; }
        public long ProductDefinitionId { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ICollection<ItemIntValue> ItemIntValues { get; set; }
        public ICollection<ItemStringValue> ItemStringValues { get; set; }
        public ICollection<ItemDecimalValue> ItemDecimalValues { get; set; }
        public ICollection<ItemBoolValue> ItemBoolValues { get; set; }
        public ICollection<ItemDateTimeValue> ItemDateTimeValues { get; set; }
        public ProductAttribute()
        {
            this.ItemIntValues = new HashSet<ItemIntValue>();
            this.ItemStringValues = new HashSet<ItemStringValue>();
            this.ItemDecimalValues = new HashSet<ItemDecimalValue>();
            this.ItemBoolValues = new HashSet<ItemBoolValue>();
            this.ItemDateTimeValues = new HashSet<ItemDateTimeValue>();
        }
    }
}
