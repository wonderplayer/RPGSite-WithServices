using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class EquipmentRarityConfiguration : EntityTypeConfiguration<EquipmentRarity>
    {
        public EquipmentRarityConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".EquipmentRarity");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Rarity).IsRequired().HasColumnName("Rarity").HasMaxLength(20);
        }
    }
}
