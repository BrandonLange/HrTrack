using HrTrackServiceHost.CORS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace HrTrackServiceHost
{
    public class ServiceHandler
    {
        private static WebServiceHost s_HrTrackServiceRest = null;

        public static void StartServices()
        {
            Console.WriteLine("Starting Service...");

            try
            {
                s_HrTrackServiceRest = new WebServiceHost(typeof(HrTrackService.HrTrackService.HrTrackService));
                foreach (ServiceEndpoint EP in s_HrTrackServiceRest.Description.Endpoints)
                    EP.Behaviors.Add(new BehaviorAttribute());
                s_HrTrackServiceRest.Open();
                Console.WriteLine("HrTrack Service REST Started : " + s_HrTrackServiceRest.BaseAddresses.ElementAt(0).AbsoluteUri.ToString());
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error starting rest service: " + exc.Message);
            }
        }
    }
}
