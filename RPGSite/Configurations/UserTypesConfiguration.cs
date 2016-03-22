using RPGSite.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGSite.Configurations
{
    public class UserTypesConfiguration : EntityTypeConfiguration<UserTypes>
    {
        public UserTypesConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".UserTypes");

            HasKey(x => x.Id);

            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Type).IsRequired().HasColumnName("Type").HasMaxLength(20);
        }
    }
}
