using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcf_host.models.V2;
using wcf_host.services.V2;

namespace wcf_host.services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service2.svc or Service2.svc.cs at the Solution Explorer and start debugging.
    public class Service2 : IService
    {
        public string DoWork(TierRequest request)
        {
            return "Service 2 echo reply: InstanceId = " + request.InstanceId;
        }

        public string DoAnotherWork(AnotherWorkRequest request)
        {
            return $"Service 2 DoAnotherWork(): InstanceId = {request.InstanceId}, CompanyId = {request.CompanyId}";
        }

        public string DoDifferentRequestFormatWork(DifferentFormatRequest request)
        {
            return $"Service 2 DoDifferentRequestFormatWork(): InstanceId = {request.InstanceId}";
        }
    }
}
