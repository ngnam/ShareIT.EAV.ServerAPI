namespace ShareIT.EAV.DomainModel.Entities
{
    public class AttributeType
    {
        public long AttributeTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<ProductAttribute> ProductAttributes { get; set; }
        public AttributeType()
        {
            this.ProductAttributes = new HashSet<ProductAttribute>();
        }
    }
}
