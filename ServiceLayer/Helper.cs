﻿using BusinessLogicLayer;
//using DataAccessLayer;
using Microsoft.Practices.Unity;

namespace ServiceLayer
{
    public static class Helper
    {
        public static void RegisterTypes(UnityContainer container)
        {
            ////register the concrete implementation for interfaces
            //container.RegisterType<IDALEmployees, DALEmployeesEF>();
            //container.RegisterType<IBLEmployees, BLEmployees>();

            ////register a singleton for DAL
            //DALEmployeesEF dalEmployeesEF = new DALEmployeesEF();
            //container.RegisterInstance(dalEmployeesEF);

            ////register a singleton for BL
            //BLEmployees blEmployees = new BLEmployees(container.Resolve<IDALEmployees>());
            //container.RegisterInstance(blEmployees);
        }

    }
}
