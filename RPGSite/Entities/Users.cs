using System.Collections.Generic;

namespace RPGSite.Entities
{
    public class Users
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public byte SecretQuestionId { get; set; }
        
        public string SecretAnswer { get; set; }

        public bool Blocked { get; set; }

        public byte TypeId { get; set; }

        public byte[] Picture { get; set; }

        public virtual UserTypes UserTypes { get; set; }

        public virtual SecretQuestions SecretQuestion { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }

        public virtual ICollection<Inventory> Inventory { get; set; }

        //    public virtual ICollection<Comments> Comments { get; set; }

        //    public virtual ICollection<Events> Events { get; set; }

        //    public virtual ICollection<Gallery> Gallery { get; set; }

        //    public virtual ICollection<Messages> Messages { get; set; }  

        //    public virtual ICollection<Posts> Posts { get; set; }

        //    public virtual ICollection<Trades> Trades { get; set; }
    }
}
