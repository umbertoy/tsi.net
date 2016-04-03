namespace PresentationLayerWinform
{
    partial class EmployeeAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LNombre = new System.Windows.Forms.Label();
            this.LFecha = new System.Windows.Forms.Label();
            this.LSalario = new System.Windows.Forms.Label();
            this.LTipo = new System.Windows.Forms.Label();
            this.LTarifa = new System.Windows.Forms.Label();
            this.TextBox_Nombre = new System.Windows.Forms.TextBox();
            this.TextBox_Salario = new System.Windows.Forms.TextBox();
            this.TextBox_Tarifa = new System.Windows.Forms.TextBox();
            this.Combo_Empleados = new System.Windows.Forms.ComboBox();
            this.DatePicker_Empleados = new System.Windows.Forms.DateTimePicker();
            this.BCrear = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(23, 87);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(44, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LFecha
            // 
            this.LFecha.AutoSize = true;
            this.LFecha.Location = new System.Drawing.Point(23, 208);
            this.LFecha.Name = "LFecha";
            this.LFecha.Size = new System.Drawing.Size(75, 13);
            this.LFecha.TabIndex = 1;
            this.LFecha.Text = "Fecha Ingreso";
            // 
            // LSalario
            // 
            this.LSalario.AutoSize = true;
            this.LSalario.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LSalario.Location = new System.Drawing.Point(23, 123);
            this.LSalario.Name = "LSalario";
            this.LSalario.Size = new System.Drawing.Size(39, 13);
            this.LSalario.TabIndex = 2;
            this.LSalario.Text = "Salario";
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Location = new System.Drawing.Point(23, 46);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(28, 13);
            this.LTipo.TabIndex = 3;
            this.LTipo.Text = "Tipo";
            // 
            // LTarifa
            // 
            this.LTarifa.AutoSize = true;
            this.LTarifa.Location = new System.Drawing.Point(23, 159);
            this.LTarifa.Name = "LTarifa";
            this.LTarifa.Size = new System.Drawing.Size(34, 13);
            this.LTarifa.TabIndex = 4;
            this.LTarifa.Text = "Tarifa";
            // 
            // TextBox_Nombre
            // 
            this.TextBox_Nombre.Location = new System.Drawing.Point(92, 87);
            this.TextBox_Nombre.Name = "TextBox_Nombre";
            this.TextBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Nombre.TabIndex = 5;
            // 
            // TextBox_Salario
            // 
            this.TextBox_Salario.Location = new System.Drawing.Point(92, 123);
            this.TextBox_Salario.Name = "TextBox_Salario";
            this.TextBox_Salario.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Salario.TabIndex = 6;
            // 
            // TextBox_Tarifa
            // 
            this.TextBox_Tarifa.Location = new System.Drawing.Point(92, 159);
            this.TextBox_Tarifa.Name = "TextBox_Tarifa";
            this.TextBox_Tarifa.Size = new System.Drawing.Size(100, 20);
            this.TextBox_Tarifa.TabIndex = 7;
            // 
            // Combo_Empleados
            // 
            this.Combo_Empleados.FormattingEnabled = true;
            this.Combo_Empleados.Location = new System.Drawing.Point(92, 43);
            this.Combo_Empleados.Name = "Combo_Empleados";
            this.Combo_Empleados.Size = new System.Drawing.Size(121, 21);
            this.Combo_Empleados.TabIndex = 8;
            this.Combo_Empleados.Click += new System.EventHandler(this.Seleccionar_Tipo);
            // 
            // DatePicker_Empleados
            // 
            this.DatePicker_Empleados.Location = new System.Drawing.Point(115, 208);
            this.DatePicker_Empleados.Name = "DatePicker_Empleados";
            this.DatePicker_Empleados.Size = new System.Drawing.Size(200, 20);
            this.DatePicker_Empleados.TabIndex = 9;
            // 
            // BCrear
            // 
            this.BCrear.Location = new System.Drawing.Point(56, 257);
            this.BCrear.Name = "BCrear";
            this.BCrear.Size = new System.Drawing.Size(75, 23);
            this.BCrear.TabIndex = 10;
            this.BCrear.Text = "Crear";
            this.BCrear.UseVisualStyleBackColor = true;
            this.BCrear.Click += new System.EventHandler(this.Crear_Empleados);
            // 
            // BGuardar
            // 
            this.BGuardar.Location = new System.Drawing.Point(164, 257);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(83, 23);
            this.BGuardar.TabIndex = 11;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.Guardar_Datos);
            // 
            // EmployeeAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 311);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.BCrear);
            this.Controls.Add(this.DatePicker_Empleados);
            this.Controls.Add(this.Combo_Empleados);
            this.Controls.Add(this.TextBox_Tarifa);
            this.Controls.Add(this.TextBox_Salario);
            this.Controls.Add(this.TextBox_Nombre);
            this.Controls.Add(this.LTarifa);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.LSalario);
            this.Controls.Add(this.LFecha);
            this.Controls.Add(this.LNombre);
            this.Name = "EmployeeAddEdit";
            this.Text = "EmployeeAddEdit";
            this.Load += new System.EventHandler(this.EmployeeAddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LFecha;
        private System.Windows.Forms.Label LSalario;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.Label LTarifa;
        private System.Windows.Forms.TextBox TextBox_Nombre;
        private System.Windows.Forms.TextBox TextBox_Salario;
        private System.Windows.Forms.TextBox TextBox_Tarifa;
        private System.Windows.Forms.ComboBox Combo_Empleados;
        private System.Windows.Forms.DateTimePicker DatePicker_Empleados;
        private System.Windows.Forms.Button BCrear;
        private System.Windows.Forms.Button BGuardar;
    }
}