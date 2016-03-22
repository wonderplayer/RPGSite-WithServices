using RPGSite.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RPGSite.Configurations
{
    public class SecretQuestionsConfiguration : EntityTypeConfiguration<SecretQuestions>
    {
        public SecretQuestionsConfiguration(string schema = "dbo")
        {
            ToTable(schema + ".SecretQuestions");

            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired().HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.Question).IsRequired().HasColumnName("Question").HasMaxLength(50);
        }
    }
}
