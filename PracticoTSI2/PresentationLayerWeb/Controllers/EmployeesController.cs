using BusinessLogicLayer;
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
            var listItems = new List<SelectListItem> { new SelectListItem { Text = "Full Time", Value = "1" }, new SelectListItem { Text = "Par time", Value = "2" }, };
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
            foreach(Employee employee in listEmployees ){
                
                listModel.Add(EmployeeToModel(employee));
            }

            return View(listModel);
        }

        // GET: Employees/Details/5
        public ActionResult Details(int id)
        {
            return View(EmployeeToModel(blHandler.GetEmployee(id)));
        }

        // GET: Employees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Edit/5
        public ActionResult Edit(int id)
        {
            return View(EmployeeToModel(blHandler.GetEmployee(id)));
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employees/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Chat()
        {
            return View();
        }
    }
}
