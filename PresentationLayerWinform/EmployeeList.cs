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
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            
            ServiceEmployeesClient servicio= new ServiceEmployeesClient();
            Employee[] employees = servicio.GetAllEmployees();
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
    }
}
