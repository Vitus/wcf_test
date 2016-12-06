using System.Runtime.Serialization;

namespace wcf_host.models.V1
{
    [DataContract]
    public class TierRequest
    {
        [DataMember]
        public short InstanceId { get; set; }
    }
}