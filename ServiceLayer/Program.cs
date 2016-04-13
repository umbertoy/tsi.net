using BusinessLogicLayer;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace ServiceLayer
{
    class Program
    {
        public static IBLEmployees blHandler;

        static void Main(string[] args)
        {
            SetupDependencies();
            SetupService();
        }

        private static void SetupDependencies()
        {
            IUnityContainer container = new UnityContainer();
            blHandler = container.LoadConfiguration("containerOne").Resolve<IBLEmployees>();
        }


        private static void SetupService()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Name = "pruebaBinding";
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.Security.Mode = BasicHttpSecurityMode.None;

            Uri baseAddress = new Uri("http://localhost:8834/tsi1");
            Uri address = new Uri("http://localhost:8834/tsi1/Employees");

            ServiceHost serviceHost = new ServiceHost(typeof(ServiceEmployees), baseAddress);
            serviceHost.AddServiceEndpoint(typeof(IServiceEmployees), binding, address);

            ServiceMetadataBehavior metadatos = new ServiceMetadataBehavior();
            metadatos.HttpGetEnabled = true;
            serviceHost.Description.Behaviors.Add(metadatos);

            serviceHost.Open();

            // The service can now be accessed.
            Console.WriteLine("The service is ready.");
            Console.WriteLine("Press <ENTER> to terminate service.");
            Console.WriteLine();
            Console.ReadLine();

            // Close the ServiceHostBase to shutdown the service.
            serviceHost.Close();
        }
    }
}
