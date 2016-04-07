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
            foreach(Employee empleado in employees)
            {
                bindingSource1.Add(empleado);
            }
            //inicializar
            GrillaEmpleados.AllowUserToAddRows = false;
            GrillaEmpleados.EditMode = DataGridViewEditMode.EditProgrammatically;
            GrillaEmpleados.AutoGenerateColumns = false;
            GrillaEmpleados.AutoSize = true;
            GrillaEmpleados.DataSource = bindingSource1;


            agregar_columna("id", "Id");
            agregar_columna("Nombre", "Name");
            agregar_columna("Fecha Ingreso", "StartDate");

            //hacer lo que venga

        }

        private void Listar_Empleados(object sender, EventArgs e)
        {

        }

        private void Actualizar_Empleados(object sender, EventArgs e)
        {

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

        }

        private void agregar_columna(string nombrecolumna, string nombrepropiedad)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = nombrepropiedad;
            column.Name = nombrepropiedad;
            GrillaEmpleados.Columns.Add(column);
        }
    }
}
