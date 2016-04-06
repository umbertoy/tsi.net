using DataAccessLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            /*PartTimeEmployee part = new PartTimeEmployee();
            part.Name = "prueba2";
            part.HourlyRate = 12;
            part.StartDate = System.DateTime.Now;
            DALEmployeesMongo dal = new DALEmployeesMongo();
            dal.AddEmployee(part);
            DALEmployeesMongo dal = new DALEmployeesMongo();
            dal.DeleteEmployee(5);*/
            DALEmployeesEF dal = new DALEmployeesEF();
            Employee emp = dal.GetEmployee(1);


            System.Console.WriteLine("hola mundo "+args.Length);
        }
    }
}
