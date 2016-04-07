using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayerWinform.ServiceEmployees;
using PresentationLayerWinform.Models;

namespace PresentationLayerWinform
{
    public partial class EmployeeAddEdit : Form
    {


        public EmployeeAddEdit()
        {
            InitializeComponent();
        }



        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {
            inputTipo.Items.Add(Constantes.StrFullTimeEmployee);
            inputTipo.Items.Add(Constantes.StrPartTimeEmployee);
            inputTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Crear_Empleados(object sender, EventArgs e)
        {
            if (this.validateData()) {
                ServiceEmployeesClient servicio = new ServiceEmployeesClient();
                if (inputTipo.Text.Equals(Constantes.StrFullTimeEmployee))
                {
                    FullTimeEmployee emp = new FullTimeEmployee();
                    emp.Name = inputNombre.Text;
                    emp.StartDate = DateTime.Parse(inputFechaIngreso.Text);
                    emp.Salary = Int32.Parse(inputSalario.Text);
                    servicio.AddEmployee(emp);
                }
                else if(inputTipo.Text.Equals(Constantes.StrPartTimeEmployee))
                {
                    PartTimeEmployee emp = new PartTimeEmployee();
                    emp.Name = inputNombre.Text;
                    emp.StartDate = DateTime.Parse(inputFechaIngreso.Text);
                    emp.HourlyRate = Double.Parse(inputTarifa.Text);
                    servicio.AddEmployee(emp);
                }
                MessageBox.Show("El empleado ha sido correctamente registrado", "Va Pa eeee", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void comboBox1_ValueMemberChanged(object sender, EventArgs e)
        {
            if (inputTipo.Text.Equals(Constantes.StrFullTimeEmployee))
            {
                inputTarifa.Enabled = false;
                inputSalario.Enabled = true;
            }
            else if (inputTipo.Text.Equals(Constantes.StrPartTimeEmployee)) {
                inputTarifa.Enabled = true;
                inputSalario.Enabled = false;
            }

        }

        private void inputSalario_EnabledChanged(object sender, EventArgs e)
        {
            inputSalario.Text = "";
        }

        private void inputTarifa_EnabledChanged(object sender, EventArgs e)
        {
            inputTarifa.Text = "";
        }

        private void Guardar_Datos(object sender, EventArgs e) {

        }

        private bool validateData() {
            int testSalario;
            double testTarifa;
            bool dataValida = true;
            if (inputTipo.Text.Equals(""))
            {
                dataValida = false;
                MessageBox.Show("Tipo no puede ser vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (inputNombre.Text.Equals(""))
            {
                dataValida = false;
                MessageBox.Show("Nombre no puede ser vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
            else if (inputTipo.Text.Equals(Constantes.StrFullTimeEmployee))
            {
                if (inputSalario.Text.Equals(""))
                {
                    dataValida = false;
                    MessageBox.Show("Salario no puede ser vacío si el tipo es " + Constantes.StrFullTimeEmployee, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Int32.TryParse(inputSalario.Text, out testSalario))
                {
                    dataValida = false;
                    MessageBox.Show("Salario debe ser un numero entero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (inputTipo.Text.Equals(Constantes.StrPartTimeEmployee))
            {
                if (inputTarifa.Text.Equals(""))
                {
                    dataValida = false;
                    MessageBox.Show("Salario no puede ser vacío si el tipo es " + Constantes.StrPartTimeEmployee, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!Double.TryParse(inputTarifa.Text, out testTarifa))
                {
                    dataValida = false;
                    MessageBox.Show("Tarifa debe ser un numero (acepta decimales)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (inputFechaIngreso.Text.Equals(""))
            {
                dataValida = false;
                MessageBox.Show("Fecha Ingreso no puede ser vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataValida;
        }

    }
}
