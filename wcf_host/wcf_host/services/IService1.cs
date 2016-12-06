using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcf_host.models.V1;

namespace wcf_host.services.V1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string DoWork(TierRequest request);

        [OperationContract]
        string DoDifferentRequestFormatWork(DifferentFormatRequest request);
    }
}
