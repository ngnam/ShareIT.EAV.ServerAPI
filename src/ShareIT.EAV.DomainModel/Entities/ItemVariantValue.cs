namespace ShareIT.EAV.DomainModel.Entities
{
    public class ItemIntValue
    {
        public long ItemIntValueId { get; set; }
        public long ProductDefinitionId { get; set; }
        public long ItemId { get; set; }
        public long ProductAttributeId { get; set; }
        public int Value { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public Item Item { get; set; }

    }

    public class ItemStringValue
    {
        public long ItemStringValueId { get; set; }
        public long ProductDefinitionId { get; set; }
        public long ItemId { get; set; }
        public long ProductAttributeId { get; set; }
        public string Value { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public Item Item { get; set; }

    }

    public class ItemBoolValue
    {
        public long ItemBoolValueId { get; set; }
        public long ProductDefinitionId { get; set; }
        public long ItemId { get; set; }
        public long ProductAttributeId { get; set; }
        public bool Value { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public Item Item { get; set; }

    }

    public class ItemDecimalValue
    {
        public long ItemDecimalValueId { get; set; }
        public long ProductDefinitionId { get; set; }
        public long ItemId { get; set; }
        public long ProductAttributeId { get; set; }
        public Decimal Value { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public Item Item { get; set; }


    }

    public class ItemDateTimeValue
    {
        public long ItemDateTimeValueId { get; set; }
        public long ProductDefinitionId { get; set; }
        public long ItemId { get; set; }
        public long ProductAttributeId { get; set; }
        public DateTime Value { get; set; }
        public ProductDefinition ProductDefinition { get; set; }
        public ProductAttribute ProductAttribute { get; set; }
        public Item Item { get; set; }


    }
}
