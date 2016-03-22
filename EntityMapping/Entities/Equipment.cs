using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class Equipment
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public byte TypeId { get; set; }

        public byte RarityId { get; set; }

        public short Price { get; set; }

        public byte[] Picture { get; set; }

        public virtual EquipmentType Type { get; set; }

        public virtual EquipmentRarity Rarity { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }


    }
}
