using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class UserTypes
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
