using Microsoft.EntityFrameworkCore;
using ShareIT.EAV.DomainModel.Entities;

namespace ShareIT.EAV.DomainModel.DomainContext
{
    public class ProductEavContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=<yourserver>; database=<your db>; uid=<username>; pwd=<yourpass>; Max Pool Size=1000;Connect Timeout=600;Pooling=true;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {        

            modelBuilder.Entity<ProductDefinition>()
                .ToTable("ProductDefinitions", "EAV");

            modelBuilder.Entity<AttributeType>()
              .ToTable("AttributeTypes", "EAV");

            modelBuilder.Entity<ProductAttribute>()
              .ToTable("ProductAttributes", "EAV");

            modelBuilder.Entity<Item>()
            .ToTable("Items", "EAV");

            modelBuilder.Entity<ItemIntValue>()
           .ToTable("ItemIntValues", "EAV")
           .Property(p => p.Value)
           .HasColumnName("Value")
           .HasColumnType("int");

            modelBuilder.Entity<ItemStringValue>()
           .ToTable("ItemStringValues", "EAV")
           .Property(p => p.Value)
           .HasColumnName("Value")
           .HasColumnType("nvarchar(255)");

            modelBuilder.Entity<ItemBoolValue>()
           .ToTable("ItemBoolValues", "EAV")
           .Property(p => p.Value)
           .HasColumnName("Value")
           .HasColumnType("bit");

            modelBuilder.Entity<ItemDecimalValue>()
           .ToTable("ItemDecimalValues", "EAV")
           .Property(p => p.Value)
           .HasColumnName("Value")
           .HasColumnType("decimal(18, 0)");

            modelBuilder.Entity<ItemDateTimeValue>()
           .ToTable("ItemDateTimeValues", "EAV")
           .Property(p => p.Value)
           .HasColumnName("Value")
           .HasColumnType("datetime");

            modelBuilder.Entity<ProductDefinition>()
                .HasMany<ProductAttribute>(g => g.ProductAttributes)
                .WithOne(s => s.ProductDefinition)
                .HasForeignKey(s => s.ProductDefinitionId);


            modelBuilder.Entity<AttributeType>()
                .HasMany<ProductAttribute>(p => p.ProductAttributes)
                .WithOne(s => s.AttributeType)
                .HasForeignKey(s => s.AttributeTypeId);

            modelBuilder.Entity<ItemIntValue>()
                .HasOne(g => g.ProductDefinition)
                .WithMany(s => s.ItemIntValues)
                .HasForeignKey(s => s.ProductDefinitionId);

            modelBuilder.Entity<ItemBoolValue>()
                .HasOne(g => g.ProductDefinition)
                .WithMany(s => s.ItemBoolValues)
                .HasForeignKey(s => s.ProductDefinitionId);

            modelBuilder.Entity<ItemStringValue>()
                .HasOne(g => g.ProductDefinition)
                .WithMany(s => s.ItemStringValues)
                .HasForeignKey(s => s.ProductDefinitionId);

            modelBuilder.Entity<ItemDecimalValue>()
                .HasOne(g => g.ProductDefinition)
                .WithMany(s => s.ItemDecimalValues)
                .HasForeignKey(s => s.ProductDefinitionId);

            modelBuilder.Entity<ItemDateTimeValue>()
                .HasOne(g => g.ProductDefinition)
                .WithMany(s => s.ItemDateTimeValues)
                .HasForeignKey(s => s.ProductDefinitionId);

            modelBuilder.Entity<ProductAttribute>()
                .HasMany(g => g.ItemStringValues)
                .WithOne(s => s.ProductAttribute)
                .HasForeignKey(s => s.ProductAttributeId);

            modelBuilder.Entity<ProductAttribute>()
              .HasMany(g => g.ItemIntValues)
              .WithOne(s => s.ProductAttribute)
              .HasForeignKey(s => s.ProductAttributeId);

            modelBuilder.Entity<ProductAttribute>()
              .HasMany(g => g.ItemBoolValues)
              .WithOne(s => s.ProductAttribute)
              .HasForeignKey(s => s.ProductAttributeId);

            modelBuilder.Entity<ProductAttribute>()
              .HasMany(g => g.ItemDecimalValues)
              .WithOne(s => s.ProductAttribute)
              .HasForeignKey(s => s.ProductAttributeId);

            modelBuilder.Entity<ProductAttribute>()
              .HasMany(g => g.ItemDateTimeValues)
              .WithOne(s => s.ProductAttribute)
              .HasForeignKey(s => s.ProductAttributeId);

            modelBuilder.Entity<Item>()
              .HasMany(g => g.ItemStringValues)
              .WithOne(s => s.Item)
              .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<Item>()
              .HasMany(g => g.ItemIntValues)
              .WithOne(s => s.Item)
              .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<Item>()
              .HasMany(g => g.ItemBoolValues)
              .WithOne(s => s.Item)
              .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<Item>()
              .HasMany(g => g.ItemDecimalValues)
              .WithOne(s => s.Item)
              .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<Item>()
              .HasMany(g => g.ItemDateTimeValues)
              .WithOne(s => s.Item)
              .HasForeignKey(s => s.ItemId);

            modelBuilder.Entity<ProductDefinition>()
              .HasMany(g => g.Items)
              .WithOne(s => s.ProductDefinition)
              .HasForeignKey(s => s.ProductDefinitionId);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<ProductDefinition> ProductDefinitions { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemIntValue> ItemIntValues { get; set; }
        public DbSet<ItemBoolValue> ItemBoolValues { get; set; }
        public DbSet<ItemStringValue> ItemStringValues { get; set; }
        public DbSet<ItemDecimalValue> ItemDecimalValues { get; set; }
        public DbSet<ItemDateTimeValue> ItemDateTimeValues { get; set; }

    }
}
