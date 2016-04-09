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
            ventana.Controls["bGuardar"].Visible = false;
            ventana.Show();

        }

        private void Modificar_Empleados(object sender, EventArgs e)
        {
            ServiceEmployeesClient servicio = new ServiceEmployeesClient();
            EmployeeAddEdit ventana = new EmployeeAddEdit();
            var row = GrillaEmpleados.CurrentRow;
            var txt1 = ventana.Controls["inputNombre"];
            var txt2 = ventana.Controls["inputTipo"];
            var txt3 = ventana.Controls["LTipo"];
            var txt4 = ventana.Controls["inputTarifa"];
            var txt5 = ventana.Controls["inputSalario"];
            txt1.Text = row.Cells[1].Value.ToString();
            txt2.Text = row.Cells[3].Value.ToString();
            ventana.Controls["bCrear"].Visible = false;
            //txt2.Enabled = false;

            //txt2.Visible = false;
            //txt3.Visible = false;

            if (txt2.Equals(Constantes.StrFullTimeEmployee))
            {                              
                txt4.Visible = false;
                txt5.Visible = true;               
            }
            else if (txt2.Equals(Constantes.StrPartTimeEmployee))
            {
                txt4.Visible = true;
                txt5.Visible = false;
            }
            //ventana.Controls["inputTipo"] = txt1.Text;
            //if(ventana.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    row.Cells[3].Value = txt1.Text;
            //}
            ventana.ShowDialog();
        }



        private void Eliminar_Empleados(object sender, EventArgs e)
        {
            var row = GrillaEmpleados.CurrentRow;
            

            //ELIMINAR DE SQL
            ServiceEmployeesClient servicio = new ServiceEmployeesClient();
            servicio.DeleteEmployee(int.Parse(row.Cells[0].Value.ToString()));

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
