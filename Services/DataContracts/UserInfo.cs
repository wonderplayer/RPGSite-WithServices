using System.Runtime.Serialization;

namespace Services.DataContracts
{
    [DataContract]
    public class UserInfo
    {
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public byte TypeId { get; set; }

        [DataMember]
        public byte SecretQuestionId { get; set; }

        [DataMember]
        public string SecretAnswer { get; set; }

        [DataMember]
        public bool Blocked { get; set; }

        [DataMember]
        public byte[] Picture { get; set; }
    }
}