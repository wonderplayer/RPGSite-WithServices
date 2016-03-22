using Services.DataContracts;
using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        bool FindUserInDB(string email, string password);

        [OperationContract]
        UserInfo GetUserInfo(int Id);
    }
}
