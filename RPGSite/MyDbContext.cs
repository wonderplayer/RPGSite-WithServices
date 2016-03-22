using RPGSite.Configurations;
using RPGSite.Entities;
using System.Data.Entity;

namespace RPGSite
{
    public class MyDbContext : DbContext
    {
        static MyDbContext()
        {
            Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext() : base("Name=MyDbContext")
        {
        }

        public IDbSet<Equipment> Equipment { get; set; }

        public IDbSet<EquipmentRarity> EquipmentRarity { get; set; }

        public IDbSet<EquipmentType> EquipmentType { get; set; }

        public IDbSet<Inventory> Inventory { get; set; }

        public IDbSet<OrderItems> OrderItems { get; set; }

        public IDbSet<Orders> Orders { get; set; }

        public IDbSet<SecretQuestions> SecretQuestions { get; set; }

        public IDbSet<Users> Users { get; set; }

        public IDbSet<UserTypes> UserTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new EquipmentConfiguration());
            modelBuilder.Configurations.Add(new EquipmentRarityConfiguration());
            modelBuilder.Configurations.Add(new EquipmentTypeConfiguration());
            modelBuilder.Configurations.Add(new InventoryConfiguration());
            modelBuilder.Configurations.Add(new OrderItemsConfiguration());
            modelBuilder.Configurations.Add(new OrdersConfiguration());
            modelBuilder.Configurations.Add(new SecretQuestionsConfiguration());
            modelBuilder.Configurations.Add(new UsersConfiguration());
            modelBuilder.Configurations.Add(new UserTypesConfiguration());
        }
    }
}
