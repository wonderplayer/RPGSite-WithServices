using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class OrdersConfiguration : EntityTypeConfiguration<Orders>
    {
        public OrdersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Orders");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.OrderDate).IsRequired().HasColumnName("OrderDate");
            Property(x => x.UserId).IsRequired().HasColumnName("UserId");
            Property(x => x.Total).IsRequired().HasColumnName("Total");

            HasRequired(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);
        }
    }
}
