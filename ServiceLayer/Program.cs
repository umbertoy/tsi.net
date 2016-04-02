﻿using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

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
            blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
        }

        private static void SetupService()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Name = "pruebaBinding";
            binding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            binding.Security.Mode = BasicHttpSecurityMode.None;

            Uri baseAddress = new Uri("http://127.0.0.1:8181/tsi-net-01/service");
            Uri address = new Uri("http://127.0.0.1:8181/tsi-net-01/service/Employees");

            ServiceHost serviceHost = new ServiceHost(typeof(ServiceEmployees), baseAddress);
            serviceHost.AddServiceEndpoint(typeof(IServiceEmployees), binding, address);
            serviceHost.Open();
        }
    }
}