using System.Runtime.Serialization;

namespace wcf_host.models.V2
{
    [DataContract]
    public class DifferentFormatRequest
    {
        [DataMember]
        public short InstanceId { get; set; }
    }
}