using System.Runtime.Serialization;

namespace wcf_host.models.V1
{
    [DataContract]
    public class DifferentFormatRequest
    {
        [DataMember]
        public string CompanyName { get; set; }
    }
}