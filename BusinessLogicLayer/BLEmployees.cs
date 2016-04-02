using DataAccessLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLEmployees : IBLEmployees
    {
        private IDALEmployees _dal;

        public BLEmployees()
        {
            _dal = new DALEmployeesEF();
        }


        public BLEmployees(IDALEmployees dal)
        {
            _dal = dal;
        }

        public void AddEmployee(Employee emp)
        {
            try
            {
                _dal.AddEmployee(emp);
            }
            catch (Exception e)
            {
                throw new BusinessException("Error desconocido", e);
            }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                _dal.DeleteEmployee(id);
            }
            catch (Exception e)
            {
                throw new BusinessException("Error desconocido", e);
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            try
            {
                _dal.UpdateEmployee(emp);
            }
            catch (Exception e)
            {
                throw new BusinessException("Error desconocido", e);
            }
        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                return _dal.GetAllEmployees();
            }
            catch (Exception e)
            {
                throw new BusinessException("Error desconocido", e);
            }
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                return _dal.GetEmployee(id);
            }
            catch (Exception e)
            {
                throw new BusinessException("Error desconocido", e);
            }
        }

        public double CalcPartTimeEmployeeSalary(int idEmployee, int hours)
        {
            Employee emp = GetEmployee(idEmployee);
            if (emp != null || emp.GetType() == typeof(PartTimeEmployee))
            {
                PartTimeEmployee pre = (PartTimeEmployee)emp;
                return hours * pre.HourlyRate;
            }

            throw new BusinessException("No es un empleado valido");
        }
    }
}
