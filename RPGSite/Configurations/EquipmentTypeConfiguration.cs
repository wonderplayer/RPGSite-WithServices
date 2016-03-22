using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class EquipmentTypeConfiguration : EntityTypeConfiguration<EquipmentType>
    {
        public EquipmentTypeConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".EquipmentType");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Type).IsRequired().HasColumnName("Type").HasMaxLength(20);
        }
    }
}
