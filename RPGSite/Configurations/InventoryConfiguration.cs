using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class InventoryConfiguration : EntityTypeConfiguration<Inventory>
    {
        public InventoryConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Inventory");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.UserId).IsOptional();
            Property(x => x.EquipmentId).IsOptional();
            Property(x => x.Quantity).IsRequired();

            HasRequired(i => i.Equipment).WithMany(e => e.Inventories).HasForeignKey(i => i.EquipmentId);
            HasRequired(i => i.User).WithMany(u => u.Inventory).HasForeignKey(i => i.UserId);
        }
    }
}
