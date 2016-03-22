using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class EquipmentRarity
    {
        public byte Id { get; set; }

        public string Rarity { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
    }
}
