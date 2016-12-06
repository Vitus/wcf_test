using System.Runtime.Serialization;

namespace wcf_host.models.V2
{
    [DataContract]
    public class AnotherWorkRequest
    {
        [DataMember]
        public short InstanceId { get; set; }

        [DataMember]
        public short CompanyId { get; set; }
    }
}