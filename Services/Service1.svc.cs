using RPGSite;
using System.Linq;
using Services.DataContracts;

namespace Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool FindUserInDB(string email, string password)
        {
            using(var ctx = new MyDbContext())
            {
                var user = ctx.Users
                    .Where(u => u.Email == email && u.Password == password)
                    .FirstOrDefault();
                if (user == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public UserInfo GetUserInfo(int Id)
        {
            var result = new UserInfo();
            using(var ctx = new MyDbContext())
            {
                var user = ctx.Users
                    .Where(u => u.Id == Id)
                    .FirstOrDefault();
                result.Username = user.Username;
                result.Password = user.Password;
                result.Email = user.Email;
                result.SecretQuestionId = user.SecretQuestionId;
                result.SecretAnswer = user.SecretAnswer;
                result.TypeId = user.TypeId;
                result.Picture = user.Picture;
                return result;
            }
        }
    }
}
