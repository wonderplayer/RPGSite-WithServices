namespace RPGSite.Entities
{
    public class Inventory
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int EquipmentId { get; set; }

        public short Quantity { get; set; }

        public virtual Users User { get; set; }

        public virtual Equipment Equipment { get; set; }
    }
}
