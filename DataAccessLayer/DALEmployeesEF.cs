using DataAccessLayer.Model;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DataAccessLayer
{
    public class DALEmployeesEF : IDALEmployees
    {
        private EntityConexion dbContext = new EntityConexion();

        public void AddEmployee(Employee emp)
        {
            if (emp.GetType() == typeof(FullTimeEmployee))
            {
                FullTimeEmployee empFT = (FullTimeEmployee)emp;
                FullTimeEmployeeTPH empFTTPH = new FullTimeEmployeeTPH();
                empFTTPH.Name = empFT.Name;
                empFTTPH.START_DATE = empFT.StartDate;
                empFTTPH.SALARY = empFT.Salary;

                dbContext.EmployeesTPH.Add(empFTTPH);

            }
            else if (emp.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee empPT = (PartTimeEmployee)emp;
                PartTimeEmployeeTPH empPTTPH = new PartTimeEmployeeTPH();
                empPTTPH.Name = empPT.Name;
                empPTTPH.START_DATE = empPT.StartDate;
                empPTTPH.RATE = empPT.HourlyRate;

                dbContext.EmployeesTPH.Add(empPTTPH);

            }
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception e) {
                e.GetBaseException();
            }
            
        }

        public void DeleteEmployee(int id)
        {
            dbContext.EmployeesTPH.Remove(GetEmployeeTPH(id));
            dbContext.SaveChanges();
        }

        //OJOOOOO
        public void UpdateEmployee(Employee emp)
        {
            Console.WriteLine(emp.GetType());

            if (emp.GetType() == typeof(FullTimeEmployee))
            {
                FullTimeEmployee empFT2 = (FullTimeEmployee)emp;
                EmployeesTPH empFTPH = dbContext.EmployeesTPH.Find(emp.Id);
                FullTimeEmployeeTPH empFT = (FullTimeEmployeeTPH)empFTPH;                
                empFT.Name = emp.Name;
                empFT.SALARY = empFT2.Salary;
                             
            }
            else if (emp.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee empPT = (PartTimeEmployee)emp;
                EmployeesTPH empTPH = dbContext.EmployeesTPH.Find(emp.Id);
                PartTimeEmployeeTPH emptPTTPH = (PartTimeEmployeeTPH)empTPH;
                emptPTTPH.Name = emp.Name;
                emptPTTPH.RATE = empPT.HourlyRate;             
                
            }
            try
            {
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                e.GetBaseException();
            }
        }//finOJOOO

        public List<Employee> GetAllEmployees()
        {
            List<Employee> listReturn = new List<Employee>();
            List<EmployeesTPH> listBase = dbContext.EmployeesTPH.ToList();
            foreach (EmployeesTPH employeesTPH in listBase)
            {
                listReturn.Add(ConvertEmployeesTPHtoEmployees(employeesTPH));
            }
            return listReturn;
        }

        public Employee GetEmployee(int id)
        {
            return ConvertEmployeesTPHtoEmployees(GetEmployeeTPH(id));
        }

        private EmployeesTPH GetEmployeeTPH(int id)
        {
            EmployeesTPH employeesTPH= dbContext.EmployeesTPH.Where(n=> n.ID==id).First();
            return employeesTPH;
        }

        private Employee ConvertEmployeesTPHtoEmployees(EmployeesTPH emp)
        {
            if (emp.GetType() == typeof(FullTimeEmployeeTPH))
            {
                FullTimeEmployeeTPH employeeTPH = (FullTimeEmployeeTPH)emp;
                FullTimeEmployee employee = new FullTimeEmployee();
                employee.Id = employeeTPH.ID;
                employee.Name = employeeTPH.Name;
                employee.StartDate = employeeTPH.START_DATE;
                employee.Salary = (int)employeeTPH.SALARY;

                return employee;
            }
            else if (emp.GetType() == typeof(PartTimeEmployeeTPH))
            {
                PartTimeEmployeeTPH employeeTPH = (PartTimeEmployeeTPH)emp;
                PartTimeEmployee employee = new PartTimeEmployee();
                employee.Id = employeeTPH.ID;
                employee.Name = employeeTPH.Name;
                employee.StartDate = employeeTPH.START_DATE;
                employee.HourlyRate = (double)employeeTPH.RATE;

                return employee;
            }

            return null;
        }
    }
}
