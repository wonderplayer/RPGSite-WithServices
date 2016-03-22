using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class EquipmentConfiguration : EntityTypeConfiguration<Equipment>
    {
        public EquipmentConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Equipment");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Title).IsRequired().HasColumnName("Title").HasMaxLength(50);
            Property(x => x.Description).IsRequired().HasColumnName("Description").HasMaxLength(1000);
            Property(x => x.TypeId).IsRequired().HasColumnName("TypeId");
            Property(x => x.RarityId).IsRequired().HasColumnName("RarityId");
            Property(x => x.Price).IsRequired().HasColumnName("Price");
            Property(x => x.Picture).IsOptional().HasColumnName("Picture");

            HasRequired(e => e.Type).WithMany(et => et.Equipment).HasForeignKey(e => e.TypeId);
            HasRequired(e => e.Rarity).WithMany(er => er.Equipment).HasForeignKey(e => e.RarityId);
        }
    }
}
