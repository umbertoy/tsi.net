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
            FullTimeEmployee saveEmp = new FullTimeEmployee();
            saveEmp.Name = "RoboMongo";
            saveEmp.StartDate = DateTime.UtcNow.Date;
            saveEmp.Salary = 1000;
            dal.AddEmployee(saveEmp);
            Employee emp = dal.GetEmployee(1);
            
            System.Console.WriteLine("id del puto este: " + emp.Id);
            System.Console.WriteLine("nombre del puto este: "+ emp.Name);
            System.Console.WriteLine("el puto este arranco: " + emp.StartDate);
            System.Console.WriteLine("el puto este cobra: " + ((FullTimeEmployee)emp).Salary);

        }
    }
}
