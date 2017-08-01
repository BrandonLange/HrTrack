using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace HrTrackServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Initialising AutoMapper...");

                Startup.InitialiseAutoMapper autoMapperInit = new Startup.InitialiseAutoMapper();
                autoMapperInit.StartAutoMapper();

                Console.WriteLine("Starting Service...");
                ServiceHandler.StartServices();

                Console.ReadLine();
            }
            catch(Exception exc)
            {
                Console.Write("There was an issue starting the service. Error: " + exc.Message);
                Console.ReadKey();
            }
        }
    }
}
