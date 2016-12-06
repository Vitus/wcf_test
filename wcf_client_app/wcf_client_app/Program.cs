using System;
using wcf_client_app.test_svc;

namespace wcf_client_app
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new test_svc.ServiceClient())
            {
                string reply = 
                    //client.DoWork(new TierRequest() {InstanceId = 2});
                    //client.DoAnotherWork(new AnotherWorkRequest() { InstanceId = 22, CompanyId = 11 });
                    client.DoDifferentRequestFormatWork(new DifferentFormatRequest() { InstanceId = 1000 });

                Console.WriteLine(reply);
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
