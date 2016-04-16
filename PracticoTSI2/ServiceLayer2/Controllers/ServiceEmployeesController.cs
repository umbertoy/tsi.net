using BusinessLogicLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServiceLayer2.Controllers
{
    [EnableCors(origins: "http://localhost:55306", headers: "*", methods: "*")]
    public class ServiceEmployeesController : ApiController
    {
        //// GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}
        public List<EmployeeREST> Get()
        {
            IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
            return blHandler.GetAllEmployeesREST();
        }

        //// GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        public Employee Get(int id)
        {
            IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
            return blHandler.GetEmployee(id);
        }



        public void Post(Employee emp)
        {
            IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
            blHandler.AddEmployee(emp);
        }

        public void Put(int id, Employee emp)
        {
            IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
            blHandler.UpdateEmployee(emp);
        }

        public void Delete(int id)
        {
            IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
            blHandler.DeleteEmployee(id);
        }

        public double CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
            return blHandler.CalcPartTimeEmployeeSalary(idEmployee, hours);
        }

        //// POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/<controller>/5
        //public void Delete(int id)
        //{
        //}


    }
}