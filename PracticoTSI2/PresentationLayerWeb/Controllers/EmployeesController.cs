using BusinessLogicLayer;
using Microsoft.AspNet.SignalR;
using PresentationLayerWeb.Hubs;
using PresentationLayerWeb.Models;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb.Controllers
{
    public class EmployeesController : Controller
    {
        private IBLEmployees blHandler = new BLEmployees(new DataAccessLayer.DALEmployeesEF());
        // GET: Employees

        private EmployeeModel EmployeeToModel(Employee employee)
        {
            EmployeeModel model = new EmployeeModel();
            model.Id = employee.Id;
            model.Name = employee.Name;
            model.StartDate = employee.StartDate;
            var listItems = new List<SelectListItem> { new SelectListItem { Text = "Full Time", Value = "1" }, new SelectListItem { Text = "Part time", Value = "2" }, };
            model.listItems = listItems;
            if (employee.GetType() == typeof(FullTimeEmployee))
            {
                FullTimeEmployee empFT = (FullTimeEmployee)employee;
                model.Type = (listItems.ToArray())[0];
                model.Salary = empFT.Salary;
            }
            else if (employee.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee empPT = (PartTimeEmployee)employee;
                model.Type = (listItems.ToArray())[1];
                model.HourlyRate = empPT.HourlyRate;
            }
            return model;
        }

        public ActionResult Index()
        {
            List<Employee> listEmployees = blHandler.GetAllEmployees();
            List<EmployeeModel> listModel = new List<EmployeeModel>();
            foreach (Employee employee in listEmployees)
            {

                listModel.Add(EmployeeToModel(employee));
            }

            return View(listModel);
        }

        public ActionResult IndexAngular()
        {
            return View("SPA/employees/employee");
        }

        public ActionResult Chat()
        {
            return View();
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            return View(EmployeeToModel(blHandler.GetEmployee(id)));
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            EmployeeModel model = new EmployeeModel();
            var listItems = new List<SelectListItem> { new SelectListItem { Text = "Full Time", Value = "1" }, new SelectListItem { Text = "Part time", Value = "2" }, };
            model.listItems = listItems;
            return View(model);
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                if (collection.Get("Type").Equals("1"))
                {
                    FullTimeEmployee emp = new FullTimeEmployee();
                    emp.Name = collection.Get("Name");
                    emp.Salary = int.Parse(collection.Get("Salary"));
                    var a = collection.Get("StartDate");
                    if (collection.Get("StartDate").IndexOf('/') == 2)
                    {
                        a = collection.Get("StartDate").Substring(3, 3) + collection.Get("StartDate").Substring(0, 2) + collection.Get("StartDate").Substring(5) + " 00:00:00";
                    }
                    emp.StartDate = Convert.ToDateTime(a);
                    blHandler.AddEmployee(emp);
                }
                else
                {
                    PartTimeEmployee emp = new PartTimeEmployee();
                    emp.Name = collection.Get("Name");
                    emp.HourlyRate = int.Parse(collection.Get("HourlyRate"));
                    var a = collection.Get("StartDate");
                    if (collection.Get("StartDate").IndexOf('/') == 2)
                    {
                        a = collection.Get("StartDate").Substring(3, 3) + collection.Get("StartDate").Substring(0, 2) + collection.Get("StartDate").Substring(5) + " 00:00:00";
                    }
                    emp.StartDate = Convert.ToDateTime(a);
                    blHandler.AddEmployee(emp);
                }
                else if (collection.Get("Type").Equals("2"))
                {
                    PartTimeEmployee emp = new PartTimeEmployee();
                    emp.Name = collection.Get("Name");
                    emp.HourlyRate = int.Parse(collection.Get("HourlyRate"));
                    var a = collection.Get("StartDate");
                    if (collection.Get("StartDate").IndexOf('/') == 2)
                    {
                        a = collection.Get("StartDate").Substring(3, 3) + collection.Get("StartDate").Substring(0, 2) + collection.Get("StartDate").Substring(5) + " 00:00:00";
                    }


                    emp.StartDate = Convert.ToDateTime(a);
                    blHandler.AddEmployee(emp);
                }

                var connection = GlobalHost.ConnectionManager.GetHubContext<tsi1Hub>();

                connection.Clients.All.addNewMessageToPage("Se creo un nuevo empleado");
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            EmployeeModel model = new EmployeeModel();
            Employee employee = blHandler.GetEmployee(id);
            if (employee.GetType() == typeof(FullTimeEmployee))
            {
                FullTimeEmployee empFT = (FullTimeEmployee)employee;
                model.Id = empFT.Id;
                model.Name = empFT.Name;
                model.Salary = empFT.Salary;
                model.StartDate = empFT.StartDate;
                var listItems = new List<SelectListItem> { new SelectListItem { Text = "Full Time", Value = "1" }, };
                model.listItems = listItems;
                
            }
            else if (employee.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee empFT = (PartTimeEmployee)employee;
                
                model.Id = empFT.Id;
                model.Name = empFT.Name;
                model.HourlyRate = empFT.HourlyRate;
                model.StartDate = empFT.StartDate;
                var listItems = new List<SelectListItem> { new SelectListItem { Text = "Part Time", Value = "2" }, };
                model.listItems = listItems;                
            }

            return View(model);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            if (collection.Get("Type").Equals("1"))
            {

                FullTimeEmployee emp = (FullTimeEmployee)blHandler.GetEmployee(id);
                emp.Name = collection.Get("Name");
                emp.Salary = int.Parse(collection.Get("Salary"));
                var a = collection.Get("StartDate");
                if (!collection.Get("StartDate").Contains(':'))
                {
                    a = collection.Get("StartDate").Substring(3, 3) + collection.Get("StartDate").Substring(0, 2) + collection.Get("StartDate").Substring(5) + " 00:00:00";
                }
                emp.StartDate = Convert.ToDateTime(a);
                blHandler.UpdateEmployee(emp);
            }
            
            else if (collection.Get("Type").Equals("2"))
            {
                PartTimeEmployee emp = (PartTimeEmployee)blHandler.GetEmployee(id);
                emp.Name = collection.Get("Name");
                emp.HourlyRate = int.Parse(collection.Get("HourlyRate"));
                var a = collection.Get("StartDate");
                if (!collection.Get("StartDate").Contains(':'))
                {
                    a = collection.Get("StartDate").Substring(3, 3) + collection.Get("StartDate").Substring(0, 2) + collection.Get("StartDate").Substring(5) + " 00:00:00";
                }
                emp.StartDate = Convert.ToDateTime(a);
                blHandler.UpdateEmployee(emp);
            }
            return RedirectToAction("Index");
        }


        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            blHandler.DeleteEmployee(id);
            return RedirectToAction("Index");
        }

        //// POST: Employees/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
