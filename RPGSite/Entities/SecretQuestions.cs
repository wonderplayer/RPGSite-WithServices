using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class SecretQuestions
    {
        public byte Id { get; set; }

        public string Question { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
