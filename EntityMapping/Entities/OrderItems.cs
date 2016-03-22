namespace RPGSite.Entities
{
    public class OrderItems
    {

        public int Id { get; set; }

        public int OrderId { get; set; }

        public int EquipmentId { get; set; }

        public byte Quantity { get; set; }

        public int Total { get; set; }

        public virtual Orders Order { get; set; }

        public virtual Equipment Equipment { get; set; }
    }
}
