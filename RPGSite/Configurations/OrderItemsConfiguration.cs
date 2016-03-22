using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class OrderItemsConfiguration : EntityTypeConfiguration<OrderItems>
    {
        public OrderItemsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".OrderItems");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.OrderId).IsRequired().HasColumnName("OrderId");
            Property(x => x.EquipmentId).IsRequired().HasColumnName("EquipmentId");
            Property(x => x.Quantity).IsRequired().HasColumnName("Quantity");
            Property(x=>x.Total).IsRequired().HasColumnName("Total");

            HasRequired(oi => oi.Order).WithMany(o => o.Id).HasForeignKey(oi => oi.OrderId);
            HasRequired(oi => oi.Equipment).WithMany(e => e.OrderItems).HasForeignKey(oi => oi.EquipmentId);
        }
    }
}
