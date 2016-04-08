using PresentationLayerWinform.Models;
using PresentationLayerWinform.ServiceEmployees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    public partial class EmployeeList : Form
    {

        private BindingSource bindingSource1 = new BindingSource();



        //GrillaEmpleados



        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            
            ServiceEmployeesClient servicio= new ServiceEmployeesClient();
            Employee[] employees = servicio.GetAllEmployees();
            bindingSource1.DataSource = typeof(EmployeeData);
            foreach (Employee empleado in employees)
            {
                EmployeeData employeeData= loadEmployeeData(empleado);
                try
                {
                    
                    bindingSource1.Add(employeeData);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                
            }

            GrillaEmpleados.ScrollBars= ScrollBars.Vertical;
            
            //inicializar
            GrillaEmpleados.AllowUserToAddRows = false;
            GrillaEmpleados.EditMode = DataGridViewEditMode.EditProgrammatically;
            GrillaEmpleados.AutoGenerateColumns = false;
            GrillaEmpleados.AutoSize = true;
            GrillaEmpleados.DataSource = bindingSource1;


            agregar_columna("id", "id");
            agregar_columna("Nombre", "nombre");
            agregar_columna("Fecha Ingreso", "fechaIngreso");
            agregar_columna("Tipo","tipo");

            //hacer lo que venga

        }

        private void Listar_Empleados(object sender, EventArgs e)
        {
            
        }

        private void Actualizar_Empleados(object sender, EventArgs e)
        {
            GrillaEmpleados.Rows.Clear();
            ServiceEmployeesClient servicio = new ServiceEmployeesClient();
            Employee[] employees = servicio.GetAllEmployees();
            bindingSource1.DataSource = typeof(EmployeeData);
            foreach (Employee empleado in employees)
            {
                EmployeeData employeeData = loadEmployeeData(empleado);
                try
                {

                    bindingSource1.Add(employeeData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }
            //inicializar
            GrillaEmpleados.AllowUserToAddRows = false;
            GrillaEmpleados.EditMode = DataGridViewEditMode.EditProgrammatically;
            GrillaEmpleados.AutoGenerateColumns = false;
            GrillaEmpleados.AutoSize = true;
            GrillaEmpleados.DataSource = bindingSource1;


     
        }

        private void Agregar_Empleados(object sender, EventArgs e)
        {

            EmployeeAddEdit ventana = new EmployeeAddEdit();
            ventana.Show();

        }

        private void Modificar_Empleados(object sender, EventArgs e)
        {
            EmployeeAddEdit ventana = new EmployeeAddEdit();
            ventana.Show();
        }

        private void Eliminar_Empleados(object sender, EventArgs e)
        {
            var row = GrillaEmpleados.CurrentRow;
            GrillaEmpleados.Rows.Remove(row);
        }

        private void agregar_columna(string nombrecolumna, string nombrepropiedad)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = nombrepropiedad;
            column.Name = nombrepropiedad;
            GrillaEmpleados.Columns.Add(column);
        }
    
        private EmployeeData loadEmployeeData(Employee empleado)
        {
            EmployeeData employeeData = new EmployeeData();
            employeeData.id = empleado.Id;
            employeeData.nombre = empleado.Name;
            employeeData.fechaIngreso = empleado.StartDate;
            employeeData.tipo = empleado.GetType() == typeof(FullTimeEmployee) ? Constantes.StrFullTimeEmployee : Constantes.StrPartTimeEmployee;
            return employeeData;
        }
    }
}
