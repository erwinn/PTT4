using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using MyServiceContract;

namespace Service
{
    class Program
    {
        public static void Main()
        {
            // create a hosting process for CalculatorService
            ServiceHost host = new ServiceHost(typeof(CService));

            // start hosting
            host.Open();

            // The service can now be accessed.
            Console.WriteLine("The service is being hosted");
            Console.WriteLine("Press <ENTER> to stop hosting.\n");
            Console.ReadLine();

            // stop hosting
            host.Close();

        }
    }
}
