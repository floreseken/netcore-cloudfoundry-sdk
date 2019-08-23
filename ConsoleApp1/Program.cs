using CloudFoundry.CloudController.V3.Client;
using CloudFoundry.CloudController.V3.Client.Helpers;
using CloudFoundry.CloudController.V3.Client.Model;
using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("Hello CF!");

                var cloudFoundryClient = new CloudFoundryClient(new Uri("https://api.system.cf.singel.home"), CancellationToken.None);

                cloudFoundryClient.Login("feken", "***").Wait();

                var createResponse = cloudFoundryClient.AppsExperimental.CreateApp("api-created-app", new Guid("ef1c944d-c7ec-4ceb-8177-317130a005da") ).Result;

                var appResponse = cloudFoundryClient.AppsExperimental.GetApp(createResponse.guid).Result;


                cloudFoundryClient.AppsExperimental.PushProgress += AppsExperimental_PushProgress;

                cloudFoundryClient.AppsExperimental.Push(createResponse.guid.Value, @"C:\test\tozip\", null, null, true, 0, 0).Wait();

                //cloudFoundryClient.AppsExperimental.DeleteApp(appResponse.Guid.Value).Wait();

                var rep = cloudFoundryClient.AppsExperimental.GetApp(appResponse.guid.Value).Result;

                var fpa = cloudFoundryClient.AppsExperimental.ListAssociatedProcesses(appResponse.guid).Result;

            }

        }

        private static void AppsExperimental_PushProgress(object sender, PushProgressEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}
