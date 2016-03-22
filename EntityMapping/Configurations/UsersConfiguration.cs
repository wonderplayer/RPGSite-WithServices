using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class UsersConfiguration : EntityTypeConfiguration<Users>
    {
        public UsersConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".Users");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Username).IsRequired().HasColumnName("Username").HasMaxLength(20);
            Property(x => x.Password).IsRequired().HasColumnName("Password").HasMaxLength(16);
            Property(x => x.Email).IsRequired().HasColumnName("Email").HasMaxLength(50);
            Property(x => x.SecretQuestionId).IsRequired().HasColumnName("SecretQuestionId");
            Property(x => x.SecretAnswer).IsRequired().HasColumnName("SecretAnswer").HasMaxLength(50);
            Property(x => x.Blocked).IsRequired().HasColumnName("Blocked");
            Property(x => x.TypeId).IsRequired().HasColumnName("TypeId");
            Property(x => x.Picture).IsRequired().HasColumnName("Picture");

            HasRequired(u => u.UserTypes).WithMany(ut => ut.Users).HasForeignKey(u => u.TypeId);
            HasRequired(u => u.SecretQuestion).WithMany(q => q.Users).HasForeignKey(u => u.SecretQuestionId);
        }
    }
}
