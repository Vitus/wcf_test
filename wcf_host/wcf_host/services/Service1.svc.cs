using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcf_host.models.V1;
using wcf_host.services.V1;

namespace wcf_host.services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService
    {
        public string DoWork(TierRequest request)
        {
            return "Service 1 echo reply: InstanceId = " + request.InstanceId;
        }

        public string DoDifferentRequestFormatWork(DifferentFormatRequest request)
        {
            return $"Service 1 DoDifferentRequestFormatWork(): CompanyName = {request.CompanyName}";
        }
    }
}
