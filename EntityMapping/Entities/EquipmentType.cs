using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class EquipmentType
    {
        public byte Id { get; set; }

        public string Type { get; set; }

        public ICollection<Equipment> Equipment { get; set; }
    }
}
